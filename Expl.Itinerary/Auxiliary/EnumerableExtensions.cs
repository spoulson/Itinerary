using System.Collections;
using System.Text;

namespace Expl.Auxiliary {
   /// <summary>
   /// Useful extensions for IEnumerable.
   /// </summary>
   public static class EnumerableExtensions {
      /// <summary>
      /// Join list of strings with delimiter.
      /// </summary>
      /// <param name="List">List of strings.</param>
      /// <param name="Delimiter">Delimiter string.</param>
      /// <returns>Joined string.</returns>
      public static string JoinStrings(this IEnumerable List, string Delimiter) {
         var sb = new StringBuilder();
         bool IterateFlag = false;

         foreach (var o in List) {
            if (IterateFlag) sb.Append(Delimiter);
            else IterateFlag = true;
            sb.Append(o.ToString());
         }

         return sb.ToString();
      }
   }
}