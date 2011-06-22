using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Expl.Itinerary {
   /// <summary>
   /// Non-intersecting schedules collection of two ISchedule objects where event A does not intersect with event B.
   /// </summary>
   [Description("Boolean Non-Intersection")]
   [Serializable]
   public class BoolNonIntersectionSchedule : ICompositeSchedule {
      private ISchedule _ScheduleA;
      private ISchedule _ScheduleB;

      /// <summary>
      /// Default constructor.
      /// </summary>
      public BoolNonIntersectionSchedule()
         : this(new VoidSchedule(), new VoidSchedule()) { }

      /// <summary>
      /// Constructor.
      /// </summary>
      /// <param name="ScheduleA">Schedule A.</param>
      /// <param name="ScheduleB">Schedule B.</param>
      public BoolNonIntersectionSchedule(ISchedule ScheduleA, ISchedule ScheduleB) {
         _ScheduleA = ScheduleA;
         _ScheduleB = ScheduleB;
      }

      /// <summary>
      /// Constructor for schedule list.
      /// <remarks>Will only enumerate the first two elements from the list.</remarks>
      /// </summary>
      /// <param name="List">Enumerable list of ISchedule objects.</param>
      public BoolNonIntersectionSchedule(IEnumerable<ISchedule> List) {
         var Iter = List.GetEnumerator();
         if (Iter.MoveNext()) {
            _ScheduleA = Iter.Current;
            if (Iter.MoveNext())
               _ScheduleB = Iter.Current;
            else
               _ScheduleB = new VoidSchedule();
         }
         else {
            _ScheduleA = _ScheduleB = new VoidSchedule();
         }
      }

      public int OperatorPrecedence { get { return 70; } }

      public override string ToString() {
         string SchedStringA = _ScheduleA.OperatorPrecedence > this.OperatorPrecedence ? "(" + _ScheduleA.ToString() + ")" : _ScheduleA.ToString();
         string SchedStringB = _ScheduleB.OperatorPrecedence >= this.OperatorPrecedence ? "(" + _ScheduleB.ToString() + ")" : _ScheduleB.ToString();
         return SchedStringA + " !&& " + SchedStringB;
      }

      public IEnumerable<ISchedule> Schedules {
         get {
            yield return _ScheduleA;
            yield return _ScheduleB;
         }
      }

      public int MinSchedules {
         get { return 2; }
      }

      public int MaxSchedules {
         get { return 2; }
      }

      // Optimized 2008-07-13
      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         // Find matches where A does not intersect B, return A
         foreach (TimedEvent A in _ScheduleA.GetRange(RangeStart, RangeEnd)) {

            // Match if no events in B intersect with this instance of A
            if (!_ScheduleB.GetRange(A.StartTime, A.EndTime).GetEnumerator().MoveNext())
               yield return A;
         }

         yield break;
      }

      public override int GetHashCode() {
         // TODO: Rewrite such that hashcodes A + B != B + A.
         return
            _ScheduleA.GetHashCode() +
            _ScheduleB.GetHashCode();
      }
   }
}
