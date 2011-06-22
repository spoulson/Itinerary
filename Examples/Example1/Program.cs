using System;
using System.Collections.Generic;
using System.Linq;
using Expl.Itinerary;
using Expl.Itinerary.Parser;

namespace Example1 {
   class Program {
      static void Main(string[] args) {
         // TDL expression.
         string tdlExpression = "every T30";

         // Parse to ISchedule.
         ISchedule schedule = TDLParser.Parse(tdlExpression);

         // Forecast timed events for the next hour.
         IEnumerable<TimedEvent> events = schedule.GetRange(DateTime.Now, DateTime.Now.AddHours(1));

         int eventCount = events.Count();
         Console.WriteLine("Found {0:d} events.", eventCount);

         // Print to screen.
         foreach (TimedEvent e in events) {
            Console.WriteLine("Event time: {0:G}", e.StartTime);
         }
      }
   }
}
