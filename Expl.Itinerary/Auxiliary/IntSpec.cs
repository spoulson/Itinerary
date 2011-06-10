using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Expl.Auxiliary.Sequence;
using System;

namespace Expl.Auxiliary {
   /// <summary>
   /// Shorthand input string to represent lists and ranges of integers.
   /// </summary>
   /// <remarks>
   /// Acceptable IntSpec operator syntax in order of precedence:
   ///  n/i
   ///  !n
   ///  n-m
   ///  n,m,o
   ///
   /// Index values much be greater than zero.
   /// Throw exception on invalid format or number range.
   /// 
   /// TODO: Consider converting to ANTLR parser?
   /// </remarks>
   public static class IntSpec {
      private static readonly Regex _RegexStep = new Regex("/(-?\\d+)$");
      private static readonly Regex _RegexSingle = new Regex("^-?\\d+$");
      private static readonly Regex _RegexRange = new Regex("^(-?\\d+)-(-?\\d+)$");
      private static readonly Regex _RegexValid = new Regex("^(\\*|-?\\d+(--?\\d+)?)(/\\d+)?$");

      /// <summary>
      /// Check if string is valid IntSpec syntax.
      /// </summary>
      /// <param name="SpecString">IntSpec string.</param>
      /// <returns>True if valid.</returns>
      public static bool IsValidIntSpec(string SpecString) {
         return _RegexValid.IsMatch(SpecString);
      }

      /// <summary>
      /// Parse IntSpec and generate enumeration of integers.
      /// </summary>
      /// <param name="SpecString">IntSpec string.</param>
      /// <returns>Integer enumeration.</returns>
      public static IEnumerable<int> Parse(string SpecString) {
         return Parse(SpecString, 0, int.MaxValue);
      }

      /// <summary>
      /// Parse IntSpec string and clip ranges by min/max values.
      /// </summary>
      /// <param name="SpecString">IntSpec string.</param>
      /// <param name="MinValue">Minimum inclusive range.</param>
      /// <param name="MaxValue">Maximum inclusive range.</param>
      /// <returns>Integer enumeration.</returns>
      public static IEnumerable<int> Parse(string SpecString, int MinValue, int MaxValue) {
         // Split specs by comma and parse each item
         string[] Spec = SpecString.Split(',');
         IEnumerable<int> EnumChain = null;

         for (int i = 0; i < Spec.Length; i++) {
            string IntSpec = Spec[i];
            bool NotFlag = false;

            // Parse not
            if (IntSpec[0] == '!') {
               NotFlag = true;
               IntSpec = IntSpec.Substring(1);
            }

            if (NotFlag) {
               if (EnumChain != null) {
                  // Use list to remove from previously defined enumeration
                  EnumChain = EnumChain.SequenceDifference(ParseTerm(IntSpec, MinValue, MaxValue), (a, b) => a.CompareTo(b));
               }
            }
            else {
               if (EnumChain == null)
                  // Define first enumeration
                  EnumChain = ParseTerm(IntSpec, MinValue, MaxValue);
               else {
                  // Combine with previously defined enumeration and removal duplicates
                  EnumChain = new[] { EnumChain, ParseTerm(IntSpec, MinValue, MaxValue) }
                     .SequenceFlatten<int>((a, b) => a.CompareTo(b))
                     .SequenceDistinct((a, b) => a.CompareTo(b));
               }
            }
         }

         // Return resultant enumerable, if any
         return EnumChain ?? new int[] { };
      }

      /// <summary>
      /// Parse single term of a comma-separated series.
      /// </summary>
      /// <param name="SpecString"></param>
      /// <param name="MinValue"></param>
      /// <param name="MaxValue"></param>
      /// <returns></returns>
      private static IEnumerable<int> ParseTerm(string SpecString, int MinValue, int MaxValue) {
         Match RegMatch;
         int Step = 1;
         int RangeStart = MinValue;
         int RangeEnd = MaxValue;

         // Parse step
         if ((RegMatch = _RegexStep.Match(SpecString)).Success) {
            Step = int.Parse(RegMatch.Groups[1].Value);
            SpecString = _RegexStep.Replace(SpecString, "");
         }

         // Parse wildcard
         if (SpecString == "*") {
            // Do nothing, use defaults
         }
         // Parse single value
         else if (_RegexSingle.IsMatch(SpecString)) {
            RangeEnd = RangeStart = int.Parse(SpecString);
         }
         // Parse range
         else if ((RegMatch = _RegexRange.Match(SpecString)).Success) {
            RangeStart = int.Parse(RegMatch.Groups[1].Value);
            RangeEnd = int.Parse(RegMatch.Groups[2].Value);
         }
         // Invalid!
         else {
            yield break;
         }

         // Enforce value limits
         if (RangeStart > MaxValue) RangeStart = MaxValue;
         else if (RangeStart < MinValue) RangeStart = MinValue;
         if (RangeEnd > MaxValue) RangeEnd = MaxValue;
         else if (RangeEnd < MinValue) RangeEnd = MinValue;

         // Generate counter
         int Count = Math.Min(RangeEnd - RangeStart, int.MaxValue - 1) + 1;
         IEnumerable<int> Counter = System.Linq.Enumerable.Range(RangeStart, Count);
         int Index = 0;
         foreach (int i in Counter.Where(x => (Index++ % Step == 0)))
            yield return i;

         yield break;
      }
   }
}
