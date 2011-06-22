using System;
using System.Collections.Generic;
using System.Text;

namespace Expl.Itinerary {
   /// <summary>
   /// Schedule once at a set time.
   /// </summary>
   [Serializable]
   public class OneTimeSchedule : IPrimitiveSchedule {
      private enum NotationKind {
         Lasting, To
      }

      private TimedEvent _Event;
      private NotationKind _Notation;

      /// <summary>
      /// Default constructor.
      /// </summary>
      public OneTimeSchedule()
         : this(DateTime.MinValue, TimeSpan.Zero) { }

      /// <summary>
      /// Constructor for event with a start time and duration.
      /// </summary>
      /// <param name="EventTime">Date/time of event.</param>
      /// <param name="Duration">Duration of event.</param>
      public OneTimeSchedule(DateTime StartTime, TimeSpan Duration) {
         _Event = new TimedEvent(StartTime, Duration);
         _Notation = NotationKind.Lasting;
      }

      /// <summary>
      /// Constructor for event with a start and end time.
      /// </summary>
      /// <param name="StartTime"></param>
      /// <param name="EndTime"></param>
      public OneTimeSchedule(DateTime StartTime, DateTime EndTime) {
         _Event = new TimedEvent(StartTime, EndTime);
         _Notation = NotationKind.To;
      }

      public int OperatorPrecedence { get { return 1; } }

      public TimedEvent Event { get { return _Event; } }

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append(ItineraryConvert.ToString(_Event.StartTime));

         // Output TDL in same notation used to create this.
         switch (_Notation) {
         case NotationKind.Lasting:
            TimeSpan Duration = _Event.Duration;
            if (Duration != TimeSpan.Zero) {
               sb.Append(" lasting ");
               sb.Append(ItineraryConvert.ToString(Duration));
            }
            break;

         case NotationKind.To:
            sb.Append(" to ");
            sb.Append(ItineraryConvert.ToString(_Event.EndTime));
            break;
         }

         return sb.ToString();
      }

      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         // Check event intersection with range
         if (_Event.Intersects(new TimedEvent(RangeStart, RangeEnd)))
            yield return _Event;

         yield break;
      }

      public override int GetHashCode() {
         return
            _Event.GetHashCode() +
            _Notation.GetHashCode();
      }
   }
}
