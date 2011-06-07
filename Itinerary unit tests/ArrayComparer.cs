using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expl.Itinerary.Test {
   /// <summary>
   /// Asserts two sequences for exact matching ordered contents.
   /// Provides debug feedback for each item comparison.
   /// Functionally similar to Enumerable.SequenceEqual()
   /// </summary>
   public static class SequenceComparer {
      /// <summary>
      /// Assert sequence equality according to object.GetHashCode() value.
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="ExpectedList"></param>
      /// <param name="ActualList"></param>
      public static void AssertEquals<T>(IEnumerable<T> ExpectedList, IEnumerable<T> ActualList) where T : class {
         AssertEquals(ActualList, ExpectedList, (a, b) => a.GetHashCode() == b.GetHashCode());
      }

      /// <summary>
      /// Assert sequence equality according to delegate function returning boolean.
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="ExpectedList"></param>
      /// <param name="ActualList"></param>
      /// <param name="Comparer"></param>
      public static void AssertEquals<T>(IEnumerable<T> ExpectedList, IEnumerable<T> ActualList, Func<T, T, bool> Comparer) {
         IEnumerator<T> enum1 = ActualList.GetEnumerator();
         IEnumerator<T> enum2 = ExpectedList.GetEnumerator();
         bool enum1more, enum2more;

         for (; ; ) {
            // Iterate both enumerators, break if one reaches an end
            enum1more = enum1.MoveNext();
            enum2more = enum2.MoveNext();
            if (!enum1more || !enum2more) break;

            T e1 = enum1.Current;
            T e2 = enum2.Current;
            Debug.WriteLine(string.Format("Comparing: {0} <=> {1}", e1.ToString(), e2.ToString()));
            if (Comparer(e1, e2)) {
               string ErrorMsg = "Comparison failed: Element mismatch!";
               Debug.WriteLine(ErrorMsg);
               // Write out remainder of elements
               for (int i = 1; i <= 20 && enum1.MoveNext(); i++) {
                  Debug.WriteLine("Remaining actual elements: " + enum1.Current.ToString());
               }
               Assert.Fail(ErrorMsg);
            }
         }
         // If enum1 has more elements, list them
         if (enum1more) {
            string ErrorMsg = "Comparison failed: Remaining actual elements!";
            Debug.WriteLine(ErrorMsg);
            for (int i = 1; i <= 20; i++) {
               Debug.WriteLine(string.Format("Remaining actual element: {0}", enum1.Current.ToString()));
               if (!enum1.MoveNext()) break;
            } while (enum1.MoveNext()) ;
            Assert.Fail("Comparison failed: Remaining actual elements");
         }
         // If enum2 has more elements, list them
         if (enum2more) {
            string ErrorMsg = "Comparison failed: Remaining expected elements!";
            Debug.WriteLine(ErrorMsg);
            for (int i = 1; i <= 20; i++) {
               Debug.WriteLine(string.Format("Remaining expected element: {0}", enum2.Current.ToString()));
               if (!enum2.MoveNext()) break;
            } while (enum2.MoveNext()) ;
            Assert.Fail(ErrorMsg);
         }

         Debug.WriteLine("Comparison successful.");
      }

      /// <summary>
      /// Assert sequence equality according to IComparable.
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="ExpectedList"></param>
      /// <param name="ActualList"></param>
      public static void AssertCompare<T>(IEnumerable<T> ExpectedList, IEnumerable<T> ActualList) where T : class, IComparable<T> {
         AssertCompare(ActualList, ExpectedList, (a, b) => a.CompareTo(b));
      }

      /// <summary>
      /// Assert sequence equality according to Comparison delegate.
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="ExpectedList"></param>
      /// <param name="ActualList"></param>
      /// <param name="Comparer"></param>
      public static void AssertCompare<T>(IEnumerable<T> ExpectedList, IEnumerable<T> ActualList, Comparison<T> Comparer) {
         IEnumerator<T> enum1 = ActualList.GetEnumerator();
         IEnumerator<T> enum2 = ExpectedList.GetEnumerator();
         bool enum1more, enum2more;

         for (; ; ) {
            // Iterate both enumerators, break if one reaches an end
            enum1more = enum1.MoveNext();
            enum2more = enum2.MoveNext();
            if (!enum1more || !enum2more) break;

            T e1 = enum1.Current;
            T e2 = enum2.Current;
            Debug.WriteLine(string.Format("Comparing: {0} <=> {1}", e1.ToString(), e2.ToString()));
            if (Comparer(e1, e2) != 0) {
               string ErrorMsg = "Comparison failed: Element mismatch!";
               Debug.WriteLine(ErrorMsg);
               // Write out remainder of elements
               for (int i = 1; i <= 20 && enum1.MoveNext(); i++) {
                  Debug.WriteLine("Remaining actual elements: " + enum1.Current.ToString());
               }
               Assert.Fail(ErrorMsg);
            }
         }
         // If enum1 has more elements, list them
         if (enum1more) {
            string ErrorMsg = "Comparison failed: Remaining actual elements!";
            Debug.WriteLine(ErrorMsg);
            for (int i = 1; i <= 20; i++) {
               Debug.WriteLine(string.Format("Remaining actual element: {0}", enum1.Current.ToString()));
               if (!enum1.MoveNext()) break;
            } while (enum1.MoveNext()) ;
            Assert.Fail("Comparison failed: Remaining actual elements");
         }
         // If enum2 has more elements, list them
         if (enum2more) {
            string ErrorMsg = "Comparison failed: Remaining expected elements!";
            Debug.WriteLine(ErrorMsg);
            for (int i = 1; i <= 20; i++) {
               Debug.WriteLine(string.Format("Remaining expected element: {0}", enum2.Current.ToString()));
               if (!enum2.MoveNext()) break;
            } while (enum2.MoveNext());
            Assert.Fail(ErrorMsg);
         }

         Debug.WriteLine("Comparison successful.");
      }
   }
}
