using System;
using System.Collections.Generic;
using System.Linq;
using Expl.Itinerary;

namespace Example2 {
   class Program {
      static void Main(string[] args) {
         // Create schedule programmatically.
         ISchedule schedule1 = new IntervalSchedule(TimeSpan.FromSeconds(11), TimeSpan.Zero, DateTime.MinValue);
         ISchedule schedule2 = new IntervalSchedule(TimeSpan.FromMinutes(1), TimeSpan.Zero, DateTime.MinValue.AddSeconds(1));
         ISchedule schedule3 = new CronSchedule("*/5", "*", "*", "*", "*", TimeSpan.Zero);
         ISchedule combinedSchedule = new ListSchedule(new[] { schedule1, schedule2, schedule3 });

         // Print schedule TDL.
         Console.WriteLine("Forecasting events from expression:\n{0}", combinedSchedule.ToString());

         // Forecast timed events for the next hour.
         IEnumerable<TimedEvent> events = combinedSchedule.GetRange(DateTime.Now, DateTime.Now.AddHours(1));

         int eventCount = events.Count();
         Console.WriteLine("Found {0:d} events.", eventCount);

         // Print to screen.
         foreach (TimedEvent e in events) {
            Console.WriteLine("Event time: {0:G}", e.StartTime);
         }
      }
   }
}
