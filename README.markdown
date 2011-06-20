Itinerary: Lazy time scheduling toolset for .NET
================================================

Pre-release, 2011-06-06  
GitHub repo: https://github.com/spoulson/Itinerary  
Shawn Poulson, http://explodingcoder.com

INTRODUCTION
------------

### What does Itinerary do?
  - Describe an abstract schedule of timed events as an expression, such as the equivalent of:  
    "Every Friday at 5:30 pm for 1 hour, except on holidays", for any given time range.
  - Perform complex boolean set math on recurring patterns of timed events.
  - Parse expressions to a schedule object and enumerate timed events.
  - Change schedule properties programmatically, then reserialize back to expression.

### What *doesn't* Itinerary do?
  - Does not actively run tasks on a schedule.  That's your job.
    For that, check out http://quartznet.sf.net and the ItineraryTrigger class in the solution.
  - Does not perform timezone interpretation or computation.  All date/times are timezone agnostic.

### Why use Itinerary?
  - You need to integrate a cron-like scheduler into your app.
  - You need to logically describe complex recurrance patterns and/or arbitrary schedules of date/times.
  - You need to store this description (not the events) for later reuse.

### How do I get started using Itinerary?
  - Learn TDL expression syntax from the Itinerary Wiki on GitHub:
    https://github.com/spoulson/Itinerary/wiki
  - Test TDL expression syntax using the TDL Explorer tool in the solution.

SYSTEM REQUIREMENTS
-------------------

### Development requirements:
* Visual Studio 2010 (Professional edition or better required for unit test execution).
* Java SE JDK (optional, required to compile ANTLR grammar).

### Runtime requirements:
* .NET 4.0 Framework.

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
