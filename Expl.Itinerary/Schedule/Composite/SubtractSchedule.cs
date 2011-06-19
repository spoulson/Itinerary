using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Expl.Auxiliary;

namespace Expl.Itinerary {
   /// <summary>
   /// Subtract.
   /// Non-intersecting schedules collection of two ISchedule objects where events of Schedule A does not overlap events of Schedule B.
   /// (****[..)....]
   /// Generate subtraction of two datetime spans.
   /// </summary>
   /// <remarks>
   /// TODO: Implement unit tests for SubtractSchedule.
   /// </remarks>
   [Description("Subtract")]
   public class SubtractSchedule : ICompositeSchedule {
      private ISchedule _ScheduleA;
      private ISchedule _ScheduleB;

      /// <summary>
      /// Default constructor for empty list.
      /// </summary>
      public SubtractSchedule()
         : this(new VoidSchedule(), new VoidSchedule()) { }

      /// <summary>
      /// Constructor for two schedules.
      /// </summary>
      /// <param name="ScheduleA">Schedule A.</param>
      /// <param name="ScheduleB">Schedule B.</param>
      public SubtractSchedule(ISchedule ScheduleA, ISchedule ScheduleB) {
         _ScheduleA = ScheduleA;
         _ScheduleB = ScheduleB;
      }

      public ISchedule ScheduleA {
         get { return _ScheduleA; }
      }

      public ISchedule ScheduleB {
         get { return _ScheduleB; }
      }

      public int MinSchedules {
         get { return 2; }
      }

      public int MaxSchedules {
         get { return 2; }
      }

      public IEnumerable<ISchedule> Schedules {
         get {
            yield return _ScheduleA;
            yield return _ScheduleB;
            yield break;
         }
      }

      public int OperatorPrecedence { get { return 40; } }

      public override string ToString() {
         string SchedStringA = _ScheduleA.OperatorPrecedence > this.OperatorPrecedence ? "(" + _ScheduleA.ToString() + ")" : _ScheduleA.ToString();
         string SchedStringB = _ScheduleB.OperatorPrecedence >= this.OperatorPrecedence ? "(" + _ScheduleB.ToString() + ")" : _ScheduleB.ToString();
         return SchedStringA + " - " + SchedStringB;
      }

      // Optimized 2008-07-13
      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         /* Subtraction complex example:
          * Input:
          * A: xxxx  xxxx
          * B:   xxxxxx
          *   
          * Compare:
          * A: AAAA  xxxx
          * B:   BBBBBB
          *   
          * Compute subtraction:
          * A: AA--  xxxx
          * A:   --BBBB
          * 
          * Compare next:
          * A: RR    AAAA
          * B:     BBBB
          *     
          * Compute subtraction:
          * A: RR    --AA
          * B:     BB--
          *     
          * Result:
          * RR      RR
          * 
          */

         // Prepare iterator A.
         var IteratorA = _ScheduleA.GetRange(RangeStart, RangeEnd).GetEnumerator();
         bool HasMoreA = IteratorA.MoveNext();

         // If no events in schedule A, quit now.
         if (!HasMoreA) yield break;

         // Prepare iterator B.
         var IteratorB = _ScheduleB.GetRange(RangeStart, RangeEnd).GetEnumerator();
         bool HasMoreB = IteratorB.MoveNext();

         List<TimedEvent> QueueA = new List<TimedEvent>();

         do {
            // Get next event for A from queue or iterator, whichever is earliest.
            TimedEvent A = default(TimedEvent);
            if (QueueA.Count > 0 && (!HasMoreA || QueueA[0] <= IteratorA.Current)) {
               // Pop event off queue A.
               A = QueueA[0];
               QueueA.RemoveAt(0);
            }
            else if (HasMoreA) {
               // If queue is empty or iterator's current value is earlier,
               // get next event from A and put it on the queue.
               QueueA.Add(IteratorA.Current);
               HasMoreA = IteratorA.MoveNext();
               continue;
            }

            do {  // Dummy code block.
               if (!HasMoreB) {
                  // If no more events from B, return remaining events from A.
                  yield return A;
               }
               else {
                  // Compare A <=> B.
                  var B = IteratorB.Current;

                  // AAAA
                  //      BBBB
                  if (A.EndTime <= B.StartTime) {
                     // No intersection, return A.
                     yield return A;
                  }
                  // AAAA   or AAAA or   AAAA or  AA
                  //   BBBB     BB     BBBB      BBBB
                  else if (B.EndTime > A.StartTime) {
                     // AAAA   or AAAA
                     //   BBBB     BB
                     if (A.StartTime < B.StartTime) {
                        var NewA = new TimedEvent(A.StartTime, B.StartTime);
                        QueueA.Add(NewA);

                        if (B.EndTime < A.EndTime) {
                           var NewA2 = new TimedEvent(A.StartTime, B.StartTime);
                           QueueA.Add(NewA2);
                        }
                     }
                     //   AAAA or  AA
                     // BBBB      BBBB
                     else if (B.EndTime < A.EndTime) {
                        var NewA = new TimedEvent(B.EndTime, A.EndTime);
                        QueueA.Add(NewA);
                     }
                  }
                  else {
                     //      AAAA
                     // BBBB
                     // No intersection, advance schedule B and recompare.
                     HasMoreB = IteratorB.MoveNext();
                     continue;
                  }
               } // if (!HasMoreB) else
            } while (false);

            // Continue until no more events from A.
         } while (HasMoreA || QueueA.Count > 0);

         yield break;
      }
   }
}
