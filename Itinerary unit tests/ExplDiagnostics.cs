using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace Expl.Auxiliary {
   public static class ExplDiagnostics {
      /// <summary>
      /// DateTime format used in timestamps for debug output.
      /// </summary>
      private const string StdDateTimeFormat = "yyyy-MM-dd HH:mm:ss.fff";

      /// <summary>
      /// Get fully qualified method name of calling method/property from stack.
      /// </summary>
      public static string ThisMethod {
         get {
            StackTrace st = new StackTrace();
            MethodBase method = st.GetFrame(1).GetMethod();
            return method.ReflectedType.ToString() + "." + method.Name;
         }
      }

      /// <summary>
      /// Get fully qualified method name of calling method/property from stack.
      /// </summary>
      public static string CallingMethod {
         get {
            var st = new StackTrace();
            var method = st.GetFrame(2).GetMethod();
            return method.ReflectedType.ToString() + "." + method.Name;
         }
      }

      /// <summary>
      /// Write debug text and include the class/method name and time stamp.
      /// </summary>
      /// <param name="text">Text to write.</param>
      public static void WriteLine(string text) {
         var mb = new StackTrace().GetFrame(1).GetMethod();
         Debug.WriteLine(string.Format("{0}.{1},{2}:\n* {3}", mb.ReflectedType.ToString(), mb.Name, DateTime.Now.ToString(StdDateTimeFormat), text));
      }

      /// <summary>
      /// Write debug text using string.Format() and include the class/method name and time stamp.
      /// </summary>
      /// <param name="text">Text format string.</param>
      /// <param name="args">Arguments to string.Format().</param>
      public static void WriteLine(string text, params object[] args) {
         WriteLine(string.Format(text, args));
      }

      /// <summary>
      /// Write debug text and include the class/method name and time stamp.
      /// </summary>
      /// <param name="delg">Delegate that returns text to write.</param>
      /// <remarks>
      /// In debug mode, this method does as intended.
      /// In release mode, the delegate is never executed.  Performance overhead to calling code is reduced by not processing the parameters.
      /// </remarks>
      public static void WriteLine(Func<string> delg) {
         WriteLine(delg());
      }

      /// <summary>
      /// Execute a delegate in debug build only.
      /// </summary>
      /// <param name="delg">Delegate to execute</param>
      public static void InDebug(Action delg) {
         delg();
      }

      /// <summary>
      /// Get human readable dump of exception message(s).
      /// </summary>
      /// <param name="ex">Exception object.</param>
      /// <returns>Exception dump.</returns>
      public static string GetExceptionMessages(this Exception ex) {
         var sb = new StringBuilder();
         sb.Append("Exception: ");
         sb.Append(ex.GetType().ToString());
         sb.Append(", ");
         sb.Append(ex.Message);

         Exception innerEx = ex.InnerException;
         while (innerEx != null) {
            sb.Append(Environment.NewLine);
            sb.Append("Inner exception: ");
            sb.Append(innerEx.GetType().ToString());
            sb.Append(", ");
            sb.Append(innerEx.Message);

            innerEx = innerEx.InnerException;
         }

         return sb.ToString();
      }
   }
}
