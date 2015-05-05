using Quartz;
using System;

namespace Expl.Itinerary.Quartz {

   /// <summary>
   /// Extension methods to attach <see cref="ItineraryScheduleBuilder"/> to <see cref="TriggerBuilder" />.
   /// </summary>
   public static class ItineraryScheduleTriggerBuilderExtensions {

      public static TriggerBuilder WithItinerarySchedule(this TriggerBuilder triggerBuilder, ISchedule schedule, DateTime rangeStart) {
         var builder = ItineraryScheduleBuilder.ItinerarySchedule(schedule, rangeStart);
         return triggerBuilder.WithSchedule(builder);
      }

      public static TriggerBuilder WithItinerarySchedule(this TriggerBuilder triggerBuilder, ISchedule schedule, DateTime rangeStart, Action<ItineraryScheduleBuilder> action) {
         var builder = ItineraryScheduleBuilder.ItinerarySchedule(schedule, rangeStart);
         action(builder);
         return triggerBuilder.WithSchedule(builder);
      }
   }
}