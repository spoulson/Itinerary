using System.Collections.Generic;
using Expl.Itinerary;
using Expl.Itinerary.Parser;

namespace TDL_Explorer {
   public class Examples {
      public static IEnumerable<IExampleItem> GetExampleList() {
         return new IExampleItem[] {
            new ExampleGroup("Intervals") {
               Items = new IExampleItem[] {
                  new ExampleSchedule("Every day", "every T1.0:0:0 lasting T1.0:0:0"),
                  new ExampleSchedule("Every hour", "every T1:0:0 lasting T1:0:0"),
                  new ExampleSchedule("Every 30 minutes", "every T30:0 lasting T30:0"),
                  new ExampleSchedule("Every 15 minutes", "every T15:0 lasting T15:0"),
                  new ExampleSchedule("Every 5 minutes", "every T5:0 lasting T5:0"),
                  new ExampleSchedule("Every minute", "every T1:0 lasting T1:0"),
                  new ExampleSchedule("Every 30 seconds", "every T30 lasting T30"),
                  new ExampleSchedule("Every 15 seconds", "every T15 lasting T15"),
                  new ExampleSchedule("Every 10 seconds", "every T10 lasting T10"),
                  new ExampleSchedule("Every 5 seconds", "every T5 lasting T5"),
                  new ExampleSchedule("Every second", "every T1 lasting T1")
               }
            },
            new ExampleGroup("Days of the week") {
               Items = new IExampleItem[] {
                  new ExampleSchedule("Mondays", "every T7.0:0:0 since 2008-01-07 lasting T1.0:0:0"),
                  new ExampleSchedule("Tuesdays", "every T7.0:0:0 since 2008-01-01 lasting T1.0:0:0"),
                  new ExampleSchedule("Wednesdays", "every T7.0:0:0 since 2008-01-02 lasting T1.0:0:0"),
                  new ExampleSchedule("Thursdays", "every T7.0:0:0 since 2008-01-03 lasting T1.0:0:0"),
                  new ExampleSchedule("Fridays", "every T7.0:0:0 since 2008-01-04 lasting T1.0:0:0"),
                  new ExampleSchedule("Saturdays", "every T7.0:0:0 since 2008-01-05 lasting T1.0:0:0"),
                  new ExampleSchedule("Sundays", "every T7.0:0:0 since 2008-01-06 lasting T1.0:0:0"),
                  new ExampleSchedule("Weekends", "every T7.0:0:0 since 2008-01-05 lasting T1.0:0:0, every T7.0:0:0 since 2008-01-06 lasting T1.0:0:0"),
                  new ExampleSchedule("Weekdays", "every T1.0:0:0 lasting T1.0:0:0 !& (every T7.0:0:0 since 2008-01-05 lasting T1.0:0:0, every T7.0:0:0 since 2008-01-06 lasting T1.0:0:0)"),
               }
            },
            new ExampleGroup("Months") {
               Items = new IExampleItem[] {
                  new ExampleSchedule("January", "cron 0 0 1 1 * lasting T31.0:0:0"),
                  new ExampleSchedule("February", "(cron 0 0 * 2 * lasting T1.0:0:0 | void)"),
                  new ExampleSchedule("March", "cron 0 0 1 3 * lasting T31.0:0:0"),
                  new ExampleSchedule("April", "cron 0 0 1 4 * lasting T30.0:0:0"),
                  new ExampleSchedule("May", "cron 0 0 1 5 * lasting T31.0:0:0"),
                  new ExampleSchedule("June", "cron 0 0 1 6 * lasting T30.0:0:0"),
                  new ExampleSchedule("July", "cron 0 0 1 7 * lasting T31.0:0:0"),
                  new ExampleSchedule("August", "cron 0 0 1 8 * lasting T31.0:0:0"),
                  new ExampleSchedule("September", "cron 0 0 1 9 * lasting T30.0:0:0"),
                  new ExampleSchedule("October", "cron 0 0 1 10 * lasting T31.0:0:0"),
                  new ExampleSchedule("November", "cron 0 0 1 11 * lasting T30.0:0:0"),
                  new ExampleSchedule("December", "cron 0 0 1 12 * lasting T31.0:0:0"),
               }
            },
            new ExampleGroup("US Holidays") {
               Items = new IExampleItem[] {
                  new ExampleSchedule("New Year's Day", "cron 0 0 1 1 * lasting T1.0:0:0"),
                  new ExampleSchedule("Martin Luther King, Jr. Day", "week 3 1 && cron 0 0 1 1 * lasting T31.0:0:0"),
                  new ExampleSchedule("Washington's Birthday", "week 3 1 && (cron 0 0 * 2 * lasting T1.0:0:0 | void)"),
                  new ExampleSchedule("Valentine's Day", "cron 0 0 14 2 * lasting T1.0:0:0"),
                  new ExampleSchedule("St. Patrick's Day", "cron 0 0 17 3 * lasting T1.0:0:0"),
                  new ExampleSchedule("Memorial Day", "cron 0 0 >24 5 1 lasting T1.0:0:0"),
                  new ExampleSchedule("Independence Day", "cron 0 0 4 7 * lasting T1.0:0:0"),
                  new ExampleSchedule("Labor Day", "week 1 1 && cron 0 0 1 9 * lasting T30.0:0:0"),
                  new ExampleSchedule("Columbus Day", "week 2 1 && cron 0 0 1 10 * lasting T31.0:0:0"),
                  new ExampleSchedule("Halloween", "cron 0 0 31 10 * lasting T1.0:0:0"),
                  new ExampleSchedule("Veteran's Day", "cron 0 0 11 11 * lasting T1.0:0:0"),
                  new ExampleSchedule("Thanksgiving Day", "week 4 4 && cron 0 0 1 11 * lasting T30.0:0:0"),
                  new ExampleSchedule("Christmas Eve", "cron 0 0 24 12 * lasting T1.0:0:0"),
                  new ExampleSchedule("Christmas Day", "cron 0 0 25 12 * lasting T1.0:0:0"),
                  new ExampleSchedule("New Year's Eve", "cron 0 0 31 12 * lasting T1.0:0:0")
               }
            }
         };
      }
   }

   public interface IExampleItem {
      string Name { get; }
   }

   public class ExampleGroup : IExampleItem {
      public ExampleGroup(string name) {
         this.Name = name;
         this.Items = new IExampleItem[0];
      }

      public ExampleGroup(string name, IEnumerable<IExampleItem> items) {
         this.Name = name;
         this.Items = items;
      }

      public string Name { get; private set; }
      public IEnumerable<IExampleItem> Items { get; set; }
   }

   /// <summary>
   /// Example name and schedule pair.
   /// </summary>
   public class ExampleSchedule : IExampleItem {
      public ExampleSchedule(string name, string tdl) {
         this.Name = name;
         this.Schedule = TDLParser.Parse(tdl);
      }

      public ExampleSchedule(string name, ISchedule schedule) {
         this.Name = name;
         this.Schedule = schedule;
      }

      public string Name { get; private set; }
      public ISchedule Schedule { get; private set; }
   }
}
