using System;
using System.Collections.Generic;

namespace Expl.Itinerary {
   /// <summary>
   /// Void schedule
   /// </summary>
   public class VoidSchedule : IPrimitiveSchedule {
      public void Dispose() { }

      public int OperatorPrecedence { get { return 1; } }

      public override string ToString() {
         return "void";
      }

      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         yield break;
      }
   }
}
