using System;
using System.Diagnostics;
using Expl.Auxiliary;
using Expl.Itinerary.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expl.Itinerary.Tests {
   /// <summary>
   /// TDL Parser validity unit tests
   /// </summary>
   [TestClass]
   public class TDLParserTests {
      [TestMethod]
      public void VoidScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("void")
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void OneTimeScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("2008-08-19", "2008-08-19 00:00"),
            new TDLUnitTest("10:37", NowDate + " 10:37"),
            new TDLUnitTest("10:37:51", NowDate + " 10:37:51"),
            new TDLUnitTest("10:37:51.627", NowDate + " 10:37:51.627"),
            new TDLUnitTest("2008-01-15 10:37:51.627", "2008-01-15 10:37:51.627"),
            new TDLUnitTest("10:37 lasting T1", NowDate + " 10:37 lasting T1"),
            new TDLUnitTest("10:37 lasting T1:16", NowDate + " 10:37 lasting T1:16"),
            new TDLUnitTest("10:37 lasting T1:16.867", NowDate + " 10:37 lasting T1:16.867"),
            new TDLUnitTest("10:37 lasting T6:1:16.867", NowDate + " 10:37 lasting T6:1:16.867"),
            new TDLUnitTest("10:37 lasting T7.6:1:16.867", NowDate + " 10:37 lasting T7.6:1:16.867")
         };
         
         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void IntervalScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("every T1"),
            new TDLUnitTest("every T1 lasting T10"),
            new TDLUnitTest("every T1 since 00:00", "every T1 since " + NowDate + " 00:00"),
            new TDLUnitTest("every T1 since 00:00 lasting T10", "every T1 since " + NowDate + " 00:00 lasting T10")
         };
         
         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void CronScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("cron * * * * *"),
            new TDLUnitTest("cron 1 2 3 4 5"),
            new TDLUnitTest("cron 5-30 5-20 10-25 1-4 0-5"),
            new TDLUnitTest("cron 1,2,3 4,5,6 7,8,9 10,11,12 0,1,2"),
            new TDLUnitTest("cron */2 */3 */4 * *"),
            new TDLUnitTest("cron *>4 *>10 *>2 * *"),
            new TDLUnitTest("cron *<20 *<10 *<20 * *"),
            new TDLUnitTest("cron *,!20 *,!1,!4,!10 * * *"),
            new TDLUnitTest("cron 0 0 1 10 *")
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void DayOfWeekScheduleTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("week * *"),
            new TDLUnitTest("week 0 *"),
            new TDLUnitTest("week 1 *"),
            new TDLUnitTest("week 2 *"),
            new TDLUnitTest("week 3 *"),
            new TDLUnitTest("week 4 *"),
            new TDLUnitTest("week 5 *"),
            new TDLUnitTest("week 6 *"),
            new TDLUnitTest("week * 0"),
            new TDLUnitTest("week * 1"),
            new TDLUnitTest("week * 2"),
            new TDLUnitTest("week * 3"),
            new TDLUnitTest("week * 4"),
            new TDLUnitTest("week * 5"),
            new TDLUnitTest("week * 6"),
            new TDLUnitTest("week 1-3 4-6"),
            new TDLUnitTest("week */2 1-5/2"),
            new TDLUnitTest("week 1,3,4 0,2,5"),
            new TDLUnitTest("week *,!3 *,!2")
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void LastingScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("2008-09-09 10:37 lasting T10 lasting T20"),
            new TDLUnitTest("(2008-09-09 10:37 lasting T10) lasting T20", "2008-09-09 10:37 lasting T10 lasting T20"),
            new TDLUnitTest("(every T20, 2008-09-09 10:37) lasting T20")
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void IndexScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("2008-09-03 10:37 #1"),
            new TDLUnitTest("2008-09-03 10:37# 1", "2008-09-03 10:37 #1"),
            new TDLUnitTest("2008-09-03 10:37 # 1", "2008-09-03 10:37 #1"),
            new TDLUnitTest("2008-09-03 10:37#1", "2008-09-03 10:37 #1"),
            new TDLUnitTest("every T30 #1"),
            new TDLUnitTest("every T30 #1-10"),
            new TDLUnitTest("every T30 #1,2"),
            new TDLUnitTest("every T30 #1,2,3"),
            new TDLUnitTest("every T30 #1-10,!5"),
            new TDLUnitTest("every T30 #1-10,!5,11-15"),
            new TDLUnitTest("every T30 #1-10,!5-9")
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void OffsetScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("2008-09-02 10:37 + T1:0"),
            new TDLUnitTest("2008-09-02 10:37+ T1:0", "2008-09-02 10:37 + T1:0"),
            new TDLUnitTest("2008-09-02 10:37 +T1:0", "2008-09-02 10:37 + T1:0"),
            new TDLUnitTest("2008-09-02 10:37+T1:0", "2008-09-02 10:37 + T1:0"),
            new TDLUnitTest("2008-09-02 10:37 - T1:0"),
            new TDLUnitTest("2008-09-02 10:37- T1:0", "2008-09-02 10:37 - T1:0"),
            new TDLUnitTest("2008-09-02 10:37 -T1:0", "2008-09-02 10:37 - T1:0"),
            new TDLUnitTest("2008-09-02 10:37-T1:0", "2008-09-02 10:37 - T1:0")
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void LimitScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("2008-09-02 10:37 <= every T1:0:0 < 2008-09-03 10:37"),
            new TDLUnitTest("2008-09-02 10:37<= every T1:0:0< 2008-09-03 10:37", "2008-09-02 10:37 <= every T1:0:0 < 2008-09-03 10:37"),
            new TDLUnitTest("2008-09-02 10:37 <=every T1:0:0 <2008-09-03 10:37", "2008-09-02 10:37 <= every T1:0:0 < 2008-09-03 10:37"),
            new TDLUnitTest("2008-09-02 10:37<=every T1:0:0<2008-09-03 10:37", "2008-09-02 10:37 <= every T1:0:0 < 2008-09-03 10:37")
         };
      }

      [TestMethod]
      public void RepeatScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("2008-09-02 10:37 x 4"),
            new TDLUnitTest("2008-09-02 10:37x 4", "2008-09-02 10:37 x 4"),
            new TDLUnitTest("2008-09-02 10:37 x4", "2008-09-02 10:37 x 4"),
            new TDLUnitTest("2008-09-02 10:37x4", "2008-09-02 10:37 x 4")
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void IntersectionScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("10:37 & 10:38", NowDate + " 10:37 & " + NowDate + " 10:38"),
            new TDLUnitTest("10:37& 10:38", NowDate + " 10:37 & " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 &10:38", NowDate + " 10:37 & " + NowDate + " 10:38"),
            new TDLUnitTest("10:37&10:38", NowDate + " 10:37 & " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 lasting T1:00:00 & 10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 & " + NowDate + " 10:38 lasting T1:0:0"),
            new TDLUnitTest("10:37 lasting T1:00:00& 10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 & " + NowDate + " 10:38 lasting T1:0:0"),
            new TDLUnitTest("10:37 lasting T1:00:00 &10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 & " + NowDate + " 10:38 lasting T1:0:0"),
            new TDLUnitTest("10:37 lasting T1:00:00&10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 & " + NowDate + " 10:38 lasting T1:0:0")
         };
         
         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void DifferenceScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("10:37 !& 10:38", NowDate + " 10:37 !& " + NowDate + " 10:38"),
            new TDLUnitTest("10:37!& 10:38", NowDate + " 10:37 !& " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 !&10:38", NowDate + " 10:37 !& " + NowDate + " 10:38"),
            new TDLUnitTest("10:37!&10:38", NowDate + " 10:37 !& " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 lasting T1:00:00 !& 10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 !& " + NowDate + " 10:38 lasting T1:0:0"),
            new TDLUnitTest("10:37 lasting T1:00:00!& 10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 !& " + NowDate + " 10:38 lasting T1:0:0"),
            new TDLUnitTest("10:37 lasting T1:00:00 !&10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 !& " + NowDate + " 10:38 lasting T1:0:0"),
            new TDLUnitTest("10:37 lasting T1:00:00!&10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 !& " + NowDate + " 10:38 lasting T1:0:0"),
         };
         
         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void UnionScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("10:37 | 10:38", NowDate + " 10:37 | " + NowDate + " 10:38"),
            new TDLUnitTest("10:37| 10:38", NowDate + " 10:37 | " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 |10:38", NowDate + " 10:37 | " + NowDate + " 10:38"),
            new TDLUnitTest("10:37|10:38", NowDate + " 10:37 | " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 | 10:38 | 11:30 | 14:51 | 7:15", NowDate + " 10:37 | " + NowDate + " 10:38 | " + NowDate + " 11:30 | " + NowDate + " 14:51 | " + NowDate + " 07:15"),
            new TDLUnitTest("10:37| 10:38 |11:30 | 14:51|7:15",  NowDate + " 10:37 | " + NowDate + " 10:38 | " + NowDate + " 11:30 | " + NowDate + " 14:51 | " + NowDate + " 07:15"),
            new TDLUnitTest("10:37 | every T1 since 00:00", NowDate + " 10:37 | every T1 since " + NowDate + " 00:00")
         };
         
         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void BoolIntersectionScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("10:37 && 10:38", NowDate + " 10:37 && " + NowDate + " 10:38"),
            new TDLUnitTest("10:37&& 10:38", NowDate + " 10:37 && " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 &&10:38", NowDate + " 10:37 && " + NowDate + " 10:38"),
            new TDLUnitTest("10:37&&10:38", NowDate + " 10:37 && " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 lasting T1:00:00 && 10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 && " + NowDate + " 10:38 lasting T1:0:0"),
            new TDLUnitTest("10:37 lasting T1:00:00&& 10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 && " + NowDate + " 10:38 lasting T1:0:0"),
            new TDLUnitTest("10:37 lasting T1:00:00 &&10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 && " + NowDate + " 10:38 lasting T1:0:0"),
            new TDLUnitTest("10:37 lasting T1:00:00&&10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 && " + NowDate + " 10:38 lasting T1:0:0")
         };
         
         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void BoolDifferenceScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("10:37 !&& 10:38", NowDate + " 10:37 !&& " + NowDate + " 10:38"),
            new TDLUnitTest("10:37!&& 10:38", NowDate + " 10:37 !&& " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 !&&10:38", NowDate + " 10:37 !&& " + NowDate + " 10:38"),
            new TDLUnitTest("10:37!&&10:38", NowDate + " 10:37 !&& " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 lasting T1:00:00 !&& 10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 !&& " + NowDate + " 10:38 lasting T1:0:0"),
            new TDLUnitTest("10:37 lasting T1:00:00!&& 10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 !&& " + NowDate + " 10:38 lasting T1:0:0"),
            new TDLUnitTest("10:37 lasting T1:00:00 !&&10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 !&& " + NowDate + " 10:38 lasting T1:0:0"),
            new TDLUnitTest("10:37 lasting T1:00:00!&&10:38 lasting T1:00:00", NowDate + " 10:37 lasting T1:0:0 !&& " + NowDate + " 10:38 lasting T1:0:0")
         };
         
         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void ListScheduleParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("10:37 , 10:38", NowDate + " 10:37, " + NowDate + " 10:38"),
            new TDLUnitTest("10:37, 10:38", NowDate + " 10:37, " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 ,10:38", NowDate + " 10:37, " + NowDate + " 10:38"),
            new TDLUnitTest("10:37,10:38", NowDate + " 10:37, " + NowDate + " 10:38"),
            new TDLUnitTest("10:37, 10:38, 10:39, 10:40, 10:41, 10:42", NowDate + " 10:37, " + NowDate + " 10:38, " + NowDate + " 10:39, " + NowDate + " 10:40, " + NowDate + " 10:41, " + NowDate + " 10:42"),
            new TDLUnitTest("10:37,10:38, 10:39 , 10:40 , 10:41 ,10:42", NowDate + " 10:37, " + NowDate + " 10:38, " + NowDate + " 10:39, " + NowDate + " 10:40, " + NowDate + " 10:41, " + NowDate + " 10:42"),
            new TDLUnitTest("10:37, every T1 since 00:00", NowDate + " 10:37, every T1 since " + NowDate + " 00:00"),
            new TDLUnitTest("10:37, every T1 since 00:00, 10:38", NowDate + " 10:37, every T1 since " + NowDate + " 00:00, " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 lasting T1:00:00, 14:51 lasting T2:00:00, 18:12 lasting T45:00", NowDate + " 10:37 lasting T1:0:0, " + NowDate + " 14:51 lasting T2:0:0, " + NowDate + " 18:12 lasting T45:0"),
            new TDLUnitTest("10:37 lasting T1:00:00, 14:51 lasting T2:00:00, 18:12 lasting T45:00, every T57:15.916 since 5:41 lasting T1:15:41.336", NowDate + " 10:37 lasting T1:0:0, " + NowDate + " 14:51 lasting T2:0:0, " + NowDate + " 18:12 lasting T45:0, every T57:15.916 since " + NowDate + " 05:41 lasting T1:15:41.336")
         };
         
         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void NestedParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("10:37 | 10:38 & 10:40", NowDate + " 10:37 | " + NowDate + " 10:38 & " + NowDate + " 10:40"),
            new TDLUnitTest("10:37 & 10:38 | 10:40", NowDate + " 10:37 & " + NowDate + " 10:38 | " + NowDate + " 10:40"),
            new TDLUnitTest("10:37, 10:38 | 10:40", NowDate + " 10:37, " + NowDate + " 10:38 | " + NowDate + " 10:40"),
            new TDLUnitTest("10:37| 10:38 , 10:40", NowDate + " 10:37 | " + NowDate + " 10:38, " + NowDate + " 10:40"),
            new TDLUnitTest("10:37 & 10:38 !& 10:40 | 10:41 && 10:42 !&& 10:43, 10:44", NowDate + " 10:37 & " + NowDate + " 10:38 !& " + NowDate + " 10:40 | " + NowDate + " 10:41 && " + NowDate + " 10:42 !&& " + NowDate + " 10:43, " + NowDate + " 10:44"),
            new TDLUnitTest("10:37 , 10:38 !&& 10:40 && 10:41 | 10:42 !& 10:43& 10:44", NowDate + " 10:37, " + NowDate + " 10:38 !&& " + NowDate + " 10:40 && " + NowDate + " 10:41 | " + NowDate + " 10:42 !& " + NowDate + " 10:43 & " + NowDate + " 10:44")
         };
         
         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void PrecedenceTest() {
         TDLUnitTest[] tests = {
            // Filters
            new TDLUnitTest("every T10 #1-10/3 #2"),
            new TDLUnitTest("every T10 #1-10/3 lasting T5"),
            new TDLUnitTest("every T10 #1-10/3 x 20"),
            new TDLUnitTest("every T10 x 20 #1-10/3"),
            // Intersection
            new TDLUnitTest("every T10 & (every T30 #1-10)", "every T10 & every T30 #1-10"),
            new TDLUnitTest("(every T10 & every T30) #1-10"),
            new TDLUnitTest("every T10 & (every T30 x 10)", "every T10 & every T30 x 10"),
            new TDLUnitTest("(every T10 & every T30) x 10"),
            new TDLUnitTest("every T10 & ((every T30) lasting T1:0)", "every T10 & every T30 lasting T1:0"),
            new TDLUnitTest("(every T10 & every T30) lasting T1:0"),
            new TDLUnitTest("every T10 & (every T30 + T1:0)", "every T10 & every T30 + T1:0"),
            new TDLUnitTest("(every T10 & every T30) + T1:0"),
            new TDLUnitTest("every T10 & (2008-09-15 00:00 <= every T30 < 2008-09-16 00:00)", "every T10 & 2008-09-15 00:00 <= every T30 < 2008-09-16 00:00"),
            new TDLUnitTest("every T10 & every T30 & every T1:0"),
            new TDLUnitTest("(every T10 & every T30) & every T1:0", "every T10 & every T30 & every T1:0"),
            new TDLUnitTest("every T10 & (every T30 & every T1:0)"),
            new TDLUnitTest("(every T10 & every T30) !& every T1:0", "every T10 & every T30 !& every T1:0"),
            new TDLUnitTest("every T10 & (every T30 !& every T1:0)"),
            new TDLUnitTest("(every T10 & every T30) | every T1:0", "every T10 & every T30 | every T1:0"),
            new TDLUnitTest("every T10 & (every T30 | every T1:0)"),
            new TDLUnitTest("(every T10 & every T30) && every T1:0", "every T10 & every T30 && every T1:0"),
            new TDLUnitTest("every T10 & (every T30 && every T1:0)"),
            new TDLUnitTest("(every T10 & every T30) !&& every T1:0", "every T10 & every T30 !&& every T1:0"),
            new TDLUnitTest("every T10 & (every T30 !&& every T1:0)"),
            new TDLUnitTest("(every T10 & every T30), every T1:0", "every T10 & every T30, every T1:0"),
            new TDLUnitTest("every T10 & (every T30, every T1:0)"),
            // Difference
            new TDLUnitTest("every T10 !& (every T30 #1-10)", "every T10 !& every T30 #1-10"),
            new TDLUnitTest("(every T10 !& every T30) #1-10"),
            new TDLUnitTest("every T10 !& (every T30 x 10)", "every T10 !& every T30 x 10"),
            new TDLUnitTest("(every T10 !& every T30) x 10"),
            new TDLUnitTest("every T10 !& ((every T30) lasting T1:0)", "every T10 !& every T30 lasting T1:0"),
            new TDLUnitTest("(every T10 !& every T30) lasting T1:0"),
            new TDLUnitTest("every T10 !& (every T30 + T1:0)", "every T10 !& every T30 + T1:0"),
            new TDLUnitTest("(every T10 !& every T30) + T1:0"),
            new TDLUnitTest("every T10 !& (2008-09-15 00:00 <= every T30 < 2008-09-16 00:00)", "every T10 !& 2008-09-15 00:00 <= every T30 < 2008-09-16 00:00"),
            new TDLUnitTest("every T10 !& (every T30 & every T1:0)", "every T10 !& every T30 & every T1:0"),
            new TDLUnitTest("(every T10 !& every T30) & every T1:0"),
            new TDLUnitTest("every T10 !& every T30 !& every T1:0"),
            new TDLUnitTest("every T10 !& (every T30 !& every T1:0)"),
            new TDLUnitTest("(every T10 !& every T30) !& every T1:0", "every T10 !& every T30 !& every T1:0"),
            new TDLUnitTest("every T10 !& (every T30 && every T1:0)"),
            new TDLUnitTest("(every T10 !& every T30) && every T1:0", "every T10 !& every T30 && every T1:0"),
            new TDLUnitTest("every T10 !& (every T30 !&& every T1:0)"),
            new TDLUnitTest("(every T10 !& every T30) !&& every T1:0", "every T10 !& every T30 !&& every T1:0"),
            new TDLUnitTest("every T10 !& (every T30, every T1:0)"),
            new TDLUnitTest("(every T10 !& every T30), every T1:0", "every T10 !& every T30, every T1:0"),
            // Union
            new TDLUnitTest("every T10 | (every T30 #1-10)", "every T10 | every T30 #1-10"),
            new TDLUnitTest("(every T10 | every T30) #1-10"),
            new TDLUnitTest("every T10 | (every T30 x 10)", "every T10 | every T30 x 10"),
            new TDLUnitTest("(every T10 | every T30) x 10"),
            new TDLUnitTest("every T10 | ((every T30) lasting T1:0)", "every T10 | every T30 lasting T1:0"),
            new TDLUnitTest("(every T10 | every T30) lasting T1:0"),
            new TDLUnitTest("every T10 | (every T30 + T1:0)", "every T10 | every T30 + T1:0"),
            new TDLUnitTest("(every T10 | every T30) + T1:0"),
            new TDLUnitTest("every T10 | (2008-09-15 00:00 <= every T30 < 2008-09-16 00:00)", "every T10 | 2008-09-15 00:00 <= every T30 < 2008-09-16 00:00"),
            new TDLUnitTest("every T10 | (every T30 & every T1:0)", "every T10 | every T30 & every T1:0"),
            new TDLUnitTest("(every T10 | every T30) & every T1:0"),
            new TDLUnitTest("every T10 | (every T30 !& every T1:0)", "every T10 | every T30 !& every T1:0"),
            new TDLUnitTest("(every T10 | every T30) !& every T1:0"),
            new TDLUnitTest("every T10 | every T30 | every T1:0"),
            new TDLUnitTest("every T10 | (every T30 | every T1:0)", "every T10 | every T30 | every T1:0"),
            new TDLUnitTest("(every T10 | every T30) | every T1:0", "every T10 | every T30 | every T1:0"),
            new TDLUnitTest("(every T10 | every T30) && every T1:0", "every T10 | every T30 && every T1:0"),
            new TDLUnitTest("every T10 | (every T30 && every T1:0)"),
            new TDLUnitTest("(every T10 | every T30) !&& every T1:0", "every T10 | every T30 !&& every T1:0"),
            new TDLUnitTest("every T10 | (every T30 !&& every T1:0)"),
            new TDLUnitTest("(every T10 | every T30), every T1:0", "every T10 | every T30, every T1:0"),
            new TDLUnitTest("every T10 | (every T30, every T1:0)"),
            // Bool intersection
            new TDLUnitTest("every T10 && (every T30 #1-10)", "every T10 && every T30 #1-10"),
            new TDLUnitTest("(every T10 && every T30) #1-10"),
            new TDLUnitTest("every T10 && (every T30 x 10)", "every T10 && every T30 x 10"),
            new TDLUnitTest("(every T10 && every T30) x 10"),
            new TDLUnitTest("every T10 && ((every T30) lasting T1:0)", "every T10 && every T30 lasting T1:0"),
            new TDLUnitTest("(every T10 && every T30) lasting T1:0"),
            new TDLUnitTest("every T10 && (every T30 + T1:0)", "every T10 && every T30 + T1:0"),
            new TDLUnitTest("(every T10 && every T30) + T1:0"),
            new TDLUnitTest("every T10 && (2008-09-15 00:00 <= every T30 < 2008-09-16 00:00)", "every T10 && 2008-09-15 00:00 <= every T30 < 2008-09-16 00:00"),
            new TDLUnitTest("every T10 && (every T30 & every T1:0)", "every T10 && every T30 & every T1:0"),
            new TDLUnitTest("(every T10 && every T30) & every T1:0"),
            new TDLUnitTest("every T10 && (every T30 !& every T1:0)", "every T10 && every T30 !& every T1:0"),
            new TDLUnitTest("(every T10 && every T30) !& every T1:0"),
            new TDLUnitTest("every T10 && (every T30 | every T1:0)", "every T10 && every T30 | every T1:0"),
            new TDLUnitTest("(every T10 && every T30) | every T1:0"),
            new TDLUnitTest("every T10 && every T30 && every T1:0"),
            new TDLUnitTest("(every T10 && every T30) && every T1:0", "every T10 && every T30 && every T1:0"),
            new TDLUnitTest("every T10 && (every T30 && every T1:0)"),
            new TDLUnitTest("(every T10 && every T30) !&& every T1:0", "every T10 && every T30 !&& every T1:0"),
            new TDLUnitTest("every T10 && (every T30 !&& every T1:0)"),
            new TDLUnitTest("(every T10 && every T30), every T1:0", "every T10 && every T30, every T1:0"),
            new TDLUnitTest("every T10 && (every T30, every T1:0)"),
            // Bool non-intersection
            new TDLUnitTest("every T10 !&& (every T30 #1-10)", "every T10 !&& every T30 #1-10"),
            new TDLUnitTest("(every T10 !&& every T30) #1-10"),
            new TDLUnitTest("every T10 !&& (every T30 x 10)", "every T10 !&& every T30 x 10"),
            new TDLUnitTest("(every T10 !&& every T30) x 10"),
            new TDLUnitTest("every T10 !&& ((every T30) lasting T1:0)", "every T10 !&& every T30 lasting T1:0"),
            new TDLUnitTest("(every T10 !&& every T30) lasting T1:0"),
            new TDLUnitTest("every T10 !&& (every T30 + T1:0)", "every T10 !&& every T30 + T1:0"),
            new TDLUnitTest("(every T10 !&& every T30) + T1:0"),
            new TDLUnitTest("every T10 !&& (2008-09-15 00:00 <= every T30 < 2008-09-16 00:00)", "every T10 !&& 2008-09-15 00:00 <= every T30 < 2008-09-16 00:00"),
            new TDLUnitTest("every T10 !&& (every T30 & every T1:0)", "every T10 !&& every T30 & every T1:0"),
            new TDLUnitTest("(every T10 !&& every T30) & every T1:0"),
            new TDLUnitTest("every T10 !&& (every T30 !& every T1:0)", "every T10 !&& every T30 !& every T1:0"),
            new TDLUnitTest("(every T10 !&& every T30) !& every T1:0"),
            new TDLUnitTest("every T10 !&& (every T30 | every T1:0)", "every T10 !&& every T30 | every T1:0"),
            new TDLUnitTest("(every T10 !&& every T30) | every T1:0"),
            new TDLUnitTest("every T10 !&& (every T30 && every T1:0)", "every T10 !&& every T30 && every T1:0"),
            new TDLUnitTest("(every T10 !&& every T30) && every T1:0"),
            new TDLUnitTest("every T10 !&& every T30 !&& every T1:0"),
            new TDLUnitTest("(every T10 !&& every T30) !&& every T1:0", "every T10 !&& every T30 !&& every T1:0"),
            new TDLUnitTest("every T10 !&& (every T30 !&& every T1:0)"),
            new TDLUnitTest("(every T10 !&& every T30), every T1:0", "every T10 !&& every T30, every T1:0"),
            new TDLUnitTest("every T10 !&& (every T30, every T1:0)"),
            // List
            new TDLUnitTest("every T10, (every T30 #1-10)", "every T10, every T30 #1-10"),
            new TDLUnitTest("(every T10, every T30) #1-10"),
            new TDLUnitTest("every T10, (every T30 x 10)", "every T10, every T30 x 10"),
            new TDLUnitTest("(every T10, every T30) x 10"),
            new TDLUnitTest("every T10, ((every T30) lasting T1:0)", "every T10, every T30 lasting T1:0"),
            new TDLUnitTest("(every T10, every T30) lasting T1:0"),
            new TDLUnitTest("every T10, (every T30 + T1:0)", "every T10, every T30 + T1:0"),
            new TDLUnitTest("(every T10, every T30) + T1:0"),
            new TDLUnitTest("every T10, (2008-09-15 00:00 <= every T30 < 2008-09-16 00:00)", "every T10, 2008-09-15 00:00 <= every T30 < 2008-09-16 00:00"),
            new TDLUnitTest("every T10, (every T30 & every T1:0)", "every T10, every T30 & every T1:0"),
            new TDLUnitTest("(every T10, every T30) & every T1:0"),
            new TDLUnitTest("every T10, (every T30 !& every T1:0)", "every T10, every T30 !& every T1:0"),
            new TDLUnitTest("(every T10, every T30) !& every T1:0"),
            new TDLUnitTest("every T10, (every T30 | every T1:0)", "every T10, every T30 | every T1:0"),
            new TDLUnitTest("(every T10, every T30) | every T1:0"),
            new TDLUnitTest("every T10, (every T30 && every T1:0)", "every T10, every T30 && every T1:0"),
            new TDLUnitTest("(every T10, every T30) && every T1:0"),
            new TDLUnitTest("every T10, (every T30 !&& every T1:0)", "every T10, every T30 !&& every T1:0"),
            new TDLUnitTest("(every T10, every T30) !&& every T1:0"),
            new TDLUnitTest("every T10, every T30, every T1:0"),
            new TDLUnitTest("every T10, (every T30, every T1:0)", "every T10, every T30, every T1:0"),
            new TDLUnitTest("(every T10, every T30), every T1:0", "every T10, every T30, every T1:0")
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void ParenParseTest() {
         TDLUnitTest[] tests = {
            new TDLUnitTest("(10:37)", NowDate + " 10:37"),
            new TDLUnitTest("10:37 | (10:38)", NowDate + " 10:37 | " + NowDate + " 10:38"),
            new TDLUnitTest("(10:37) | 10:38", NowDate + " 10:37 | " + NowDate + " 10:38"),
            new TDLUnitTest("(10:37) | (10:38)", NowDate + " 10:37 | " + NowDate + " 10:38"),
            new TDLUnitTest("(10:37 | 10:38)", NowDate + " 10:37 | " + NowDate + " 10:38"),
            new TDLUnitTest("10:37 | (10:38 & 10:39)", NowDate + " 10:37 | " + NowDate + " 10:38 & " + NowDate + " 10:39"),
            new TDLUnitTest("(10:37 | 10:38) & 10:39", "(" + NowDate + " 10:37 | " + NowDate + " 10:38) & " + NowDate + " 10:39"),
            new TDLUnitTest("(10:37 | 10:38 & 10:39)", NowDate + " 10:37 | " + NowDate + " 10:38 & " + NowDate + " 10:39")
         };

         foreach (var t in tests) t.Run();
      }

      private string NowDate {
         get { return DateTime.UtcNow.ToString("yyyy-MM-dd"); }
      }
   }

   /// <summary>
   /// Helper class to test a TDL expression.
   /// Provide a valid TDL expression and an expected string generated by ISchedule.ToString() value.
   /// </summary>
   public class TDLUnitTest {

      public TDLUnitTest(string TDLExpression)
         : this(TDLExpression, TDLExpression) { }

      public TDLUnitTest(string TDLExpression, string TDLVerifyExpression) {
         TDL = TDLExpression;
         TDLVerify = TDLVerifyExpression;
      }

      public string TDL { get; private set; }
      public string TDLVerify { get; private set; }

      public void Run() {
         Debug.WriteLine("Unit test: " + TDL);

         // Test input vs. parsed output
         ISchedule sched = TDLParser.Parse(TDL);
         string verify = sched.ToString();
         Assert.AreEqual(TDLVerify, verify, "TDL Parse result mismatch.");

         // Test parsed output vs. re-parsed output's output
         ISchedule sched2 = TDLParser.Parse(verify);
         string verify2 = sched2.ToString();
         Assert.AreEqual(verify, verify2, "TDL Parse #2 result mismatch.");

         Debug.WriteLine(string.Format("{0}: \"{1}\" evaluates to: \"{2}\"", ExplDiagnostics.CallingMethod, TDL, verify));
      }
   }
}
