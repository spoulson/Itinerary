using System;
using System.Collections.Generic;
using System.Text;

namespace Expl.Itinerary {
   /// <summary>
   /// Schedule once at a set time.
   /// </summary>
   public class OneTimeSchedule : IPrimitiveSchedule {
      protected TimedEvent _Event;

      /// <summary>
      /// Default constructor
      /// </summary>
      public OneTimeSchedule()
         : this(DateTime.MinValue, TimeSpan.Zero) { }

      /// <summary>
      /// Constructor for event with a start time and duration
      /// </summary>
      /// <param name="EventTime">Date/time of event</param>
      /// <param name="Duration">Duration of event</param>
      public OneTimeSchedule(DateTime StartTime, TimeSpan Duration) {
         _Event = new TimedEvent(StartTime, Duration);
      }

      /// <summary>
      /// Constructor for event with a start and end time
      /// </summary>
      /// <param name="StartTime"></param>
      /// <param name="EndTime"></param>
      public OneTimeSchedule(DateTime StartTime, DateTime EndTime) {
         _Event = new TimedEvent(StartTime, EndTime);
      }

      public int OperatorPrecedence { get { return 1; } }

      public TimedEvent Event { get { return _Event; } }

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append(ItineraryConvert.ToString(_Event.StartTime));
         TimeSpan Duration = _Event.Duration;
         if (Duration != TimeSpan.Zero) {
            sb.Append(" lasting ");
            sb.Append(ItineraryConvert.ToString(Duration));
         }
         return sb.ToString();
         //return string.Format("{0} lasting {1}", ItineraryConvert.ToString(_Event.StartTime), ItineraryConvert.ToString(_Event.Duration));
      }

      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         // Check event intersection with range
         if (_Event.Intersects(new TimedEvent(RangeStart, RangeEnd)))
            yield return _Event;

         yield break;
      }
   }
}
