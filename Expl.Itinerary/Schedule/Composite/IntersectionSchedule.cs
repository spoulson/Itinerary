using System;
using System.Collections.Generic;
using System.ComponentModel;
using Expl.Auxiliary;

namespace Expl.Itinerary {
   /// <summary>
   /// Intersecting schedules collection of two ISchedule objects where event times overlap.
   /// </summary>
   [Description("Intersection")]
   [Serializable]
   public class IntersectionSchedule : ICompositeSchedule {
      private ISchedule _ScheduleA;
      private ISchedule _ScheduleB;

      /// <summary>
      /// Optimization threshold for iterating two schedules.
      /// If iterating more than SeekCountThreshold and no intersection has been found, 
      /// the iterator will be rebuilt starting at the next predicted match.
      /// </summary>
      private const int SeekCountThreshold = 2;

      /// <summary>
      /// Default constructor.
      /// <remarks>Uses Void schedules as parameters.</remarks>
      /// </summary>
      public IntersectionSchedule()
         : this(new VoidSchedule(), new VoidSchedule()) { }

      /// <summary>
      /// Constructor.
      /// </summary>
      /// <param name="ScheduleA">Schedule A.</param>
      /// <param name="ScheduleB">Schedule B.</param>
      public IntersectionSchedule(ISchedule ScheduleA, ISchedule ScheduleB) {
         _ScheduleA = ScheduleA;
         _ScheduleB = ScheduleB;
      }

      /// <summary>
      /// Constructor for schedule list.
      /// <remarks>Will only enumerate the first two items from the list.
      /// If the list contains less than 2 items, default to Void schedules.</remarks>
      /// </summary>
      /// <param name="List">Enumerable list of ISchedule objects.</param>
      public IntersectionSchedule(IEnumerable<ISchedule> List) {
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

      public int OperatorPrecedence { get { return 20; } }

      public override string ToString() {
         string SchedStringA = _ScheduleA.OperatorPrecedence > this.OperatorPrecedence ? "(" + _ScheduleA.ToString() + ")" : _ScheduleA.ToString();
         string SchedStringB = _ScheduleB.OperatorPrecedence >= this.OperatorPrecedence ? "(" + _ScheduleB.ToString() + ")" : _ScheduleB.ToString();
         return SchedStringA + " & " + SchedStringB;
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

      // Optimized for iterative access 2008-07-16
      // Optimized with SeekCount 2008-07-18
      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         // xxxx  xxxx xxxx  xx xx
         // xxxx xxxx   xxxx xxxxx
         // ====  ===   ===  == ==

         // Flatten ScheduleB with union
         // Since results are based on events in ScheduleA, A is not flatted.
         var IterA = _ScheduleA.GetRange(RangeStart, RangeEnd).GetSpyEnumerator();
         var IterB = new UnionSchedule(_ScheduleB).GetRange(RangeStart, RangeEnd).GetSpyEnumerator();
         int SeekCount = 0;
         while (IterA.HasMore && IterB.HasMore) {
            if (IterA.Peek.Intersects(IterB.Peek)) {
               yield return IterA.Peek & IterB.Peek;
               SeekCount = 0;
            }
            else
               SeekCount++;

            // Iterate
            if (IterA.Peek.StartTime >= IterB.Peek.EndTime) {
               // If count threshold is met, jump iterator to next match
               if (SeekCount > SeekCountThreshold) {
                  IterB = new UnionSchedule(_ScheduleB).GetRange(IterA.Peek.StartTime, RangeEnd).GetSpyEnumerator();
                  SeekCount = 0;
               }
               else
                  IterB.MoveNext();
            }
            else {
               // If count threshold is met, jump iterator to next match
               if (SeekCount > SeekCountThreshold) {
                  IterA = _ScheduleA.GetRange(IterB.Peek.StartTime, RangeEnd).GetSpyEnumerator();
                  SeekCount = 0;
               }
               else
                  IterA.MoveNext();
            }
         }

         yield break;
      }

      public override int GetHashCode() {
         return
            _ScheduleA.GetHashCode() +
            _ScheduleB.GetHashCode();
      }
   }
}
