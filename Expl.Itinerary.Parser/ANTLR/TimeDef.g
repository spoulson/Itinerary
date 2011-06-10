grammar TimeDef;

// Quick ref on set math: http://www.sonsothunder.com/devres/revolution/tips/arry002.htm

options {
   language=CSharp2;
   output=AST;
   backtrack=true;
}

@parser::header {
   using System.Collections.Generic;
   using Debug = System.Diagnostics.Debug;
   using Expl.Itinerary;
}

@rulecatch {
   catch (RecognitionException) { throw; }
}

prog returns [ISchedule value]:
   expr EOF { $value = $expr.value; };

// Schedule precedence, lowest to highest
// Composites:
//  List ,
//  Boolean Not Intersection !&&
//  Boolean Intersection &&
//  Union |
//  Difference !&
//  Intersection &
// Filters: (all same precedence)
//  Lasting 'lasting'/'to'
//  Offset +/-
//  Repeat x
//  Index #
// Atoms: (all highest precedence)
//  One Time
//  Interval
//  Cron
//  Void

//
// Expression rules
//
atom returns [ISchedule value]:
   once_p { $value = $once_p.value; } |
   every_p { $value = $every_p.value; } |
   cron_p { $value = $cron_p.value; } |
   dayofweek_p { $value = $dayofweek_p.value; } |
   void_p { $value = $void_p.value; } |
   paren_p { $value = $paren_p.value; };


//
// Core expression primitives
//
once_p returns [OneTimeSchedule value]: (
   start=datetime_p (WS+ 'lasting' WS+ duration=timespan_p)?
) { $value = new OneTimeSchedule($start.value, duration==null ? TimeSpan.Zero : $duration.value); };

every_p returns [IntervalSchedule value]: (
   'every' WS+ interval=timespan_p (WS+ 'since' WS+ sync=datetime_p)? (WS+ 'lasting' WS+ duration=timespan_p)?
) { $value = new IntervalSchedule($interval.value, duration==null ? TimeSpan.Zero : $duration.value, sync==null ? DateTime.MinValue : $sync.value); };

cron_p returns [CronSchedule value]: (
   'cron' WS+
   minute=cron_field_p WS+
   hour=cron_field_p WS+
   day=cron_field_p WS+
   month=cron_field_p WS+
   dow=cron_field_p
   (WS+ 'lasting' WS+ duration=timespan_p)?
) { $value = new CronSchedule($minute.text, $hour.text, $day.text, $month.text, $dow.text, duration==null ? TimeSpan.Zero : $duration.value); };

dayofweek_p returns [DayOfWeekSchedule value]: (
   'week' WS+ ordinal=intspec_p WS+ dayofweek=intspec_p
) { $value = new DayOfWeekSchedule($ordinal.text, $dayofweek.text); };

void_p returns [VoidSchedule value]:
   'void' { $value = new VoidSchedule(); };

paren_p returns [ISchedule value]: (
   '(' expr ')'
) { $value = $expr.value; };

//
// Expression computations
//

filter_p returns [ISchedule value]:
   A=atom { $value = $A.value; } (
      (WS* '#' WS* index_intspec=intspec_p { $value = new IndexSchedule($index_intspec.text, $value); } ) |
      (WS* 'x' WS* repeatcount=UINT { $value = new RepeatSchedule(int.Parse($repeatcount.text), $value); } ) |
      (WS* op=('+'|'-') WS* offset_timespan=timespan_p { $value = new OffsetSchedule($op.Text == "+" ? $offset_timespan.value : $offset_timespan.value.Negate(), $value); } ) |
      (WS+ 'lasting' WS+ lasting_timespan=timespan_p { $value = new LastingSchedule($lasting_timespan.value, $value); } )
   )*;

// Expression List
// Simple array list of expressions
expr returns [ISchedule value]
@init {
   List<ISchedule> Schedules = new List<ISchedule>();
}
: (
   WS* A=boolnonintersection_p { Schedules.Add($A.value); }
   (WS* ',' WS* B=boolnonintersection_p { Schedules.Add($B.value); } )* WS*
) { $value = Schedules.Count > 1 ? new ListSchedule(Schedules) : Schedules[0]; };

// Boolean NonIntersection
// Test Not (....[**)....]
// Test NonIntersection of two datetime spans
boolnonintersection_p returns [ISchedule value]:
   A=boolintersection_p { $value = $A.value; }
   (WS* '!&&' WS* B=boolintersection_p { $value = new BoolNonIntersectionSchedule($value, $B.value); } )*;

// Boolean Intersection
// Test (....[**)....]
// Like ANDing A and B
// Test intersection of two datetime spans
boolintersection_p returns [ISchedule value]:
   A=union_p { $value = $A.value; }
   (WS* '&&' WS* B=union_p { $value = new BoolIntersectionSchedule($value, $B.value); } )*;

// Union
// (****[**)****]
// Like ORing A and B
// Generate single datetime span, eliminate overlap redundancy
union_p returns [ISchedule value]
@init {
   List<ISchedule> Schedules = new List<ISchedule>();
}
: (
   A=difference_p { Schedules.Add($A.value); }
   (WS* '|' WS* B=difference_p { Schedules.Add($B.value); } )*
) { $value = Schedules.Count > 1 ? new UnionSchedule(Schedules) : Schedules[0]; };

// Difference
// (****[..)****]
// Generate difference of two datetime spans
difference_p returns [ISchedule value]
@init {
   List<ISchedule> Schedules = new List<ISchedule>();
}
: (
   A=intersection_p { Schedules.Add($A.value); }
   (WS* '!&' WS* B=intersection_p { Schedules.Add($B.value); } )*
) { $value = Schedules.Count > 1 ? new DifferenceSchedule(Schedules) : Schedules[0]; };

// Intersection
// (....[**)....]
// Like ANDing A and B
// Generate single datetime span
intersection_p returns [ISchedule value]:
   A=filter_p { $value = $A.value; }
   (WS* '&' WS* B=filter_p { $value = new IntersectionSchedule($value, $B.value); } )*;


//
// Time units
//
datetime_p returns [DateTime value]: (
   y=year_p '-' mo=month_p '-' d=day_p (WS+ h=hour24_p ':' m=minute60_p (':' s=second60_p ('.' ms=millisecond1000_p)?)?)? |
   h=hour24_p ':' m=minute60_p (':' s=second60_p ('.' ms=millisecond1000_p)?)?
) {
   $value = new DateTime(
      y==null ? DateTime.UtcNow.Year : $y.value,
      mo==null ? DateTime.UtcNow.Month : $mo.value,
      d==null ? DateTime.UtcNow.Day : $d.value,
      h==null ? 0 : $h.value,
      m==null ? 0 : $m.value,
      s==null ? 0 : $s.value,
      ms==null ? 0 : $ms.value);
};

datetime_prog returns [DateTime value]: (
   datetime_p EOF
) { $value = $datetime_p.value; };

year_p returns [int value]: UINT { $value = int.Parse($UINT.text); };
month_p returns [int value]: UINT { $value = int.Parse($UINT.text); };
day_p returns [int value]: UINT { $value = int.Parse($UINT.text); };
hour24_p returns [int value]: UINT { $value = int.Parse($UINT.text); };
minute60_p returns [int value]: UINT { $value = int.Parse($UINT.text); };
second60_p returns [int value]: UINT { $value = int.Parse($UINT.text); };
millisecond1000_p returns [int value]: UINT { $value = int.Parse($UINT.text); };

timespan_p returns [TimeSpan value]: (
   'T' (((d=days_p '.')? h=hours_p ':')? m=minutes_p ':')? s=seconds_p ('.' ms=milliseconds_p)?
) {
   $value = new TimeSpan(
      d==null ? 0 : $d.value,
      h==null ? 0 : $h.value,
      m==null ? 0 : $m.value,
      $s.value,
      ms==null ? 0 : $ms.value);
};

timespan_prog returns [TimeSpan value]: (
   timespan_p EOF
) { $value = $timespan_p.value; };

days_p returns [int value]: int_p { $value = int.Parse($int_p.text); };
hours_p returns [int value]: int_p { $value = int.Parse($int_p.text); };
minutes_p returns [int value]: int_p { $value = int.Parse($int_p.text); };
seconds_p returns [int value]: int_p { $value = int.Parse($int_p.text); };
milliseconds_p returns [int value]: int_p { $value = int.Parse($int_p.text); };

cron_field_p: cron_term_p (',' cron_term_p)*;
cron_term_p: '!'? (UINT | '/' | '-' | '*' | '>' | '<')+;

intspec_p: intspec_term_p (',' intspec_term_p)*;
intspec_term_p: '!'? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )?;

//
// Primitives
//
int_p: '-'? UINT;

UINT: ('0'..'9')+;
ALPHA: ('A'..'Z'|'a'..'z')+;
WS: (' '|'\t'|'\r\n'|'\r')+;
