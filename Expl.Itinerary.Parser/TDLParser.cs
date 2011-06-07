using System;
using Antlr.Runtime;

namespace Expl.Itinerary {
   /// <summary>
   /// Helper class for calling parser to generate an ISchedule object from TDL string.
   /// </summary>
   public static class TDLParser {
      /// <summary>
      /// Parse TDL string to ISchedule object.
      /// </summary>
      /// <param name="Text">TDL string.</param>
      /// <returns>ISchedule object.</returns>
      public static ISchedule Parse(string Text) {
         TimeDefParser parser = GetParser(Text);

         try {
            TimeDefParser.prog_return prog_ret = parser.prog();
            return prog_ret == null ? null : prog_ret.value;
         }
         catch (Exception ex) {
            throw new ParserException(ex.Message, ex);
         }
      }

      /// <summary>
      /// Validate TDL string for syntax.
      /// </summary>
      /// <param name="Text">TDL string.</param>
      /// <returns>True if valid.</returns>
      public static bool IsValid(string Text) {
         try {
            ISchedule s = TDLParser.Parse(Text);
            return s is ISchedule;
         }
         catch (ParserException) { }
         return false;
      }

      /// <summary>
      /// Parse Date/time string from format:
      /// YYYY-MM-DD [hh:mm[:ss[.ffff]]] or
      /// hh:mm[:ss[.ffff]]]   (omitting date parts assumes current UTC date).
      /// </summary>
      /// <param name="Text">Date/time string.</param>
      /// <returns>DateTime value.</returns>
      public static DateTime ParseDateTime(string Text) {
         try {
            var ret = GetParser(Text).datetime_prog();
            return ret.value;
         }
         catch (Exception ex) {
            throw new ParserException(ex.Message, ex);
         }
      }

      /// <summary>
      /// Validate Date/time string for syntax.
      /// See ParseDateTime() for valid syntax.
      /// </summary>
      /// <param name="Text">Date/time string.</param>
      /// <returns>True if valid.</returns>
      public static bool IsValidDateTime(string Text) {
         try {
            var dt = TDLParser.ParseDateTime(Text);
         }
         catch (ParserException) {
            return false;
         }
         return true;
      }

      /// <summary>
      /// Parse timespan string from format:
      /// T[[[DD.]hh:]mm:]ss[.ffff]
      /// </summary>
      /// <param name="Text">Timespan string.</param>
      /// <returns>Timespan value.</returns>
      public static TimeSpan ParseTimeSpan(string Text) {
         try {
            var ret = GetParser(Text).timespan_prog();
            return ret.value;
         }
         catch (Exception ex) {
            throw new ParserException(ex.Message, ex);
         }
      }

      /// <summary>
      /// Validate timespan string for syntax.
      /// See ParseTimeSpan() for valid syntax.
      /// </summary>
      /// <param name="Text">Timespan string.</param>
      /// <returns>True if valid.</returns>
      public static bool IsValidTimeSpan(string Text) {
         try {
            var ts = TDLParser.ParseTimeSpan(Text);
         }
         catch (ParserException) {
            return false;
         }
         return true;
      }

      /// <summary>
      /// Instantiate ANTLR-based TDL parser and parse TDL.
      /// </summary>
      /// <param name="Text">TDL string.</param>
      /// <returns>TimeDefParser object.</returns>
      private static TimeDefParser GetParser(string Text) {
         ICharStream input = new ANTLRStringStream(Text);
         TimeDefLexer lex = new TimeDefLexer(input);
         CommonTokenStream tokens = new CommonTokenStream(lex);
         return new TimeDefParser(tokens);
      }

      /// <summary>
      /// TDL parser exception.
      /// </summary>
      public class ParserException : Exception {
         public ParserException(string Message) : base(Message) { }
         public ParserException(string Message, Exception InnerException) : base(Message, InnerException) { }
      }
   }
}
