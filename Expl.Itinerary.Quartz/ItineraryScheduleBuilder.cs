using Quartz;
using Quartz.Spi;
using System;

namespace Expl.Itinerary.Quartz {

   public class ItineraryScheduleBuilder : ScheduleBuilder<IItineraryTrigger> {
      private readonly ISchedule _schedule;
      private readonly DateTime _rangeStart;
      private int misfireInstruction = ItineraryTriggerMisfireInstruction.FireOnceNow;

      protected ItineraryScheduleBuilder(ISchedule schedule, DateTime rangeStart) {
         _schedule = schedule;
         _rangeStart = rangeStart;
      }

      public static ItineraryScheduleBuilder ItinerarySchedule(ISchedule schedule) {
         return new ItineraryScheduleBuilder(schedule, DateTime.UtcNow);
      }

      public static ItineraryScheduleBuilder ItinerarySchedule(ISchedule schedule, DateTime rangeStart) {
         return new ItineraryScheduleBuilder(schedule, rangeStart);
      }

      public override IMutableTrigger Build() {
         return new ItineraryTriggerImpl(_schedule, _rangeStart) {
            MisfireInstruction = misfireInstruction
         };
      }

      public void WithMisfireHandlingInstructionDoNothing() {
         misfireInstruction = ItineraryTriggerMisfireInstruction.DoNothing;
      }

      public void WithMisfireHandlingInstructionFireAndProceed() {
         misfireInstruction = ItineraryTriggerMisfireInstruction.FireOnceNow;
      }
   }
}