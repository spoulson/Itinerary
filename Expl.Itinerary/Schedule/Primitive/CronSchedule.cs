using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Expl.Auxiliary;

namespace Expl.Itinerary {
   /// <summary>
   /// Cron schedule.
   /// </summary>
   public class CronSchedule : IPrimitiveSchedule {
      /// <summary>
      /// Translation table for day of week field.
      /// </summary>
      private static readonly Dictionary<string, string> _XlatDOWLookup = new Dictionary<string, string>() {
         { "7", "0" },
         { "sun", "0" },
         { "mon", "1" },
         { "tue", "2" },
         { "wed", "3" },
         { "thu", "4" },
         { "fri", "5" },
         { "sat", "6" }
      };

      private CronField _MinuteLookup;
      private CronField _HourLookup;
      private CronField _DayLookup;
      private CronField _MonthLookup;
      private CronField _DayOfWeekLookup;
      private TimeSpan _Duration;

      /// <summary>
      /// Default constructor.
      /// </summary>
      public CronSchedule()
         : this("*", "*", "*", "*", "*", TimeSpan.Zero) { }

      /// <summary>
      /// Constructor for cron specification of event intervals.
      /// </summary>
      /// <param name="MinuteSpec">Minute spec.</param>
      /// <param name="HourSpec">Hour spec.</param>
      /// <param name="DaySpec">Day spec.</param>
      /// <param name="MonthSpec">Month spec.</param>
      /// <param name="DayOfWeekSpec">Day of week spec.</param>
      /// <param name="Duration">Duration of event.</param>
      public CronSchedule(string MinuteSpec, string HourSpec, string DaySpec, string MonthSpec, string DayOfWeekSpec, TimeSpan Duration) {
         _MinuteLookup = new CronField(MinuteSpec, 0, 59);
         _HourLookup = new CronField(HourSpec, 0, 23);
         _DayLookup = new CronField(DaySpec, 1, 31);
         _MonthLookup = new CronField(MonthSpec, 1, 12);
         _DayOfWeekLookup = new CronField(DayOfWeekSpec, 0, 6, XlatDOW);
         _Duration = Duration;
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

         for (int Year = IterateStart.Year; Year <= RangeEnd.Year; Year++) {

            foreach (int Month in _MonthLookup.PickList.Where(x => MonthStart.HasValue ? x >= MonthStart.Value : true)) {
               var DOWCounter = new int[] { 0, 0, 0, 0, 0, 0, 0 };
               if (MonthStart.HasValue && Month != MonthStart.Value)
                  MonthStart = DayStart = HourStart = MinuteStart = null;
                  
               int MonthDays = Calendar.GetMonthDays(Year, Month);

               foreach (int Day in _DayLookup.PickList.Where(x => (DayStart.HasValue ? x >= DayStart.Value : true) && x <= MonthDays)) {
                  if (DayStart.HasValue && Day != DayStart.Value)
                     DayStart = HourStart = MinuteStart = null;

                  // Compute day of week.
                  int DOW = (int)new DateTime(Year, Month, Day).DayOfWeek;

                  // Skip this daBy if DOW doesn't match
                  if (!_DayOfWeekLookup[DOW]) continue;
                  DOWCounter[DOW]++;
                  if (_DayOfWeekLookup.OccurranceIndex.HasValue) {
                     // Check DOW occurance index.
                     // Handle special case for last occurance (negative range).
                     int occuranceIndex = _DayOfWeekLookup.OccurranceIndex < 0 ?
                        // Compute last occurrance index.
                        ComputeLastDOWOccurance(Year, Month, DOW) + _DayOfWeekLookup.OccurranceIndex.Value + 1 :
                        _DayOfWeekLookup.OccurranceIndex.Value - 1;

                     if (occuranceIndex != DOWCounter[DOW] - 1) continue;
                  }

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

      /// <summary>
      /// Compute last occurance index of a day of week in a month.
      /// </summary>
      /// <param name="Year"></param>
      /// <param name="Month"></param>
      /// <param name="DOW"></param>
      /// <returns></returns>
      private int ComputeLastDOWOccurance(int Year, int Month, int DOW) {
         var A = new DateTime(Year, Month, 1).AddDays(DOW);
         var B = new DateTime(Year, Month + 1, 1).AddDays(-1);
         return ((int)A.DayOfWeek + B.Day) / 7 - 1;
      }

      /// <summary>
      /// Translation function for day of week tokens.
      /// </summary>
      /// <param name="value"></param>
      /// <returns></returns>
      private static string XlatDOW(string value) {
         var lookupKey = value.ToLower();
         if (_XlatDOWLookup.ContainsKey(lookupKey))
            return _XlatDOWLookup[lookupKey];

         return value;
      }
   }

   /// <summary>
   /// Cron numeric field parser.
   /// </summary>
   /// <remarks>
   /// TODO: Consider migrating parser to ANTLR grammar?  IntSpec syntax?
   /// </remarks>
   public class CronField {
      public const int LAST_OCCURANCE_INDEX = -1;
      private int _Min, _Max;
      private Func<string, string> _XlatFunc;
      private string _CronSpec;
      private bool[] _Lookup;
      private List<int> _PickList;
      private int? _OccurranceIndex;
      private static readonly Regex _RegexStep = new Regex("/(\\w+)$");
      private static readonly Regex _RegexSingle = new Regex("^\\w+$");
      private static readonly Regex _RegexRange = new Regex("^(\\w+)-(\\w+)$");
      private static readonly Regex _RegexMinMaxRange = new Regex("^([<>])(\\w+)$");

      public CronField(string CronSpec, int Min, int Max)
         : this(CronSpec, Min, Max, x => x) { }

      public CronField(string CronSpec, int Min, int Max, Func<string, string> XlatFunc) {
         _Min = Min;
         _Max = Max;
         _XlatFunc = XlatFunc;
         var Length = _Max - Min + 1;
         _Lookup = new bool[Length];
         Array.Clear(_Lookup, 0, Length);

         _CronSpec = CronSpec;
         Parse(CronSpec);
      }

      /// <summary>
      /// Get cron field spec string.
      /// </summary>
      public string CronSpec {
         get { return _CronSpec; }
      }

      /// <summary>
      /// Get occurrance match index.  Index is 1-based.
      /// Index of -1 means last occurance.
      /// </summary>
      public int? OccurranceIndex {
         get { return _OccurranceIndex; }
      }

      /// <summary>
      /// Get minimum field value.
      /// </summary>
      public int Min {
         get { return _Min; }
      }

      /// <summary>
      /// Get maximum field value.
      /// </summary>
      public int Max {
         get { return _Max; }
      }

      /// <summary>
      /// Lookup whether value matches cron field spec.
      /// </summary>
      /// <param name="Value"></param>
      /// <returns></returns>
      public bool this[int Value] {
         get {
            if (Value < _Min) throw new ArgumentOutOfRangeException("Argument is below the minimum");
            if (Value > _Max) throw new ArgumentOutOfRangeException("Argument is greater than the maximum");
            int ArrayIndex = Value - _Min;
            return _Lookup[ArrayIndex];
         }
      }

      /// <summary>
      /// Get list of matching values in cron field spec.
      /// </summary>
      public IEnumerable<int> PickList {
         get { return _PickList; }
      }

      private void Set(int Index, bool Value) {
         int ArrayIndex = Index - _Min;
         _Lookup[ArrayIndex] = Value;
      }

      /// <summary>
      /// Parse Cron field spec string.
      /// </summary>
      /// <param name="Cron"></param>
      private void Parse(string Cron) {
         List<int> TallyList = new List<int>();
         List<int> NotList = new List<int>();
         Match RegMatch;

         // Parse occurrance index.
         string[] CronIndexParts = Cron.Split('#');
         string CronItem = CronIndexParts[0];
         string IndexArg = CronIndexParts.Skip(1).FirstOrDefault();
         if (IndexArg == "L") {
            _OccurranceIndex = LAST_OCCURANCE_INDEX;
         }
         else {
            int OccurranceIndex;
            if (int.TryParse(IndexArg, out OccurranceIndex)) {
               _OccurranceIndex = OccurranceIndex;
            }
            else {
               // If unparsable, assume no index.
               _OccurranceIndex = null;
            }
         }

         foreach (string Arg in CronItem.Split(',')) {
            var Item = Arg;
            List<int> PickList = new List<int>();
            var Step = 1;
            var NotFlag = false;

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
               PickList.Add(int.Parse(_XlatFunc(Item)));
            }
            // Parse wildcard
            else if (Item == "*") {
               PickList.AddRange(Enumerable.Range(_Min, _Max - _Min + 1));
            }
            // Parse range
            else if ((RegMatch = _RegexRange.Match(Item)).Success) {
               int RangeStart = int.Parse(_XlatFunc(RegMatch.Groups[1].Value));
               int RangeEnd = int.Parse(_XlatFunc(RegMatch.Groups[2].Value));
               for (int i = RangeStart; i <= RangeEnd; i++) {
                  PickList.Add(i);
               }
            }
            // Parse less than/greater than range
            else if ((RegMatch = _RegexMinMaxRange.Match(Item)).Success) {
               int RangeStart, RangeEnd;
               if (RegMatch.Groups[1].Value == "<") {
                  RangeStart = _Min;
                  RangeEnd = int.Parse(_XlatFunc(RegMatch.Groups[2].Value)) - 1;
               }
               else {
                  RangeStart = int.Parse(_XlatFunc(RegMatch.Groups[2].Value)) + 1;
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
            );
         }
      }
   }
}
