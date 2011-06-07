using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Expl.Itinerary {
   [Description("Limit")]
   public class LimitSchedule : IFilterSchedule {
      protected DateTime _LimitStart, _LimitEnd;
      protected TimedEvent _LimitEvent;
      protected ISchedule _Schedule;
      private static VoidSchedule _VoidSchedule = new VoidSchedule();

      /// <summary>
      /// Default constructor
      /// </summary>
      public LimitSchedule()
         : this(DateTime.MinValue, DateTime.MaxValue, new VoidSchedule()) { }

      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="LimitStart">Start time</param>
      /// <param name="LimitEnd">End time</param>
      /// <param name="Schedule">Schedule</param>
      public LimitSchedule(DateTime LimitStart, DateTime LimitEnd, ISchedule Schedule) {
         _LimitStart = LimitStart;
         _LimitEnd = LimitEnd;
         _LimitEvent = new TimedEvent(_LimitStart, _LimitEnd);
         _Schedule = Schedule;
      }

      public int OperatorPrecedence { get { return 10; } }

      public override string ToString() {
         string SchedString = _Schedule.OperatorPrecedence > this.OperatorPrecedence ? "(" + _Schedule.ToString() + ")" : _Schedule.ToString();
         return string.Format("{0} <= {1} < {2}", ItineraryConvert.ToString(_LimitStart), SchedString, ItineraryConvert.ToString(_LimitEnd));
      }

      public ISchedule BaseSchedule {
         get { return _Schedule; }
      }

      public int MinSchedules {
         get { return 1; }
      }

      public int MaxSchedules {
         get { return 1; }
      }

      public DateTime LimitStart {
         get { return _LimitStart; }
      }

      public DateTime LimitEnd {
         get { return _LimitEnd; }
      }

      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         // Find intersecting ranges between requested range and limited range
         TimedEvent Evt1 = _LimitEvent.Intersection(new TimedEvent(RangeStart, RangeEnd));

         // No intersection means no possible events
         if (Evt1 == null) return _VoidSchedule.GetRange(DateTime.MinValue, DateTime.MaxValue);

         // Return events in intersecting time range
         return _Schedule.GetRange(Evt1.StartTime, Evt1.EndTime);
      }
   }
}
