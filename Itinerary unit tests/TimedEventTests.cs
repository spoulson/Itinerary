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
            new TimedEventUnitTest("Test partial intersection, reversed",  
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => new[] {
                  e.Intersection(new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1)))
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
            new TimedEventUnitTest("Test no intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => new[] {
                  e.Intersection(new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1)))
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
            new TimedEventUnitTest("Test contained intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)),
               e => new[] {
                  e.Intersection(new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3)))
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
            new TimedEventUnitTest("Test partial intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e.Difference(new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))),
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
            new TimedEventUnitTest("Test no intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e.Difference(new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1))),
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
            new TimedEventUnitTest("Test contained intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)),
               e => e.Difference(new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3))),
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
            new TimedEventUnitTest("Test partial intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e.Union(new TimedEvent(new DateTime(2008, 1, 31, 7, 0, 0), TimeSpan.FromHours(1))),
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
            new TimedEventUnitTest("Test no intersection, reversed",
               new TimedEvent(new DateTime(2008, 1, 31, 7, 30, 0), TimeSpan.FromHours(1)),
               e => e.Union(new TimedEvent(new DateTime(2008, 1, 31, 4, 0, 0), TimeSpan.FromHours(1))),
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
            new TimedEventUnitTest("Test contained intersection",
               new TimedEvent(new DateTime(2008, 1, 31, 0, 0, 0), TimeSpan.FromDays(1)),
               e => e.Union(new TimedEvent(new DateTime(2008, 1, 31, 10, 45, 0), TimeSpan.FromHours(3))),
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

      // TODO: Coverage required for: all operators, Contains, AdjacentTo, Negate

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
