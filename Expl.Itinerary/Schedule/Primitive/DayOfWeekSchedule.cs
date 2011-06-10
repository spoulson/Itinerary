using System;
using System.Collections.Generic;
using System.Linq;
using Expl.Auxiliary;

namespace Expl.Itinerary {
   /// <summary>
   /// Day of week schedule.
   /// </summary>
   /// <remarks>
   /// TODO: Merge this concept into CronSchedule as '#' markup.  Eliminate syntax from ANTLR grammar.  Update unit tests.
   /// See http://en.wikipedia.org/wiki/Cron
   /// </remarks>
   public class DayOfWeekSchedule : IPrimitiveSchedule {
      protected string _DayOfWeekSpec;
      protected string _OrdinalSpec;
      protected IEnumerable<int> _DayOfWeekEnum;
      protected IEnumerable<int> _OrdinalEnum;

      /// <summary>
      /// Default constructor
      /// </summary>
      public DayOfWeekSchedule()
         : this("*", "*") { }

      public DayOfWeekSchedule(string DayOfWeekSpec)
         : this("*", DayOfWeekSpec) { }

      public DayOfWeekSchedule(string OrdinalSpec, string DayOfWeekSpec) {
         _DayOfWeekSpec = DayOfWeekSpec;
         _DayOfWeekEnum = IntSpec.Parse(_DayOfWeekSpec, 0, 6);
         _OrdinalSpec = OrdinalSpec;
         _OrdinalEnum = IntSpec.Parse(_OrdinalSpec, -5, 5);
      }

      public int OperatorPrecedence { get { return 1; } }

      public string DayOfWeekSpec { get { return _DayOfWeekSpec; } }
      public string OrdinalSpec { get { return _OrdinalSpec; } }

      public override string ToString() {
         return string.Format("week {0} {1}", _OrdinalSpec, _DayOfWeekSpec);
      }

      // Spaghetti vomit code - but it works!
      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         // Compute DOW of RangeStart
         int DOW = (int)RangeStart.DayOfWeek;
         int MinDOW = DOW;
         int FirstDOW = (int)new DateTime(RangeStart.Year, RangeStart.Month, 1).DayOfWeek;

         // Compute ordinal of DOW of RangeStart
         int Ordinal = 1;
         int MonthLength = Calendar.GetMonthDays(RangeStart.Year, RangeStart.Month);
         for (int Day = 1; Day <= MonthLength && Day < RangeStart.Day; Day += 7)
            Ordinal++;

         // WorkStart = Date to begin scanning within a week; usually on a Sunday
         var WorkStart = new DateTime(RangeStart.Year, RangeStart.Month, (Ordinal - 1) * 7 + 1);

         while (WorkStart < RangeEnd) {
            // Check for week ordinal match
            if (_OrdinalEnum.Contains(Ordinal)) {
               bool RecheckFlag = false;

               // Compare DOW IntSpec to the current Ordinal week
               TimeSpan DayOffset = TimeSpan.Zero;
               DateTime ReturnTime = WorkStart + DayOffset;
               foreach (int NextDOW in _DayOfWeekEnum.Where(x => x >= MinDOW)) {
                  //int NextDOW = NextDOW1 % 7;
                  if (DOW != NextDOW) {
                     // Advance DayOffset to match NextDOW
                     int IncrDays1 = NextDOW > DOW ? NextDOW - DOW : NextDOW + 7 - DOW;
                     DayOffset += new TimeSpan(IncrDays1, 0, 0, 0);
                     int NewDOW1 = (DOW + IncrDays1) % 7;
                     ReturnTime = WorkStart + DayOffset;
                     if (ReturnTime.Month != WorkStart.Month) {
                        // Incremented to next month
                        Ordinal = 1;
                        WorkStart = new DateTime(ReturnTime.Year, ReturnTime.Month, 1);
                        DOW = MinDOW = FirstDOW = (int)WorkStart.DayOfWeek;
                        RecheckFlag = true;
                        break;
                     }
                     else if (DOW < FirstDOW && NewDOW1 >= FirstDOW) {
                        // Crossed a week boundary on FirstDOW
                        Ordinal++;
                        WorkStart = WorkStart.AddDays(FirstDOW - DOW);
                        DOW = MinDOW = FirstDOW;
                        RecheckFlag = true;
                        break;
                     }
                     else {
                        // Advance to NextDOW
                        DOW = NextDOW;
                     }
                  }

                  if (ReturnTime >= RangeEnd) yield break;
                  else yield return new TimedEvent(ReturnTime, new TimeSpan(1, 0, 0, 0));
               }

               if (RecheckFlag) continue;

               // Advance to next Sunday
               var NewTime3 = ReturnTime.AddDays(7 - DOW);
               if (NewTime3.Month != WorkStart.Month) {
                  // Incremented to next month
                  Ordinal = 1;
                  NewTime3 = new DateTime(NewTime3.Year, NewTime3.Month, 1);
                  MinDOW = FirstDOW = (int)NewTime3.DayOfWeek;
               }
               else if (FirstDOW == 0 || DOW < FirstDOW) {
                  // Increment ordinal if crossed a week boundary
                  Ordinal++;
               }
               WorkStart = NewTime3;
               DOW = MinDOW = 0;
            }
            else {
               // Skip to next week
               DateTime NewTime2 = WorkStart.AddDays(FirstDOW == DOW ? 7 : (FirstDOW - DOW + 7) % 7);
               if (NewTime2.Month != WorkStart.Month) {
                  // Incremented to next month
                  Ordinal = 1;
                  NewTime2 = new DateTime(NewTime2.Year, NewTime2.Month, 1);
                  DOW = MinDOW = FirstDOW = (int)NewTime2.DayOfWeek;
               }
               else {
                  // Advance to next week
                  DOW = MinDOW = FirstDOW;
                  Ordinal++;
               }
               WorkStart = NewTime2;
            }
         }
      }
   }
}
