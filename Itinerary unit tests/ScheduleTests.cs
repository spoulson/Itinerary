using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Expl.Itinerary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expl.Itinerary.Test {
   [TestClass]
   public class ScheduleTests {
      [TestMethod]
      public void VoidTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test void",
               new VoidSchedule(),
               new TimedEvent[] { }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void OneTimeTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test no duration",
               new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.Zero),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test short duration",
               new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(0, 30, 0)),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(0, 30, 0))
               }
            ),
            new ScheduleUnitTest("Test day boundary",
               new OneTimeSchedule(new DateTime(2008, 1, 1, 22, 0, 0), new TimeSpan(4, 0, 0)),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 22, 0, 0), new TimeSpan(4, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test month boundary",
               new OneTimeSchedule(new DateTime(2008, 1, 31, 22, 0, 0), new TimeSpan(4, 0, 0)),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 22, 0, 0), new TimeSpan(4, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test leap year 2008",
               new OneTimeSchedule(new DateTime(2008, 2, 28, 22, 0, 0), new TimeSpan(4, 0, 0)),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 2, 28, 22, 0, 0), new TimeSpan(4, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test leap year 2004",
               new OneTimeSchedule(new DateTime(2004, 2, 28, 22, 0, 0), new TimeSpan(4, 0, 0)),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2004, 2, 28, 22, 0, 0), new TimeSpan(4, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test non-leap year 2007",
               new OneTimeSchedule(new DateTime(2007, 2, 28, 22, 0, 0), new TimeSpan(4, 0, 0)),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2007, 2, 28, 22, 0, 0), new TimeSpan(4, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test non-leap year 2006",
               new OneTimeSchedule(new DateTime(2006, 2, 28, 22, 0, 0), new TimeSpan(4, 0, 0)),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2006, 2, 28, 22, 0, 0), new TimeSpan(4, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test non-leap year 2005",
               new OneTimeSchedule(new DateTime(2005, 2, 28, 22, 0, 0), new TimeSpan(4, 0, 0)),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2005, 2, 28, 22, 0, 0), new TimeSpan(4, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test partial match, left",
               // EEEE
               //   WWWW
               new OneTimeSchedule(new DateTime(2008, 6, 9, 8, 0, 0), new TimeSpan(4, 0, 0)),
               new DateTime(2008, 6, 9, 10, 0, 0), new DateTime(2008, 6, 9, 14, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 6, 9, 8, 0, 0), new TimeSpan(4, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test partial match, right",
               //   EEEE
               // WWWW
               new OneTimeSchedule(new DateTime(2008, 6, 9, 12, 0, 0), new TimeSpan(4, 0, 0)),
               new DateTime(2008, 6, 9, 10, 0, 0), new DateTime(2008, 6, 9, 14, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 6, 9, 12, 0, 0), new TimeSpan(4, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test event start/end outside time window",
               // EEEEEEEE
               //   WWWW
               new OneTimeSchedule(new DateTime(2008, 6, 9, 8, 0, 0), new TimeSpan(8, 0, 0)),
               new DateTime(2008, 6, 9, 10, 0, 0), new DateTime(2008, 6, 9, 14, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 6, 9, 8, 0, 0), new TimeSpan(8, 0, 0))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void IntervalTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test millisecond interval",
               new IntervalSchedule(new TimeSpan(0, 0, 0, 0, 100), TimeSpan.Zero, new DateTime(2008, 1, 1, 0, 0, 0)),
               new DateTime(2008, 1, 1, 0, 0, 0), new DateTime(2008, 1, 1, 0, 0, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0, 100), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0, 200), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0, 300), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0, 400), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0, 500), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0, 600), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0, 700), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0, 800), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0, 900), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test second interval",
               new IntervalSchedule(new TimeSpan(0, 0, 1), TimeSpan.Zero, new DateTime(2008, 1, 1, 0, 0, 0)),
               new DateTime(2008, 1, 1, 0, 0, 0), new DateTime(2008, 1, 1, 0, 0, 10),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 1), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 2), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 3), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 4), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 5), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 6), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 7), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 8), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 9), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test minute interval",
               new IntervalSchedule(new TimeSpan(0, 1, 0), TimeSpan.Zero, new DateTime(2008, 1, 1, 0, 0, 0)),
               new DateTime(2008, 1, 1, 0, 0, 0), new DateTime(2008, 1, 1, 0, 10, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 1, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 2, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 3, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 4, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 5, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 6, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 7, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 8, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 9, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test hour interval",
               new IntervalSchedule(new TimeSpan(1, 0, 0), TimeSpan.Zero, new DateTime(2008, 1, 1, 0, 0, 0)),
               new DateTime(2008, 1, 1, 0, 0, 0), new DateTime(2008, 1, 1, 10, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 1, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 2, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 3, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 4, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 5, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 6, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 7, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 8, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 9, 0, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test day interval",
               new IntervalSchedule(new TimeSpan(1, 0, 0, 0), TimeSpan.Zero, new DateTime(2008, 1, 1, 0, 0, 0)),
               new DateTime(2008, 1, 1, 0, 0, 0), new DateTime(2008, 1, 11, 0, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 2, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 3, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 4, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 5, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 6, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 7, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 8, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 9, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 10, 0, 0, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test week interval",
               new IntervalSchedule(new TimeSpan(7, 0, 0, 0), TimeSpan.Zero, new DateTime(2008, 1, 1, 0, 0, 0)),
               new DateTime(2008, 1, 1, 0, 0, 0), new DateTime(2008, 3, 5, 0, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 8, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 15, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 22, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 29, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 5, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 12, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 19, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 26, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 3, 4, 0, 0, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test odd interval",
               new IntervalSchedule(new TimeSpan(0, 9, 0), TimeSpan.Zero, new DateTime(2008, 1, 1, 0, 0, 0)),
               new DateTime(2008, 1, 1, 0, 0, 0), new DateTime(2008, 1, 1, 1, 45, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 9, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 18, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 27, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 36, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 45, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 54, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 1, 3, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 1, 12, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 1, 21, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 1, 30, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 1, 39, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test offset sync date",
               new IntervalSchedule(new TimeSpan(0, 3, 0), TimeSpan.Zero, new DateTime(2008, 1, 1, 0, 10, 0)),
               new DateTime(2008, 1, 1, 0, 0, 0), new DateTime(2008, 1, 1, 0, 30, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 1, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 4, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 7, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 10, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 13, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 16, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 19, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 22, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 25, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 28, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test partial match, left",
               new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 30, 0), new DateTime(2008, 1, 1, 0, 0, 0)),
               new DateTime(2008, 1, 1, 0, 15, 0), new DateTime(2008, 1, 2, 0, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 1, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 2, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 3, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 4, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 5, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 6, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 7, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 8, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 9, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 10, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 11, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 12, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 13, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 14, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 15, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 16, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 17, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 18, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 19, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 20, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 21, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 22, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 23, 0, 0), new TimeSpan(0, 30, 0))
               }
            ),
            new ScheduleUnitTest("Test partial match, right",
               new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 30, 0), new DateTime(2008, 1, 1, 0, 0, 0)),
               new DateTime(2008, 1, 1, 0, 0, 0), new DateTime(2008, 1, 2, 0, 45, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 1, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 2, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 3, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 4, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 5, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 6, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 7, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 8, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 9, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 10, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 11, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 12, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 13, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 14, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 15, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 16, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 17, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 18, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 19, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 20, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 21, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 22, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 23, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 2, 0, 0, 0), new TimeSpan(0, 30, 0))
               }
            ),
            new ScheduleUnitTest("Test event start/end outside time window",
               new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 30, 0), new DateTime(2008, 1, 1, 0, 0, 0)),
               new DateTime(2008, 1, 1, 0, 15, 0), new DateTime(2008, 1, 2, 0, 45, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 1, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 2, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 3, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 4, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 5, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 6, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 7, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 8, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 9, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 10, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 11, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 12, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 13, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 14, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 15, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 16, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 17, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 18, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 19, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 20, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 21, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 22, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 1, 23, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 2, 0, 0, 0), new TimeSpan(0, 30, 0))
               }
            ),
            new ScheduleUnitTest("Test every hour",
               new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(1, 0, 0), DateTime.MinValue),
               new DateTime(2008, 7, 16), new DateTime(2008, 7, 17),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 7, 16, 0, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 1, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 2, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 3, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 4, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 5, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 6, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 7, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 8, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 9, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 10, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 11, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 12, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 13, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 14, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 15, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 16, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 17, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 18, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 19, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 20, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 21, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 22, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 23, 0, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test near DateTime.MinValue",
               new IntervalSchedule(new TimeSpan(0, 1, 0), TimeSpan.Zero, DateTime.MinValue),
               DateTime.MinValue, new DateTime(0001, 1, 1, 0, 15, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 1, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 2, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 3, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 4, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 5, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 6, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 7, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 8, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 9, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 10, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 11, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 12, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 13, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 14, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test near DateTime.MinValue with duration",
               new IntervalSchedule(new TimeSpan(0, 1, 0), new TimeSpan(0, 1, 0), DateTime.MinValue),
               DateTime.MinValue, new DateTime(0001, 1, 1, 0, 15, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 0, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 1, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 2, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 3, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 4, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 5, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 6, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 7, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 8, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 9, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 10, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 11, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 12, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 13, 0), new TimeSpan(0, 1, 0)),
                  new TimedEvent(new DateTime(0001, 1, 1, 0, 14, 0), new TimeSpan(0, 1, 0))
               }
            ),
            new ScheduleUnitTest("Test near DateTime.MaxValue",
               new IntervalSchedule(new TimeSpan(0, 1, 0), TimeSpan.Zero, DateTime.MinValue),
               new DateTime(9999, 12, 31, 23, 45, 0), DateTime.MaxValue,
               new TimedEvent[] {
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 45, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 46, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 47, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 48, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 49, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 50, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 51, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 52, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 53, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 54, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 55, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 56, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 57, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 58, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 59, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test near DateTime.MaxValue with duration",
               new IntervalSchedule(new TimeSpan(0, 1, 0), new TimeSpan(0, 0, 59), DateTime.MinValue),
               new DateTime(9999, 12, 31, 23, 45, 0), DateTime.MaxValue,
               new TimedEvent[] {
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 45, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 46, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 47, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 48, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 49, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 50, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 51, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 52, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 53, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 54, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 55, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 56, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 57, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 58, 0), new TimeSpan(0, 0, 59)),
                  new TimedEvent(new DateTime(9999, 12, 31, 23, 59, 0), new TimeSpan(0, 0, 59))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void DayOfWeekTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test Mondays",
               new DayOfWeekSchedule("1"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 1), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 15), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 22), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 29), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test Tuesdays",
               new DayOfWeekSchedule("2"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 2), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 9), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 16), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 23), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 30), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test Wednesdays",
               new DayOfWeekSchedule("3"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 3), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 10), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 17), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 24), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test Thursdays",
               new DayOfWeekSchedule("4"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 4), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 11), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 18), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 25), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test Fridays",
               new DayOfWeekSchedule("5"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 5), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 12), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 19), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 26), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test Saturdays",
               new DayOfWeekSchedule("6"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 6), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 13), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 20), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 27), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test Sundays",
               new DayOfWeekSchedule("0"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 7), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 14), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 21), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 28), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test Weekdays",
               new DayOfWeekSchedule("1-5"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 1), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 2), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 3), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 4), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 5), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 9), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 10), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 11), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 12), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 15), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 16), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 17), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 18), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 19), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 22), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 23), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 24), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 25), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 26), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 29), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 30), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test month end boundary",
               new DayOfWeekSchedule("*"),
               new DateTime(2008, 9, 29), new DateTime(2008, 10, 3),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 29), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 30), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 10, 1), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 10, 2), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("First Mondays",
               new DayOfWeekSchedule("1", "1"),
               new DateTime(2008, 10, 1), new DateTime(2009, 2, 1),
               new TimedEvent[] {
                  //new TimedEvent(new DateTime(2008, 9, 1), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 10, 6), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 3), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 1), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2009, 1, 5), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Third Fridays",
               new DayOfWeekSchedule("3", "5"),
               new DateTime(2008, 9, 1), new DateTime(2009, 2, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 19), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 10, 17), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 21), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 19), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2009, 1, 16), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("1st week, month starts on a Monday",
               new DayOfWeekSchedule("1", "*"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 1), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 2), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 3), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 4), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 5), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 6), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 7), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("2nd week, month starts on a Monday",
               new DayOfWeekSchedule("2", "*"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 8), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 9), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 10), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 11), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 12), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 13), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 14), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("3rd week, month starts on a Monday",
               new DayOfWeekSchedule("3", "*"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 15), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 16), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 17), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 18), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 19), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 20), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 21), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("4th week, month starts on a Monday",
               new DayOfWeekSchedule("4", "*"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 22), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 23), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 24), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 25), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 26), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 27), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 28), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("5th week, month starts on a Monday",
               new DayOfWeekSchedule("5", "*"),
               new DateTime(2008, 9, 1), new DateTime(2008, 10, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 29), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 30), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("1st week, month starts on a Sunday",
               new DayOfWeekSchedule("1", "*"),
               new DateTime(2008, 6, 1), new DateTime(2008, 7, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 6, 1), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 2), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 3), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 4), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 5), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 6), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 7), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("2nd week, month starts on a Sunday",
               new DayOfWeekSchedule("2", "*"),
               new DateTime(2008, 6, 1), new DateTime(2008, 7, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 6, 8), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 9), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 10), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 11), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 12), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 13), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 14), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("3rd week, month starts on a Sunday",
               new DayOfWeekSchedule("3", "*"),
               new DateTime(2008, 6, 1), new DateTime(2008, 7, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 6, 15), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 16), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 17), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 18), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 19), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 20), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 21), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("4th week, month starts on a Sunday",
               new DayOfWeekSchedule("4", "*"),
               new DateTime(2008, 6, 1), new DateTime(2008, 7, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 6, 22), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 23), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 24), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 25), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 26), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 27), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 28), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("5th week, month starts on a Sunday",
               new DayOfWeekSchedule("5", "*"),
               new DateTime(2008, 6, 1), new DateTime(2008, 7, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 6, 29), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 6, 30), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("1st week, month starts on a Saturday",
               new DayOfWeekSchedule("1", "*"),
               new DateTime(2008, 11, 1), new DateTime(2008, 12, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 11, 1), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 2), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 3), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 4), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 5), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 6), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 7), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("2nd week, month starts on a Saturday",
               new DayOfWeekSchedule("2", "*"),
               new DateTime(2008, 11, 1), new DateTime(2008, 12, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 11, 8), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 9), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 10), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 11), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 12), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 13), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 14), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("3rd week, month starts on a Saturday",
               new DayOfWeekSchedule("3", "*"),
               new DateTime(2008, 11, 1), new DateTime(2008, 12, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 11, 15), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 16), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 17), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 18), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 19), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 20), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 21), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("4th week, month starts on a Saturday",
               new DayOfWeekSchedule("4", "*"),
               new DateTime(2008, 11, 1), new DateTime(2008, 12, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 11, 22), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 23), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 24), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 25), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 26), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 27), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 28), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("5th week, month starts on a Saturday",
               new DayOfWeekSchedule("5", "*"),
               new DateTime(2008, 11, 1), new DateTime(2008, 12, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 11, 29), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 11, 30), new TimeSpan(1, 0, 0, 0))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void LastingTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test one time event",
               new LastingSchedule(new TimeSpan(1, 0, 0), new OneTimeSchedule(new DateTime(2008, 9, 9), new TimeSpan(0, 10, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 9), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test event within range",
               new LastingSchedule(new TimeSpan(1, 0, 0), new OneTimeSchedule(new DateTime(2008, 9, 9), new TimeSpan(0, 10, 0))),
               new DateTime(2008, 9, 8), new DateTime(2008, 9, 10),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 9), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test event no longer within range",
               new LastingSchedule(new TimeSpan(0, 10, 0), new OneTimeSchedule(new DateTime(2008, 9, 9), new TimeSpan(1, 0, 0))),
               new DateTime(2008, 9, 9, 0, 30, 0), new DateTime(2008, 9, 10),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test interval",
               new LastingSchedule(new TimeSpan(1, 0, 0), new IntervalSchedule(new TimeSpan(2, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue)),
               new DateTime(2008, 9, 8), new DateTime(2008, 9, 9),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 8, 0, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8, 2, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8, 4, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8, 6, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8, 8, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8, 10, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8, 12, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8, 14, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8, 16, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8, 18, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8, 20, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 8, 22, 0, 0), new TimeSpan(1, 0, 0))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void IndexTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test index #0",
               new IndexSchedule("0",
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue)
               ),
               new DateTime(2008, 9, 3, 10, 0, 0), new DateTime(2008, 9, 3, 14, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 3, 10, 0, 0), new TimeSpan(0, 10, 0))
               }
            ),
            new ScheduleUnitTest("Test index #1",
               new IndexSchedule("1",
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue)
               ),
               new DateTime(2008, 9, 3, 10, 0, 0), new DateTime(2008, 9, 3, 14, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 3, 11, 0, 0), new TimeSpan(0, 10, 0))
               }
            ),
            new ScheduleUnitTest("Test index #2",
               new IndexSchedule("2",
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue)
               ),
               new DateTime(2008, 9, 3, 10, 0, 0), new DateTime(2008, 9, 3, 14, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 3, 12, 0, 0), new TimeSpan(0, 10, 0))
               }
            ),
            new ScheduleUnitTest("Test index out of range #4",
               new IndexSchedule("4",
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue)
               ),
               new DateTime(2008, 9, 3, 10, 0, 0), new DateTime(2008, 9, 3, 14, 0, 0),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test multiple indicies",
               new IndexSchedule("0,1,3",
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue)
               ),
               new DateTime(2008, 9, 3, 10, 0, 0), new DateTime(2008, 9, 3, 14, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 3, 10, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 9, 3, 11, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 9, 3, 13, 0, 0), new TimeSpan(0, 10, 0))
               }
            ),
            new ScheduleUnitTest("Test index range",
               new IndexSchedule("1-3",
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue)
               ),
               new DateTime(2008, 9, 3, 10, 0, 0), new DateTime(2008, 9, 3, 14, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 3, 11, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 9, 3, 12, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 9, 3, 13, 0, 0), new TimeSpan(0, 10, 0))
               }
            ),
            new ScheduleUnitTest("Test index range and not single",
               new IndexSchedule("1-3,!2",
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue)
               ),
               new DateTime(2008, 9, 3, 10, 0, 0), new DateTime(2008, 9, 3, 14, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 3, 11, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 9, 3, 13, 0, 0), new TimeSpan(0, 10, 0))
               }
            ),
            new ScheduleUnitTest("Test index range, out of range",
               new IndexSchedule("1-98",
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue)
               ),
               new DateTime(2008, 9, 3, 10, 0, 0), new DateTime(2008, 9, 3, 14, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 3, 11, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 9, 3, 12, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 9, 3, 13, 0, 0), new TimeSpan(0, 10, 0))
               }
            ),
            new ScheduleUnitTest("Test exclusive index",
               new IndexSchedule("*,!0",
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(1, 0, 0), DateTime.MinValue)
               ),
               new DateTime(2008, 9, 3, 10, 0, 0), new DateTime(2008, 9, 3, 14, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 3, 11, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 3, 12, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 9, 3, 13, 0, 0), new TimeSpan(1, 0, 0))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void OffsetTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test positive offset on OneTimeSchedule",
               new OffsetSchedule(
                  new TimeSpan(0, 10, 0),
                  new OneTimeSchedule(new DateTime(2008, 9, 2, 10, 4, 0), TimeSpan.Zero)
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 2, 10, 14, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test offset moved event out of range on OneTimeSchedule",
               new OffsetSchedule(
                  new TimeSpan(0, 10, 0),
                  new OneTimeSchedule(new DateTime(2008, 9, 2, 10, 4, 0), TimeSpan.Zero)
               ),
               new DateTime(2008, 9, 2, 10, 0, 0), new DateTime(2008, 9, 2, 10, 10, 0),
               new TimedEvent[] {}
            ),
            new ScheduleUnitTest("Test offset moved event in range on OneTimeSchedule",
               new OffsetSchedule(
                  new TimeSpan(0, 10, 0),
                  new OneTimeSchedule(new DateTime(2008, 9, 2, 10, 4, 0), TimeSpan.Zero)
               ),
               new DateTime(2008, 9, 2, 10, 10, 0), new DateTime(2008, 9, 2, 10, 30, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 2, 10, 14, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test positive offset range on OneTimeSchedule",
               new OffsetSchedule(
                  new TimeSpan(0, 10, 0),
                  new OneTimeSchedule(new DateTime(2008, 9, 2, 10, 4, 0), TimeSpan.Zero)
               ),
               new DateTime(2008, 9, 1), new DateTime(2008, 9, 3),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 2, 10, 14, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test positive offset range on interval",
               new OffsetSchedule(
                  new TimeSpan(0, 10, 0),
                  new IntervalSchedule(new TimeSpan(1, 0, 0), TimeSpan.Zero, DateTime.MinValue)
               ),
               new DateTime(2008, 9, 2, 18, 0, 0), new DateTime(2008, 9, 3, 0, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 2, 18, 10, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 19, 10, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 20, 10, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 21, 10, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 22, 10, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 23, 10, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test negative offset range",
               new OffsetSchedule(
                  new TimeSpan(0, 10, 0).Negate(),
                  new OneTimeSchedule(new DateTime(2008, 9, 2, 10, 4, 0), TimeSpan.Zero)
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 2, 9, 54, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test negative offset range on interval",
               new OffsetSchedule(
                  new TimeSpan(0, 10, 0).Negate(),
                  new IntervalSchedule(new TimeSpan(1, 0, 0), TimeSpan.Zero, DateTime.MinValue)
               ),
               new DateTime(2008, 9, 2, 18, 0, 0), new DateTime(2008, 9, 3, 0, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 2, 18, 50, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 19, 50, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 20, 50, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 21, 50, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 22, 50, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 23, 50, 0), TimeSpan.Zero)
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void RepeatTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test repeat 0",
               new RepeatSchedule(
                  0, 
                  new OneTimeSchedule(new DateTime(2008, 9, 2), TimeSpan.Zero)
               ),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test repeat 1",
               new RepeatSchedule(
                  1, 
                  new OneTimeSchedule(new DateTime(2008, 9, 2), TimeSpan.Zero)
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 2), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test repeat 5",
               new RepeatSchedule(
                  5, 
                  new OneTimeSchedule(new DateTime(2008, 9, 2), TimeSpan.Zero)
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 2), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test repeat interval",
               new RepeatSchedule(
                  4,
                  new IntervalSchedule(new TimeSpan(1, 0, 0), TimeSpan.Zero, DateTime.MinValue)
               ),
               new DateTime(2008, 9, 2, 5, 0, 0),
               new DateTime(2008, 9, 2, 8, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 9, 2, 5, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 5, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 5, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 5, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 6, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 6, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 6, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 6, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 7, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 7, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 7, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 9, 2, 7, 0, 0), TimeSpan.Zero)
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void IntersectionTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test partial intersection",
               new IntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(0, 30, 0))
               }
            ),
            new ScheduleUnitTest("Test partial intersection, reversed",
               new IntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(0, 30, 0))
               }
            ),
            new ScheduleUnitTest("Test no intersection",
               new IntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))
               ),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test no intersection, reversed",
               new IntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0))
               ),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test complete intersection",
               new IntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test contained intersection",
               new IntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test contained intersection, reversed",
               new IntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test continual intersection",
               new IntersectionSchedule(
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(1, 0, 0), DateTime.MinValue),
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(1, 0, 0), DateTime.MinValue.AddMinutes(30))
               ),
               new DateTime(2008, 7, 16), new DateTime(2008, 7, 17),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 7, 16, 0, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 1, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 2, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 3, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 4, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 5, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 6, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 7, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 8, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 9, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 10, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 11, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 12, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 13, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 14, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 15, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 16, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 17, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 18, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 19, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 20, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 21, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 22, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 23, 0, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test multiple subintersections",
               new IntersectionSchedule(
                  new IntervalSchedule(new TimeSpan(1, 0, 0), TimeSpan.Zero, DateTime.MinValue),
                  new OneTimeSchedule(new DateTime(2008, 7, 14, 8, 0, 0), new TimeSpan(10, 0, 0))
               ),
               new DateTime(2008, 7, 14, 6, 0, 0), new DateTime(2008, 7, 15),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 7, 14, 8, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 9, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 10, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 11, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 12, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 13, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 14, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 15, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 16, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 17, 0, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test schedule cropping",
               new IntersectionSchedule(
                  new ListSchedule(new[] {
                     new OneTimeSchedule(new DateTime(2008, 7, 16, 22, 0, 0), new DateTime(2008, 7, 17, 8, 0, 0)),
                     new OneTimeSchedule(new DateTime(2008, 7, 17, 6, 0, 0), new DateTime(2008, 7, 17, 17, 0, 0)),
                     new OneTimeSchedule(new DateTime(2008, 7, 17, 18, 0, 0), new DateTime(2008, 7, 18, 2, 0, 0))
                  }),
                  new OneTimeSchedule(new DateTime(2008, 7, 17), new TimeSpan(1, 0, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 7, 17, 0, 0, 0), new DateTime(2008, 7, 17, 8, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 17, 6, 0, 0), new DateTime(2008, 7, 17, 17, 0, 0)),
                  new TimedEvent(new DateTime(2008, 7, 17, 18, 0, 0), new DateTime(2008, 7, 18, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test extreme time range",
               new IntersectionSchedule(
                  new IntervalSchedule(new TimeSpan(1, 0, 0), TimeSpan.Zero, DateTime.MinValue),
                  new OneTimeSchedule(new DateTime(2008, 7, 14, 8, 0, 0), new TimeSpan(10, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 7, 14, 8, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 9, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 10, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 11, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 12, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 13, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 14, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 15, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 16, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 17, 0, 0), TimeSpan.Zero)
               }
            ),
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void IntersectionAllTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test partial intersection",
               new IntersectionAllSchedule(
                  new ListSchedule(
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0)),
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))
                  )
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(0, 30, 0))
               }
            ),
            new ScheduleUnitTest("Test partial intersection, reversed",
               new IntersectionAllSchedule(
                  new ListSchedule(
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0)),
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))
                  )
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(0, 30, 0))
               }
            ),
            new ScheduleUnitTest("Test no intersection",
               new IntersectionAllSchedule(
                  new ListSchedule(
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0)),
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))
                  )
               ),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test no intersection, reversed",
               new IntersectionAllSchedule(
                  new ListSchedule(
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0)),
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0))
                  )
               ),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test complete intersection",
               new IntersectionAllSchedule(
                  new ListSchedule(
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0)),
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))
                  )
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test contained intersection",
               new IntersectionAllSchedule(
                  new ListSchedule(
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0))
                  )
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test contained intersection, reversed",
               new IntersectionAllSchedule(
                  new ListSchedule(
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0)),
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
                  )
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test multiple subintersections",
               new IntersectionAllSchedule(
                  new ListSchedule(
                     new IntervalSchedule(new TimeSpan(1, 0, 0), TimeSpan.Zero, DateTime.MinValue),
                     new OneTimeSchedule(new DateTime(2008, 7, 14, 8, 0, 0), new TimeSpan(10, 0, 0))
                  )
               ),
               new DateTime(2008, 7, 14, 6, 0, 0), new DateTime(2008, 7, 15),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 7, 14, 8, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 9, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 10, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 11, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 12, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 13, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 14, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 15, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 16, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 14, 17, 0, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test self-intersecting intervals 1",
               new IntersectionAllSchedule(
                  new IntervalSchedule(new TimeSpan(0, 30, 0), new TimeSpan(1, 0, 0), DateTime.MinValue)
               ),
               new DateTime(2008, 7, 16), new DateTime(2008, 7, 17),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 7, 16), new DateTime(2008, 7, 17))
               }
            ),
            new ScheduleUnitTest("Test self-intersecting intervals 2",
               new IntersectionAllSchedule(
                  new IntervalSchedule(new TimeSpan(0, 30, 0), new TimeSpan(0, 45, 0), DateTime.MinValue)
               ),
               new DateTime(2008, 7, 16, 0, 0, 0), new DateTime(2008, 7, 16, 6, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 7, 16, 0, 0, 0), new DateTime(2008, 7, 16, 0, 15, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 0, 30, 0), new DateTime(2008, 7, 16, 0, 45, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 1, 0, 0), new DateTime(2008, 7, 16, 1, 15, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 1, 30, 0), new DateTime(2008, 7, 16, 1, 45, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 2, 0, 0), new DateTime(2008, 7, 16, 2, 15, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 2, 30, 0), new DateTime(2008, 7, 16, 2, 45, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 3, 0, 0), new DateTime(2008, 7, 16, 3, 15, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 3, 30, 0), new DateTime(2008, 7, 16, 3, 45, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 4, 0, 0), new DateTime(2008, 7, 16, 4, 15, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 4, 30, 0), new DateTime(2008, 7, 16, 4, 45, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 5, 0, 0), new DateTime(2008, 7, 16, 5, 15, 0)),
                  new TimedEvent(new DateTime(2008, 7, 16, 5, 30, 0), new DateTime(2008, 7, 16, 5, 45, 0))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void DifferenceTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test weekdays",
               new DifferenceSchedule(
                  new IntervalSchedule(new TimeSpan(1, 0, 0, 0), new TimeSpan(1, 0, 0, 0), DateTime.MinValue),
                  new ListSchedule(
                     new IntervalSchedule(new TimeSpan(7, 0, 0, 0), new TimeSpan(1, 0, 0, 0), new DateTime(2008, 1, 5, 0, 0, 0)),
                     new IntervalSchedule(new TimeSpan(7, 0, 0, 0), new TimeSpan(1, 0, 0, 0), new DateTime(2008, 1, 6, 0, 0, 0))
                  )
               ),
               new DateTime(2008, 2, 18, 0, 0 ,0), new DateTime(2008, 3, 1, 0, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 2, 18, 0 ,0 ,0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 2, 19, 0 ,0 ,0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 2, 20, 0 ,0 ,0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 2, 21, 0 ,0 ,0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 2, 22, 0 ,0 ,0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 2, 25, 0 ,0 ,0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 2, 26, 0 ,0 ,0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 2, 27, 0 ,0 ,0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 2, 28, 0 ,0 ,0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 2, 29, 0 ,0 ,0), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test partial intersection",
               new DifferenceSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 8, 0, 0), new TimeSpan(0, 30, 0))
               }
            ),
            new ScheduleUnitTest("Test partial intersection, reversed",
               new DifferenceSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(0, 30, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 8, 0, 0), new TimeSpan(0, 30, 0))
               }
            ),
            new ScheduleUnitTest("Test no intersection",
               new DifferenceSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test no intersection, reversed",
               new DifferenceSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test complete intersection",
               new DifferenceSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test contained intersection",
               new DifferenceSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(10, 45, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 13, 45, 0), new TimeSpan(10, 15, 0))
               }
            ),
            new ScheduleUnitTest("Test contained intersection, reversed",
               new DifferenceSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(10, 45, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 13, 45, 0), new TimeSpan(10, 15, 0))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void UnionTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test partial intersection",
               new UnionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 30, 0))
               }
            ),
            new ScheduleUnitTest("Test partial intersection, reversed",
               new UnionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 30, 0))
               }
            ),
            new ScheduleUnitTest("Test no intersection",
               new UnionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test no intersection, reversed",
               new UnionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test complete intersection",
               new UnionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test contained intersection",
               new UnionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test contained intersection, reversed",
               new UnionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void BoolIntersectionTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test partial intersection",
               new BoolIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test partial intersection, reversed",
               new BoolIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test no intersection",
               new BoolIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test no intersection, reversed",
               new BoolIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test complete intersection",
               new BoolIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test contained intersection",
               new BoolIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test contained intersection, reversed",
               new BoolIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test multiple intersections",
               new BoolIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(6, 0, 0)),
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue)
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(6, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test multiple intersections, reversed",
               new BoolIntersectionSchedule(
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(6, 0, 0))
               ),
               new DateTime(2008, 1, 30, 12, 0 ,0), new DateTime(2008, 1, 31, 12, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 1, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 2, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 3, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 5, 0, 0), new TimeSpan(0, 10, 0))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void BoolNonIntersectionTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Test partial intersection",
               new BoolNonIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test partial intersection, reversed",
               new BoolNonIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test no intersection",
               new BoolNonIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test no intersection, reversed",
               new BoolNonIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 4, 0, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), new TimeSpan(1, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test complete intersection",
               new BoolNonIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 0, 0))),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test contained intersection",
               new BoolNonIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0))
               ),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test contained intersection, reversed",
               new BoolNonIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 10, 45, 0), new TimeSpan(3, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
               ),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test multiple intersections",
               new BoolNonIntersectionSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(6, 0, 0)),
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue)
               ),
               new TimedEvent[] { }
            ),
            new ScheduleUnitTest("Test multiple intersections, reversed",
               new BoolNonIntersectionSchedule(
                  new IntervalSchedule(new TimeSpan(1, 0, 0), new TimeSpan(0, 10, 0), DateTime.MinValue),
                  new OneTimeSchedule(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(6, 0, 0))
               ),
               new DateTime(2008, 1, 30, 12, 0 ,0), new DateTime(2008, 1, 31, 12, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 30, 12, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 30, 13, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 30, 14, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 30, 15, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 30, 16, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 30, 17, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 30, 18, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 30, 19, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 30, 20, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 30, 21, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 30, 22, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 30, 23, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 6, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 8, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 9, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 10, 0, 0), new TimeSpan(0, 10, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 11, 0, 0), new TimeSpan(0, 10, 0))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void ListTest() {
         ScheduleUnitTest[] tests = new ScheduleUnitTest[] {
            new ScheduleUnitTest("Test empty list", new ListSchedule(), new TimedEvent[] { }),
            new ScheduleUnitTest("Test single element",
               new ListSchedule(new OneTimeSchedule(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero)),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test 2 elements",
               new ListSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new OneTimeSchedule(new DateTime(2008, 1, 2, 0, 0, 0), TimeSpan.Zero)
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 2, 0, 0, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test 2 identical elements",
               new ListSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new OneTimeSchedule(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero)
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test many elements",
               new ListSchedule(new ISchedule[] {
                  new OneTimeSchedule(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new OneTimeSchedule(new DateTime(2008, 1, 2, 0, 0, 0), TimeSpan.Zero),
                  new OneTimeSchedule(new DateTime(2008, 2, 7, 0, 0, 0), TimeSpan.Zero),
                  new OneTimeSchedule(new DateTime(2008, 4, 16, 0, 0, 0), TimeSpan.Zero),
                  new OneTimeSchedule(new DateTime(2008, 10, 6, 0, 0, 0), TimeSpan.Zero)
               }),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 2, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 4, 16, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 10, 6, 0, 0, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test mixed elements",
               new ListSchedule(
                  new OneTimeSchedule(new DateTime(2008, 1, 1, 6, 10, 30, 119), new TimeSpan(1, 2, 3)),
                  new IntervalSchedule(new TimeSpan(1, 0, 15), TimeSpan.Zero, new DateTime(2008, 1, 1, 0, 0, 0))
               ),
               new DateTime(2008, 1, 1, 0, 0, 0), new DateTime(2008, 1, 1, 8, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 1, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 1, 0, 15), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 2, 0, 30), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 3, 0, 45), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 4, 1, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 5, 1, 15), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 6, 1, 30), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 1, 1, 6, 10, 30, 119), new TimeSpan(1, 2, 3)),
                  new TimedEvent(new DateTime(2008, 1, 1, 7, 1, 45), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Test intersecting intervals",
               new ListSchedule(
                  new IntervalSchedule(new TimeSpan(0, 0, 1), TimeSpan.Zero, DateTime.MinValue),
                  new IntervalSchedule(new TimeSpan(0, 0, 5), TimeSpan.Zero, DateTime.MinValue)
               ),
               new DateTime(2008, 7, 25, 0, 0, 0), new DateTime(2008, 7, 25, 0, 0, 12),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 1), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 2), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 3), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 4), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 5), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 5), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 6), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 7), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 8), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 9), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 10), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 10), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 7, 25, 0, 0, 11), TimeSpan.Zero)
               }
            ),
            // Test buffering mechanism of ListSchedule and chronological ordering of interspersed events
            new ScheduleUnitTest("Test extreme range",
               new ListSchedule(new ISchedule[] {
                  new IntervalSchedule(new TimeSpan(1000, 0, 0, 0), TimeSpan.Zero, DateTime.MinValue),
                  new OneTimeSchedule(DateTime.MaxValue.AddMinutes(-1), TimeSpan.Zero),
                  new OneTimeSchedule(DateTime.MinValue, TimeSpan.Zero)
               }),
               TestExtremeRangeResult()
            )
         };

         foreach (var t in tests) t.Run();
      }

      private IEnumerable<TimedEvent> TestExtremeRangeResult() {
         yield return new TimedEvent(DateTime.MinValue, TimeSpan.Zero);

         for (DateTime dt = DateTime.MinValue; ; dt = dt.AddDays(1000)) {
            yield return new TimedEvent(dt, TimeSpan.Zero);
            if (dt >= DateTime.MaxValue.AddDays(-1000)) break;
         }

         yield return new TimedEvent(DateTime.MaxValue.AddMinutes(-1), TimeSpan.Zero);
         yield break;
      }

      [TestMethod]
      public void NestedTest() {
         ScheduleUnitTest[] tests = {
            // 2008-02-02 10:37, 2008-02-01 10:44 lasting T3:0:0
            new ScheduleUnitTest("Expression 1",
               new ListSchedule(
                 new OneTimeSchedule(new DateTime(2008, 2, 2, 10, 37, 0), TimeSpan.Zero),
                  new OneTimeSchedule(new DateTime(2008, 2, 1, 10, 45, 0), new TimeSpan(3, 0, 0))
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 2, 1, 10, 45, 0), new TimeSpan(3, 0, 0)),
                  new TimedEvent(new DateTime(2008, 2, 2, 10, 37, 0), TimeSpan.Zero)
               }
            ),

            // (2008-02-02 10:37, (2008-02-01 10:40 lasting T4:0:0 & 2008-02-01 10:45 lasting T3:0:0))
            new ScheduleUnitTest("Expression 2",
               new ListSchedule(
                  new OneTimeSchedule(new DateTime(2008, 2, 2, 10, 37, 0), TimeSpan.Zero),
                  new IntersectionSchedule(
                     new OneTimeSchedule(new DateTime(2008, 2, 1, 10, 40, 0), new TimeSpan(4, 0, 0)),
                     new OneTimeSchedule(new DateTime(2008, 2, 1, 10, 45, 0), new TimeSpan(3, 0, 0))
                  )
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 2, 1, 10, 45, 0), new TimeSpan(3, 0, 0)),
                  new TimedEvent(new DateTime(2008, 2, 2, 10, 37, 0), TimeSpan.Zero)
               }
            ),
   
            // (2008-02-02 10:37, (2008-02-01 00:00 lasting T24:0:0 !& (2008-02-01 10:40 lasting T4:0:0 & 2008-02-01 10:45 lasting T3:0:0)))
            new ScheduleUnitTest("Expression 3",
               new ListSchedule(
                  new OneTimeSchedule(new DateTime(2008, 2, 2, 10, 37, 0), TimeSpan.Zero),
                  new DifferenceSchedule(
                     new OneTimeSchedule(new DateTime(2008, 2, 1, 0, 0, 0), new TimeSpan(24, 0, 0)),
                     new IntersectionSchedule(
                        new OneTimeSchedule(new DateTime(2008, 2, 1, 10, 40, 0), new TimeSpan(4, 0, 0)),
                        new OneTimeSchedule(new DateTime(2008, 2, 1, 10, 45, 0), new TimeSpan(3, 0, 0))
                     )
                  )
               ),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 2, 1, 0, 0, 0), new TimeSpan(10, 45, 0)),
                  new TimedEvent(new DateTime(2008, 2, 1, 13, 45, 0), new TimeSpan(10, 15, 0)),
                  new TimedEvent(new DateTime(2008, 2, 2, 10, 37, 0), TimeSpan.Zero)
               }
            ),

            // (2008-02-02 10:37, (2008-01-31 20:41 lasting T5:0:0 | (2008-02-01 00:00 lasting T24:0:0 !& (2008-02-01 10:40 lasting T4:0:0 & 2008-02-01 10:45 lasting T3:0:0))), void)
            new ScheduleUnitTest("Test mean nested expression",
               new ListSchedule(new ISchedule[] {
                  new OneTimeSchedule(new DateTime(2008, 2, 2, 10, 37, 0), TimeSpan.Zero),
                  new UnionSchedule(
                     new OneTimeSchedule(new DateTime(2008, 1, 31, 20, 41, 0), new TimeSpan(5, 0, 0)),
                     new DifferenceSchedule(
                        new OneTimeSchedule(new DateTime(2008, 2, 1, 0, 0, 0), new TimeSpan(24, 0, 0)),
                           new IntersectionSchedule(
                           new OneTimeSchedule(new DateTime(2008, 2, 1, 10, 40, 0), new TimeSpan(4, 0, 0)),
                           new OneTimeSchedule(new DateTime(2008, 2, 1, 10, 45, 0), new TimeSpan(3, 0, 0))
                        )
                     )
                  ),
                  new VoidSchedule()
               }),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 20, 41, 0), new TimeSpan(14, 4, 0)),
                  new TimedEvent(new DateTime(2008, 2, 1, 13, 45, 0), new TimeSpan(10, 15, 0)),
                  new TimedEvent(new DateTime(2008, 2, 2, 10, 37, 0), new TimeSpan(0, 0, 0))
               }
            ),

            new ScheduleUnitTest("Test practical example 1a",
               new BoolNonIntersectionSchedule(
                  new IntervalSchedule(new TimeSpan(1, 0, 0, 0), new TimeSpan(1, 0, 0, 0), new DateTime(2008, 1, 1, 0, 0, 0)),
                  new OneTimeSchedule(new DateTime(2008, 12, 24, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
               ),
               new DateTime(2008, 12, 20, 0, 0, 0), new DateTime(2009, 1, 5, 0, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 12, 20, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 21, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 22, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 23, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 25, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 26, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 27, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 28, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 29, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 30, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2009, 1, 1, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2009, 1, 2, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2009, 1, 3, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2009, 1, 4, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
               }
            ),

            // Practical example: Every day except holidays
            // /* every day */ every T1.0:0:0 since 2008-01-01 00:00 lasting T1.0:0:0 !&& (
            //   /* Christmas eve */ 2008-12-24 00:00 lasting T1.0:0:0, 
            //   /* Christmas day */ 2008-12-25 00:00 lasting T1.0:0:0,
            //   /* New year's day */ 2009-01-01 00:00 lasting T1.0:0:0
            // )
            new ScheduleUnitTest("Test practical example 1",
               new BoolNonIntersectionSchedule(
                  new IntervalSchedule(new TimeSpan(1, 0, 0, 0), new TimeSpan(1, 0, 0, 0), new DateTime(2008, 1, 1, 0, 0, 0)),
                  new ListSchedule(new[] {
                     new OneTimeSchedule(new DateTime(2008, 12, 24, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                     new OneTimeSchedule(new DateTime(2008, 12, 25, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                     new OneTimeSchedule(new DateTime(2009, 1, 1, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
                  })
               ),
               new DateTime(2008, 12, 20, 0, 0, 0), new DateTime(2009, 1, 5, 0, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 12, 20, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 21, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 22, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 23, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 26, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 27, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 28, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 29, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 30, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 12, 31, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2009, 1, 2, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2009, 1, 3, 0, 0, 0), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2009, 1, 4, 0, 0, 0), new TimeSpan(1, 0, 0, 0))
               }
            ),
            new ScheduleUnitTest("Test President's Day -- 3rd Monday of February",
               new BoolIntersectionSchedule(
                  new DayOfWeekSchedule("3", "1"),
                  new UnionSchedule(
                     new CronSchedule("0", "0", "*", "2", "*", new TimeSpan(1, 0, 0, 0)),
                     new VoidSchedule()
                  )
               ),
               new DateTime(2008, 1, 1), new DateTime(2012, 1, 1),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 2, 18), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2009, 2, 16), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2010, 2, 15), new TimeSpan(1, 0, 0, 0)),
                  new TimedEvent(new DateTime(2011, 2, 21), new TimeSpan(1, 0, 0, 0))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void CronFieldTest() {
         CronFieldTester[] crontests = {
            new CronFieldTester("Test *", new CronField("*", 0, 59), new int[] {
               0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
               31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59 
            }),
            new CronFieldTester("Test */2", new CronField("*/2", 0, 59), new int[] {
               0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58
            }),
            new CronFieldTester("Test 0", new CronField("0", 0, 59), new int[] { 0 }),
            new CronFieldTester("Test 1", new CronField("1", 0, 59), new int[] { 1 }),
            new CronFieldTester("Test 59", new CronField("59", 0, 59), new int[] { 59 }),
            new CronFieldTester("Test 0-10", new CronField("0-10", 0, 59), new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
            new CronFieldTester("Test 0-10/2", new CronField("0-10/2", 0, 59), new int[] { 0, 2, 4, 6, 8, 10 }),
            new CronFieldTester("Test 1-11/2", new CronField("1-11/2", 0, 59), new int[] { 1, 3, 5, 7, 9, 11 }),
            new CronFieldTester("Test */3", new CronField("*/3", 0, 59), new int[] { 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57 }),
            new CronFieldTester("Test 0-10/3", new CronField("0-10/3", 0, 59), new int[] { 0, 3, 6, 9 }),
            new CronFieldTester("Test 1,2,3", new CronField("1,2,3", 0, 59), new int[] { 1, 2, 3}),
            new CronFieldTester("Test 0-10,15", new CronField("0-10,15", 0, 59), new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15 }),
            new CronFieldTester("Test 0-10,5", new CronField("0-10,5", 0, 59), new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
            new CronFieldTester("Test *,!7", new CronField("*,!7", 0, 59), new int[] {
               0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
               31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59 
            }),
            new CronFieldTester("Test 0-10,!7", new CronField("0-10,!7", 0, 59), new int[] { 0, 1, 2, 3, 4, 5, 6, 8, 9, 10 }),
            new CronFieldTester("Test >45", new CronField(">45", 0, 59), new int[] { 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59 }),
            new CronFieldTester("Test <15", new CronField("<15", 0, 59), new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }),
            new CronFieldTester("Test *,!20-50", new CronField("*,!20-50", 0, 59), new int[] {
               0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 51, 52, 53, 54, 55, 56, 57, 58, 59
            }),
            new CronFieldTester("Test *,!>20", new CronField("*,!>20", 0, 59), new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }),
            new CronFieldTester("Test 1-10,!2-20", new CronField("1-10,!2-20", 0, 59), new int[] { 1 }),
            new CronFieldTester("Test 1-10,!>0", new CronField("1-10,!>0", 0, 59), new int[] { })
         };

         foreach (CronFieldTester t in crontests) t.Run();
      }

      [TestMethod]
      public void CronTest() {
         ScheduleUnitTest[] tests = {
            new ScheduleUnitTest("Every minute",
               new CronSchedule("*", "*", "*", "*", "*", TimeSpan.Zero),
               new DateTime(2008, 2, 7, 8, 0, 0), new DateTime(2008, 2, 7, 8, 15, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 1, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 2, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 3, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 4, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 5, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 6, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 7, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 8, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 9, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 10, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 11, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 12, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 13, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 14, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Every hour",
               new CronSchedule("0", "*", "*", "*", "*", TimeSpan.Zero),
               new DateTime(2008, 2, 7, 8, 0, 0), new DateTime(2008, 2, 8, 8, 15, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(2008, 2, 7, 8, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 9, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 10, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 11, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 12, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 13, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 14, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 15, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 16, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 17, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 18, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 19, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 20, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 21, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 22, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 7, 23, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 8, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 8, 1, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 8, 2, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 8, 3, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 8, 4, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 8, 5, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 8, 6, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 8, 7, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 2, 8, 8, 0, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("Every Friday the 13th at midnight",
               new CronSchedule("0", "0", "13", "*", "5", TimeSpan.Zero),
               new DateTime(1995, 1, 1, 0, 0, 0), new DateTime(2010, 1, 1, 0, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(1995, 1, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(1995, 10, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(1996, 9, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(1996, 12, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(1997, 6, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(1998, 2, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(1998, 3, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(1998, 11, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(1999, 8, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2000, 10, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2001, 4, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2001, 7, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2002, 9, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2002, 12, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2003, 6, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2004, 2, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2004, 8, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2005, 5, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2006, 1, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2006, 10, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2007, 4, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2007, 7, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2008, 6, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2009, 2, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2009, 3, 13, 0, 0, 0), TimeSpan.Zero),
                  new TimedEvent(new DateTime(2009, 11, 13, 0, 0, 0), TimeSpan.Zero)
               }
            ),
            new ScheduleUnitTest("October",
               new CronSchedule("0", "0", "1", "10", "*", new TimeSpan(31, 0, 0, 0)),
               new DateTime(1995, 1, 1, 0, 0, 0), new DateTime(2010, 1, 1, 0, 0, 0),
               new TimedEvent[] {
                  new TimedEvent(new DateTime(1995, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(1996, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(1997, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(1998, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(1999, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(2000, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(2001, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(2002, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(2003, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(2004, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(2005, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(2006, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(2007, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(2008, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0)),
                  new TimedEvent(new DateTime(2009, 10, 1, 0, 0, 0), new TimeSpan(31, 0, 0, 0))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void CalculateDOWTest() {
         // Calendar.GetDOW() has been refactored
         // TODO: Refactor this unit test

         //int[] DOWLookup = { 0, 3, 3, 6, 1, 4, 6, 2, 5, 0, 3, 5 };
         //int[] DOWLookupLY = { 6, 2, 3, 6, 1, 4, 6, 2, 5, 0, 3, 5 };

         //for (int Month = 1; Month <= 12; Month++) {
         //   int DOW = Calendar.fm(Month, false);
         //   int DOWCheck = DOWLookup[Month - 1];
         //   Debug.WriteLine(string.Format("{0:d} <=> {1:d}", DOW, DOWCheck));
         //   Assert.AreEqual<int>(DOW, DOWCheck, string.Format("DOW failed at month {0:d}", Month));
         //}

         //for (int Month = 1; Month <= 12; Month++) {
         //   int DOW = Calendar.fm(Month, true);
         //   int DOWCheck = DOWLookupLY[Month - 1];
         //   Debug.WriteLine(string.Format("{0:d} <=> {1:d}", DOW, DOWCheck));
         //   Assert.AreEqual<int>(DOW, DOWCheck, string.Format("DOW failed at leapyear month {0:d}", Month));
         //}

      }

      private void DumpEvents(IList<TimedEvent> EventList) {
         foreach (TimedEvent e in EventList) {
            Debug.WriteLine("Event: " + e.ToString());
         }
      }

      public class CronFieldTester {
         private string _Name;
         private CronField _Field;
         private IEnumerable<int> _ExpectedValues;

         public CronFieldTester(string Name, CronField Field, IEnumerable<int> ExpectedValues) {
            _Name = Name;
            _Field = Field;
            _ExpectedValues = ExpectedValues;
         }

         public void Run() {
            Debug.WriteLine("CronField Test: " + _Name);
            ArrayCompare(_Field.PickList, _ExpectedValues);
         }

         private void ArrayCompare(IEnumerable A, IEnumerable<int> B) {
            IEnumerator enum1 = A.GetEnumerator();
            IEnumerator enum2 = B.GetEnumerator();
            bool enum1more, enum2more;
            while (true) {
               enum1more = enum1.MoveNext();
               enum2more = enum2.MoveNext();
               if (!enum1more || !enum2more) break;

               int e1 = (int)enum1.Current;
               int e2 = (int)enum2.Current;
               Debug.WriteLine(string.Format("Comparing elements: {0:d} <=> {1:d}", e1, e2));
               if (e1 != e2) {
                  // Write out remainder of elements
                  while (enum1.MoveNext()) {
                     Debug.WriteLine("Remaining element: " + enum1.Current.ToString());
                  }
                  throw new Exception("ArrayCompare failure: mismatch");
               }
            }

            // If enum1 has more records, note them
            if (enum1more) {
               do {
                  Debug.WriteLine(string.Format("Extra left element: {0:d}", enum1.Current));
               } while (enum1.MoveNext());
               throw new Exception("ArrayCompare failure: Extra left elements");
            }
            // If enum2 has more records, note them
            if (enum2more) {
               do {
                  Debug.WriteLine(string.Format("Extra right element: {0:d}", enum2.Current));
               } while (enum2.MoveNext());
               throw new Exception("ArrayCompare failure: Extra right elements");
            }
         }
      }

      public class ScheduleUnitTest {
         private string _Name;
         private ISchedule _Schedule;
         private DateTime _RangeStart, _RangeEnd;
         private IEnumerable<TimedEvent> _ExpectedEvents;

         public ScheduleUnitTest(string Name, ISchedule Schedule, IEnumerable<TimedEvent> ExpectedEvents) {
            _Name = Name;
            _Schedule = Schedule;
            _RangeStart = DateTime.MinValue;
            _RangeEnd = DateTime.MaxValue;
            _ExpectedEvents = ExpectedEvents;
         }

         public ScheduleUnitTest(string Name, ISchedule Schedule, DateTime StartRange, DateTime EndRange, IEnumerable<TimedEvent> ExpectedEvents) {
            _Name = Name;
            _Schedule = Schedule;
            _RangeStart = StartRange;
            _RangeEnd = EndRange;
            _ExpectedEvents = ExpectedEvents;
         }

         public string Name { get { return _Name; } }

         public void Run() {
            Debug.WriteLine("Unit test: " + this._Name);
            Debug.WriteLine("Schedule expression: " + this._Schedule.ToString());

            SequenceComparer.AssertCompare(_Schedule.GetRange(_RangeStart, _RangeEnd), _ExpectedEvents, (a, b) => a.CompareTo(b));

            // Success, exact match
         }
      }
   }
}
