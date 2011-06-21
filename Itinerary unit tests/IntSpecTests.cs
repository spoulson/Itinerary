using System;
using System.Diagnostics;
using Expl.Auxiliary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Expl.Itinerary.Test {
   /// <summary>
   /// TDL Parser validity unit tests
   /// </summary>
   [TestClass]
   public class IntSpecTests {
      [TestMethod]
      public void ParseTest() {
         var tests = new[] {
            new IntSpecUnitTest("Empty", "", new int[0]),
            new IntSpecUnitTest("Single element", "1", new[] { 1 }),
            new IntSpecUnitTest("Two elements", "1,2", new[] { 1, 2 }),
            new IntSpecUnitTest("Whitespace invalid 1", " 1 , 2 ", new int[0]),
            new IntSpecUnitTest("Whitespace invalid 2", "1 , 2 ", new int[0]),
            new IntSpecUnitTest("Whitespace invalid 3", "1, 2 ", new[] { 1 }),
            new IntSpecUnitTest("Trailing whitespace valid", "1,2 ", new[] { 1, 2 }),
            new IntSpecUnitTest("Wildcard", "*", 1, 10, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
            new IntSpecUnitTest("Wildcard step", "*/2", 1, 10, new[] { 1, 3, 5, 7, 9 }),
            new IntSpecUnitTest("Exlusion 1", "*,!1", 1, 10, new[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
            new IntSpecUnitTest("Exlusion 2", "*,!5", 1, 10, new[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 }),
            new IntSpecUnitTest("Exlusion 3", "*,!10", 1, 10, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }),
            new IntSpecUnitTest("Range 1", "1-5", new[] { 1, 2, 3, 4, 5 }),
            new IntSpecUnitTest("Range 2", "1-5", 1, 10, new[] { 1, 2, 3, 4, 5 }),
            new IntSpecUnitTest("Range with step", "1-9/2", new[] { 1, 3, 5, 7, 9 }),
            new IntSpecUnitTest("Exclude range", "*,!1-5", 1, 10, new[] { 6, 7, 8, 9, 10}),
            new IntSpecUnitTest("Exclude stepped range", "*,!1-5/2", 1, 10, new[] { 2, 4, 6, 7, 8, 9, 10 }),
            new IntSpecUnitTest("Reinclude excluded range", "*,!1-5,1-5", 1, 10, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
            new IntSpecUnitTest("Complex combination", "*,!1,!5-18,6,8-9,10-14/2", 1, 20, new[] { 2, 3, 4, 6, 8, 9, 10, 12, 14, 19, 20 }),
            new IntSpecUnitTest("Redundancy ignored", "*,1-10,1,2,3,4,5,6,7,8,9,10", 1, 10, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
            new IntSpecUnitTest("Out of range spec ignored", "20,25-30,!40,50-60/2", 1, 10, new int[0]),
            new IntSpecUnitTest("Empty list elements ignored", "1,2,,,,3,,", new[] { 1, 2, 3 })
         };

         foreach (var t in tests) t.Run();
      }

      public class IntSpecUnitTest {
         public IntSpecUnitTest(string Name, string Spec, IEnumerable<int> Expected) {
            this.Name = Name;
            this.Spec = Spec;
            this.RangeStart = null;
            this.RangeEnd = null;
            this.Expected = Expected;
         }

         public IntSpecUnitTest(string Name, string Spec, int RangeStart, int RangeEnd, IEnumerable<int> Expected) {
            this.Name = Name;
            this.Spec = Spec;
            this.RangeStart = RangeStart;
            this.RangeEnd = RangeEnd;
            this.Expected = Expected;
         }

         public string Name { get; private set; }
         public string Spec { get; private set; }
         public int? RangeStart { get; private set; }
         public int? RangeEnd { get; private set; }
         public IEnumerable<int> Expected { get; private set; }

         public void Run() {
            Debug.WriteLine("Unit test: " + Name);
            Debug.WriteLine("IntSpec expression: " + Spec);

            var specActual = RangeStart.HasValue && RangeEnd.HasValue ?
               IntSpec.Parse(Spec, RangeStart.Value, RangeEnd.Value) :
               IntSpec.Parse(Spec);
            SequenceComparer.AssertCompare(Expected, specActual, (a, b) => a.CompareTo(b));

            // Success, exact match
         }
      }
   }
}
