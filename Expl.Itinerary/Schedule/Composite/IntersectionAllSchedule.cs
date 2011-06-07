using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Expl.Itinerary{
   /// <summary>
   /// Intersecting schedules collection of two ISchedule objects where event times overlap.
   /// This differs with IntersectionSchedule in that there is no comparison between schedules.  All events are flattened to intersecting events.
   /// </summary>
   [Description("IntersectionAll")]
   public class IntersectionAllSchedule : ICompositeSchedule {
      protected ISchedule _Schedule;

      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="Schedule">Schedule subject</param>
      public IntersectionAllSchedule(ISchedule Schedule) {
         _Schedule = Schedule;
      }

      public int OperatorPrecedence { get { return 1000; } }

      public override string ToString() {
         return string.Format("&[{0}]", _Schedule.ToString());
      }

      public IEnumerable<ISchedule> Schedules {
         get { yield return _Schedule; }
      }

      public int MinSchedules {
         get { return 1; }
      }

      public int MaxSchedules {
         get { return 1; }
      }

      // Optimized 2008-07-16
      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         // Algorithm details:
         // Iterate A through schedule
         //   Maintain a WorkEvent that holds the contiguous time range of events seen
         //   Maintain a MatchEvent that holds the contiguous time range of matching event time
         //   If A is not intersecting/adjacent to WorkEvent, clear it and MatchEvent
         //   Check if A intersects WorkEvent
         //     If so, union MatchEvent and A
         //     But, first check that MatchEvent is intersecting/adjacent to A.  If not, return MatchEvent and clear.
         //   Union WorkEvent and A
         // End Iterate
         //
         // Proof using a rigorous example:
         // xxxx xxxx  xxxx
         //   xxxx
         //  xxxxxxxx
         // ---------  ----
         // 
         // aaaa xxxx  xxxx
         //   xxxx
         //  bbbbbbbb
         // ---------
         //
         // xXXX xxxx  xxxx
         //   xxxx
         //  XXXxxxxx
         // ---------
         //  ===
         //
         // aAAA xxxx  xxxx
         //   bbbb
         //  XXXxxxxx
         // ---------
         //  ===
         //
         // xXXX xxxx  xxxx
         //   XXxx
         //  XXXxxxxx
         // ---------
         //  ===
         //
         // xXXX xxxx  xxxx
         //   BBbb
         //  AAAaaaaa
         // ---------
         //  ===
         //
         // xXXX xxxx  xxxx
         //   XXXX
         //  XXXXXxxx
         // ---------
         //  =====
         //
         // xXXX bbbb  xxxx
         //   XXXX
         //  AAAAAaaa
         // ---------
         //  =====
         //
         // xXXX XXXX  xxxx
         //   XXXX
         //  XXXXXXXX
         // ---------
         //  ========
         //
         // xXXX BBBB  xxxx
         //   AAAA
         //  XXXXXXXX
         // ---------
         //  ========
         //
         // xXXX XXXX  xxxx
         //   XXXX
         //  XXXXXXXX
         // ---------
         //  ========
         //
         // xXXX AAAA  bbbb
         //   XXXX
         //  XXXXXXXX
         //            ----
         //  ========
         //
         // xXXX XXXX
         //   XXXX
         //  XXXXXXXX
         //  ========

         TimedEvent WorkEvent = null;
         TimedEvent MatchEvent = null;
         foreach (TimedEvent A in _Schedule.GetRange(RangeStart, RangeEnd)) {
            if (MatchEvent == null) {
               // If WorkEvent doesn't exist, compare A and WorkEvent
               if (WorkEvent != null && WorkEvent.Intersects(A)) {
                  // A intersects WorkEvent
                  MatchEvent = WorkEvent & A;
                  WorkEvent = WorkEvent.Union(A)[0];
               }
               else {
                  // Load up WorkEvent, move on
                  WorkEvent = A;
               }
            }
            else {
               if (A.StartTime > MatchEvent.EndTime) {
                  // Event retrieved thats after the matching event, return match value
                  yield return MatchEvent;
                  // Update match
                  MatchEvent = WorkEvent.Intersects(A) ? WorkEvent & A : null;
               }
               else if (MatchEvent.Intersects(A) || MatchEvent.AdjacentTo(A)) {
                  // A intersects with/adjacent to match, so union with A
                  MatchEvent = MatchEvent.Union(WorkEvent & A)[0];
               }

               // Update working range; Union with A if intersecting/adjacent or clear and set to A
               WorkEvent = (WorkEvent != null && (WorkEvent.Intersects(A) || WorkEvent.AdjacentTo(A))) ? WorkEvent.Union(A)[0] : A;
            }
         }

         if (MatchEvent != null) yield return MatchEvent;

         yield break;
      }
   }
}
