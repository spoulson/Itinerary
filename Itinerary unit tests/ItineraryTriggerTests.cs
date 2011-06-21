using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Expl.Itinerary.Quartz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quartz;
using Quartz.Impl;

namespace Expl.Itinerary.Test {
   [TestClass]
   public class ItineraryTriggerTests {
      public ISchedulerFactory sf;
      public IScheduler sched;

      [TestInitialize]
      public void Initialize() {
         Debug.WriteLine("------- Initializing ----------------------");
         sf = new StdSchedulerFactory();
         sched = sf.GetScheduler();
      }

      [TestCleanup]
      public void Cleanup() {
         // Shut down the scheduler.
         Debug.WriteLine("------- Shutting Down ---------------------");
         sched.Shutdown(true);
      }

      [TestMethod]
      public void OneTimeScheduleTriggerTest() {
         Debug.WriteLine("------- Scheduling Jobs -------------------");

         var semHandle = new EventWaitHandle(false, EventResetMode.AutoReset);

         // Set the job run time.
         DateTime rangeStart = DateTime.UtcNow;
         DateTime runTime = rangeStart.AddSeconds(1);
         var runSchedule = new OneTimeSchedule(runTime, TimeSpan.Zero);

         // Define the job and tie it to our HelloJob class.
         JobDetail job = new JobDetail("job1", "group1", typeof(HelloJob));
         job.JobDataMap["SemHandle"] = semHandle;

         // Trigger the job to run on the set time.
         var trigger = new ItineraryTrigger("trigger1", "group1", runSchedule, rangeStart);

         // Tell Quartz to schedule the job using our trigger.
         sched.ScheduleJob(job, trigger);
         var firstEvent = runSchedule.GetRange(rangeStart, DateTime.MaxValue).First();
         Debug.WriteLine(string.Format("{0} will start at: {1}", job.FullName, firstEvent.StartTime.ToString("r")));

         // Start up the scheduler.
         sched.Start();
         Debug.WriteLine("------- Started Scheduler -----------------");

         // Wait long enough so that the scheduler as an opportunity to 
         // run the job.
         Debug.WriteLine("------- Waiting a few seconds... -------------");

         // Wait for job to signal.
         Assert.IsTrue(semHandle.WaitOne(5000));
      }

      [TestMethod]
      public void IntervalScheduleTriggerTest() {
         Debug.WriteLine("------- Scheduling Jobs -------------------");

         var semHandle = new EventWaitHandle(false, EventResetMode.AutoReset);

         // Set the job run time.
         DateTime rangeStart = DateTime.UtcNow;
         DateTime runTime = rangeStart.AddSeconds(1);
         var runSchedule = new IntervalSchedule(TimeSpan.FromMilliseconds(500), TimeSpan.Zero, rangeStart);

         // Define the job and tie it to our HelloJob class.
         JobDetail job = new JobDetail("job1", "group1", typeof(HelloJob));
         job.JobDataMap["SemHandle"] = semHandle;

         // Trigger the job to run on the set time.
         var trigger = new ItineraryTrigger("trigger1", "group1", runSchedule, rangeStart);

         // Tell Quartz to schedule the job using our trigger.
         sched.ScheduleJob(job, trigger);
         var firstEvent = runSchedule.GetRange(rangeStart, DateTime.MaxValue).First();
         Debug.WriteLine(string.Format("{0} will start at: {1}", job.FullName, firstEvent.StartTime.ToString("r")));

         // Start up the scheduler.
         sched.Start();
         Debug.WriteLine("------- Started Scheduler -----------------");

         // Wait long enough so that the scheduler as an opportunity to 
         // run the job.
         Debug.WriteLine("------- Waiting a few seconds... -------------");

         // Wait for job to signal 5 times.
         for (int i = 0; i < 5; i++) {
            Assert.IsTrue(semHandle.WaitOne(5000));
         }
      }

      [TestMethod]
      public void MisfireTriggerTest() {
         Debug.WriteLine("------- Scheduling Jobs -------------------");

         var semHandle = new EventWaitHandle(false, EventResetMode.AutoReset);

         // Set the job run time.
         DateTime rangeStart = DateTime.UtcNow;
         DateTime runTime = rangeStart.AddSeconds(1);
         var runSchedule = new OneTimeSchedule(runTime, TimeSpan.Zero);

         // Define the job and tie it to our HelloJob class.
         JobDetail job = new JobDetail("job1", "group1", typeof(HelloJob));
         job.JobDataMap["SemHandle"] = semHandle;

         // Trigger the job to run on the set time.
         var trigger = new ItineraryTrigger("trigger1", "group1", runSchedule, rangeStart);
         trigger.MisfireInstruction = ItineraryTriggerMisfireInstruction.RescheduleNowWithExistingCount;

         // Tell Quartz to schedule the job using our trigger.
         sched.ScheduleJob(job, trigger);
         var firstEvent = runSchedule.GetRange(rangeStart, DateTime.MaxValue).First();
         Debug.WriteLine(string.Format("{0} will start at: {1}", job.FullName, firstEvent.StartTime.ToString("r")));

         // Start up the scheduler.
         sched.Start();
         Debug.WriteLine("------- Started Scheduler -----------------");

         // Wait long enough so that the scheduler as an opportunity to 
         // run the job.
         Debug.WriteLine("------- PauseAll(), wait 4s -------------");

         sched.PauseAll();
         Thread.Sleep(4000);
         Debug.WriteLine("------- ResumeAll(), expect job to run immediately -------------");
         sched.ResumeAll();

         // TODO: What does it take to get Quartz to drop a trigger event?
         Debug.WriteLine("------- Waiting a few seconds... -------------");
         Assert.IsTrue(semHandle.WaitOne(5000));
      }

      public class HelloJob : IJob {
         /// <summary> 
         /// Called by the <see cref="IScheduler" /> when a
         /// <see cref="Trigger" /> fires that is associated with
         /// the <see cref="IJob" />.
         /// </summary>
         public virtual void Execute(JobExecutionContext context) {
            // Say Hello to the World and display the date/time
            var now = DateTime.UtcNow;
            var variance = now - context.FireTimeUtc;
            Debug.WriteLine(string.Format("Hello World! - {0}, Start time variance: {1}", now.ToString("r"), variance.ToString()));

            var semHandle = context.JobDetail.JobDataMap["SemHandle"] as EventWaitHandle;
            if (semHandle != null) {
               semHandle.Set();
            }
         }
      }

      public class SleepJob : IJob {
         /// <summary> 
         /// Called by the <see cref="IScheduler" /> when a
         /// <see cref="Trigger" /> fires that is associated with
         /// the <see cref="IJob" />.
         /// </summary>
         public virtual void Execute(JobExecutionContext context) {
            var sleepTime = context.JobDetail.JobDataMap["SleepTime"] as int? ?? 0;

            Debug.WriteLine(string.Format("Sleeping for {0:d}ms - {1}", sleepTime, System.DateTime.UtcNow.ToString("r")));
            Thread.Sleep(sleepTime);

            var semHandle = context.JobDetail.JobDataMap["SemHandle"] as EventWaitHandle;
            if (semHandle != null) {
               semHandle.Set();
            }
         }
      }
   }
}
