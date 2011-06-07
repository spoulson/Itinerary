using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Expl.Itinerary {
   /// <summary>
   /// Filter by week of the month
   /// </summary>
   [Description("Week")]
   public class WeekSchedule : IFilterSchedule {
      protected ISchedule _Schedule;
      protected int _Ordinal, _DayOfWeek;

      public WeekSchedule(int Ordinal, int DayOfWeek) {
         _Ordinal = Ordinal;
         _DayOfWeek = DayOfWeek;
      }

      public ISchedule BaseSchedule { get { return _Schedule; } }

      public int Ordinal { get { return _Ordinal; } }
      public int DayOfWeek { get { return _DayOfWeek; } }

      public int OperatorPrecedence { get { return 10; } }

      public override string ToString() {
         string SchedString = _Schedule.OperatorPrecedence > this.OperatorPrecedence ? "(" + _Schedule.ToString() + ")" : _Schedule.ToString();
         return SchedString + " week " + _DayOfWeek.ToString();
      }

      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         return _Schedule.GetRange(RangeStart, RangeEnd).Where(new Func<TimedEvent, bool>(IsInWeek));
      }

      /// <summary>
      /// Check if this event intersects the specified week
      /// </summary>
      /// <param name="Event">TimedEvent to compare</param>
      /// <returns>True if event intersects specified week</returns>
      private bool IsInWeek(TimedEvent Event) {
         //// Naive algorithm
         //// There should be a way to compue this without iterating every month of every event
         //TimedEvent WeekEvent = new TimedEvent(Calendar.GetWeekStart(Event.StartTime.Year, Event.StartTime.Month, _Week), new TimeSpan(7, 0, 0, 0));
         //DateTime WorkDate = new DateTime(Event.StartTime.Year, Event.StartTime.Month, 1);
         //while (WorkDate < Event.EndTime) {
         //   if (Event.Intersects(WeekEvent)) return true;
         //   WorkDate = WorkDate.AddMonths(1);
         //}
         return false;
      }

      //private static int DaysPassed(int Year, int Month) {
      //   if (Month == 1) return 0;
      //   else return MonthLength(Year, Month) + DaysPassed(Year, Month - 1);
      //}
   }
}
