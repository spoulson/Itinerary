using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Expl.Itinerary.Test {
   /// <summary>
   /// Summary description for TimedEventTests
   /// </summary>
   [TestClass]
   public class TimedEventTests {
      [TestMethod]
      public void IntersectionTest() {
         TimedEventUnitTest[] tests = {
            new TimedEventUnitTest("Test partial intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => new[] {
                  e.Intersection(new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)))
               },
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromMinutes(30))
               }
            ),
            new TimedEventUnitTest("Test partial intersection (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => new[] {
                  e & new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))
               },
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromMinutes(30))
               }
            ),
            new TimedEventUnitTest("Test partial intersection, reversed",  
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => new[] {
                  e.Intersection(new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)))
               },
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromMinutes(30))
               }
            ),
            new TimedEventUnitTest("Test partial intersection, reversed (using operator)",  
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => new[] {
                  e & new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))
               },
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromMinutes(30))
               }
            ),
            new TimedEventUnitTest("Test no intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
               e => new[] {
                  e.Intersection(new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)))
               },
               new TimedEvent[0]
            ),
            new TimedEventUnitTest("Test no intersection (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
               e => new[] {
                  e & new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))
               },
               new TimedEvent[0]
            ),
            new TimedEventUnitTest("Test no intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => new[] {
                  e.Intersection(new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)))
               },
               new TimedEvent[0]
            ),
            new TimedEventUnitTest("Test no intersection, reversed (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => new[] {
                  e & new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1))
               },
               new TimedEvent[0]
            ),
            new TimedEventUnitTest("Test complete intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => new[] {
                  e.Intersection(new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)))
               },
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))
               }
            ),
            new TimedEventUnitTest("Test complete intersection (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => new[] {
                  e & new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))
               },
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))
               }
            ),
            new TimedEventUnitTest("Test contained intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)),
               e => new[] {
                  e.Intersection(new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3)))
               },
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3))
               }
            ),
            new TimedEventUnitTest("Test contained intersection (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)),
               e => new[] {
                  e & new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3))
               },
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3))
               }
            ),
            new TimedEventUnitTest("Test contained intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3)),
               e => new[] {
                  e.Intersection(new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)))
               },
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3))
               }
            ),
            new TimedEventUnitTest("Test contained intersection, reversed (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3)),
               e => new[] {
                  e & new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1))
               },
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void DifferenceTest() {
         TimedEventUnitTest[] tests = {
            new TimedEventUnitTest("Test partial intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => e.Difference(new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromMinutes(30)),
                  new TimedEvent(new DateTime(2008, 1, 31, 8, 0, 0), TimeSpan.FromMinutes(30))
               }
            ),
            new TimedEventUnitTest("Test partial intersection (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => e ^ new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromMinutes(30)),
                  new TimedEvent(new DateTime(2008, 1, 31, 8, 0, 0), TimeSpan.FromMinutes(30))
               }
            ),
            new TimedEventUnitTest("Test partial intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e.Difference(new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromMinutes(30)),
                  new TimedEvent(new DateTime(2008, 1, 31, 8, 0, 0), TimeSpan.FromMinutes(30))
               }
            ),
            new TimedEventUnitTest("Test partial intersection, reversed (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e ^ new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromMinutes(30)),
                  new TimedEvent(new DateTime(2008, 1, 31, 8, 0, 0), TimeSpan.FromMinutes(30))
               }
            ),
            new TimedEventUnitTest("Test no intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
               e => e.Difference(new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))
               }
            ),
            new TimedEventUnitTest("Test no intersection (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
               e => e ^ new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))
               }
            ),
            new TimedEventUnitTest("Test no intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e.Difference(new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))
               }
            ),
            new TimedEventUnitTest("Test no intersection, reversed (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e ^ new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))
               }
            ),
            new TimedEventUnitTest("Test complete intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => e.Difference(new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))),
               new TimedEvent[0]
            ),
            new TimedEventUnitTest("Test complete intersection (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => e ^ new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               new TimedEvent[0]
            ),
            new TimedEventUnitTest("Test contained intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)),
               e => e.Difference(new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(10, 45, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 13, 45, 0), new TimeSpan(10, 15, 0))
               }
            ),
            new TimedEventUnitTest("Test contained intersection (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)),
               e => e ^ new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(10, 45, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 13, 45, 0), new TimeSpan(10, 15, 0))
               }
            ),
            new TimedEventUnitTest("Test contained intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3)),
               e => e.Difference(new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(10, 45, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 13, 45, 0), new TimeSpan(10, 15, 0))
               }
            ),
            new TimedEventUnitTest("Test contained intersection, reversed (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3)),
               e => e ^ new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), new TimeSpan(10, 45, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 13, 45, 0), new TimeSpan(10, 15, 0))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void UnionTest() {
         TimedEventUnitTest[] tests = {
            new TimedEventUnitTest("Test partial intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => e.Union(new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 30, 0))
               }
            ),
            new TimedEventUnitTest("Test partial intersection (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => e | new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 30, 0))
               }
            ),
            new TimedEventUnitTest("Test partial intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e.Union(new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 30, 0))
               }
            ),
            new TimedEventUnitTest("Test partial intersection, reversed (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e | new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), new TimeSpan(1, 30, 0))
               }
            ),
            new TimedEventUnitTest("Test no intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
               e => e.Union(new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))
               }
            ),
            new TimedEventUnitTest("Test no intersection (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
               e => e | new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))
               }
            ),
            new TimedEventUnitTest("Test no intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e.Union(new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))
               }
            ),
            new TimedEventUnitTest("Test no intersection, reversed (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e | new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))
               }
            ),
            new TimedEventUnitTest("Test complete intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => e.Union(new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))
               }
            ),
            new TimedEventUnitTest("Test complete intersection (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => e | new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))
               }
            ),
            new TimedEventUnitTest("Test contained intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)),
               e => e.Union(new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1))
               }
            ),
            new TimedEventUnitTest("Test contained intersection (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)),
               e => e | new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1))
               }
            ),
            new TimedEventUnitTest("Test contained intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3)),
               e => e.Union(new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1))),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1))
               }
            ),
            new TimedEventUnitTest("Test contained intersection, reversed (using operator)",
               new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3)),
               e => e | new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)),
               new[] {
                  new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1))
               }
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void BoolIntersectionTest() {
         TimedEventBooleanUnitTest[] tests = {
            new TimedEventBooleanUnitTest("Test partial intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => e.Intersects(new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))),
               true
            ),
            new TimedEventBooleanUnitTest("Test partial intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e.Intersects(new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))),
               true
            ),
            new TimedEventBooleanUnitTest("Test no intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)),
               e => e.Intersects(new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test no intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e.Intersects(new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test complete intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => e.Intersects(new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))),
               true
            ),
            new TimedEventBooleanUnitTest("Test contained intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)),
               e => e.Intersects(new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3))),
               true
            ),
            new TimedEventBooleanUnitTest("Test contained intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3)),
               e => e.Intersects(new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1))),
               true
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void ComparisonTest() {
         TimedEventBooleanUnitTest[] tests = {
            // Equality.
            new TimedEventBooleanUnitTest("Test equality",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Equals(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))),
               true
            ),
            new TimedEventBooleanUnitTest("Test equality (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e == new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               true
            ),
            new TimedEventBooleanUnitTest("Test equality (using operator 2)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e != new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               false
            ),
            new TimedEventBooleanUnitTest("Test inequality, different start time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Equals(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 1), TimeSpan.FromHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test inequality, different start time (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e == new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 1), TimeSpan.FromHours(1)),
               false
            ),
            new TimedEventBooleanUnitTest("Test inequality, different start time (using operator 2)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e != new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 1), TimeSpan.FromHours(1)),
               true
            ),
            new TimedEventBooleanUnitTest("Test inequality, different start date",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Equals(new TimedEvent(new DateTime(2011, 4, 1, 7, 27, 1), TimeSpan.FromHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test inequality, different start date (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e == new TimedEvent(new DateTime(2011, 4, 1, 7, 27, 1), TimeSpan.FromHours(1)),
               false
            ),
            new TimedEventBooleanUnitTest("Test inequality, different start date (using operator 2)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e != new TimedEvent(new DateTime(2011, 4, 1, 7, 27, 1), TimeSpan.FromHours(1)),
               true
            ),
            new TimedEventBooleanUnitTest("Test inequality, different duration",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Equals(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromMinutes(5))),
               false
            ),
            new TimedEventBooleanUnitTest("Test inequality, different duration (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e == new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 1), TimeSpan.FromMinutes(5)),
               false
            ),
            new TimedEventBooleanUnitTest("Test inequality, different duration (using operator 2)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e != new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 1), TimeSpan.FromMinutes(5)),
               true
            ),
            // Greater than.
            new TimedEventBooleanUnitTest("Test greater than, different start time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))) > 0,
               true
            ),
            new TimedEventBooleanUnitTest("Test greater than, different start time (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e > new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               true
            ),
            new TimedEventBooleanUnitTest("Test greater than, equal events",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))) > 0,
               false
            ),
            new TimedEventBooleanUnitTest("Test greater than, equal events (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e > new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               false
            ),
            new TimedEventBooleanUnitTest("Test greater than, reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1))) > 0,
               false
            ),
            new TimedEventBooleanUnitTest("Test greater than, reversed (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e > new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               false
            ),
            // Greater than or equal to.
            new TimedEventBooleanUnitTest("Test greater than or equal to, different start time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))) >= 0,
               true
            ),
            new TimedEventBooleanUnitTest("Test greater than or equal to, different start time (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e >= new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               true
            ),
            new TimedEventBooleanUnitTest("Test greater than or equal to, equal events",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))) >= 0,
               true
            ),
            new TimedEventBooleanUnitTest("Test greater than or equal to, equal events (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e >= new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               true
            ),
            new TimedEventBooleanUnitTest("Test greater than or equal to, reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1))) >= 0,
               false
            ),
            new TimedEventBooleanUnitTest("Test greater than or equal to, reversed (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e >= new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               false
            ),
            // Less than.
            new TimedEventBooleanUnitTest("Test less than, different start time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1))) < 0,
               true
            ),
            new TimedEventBooleanUnitTest("Test less than, different start time (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e < new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               true
            ),
            new TimedEventBooleanUnitTest("Test less than, equal events",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))) > 0,
               false
            ),
            new TimedEventBooleanUnitTest("Test less than, equal events (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e > new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               false
            ),
            new TimedEventBooleanUnitTest("Test less than, reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))) < 0,
               false
            ),
            new TimedEventBooleanUnitTest("Test less than, reversed (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e < new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               false
            ),
            // Less than or equal to.
            new TimedEventBooleanUnitTest("Test less than or equal to, different start time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1))) <= 0,
               true
            ),
            new TimedEventBooleanUnitTest("Test less than or equal to, different start time (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e <= new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               true
            ),
            new TimedEventBooleanUnitTest("Test less than or equal to, equal events",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))) <= 0,
               true
            ),
            new TimedEventBooleanUnitTest("Test less than or equal to, equal events (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e <= new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               true
            ),
            new TimedEventBooleanUnitTest("Test less than or equal to, reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))) <= 0,
               false
            ),
            new TimedEventBooleanUnitTest("Test less than or equal to, reversed (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e <= new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               false
            )
         };

         foreach (var t in tests) t.Run();
      }

      // TODO: Coverage required for: Contains, AdjacentTo, Negate

      public class TimedEventUnitTest {
         private string _Name;
         private TimedEvent _Event;
         private Func<TimedEvent, IEnumerable<TimedEvent>> _TimedEventFunc;
         private IEnumerable<TimedEvent> _ExpectedEvents;

         public TimedEventUnitTest(string Name, TimedEvent Event, Func<TimedEvent, IEnumerable<TimedEvent>> TimedEventFunc, IEnumerable<TimedEvent> ExpectedEvents) {
            _Name = Name;
            _Event = Event;
            _TimedEventFunc = TimedEventFunc;
            _ExpectedEvents = ExpectedEvents;
         }

         public string Name { get { return _Name; } }

         public void Run() {
            Debug.WriteLine("Unit test: " + this._Name);
            SequenceComparer.AssertCompare(
               _TimedEventFunc(_Event).Where(x => x != null),
               _ExpectedEvents, 
               (a, b) => a.CompareTo(b));

            // Success, exact match
         }
      }

      public class TimedEventBooleanUnitTest {
         private string _Name;
         private TimedEvent _Event;
         private Func<TimedEvent, bool> _TimedEventFunc;
         private bool _ExpectedResult;

         public TimedEventBooleanUnitTest(string Name, TimedEvent Event, Func<TimedEvent, bool> TimedEventFunc, bool ExpectedResult) {
            _Name = Name;
            _Event = Event;
            _TimedEventFunc = TimedEventFunc;
            _ExpectedResult = ExpectedResult;
         }

         public string Name { get { return _Name; } }

         public void Run() {
            Debug.WriteLine("Unit test: " + this._Name);
            Assert.AreEqual(_ExpectedResult, _TimedEventFunc(_Event));
            
            // Success.
         }
      }
}
}
