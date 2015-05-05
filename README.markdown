Itinerary: Lazy time scheduling toolset for .NET
================================================

Release 1.1, 2015-05-05  
GitHub repo: https://github.com/spoulson/Itinerary  
Shawn Poulson, http://explodingcoder.com

INTRODUCTION
------------

### What does Itinerary do?
 - Describe an abstract schedule of timed events as an expression, such as the equivalent of:  
   "Every Friday at 5:30 pm for 1 hour, except on holidays", for any given time range.
 - Parse expressions to an Itinerary `ISchedule` object at runtime.
 - `ISchedule` provides `IEnumerable` of timed events within any given time range.
 - Perform complex boolean set math on schedules.
 - Change `ISchedule` properties programmatically, then reserialize back to TDL expression string.

### What *doesn't* Itinerary do?
 - Does not actively run tasks on a schedule.  That's your job.  
   For that, check out [Quartz.NET](http://quartznet.sf.net) and the provided `ScheduleTests` unit test class.
 - Does not perform timezone interpretation or computation.  All date/times are timezone agnostic.

### Why use Itinerary?
 - Lightweight, stateless, lazily generate events on demand.
 - You need to integrate a cron-like scheduler into your app.
 - You already use a scheduler, like Quartz.NET, but need more powerful scheduling logic.
 - You need to logically describe arbitrary or complex recurrance patterns.
 - You need to forecast scheduled timed events.
 - You need to store the recurrance logic (not the events) for later reuse.

### How do I get started using Itinerary?
 - Learn TDL expression syntax from the Itinerary Wiki on GitHub:
   https://github.com/spoulson/Itinerary/wiki
 - Test TDL expression syntax using the TDL Explorer tool in the solution.
 - Check out the example projects.
 - Refer to unit tests for usage reference.

SYSTEM REQUIREMENTS
-------------------

### Development requirements:
* Visual Studio 2013 (Professional edition or better required for unit test execution).
* NUnit to run unit tests.  Typically, Visual Studio 2013 Professional + NUnit Test Adapter extension will do the job.
* Java SE JDK (optional, required to recompile ANTLR grammar).

### Runtime requirements:
* .NET 4.5.1 Framework.

KNOWN ISSUES
------------

None reported at time of release.  
See GitHub repo for issue tracking.

LICENSING
---------

Itinerary is an open source project licensed under the Creative Commons Attribution license:
http://creativecommons.org/licenses/by/3.0/legalcode.

ANTLR 3.2 http://antlr.org binary tools and .NET runtime are included in the Expl.Itinerary.Parser
project, allowable under ANTLR's BSD license terms: http://antlr.org/license.html.
