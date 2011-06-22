using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Expl.Auxiliary;

namespace Expl.Itinerary {
   /// <summary>
   /// Union collection of ISchedule objects.
   /// </summary>
   [Description("List")]
   [Serializable]
   public class ListSchedule : ICompositeSchedule {
      private List<ISchedule> _Schedules;

      /// <summary>
      /// Constructor for empty list.
      /// </summary>
      public ListSchedule() {
         _Schedules = new List<ISchedule>();
      }

      /// <summary>
      /// Constructor for single element in list.
      /// </summary>
      /// <param name="A">Schedule.</param>
      public ListSchedule(ISchedule A) {
         _Schedules = new List<ISchedule>();
         _Schedules.Add(A);
      }

      /// <summary>
      /// Constructor for two elements in list.
      /// </summary>
      /// <param name="A">Schedule A.</param>
      /// <param name="B">Schedule B.</param>
      public ListSchedule(ISchedule A, ISchedule B) {
         _Schedules = new List<ISchedule>();
         _Schedules.Add(A);
         _Schedules.Add(B);
      }

      /// <summary>
      /// Constructor for many elements in list.
      /// </summary>
      /// <param name="List">Enumerable list of ISchedule objects.</param>
      public ListSchedule(IEnumerable<ISchedule> List) {
         _Schedules = new List<ISchedule>(List);
      }

      public int OperatorPrecedence { get { return 80; } }

      public override string ToString() {
         // If schedule precedence is > this schedule, add parens
         // If lvalue is same type as this schedule, no parens are needed.
         // e.g. "(A, B), C" equates to "A, B, C"
         // e.g. "A, (B, C)" equates to "A, B, C"
         StringBuilder sb = new StringBuilder();
         sb.Append(Schedules.Select<ISchedule, string>(Schedule =>
            Schedule.OperatorPrecedence > this.OperatorPrecedence
            ? "(" + Schedule.ToString() + ")"
            : Schedule.ToString()
         ).JoinStrings(", "));
         return sb.ToString();
      }

      /// <summary>
      /// Get ISchedules collection.
      /// </summary>
      public IEnumerable<ISchedule> Schedules {
         get { return _Schedules; }
      }

      public int MinSchedules {
         get { return 0; }
      }

      public int MaxSchedules {
         get { return int.MaxValue; }
      }

      const int MaxScheduleBufferSize = 20;

      // Optimized 2008-07-07
      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         // Get iterators from each schedule
         List<SpyEnumerator<TimedEvent>> Iterators = new List<SpyEnumerator<TimedEvent>>(_Schedules.Count);
         foreach (ISchedule Schedule1 in _Schedules)
            Iterators.Add(Schedule1.GetRange(RangeStart, RangeEnd).GetSpyEnumerator());

         // Batch loop
         List<TimedEvent> BatchEvents = new List<TimedEvent>(MaxScheduleBufferSize * _Schedules.Count);
         for (; ; ) {
            DateTime? BatchEndTime = null;

            // Peek first events from each iterator
            foreach (SpyEnumerator<TimedEvent> Iterator in Iterators) {
               if (Iterator.HasMore) {
                  TimedEvent Evt1 = Iterator.Peek;
                     if (!BatchEndTime.HasValue || Evt1.StartTime < BatchEndTime.Value)
                     BatchEndTime = Evt1.StartTime;
               }
            }

            // Check if no more events can be iterated, break out
            if (!BatchEndTime.HasValue) break;

            // Iterate events up to BatchEndTime
            foreach (SpyEnumerator<TimedEvent> Iterator in Iterators) {
               int BatchSize = 0;
               while (Iterator.HasMore) {
                  TimedEvent Evt1 = Iterator.Peek;
                  if (Evt1.StartTime > BatchEndTime) break;
                  Iterator.MoveNext();
                  BatchEvents.Add(Evt1);
                  BatchSize++;

                  if (BatchSize >= MaxScheduleBufferSize) {
                     // Max buffer size reached
                     // Set new BatchEndTime and skip to next schedule
                     BatchEndTime = Evt1.StartTime;
                     break;
                  }
               }
            }

            // If no more events can be had, break from iteration
            if (BatchEvents.Count == 0) break;

            // Sort batch results to ensure chronological order, then return each event
            BatchEvents.Sort();
            int BatchIdx;
            for (BatchIdx = 0; BatchIdx < BatchEvents.Count; BatchIdx++) {
               TimedEvent Evt1 = BatchEvents[BatchIdx];
               if (Evt1.StartTime > BatchEndTime) break;
               yield return Evt1;
            }

            // Clear event list and repeat
            BatchEvents.RemoveRange(0, BatchIdx);
         }

         yield break;
      }

      public override int GetHashCode() {
         int a = 0;

         foreach (var sched in _Schedules) {
            a += sched.GetHashCode();
         }

         return a;
      }
   }
}
