using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Expl.Itinerary {
   [Description("Offset")]
   [Serializable]
   public class OffsetSchedule : IFilterSchedule {
      private ISchedule _Schedule;
      private TimeSpan _OffsetTime;

      /// <summary>
      /// Default constructor.
      /// </summary>
      public OffsetSchedule()
         : this(TimeSpan.Zero, new VoidSchedule()) { }

      /// <summary>
      /// Constructor.
      /// </summary>
      /// <param name="OffsetTime">TimeSpan of offset.</param>
      /// <param name="Schedule">Schedule to filter.</param>
      public OffsetSchedule(TimeSpan OffsetTime, ISchedule Schedule) {
         _OffsetTime = OffsetTime;
         _Schedule = Schedule;
      }

      public int OperatorPrecedence { get { return 10; } }

      public override string ToString() {
         string SchedString = _Schedule.OperatorPrecedence > this.OperatorPrecedence ? "(" + _Schedule.ToString() + ")" : _Schedule.ToString();
         return _OffsetTime.Ticks >= 0 ?
            string.Format("{0} + {1}", SchedString, ItineraryConvert.ToString(_OffsetTime)) :
            string.Format("{0} - {1}", SchedString, ItineraryConvert.ToString(_OffsetTime.Negate()));
      }

      public ISchedule BaseSchedule {
         get { return _Schedule; }
      }

      public TimeSpan OffsetTime {
         get { return _OffsetTime; }
      }

      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         TimedEvent RangeEvent = new TimedEvent(RangeStart, RangeEnd);
         IEnumerable<TimedEvent> Enum1 = _OffsetTime.Ticks >= 0 ?
            _Schedule.GetRange(SafeDateTimeAdd(RangeStart, _OffsetTime.Negate()), DateTime.MaxValue) :
            _Schedule.GetRange(SafeDateTimeAdd(RangeStart, _OffsetTime), DateTime.MaxValue);

         foreach (TimedEvent Evt in Enum1) {
            TimedEvent OffsetEvt;
            try {
               OffsetEvt = new TimedEvent(Evt.StartTime + _OffsetTime, Evt.EndTime + _OffsetTime);
            }
            catch (ArgumentOutOfRangeException) {
               // This occurs when _OffsetTime is added to StartTime or EndTime and causes an overflow or underflow.
               // In this case, we ignore this event, since it can't be represented.
               continue;
            }
            if (OffsetEvt.StartTime >= RangeEnd) break;
            if (OffsetEvt.Intersects(RangeEvent))
               yield return OffsetEvt;
         }

         yield break;
      }

      private DateTime SafeDateTimeAdd(DateTime Value, TimeSpan AddValue) {
         if (AddValue.Ticks >= 0) {
            if (DateTime.MaxValue - Value <= AddValue) return DateTime.MaxValue;
         }
         else {
            if (-AddValue.Ticks >= Value.Ticks) return DateTime.MinValue;
         }
         return Value + AddValue;
      }

      public override int GetHashCode() {
         return
            _Schedule.GetHashCode() +
            _OffsetTime.GetHashCode();
      }
   }
}
