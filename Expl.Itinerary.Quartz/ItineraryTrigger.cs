using System;
using System.Collections.Generic;
using System.Linq;
using Quartz;
using Quartz.Util;

namespace Expl.Itinerary.Quartz {
   /// <summary>
   /// Quartz trigger class with Itinerary scheduling integration.
   /// </summary>
   public class ItineraryTrigger : Trigger {
      /// <summary>
      /// Itinerary schedule.
      /// </summary>
      private ISchedule schedule;

      /// <summary>
      /// Active schedule enumerator.
      /// </summary>
      private IEnumerator<TimedEvent> scheduleEnumerator;

      /// <summary>
      /// Last event time fired.
      /// </summary>
      private DateTime? lastEventTime = null;

      /// <summary>
      /// Next event time waiting to fire.
      /// </summary>
      private DateTime? nextEventTime = null;

      #region Constructors

      public ItineraryTrigger(string name, ISchedule schedule)
         : this(name, null, schedule, DateTime.UtcNow) { }

      public ItineraryTrigger(string name, ISchedule schedule, DateTime startTimeUtc)
         : this(name, null, schedule, startTimeUtc) { }

      public ItineraryTrigger(string name, string group, ISchedule schedule)
         : this(name, group, schedule, DateTime.UtcNow) { }

      public ItineraryTrigger(string name, string group, ISchedule schedule, DateTime startTimeUtc) {
         this.Name = name;
         this.Group = group;
         this.schedule = schedule;
         scheduleEnumerator = this.schedule.GetRange(startTimeUtc, DateTime.MaxValue).GetEnumerator();
      }

      #endregion

      /// <summary> 
      /// Returns the final UTC time at which the <see cref="ItineraryTrigger" /> will
      /// fire.
      /// At this time, this value is not calculated and only returns null.
      /// </summary>
      public override DateTime? FinalFireTimeUtc {
         get { return null; }
      }

      /// <summary>
      /// Tells whether this Trigger instance can handle events
      /// in millisecond precision.
      /// </summary>
      /// <value></value>
      public override bool HasMillisecondPrecision {
         get { return true; }
      }

      /// <summary>
      /// Called when the <see cref="IScheduler" /> has decided to 'fire'
      /// the trigger (Execute the associated <see cref="IJob" />), in order to
      /// give the <see cref="Trigger" /> a chance to update itself for its next
      /// triggering (if any).
      /// </summary>
      /// <seealso cref="JobExecutionException" />
      public override void Triggered(ICalendar cal) {
         lastEventTime = nextEventTime;

         // Advance enumerator.
         if (nextEventTime.HasValue) {
            if (!scheduleEnumerator.MoveNext()) {
               nextEventTime = null;
            }
            else {
               nextEventTime = scheduleEnumerator.Current.StartTime;
            }
         }
      }

      /// <summary>
      /// Called by the scheduler at the time a <see cref="Trigger" /> is first
      /// added to the scheduler, in order to have the <see cref="Trigger" />
      /// compute its first fire time, based on any associated calendar.
      /// <p>
      /// After this method has been called, <see cref="GetNextFireTimeUtc" />
      /// should return a valid answer.
      /// </p>
      /// </summary>
      /// <returns> 
      /// The first time at which the <see cref="Trigger" /> will be fired
      /// by the scheduler, which is also the same value <see cref="GetNextFireTimeUtc" />
      /// will return (until after the first firing of the <see cref="Trigger" />).
      /// </returns>
      public override DateTime? ComputeFirstFireTimeUtc(ICalendar cal) {
         do {
            if (!scheduleEnumerator.MoveNext()) {
               nextEventTime = null;
               break;
            }

            nextEventTime = scheduleEnumerator.Current.StartTime;
         } while (cal != null && !cal.IsTimeIncluded(scheduleEnumerator.Current.StartTime));

         return nextEventTime;
      }

      /// <summary> 
      /// Determines whether or not the <see cref="ItineraryTrigger" /> will occur
      /// again.
      /// </summary>
      public override bool GetMayFireAgain() {
         return nextEventTime.HasValue;
      }

      /// <summary>
      /// Returns the next time at which the <see cref="ItineraryTrigger" /> will
      /// fire. If the trigger will not fire again, <see langword="null" /> will be
      /// returned. The value returned is not guaranteed to be valid until after
      /// the <see cref="Trigger" /> has been added to the scheduler.
      /// </summary>
      public override DateTime? GetNextFireTimeUtc() {
         return nextEventTime;
      }

      /// <summary>
      /// Set the next UTC time at which the <see cref="ItineraryTrigger" /> should fire.
      /// <strong>This method should not be invoked by client code.</strong>
      /// </summary>
      public void SetNextFireTime(DateTime? fireTimeUtc) {
         nextEventTime = DateTimeUtil.AssumeUniversalTime(fireTimeUtc);

         // Restart enumerator with new range.
         if (fireTimeUtc.HasValue) {
            scheduleEnumerator = schedule.GetRange(fireTimeUtc.Value, DateTime.MaxValue).GetEnumerator();
         }
         else {
            scheduleEnumerator = null;
         }
      }

      /// <summary>
      /// Returns the previous time at which the <see cref="ItineraryTrigger" /> fired.
      /// If the trigger has not yet fired, <see langword="null" /> will be
      /// returned.
      /// </summary>
      public override DateTime? GetPreviousFireTimeUtc() {
         return lastEventTime;
      }

      /// <summary> 
      /// Returns the next UTC time at which the <see cref="ItineraryTrigger" /> will
      /// fire, after the given UTC time. If the trigger will not fire after the given
      /// time, <see langword="null" /> will be returned.
      /// </summary>
      public override DateTime? GetFireTimeAfter(DateTime? afterTime) {
         if (!afterTime.HasValue) return null;

         var nextEvent = schedule.GetRange(afterTime.Value, DateTime.MaxValue).FirstOrDefault(e => e.StartTime > afterTime);
         if (nextEvent == null) return null;
         else return nextEvent.StartTime;
      }

      /// <summary>
      /// Validates the misfire instruction.
      /// </summary>
      /// <param name="misfireInstruction">The misfire instruction.</param>
      /// <returns></returns>
      protected override bool ValidateMisfireInstruction(int misfireInstruction) {
         return
            misfireInstruction == ItineraryTriggerMisfireInstruction.RescheduleNowWithExistingCount ||
            misfireInstruction == ItineraryTriggerMisfireInstruction.RescheduleNowWithRemainingCount ||
            misfireInstruction == ItineraryTriggerMisfireInstruction.RescheduleNextWithExistingCount ||
            misfireInstruction == ItineraryTriggerMisfireInstruction.RescheduleNextWithRemainingCount;
      }

      /// <summary>
      /// Updates the <see cref="ItineraryTrigger" />'s state based on the
      /// MisfireInstruction value that was selected when the <see cref="ItineraryTrigger" />
      /// was created.
      /// </summary>
      public override void UpdateAfterMisfire(ICalendar cal) {
         var instr = MisfireInstruction;

         if (instr == ItineraryTriggerMisfireInstruction.RescheduleNextWithExistingCount) {
            // Drop missed events.  Resume schedule at the next event from from current time.
            var newFireTime = GetFireTimeAfter(DateTime.UtcNow);

            // Ensure event is in ICalendar.
            while (newFireTime.HasValue && cal != null && !cal.IsTimeIncluded(newFireTime.Value)) {
               newFireTime = GetFireTimeAfter(newFireTime);
            }

            SetNextFireTime(newFireTime);
         }
         else if (instr == ItineraryTriggerMisfireInstruction.RescheduleNextWithRemainingCount) {
            // Drop missed events.  Resume schedule from current time.
            // Track count of dropped events.
            var rangeStart = DateTime.UtcNow;
            var newFireTime = GetFireTimeAfter(rangeStart);

            // Ensure event is in ICalendar.
            while (newFireTime.HasValue && cal != null && !cal.IsTimeIncluded(newFireTime.Value)) {
               newFireTime = GetFireTimeAfter(newFireTime);
            }

            // Tally missed events.
            if (GetNextFireTimeUtc().HasValue) {
               TriggerCount += schedule.GetRange(GetNextFireTimeUtc().Value, rangeStart)
                  .Where(e => cal == null || cal.IsTimeIncluded(e.StartTime))
                  .Count();
            }

            SetNextFireTime(newFireTime);
         }
         else if (instr == ItineraryTriggerMisfireInstruction.RescheduleNowWithExistingCount) {
            // Drop missed events.  Trigger event now, then resume schedule from current time.
            SetNextFireTime(DateTime.UtcNow);
         }
         else if (instr == ItineraryTriggerMisfireInstruction.RescheduleNowWithRemainingCount) {
            // Drop missed events.  Resume schedule from current time.
            // Track count of dropped events.
            var newFireTime = DateTime.UtcNow;

            // Tally missed events.
            if (GetNextFireTimeUtc().HasValue) {
               TriggerCount += schedule.GetRange(GetNextFireTimeUtc().Value, newFireTime)
                  .Where(e => cal == null || cal.IsTimeIncluded(e.StartTime))
                  .Count();
            }

            SetNextFireTime(newFireTime);
         }
      }

      /// <summary>
      /// Updates the instance with new calendar.
      /// </summary>
      /// <param name="calendar">The calendar.</param>
      /// <param name="misfireThreshold">The misfire threshold.</param>
      public override void UpdateWithNewCalendar(ICalendar cal, TimeSpan misfireThreshold) {
         throw new NotImplementedException();
      }

      public int TriggerCount { get; private set; }
   }

   /// <summary>
   /// Trigger misfire instruction constants.
   /// </summary>
   public struct ItineraryTriggerMisfireInstruction {
      /// <summary>
      /// Drop missed events.  Resume schedule at the next event from from current time.
      /// </summary>
      public const int RescheduleNowWithExistingCount = 0xf000;

      /// <summary>
      /// Drop missed events.  Resume schedule from current time.
      /// Track count of dropped events.
      /// </summary>
      public const int RescheduleNowWithRemainingCount = 0xf001;

      /// <summary>
      /// Drop missed events.  Trigger event now, then resume schedule from current time.
      /// </summary>
      public const int RescheduleNextWithExistingCount = 0xf002;

      /// <summary>
      /// Drop missed events.  Resume schedule from current time.
      /// Track count of dropped events.
      /// </summary>
      public const int RescheduleNextWithRemainingCount = 0xf003;
   }
}
