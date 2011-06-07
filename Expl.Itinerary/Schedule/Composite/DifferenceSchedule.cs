using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Expl.Auxiliary;

namespace Expl.Itinerary {
   /// <summary>
   /// Difference
   /// Non-intersecting schedules collection of two or more ISchedule objects where event times do not overlap.
   /// (****[..)****]
   /// Generate difference of two datetime spans
   /// </summary>
   [Description("Difference")]
   public class DifferenceSchedule : ICompositeSchedule {
      protected ListSchedule _Schedule;

      /// <summary>
      /// Default constructor for empty list
      /// </summary>
      public DifferenceSchedule()
         : this(new VoidSchedule(), new VoidSchedule()) { }

      /// <summary>
      /// Constructor for two schedules
      /// </summary>
      /// <param name="ScheduleA">Schedule A</param>
      /// <param name="ScheduleB">Schedule B</param>
      public DifferenceSchedule(ISchedule ScheduleA, ISchedule ScheduleB) {
         _Schedule = new ListSchedule(ScheduleA, ScheduleB);
      }

      /// <summary>
      /// Constructor for many schedules
      /// </summary>
      /// <param name="List">Enumerable list of ISchedule objects</param>
      public DifferenceSchedule(IEnumerable<ISchedule> List) {
         _Schedule = new ListSchedule(List);
      }

      public IEnumerable<ISchedule> Schedules {
         get { return _Schedule.Schedules; }
      }

      public int MinSchedules {
         get { return 2; }
      }

      public int MaxSchedules {
         get { return int.MaxValue; }
      }

      public int OperatorPrecedence { get { return 30; } }

      public override string ToString() {
         // First schedule is lvalue; if its precedence is > this schedule, add parens
         // If lvalue is same type as this schedule, no parens are needed.
         // e.g. "(A !& B) !& C" -- lvalue is "(B !& C)".  Expression equates to "A !& B !& C".
         // All other schedules are rvalues; if precedent is >= this schedule or the type is same as this schedule, add parens
         // e.g. "A !& (B !& C)" -- rvalue is "(B !& C)", requires parens to preserve precedence
         StringBuilder sb = new StringBuilder();
         sb.Append(Schedules.Select<ISchedule, string>((Schedule, Count) =>
            (Count == 0 && Schedule.OperatorPrecedence > this.OperatorPrecedence)
            || (Count != 0 && (Schedule.OperatorPrecedence >= this.OperatorPrecedence || this.GetType() == Schedule.GetType()))
            ? "(" + Schedule.ToString() + ")"
            : Schedule.ToString()
         ).JoinStrings(" !& "));
         return sb.ToString();
      }

      // Optimized 2008-07-13
      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         /*
          * xxxx  xxxx
          *   xxxxxx
          *
          * AAAA  xxxx
          *   BBBBBB
          * 
          * xx    xxxx
          *     xxxx
          * 
          * AA    xxxx
          *     BBBB
          * 
          * AA    BBBB
          *     xxxx
          * 
          * xx    BBBB
          *     AAAA
          * 
          * xx  xx  xx
          * 
          */

         IEnumerator<TimedEvent> ListIterator = _Schedule.GetRange(RangeStart, RangeEnd).GetEnumerator();

         if (ListIterator.MoveNext()) {
            TimedEvent DiffEvent = null;
            DateTime Max = ListIterator.Current.StartTime;
            var BufferList = new List<TimedEvent>(new TimedEvent[] { ListIterator.Current });

            do {
               // Get next event
               TimedEvent A = BufferList[0];
               BufferList.RemoveAt(0);

               // Figure out what to do with it
               if (DiffEvent == null) {
                  DiffEvent = A;
               }
               else if (DiffEvent.Intersects(A)) {
                  // With an intersection, add difference events to list and redo
                  TimedEvent[] DiffEvents = DiffEvent.Difference(A);
                  if (DiffEvents.Length > 0) {
                     TimedEvent LastEvent = DiffEvents[DiffEvents.Length - 1];
                     if (LastEvent.StartTime > Max) Max = LastEvent.StartTime;

                     BufferList.AddRange(DiffEvents);
                     BufferList.Sort();
                  }
                  DiffEvent = null;
               }
               else {
                  // No intersection, return working DiffEvent
                  yield return DiffEvent;
                  DiffEvent = A;
               }

               // Fetch more events?
               if (BufferList.Count == 0) {
                  while (ListIterator.MoveNext()) {
                     TimedEvent Event1 = ListIterator.Current;
                     BufferList.Add(Event1);
                     // Stop buffering when we pass the maximum StartTime we need
                     if (Event1.StartTime > Max) {
                        Max = Event1.StartTime;
                        break;
                     }
                  }
               }

               // Continue as long as more data exists
            } while (BufferList.Count > 0);

            // If working DiffEvent has a value, return it
            if (DiffEvent != null) yield return DiffEvent;
         }

         yield break;
      }
   }
}
