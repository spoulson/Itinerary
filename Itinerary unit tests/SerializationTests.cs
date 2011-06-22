using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expl.Itinerary.Test {
   /// <summary>
   /// Verify that all schedule types can be binary serialized and deserialized.
   /// </summary>
   [TestClass]
   public class SerializationTests {
      [TestMethod]
      public void TestSerialization() {
         var SerializeScheduleTests = new[] {
            // Primitives.
            new SerializationUnitTest("VoidSchedule", new VoidSchedule()),
            new SerializationUnitTest("OneTimeSchedule", new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromDays(1))),
            new SerializationUnitTest("IntervalSchedule", new IntervalSchedule(TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(1), DateTime.MinValue)),
            new SerializationUnitTest("CronSchedule 1", new CronSchedule("*", "*", "*", "*", "*", TimeSpan.FromHours(1))),
            new SerializationUnitTest("CronSchedule 2", new CronSchedule("1,2,3", "4,5,6", "7,8,9", "10,11,12", "0,1,2", TimeSpan.Zero)),
            // Filters.
            new SerializationUnitTest("IndexSchedule", new IndexSchedule("1-5", new IntervalSchedule(TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(1), DateTime.MinValue))),
            new SerializationUnitTest("LastingSchedule", new LastingSchedule(TimeSpan.FromHours(1), new OneTimeSchedule(new DateTime(2011, 6, 21), new DateTime(2011, 6, 22)))),
            new SerializationUnitTest("OffsetSchedule", new OffsetSchedule(TimeSpan.FromHours(1), new IntervalSchedule(TimeSpan.FromDays(1), TimeSpan.FromDays(1), DateTime.MinValue))),
            new SerializationUnitTest("RepeatSchedule", new RepeatSchedule(5, new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromHours(1)))),
            // Composites.
            new SerializationUnitTest("BoolIntersectionSchedule", new BoolIntersectionSchedule(
               new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromDays(1)),
               new OneTimeSchedule(new DateTime(2011, 6, 1), TimeSpan.FromDays(30)))),
            new SerializationUnitTest("BoolNonIntersectionSchedule", new BoolNonIntersectionSchedule(
               new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromDays(1)),
               new OneTimeSchedule(new DateTime(2011, 6, 1), TimeSpan.FromDays(30)))),
            new SerializationUnitTest("DifferenceSchedule 1", new DifferenceSchedule(
               new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromDays(1)),
               new OneTimeSchedule(new DateTime(2011, 6, 1), TimeSpan.FromDays(30)))),
            new SerializationUnitTest("DifferenceSchedule 2", new DifferenceSchedule(new [] {
               new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromDays(1)),
               new OneTimeSchedule(new DateTime(2011, 6, 1), TimeSpan.FromDays(30)),
               new OneTimeSchedule(new DateTime(2011, 7, 1), TimeSpan.FromDays(31))
            })),
            new SerializationUnitTest("IntersectionSchedule 1", new IntersectionSchedule(
               new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromDays(1)),
               new OneTimeSchedule(new DateTime(2011, 6, 1), TimeSpan.FromDays(30)))),
            new SerializationUnitTest("IntersectionSchedule 2", new IntersectionSchedule(new [] {
               new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromDays(1)),
               new OneTimeSchedule(new DateTime(2011, 6, 1), TimeSpan.FromDays(30)),
               new OneTimeSchedule(new DateTime(2011, 7, 1), TimeSpan.FromDays(31))
            })),
            new SerializationUnitTest("ListSchedule 1", new ListSchedule(
               new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromDays(1)),
               new OneTimeSchedule(new DateTime(2011, 6, 1), TimeSpan.FromDays(30)))),
            new SerializationUnitTest("ListSchedule 2", new ListSchedule(new [] {
               new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromDays(1)),
               new OneTimeSchedule(new DateTime(2011, 6, 1), TimeSpan.FromDays(30)),
               new OneTimeSchedule(new DateTime(2011, 7, 1), TimeSpan.FromDays(31)),
            })),
            new SerializationUnitTest("SubtractSchedule", new SubtractSchedule(
               new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromDays(1)),
               new OneTimeSchedule(new DateTime(2011, 6, 1), TimeSpan.FromDays(30)))),
            new SerializationUnitTest("UnionSchedule 1", new UnionSchedule(
               new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromDays(1)),
               new OneTimeSchedule(new DateTime(2011, 6, 1), TimeSpan.FromDays(30)))),
            new SerializationUnitTest("UnionSchedule 2", new UnionSchedule(new [] {
               new OneTimeSchedule(new DateTime(2011, 6, 21), TimeSpan.FromDays(1)),
               new OneTimeSchedule(new DateTime(2011, 6, 1), TimeSpan.FromDays(30)),
               new OneTimeSchedule(new DateTime(2011, 7, 1), TimeSpan.FromDays(31))
            }))
         };

         foreach (var t in SerializeScheduleTests) t.Run();
      }

      private class SerializationUnitTest {
         public SerializationUnitTest(string Name, ISchedule Schedule) {
            this.Name = Name;
            this.Schedule = Schedule;
         }

         public string Name { get; private set; }
         public ISchedule Schedule { get; private set; }

         public void Run() {
            Debug.WriteLine("Unit test: " + Name);
            Debug.WriteLine("Schedule expression: " + Schedule.ToString());

            var formatter = new BinaryFormatter();

            using (var serializedStream = new MemoryStream()) {
               // Serialize.
               formatter.Serialize(serializedStream, Schedule);
               var serialized = serializedStream.ToArray();
               Assert.IsTrue(serialized.Length > 0);
               Debug.WriteLine("Serialized bytes: {0:d}", serialized.Length);

               // Deserialize back to ISchedule.
               using (var deserializingStream = new MemoryStream(serialized)) {
                  var deserializedSched = formatter.Deserialize(deserializingStream) as ISchedule;

                  // Check that types match.
                  Assert.IsInstanceOfType(deserializedSched, Schedule.GetType());

                  // Check that hashcodes match.
                  Assert.AreEqual(Schedule.GetHashCode(), deserializedSched.GetHashCode());

                  deserializingStream.Close();
               }

               serializedStream.Close();
            }
         }
      }
   }
}
