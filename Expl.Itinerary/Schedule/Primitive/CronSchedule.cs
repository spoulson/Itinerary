using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Expl.Auxiliary;

namespace Expl.Itinerary {
   public class CronSchedule : IPrimitiveSchedule {
      protected CronField _MinuteLookup;
      protected CronField _HourLookup;
      protected CronField _DayLookup;
      protected CronField _MonthLookup;
      protected CronField _DayOfWeekLookup;
      protected TimeSpan _Duration;

      /// <summary>
      /// Default constructor
      /// </summary>
      public CronSchedule()
         : this("*", "*", "*", "*", "*", TimeSpan.Zero) { }

      /// <summary>
      /// Constructor for cron specification of event intervals
      /// </summary>
      /// <param name="MinuteSpec">Minute spec</param>
      /// <param name="HourSpec">Hour spec</param>
      /// <param name="DaySpec">Day spec</param>
      /// <param name="MonthSpec">Month spec</param>
      /// <param name="DayOfWeekSpec">Day of week spec</param>
      /// <param name="Duration">Duration of event</param>
      public CronSchedule(string MinuteSpec, string HourSpec, string DaySpec, string MonthSpec, string DayOfWeekSpec, TimeSpan Duration) {
         _MinuteLookup = new CronField(MinuteSpec, 0, 59);
         _HourLookup = new CronField(HourSpec, 0, 23);
         _DayLookup = new CronField(DaySpec, 1, 31);
         _MonthLookup = new CronField(MonthSpec, 1, 12);
         _DayOfWeekLookup = new CronField(DayOfWeekSpec, 0, 6);
         _Duration = Duration;
      }

      public void Dispose() {
         _MinuteLookup = null;
         _HourLookup = null;
         _DayLookup = null;
         _MonthLookup = null;
         _DayOfWeekLookup = null;
      }

      public int OperatorPrecedence { get { return 1; } }

      public override string ToString() {
         var sb = new StringBuilder(string.Format("cron {0} {1} {2} {3} {4}", _MinuteLookup.CronSpec, _HourLookup.CronSpec, _DayLookup.CronSpec, _MonthLookup.CronSpec, _DayOfWeekLookup.CronSpec));
         if (_Duration != TimeSpan.Zero) {
            sb.Append(" lasting ");
            sb.Append(ItineraryConvert.ToString(_Duration));
         }
         return sb.ToString();
      }

      public IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd) {
         // Determine start of iteration by stepping back _Duration time, then adding 1 minute (smallest increment in cron)
         TimeSpan OneMinute = new TimeSpan(0, 1, 0);
         TimeSpan StepBackTime = _Duration >= OneMinute ? _Duration.Subtract(OneMinute) : TimeSpan.Zero;
         DateTime IterateStart = RangeStart.Ticks >= StepBackTime.Ticks ? RangeStart.Subtract(StepBackTime) : DateTime.MinValue;

         // Strip seconds, ms, and ticks
         IterateStart.AddTicks(-(IterateStart.Ticks % TimeSpan.TicksPerMinute));

         // Start iteration with restricted ranges
         int? MonthStart = IterateStart.Month;
         int? DayStart = IterateStart.Day;
         int? HourStart = IterateStart.Hour;
         int? MinuteStart = IterateStart.Minute;

         // Change flags indicate when range is no longer restricted to the starting DateTime
         //bool MonthChanged = false;
         //bool DayChanged = false;
         //bool HourChanged = false;
         //bool MinuteChanged = false;

         for (int Year = IterateStart.Year; Year <= RangeEnd.Year; Year++) {

            foreach (int Month in _MonthLookup.PickList.Where(x => MonthStart.HasValue ? x >= MonthStart.Value : true)) {
               if (MonthStart.HasValue && Month != MonthStart.Value)
                  MonthStart = DayStart = HourStart = MinuteStart = null;
                  
               int MonthDays = Calendar.GetMonthDays(Year, Month);

               foreach (int Day in _DayLookup.PickList.Where(x => (DayStart.HasValue ? x >= DayStart.Value : true) && x <= MonthDays)) {
                  if (DayStart.HasValue && Day != DayStart.Value)
                     DayStart = HourStart = MinuteStart = null;

                  int DOW = (int)new DateTime(Year, Month, Day).DayOfWeek;
                  // Skip this daBy if DOW doesn't match
                  if (!_DayOfWeekLookup[DOW]) continue;

                  foreach (int Hour in _HourLookup.PickList.Where(x => HourStart.HasValue ? x >= HourStart.Value : true)) {
                     if (HourStart.HasValue && Hour != HourStart.Value)
                        HourStart = MinuteStart = null;

                     foreach (int Minute in _MinuteLookup.PickList.Where(x => MinuteStart.HasValue ? x >= MinuteStart.Value : true)) {
                        DateTime Next = new DateTime(Year, Month, Day, Hour, Minute, 0);
                        if (Next >= RangeEnd) yield break;
                        TimedEvent ReturnEvent = new TimedEvent(Next, _Duration);

                        yield return ReturnEvent;
                     }

                     MinuteStart = null;
                  }

                  HourStart = MinuteStart = null;
               }

               DayStart = HourStart = MinuteStart = null;
            }

            MonthStart = DayStart = HourStart = MinuteStart = null;
         }

         yield break;
      }
   }

   public class CronField {
      private int _Min, _Max;
      private string _CronSpec;
      private bool[] _Lookup;
      private List<int> _PickList;
      private static Regex _RegexStep = new Regex("/(\\d+)$");
      private static Regex _RegexSingle = new Regex("^\\d+$");
      private static Regex _RegexRange = new Regex("^(\\d+)-(\\d+)$");
      private static Regex _RegexMinMaxRange = new Regex("^([<>])(\\d+)$");

      public CronField(string CronSpec, int Min, int Max) {
         _Min = Min;
         _Max = Max;
         _Lookup = new bool[Length];
         Array.Clear(_Lookup, 0, Length);

         _CronSpec = CronSpec;
         Parse(CronSpec);
      }

      public int Length {
         get { return _Max - _Min + 1; }
      }

      public IEnumerable<int> Range {
         get {
            for (int i = _Min; i <= _Max; i++) {
               yield return i;
            }
         }
      }

      public string CronSpec {
         get { return _CronSpec; }
      }

      public bool this[int Index] {
         get {
            if (Index < _Min) throw new ArgumentOutOfRangeException("Index argument is below the minimum");
            if (Index > _Max) throw new ArgumentOutOfRangeException("Index argument is greater than the maximum");
            int ArrayIndex = Index - _Min;
            return _Lookup[ArrayIndex];
         }
      }

      public IEnumerable<int> PickList {
         get { return _PickList; }
      }

      private void Set(int Index, bool Value) {
         int ArrayIndex = Index - _Min;
         _Lookup[ArrayIndex] = Value;
      }

      private void Parse(string Cron) {
         List<int> TallyList = new List<int>();
         List<int> NotList = new List<int>();
         Match RegMatch;

         foreach (string Arg in Cron.Split(',')) {
            string Item = Arg;
            List<int> PickList = new List<int>();
            int Step = 1;
            bool NotFlag = false;

            // Parse step
            if ((RegMatch = _RegexStep.Match(Item)).Success) {
               Step = int.Parse(RegMatch.Groups[1].Value);
               Item = _RegexStep.Replace(Item, "");
            }

            // Parse not
            if (Item[0] == '!') {
               NotFlag = true;
               Item = Item.Substring(1);
            }

            // Parse single value
            if (_RegexSingle.IsMatch(Item)) {
               PickList.Add(int.Parse(Item));
            }
            // Parse wildcard
            else if (Item == "*") {
               PickList.AddRange(Range);
            }
            // Parse range
            else if ((RegMatch = _RegexRange.Match(Item)).Success) {
               int RangeStart = int.Parse(RegMatch.Groups[1].Value);
               int RangeEnd = int.Parse(RegMatch.Groups[2].Value);
               for (int i = RangeStart; i <= RangeEnd; i++) {
                  PickList.Add(i);
               }
            }
            // Parse less than/greater than range
            else if ((RegMatch = _RegexMinMaxRange.Match(Item)).Success) {
               int RangeStart, RangeEnd;
               if (RegMatch.Groups[1].Value == "<") {
                  RangeStart = _Min;
                  RangeEnd = int.Parse(RegMatch.Groups[2].Value) - 1;
               }
               else {
                  RangeStart = int.Parse(RegMatch.Groups[2].Value) + 1;
                  RangeEnd = _Max;
               }
               for (int i = RangeStart; i <= RangeEnd; i++) {
                  PickList.Add(i);
               }
            }

            // Process step filter
            if (Step > 1) {
               int Index = 0;
               PickList = new List<int>(PickList.Where(x => (Index++ % Step == 0)));
            }

            if (NotFlag)
               NotList.AddRange(PickList);
            else
               TallyList.AddRange(PickList);
         }

         // Transfer TallyList to Lookup
         foreach (int i in TallyList) {
            Set(i, true);
         }

         // Remove items in Lookup found in the NotList
         foreach (int i in NotList) {
            Set(i, false);
         }

         // Transfer _Lookup true's to _PickList
         {
            int Index = _Min;
            _PickList = new List<int>(
               _Lookup.Where<bool>(x => { Index++; return x; }).Select<bool, int>(x => Index - 1)
               //Enumerable.Map<bool, int>(
               //   _Lookup.Where(x => { Index++; return x; }),
               //   x => Index - 1)
            );
         }
      }
   }
}
