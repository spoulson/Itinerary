using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Collections;

namespace Expl.Itinerary.Test {
   [TestClass]
   public class TimedEventTests {
      [TestMethod]
      public void IntersectionTest() {
         var tests = new[] {
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
         var tests = new[] {
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
         var tests = new[] {
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
         var tests = new[] {
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
         var tests = new[] {
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
            new TimedEventBooleanUnitTest("Test greater than, different duration",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5))) > 0,
               true
            ),
            new TimedEventBooleanUnitTest("Test greater than, different duration (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e > new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5)),
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
            new TimedEventBooleanUnitTest("Test greater than, different duration reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1))) > 0,
               false
            ),
            new TimedEventBooleanUnitTest("Test greater than, different duration reversed (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5)),
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
            new TimedEventBooleanUnitTest("Test greater than or equal to, different duration",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5))) >= 0,
               true
            ),
            new TimedEventBooleanUnitTest("Test greater than or equal to, different duration (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e >= new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5)),
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
            new TimedEventBooleanUnitTest("Test greater than or equal to, different duration reversed ",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1))) >= 0,
               false
            ),
            new TimedEventBooleanUnitTest("Test greater than or equal to, different duration reversed (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5)),
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
            new TimedEventBooleanUnitTest("Test less than, different duration",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1))) < 0,
               true
            ),
            new TimedEventBooleanUnitTest("Test less than, different duration (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5)),
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
            new TimedEventBooleanUnitTest("Test less than, different duration reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5))) < 0,
               false
            ),
            new TimedEventBooleanUnitTest("Test less than, different duration reversed (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e < new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5)),
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
            new TimedEventBooleanUnitTest("Test less than or equal to, different duration",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1))) <= 0,
               true
            ),
            new TimedEventBooleanUnitTest("Test less than or equal to, different duration (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5)),
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
            ),
            new TimedEventBooleanUnitTest("Test less than or equal to, different duration reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e.CompareTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5))) <= 0,
               false
            ),
            new TimedEventBooleanUnitTest("Test less than or equal to, different duration reversed (using operator)",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromHours(1)),
               e => e <= new TimedEvent(new DateTime(2011, 6, 16, 7, 34, 0), TimeSpan.FromMinutes(5)),
               false
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void ContainsTest() {
         var tests = new[] {
            new TimedEventBooleanUnitTest("Test equality",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Contains(new TimedEvent(e.StartTime, e.EndTime)),
               true
            ),
            new TimedEventBooleanUnitTest("Test A contains smaller B",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Contains(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 30), TimeSpan.FromMinutes(10))),
               true
            ),
            new TimedEventBooleanUnitTest("Test A contains smaller B, reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 30), TimeSpan.FromMinutes(10)),
               e => e.Contains(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A contains smaller B, same start time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Contains(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromMinutes(10))),
               true
            ),
            new TimedEventBooleanUnitTest("Test A contains smaller B, same start time reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromMinutes(10)),
               e => e.Contains(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A contains smaller B, same end time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Contains(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 50), TimeSpan.FromMinutes(10))),
               true
            ),
            new TimedEventBooleanUnitTest("Test A contains smaller B, same end time reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 50), TimeSpan.FromMinutes(10)),
               e => e.Contains(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A partially contains B, B having later end time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Contains(new TimedEvent(e.StartTime.AddMinutes(30), e.EndTime.AddHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A partially contains B, B having same start time but later end time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Contains(new TimedEvent(e.StartTime, e.EndTime.AddHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A partially contains B, B having earlier start time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Contains(new TimedEvent(e.StartTime.AddHours(-1), e.EndTime.AddMinutes(-30))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A partially contains B, B having same end time but earlier start time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Contains(new TimedEvent(e.StartTime.AddHours(-1), e.EndTime)),
               false
            ),
            new TimedEventBooleanUnitTest("Test adjacent left",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Contains(new TimedEvent(e.StartTime.AddHours(-1), e.StartTime)),
               false
            ),
            new TimedEventBooleanUnitTest("Test adjacent right",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.Contains(new TimedEvent(e.EndTime, e.EndTime.AddHours(1))),
               false
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void IsAdjacentToTest() {
         var tests = new[] {
            new TimedEventBooleanUnitTest("Test equality",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.IsAdjacentTo(new TimedEvent(e.StartTime, e.EndTime)),
               false
            ),
            new TimedEventBooleanUnitTest("Test adjacent left",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.IsAdjacentTo(new TimedEvent(e.StartTime.AddHours(-1), e.StartTime)),
               true
            ),
            new TimedEventBooleanUnitTest("Test adjacent right",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.IsAdjacentTo(new TimedEvent(e.EndTime, e.EndTime.AddHours(1))),
               true
            ),
            new TimedEventBooleanUnitTest("Test A contains smaller B",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.IsAdjacentTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 30), TimeSpan.FromMinutes(10))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A contains smaller B, reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 30), TimeSpan.FromMinutes(10)),
               e => e.IsAdjacentTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A contains smaller B, same start time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.IsAdjacentTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromMinutes(10))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A contains smaller B, same start time reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromMinutes(10)),
               e => e.IsAdjacentTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A contains smaller B, same end time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.IsAdjacentTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 50), TimeSpan.FromMinutes(10))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A contains smaller B, same end time reversed",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 50), TimeSpan.FromMinutes(10)),
               e => e.IsAdjacentTo(new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A partially contains B, B having later end time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.IsAdjacentTo(new TimedEvent(e.StartTime.AddMinutes(30), e.EndTime.AddHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A partially contains B, B having same start time but later end time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.IsAdjacentTo(new TimedEvent(e.StartTime, e.EndTime.AddHours(1))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A partially contains B, B having earlier start time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.IsAdjacentTo(new TimedEvent(e.StartTime.AddHours(-1), e.EndTime.AddMinutes(-30))),
               false
            ),
            new TimedEventBooleanUnitTest("Test A partially contains B, B having same end time but earlier start time",
               new TimedEvent(new DateTime(2011, 6, 16, 7, 27, 0), TimeSpan.FromHours(1)),
               e => e.IsAdjacentTo(new TimedEvent(e.StartTime.AddHours(-1), e.EndTime)),
               false
            )
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void NegateTest() {
         var tests = new[] {
            new TimedEventUnitTest("Test negate",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)),
               e => e.Negate(),
               new[] {
                  new TimedEvent(DateTime.MinValue, new DateTime(2008, 1, 31, 7, 0, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 8, 0, 0), DateTime.MaxValue)
               }
            ),
            new TimedEventUnitTest("Test negate, no duration",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.Zero),
               e => e.Negate(),
               new[] {
                  new TimedEvent(DateTime.MinValue, new DateTime(2008, 1, 31, 7, 0, 0)),
                  new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), DateTime.MaxValue)
               }
            ),
            new TimedEventUnitTest("Test negate DateTime.MinValue",
               new TimedEvent(DateTime.MinValue, TimeSpan.FromHours(1)),
               e => e.Negate(),
               new[] {
                  new TimedEvent(DateTime.MinValue.AddHours(1), DateTime.MaxValue)
               }
            ),
            new TimedEventUnitTest("Test negate DateTime.MinValue, no duration",
               new TimedEvent(DateTime.MinValue, TimeSpan.Zero),
               e => e.Negate(),
               new[] {
                  new TimedEvent(DateTime.MinValue, DateTime.MaxValue)
               }
            ),
            new TimedEventUnitTest("Test negate DateTime.MaxValue",
               new TimedEvent(DateTime.MaxValue.AddHours(-1), TimeSpan.FromHours(1)),
               e => e.Negate(),
               new[] {
                  new TimedEvent(DateTime.MinValue, DateTime.MaxValue.AddHours(-1))
               }
            ),
            new TimedEventUnitTest("Test negate DateTime.MaxValue, no duration",
               new TimedEvent(DateTime.MaxValue, TimeSpan.Zero),
               e => e.Negate(),
               new[] {
                  new TimedEvent(DateTime.MinValue, DateTime.MaxValue)
               }
            ),
         };

         foreach (var t in tests) t.Run();
      }

      [TestMethod]
      public void GetEventDatesTest() {
         var tests = new[] {
            new TimedEventDateUnitTest("Test single day, no duration.",
               new TimedEvent(new DateTime(2011, 6, 30, 0, 0, 0), TimeSpan.Zero),
               e => e.GetEventDates(),
               new[] {
                  new DateTime(2011, 6, 30, 0, 0, 0)
               }
            ),
            new TimedEventDateUnitTest("Test single day, short duration.",
               new TimedEvent(new DateTime(2011, 6, 30, 0, 0, 0), TimeSpan.FromHours(1)),
               e => e.GetEventDates(),
               new[] {
                  new DateTime(2011, 6, 30, 0, 0, 0)
               }
            ),
            new TimedEventDateUnitTest("Test single day, full day duration.",
               new TimedEvent(new DateTime(2011, 6, 30, 0, 0, 0), TimeSpan.FromDays(1)),
               e => e.GetEventDates(),
               new[] {
                  new DateTime(2011, 6, 30, 0, 0, 0)
               }
            ),
            new TimedEventDateUnitTest("Test single day, more than a full day duration.",
               new TimedEvent(new DateTime(2011, 6, 30, 0, 0, 0), TimeSpan.FromHours(25)),
               e => e.GetEventDates(),
               new[] {
                  new DateTime(2011, 6, 30, 0, 0, 0),
                  new DateTime(2011, 7, 1, 0, 0, 0)
               }
            ),
            new TimedEventDateUnitTest("Test two full days.",
               new TimedEvent(new DateTime(2011, 6, 30, 0, 0, 0), TimeSpan.FromDays(2)),
               e => e.GetEventDates(),
               new[] {
                  new DateTime(2011, 6, 30, 0, 0, 0),
                  new DateTime(2011, 7, 1, 0, 0, 0)
               }
            ),
            new TimedEventDateUnitTest("Test short duration over day boundary.",
               new TimedEvent(new DateTime(2011, 6, 30, 23, 0, 0), TimeSpan.FromHours(2)),
               e => e.GetEventDates(),
               new[] {
                  new DateTime(2011, 6, 30, 0, 0, 0),
                  new DateTime(2011, 7, 1, 0, 0, 0)
               }
            ),
            new TimedEventDateUnitTest("Test 10 days.",
               new TimedEvent(new DateTime(2011, 6, 30, 0, 0, 0), TimeSpan.FromDays(10)),
               e => e.GetEventDates(),
               new[] {
                  new DateTime(2011, 6, 30, 0, 0, 0),
                  new DateTime(2011, 7, 1, 0, 0, 0),
                  new DateTime(2011, 7, 2, 0, 0, 0),
                  new DateTime(2011, 7, 3, 0, 0, 0),
                  new DateTime(2011, 7, 4, 0, 0, 0),
                  new DateTime(2011, 7, 5, 0, 0, 0),
                  new DateTime(2011, 7, 6, 0, 0, 0),
                  new DateTime(2011, 7, 7, 0, 0, 0),
                  new DateTime(2011, 7, 8, 0, 0, 0),
                  new DateTime(2011, 7, 9, 0, 0, 0)
               }
            )

         };

         foreach (var t in tests) t.Run();
      }

      private class TimedEventUnitTest {
         public TimedEventUnitTest(string Name, TimedEvent Event, Func<TimedEvent, IEnumerable<TimedEvent>> TimedEventFunc, IEnumerable<TimedEvent> ExpectedEvents) {
            this.Name = Name;
            this.Event = Event;
            this.TimedEventFunc = TimedEventFunc;
            this.ExpectedEvents = ExpectedEvents;
         }

         public string Name { get; private set; }
         public TimedEvent Event { get; private set; }
         public Func<TimedEvent, IEnumerable<TimedEvent>> TimedEventFunc { get; private set; }
         public IEnumerable<TimedEvent> ExpectedEvents { get; private set; }

         public void Run() {
            Debug.WriteLine("Unit test: " + Name);
            SequenceComparer.AssertCompare(
               ExpectedEvents, 
               TimedEventFunc(Event).Where(x => x != null),
               (a, b) => a.CompareTo(b));

            // Success, exact match
         }
      }

      private class TimedEventBooleanUnitTest {
         public TimedEventBooleanUnitTest(string Name, TimedEvent Event, Func<TimedEvent, bool> TimedEventFunc, bool ExpectedResult) {
            this.Name = Name;
            this.Event = Event;
            this.TimedEventFunc = TimedEventFunc;
            this.ExpectedResult = ExpectedResult;
         }

         public string Name { get; private set; }
         public TimedEvent Event { get; private set; }
         public Func<TimedEvent, bool> TimedEventFunc { get; private set; }
         public bool ExpectedResult { get; private set; }

         public void Run() {
            Debug.WriteLine("Unit test: " + Name);
            Assert.AreEqual(ExpectedResult, TimedEventFunc(Event));
            
            // Success.
         }
      }

      private class TimedEventDateUnitTest {
         public TimedEventDateUnitTest(string Name, TimedEvent Event, Func<TimedEvent, IEnumerable<DateTime>> TimedEventFunc, IEnumerable<DateTime> ExpectedDates) {
            this.Name = Name;
            this.Event = Event;
            this.TimedEventFunc = TimedEventFunc;
            this.ExpectedDates = ExpectedDates;
         }

         public string Name { get; private set; }
         public TimedEvent Event { get; private set; }
         public Func<TimedEvent, IEnumerable<DateTime>> TimedEventFunc { get; private set; }
         public IEnumerable<DateTime> ExpectedDates { get; private set; }

         public void Run() {
            Debug.WriteLine("Unit test: " + Name);
            SequenceComparer.AssertCompare(
               ExpectedDates,
               TimedEventFunc(Event),
               (a, b) => a.CompareTo(b));

            // Success, exact match
         }
      }
   }
}
