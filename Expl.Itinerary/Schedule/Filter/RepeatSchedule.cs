using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Expl.Itinerary {
   [Description("Repeat")]
   public class RepeatSchedule : IFilterSchedule {
      protected ISchedule _Schedule;
      protected int _RepeatCount;

      /// <summary>
      /// Default constructor.
      /// </summary>
      public RepeatSchedule()
         : this(1, new VoidSchedule()) { }

      /// <summary>
      /// Constructor.
      /// </summary>
      /// <param name="RepeatCount">Repeat count.</param>
      /// <param name="Schedule">Schedule to repeat.</param>
      public RepeatSchedule(int RepeatCount, ISchedule Schedule) {
         _Schedule = Schedule;
         _RepeatCount = RepeatCount;
      }

      public int OperatorPrecedence { get { return 10; } }

      public override string ToString() {
         string SchedString = _Schedule.OperatorPrecedence > this.OperatorPrecedence ? "(" + _Schedule.ToString() + ")" : _Schedule.ToString();
         return string.Format("{0} x {1:d}", SchedString, _RepeatCount);
      }

      public ISchedule BaseSchedule {
         get { return _Schedule; }
      }

      public int RepeatCount {
         get { return _RepeatCount; }
      }

      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         if (_RepeatCount < 1) yield break;

         foreach (TimedEvent Evt in _Schedule.GetRange(RangeStart, RangeEnd)) {
            for (int i = 0; i < _RepeatCount; i++)
               yield return Evt;
         }

         yield break;
      }
   }
}
