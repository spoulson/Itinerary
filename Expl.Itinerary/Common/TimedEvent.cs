using System;
using System.Collections.Generic;

namespace Expl.Itinerary {
   /// <summary>
   /// Class encapsulating a timed event.
   /// </summary>
   [Serializable]
   public class TimedEvent : IComparable<TimedEvent> {
      protected DateTime _StartTime;
      protected DateTime _EndTime;

      /// <summary>
      /// Constructor.
      /// </summary>
      /// <param name="StartTime">Event start time.</param>
      /// <param name="EndTime">Event end time.</param>
      public TimedEvent(DateTime StartTime, DateTime EndTime) {
         _StartTime = StartTime;
         _EndTime = EndTime;
      }

      /// <summary>
      /// Constructor.
      /// </summary>
      /// <param name="StartTime">Event start time.</param>
      /// <param name="Duration">Event duration.</param>
      public TimedEvent(DateTime StartTime, TimeSpan Duration) {
         _StartTime = StartTime;
         _EndTime = _StartTime + Duration;
      }

      public override int GetHashCode() {
         return
            _StartTime.GetHashCode() +
            _EndTime.GetHashCode();
      }

      /// <summary>
      /// Get event start time.  Time is range inclusive.
      /// </summary>
      public DateTime StartTime {
         get { return _StartTime; }
      }

      /// <summary>
      /// Get event end time.  Time is range exclusive.
      /// </summary>
      public DateTime EndTime {
         get { return _EndTime; }
      }

      /// <summary>
      /// Get event duration.
      /// </summary>
      public TimeSpan Duration {
         get { return _EndTime - _StartTime; }
      }

      /// <summary>
      /// Convert to TDL string.
      /// </summary>
      /// <returns>String value.</returns>
      public override string ToString() {
         return string.Format("{0} T{1}", ItineraryConvert.ToString(_StartTime), Duration.ToString());
      }

      #region Comparisons

      /// <summary>
      /// Test for exact match.
      /// </summary>
      /// <param name="A"></param>
      /// <param name="B"></param>
      /// <returns></returns>
      public static bool operator ==(TimedEvent A, TimedEvent B) {
         if ((object)A == null) return (object)B == null;
         if ((object)B == null) return (object)A == null;
         return A.Equals(B);
      }

      /// <summary>
      /// Test for not an exact match.
      /// </summary>
      /// <param name="A"></param>
      /// <param name="B"></param>
      /// <returns></returns>
      public static bool operator !=(TimedEvent A, TimedEvent B) {
         if ((object)A == null) return (object)B != null;
         if ((object)B == null) return (object)A != null;
         return !A.Equals(B);
      }

      /// <summary>
      /// Test equality of two TimedEvents.
      /// Checks start/end times for exact match.
      /// </summary>
      /// <param name="rvalue"></param>
      /// <returns></returns>
      public override bool Equals(Object B) {
         if (!(B is TimedEvent)) return false;
         TimedEvent B_te = (TimedEvent)B;
         return
            (StartTime == B_te.StartTime) &&
            (EndTime == B_te.EndTime);
      }

      /// <summary>
      /// Test if TimedEvent A is less than B.
      /// </summary>
      /// <param name="A"></param>
      /// <param name="B"></param>
      /// <returns></returns>
      public static bool operator <(TimedEvent A, TimedEvent B) {
         return A.CompareTo(B) < 0;
      }

      /// <summary>
      /// Test if TimedEvent A is greater than B.
      /// </summary>
      /// <param name="A"></param>
      /// <param name="B"></param>
      /// <returns></returns>
      public static bool operator >(TimedEvent A, TimedEvent B) {
         return A.CompareTo(B) > 0;
      }

      /// <summary>
      /// Test if TimedEvent A is less than or equal to B.
      /// </summary>
      /// <param name="A"></param>
      /// <param name="B"></param>
      /// <returns></returns>
      public static bool operator <=(TimedEvent A, TimedEvent B) {
         return A.CompareTo(B) <= 0;
      }

      /// <summary>
      /// Test if TimedEvent A is greater than or equal to B.
      /// </summary>
      /// <param name="A"></param>
      /// <param name="B"></param>
      /// <returns></returns>
      public static bool operator >=(TimedEvent A, TimedEvent B) {
         return A.CompareTo(B) >= 0;
      }

      /// <summary>
      /// Compare StartTime, then EndTime.
      /// </summary>
      /// <remarks>
      /// Implemented IComparable for use with Array.Sort().
      /// </remarks>
      /// <param name="rvalue"></param>
      /// <returns></returns>
      public int CompareTo(TimedEvent rvalue) {
         if (rvalue == null) throw new NullReferenceException();  // Cannot compare against null
         int cmp = _StartTime.CompareTo(rvalue.StartTime);
         if (cmp == 0) cmp = EndTime.CompareTo(rvalue.EndTime);
         return cmp;
      }

      #endregion

      #region TimedEvent math

      /// <summary>
      /// Test if two TimedEvents intersect.
      /// </summary>
      /// <param name="B">TimedEvent to compare.</param>
      /// <returns>True if intersecting.</returns>
      public bool Intersects(TimedEvent B) {
         TimedEvent A = this;
         //      AAAA  AAAA
         // BBBB            BBBB
         return !(B.EndTime <= A.StartTime || A.EndTime <= B.StartTime) || A.StartTime == B.StartTime;
      }

      /// <summary>
      /// Calculate intersection of two TimedEvents.
      /// </summary>
      /// <param name="A">TimedEvent A.</param>
      /// <param name="B">TimedEvent B.</param>
      /// <returns>TimedEvent or null if no intersection.</returns>
      public static TimedEvent operator &(TimedEvent A, TimedEvent B) {
         return A.Intersection(B);
      }

      /// <summary>
      /// Test if DateTime is contained within TimedEvent.
      /// </summary>
      /// <param name="A">TimedEvent.</param>
      /// <param name="B">DateTime.</param>
      /// <returns>True if contained.</returns>
      public static bool operator &(TimedEvent A, DateTime B) {
         return A.Contains(B);
      }

      /// <summary>
      /// Test if DateTime is contained within TimedEvent.
      /// </summary>
      /// <param name="A">DateTime.</param>
      /// <param name="B">TimedEvent.</param>
      /// <returns>True if contained.</returns>
      public static bool operator &(DateTime A, TimedEvent B) {
         return B.Contains(A);
      }

      /// <summary>
      /// Calculate intersection of two TimedEvents.
      /// (....[**)....]
      /// </summary>
      /// <param name="rvalue">TimedEvent to compare.</param>
      /// <returns>TimedEvent or null if no intersection.</returns>
      public TimedEvent Intersection(TimedEvent B) {
         TimedEvent A = this;
         if (A.Contains(B.StartTime)) {
            // AAAA   AAAA AAAA
            //   BBBB  BB    BB
            if (B.EndTime > A.EndTime) {
               // AAAA
               //   BBBB
               return new TimedEvent(B.StartTime, A.EndTime);
            }
            else {
               // AAAA  AAAA
               //  BB     BB
               return B;
            }
         }
         else if (A.Contains(B.EndTime)) {
            //   AAAA    AAAA
            // BBBB    BBBBBB
            return new TimedEvent(A.StartTime, B.EndTime);
         }
         else if (B.Contains(A.StartTime)) {
            //  AA
            // BBBB
            return A;
         }

         // No intersection
         return null;
      }

      /// <summary>
      /// Test if a DateTime is contained within this TimedEvent.
      /// </summary>
      /// <param name="B">DateTime to compare.</param>
      /// <returns>True if DateTime is contained.</returns>
      public bool Contains(DateTime B) {
         TimedEvent A = this;
         return B >= A.StartTime && B < A.EndTime;
      }

      /// <summary>
      /// Test if a TimedEvent is contained within this TimedEvent.
      /// AAAA
      ///  BB
      /// </summary>
      /// <param name="B">TimedEvent to compare.</param>
      /// <returns>True if TimedEvent is contained.</returns>
      public bool Contains(TimedEvent B) {
         TimedEvent A = this;
         return B.StartTime >= A.StartTime && B.StartTime < A.EndTime && B.EndTime <= A.EndTime;
      }

      /// <summary>
      /// Test if two TimedEvents are adjacent.
      /// AAAABBBB or BBBBAAAA
      /// </summary>
      /// <param name="B">TimedEvent to compare.</param>
      /// <returns>True if TimedEvents are adjacent.</returns>
      public bool IsAdjacentTo(TimedEvent B) {
         TimedEvent A = this;
         return A.EndTime == B.StartTime || B.EndTime == A.StartTime;
      }

      /// <summary>
      /// Calculate union of two TimedEvents.
      /// </summary>
      /// <param name="A">TimedEvent A.</param>
      /// <param name="B">TimedEvent B.</param>
      /// <returns>TimedEvent[] array.</returns>
      public static TimedEvent[] operator |(TimedEvent A, TimedEvent B) {
         return A.Union(B);
      }

      /// <summary>
      /// Calculate union of two TimedEvents.
      /// </summary>
      /// <param name="B">TimedEvent to compare.</param>
      /// <returns>TimedEvent[] array.</returns>
      public TimedEvent[] Union(TimedEvent B) {
         TimedEvent A = this;

         // Swap if out of order.
         if (A.StartTime > B.StartTime) {
            A = B;
            B = this;
         }

         if (A.Contains(B.StartTime)) {
            //  AAA..
            //    BBB..
            if (B.StartTime > A.StartTime) {
               // AAAA    AAAA  AAAA
               //   BBBB    BB  BBBB
               if (B.EndTime > A.EndTime) {
                  // AAAA
                  //   BBBB
                  return new[] { new TimedEvent(A.StartTime, B.EndTime) };
               }
               else {
                  // AAAA
                  //   BB
                  return new[] { A };
               }
            }
            else {
               // AAAA  AAAA
               // BBBB  BBBBBB
               return new[] { B };
            }
         }
         else if (A.Contains(B.EndTime)) {
            // AAAA    AAAA    AAAA
            // BB    BBBB    BBBBBB
            if (B.StartTime < A.StartTime) {
               //   AAAA    AAAA
               // BBBB    BBBBBB
               if (B.EndTime < A.EndTime) {
                  //   AAAA
                  // BBBB
                  return new[] { new TimedEvent(B.StartTime, A.EndTime) };
               }
               else {
                  //   AAAA
                  // BBBBBB
                  return new[] { B };
               }
            }
            else {
               // AAAA
               // BB
               return new[] { A };
            }
         }
         else if (B.Contains(A.StartTime)) {
            //  AA
            // BBBB
            return new[] { B };
         }
         else if (A.EndTime == B.StartTime) {
            // AAAABBBB
            return new[] { new TimedEvent(A.StartTime, B.EndTime) };
         }
         else if (B.EndTime == A.StartTime) {
            // BBBBAAAA
            return new[] { new TimedEvent(B.StartTime, A.EndTime) };
         }

         // No intersection
         return new[] { A, B };
      }

      /// <summary>
      /// Calculate difference of two TimedEvents.
      /// </summary>
      /// <param name="A">TimedEvent A.</param>
      /// <param name="B">TimedEvent B.</param>
      /// <returns>TimedEvent[] array.</returns>
      public static TimedEvent[] operator ^(TimedEvent A, TimedEvent B) {
         return A.Difference(B);
      }

      /// <summary>
      /// Calculate difference of two TimedEvents.
      /// (****[..)****]
      /// </summary>
      /// <param name="B">TimedEvent to compare.</param>
      /// <returns>TimedEvent[] array.</returns>
      public TimedEvent[] Difference(TimedEvent B) {
         TimedEvent A = this;

         // Swap if out of order.
         if (A.StartTime > B.StartTime) {
            A = B;
            B = this;
         }

         if (A.Contains(B.StartTime)) {
            //  AAA..
            //    BBB..
            if (B.StartTime > A.StartTime) {
               // AAAA    AAAA  AAAA
               //   BBBB    BB  BBBB
               if (B.EndTime > A.EndTime) {
                  // AAAA
                  //   BBBB
                  return new[] { new TimedEvent(A.StartTime, B.StartTime), new TimedEvent(A.EndTime, B.EndTime) };
               }
               else if (B.EndTime < A.EndTime) {
                  // AAAA
                  //  BB
                  return new[] { new TimedEvent(A.StartTime, B.StartTime), new TimedEvent(B.EndTime, A.EndTime) };
               }
               else {
                  // AAAA
                  //   BB
                  return new[] { new TimedEvent(A.StartTime, B.StartTime) };
               }
            }
            else if (B.EndTime > A.EndTime) {
               // AAAA
               // BBBBBB
               return new[] { new TimedEvent(A.EndTime, B.EndTime) };
            }
            else {
               // AAAA
               // BBBB
               return new TimedEvent[0];
            }
         }
         else if (A.Contains(B.EndTime)) {
            // AAAA    AAAA    AAAA
            // BB    BBBB    BBBBBB
            if (B.StartTime < A.StartTime) {
               //   AAAA    AAAA
               // BBBB    BBBBBB
               if (B.EndTime < A.EndTime) {
                  //   AAAA
                  // BBBB
                  return new[] { new TimedEvent(B.StartTime, A.StartTime), new TimedEvent(B.EndTime, A.EndTime) };
               }
               else {
                  //   AAAA
                  // BBBBBB
                  return new[] { new TimedEvent(B.StartTime, A.StartTime) };
               }
            }
            else {
               // AAAA
               // BB
               return new[] { new TimedEvent(B.EndTime, A.EndTime) };
            }
         }
         else if (B.Contains(A.StartTime)) {
            //  AA
            // BBBB
            return new[] { new TimedEvent(B.StartTime, A.StartTime), new TimedEvent(A.EndTime, B.EndTime) };
         }

         // No intersection
         return new[] { A, B };
      }

      /// <summary>
      /// Calculate negated time ranges.
      /// </summary>
      /// <returns>TimedEvent[] array.</returns>
      public TimedEvent[] Negate() {
         if (StartTime > DateTime.MinValue && EndTime < DateTime.MaxValue)
            return new[] { new TimedEvent(DateTime.MinValue, StartTime), new TimedEvent(EndTime, DateTime.MaxValue) };
         else if (StartTime > DateTime.MinValue)
            return new[] { new TimedEvent(DateTime.MinValue, StartTime) };
         else if (EndTime < DateTime.MaxValue)
            return new[] { new TimedEvent(EndTime, DateTime.MaxValue) };
         else
            return new TimedEvent[0];
      }

      /// <summary>
      /// Enumerate dates that this event spans.
      /// </summary>
      /// <param name="evt"></param>
      /// <returns></returns>
      public IEnumerable<DateTime> GetEventDates() {
         var dt = StartTime.Date;
         
         do {
            yield return dt;
            dt = dt.AddDays(1);
         } while (dt < EndTime);

         yield break;
      }

      #endregion
   }
}
