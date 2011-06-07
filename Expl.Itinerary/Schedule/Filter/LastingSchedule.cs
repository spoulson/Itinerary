using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Expl.Itinerary {
   /// <summary>
   /// Overrides event duration
   /// </summary>
   [Description("Lasting")]
   public class LastingSchedule : IFilterSchedule {
      protected TimeSpan _Duration;
      protected ISchedule _Schedule;

      public LastingSchedule() : this(TimeSpan.Zero, new VoidSchedule()) { }

      public LastingSchedule(TimeSpan Duration, ISchedule Schedule) {
         _Duration = Duration;
         _Schedule = Schedule;
      }

      public ISchedule BaseSchedule {
         get { return _Schedule; }
      }
         
      public TimeSpan Duration {
         get { return _Duration; }
      }

      public int OperatorPrecedence { get { return 10; } }

      public override string ToString() {
         string SchedString = _Schedule.OperatorPrecedence > this.OperatorPrecedence ? "(" + _Schedule.ToString() + ")" : _Schedule.ToString();
         return SchedString + " lasting " + ItineraryConvert.ToString(_Duration);
      }

      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         foreach (var Evt in _Schedule.GetRange(RangeStart, RangeEnd)) {
            DateTime NewEndTime = Evt.StartTime + _Duration;

            // Check if event is still within requested range
            if (NewEndTime <= RangeStart) continue;

            yield return new TimedEvent(Evt.StartTime, NewEndTime);
         }

         yield break;
      }
   }
}
