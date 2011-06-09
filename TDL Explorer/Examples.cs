using System.Collections.Generic;
using Expl.Itinerary;
using Expl.Itinerary.Parser;

namespace TDL_Explorer {
   public class Examples {
      public static IEnumerable<ExampleItem> GetExampleList() {
         return new[] {
            new ExampleItem("Every day", "every T1.0:0:0 lasting T1.0:0:0"),
            new ExampleItem("Mondays", "every T7.0:0:0 since 2008-01-07 lasting T1.0:0:0"),
            new ExampleItem("Tuesdays", "every T7.0:0:0 since 2008-01-01 lasting T1.0:0:0"),
            new ExampleItem("Wednesdays", "every T7.0:0:0 since 2008-01-02 lasting T1.0:0:0"),
            new ExampleItem("Thursdays", "every T7.0:0:0 since 2008-01-03 lasting T1.0:0:0"),
            new ExampleItem("Fridays", "every T7.0:0:0 since 2008-01-04 lasting T1.0:0:0"),
            new ExampleItem("Saturdays", "every T7.0:0:0 since 2008-01-05 lasting T1.0:0:0"),
            new ExampleItem("Sundays", "every T7.0:0:0 since 2008-01-06 lasting T1.0:0:0"),
            new ExampleItem("Weekends", "every T7.0:0:0 since 2008-01-05 lasting T1.0:0:0, every T7.0:0:0 since 2008-01-06 lasting T1.0:0:0"),
            new ExampleItem("Weekdays", "every T1.0:0:0 lasting T1.0:0:0 !& (every T7.0:0:0 since 2008-01-05 lasting T1.0:0:0, every T7.0:0:0 since 2008-01-06 lasting T1.0:0:0)"),
            new ExampleItem("Every hour", "every T1:0:0 lasting T1:0:0"),
            new ExampleItem("Every 30 minutes", "every T30:0 lasting T30:0"),
            new ExampleItem("Every 15 minutes", "every T15:0 lasting T15:0"),
            new ExampleItem("Every 5 minutes", "every T5:0 lasting T5:0"),
            new ExampleItem("Every minute", "every T1:0 lasting T1:0"),
            new ExampleItem("Every 30 seconds", "every T30 lasting T30"),
            new ExampleItem("Every 15 seconds", "every T15 lasting T15"),
            new ExampleItem("Every 10 seconds", "every T10 lasting T10"),
            new ExampleItem("Every 5 seconds", "every T5 lasting T5"),
            new ExampleItem("Every second", "every T1 lasting T1"),
            new ExampleItem("January", "cron 0 0 1 1 * lasting T31.0:0:0"),
            new ExampleItem("February", "(cron 0 0 * 2 * lasting T1.0:0:0 | void)"),
            new ExampleItem("March", "cron 0 0 1 3 * lasting T31.0:0:0"),
            new ExampleItem("April", "cron 0 0 1 4 * lasting T30.0:0:0"),
            new ExampleItem("May", "cron 0 0 1 5 * lasting T31.0:0:0"),
            new ExampleItem("June", "cron 0 0 1 6 * lasting T30.0:0:0"),
            new ExampleItem("July", "cron 0 0 1 7 * lasting T31.0:0:0"),
            new ExampleItem("August", "cron 0 0 1 8 * lasting T31.0:0:0"),
            new ExampleItem("September", "cron 0 0 1 9 * lasting T30.0:0:0"),
            new ExampleItem("October", "cron 0 0 1 10 * lasting T31.0:0:0"),
            new ExampleItem("November", "cron 0 0 1 11 * lasting T30.0:0:0"),
            new ExampleItem("December", "cron 0 0 1 12 * lasting T31.0:0:0"),

            new ExampleItem("New Year's Day", "cron 0 0 1 1 * lasting T1.0:0:0"),
            new ExampleItem("Martin Luther King, Jr. Day", "week 3 1 && cron 0 0 1 1 * lasting T31.0:0:0"),
            new ExampleItem("Washington's Birthday", "week 3 1 && (cron 0 0 * 2 * lasting T1.0:0:0 | void)"),
            new ExampleItem("Valentine's Day", "cron 0 0 14 2 * lasting T1.0:0:0"),
            new ExampleItem("St. Patrick's Day", "cron 0 0 17 3 * lasting T1.0:0:0"),
            new ExampleItem("Memorial Day", "cron 0 0 >24 5 1 lasting T1.0:0:0"),
            new ExampleItem("Independence Day", "cron 0 0 4 7 * lasting T1.0:0:0"),
            new ExampleItem("Labor Day", "week 1 1 && cron 0 0 1 9 * lasting T30.0:0:0"),
            new ExampleItem("Columbus Day", "week 2 1 && cron 0 0 1 10 * lasting T31.0:0:0"),
            new ExampleItem("Halloween", "cron 0 0 31 10 * lasting T1.0:0:0"),
            new ExampleItem("Veteran's Day", "cron 0 0 11 11 * lasting T1.0:0:0"),
            new ExampleItem("Thanksgiving Day", "week 4 4 && cron 0 0 1 11 * lasting T30.0:0:0"),
            new ExampleItem("Christmas Eve", "cron 0 0 24 12 * lasting T1.0:0:0"),
            new ExampleItem("Christmas Day", "cron 0 0 25 12 * lasting T1.0:0:0"),
            new ExampleItem("New Year's Eve", "cron 0 0 31 12 * lasting T1.0:0:0")
         };
      }
   }

   /// <summary>
   /// Example name and schedule pair.
   /// </summary>
   public class ExampleItem {
      public string Name { get; private set; }
      public ISchedule Schedule { get; private set; }

      public ExampleItem(string name, string tdl) {
         this.Name = name;
         this.Schedule = TDLParser.Parse(tdl);
      }

      public ExampleItem(string name, ISchedule schedule) {
         this.Name = name;
         this.Schedule = schedule;
      }
   }
}
