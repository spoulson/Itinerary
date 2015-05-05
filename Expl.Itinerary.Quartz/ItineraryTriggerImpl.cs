using Quartz;
using Quartz.Impl.Triggers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Expl.Itinerary.Quartz {

   /// <summary>
   /// Quartz trigger interface for Itinerary scheduling integration.
   /// </summary>
   public interface IItineraryTrigger : ITrigger {
   }

   /// <summary>
   /// Quartz trigger class with Itinerary scheduling integration.
   /// </summary>
   public class ItineraryTriggerImpl : AbstractTrigger, IItineraryTrigger {

      /// <summary>
      /// Itinerary schedule.
      /// </summary>
      private readonly ISchedule schedule;

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

      public ItineraryTriggerImpl(ISchedule schedule)
         : this(schedule, DateTime.UtcNow) { }

      public ItineraryTriggerImpl(ISchedule schedule, DateTime startTimeUtc) {
         this.schedule = schedule;
         scheduleEnumerator = this.schedule.GetRange(startTimeUtc, DateTime.MaxValue).GetEnumerator();
      }

      #endregion Constructors

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
      /// Determines whether or not the <see cref="ItineraryTriggerImpl" /> will occur
      /// again.
      /// </summary>
      public override bool GetMayFireAgain() {
         return nextEventTime.HasValue;
      }

      /// <summary>
      /// Validates the misfire instruction.
      /// </summary>
      /// <param name="misfireInstruction">The misfire instruction.</param>
      /// <returns></returns>
      protected override bool ValidateMisfireInstruction(int misfireInstruction) {
         return misfireInstruction == ItineraryTriggerMisfireInstruction.DoNothing
            || misfireInstruction == ItineraryTriggerMisfireInstruction.FireOnceNow;
      }

      /// <summary>
      /// Updates the <see cref="ItineraryTriggerImpl" />'s state based on the
      /// MisfireInstruction value that was selected when the <see cref="ItineraryTriggerImpl" />
      /// was created.
      /// </summary>
      public override void UpdateAfterMisfire(ICalendar cal) {
         var instr = MisfireInstruction;

         if (instr == ItineraryTriggerMisfireInstruction.DoNothing) {
            // Drop missed events.  Resume schedule at the next event from from current time.
            var newFireTime = GetFireTimeAfter(DateTime.UtcNow);

            // Ensure event is in ICalendar.
            while (newFireTime.HasValue && cal != null && !cal.IsTimeIncluded(newFireTime.Value)) {
               newFireTime = GetFireTimeAfter(newFireTime);
            }

            SetNextFireTimeUtc(newFireTime);
         }
         else if (instr == ItineraryTriggerMisfireInstruction.FireOnceNow) {
            // Drop missed events.  Trigger event now, then resume schedule from current time.
            SetNextFireTimeUtc(DateTime.UtcNow);
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

      public override DateTimeOffset? FinalFireTimeUtc {
         get { return null; }
      }

      public override DateTimeOffset? GetFireTimeAfter(DateTimeOffset? afterTime) {
         if (!afterTime.HasValue)
            return null;

         var nextEvent = schedule.GetRange(afterTime.Value.DateTime, DateTime.MaxValue).FirstOrDefault(e => e.StartTime > afterTime);
         if (nextEvent == null)
            return null;
         else
            return nextEvent.StartTime;
      }

      public override IScheduleBuilder GetScheduleBuilder() {
         ItineraryScheduleBuilder scheduleBuilder = ItineraryScheduleBuilder.ItinerarySchedule(schedule);

         switch (MisfireInstruction) {
            case ItineraryTriggerMisfireInstruction.DoNothing:
               scheduleBuilder.WithMisfireHandlingInstructionDoNothing();
               break;

            case ItineraryTriggerMisfireInstruction.FireOnceNow:
               scheduleBuilder.WithMisfireHandlingInstructionFireAndProceed();
               break;
         }

         return scheduleBuilder;
      }

      public override void SetNextFireTimeUtc(DateTimeOffset? nextFireTime) {
         nextEventTime = nextFireTime.HasValue ? DateTime.SpecifyKind(nextFireTime.Value.DateTime, DateTimeKind.Utc) : (DateTime?)null;

         // Restart enumerator with new range.
         if (nextFireTime.HasValue) {
            scheduleEnumerator = schedule.GetRange(nextFireTime.Value.DateTime, DateTime.MaxValue).GetEnumerator();
         }
         else {
            scheduleEnumerator = null;
         }
      }

      public override void SetPreviousFireTimeUtc(DateTimeOffset? previousFireTime) {
         lastEventTime = previousFireTime.HasValue ? previousFireTime.Value.DateTime : (DateTime?)null;
      }

      public override DateTimeOffset? ComputeFirstFireTimeUtc(ICalendar cal) {
         do {
            if (!scheduleEnumerator.MoveNext()) {
               nextEventTime = null;
               break;
            }

            nextEventTime = scheduleEnumerator.Current.StartTime;
         } while (cal != null && !cal.IsTimeIncluded(scheduleEnumerator.Current.StartTime));

         return nextEventTime;
      }

      public override DateTimeOffset? GetNextFireTimeUtc() {
         return nextEventTime;
      }

      public override DateTimeOffset? GetPreviousFireTimeUtc() {
         return lastEventTime;
      }
   }

   /// <summary>
   /// Trigger misfire instruction constants.
   /// </summary>
   public struct ItineraryTriggerMisfireInstruction {

      // Summary:
      //     Instructs the Quartz.IScheduler that upon a mis-fire situation, the <see cref="Expl.Itinerary.ITineraryTriggerImpl" />
      //     wants to have it's next-fire-time updated to the next time in the schedule
      //     after the current time (taking into account any associated <see cref="Quartz.ICalendar" />,
      //     but it does not want to be fired now.
      public const int DoNothing = 2;

      //
      // Summary:
      //     Instructs the Quartz.IScheduler that upon a mis-fire situation, the <see cref="Expl.Itinerary.IItineraryTrigger" />
      //     wants to be fired now by <see cref="Quartz.IScheduler" />.
      public const int FireOnceNow = 1;
   }
}