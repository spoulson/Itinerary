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
   [Description("Union")]
   public class UnionSchedule : ICompositeSchedule {
      private ListSchedule _Schedule;

      /// <summary>
      /// Constructor for empty list.
      /// </summary>
      public UnionSchedule() {
         _Schedule = new ListSchedule();
      }

      /// <summary>
      /// Constructor for single schedule.
      /// </summary>
      /// <param name="A">Schedule.</param>
      public UnionSchedule(ISchedule A) {
         _Schedule = new ListSchedule(A);
      }

      /// <summary>
      /// Constructor for two schedules.
      /// </summary>
      /// <param name="A">Schedule A.</param>
      /// <param name="B">Schedule B.</param>
      public UnionSchedule(ISchedule A, ISchedule B) {
         _Schedule = new ListSchedule(A, B);
      }

      /// <summary>
      /// Constructor for many schedules.
      /// </summary>
      /// <param name="List">Enumerable list of ISchedule objects.</param>
      public UnionSchedule(IEnumerable<ISchedule> List) {
         _Schedule = new ListSchedule(List);
      }

      public IEnumerable<ISchedule> Schedules {
         get { return _Schedule.Schedules; }
      }

      public int MinSchedules {
         get { return 1; }
      }

      public int MaxSchedules {
         get { return int.MaxValue; }
      }

      public int OperatorPrecedence { get { return 40; } }

      public override string ToString() {
         // If schedule precedence is > this schedule, add parens
         // If lvalue is same type as this schedule, no parens are needed.
         // e.g. "(A | B) | C" equates to "A | B | C"
         // e.g. "A | (B | C)" equates to "A | B | C"
         StringBuilder sb = new StringBuilder();
         sb.Append(Schedules.Select<ISchedule, string>(Schedule =>
            Schedule.OperatorPrecedence > this.OperatorPrecedence
            ? "(" + Schedule.ToString() + ")"
            : Schedule.ToString()
         ).JoinStrings(" | "));
         return sb.ToString();
      }

      // Optimized 2008-07-13
      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         // AAAA
         //   BBBB
         // xxxxxx
         //
         // AA
         //   BB
         // xxxx
         //
         // AAAA
         //   BBBB
         // xxxxxx
         //       CC
         // xxxxxxxx

         TimedEvent MatchEvent = null;
         foreach (TimedEvent A in _Schedule.GetRange(RangeStart, RangeEnd)) {
            if (MatchEvent == null) {
               // Load up MatchEvent
               MatchEvent = A;
            }
            else if (MatchEvent.Intersects(A) || MatchEvent.IsAdjacentTo(A)) {
               // Compute union and move on
               MatchEvent = MatchEvent.Union(A)[0];
            }
            else {
               // No intersection, return MatchEvent
               yield return MatchEvent;
               MatchEvent = A;
            }
         }

         // If MatchEvent has a value, return it
         if (MatchEvent != null) yield return MatchEvent;

         yield break;
      }
   }
}
