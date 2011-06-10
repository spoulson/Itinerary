using System;
using System.Collections.Generic;
using System.Text;

namespace Expl.Itinerary {
   /// <summary>
   /// Schedule at regular intervals.
   /// </summary>
   public class IntervalSchedule : IPrimitiveSchedule {
      protected TimeSpan _Interval;
      protected TimeSpan _Duration;
      protected DateTime _SyncTime;

      /// <summary>
      /// Default constructor
      /// </summary>
      public IntervalSchedule()
         : this(TimeSpan.Zero, TimeSpan.Zero, DateTime.MinValue) { }

      /// <summary>
      /// Constructor for events at a regular interval
      /// </summary>
      /// <param name="Interval">Time interval</param>
      /// <param name="Duration">Duration of event</param>
      /// <param name="SynchronizeTime">Synchronize to time</param>
      public IntervalSchedule(TimeSpan Interval, TimeSpan Duration, DateTime SynchronizeTime) {
         _Interval = Interval;
         _Duration = Duration;
         _SyncTime = SynchronizeTime;
      }

      public int OperatorPrecedence { get { return 1; } }

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append("every ");
         sb.Append(ItineraryConvert.ToString(_Interval));
         if (_SyncTime != DateTime.MinValue) {
            sb.Append(" since ");
            sb.Append(ItineraryConvert.ToString(_SyncTime));
         }
         if (_Duration != TimeSpan.Zero) {
            sb.Append(" lasting ");
            sb.Append(ItineraryConvert.ToString(_Duration));
         }
         return sb.ToString();
         //return string.Format("every {0} since {1} lasting {2}", ItineraryConvert.ToString(_Interval), ItineraryConvert.ToString(_SyncTime), ItineraryConvert.ToString(_Duration));
      }

      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         // Handle zero interval condition
         if (_Interval == TimeSpan.Zero) yield break;

         // Check event intersection with range
         TimeSpan RangeDuration = RangeEnd - RangeStart;
         DateTime IterateStart = SynchronizeTime(RangeStart);
         DateTime IterateEnd = RangeEnd;

         // Check first event
         // EEEE EEEE
         //   WWWWWWW
         TimedEvent FirstEvt = new TimedEvent(
            (IterateStart.Ticks >= _Interval.Ticks ? // Handle when IterateStart is near DateTime.MinValue
            IterateStart.Subtract(_Interval) :
            DateTime.MinValue),
            _Duration);
         if (FirstEvt.StartTime != IterateStart && FirstEvt.Intersects(new TimedEvent(RangeStart, RangeEnd)))
            yield return FirstEvt;

         if (DateTime.MaxValue - IterateEnd >= _Interval) {
            for (DateTime dt = IterateStart; dt < IterateEnd; dt = dt.Add(_Interval))
               yield return new TimedEvent(dt, dt.Add(_Duration));
         }
         else {
            // Special case when end of iteration is very close to DateTime.MaxValue
            // IterateEnd must be at least > Interval time to match any events
            if (IterateEnd.Ticks >= _Interval.Ticks) {
               DateTime IterateEnd2 = IterateEnd.Subtract(_Interval);
               for (DateTime dt = IterateStart; ; dt = dt.Add(_Interval)) {
                  yield return new TimedEvent(dt, dt.Add(_Duration));
                  if (dt >= IterateEnd2) break;
               }
            }
         }

         yield break;
      }

      /// <summary>
      /// Synchronize time to set interval and sync time
      /// </summary>
      /// <param name="dt">Date/time to synchronize</param>
      /// <returns>Synchronized date/time</returns>
      private DateTime SynchronizeTime(DateTime dt) {
         /*
          * Test cases for synchronize time algorithm:
          * ---
          * 
          * SyncTime: 00:00:25.000 / 25000ms
          * Interval: 1000ms
          * 
          * Test time: 00:00:40.000 / 40000ms
          * test - ((test-synctime) % interval) + (round up interval) =
          * 40000 - ((40000-25000) % 1000) + (round up 1000) =
          * 40000 - (0) + (0) = 40000 = 00:00:40.000
          * 
          * Test time: 00:00:38.125 / 38125ms
          * 38125 - ((38125-25000) % 1000) + (round up 1000) =
          * 38125 - (125) + (1000) = 39000 = 00:00:39.000
          * 
          * Test time: 00:12:47.552 / 767552ms
          * 767552 - ((767552-25000) % 1000) + (round up 1000) =
          * 767552 - (552) + (1000) = 768000 = 00:12:48.000
          * ---
          * 
          * SyncTime: 00:00:25.000 / 25000ms
          * Interval: 152ms
          * 
          * Test time: 00:00:40.000 / 40000ms
          * test - ((test-synctime) % interval) + (round up interval) =
          * 40000 - ((40000-25000) % 152) + (round up 152) =
          * 40000 - (104) + (152) = 40048 = 00:00:40.048
          * 
          * Test time: 00:00:38.125 / 38125ms
          * 38125 - ((38125-25000) % 152) + (round up 152) =
          * 38125 - (53) + (152) = 38224 = 00:00:38.224
          * 
          * Test time: 00:12.47.552 / 767552ms
          * 767552 - ((767552-25000) % 152) + (round up 152) =
          * 767552 - (32) + (152) = 767672 = 00:12:47.672
          */

         long r = (long)((dt - _SyncTime).TotalMilliseconds) % (long)_Interval.TotalMilliseconds;
         return dt.AddMilliseconds(r > 0 ? _Interval.TotalMilliseconds - r : -r);
      }

      private long TotalMilliseconds(DateTime dt) {
         return (long)(dt.Ticks / 10000);
      }
   }
}
