using System;
using System.Collections.Generic;

namespace Expl.Itinerary {
   /// <summary>
   /// Interface for Schedule classes containing time schedule definition.
   /// </summary>
   public interface ISchedule {
      /// <summary>
      /// Rank of precedence during parsing and serialization.
      /// Lower is greater precedence; higher is lesser precedence.
      /// </summary>
      int OperatorPrecedence { get; }

      /// <summary>
      /// Return serialized TDL syntax of schedule definition
      /// </summary>
      string ToString();

      /// <summary>
      /// Get events that intersect a range of time
      /// </summary>
      /// <param name="RangeStart">Start time</param>
      /// <param name="RangeEnd">End time</param>
      /// <returns>Enumeration of events in chronological order</returns>
      IEnumerable<TimedEvent> GetRange(DateTime RangeStart, DateTime RangeEnd);
   }

   /// <summary>
   /// Interface for Schedule classes classified as primitive schedule elements.
   /// </summary>
   public interface IPrimitiveSchedule : ISchedule { }

   /// <summary>
   /// Interface for Schedule classes classified as filters.
   /// </summary>
   public interface IFilterSchedule : ISchedule {
      /// <summary>
      /// Get associated base schedule
      /// </summary>
      ISchedule BaseSchedule { get; }
   }

   /// <summary>
   /// Interface for Schedule classes classified as composite/aggregate transforms.
   /// </summary>
   public interface ICompositeSchedule : ISchedule {
      /// <summary>
      /// List of associated schedules
      /// </summary>
      IEnumerable<ISchedule> Schedules { get; }

      /// <summary>
      /// Minimum number of associated schedules
      /// </summary>
      int MinSchedules { get; }

      /// <summary>
      /// Maximum number of associated schedules
      /// </summary>
      int MaxSchedules { get; }
   }
}
