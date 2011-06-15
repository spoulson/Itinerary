using System;
using System.Collections.Generic;
using System.ComponentModel;
using Expl.Auxiliary;

namespace Expl.Itinerary {
   /// <summary>
   /// Extract events at specified indexes.
   /// Indexes are 1-based.
   /// </summary>
   [Description("Index")]
   public class IndexSchedule : IFilterSchedule {
      protected string _IndexSpec;
      protected ISchedule _Schedule;

      public IndexSchedule() : this("1", new VoidSchedule()) { }

      public IndexSchedule(string IndexSpec, ISchedule Schedule) {
         _IndexSpec = IndexSpec;
         _Schedule = Schedule;
      }

      public int OperatorPrecedence { get { return 10; } }

      public ISchedule BaseSchedule {
         get { return _Schedule; }
      }

      public string IndexSpec {
         get { return _IndexSpec; }
      }

      public override string ToString() {
         string SchedString = _Schedule.OperatorPrecedence > this.OperatorPrecedence ? "(" + _Schedule.ToString() + ")" : _Schedule.ToString();
         return SchedString + " #" + _IndexSpec;
      }

      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         int Index = 1;
         IEnumerator<int> IndicesIter = IntSpec.Parse(_IndexSpec, 1, int.MaxValue).GetEnumerator();

         // If no indices, return
         if (!IndicesIter.MoveNext()) yield break;

         int NextIndex = IndicesIter.Current;

         // Iterate over each event, increment index until a match
         foreach (var Evt in _Schedule.GetRange(RangeStart, RangeEnd)) {
            // If index matches next, return the event
            if (Index == NextIndex) {
               yield return Evt;
               if (!IndicesIter.MoveNext()) yield break;
               NextIndex = IndicesIter.Current;
            }

            Index++;
         }

         yield break;
      }
   }
}
