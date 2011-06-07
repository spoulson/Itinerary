using System;
using System.Text;

namespace Expl.Itinerary {
   /// <summary>
   /// Conversion functions for Itinerary.
   /// </summary>
   public static class ItineraryConvert {
      /// <summary>
      /// Convert DateTime value to TDL-compatible formatted string.
      /// Drops insignificant milliseconds and/or seconds if zero.
      /// </summary>
      /// <param name="dt">DateTime value</param>
      /// <returns>String representation</returns>
      public static string ToString(DateTime dt) {
         var FormatString = "yyyy-MM-dd HH:mm";
         if (dt.Millisecond != 0)
            FormatString += ":ss.fff";
         else if (dt.Second != 0)
            FormatString += ":ss";
         return dt.ToString(FormatString);
      }

      /// <summary>
      /// Convert TimeSpan value to TDL-compatible formatted string.
      /// Drops insignificant milliseconds and/or seconds if zero.
      /// </summary>
      /// <param name="ts">TimeSpan value</param>
      /// <returns>String representation</returns>
      public static string ToString(TimeSpan ts) {
         StringBuilder sb = new StringBuilder();
         int sign = ts.Ticks < 0 ? -1 : 1;
         sb.Append('T');

         if (ts.Days != 0) {
            sb.Append(string.Format("{0}.{1}:{2}:{3}", ts.Days, ts.Hours * sign, ts.Minutes * sign, ts.Seconds * sign));
         }
         else if (ts.Hours != 0) {
            sb.Append(string.Format("{0}:{1}:{2}", ts.Hours, ts.Minutes * sign, ts.Seconds * sign));
         }
         else if (ts.Minutes != 0) {
            sb.Append(string.Format("{0}:{1}", ts.Minutes, ts.Seconds * sign));
         }
         else {
            sb.Append(ts.Seconds.ToString());
         }

         if (ts.Milliseconds != 0) {
            sb.Append("." + (ts.Milliseconds * sign).ToString());
         }

         return sb.ToString();
      }
   }
}
