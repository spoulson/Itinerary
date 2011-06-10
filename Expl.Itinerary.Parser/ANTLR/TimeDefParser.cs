// $ANTLR 3.2 Sep 23, 2009 12:02:23 TimeDef.g 2011-06-10 10:45:41

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


   using System.Collections.Generic;
   using Debug = System.Diagnostics.Debug;
   using Expl.Itinerary;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

public partial class TimeDefParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"WS", 
		"UINT", 
		"ALPHA", 
		"'lasting'", 
		"'every'", 
		"'since'", 
		"'cron'", 
		"'week'", 
		"'void'", 
		"'('", 
		"')'", 
		"'#'", 
		"'x'", 
		"'+'", 
		"'-'", 
		"','", 
		"'!&&'", 
		"'&&'", 
		"'|'", 
		"'!&'", 
		"'&'", 
		"':'", 
		"'.'", 
		"'T'", 
		"'!'", 
		"'/'", 
		"'*'", 
		"'>'", 
		"'<'"
    };

    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int UINT = 5;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int EOF = -1;
    public const int T__9 = 9;
    public const int T__8 = 8;
    public const int T__7 = 7;
    public const int ALPHA = 6;
    public const int T__30 = 30;
    public const int T__19 = 19;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 4;
    public const int T__16 = 16;
    public const int T__15 = 15;
    public const int T__18 = 18;
    public const int T__17 = 17;
    public const int T__12 = 12;
    public const int T__11 = 11;
    public const int T__14 = 14;
    public const int T__13 = 13;
    public const int T__10 = 10;

    // delegates
    // delegators



        public TimeDefParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public TimeDefParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return TimeDefParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "TimeDef.g"; }
    }


    public class prog_return : ParserRuleReturnScope
    {
        public ISchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "prog"
    // TimeDef.g:21:1: prog returns [ISchedule value] : expr EOF ;
    public TimeDefParser.prog_return prog() // throws RecognitionException [1]
    {   
        TimeDefParser.prog_return retval = new TimeDefParser.prog_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF2 = null;
        TimeDefParser.expr_return expr1 = default(TimeDefParser.expr_return);


        object EOF2_tree=null;

        try 
    	{
            // TimeDef.g:21:31: ( expr EOF )
            // TimeDef.g:22:4: expr EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expr_in_prog62);
            	expr1 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr1.Tree);
            	EOF2=(IToken)Match(input,EOF,FOLLOW_EOF_in_prog64); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EOF2_tree = (object)adaptor.Create(EOF2);
            		adaptor.AddChild(root_0, EOF2_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((expr1 != null) ? expr1.value : default(ISchedule)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "prog"

    public class atom_return : ParserRuleReturnScope
    {
        public ISchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "atom"
    // TimeDef.g:46:1: atom returns [ISchedule value] : ( once_p | every_p | cron_p | dayofweek_p | void_p | paren_p );
    public TimeDefParser.atom_return atom() // throws RecognitionException [1]
    {   
        TimeDefParser.atom_return retval = new TimeDefParser.atom_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.once_p_return once_p3 = default(TimeDefParser.once_p_return);

        TimeDefParser.every_p_return every_p4 = default(TimeDefParser.every_p_return);

        TimeDefParser.cron_p_return cron_p5 = default(TimeDefParser.cron_p_return);

        TimeDefParser.dayofweek_p_return dayofweek_p6 = default(TimeDefParser.dayofweek_p_return);

        TimeDefParser.void_p_return void_p7 = default(TimeDefParser.void_p_return);

        TimeDefParser.paren_p_return paren_p8 = default(TimeDefParser.paren_p_return);



        try 
    	{
            // TimeDef.g:46:31: ( once_p | every_p | cron_p | dayofweek_p | void_p | paren_p )
            int alt1 = 6;
            switch ( input.LA(1) ) 
            {
            case UINT:
            	{
                alt1 = 1;
                }
                break;
            case 8:
            	{
                alt1 = 2;
                }
                break;
            case 10:
            	{
                alt1 = 3;
                }
                break;
            case 11:
            	{
                alt1 = 4;
                }
                break;
            case 12:
            	{
                alt1 = 5;
                }
                break;
            case 13:
            	{
                alt1 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            }

            switch (alt1) 
            {
                case 1 :
                    // TimeDef.g:47:4: once_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_once_p_in_atom102);
                    	once_p3 = once_p();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, once_p3.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((once_p3 != null) ? once_p3.value : default(OneTimeSchedule)); 
                    	}

                    }
                    break;
                case 2 :
                    // TimeDef.g:48:4: every_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_every_p_in_atom111);
                    	every_p4 = every_p();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, every_p4.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((every_p4 != null) ? every_p4.value : default(IntervalSchedule)); 
                    	}

                    }
                    break;
                case 3 :
                    // TimeDef.g:49:4: cron_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_cron_p_in_atom120);
                    	cron_p5 = cron_p();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cron_p5.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((cron_p5 != null) ? cron_p5.value : default(CronSchedule)); 
                    	}

                    }
                    break;
                case 4 :
                    // TimeDef.g:50:4: dayofweek_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dayofweek_p_in_atom129);
                    	dayofweek_p6 = dayofweek_p();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dayofweek_p6.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((dayofweek_p6 != null) ? dayofweek_p6.value : default(DayOfWeekSchedule)); 
                    	}

                    }
                    break;
                case 5 :
                    // TimeDef.g:51:4: void_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_void_p_in_atom138);
                    	void_p7 = void_p();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, void_p7.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((void_p7 != null) ? void_p7.value : default(VoidSchedule)); 
                    	}

                    }
                    break;
                case 6 :
                    // TimeDef.g:52:4: paren_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_paren_p_in_atom147);
                    	paren_p8 = paren_p();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, paren_p8.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((paren_p8 != null) ? paren_p8.value : default(ISchedule)); 
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "atom"

    public class once_p_return : ParserRuleReturnScope
    {
        public OneTimeSchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "once_p"
    // TimeDef.g:58:1: once_p returns [OneTimeSchedule value] : (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) ;
    public TimeDefParser.once_p_return once_p() // throws RecognitionException [1]
    {   
        TimeDefParser.once_p_return retval = new TimeDefParser.once_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS9 = null;
        IToken string_literal10 = null;
        IToken WS11 = null;
        TimeDefParser.datetime_p_return start = default(TimeDefParser.datetime_p_return);

        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        object WS9_tree=null;
        object string_literal10_tree=null;
        object WS11_tree=null;

        try 
    	{
            // TimeDef.g:58:39: ( (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:58:41: (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:58:41: (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:59:4: start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		PushFollow(FOLLOW_datetime_p_in_once_p171);
            		start = datetime_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, start.Tree);
            		// TimeDef.g:59:21: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            		int alt4 = 2;
            		alt4 = dfa4.Predict(input);
            		switch (alt4) 
            		{
            		    case 1 :
            		        // TimeDef.g:59:22: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
            		        {
            		        	// TimeDef.g:59:22: ( WS )+
            		        	int cnt2 = 0;
            		        	do 
            		        	{
            		        	    int alt2 = 2;
            		        	    int LA2_0 = input.LA(1);

            		        	    if ( (LA2_0 == WS) )
            		        	    {
            		        	        alt2 = 1;
            		        	    }


            		        	    switch (alt2) 
            		        		{
            		        			case 1 :
            		        			    // TimeDef.g:0:0: WS
            		        			    {
            		        			    	WS9=(IToken)Match(input,WS,FOLLOW_WS_in_once_p174); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS9_tree = (object)adaptor.Create(WS9);
            		        			    		adaptor.AddChild(root_0, WS9_tree);
            		        			    	}

            		        			    }
            		        			    break;

            		        			default:
            		        			    if ( cnt2 >= 1 ) goto loop2;
            		        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        		            EarlyExitException eee2 =
            		        		                new EarlyExitException(2, input);
            		        		            throw eee2;
            		        	    }
            		        	    cnt2++;
            		        	} while (true);

            		        	loop2:
            		        		;	// Stops C# compiler whining that label 'loop2' has no statements

            		        	string_literal10=(IToken)Match(input,7,FOLLOW_7_in_once_p177); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal10_tree = (object)adaptor.Create(string_literal10);
            		        		adaptor.AddChild(root_0, string_literal10_tree);
            		        	}
            		        	// TimeDef.g:59:36: ( WS )+
            		        	int cnt3 = 0;
            		        	do 
            		        	{
            		        	    int alt3 = 2;
            		        	    int LA3_0 = input.LA(1);

            		        	    if ( (LA3_0 == WS) )
            		        	    {
            		        	        alt3 = 1;
            		        	    }


            		        	    switch (alt3) 
            		        		{
            		        			case 1 :
            		        			    // TimeDef.g:0:0: WS
            		        			    {
            		        			    	WS11=(IToken)Match(input,WS,FOLLOW_WS_in_once_p179); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS11_tree = (object)adaptor.Create(WS11);
            		        			    		adaptor.AddChild(root_0, WS11_tree);
            		        			    	}

            		        			    }
            		        			    break;

            		        			default:
            		        			    if ( cnt3 >= 1 ) goto loop3;
            		        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        		            EarlyExitException eee3 =
            		        		                new EarlyExitException(3, input);
            		        		            throw eee3;
            		        	    }
            		        	    cnt3++;
            		        	} while (true);

            		        	loop3:
            		        		;	// Stops C# compiler whining that label 'loop3' has no statements

            		        	PushFollow(FOLLOW_timespan_p_in_once_p184);
            		        	duration = timespan_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, duration.Tree);

            		        }
            		        break;

            		}


            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new OneTimeSchedule(((start != null) ? start.value : default(DateTime)), duration==null ? TimeSpan.Zero : ((duration != null) ? duration.value : default(TimeSpan))); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "once_p"

    public class every_p_return : ParserRuleReturnScope
    {
        public IntervalSchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "every_p"
    // TimeDef.g:62:1: every_p returns [IntervalSchedule value] : ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) ;
    public TimeDefParser.every_p_return every_p() // throws RecognitionException [1]
    {   
        TimeDefParser.every_p_return retval = new TimeDefParser.every_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal12 = null;
        IToken WS13 = null;
        IToken WS14 = null;
        IToken string_literal15 = null;
        IToken WS16 = null;
        IToken WS17 = null;
        IToken string_literal18 = null;
        IToken WS19 = null;
        TimeDefParser.timespan_p_return interval = default(TimeDefParser.timespan_p_return);

        TimeDefParser.datetime_p_return sync = default(TimeDefParser.datetime_p_return);

        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        object string_literal12_tree=null;
        object WS13_tree=null;
        object WS14_tree=null;
        object string_literal15_tree=null;
        object WS16_tree=null;
        object WS17_tree=null;
        object string_literal18_tree=null;
        object WS19_tree=null;

        try 
    	{
            // TimeDef.g:62:41: ( ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:62:43: ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:62:43: ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:63:4: 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		string_literal12=(IToken)Match(input,8,FOLLOW_8_in_every_p206); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{string_literal12_tree = (object)adaptor.Create(string_literal12);
            			adaptor.AddChild(root_0, string_literal12_tree);
            		}
            		// TimeDef.g:63:12: ( WS )+
            		int cnt5 = 0;
            		do 
            		{
            		    int alt5 = 2;
            		    int LA5_0 = input.LA(1);

            		    if ( (LA5_0 == WS) )
            		    {
            		        alt5 = 1;
            		    }


            		    switch (alt5) 
            			{
            				case 1 :
            				    // TimeDef.g:0:0: WS
            				    {
            				    	WS13=(IToken)Match(input,WS,FOLLOW_WS_in_every_p208); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS13_tree = (object)adaptor.Create(WS13);
            				    		adaptor.AddChild(root_0, WS13_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    if ( cnt5 >= 1 ) goto loop5;
            				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			            EarlyExitException eee5 =
            			                new EarlyExitException(5, input);
            			            throw eee5;
            		    }
            		    cnt5++;
            		} while (true);

            		loop5:
            			;	// Stops C# compiler whining that label 'loop5' has no statements

            		PushFollow(FOLLOW_timespan_p_in_every_p213);
            		interval = timespan_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, interval.Tree);
            		// TimeDef.g:63:36: ( ( WS )+ 'since' ( WS )+ sync= datetime_p )?
            		int alt8 = 2;
            		alt8 = dfa8.Predict(input);
            		switch (alt8) 
            		{
            		    case 1 :
            		        // TimeDef.g:63:37: ( WS )+ 'since' ( WS )+ sync= datetime_p
            		        {
            		        	// TimeDef.g:63:37: ( WS )+
            		        	int cnt6 = 0;
            		        	do 
            		        	{
            		        	    int alt6 = 2;
            		        	    int LA6_0 = input.LA(1);

            		        	    if ( (LA6_0 == WS) )
            		        	    {
            		        	        alt6 = 1;
            		        	    }


            		        	    switch (alt6) 
            		        		{
            		        			case 1 :
            		        			    // TimeDef.g:0:0: WS
            		        			    {
            		        			    	WS14=(IToken)Match(input,WS,FOLLOW_WS_in_every_p216); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS14_tree = (object)adaptor.Create(WS14);
            		        			    		adaptor.AddChild(root_0, WS14_tree);
            		        			    	}

            		        			    }
            		        			    break;

            		        			default:
            		        			    if ( cnt6 >= 1 ) goto loop6;
            		        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        		            EarlyExitException eee6 =
            		        		                new EarlyExitException(6, input);
            		        		            throw eee6;
            		        	    }
            		        	    cnt6++;
            		        	} while (true);

            		        	loop6:
            		        		;	// Stops C# compiler whining that label 'loop6' has no statements

            		        	string_literal15=(IToken)Match(input,9,FOLLOW_9_in_every_p219); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal15_tree = (object)adaptor.Create(string_literal15);
            		        		adaptor.AddChild(root_0, string_literal15_tree);
            		        	}
            		        	// TimeDef.g:63:49: ( WS )+
            		        	int cnt7 = 0;
            		        	do 
            		        	{
            		        	    int alt7 = 2;
            		        	    int LA7_0 = input.LA(1);

            		        	    if ( (LA7_0 == WS) )
            		        	    {
            		        	        alt7 = 1;
            		        	    }


            		        	    switch (alt7) 
            		        		{
            		        			case 1 :
            		        			    // TimeDef.g:0:0: WS
            		        			    {
            		        			    	WS16=(IToken)Match(input,WS,FOLLOW_WS_in_every_p221); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS16_tree = (object)adaptor.Create(WS16);
            		        			    		adaptor.AddChild(root_0, WS16_tree);
            		        			    	}

            		        			    }
            		        			    break;

            		        			default:
            		        			    if ( cnt7 >= 1 ) goto loop7;
            		        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        		            EarlyExitException eee7 =
            		        		                new EarlyExitException(7, input);
            		        		            throw eee7;
            		        	    }
            		        	    cnt7++;
            		        	} while (true);

            		        	loop7:
            		        		;	// Stops C# compiler whining that label 'loop7' has no statements

            		        	PushFollow(FOLLOW_datetime_p_in_every_p226);
            		        	sync = datetime_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sync.Tree);

            		        }
            		        break;

            		}

            		// TimeDef.g:63:71: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            		int alt11 = 2;
            		alt11 = dfa11.Predict(input);
            		switch (alt11) 
            		{
            		    case 1 :
            		        // TimeDef.g:63:72: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
            		        {
            		        	// TimeDef.g:63:72: ( WS )+
            		        	int cnt9 = 0;
            		        	do 
            		        	{
            		        	    int alt9 = 2;
            		        	    int LA9_0 = input.LA(1);

            		        	    if ( (LA9_0 == WS) )
            		        	    {
            		        	        alt9 = 1;
            		        	    }


            		        	    switch (alt9) 
            		        		{
            		        			case 1 :
            		        			    // TimeDef.g:0:0: WS
            		        			    {
            		        			    	WS17=(IToken)Match(input,WS,FOLLOW_WS_in_every_p231); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS17_tree = (object)adaptor.Create(WS17);
            		        			    		adaptor.AddChild(root_0, WS17_tree);
            		        			    	}

            		        			    }
            		        			    break;

            		        			default:
            		        			    if ( cnt9 >= 1 ) goto loop9;
            		        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        		            EarlyExitException eee9 =
            		        		                new EarlyExitException(9, input);
            		        		            throw eee9;
            		        	    }
            		        	    cnt9++;
            		        	} while (true);

            		        	loop9:
            		        		;	// Stops C# compiler whining that label 'loop9' has no statements

            		        	string_literal18=(IToken)Match(input,7,FOLLOW_7_in_every_p234); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal18_tree = (object)adaptor.Create(string_literal18);
            		        		adaptor.AddChild(root_0, string_literal18_tree);
            		        	}
            		        	// TimeDef.g:63:86: ( WS )+
            		        	int cnt10 = 0;
            		        	do 
            		        	{
            		        	    int alt10 = 2;
            		        	    int LA10_0 = input.LA(1);

            		        	    if ( (LA10_0 == WS) )
            		        	    {
            		        	        alt10 = 1;
            		        	    }


            		        	    switch (alt10) 
            		        		{
            		        			case 1 :
            		        			    // TimeDef.g:0:0: WS
            		        			    {
            		        			    	WS19=(IToken)Match(input,WS,FOLLOW_WS_in_every_p236); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS19_tree = (object)adaptor.Create(WS19);
            		        			    		adaptor.AddChild(root_0, WS19_tree);
            		        			    	}

            		        			    }
            		        			    break;

            		        			default:
            		        			    if ( cnt10 >= 1 ) goto loop10;
            		        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        		            EarlyExitException eee10 =
            		        		                new EarlyExitException(10, input);
            		        		            throw eee10;
            		        	    }
            		        	    cnt10++;
            		        	} while (true);

            		        	loop10:
            		        		;	// Stops C# compiler whining that label 'loop10' has no statements

            		        	PushFollow(FOLLOW_timespan_p_in_every_p241);
            		        	duration = timespan_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, duration.Tree);

            		        }
            		        break;

            		}


            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new IntervalSchedule(((interval != null) ? interval.value : default(TimeSpan)), duration==null ? TimeSpan.Zero : ((duration != null) ? duration.value : default(TimeSpan)), sync==null ? DateTime.MinValue : ((sync != null) ? sync.value : default(DateTime))); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "every_p"

    public class cron_p_return : ParserRuleReturnScope
    {
        public CronSchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "cron_p"
    // TimeDef.g:66:1: cron_p returns [CronSchedule value] : ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) ;
    public TimeDefParser.cron_p_return cron_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_p_return retval = new TimeDefParser.cron_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal20 = null;
        IToken WS21 = null;
        IToken WS22 = null;
        IToken WS23 = null;
        IToken WS24 = null;
        IToken WS25 = null;
        IToken WS26 = null;
        IToken string_literal27 = null;
        IToken WS28 = null;
        TimeDefParser.cron_field_p_return minute = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.cron_field_p_return hour = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.cron_field_p_return day = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.cron_field_p_return month = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.cron_field_p_return dow = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        object string_literal20_tree=null;
        object WS21_tree=null;
        object WS22_tree=null;
        object WS23_tree=null;
        object WS24_tree=null;
        object WS25_tree=null;
        object WS26_tree=null;
        object string_literal27_tree=null;
        object WS28_tree=null;

        try 
    	{
            // TimeDef.g:66:36: ( ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:66:38: ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:66:38: ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:67:4: 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		string_literal20=(IToken)Match(input,10,FOLLOW_10_in_cron_p263); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{string_literal20_tree = (object)adaptor.Create(string_literal20);
            			adaptor.AddChild(root_0, string_literal20_tree);
            		}
            		// TimeDef.g:67:11: ( WS )+
            		int cnt12 = 0;
            		do 
            		{
            		    int alt12 = 2;
            		    int LA12_0 = input.LA(1);

            		    if ( (LA12_0 == WS) )
            		    {
            		        alt12 = 1;
            		    }


            		    switch (alt12) 
            			{
            				case 1 :
            				    // TimeDef.g:0:0: WS
            				    {
            				    	WS21=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p265); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS21_tree = (object)adaptor.Create(WS21);
            				    		adaptor.AddChild(root_0, WS21_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    if ( cnt12 >= 1 ) goto loop12;
            				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			            EarlyExitException eee12 =
            			                new EarlyExitException(12, input);
            			            throw eee12;
            		    }
            		    cnt12++;
            		} while (true);

            		loop12:
            			;	// Stops C# compiler whining that label 'loop12' has no statements

            		PushFollow(FOLLOW_cron_field_p_in_cron_p273);
            		minute = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, minute.Tree);
            		// TimeDef.g:68:24: ( WS )+
            		int cnt13 = 0;
            		do 
            		{
            		    int alt13 = 2;
            		    int LA13_0 = input.LA(1);

            		    if ( (LA13_0 == WS) )
            		    {
            		        alt13 = 1;
            		    }


            		    switch (alt13) 
            			{
            				case 1 :
            				    // TimeDef.g:0:0: WS
            				    {
            				    	WS22=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p275); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS22_tree = (object)adaptor.Create(WS22);
            				    		adaptor.AddChild(root_0, WS22_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    if ( cnt13 >= 1 ) goto loop13;
            				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			            EarlyExitException eee13 =
            			                new EarlyExitException(13, input);
            			            throw eee13;
            		    }
            		    cnt13++;
            		} while (true);

            		loop13:
            			;	// Stops C# compiler whining that label 'loop13' has no statements

            		PushFollow(FOLLOW_cron_field_p_in_cron_p283);
            		hour = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, hour.Tree);
            		// TimeDef.g:69:22: ( WS )+
            		int cnt14 = 0;
            		do 
            		{
            		    int alt14 = 2;
            		    int LA14_0 = input.LA(1);

            		    if ( (LA14_0 == WS) )
            		    {
            		        alt14 = 1;
            		    }


            		    switch (alt14) 
            			{
            				case 1 :
            				    // TimeDef.g:0:0: WS
            				    {
            				    	WS23=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p285); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS23_tree = (object)adaptor.Create(WS23);
            				    		adaptor.AddChild(root_0, WS23_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    if ( cnt14 >= 1 ) goto loop14;
            				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			            EarlyExitException eee14 =
            			                new EarlyExitException(14, input);
            			            throw eee14;
            		    }
            		    cnt14++;
            		} while (true);

            		loop14:
            			;	// Stops C# compiler whining that label 'loop14' has no statements

            		PushFollow(FOLLOW_cron_field_p_in_cron_p293);
            		day = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, day.Tree);
            		// TimeDef.g:70:21: ( WS )+
            		int cnt15 = 0;
            		do 
            		{
            		    int alt15 = 2;
            		    int LA15_0 = input.LA(1);

            		    if ( (LA15_0 == WS) )
            		    {
            		        alt15 = 1;
            		    }


            		    switch (alt15) 
            			{
            				case 1 :
            				    // TimeDef.g:0:0: WS
            				    {
            				    	WS24=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p295); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS24_tree = (object)adaptor.Create(WS24);
            				    		adaptor.AddChild(root_0, WS24_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    if ( cnt15 >= 1 ) goto loop15;
            				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			            EarlyExitException eee15 =
            			                new EarlyExitException(15, input);
            			            throw eee15;
            		    }
            		    cnt15++;
            		} while (true);

            		loop15:
            			;	// Stops C# compiler whining that label 'loop15' has no statements

            		PushFollow(FOLLOW_cron_field_p_in_cron_p303);
            		month = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, month.Tree);
            		// TimeDef.g:71:23: ( WS )+
            		int cnt16 = 0;
            		do 
            		{
            		    int alt16 = 2;
            		    int LA16_0 = input.LA(1);

            		    if ( (LA16_0 == WS) )
            		    {
            		        alt16 = 1;
            		    }


            		    switch (alt16) 
            			{
            				case 1 :
            				    // TimeDef.g:0:0: WS
            				    {
            				    	WS25=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p305); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS25_tree = (object)adaptor.Create(WS25);
            				    		adaptor.AddChild(root_0, WS25_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    if ( cnt16 >= 1 ) goto loop16;
            				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			            EarlyExitException eee16 =
            			                new EarlyExitException(16, input);
            			            throw eee16;
            		    }
            		    cnt16++;
            		} while (true);

            		loop16:
            			;	// Stops C# compiler whining that label 'loop16' has no statements

            		PushFollow(FOLLOW_cron_field_p_in_cron_p313);
            		dow = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dow.Tree);
            		// TimeDef.g:73:4: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            		int alt19 = 2;
            		alt19 = dfa19.Predict(input);
            		switch (alt19) 
            		{
            		    case 1 :
            		        // TimeDef.g:73:5: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
            		        {
            		        	// TimeDef.g:73:5: ( WS )+
            		        	int cnt17 = 0;
            		        	do 
            		        	{
            		        	    int alt17 = 2;
            		        	    int LA17_0 = input.LA(1);

            		        	    if ( (LA17_0 == WS) )
            		        	    {
            		        	        alt17 = 1;
            		        	    }


            		        	    switch (alt17) 
            		        		{
            		        			case 1 :
            		        			    // TimeDef.g:0:0: WS
            		        			    {
            		        			    	WS26=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p319); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS26_tree = (object)adaptor.Create(WS26);
            		        			    		adaptor.AddChild(root_0, WS26_tree);
            		        			    	}

            		        			    }
            		        			    break;

            		        			default:
            		        			    if ( cnt17 >= 1 ) goto loop17;
            		        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        		            EarlyExitException eee17 =
            		        		                new EarlyExitException(17, input);
            		        		            throw eee17;
            		        	    }
            		        	    cnt17++;
            		        	} while (true);

            		        	loop17:
            		        		;	// Stops C# compiler whining that label 'loop17' has no statements

            		        	string_literal27=(IToken)Match(input,7,FOLLOW_7_in_cron_p322); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal27_tree = (object)adaptor.Create(string_literal27);
            		        		adaptor.AddChild(root_0, string_literal27_tree);
            		        	}
            		        	// TimeDef.g:73:19: ( WS )+
            		        	int cnt18 = 0;
            		        	do 
            		        	{
            		        	    int alt18 = 2;
            		        	    int LA18_0 = input.LA(1);

            		        	    if ( (LA18_0 == WS) )
            		        	    {
            		        	        alt18 = 1;
            		        	    }


            		        	    switch (alt18) 
            		        		{
            		        			case 1 :
            		        			    // TimeDef.g:0:0: WS
            		        			    {
            		        			    	WS28=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p324); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS28_tree = (object)adaptor.Create(WS28);
            		        			    		adaptor.AddChild(root_0, WS28_tree);
            		        			    	}

            		        			    }
            		        			    break;

            		        			default:
            		        			    if ( cnt18 >= 1 ) goto loop18;
            		        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        		            EarlyExitException eee18 =
            		        		                new EarlyExitException(18, input);
            		        		            throw eee18;
            		        	    }
            		        	    cnt18++;
            		        	} while (true);

            		        	loop18:
            		        		;	// Stops C# compiler whining that label 'loop18' has no statements

            		        	PushFollow(FOLLOW_timespan_p_in_cron_p329);
            		        	duration = timespan_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, duration.Tree);

            		        }
            		        break;

            		}


            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new CronSchedule(((minute != null) ? input.ToString((IToken)(minute.Start),(IToken)(minute.Stop)) : null), ((hour != null) ? input.ToString((IToken)(hour.Start),(IToken)(hour.Stop)) : null), ((day != null) ? input.ToString((IToken)(day.Start),(IToken)(day.Stop)) : null), ((month != null) ? input.ToString((IToken)(month.Start),(IToken)(month.Stop)) : null), ((dow != null) ? input.ToString((IToken)(dow.Start),(IToken)(dow.Stop)) : null), duration==null ? TimeSpan.Zero : ((duration != null) ? duration.value : default(TimeSpan))); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cron_p"

    public class dayofweek_p_return : ParserRuleReturnScope
    {
        public DayOfWeekSchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "dayofweek_p"
    // TimeDef.g:76:1: dayofweek_p returns [DayOfWeekSchedule value] : ( 'week' ( WS )+ ordinal= intspec_p ( WS )+ dayofweek= intspec_p ) ;
    public TimeDefParser.dayofweek_p_return dayofweek_p() // throws RecognitionException [1]
    {   
        TimeDefParser.dayofweek_p_return retval = new TimeDefParser.dayofweek_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal29 = null;
        IToken WS30 = null;
        IToken WS31 = null;
        TimeDefParser.intspec_p_return ordinal = default(TimeDefParser.intspec_p_return);

        TimeDefParser.intspec_p_return dayofweek = default(TimeDefParser.intspec_p_return);


        object string_literal29_tree=null;
        object WS30_tree=null;
        object WS31_tree=null;

        try 
    	{
            // TimeDef.g:76:46: ( ( 'week' ( WS )+ ordinal= intspec_p ( WS )+ dayofweek= intspec_p ) )
            // TimeDef.g:76:48: ( 'week' ( WS )+ ordinal= intspec_p ( WS )+ dayofweek= intspec_p )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:76:48: ( 'week' ( WS )+ ordinal= intspec_p ( WS )+ dayofweek= intspec_p )
            	// TimeDef.g:77:4: 'week' ( WS )+ ordinal= intspec_p ( WS )+ dayofweek= intspec_p
            	{
            		string_literal29=(IToken)Match(input,11,FOLLOW_11_in_dayofweek_p351); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{string_literal29_tree = (object)adaptor.Create(string_literal29);
            			adaptor.AddChild(root_0, string_literal29_tree);
            		}
            		// TimeDef.g:77:11: ( WS )+
            		int cnt20 = 0;
            		do 
            		{
            		    int alt20 = 2;
            		    int LA20_0 = input.LA(1);

            		    if ( (LA20_0 == WS) )
            		    {
            		        alt20 = 1;
            		    }


            		    switch (alt20) 
            			{
            				case 1 :
            				    // TimeDef.g:0:0: WS
            				    {
            				    	WS30=(IToken)Match(input,WS,FOLLOW_WS_in_dayofweek_p353); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS30_tree = (object)adaptor.Create(WS30);
            				    		adaptor.AddChild(root_0, WS30_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    if ( cnt20 >= 1 ) goto loop20;
            				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			            EarlyExitException eee20 =
            			                new EarlyExitException(20, input);
            			            throw eee20;
            		    }
            		    cnt20++;
            		} while (true);

            		loop20:
            			;	// Stops C# compiler whining that label 'loop20' has no statements

            		PushFollow(FOLLOW_intspec_p_in_dayofweek_p358);
            		ordinal = intspec_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ordinal.Tree);
            		// TimeDef.g:77:33: ( WS )+
            		int cnt21 = 0;
            		do 
            		{
            		    int alt21 = 2;
            		    int LA21_0 = input.LA(1);

            		    if ( (LA21_0 == WS) )
            		    {
            		        alt21 = 1;
            		    }


            		    switch (alt21) 
            			{
            				case 1 :
            				    // TimeDef.g:0:0: WS
            				    {
            				    	WS31=(IToken)Match(input,WS,FOLLOW_WS_in_dayofweek_p360); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS31_tree = (object)adaptor.Create(WS31);
            				    		adaptor.AddChild(root_0, WS31_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    if ( cnt21 >= 1 ) goto loop21;
            				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			            EarlyExitException eee21 =
            			                new EarlyExitException(21, input);
            			            throw eee21;
            		    }
            		    cnt21++;
            		} while (true);

            		loop21:
            			;	// Stops C# compiler whining that label 'loop21' has no statements

            		PushFollow(FOLLOW_intspec_p_in_dayofweek_p365);
            		dayofweek = intspec_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dayofweek.Tree);

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new DayOfWeekSchedule(((ordinal != null) ? input.ToString((IToken)(ordinal.Start),(IToken)(ordinal.Stop)) : null), ((dayofweek != null) ? input.ToString((IToken)(dayofweek.Start),(IToken)(dayofweek.Stop)) : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "dayofweek_p"

    public class void_p_return : ParserRuleReturnScope
    {
        public VoidSchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "void_p"
    // TimeDef.g:80:1: void_p returns [VoidSchedule value] : 'void' ;
    public TimeDefParser.void_p_return void_p() // throws RecognitionException [1]
    {   
        TimeDefParser.void_p_return retval = new TimeDefParser.void_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal32 = null;

        object string_literal32_tree=null;

        try 
    	{
            // TimeDef.g:80:36: ( 'void' )
            // TimeDef.g:81:4: 'void'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal32=(IToken)Match(input,12,FOLLOW_12_in_void_p383); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal32_tree = (object)adaptor.Create(string_literal32);
            		adaptor.AddChild(root_0, string_literal32_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  new VoidSchedule(); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "void_p"

    public class paren_p_return : ParserRuleReturnScope
    {
        public ISchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "paren_p"
    // TimeDef.g:83:1: paren_p returns [ISchedule value] : ( '(' expr ')' ) ;
    public TimeDefParser.paren_p_return paren_p() // throws RecognitionException [1]
    {   
        TimeDefParser.paren_p_return retval = new TimeDefParser.paren_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal33 = null;
        IToken char_literal35 = null;
        TimeDefParser.expr_return expr34 = default(TimeDefParser.expr_return);


        object char_literal33_tree=null;
        object char_literal35_tree=null;

        try 
    	{
            // TimeDef.g:83:34: ( ( '(' expr ')' ) )
            // TimeDef.g:83:36: ( '(' expr ')' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:83:36: ( '(' expr ')' )
            	// TimeDef.g:84:4: '(' expr ')'
            	{
            		char_literal33=(IToken)Match(input,13,FOLLOW_13_in_paren_p401); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal33_tree = (object)adaptor.Create(char_literal33);
            			adaptor.AddChild(root_0, char_literal33_tree);
            		}
            		PushFollow(FOLLOW_expr_in_paren_p403);
            		expr34 = expr();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr34.Tree);
            		char_literal35=(IToken)Match(input,14,FOLLOW_14_in_paren_p405); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal35_tree = (object)adaptor.Create(char_literal35);
            			adaptor.AddChild(root_0, char_literal35_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((expr34 != null) ? expr34.value : default(ISchedule)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "paren_p"

    public class filter_p_return : ParserRuleReturnScope
    {
        public ISchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "filter_p"
    // TimeDef.g:91:1: filter_p returns [ISchedule value] : A= atom ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )* ;
    public TimeDefParser.filter_p_return filter_p() // throws RecognitionException [1]
    {   
        TimeDefParser.filter_p_return retval = new TimeDefParser.filter_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken repeatcount = null;
        IToken op = null;
        IToken WS36 = null;
        IToken char_literal37 = null;
        IToken WS38 = null;
        IToken WS39 = null;
        IToken char_literal40 = null;
        IToken WS41 = null;
        IToken WS42 = null;
        IToken WS43 = null;
        IToken WS44 = null;
        IToken string_literal45 = null;
        IToken WS46 = null;
        TimeDefParser.atom_return A = default(TimeDefParser.atom_return);

        TimeDefParser.intspec_p_return index_intspec = default(TimeDefParser.intspec_p_return);

        TimeDefParser.timespan_p_return offset_timespan = default(TimeDefParser.timespan_p_return);

        TimeDefParser.timespan_p_return lasting_timespan = default(TimeDefParser.timespan_p_return);


        object repeatcount_tree=null;
        object op_tree=null;
        object WS36_tree=null;
        object char_literal37_tree=null;
        object WS38_tree=null;
        object WS39_tree=null;
        object char_literal40_tree=null;
        object WS41_tree=null;
        object WS42_tree=null;
        object WS43_tree=null;
        object WS44_tree=null;
        object string_literal45_tree=null;
        object WS46_tree=null;

        try 
    	{
            // TimeDef.g:91:35: (A= atom ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )* )
            // TimeDef.g:92:4: A= atom ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_filter_p429);
            	A = atom();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:92:34: ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*
            	do 
            	{
            	    int alt30 = 5;
            	    alt30 = dfa30.Predict(input);
            	    switch (alt30) 
            		{
            			case 1 :
            			    // TimeDef.g:93:7: ( ( WS )* '#' ( WS )* index_intspec= intspec_p )
            			    {
            			    	// TimeDef.g:93:7: ( ( WS )* '#' ( WS )* index_intspec= intspec_p )
            			    	// TimeDef.g:93:8: ( WS )* '#' ( WS )* index_intspec= intspec_p
            			    	{
            			    		// TimeDef.g:93:8: ( WS )*
            			    		do 
            			    		{
            			    		    int alt22 = 2;
            			    		    int LA22_0 = input.LA(1);

            			    		    if ( (LA22_0 == WS) )
            			    		    {
            			    		        alt22 = 1;
            			    		    }


            			    		    switch (alt22) 
            			    			{
            			    				case 1 :
            			    				    // TimeDef.g:0:0: WS
            			    				    {
            			    				    	WS36=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p442); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS36_tree = (object)adaptor.Create(WS36);
            			    				    		adaptor.AddChild(root_0, WS36_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop22;
            			    		    }
            			    		} while (true);

            			    		loop22:
            			    			;	// Stops C# compiler whining that label 'loop22' has no statements

            			    		char_literal37=(IToken)Match(input,15,FOLLOW_15_in_filter_p445); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal37_tree = (object)adaptor.Create(char_literal37);
            			    			adaptor.AddChild(root_0, char_literal37_tree);
            			    		}
            			    		// TimeDef.g:93:16: ( WS )*
            			    		do 
            			    		{
            			    		    int alt23 = 2;
            			    		    int LA23_0 = input.LA(1);

            			    		    if ( (LA23_0 == WS) )
            			    		    {
            			    		        alt23 = 1;
            			    		    }


            			    		    switch (alt23) 
            			    			{
            			    				case 1 :
            			    				    // TimeDef.g:0:0: WS
            			    				    {
            			    				    	WS38=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p447); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS38_tree = (object)adaptor.Create(WS38);
            			    				    		adaptor.AddChild(root_0, WS38_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop23;
            			    		    }
            			    		} while (true);

            			    		loop23:
            			    			;	// Stops C# compiler whining that label 'loop23' has no statements

            			    		PushFollow(FOLLOW_intspec_p_in_filter_p452);
            			    		index_intspec = intspec_p();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, index_intspec.Tree);
            			    		if ( (state.backtracking==0) )
            			    		{
            			    		   retval.value =  new IndexSchedule(((index_intspec != null) ? input.ToString((IToken)(index_intspec.Start),(IToken)(index_intspec.Stop)) : null), retval.value); 
            			    		}

            			    	}


            			    }
            			    break;
            			case 2 :
            			    // TimeDef.g:94:7: ( ( WS )* 'x' ( WS )* repeatcount= UINT )
            			    {
            			    	// TimeDef.g:94:7: ( ( WS )* 'x' ( WS )* repeatcount= UINT )
            			    	// TimeDef.g:94:8: ( WS )* 'x' ( WS )* repeatcount= UINT
            			    	{
            			    		// TimeDef.g:94:8: ( WS )*
            			    		do 
            			    		{
            			    		    int alt24 = 2;
            			    		    int LA24_0 = input.LA(1);

            			    		    if ( (LA24_0 == WS) )
            			    		    {
            			    		        alt24 = 1;
            			    		    }


            			    		    switch (alt24) 
            			    			{
            			    				case 1 :
            			    				    // TimeDef.g:0:0: WS
            			    				    {
            			    				    	WS39=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p467); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS39_tree = (object)adaptor.Create(WS39);
            			    				    		adaptor.AddChild(root_0, WS39_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop24;
            			    		    }
            			    		} while (true);

            			    		loop24:
            			    			;	// Stops C# compiler whining that label 'loop24' has no statements

            			    		char_literal40=(IToken)Match(input,16,FOLLOW_16_in_filter_p470); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal40_tree = (object)adaptor.Create(char_literal40);
            			    			adaptor.AddChild(root_0, char_literal40_tree);
            			    		}
            			    		// TimeDef.g:94:16: ( WS )*
            			    		do 
            			    		{
            			    		    int alt25 = 2;
            			    		    int LA25_0 = input.LA(1);

            			    		    if ( (LA25_0 == WS) )
            			    		    {
            			    		        alt25 = 1;
            			    		    }


            			    		    switch (alt25) 
            			    			{
            			    				case 1 :
            			    				    // TimeDef.g:0:0: WS
            			    				    {
            			    				    	WS41=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p472); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS41_tree = (object)adaptor.Create(WS41);
            			    				    		adaptor.AddChild(root_0, WS41_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop25;
            			    		    }
            			    		} while (true);

            			    		loop25:
            			    			;	// Stops C# compiler whining that label 'loop25' has no statements

            			    		repeatcount=(IToken)Match(input,UINT,FOLLOW_UINT_in_filter_p477); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{repeatcount_tree = (object)adaptor.Create(repeatcount);
            			    			adaptor.AddChild(root_0, repeatcount_tree);
            			    		}
            			    		if ( (state.backtracking==0) )
            			    		{
            			    		   retval.value =  new RepeatSchedule(int.Parse(((repeatcount != null) ? repeatcount.Text : null)), retval.value); 
            			    		}

            			    	}


            			    }
            			    break;
            			case 3 :
            			    // TimeDef.g:95:7: ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p )
            			    {
            			    	// TimeDef.g:95:7: ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p )
            			    	// TimeDef.g:95:8: ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p
            			    	{
            			    		// TimeDef.g:95:8: ( WS )*
            			    		do 
            			    		{
            			    		    int alt26 = 2;
            			    		    int LA26_0 = input.LA(1);

            			    		    if ( (LA26_0 == WS) )
            			    		    {
            			    		        alt26 = 1;
            			    		    }


            			    		    switch (alt26) 
            			    			{
            			    				case 1 :
            			    				    // TimeDef.g:0:0: WS
            			    				    {
            			    				    	WS42=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p492); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS42_tree = (object)adaptor.Create(WS42);
            			    				    		adaptor.AddChild(root_0, WS42_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop26;
            			    		    }
            			    		} while (true);

            			    		loop26:
            			    			;	// Stops C# compiler whining that label 'loop26' has no statements

            			    		op = (IToken)input.LT(1);
            			    		if ( (input.LA(1) >= 17 && input.LA(1) <= 18) ) 
            			    		{
            			    		    input.Consume();
            			    		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(op));
            			    		    state.errorRecovery = false;state.failed = false;
            			    		}
            			    		else 
            			    		{
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    		    throw mse;
            			    		}

            			    		// TimeDef.g:95:25: ( WS )*
            			    		do 
            			    		{
            			    		    int alt27 = 2;
            			    		    int LA27_0 = input.LA(1);

            			    		    if ( (LA27_0 == WS) )
            			    		    {
            			    		        alt27 = 1;
            			    		    }


            			    		    switch (alt27) 
            			    			{
            			    				case 1 :
            			    				    // TimeDef.g:0:0: WS
            			    				    {
            			    				    	WS43=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p503); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS43_tree = (object)adaptor.Create(WS43);
            			    				    		adaptor.AddChild(root_0, WS43_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop27;
            			    		    }
            			    		} while (true);

            			    		loop27:
            			    			;	// Stops C# compiler whining that label 'loop27' has no statements

            			    		PushFollow(FOLLOW_timespan_p_in_filter_p508);
            			    		offset_timespan = timespan_p();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, offset_timespan.Tree);
            			    		if ( (state.backtracking==0) )
            			    		{
            			    		   retval.value =  new OffsetSchedule(op.Text == "+" ? ((offset_timespan != null) ? offset_timespan.value : default(TimeSpan)) : ((offset_timespan != null) ? offset_timespan.value : default(TimeSpan)).Negate(), retval.value); 
            			    		}

            			    	}


            			    }
            			    break;
            			case 4 :
            			    // TimeDef.g:96:7: ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p )
            			    {
            			    	// TimeDef.g:96:7: ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p )
            			    	// TimeDef.g:96:8: ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p
            			    	{
            			    		// TimeDef.g:96:8: ( WS )+
            			    		int cnt28 = 0;
            			    		do 
            			    		{
            			    		    int alt28 = 2;
            			    		    int LA28_0 = input.LA(1);

            			    		    if ( (LA28_0 == WS) )
            			    		    {
            			    		        alt28 = 1;
            			    		    }


            			    		    switch (alt28) 
            			    			{
            			    				case 1 :
            			    				    // TimeDef.g:0:0: WS
            			    				    {
            			    				    	WS44=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p523); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS44_tree = (object)adaptor.Create(WS44);
            			    				    		adaptor.AddChild(root_0, WS44_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    if ( cnt28 >= 1 ) goto loop28;
            			    				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    			            EarlyExitException eee28 =
            			    			                new EarlyExitException(28, input);
            			    			            throw eee28;
            			    		    }
            			    		    cnt28++;
            			    		} while (true);

            			    		loop28:
            			    			;	// Stops C# compiler whining that label 'loop28' has no statements

            			    		string_literal45=(IToken)Match(input,7,FOLLOW_7_in_filter_p526); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{string_literal45_tree = (object)adaptor.Create(string_literal45);
            			    			adaptor.AddChild(root_0, string_literal45_tree);
            			    		}
            			    		// TimeDef.g:96:22: ( WS )+
            			    		int cnt29 = 0;
            			    		do 
            			    		{
            			    		    int alt29 = 2;
            			    		    int LA29_0 = input.LA(1);

            			    		    if ( (LA29_0 == WS) )
            			    		    {
            			    		        alt29 = 1;
            			    		    }


            			    		    switch (alt29) 
            			    			{
            			    				case 1 :
            			    				    // TimeDef.g:0:0: WS
            			    				    {
            			    				    	WS46=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p528); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS46_tree = (object)adaptor.Create(WS46);
            			    				    		adaptor.AddChild(root_0, WS46_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    if ( cnt29 >= 1 ) goto loop29;
            			    				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    			            EarlyExitException eee29 =
            			    			                new EarlyExitException(29, input);
            			    			            throw eee29;
            			    		    }
            			    		    cnt29++;
            			    		} while (true);

            			    		loop29:
            			    			;	// Stops C# compiler whining that label 'loop29' has no statements

            			    		PushFollow(FOLLOW_timespan_p_in_filter_p533);
            			    		lasting_timespan = timespan_p();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lasting_timespan.Tree);
            			    		if ( (state.backtracking==0) )
            			    		{
            			    		   retval.value =  new LastingSchedule(((lasting_timespan != null) ? lasting_timespan.value : default(TimeSpan)), retval.value); 
            			    		}

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop30;
            	    }
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whining that label 'loop30' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "filter_p"

    public class expr_return : ParserRuleReturnScope
    {
        public ISchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr"
    // TimeDef.g:101:1: expr returns [ISchedule value] : ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* ) ;
    public TimeDefParser.expr_return expr() // throws RecognitionException [1]
    {   
        TimeDefParser.expr_return retval = new TimeDefParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS47 = null;
        IToken WS48 = null;
        IToken char_literal49 = null;
        IToken WS50 = null;
        IToken WS51 = null;
        TimeDefParser.boolnonintersection_p_return A = default(TimeDefParser.boolnonintersection_p_return);

        TimeDefParser.boolnonintersection_p_return B = default(TimeDefParser.boolnonintersection_p_return);


        object WS47_tree=null;
        object WS48_tree=null;
        object char_literal49_tree=null;
        object WS50_tree=null;
        object WS51_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:105:1: ( ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* ) )
            // TimeDef.g:105:3: ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:105:3: ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* )
            	// TimeDef.g:106:4: ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )*
            	{
            		// TimeDef.g:106:4: ( WS )*
            		do 
            		{
            		    int alt31 = 2;
            		    int LA31_0 = input.LA(1);

            		    if ( (LA31_0 == WS) )
            		    {
            		        alt31 = 1;
            		    }


            		    switch (alt31) 
            			{
            				case 1 :
            				    // TimeDef.g:0:0: WS
            				    {
            				    	WS47=(IToken)Match(input,WS,FOLLOW_WS_in_expr567); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS47_tree = (object)adaptor.Create(WS47);
            				    		adaptor.AddChild(root_0, WS47_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    goto loop31;
            		    }
            		} while (true);

            		loop31:
            			;	// Stops C# compiler whining that label 'loop31' has no statements

            		PushFollow(FOLLOW_boolnonintersection_p_in_expr572);
            		A = boolnonintersection_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:107:4: ( ( WS )* ',' ( WS )* B= boolnonintersection_p )*
            		do 
            		{
            		    int alt34 = 2;
            		    alt34 = dfa34.Predict(input);
            		    switch (alt34) 
            			{
            				case 1 :
            				    // TimeDef.g:107:5: ( WS )* ',' ( WS )* B= boolnonintersection_p
            				    {
            				    	// TimeDef.g:107:5: ( WS )*
            				    	do 
            				    	{
            				    	    int alt32 = 2;
            				    	    int LA32_0 = input.LA(1);

            				    	    if ( (LA32_0 == WS) )
            				    	    {
            				    	        alt32 = 1;
            				    	    }


            				    	    switch (alt32) 
            				    		{
            				    			case 1 :
            				    			    // TimeDef.g:0:0: WS
            				    			    {
            				    			    	WS48=(IToken)Match(input,WS,FOLLOW_WS_in_expr580); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS48_tree = (object)adaptor.Create(WS48);
            				    			    		adaptor.AddChild(root_0, WS48_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop32;
            				    	    }
            				    	} while (true);

            				    	loop32:
            				    		;	// Stops C# compiler whining that label 'loop32' has no statements

            				    	char_literal49=(IToken)Match(input,19,FOLLOW_19_in_expr583); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{char_literal49_tree = (object)adaptor.Create(char_literal49);
            				    		adaptor.AddChild(root_0, char_literal49_tree);
            				    	}
            				    	// TimeDef.g:107:13: ( WS )*
            				    	do 
            				    	{
            				    	    int alt33 = 2;
            				    	    int LA33_0 = input.LA(1);

            				    	    if ( (LA33_0 == WS) )
            				    	    {
            				    	        alt33 = 1;
            				    	    }


            				    	    switch (alt33) 
            				    		{
            				    			case 1 :
            				    			    // TimeDef.g:0:0: WS
            				    			    {
            				    			    	WS50=(IToken)Match(input,WS,FOLLOW_WS_in_expr585); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS50_tree = (object)adaptor.Create(WS50);
            				    			    		adaptor.AddChild(root_0, WS50_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop33;
            				    	    }
            				    	} while (true);

            				    	loop33:
            				    		;	// Stops C# compiler whining that label 'loop33' has no statements

            				    	PushFollow(FOLLOW_boolnonintersection_p_in_expr590);
            				    	B = boolnonintersection_p();
            				    	state.followingStackPointer--;
            				    	if (state.failed) return retval;
            				    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, B.Tree);
            				    	if ( (state.backtracking==0) )
            				    	{
            				    	   Schedules.Add(((B != null) ? B.value : default(ISchedule))); 
            				    	}

            				    }
            				    break;

            				default:
            				    goto loop34;
            		    }
            		} while (true);

            		loop34:
            			;	// Stops C# compiler whining that label 'loop34' has no statements

            		// TimeDef.g:107:73: ( WS )*
            		do 
            		{
            		    int alt35 = 2;
            		    int LA35_0 = input.LA(1);

            		    if ( (LA35_0 == WS) )
            		    {
            		        alt35 = 1;
            		    }


            		    switch (alt35) 
            			{
            				case 1 :
            				    // TimeDef.g:0:0: WS
            				    {
            				    	WS51=(IToken)Match(input,WS,FOLLOW_WS_in_expr597); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS51_tree = (object)adaptor.Create(WS51);
            				    		adaptor.AddChild(root_0, WS51_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    goto loop35;
            		    }
            		} while (true);

            		loop35:
            			;	// Stops C# compiler whining that label 'loop35' has no statements


            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  Schedules.Count > 1 ? new ListSchedule(Schedules) : Schedules[0]; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class boolnonintersection_p_return : ParserRuleReturnScope
    {
        public ISchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "boolnonintersection_p"
    // TimeDef.g:113:1: boolnonintersection_p returns [ISchedule value] : A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )* ;
    public TimeDefParser.boolnonintersection_p_return boolnonintersection_p() // throws RecognitionException [1]
    {   
        TimeDefParser.boolnonintersection_p_return retval = new TimeDefParser.boolnonintersection_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS52 = null;
        IToken string_literal53 = null;
        IToken WS54 = null;
        TimeDefParser.boolintersection_p_return A = default(TimeDefParser.boolintersection_p_return);

        TimeDefParser.boolintersection_p_return B = default(TimeDefParser.boolintersection_p_return);


        object WS52_tree=null;
        object string_literal53_tree=null;
        object WS54_tree=null;

        try 
    	{
            // TimeDef.g:113:48: (A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )* )
            // TimeDef.g:114:4: A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_boolintersection_p_in_boolnonintersection_p621);
            	A = boolintersection_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:115:4: ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*
            	do 
            	{
            	    int alt38 = 2;
            	    alt38 = dfa38.Predict(input);
            	    switch (alt38) 
            		{
            			case 1 :
            			    // TimeDef.g:115:5: ( WS )* '!&&' ( WS )* B= boolintersection_p
            			    {
            			    	// TimeDef.g:115:5: ( WS )*
            			    	do 
            			    	{
            			    	    int alt36 = 2;
            			    	    int LA36_0 = input.LA(1);

            			    	    if ( (LA36_0 == WS) )
            			    	    {
            			    	        alt36 = 1;
            			    	    }


            			    	    switch (alt36) 
            			    		{
            			    			case 1 :
            			    			    // TimeDef.g:0:0: WS
            			    			    {
            			    			    	WS52=(IToken)Match(input,WS,FOLLOW_WS_in_boolnonintersection_p629); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS52_tree = (object)adaptor.Create(WS52);
            			    			    		adaptor.AddChild(root_0, WS52_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop36;
            			    	    }
            			    	} while (true);

            			    	loop36:
            			    		;	// Stops C# compiler whining that label 'loop36' has no statements

            			    	string_literal53=(IToken)Match(input,20,FOLLOW_20_in_boolnonintersection_p632); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal53_tree = (object)adaptor.Create(string_literal53);
            			    		adaptor.AddChild(root_0, string_literal53_tree);
            			    	}
            			    	// TimeDef.g:115:15: ( WS )*
            			    	do 
            			    	{
            			    	    int alt37 = 2;
            			    	    int LA37_0 = input.LA(1);

            			    	    if ( (LA37_0 == WS) )
            			    	    {
            			    	        alt37 = 1;
            			    	    }


            			    	    switch (alt37) 
            			    		{
            			    			case 1 :
            			    			    // TimeDef.g:0:0: WS
            			    			    {
            			    			    	WS54=(IToken)Match(input,WS,FOLLOW_WS_in_boolnonintersection_p634); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS54_tree = (object)adaptor.Create(WS54);
            			    			    		adaptor.AddChild(root_0, WS54_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop37;
            			    	    }
            			    	} while (true);

            			    	loop37:
            			    		;	// Stops C# compiler whining that label 'loop37' has no statements

            			    	PushFollow(FOLLOW_boolintersection_p_in_boolnonintersection_p639);
            			    	B = boolintersection_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, B.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   retval.value =  new BoolNonIntersectionSchedule(retval.value, ((B != null) ? B.value : default(ISchedule))); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop38;
            	    }
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whining that label 'loop38' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "boolnonintersection_p"

    public class boolintersection_p_return : ParserRuleReturnScope
    {
        public ISchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "boolintersection_p"
    // TimeDef.g:121:1: boolintersection_p returns [ISchedule value] : A= union_p ( ( WS )* '&&' ( WS )* B= union_p )* ;
    public TimeDefParser.boolintersection_p_return boolintersection_p() // throws RecognitionException [1]
    {   
        TimeDefParser.boolintersection_p_return retval = new TimeDefParser.boolintersection_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS55 = null;
        IToken string_literal56 = null;
        IToken WS57 = null;
        TimeDefParser.union_p_return A = default(TimeDefParser.union_p_return);

        TimeDefParser.union_p_return B = default(TimeDefParser.union_p_return);


        object WS55_tree=null;
        object string_literal56_tree=null;
        object WS57_tree=null;

        try 
    	{
            // TimeDef.g:121:45: (A= union_p ( ( WS )* '&&' ( WS )* B= union_p )* )
            // TimeDef.g:122:4: A= union_p ( ( WS )* '&&' ( WS )* B= union_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_union_p_in_boolintersection_p664);
            	A = union_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:123:4: ( ( WS )* '&&' ( WS )* B= union_p )*
            	do 
            	{
            	    int alt41 = 2;
            	    alt41 = dfa41.Predict(input);
            	    switch (alt41) 
            		{
            			case 1 :
            			    // TimeDef.g:123:5: ( WS )* '&&' ( WS )* B= union_p
            			    {
            			    	// TimeDef.g:123:5: ( WS )*
            			    	do 
            			    	{
            			    	    int alt39 = 2;
            			    	    int LA39_0 = input.LA(1);

            			    	    if ( (LA39_0 == WS) )
            			    	    {
            			    	        alt39 = 1;
            			    	    }


            			    	    switch (alt39) 
            			    		{
            			    			case 1 :
            			    			    // TimeDef.g:0:0: WS
            			    			    {
            			    			    	WS55=(IToken)Match(input,WS,FOLLOW_WS_in_boolintersection_p672); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS55_tree = (object)adaptor.Create(WS55);
            			    			    		adaptor.AddChild(root_0, WS55_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop39;
            			    	    }
            			    	} while (true);

            			    	loop39:
            			    		;	// Stops C# compiler whining that label 'loop39' has no statements

            			    	string_literal56=(IToken)Match(input,21,FOLLOW_21_in_boolintersection_p675); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal56_tree = (object)adaptor.Create(string_literal56);
            			    		adaptor.AddChild(root_0, string_literal56_tree);
            			    	}
            			    	// TimeDef.g:123:14: ( WS )*
            			    	do 
            			    	{
            			    	    int alt40 = 2;
            			    	    int LA40_0 = input.LA(1);

            			    	    if ( (LA40_0 == WS) )
            			    	    {
            			    	        alt40 = 1;
            			    	    }


            			    	    switch (alt40) 
            			    		{
            			    			case 1 :
            			    			    // TimeDef.g:0:0: WS
            			    			    {
            			    			    	WS57=(IToken)Match(input,WS,FOLLOW_WS_in_boolintersection_p677); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS57_tree = (object)adaptor.Create(WS57);
            			    			    		adaptor.AddChild(root_0, WS57_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop40;
            			    	    }
            			    	} while (true);

            			    	loop40:
            			    		;	// Stops C# compiler whining that label 'loop40' has no statements

            			    	PushFollow(FOLLOW_union_p_in_boolintersection_p682);
            			    	B = union_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, B.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   retval.value =  new BoolIntersectionSchedule(retval.value, ((B != null) ? B.value : default(ISchedule))); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "boolintersection_p"

    public class union_p_return : ParserRuleReturnScope
    {
        public ISchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "union_p"
    // TimeDef.g:129:1: union_p returns [ISchedule value] : (A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )* ) ;
    public TimeDefParser.union_p_return union_p() // throws RecognitionException [1]
    {   
        TimeDefParser.union_p_return retval = new TimeDefParser.union_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS58 = null;
        IToken char_literal59 = null;
        IToken WS60 = null;
        TimeDefParser.difference_p_return A = default(TimeDefParser.difference_p_return);

        TimeDefParser.difference_p_return B = default(TimeDefParser.difference_p_return);


        object WS58_tree=null;
        object char_literal59_tree=null;
        object WS60_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:133:1: ( (A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )* ) )
            // TimeDef.g:133:3: (A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:133:3: (A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )* )
            	// TimeDef.g:134:4: A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )*
            	{
            		PushFollow(FOLLOW_difference_p_in_union_p715);
            		A = difference_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:135:4: ( ( WS )* '|' ( WS )* B= difference_p )*
            		do 
            		{
            		    int alt44 = 2;
            		    alt44 = dfa44.Predict(input);
            		    switch (alt44) 
            			{
            				case 1 :
            				    // TimeDef.g:135:5: ( WS )* '|' ( WS )* B= difference_p
            				    {
            				    	// TimeDef.g:135:5: ( WS )*
            				    	do 
            				    	{
            				    	    int alt42 = 2;
            				    	    int LA42_0 = input.LA(1);

            				    	    if ( (LA42_0 == WS) )
            				    	    {
            				    	        alt42 = 1;
            				    	    }


            				    	    switch (alt42) 
            				    		{
            				    			case 1 :
            				    			    // TimeDef.g:0:0: WS
            				    			    {
            				    			    	WS58=(IToken)Match(input,WS,FOLLOW_WS_in_union_p723); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS58_tree = (object)adaptor.Create(WS58);
            				    			    		adaptor.AddChild(root_0, WS58_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop42;
            				    	    }
            				    	} while (true);

            				    	loop42:
            				    		;	// Stops C# compiler whining that label 'loop42' has no statements

            				    	char_literal59=(IToken)Match(input,22,FOLLOW_22_in_union_p726); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{char_literal59_tree = (object)adaptor.Create(char_literal59);
            				    		adaptor.AddChild(root_0, char_literal59_tree);
            				    	}
            				    	// TimeDef.g:135:13: ( WS )*
            				    	do 
            				    	{
            				    	    int alt43 = 2;
            				    	    int LA43_0 = input.LA(1);

            				    	    if ( (LA43_0 == WS) )
            				    	    {
            				    	        alt43 = 1;
            				    	    }


            				    	    switch (alt43) 
            				    		{
            				    			case 1 :
            				    			    // TimeDef.g:0:0: WS
            				    			    {
            				    			    	WS60=(IToken)Match(input,WS,FOLLOW_WS_in_union_p728); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS60_tree = (object)adaptor.Create(WS60);
            				    			    		adaptor.AddChild(root_0, WS60_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop43;
            				    	    }
            				    	} while (true);

            				    	loop43:
            				    		;	// Stops C# compiler whining that label 'loop43' has no statements

            				    	PushFollow(FOLLOW_difference_p_in_union_p733);
            				    	B = difference_p();
            				    	state.followingStackPointer--;
            				    	if (state.failed) return retval;
            				    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, B.Tree);
            				    	if ( (state.backtracking==0) )
            				    	{
            				    	   Schedules.Add(((B != null) ? B.value : default(ISchedule))); 
            				    	}

            				    }
            				    break;

            				default:
            				    goto loop44;
            		    }
            		} while (true);

            		loop44:
            			;	// Stops C# compiler whining that label 'loop44' has no statements


            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  Schedules.Count > 1 ? new UnionSchedule(Schedules) : Schedules[0]; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "union_p"

    public class difference_p_return : ParserRuleReturnScope
    {
        public ISchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "difference_p"
    // TimeDef.g:141:1: difference_p returns [ISchedule value] : (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* ) ;
    public TimeDefParser.difference_p_return difference_p() // throws RecognitionException [1]
    {   
        TimeDefParser.difference_p_return retval = new TimeDefParser.difference_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS61 = null;
        IToken string_literal62 = null;
        IToken WS63 = null;
        TimeDefParser.intersection_p_return A = default(TimeDefParser.intersection_p_return);

        TimeDefParser.intersection_p_return B = default(TimeDefParser.intersection_p_return);


        object WS61_tree=null;
        object string_literal62_tree=null;
        object WS63_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:145:1: ( (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* ) )
            // TimeDef.g:145:3: (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:145:3: (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* )
            	// TimeDef.g:146:4: A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )*
            	{
            		PushFollow(FOLLOW_intersection_p_in_difference_p769);
            		A = intersection_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:147:4: ( ( WS )* '!&' ( WS )* B= intersection_p )*
            		do 
            		{
            		    int alt47 = 2;
            		    alt47 = dfa47.Predict(input);
            		    switch (alt47) 
            			{
            				case 1 :
            				    // TimeDef.g:147:5: ( WS )* '!&' ( WS )* B= intersection_p
            				    {
            				    	// TimeDef.g:147:5: ( WS )*
            				    	do 
            				    	{
            				    	    int alt45 = 2;
            				    	    int LA45_0 = input.LA(1);

            				    	    if ( (LA45_0 == WS) )
            				    	    {
            				    	        alt45 = 1;
            				    	    }


            				    	    switch (alt45) 
            				    		{
            				    			case 1 :
            				    			    // TimeDef.g:0:0: WS
            				    			    {
            				    			    	WS61=(IToken)Match(input,WS,FOLLOW_WS_in_difference_p777); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS61_tree = (object)adaptor.Create(WS61);
            				    			    		adaptor.AddChild(root_0, WS61_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop45;
            				    	    }
            				    	} while (true);

            				    	loop45:
            				    		;	// Stops C# compiler whining that label 'loop45' has no statements

            				    	string_literal62=(IToken)Match(input,23,FOLLOW_23_in_difference_p780); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{string_literal62_tree = (object)adaptor.Create(string_literal62);
            				    		adaptor.AddChild(root_0, string_literal62_tree);
            				    	}
            				    	// TimeDef.g:147:14: ( WS )*
            				    	do 
            				    	{
            				    	    int alt46 = 2;
            				    	    int LA46_0 = input.LA(1);

            				    	    if ( (LA46_0 == WS) )
            				    	    {
            				    	        alt46 = 1;
            				    	    }


            				    	    switch (alt46) 
            				    		{
            				    			case 1 :
            				    			    // TimeDef.g:0:0: WS
            				    			    {
            				    			    	WS63=(IToken)Match(input,WS,FOLLOW_WS_in_difference_p782); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS63_tree = (object)adaptor.Create(WS63);
            				    			    		adaptor.AddChild(root_0, WS63_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop46;
            				    	    }
            				    	} while (true);

            				    	loop46:
            				    		;	// Stops C# compiler whining that label 'loop46' has no statements

            				    	PushFollow(FOLLOW_intersection_p_in_difference_p787);
            				    	B = intersection_p();
            				    	state.followingStackPointer--;
            				    	if (state.failed) return retval;
            				    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, B.Tree);
            				    	if ( (state.backtracking==0) )
            				    	{
            				    	   Schedules.Add(((B != null) ? B.value : default(ISchedule))); 
            				    	}

            				    }
            				    break;

            				default:
            				    goto loop47;
            		    }
            		} while (true);

            		loop47:
            			;	// Stops C# compiler whining that label 'loop47' has no statements


            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  Schedules.Count > 1 ? new DifferenceSchedule(Schedules) : Schedules[0]; 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "difference_p"

    public class intersection_p_return : ParserRuleReturnScope
    {
        public ISchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "intersection_p"
    // TimeDef.g:154:1: intersection_p returns [ISchedule value] : A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )* ;
    public TimeDefParser.intersection_p_return intersection_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intersection_p_return retval = new TimeDefParser.intersection_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS64 = null;
        IToken char_literal65 = null;
        IToken WS66 = null;
        TimeDefParser.filter_p_return A = default(TimeDefParser.filter_p_return);

        TimeDefParser.filter_p_return B = default(TimeDefParser.filter_p_return);


        object WS64_tree=null;
        object char_literal65_tree=null;
        object WS66_tree=null;

        try 
    	{
            // TimeDef.g:154:41: (A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )* )
            // TimeDef.g:155:4: A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_filter_p_in_intersection_p816);
            	A = filter_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:156:4: ( ( WS )* '&' ( WS )* B= filter_p )*
            	do 
            	{
            	    int alt50 = 2;
            	    alt50 = dfa50.Predict(input);
            	    switch (alt50) 
            		{
            			case 1 :
            			    // TimeDef.g:156:5: ( WS )* '&' ( WS )* B= filter_p
            			    {
            			    	// TimeDef.g:156:5: ( WS )*
            			    	do 
            			    	{
            			    	    int alt48 = 2;
            			    	    int LA48_0 = input.LA(1);

            			    	    if ( (LA48_0 == WS) )
            			    	    {
            			    	        alt48 = 1;
            			    	    }


            			    	    switch (alt48) 
            			    		{
            			    			case 1 :
            			    			    // TimeDef.g:0:0: WS
            			    			    {
            			    			    	WS64=(IToken)Match(input,WS,FOLLOW_WS_in_intersection_p824); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS64_tree = (object)adaptor.Create(WS64);
            			    			    		adaptor.AddChild(root_0, WS64_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop48;
            			    	    }
            			    	} while (true);

            			    	loop48:
            			    		;	// Stops C# compiler whining that label 'loop48' has no statements

            			    	char_literal65=(IToken)Match(input,24,FOLLOW_24_in_intersection_p827); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal65_tree = (object)adaptor.Create(char_literal65);
            			    		adaptor.AddChild(root_0, char_literal65_tree);
            			    	}
            			    	// TimeDef.g:156:13: ( WS )*
            			    	do 
            			    	{
            			    	    int alt49 = 2;
            			    	    int LA49_0 = input.LA(1);

            			    	    if ( (LA49_0 == WS) )
            			    	    {
            			    	        alt49 = 1;
            			    	    }


            			    	    switch (alt49) 
            			    		{
            			    			case 1 :
            			    			    // TimeDef.g:0:0: WS
            			    			    {
            			    			    	WS66=(IToken)Match(input,WS,FOLLOW_WS_in_intersection_p829); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS66_tree = (object)adaptor.Create(WS66);
            			    			    		adaptor.AddChild(root_0, WS66_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop49;
            			    	    }
            			    	} while (true);

            			    	loop49:
            			    		;	// Stops C# compiler whining that label 'loop49' has no statements

            			    	PushFollow(FOLLOW_filter_p_in_intersection_p834);
            			    	B = filter_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, B.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   retval.value =  new IntersectionSchedule(retval.value, ((B != null) ? B.value : default(ISchedule))); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop50;
            	    }
            	} while (true);

            	loop50:
            		;	// Stops C# compiler whining that label 'loop50' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "intersection_p"

    public class datetime_p_return : ParserRuleReturnScope
    {
        public DateTime value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "datetime_p"
    // TimeDef.g:162:1: datetime_p returns [DateTime value] : (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? ) ;
    public TimeDefParser.datetime_p_return datetime_p() // throws RecognitionException [1]
    {   
        TimeDefParser.datetime_p_return retval = new TimeDefParser.datetime_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal67 = null;
        IToken char_literal68 = null;
        IToken WS69 = null;
        IToken char_literal70 = null;
        IToken char_literal71 = null;
        IToken char_literal72 = null;
        IToken char_literal73 = null;
        IToken char_literal74 = null;
        IToken char_literal75 = null;
        TimeDefParser.year_p_return y = default(TimeDefParser.year_p_return);

        TimeDefParser.month_p_return mo = default(TimeDefParser.month_p_return);

        TimeDefParser.day_p_return d = default(TimeDefParser.day_p_return);

        TimeDefParser.hour24_p_return h = default(TimeDefParser.hour24_p_return);

        TimeDefParser.minute60_p_return m = default(TimeDefParser.minute60_p_return);

        TimeDefParser.second60_p_return s = default(TimeDefParser.second60_p_return);

        TimeDefParser.millisecond1000_p_return ms = default(TimeDefParser.millisecond1000_p_return);


        object char_literal67_tree=null;
        object char_literal68_tree=null;
        object WS69_tree=null;
        object char_literal70_tree=null;
        object char_literal71_tree=null;
        object char_literal72_tree=null;
        object char_literal73_tree=null;
        object char_literal74_tree=null;
        object char_literal75_tree=null;

        try 
    	{
            // TimeDef.g:162:36: ( (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? ) )
            // TimeDef.g:162:38: (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:162:38: (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )
            	int alt57 = 2;
            	int LA57_0 = input.LA(1);

            	if ( (LA57_0 == UINT) )
            	{
            	    int LA57_1 = input.LA(2);

            	    if ( (LA57_1 == 18) )
            	    {
            	        alt57 = 1;
            	    }
            	    else if ( (LA57_1 == 25) )
            	    {
            	        alt57 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d57s1 =
            	            new NoViableAltException("", 57, 1, input);

            	        throw nvae_d57s1;
            	    }
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d57s0 =
            	        new NoViableAltException("", 57, 0, input);

            	    throw nvae_d57s0;
            	}
            	switch (alt57) 
            	{
            	    case 1 :
            	        // TimeDef.g:163:4: y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?
            	        {
            	        	PushFollow(FOLLOW_year_p_in_datetime_p861);
            	        	y = year_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, y.Tree);
            	        	char_literal67=(IToken)Match(input,18,FOLLOW_18_in_datetime_p863); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal67_tree = (object)adaptor.Create(char_literal67);
            	        		adaptor.AddChild(root_0, char_literal67_tree);
            	        	}
            	        	PushFollow(FOLLOW_month_p_in_datetime_p867);
            	        	mo = month_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mo.Tree);
            	        	char_literal68=(IToken)Match(input,18,FOLLOW_18_in_datetime_p869); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal68_tree = (object)adaptor.Create(char_literal68);
            	        		adaptor.AddChild(root_0, char_literal68_tree);
            	        	}
            	        	PushFollow(FOLLOW_day_p_in_datetime_p873);
            	        	d = day_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, d.Tree);
            	        	// TimeDef.g:163:40: ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?
            	        	int alt54 = 2;
            	        	alt54 = dfa54.Predict(input);
            	        	switch (alt54) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:163:41: ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	        {
            	        	        	// TimeDef.g:163:41: ( WS )+
            	        	        	int cnt51 = 0;
            	        	        	do 
            	        	        	{
            	        	        	    int alt51 = 2;
            	        	        	    int LA51_0 = input.LA(1);

            	        	        	    if ( (LA51_0 == WS) )
            	        	        	    {
            	        	        	        alt51 = 1;
            	        	        	    }


            	        	        	    switch (alt51) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // TimeDef.g:0:0: WS
            	        	        			    {
            	        	        			    	WS69=(IToken)Match(input,WS,FOLLOW_WS_in_datetime_p876); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{WS69_tree = (object)adaptor.Create(WS69);
            	        	        			    		adaptor.AddChild(root_0, WS69_tree);
            	        	        			    	}

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    if ( cnt51 >= 1 ) goto loop51;
            	        	        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	        		            EarlyExitException eee51 =
            	        	        		                new EarlyExitException(51, input);
            	        	        		            throw eee51;
            	        	        	    }
            	        	        	    cnt51++;
            	        	        	} while (true);

            	        	        	loop51:
            	        	        		;	// Stops C# compiler whining that label 'loop51' has no statements

            	        	        	PushFollow(FOLLOW_hour24_p_in_datetime_p881);
            	        	        	h = hour24_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            	        	        	char_literal70=(IToken)Match(input,25,FOLLOW_25_in_datetime_p883); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal70_tree = (object)adaptor.Create(char_literal70);
            	        	        		adaptor.AddChild(root_0, char_literal70_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_minute60_p_in_datetime_p887);
            	        	        	m = minute60_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            	        	        	// TimeDef.g:163:73: ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	        	int alt53 = 2;
            	        	        	int LA53_0 = input.LA(1);

            	        	        	if ( (LA53_0 == 25) )
            	        	        	{
            	        	        	    alt53 = 1;
            	        	        	}
            	        	        	switch (alt53) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // TimeDef.g:163:74: ':' s= second60_p ( '.' ms= millisecond1000_p )?
            	        	        	        {
            	        	        	        	char_literal71=(IToken)Match(input,25,FOLLOW_25_in_datetime_p890); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{char_literal71_tree = (object)adaptor.Create(char_literal71);
            	        	        	        		adaptor.AddChild(root_0, char_literal71_tree);
            	        	        	        	}
            	        	        	        	PushFollow(FOLLOW_second60_p_in_datetime_p894);
            	        	        	        	s = second60_p();
            	        	        	        	state.followingStackPointer--;
            	        	        	        	if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            	        	        	        	// TimeDef.g:163:91: ( '.' ms= millisecond1000_p )?
            	        	        	        	int alt52 = 2;
            	        	        	        	int LA52_0 = input.LA(1);

            	        	        	        	if ( (LA52_0 == 26) )
            	        	        	        	{
            	        	        	        	    alt52 = 1;
            	        	        	        	}
            	        	        	        	switch (alt52) 
            	        	        	        	{
            	        	        	        	    case 1 :
            	        	        	        	        // TimeDef.g:163:92: '.' ms= millisecond1000_p
            	        	        	        	        {
            	        	        	        	        	char_literal72=(IToken)Match(input,26,FOLLOW_26_in_datetime_p897); if (state.failed) return retval;
            	        	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	        	{char_literal72_tree = (object)adaptor.Create(char_literal72);
            	        	        	        	        		adaptor.AddChild(root_0, char_literal72_tree);
            	        	        	        	        	}
            	        	        	        	        	PushFollow(FOLLOW_millisecond1000_p_in_datetime_p901);
            	        	        	        	        	ms = millisecond1000_p();
            	        	        	        	        	state.followingStackPointer--;
            	        	        	        	        	if (state.failed) return retval;
            	        	        	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ms.Tree);

            	        	        	        	        }
            	        	        	        	        break;

            	        	        	        	}


            	        	        	        }
            	        	        	        break;

            	        	        	}


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // TimeDef.g:164:4: h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        {
            	        	PushFollow(FOLLOW_hour24_p_in_datetime_p916);
            	        	h = hour24_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            	        	char_literal73=(IToken)Match(input,25,FOLLOW_25_in_datetime_p918); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal73_tree = (object)adaptor.Create(char_literal73);
            	        		adaptor.AddChild(root_0, char_literal73_tree);
            	        	}
            	        	PushFollow(FOLLOW_minute60_p_in_datetime_p922);
            	        	m = minute60_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            	        	// TimeDef.g:164:32: ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	int alt56 = 2;
            	        	int LA56_0 = input.LA(1);

            	        	if ( (LA56_0 == 25) )
            	        	{
            	        	    alt56 = 1;
            	        	}
            	        	switch (alt56) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:164:33: ':' s= second60_p ( '.' ms= millisecond1000_p )?
            	        	        {
            	        	        	char_literal74=(IToken)Match(input,25,FOLLOW_25_in_datetime_p925); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal74_tree = (object)adaptor.Create(char_literal74);
            	        	        		adaptor.AddChild(root_0, char_literal74_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_second60_p_in_datetime_p929);
            	        	        	s = second60_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            	        	        	// TimeDef.g:164:50: ( '.' ms= millisecond1000_p )?
            	        	        	int alt55 = 2;
            	        	        	int LA55_0 = input.LA(1);

            	        	        	if ( (LA55_0 == 26) )
            	        	        	{
            	        	        	    alt55 = 1;
            	        	        	}
            	        	        	switch (alt55) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // TimeDef.g:164:51: '.' ms= millisecond1000_p
            	        	        	        {
            	        	        	        	char_literal75=(IToken)Match(input,26,FOLLOW_26_in_datetime_p932); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{char_literal75_tree = (object)adaptor.Create(char_literal75);
            	        	        	        		adaptor.AddChild(root_0, char_literal75_tree);
            	        	        	        	}
            	        	        	        	PushFollow(FOLLOW_millisecond1000_p_in_datetime_p936);
            	        	        	        	ms = millisecond1000_p();
            	        	        	        	state.followingStackPointer--;
            	        	        	        	if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ms.Tree);

            	        	        	        }
            	        	        	        break;

            	        	        	}


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	if ( (state.backtracking==0) )
            	{

            	     retval.value =  new DateTime(
            	        y==null ? DateTime.UtcNow.Year : ((y != null) ? y.value : default(int)),
            	        mo==null ? DateTime.UtcNow.Month : ((mo != null) ? mo.value : default(int)),
            	        d==null ? DateTime.UtcNow.Day : ((d != null) ? d.value : default(int)),
            	        h==null ? 0 : ((h != null) ? h.value : default(int)),
            	        m==null ? 0 : ((m != null) ? m.value : default(int)),
            	        s==null ? 0 : ((s != null) ? s.value : default(int)),
            	        ms==null ? 0 : ((ms != null) ? ms.value : default(int)));

            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "datetime_p"

    public class datetime_prog_return : ParserRuleReturnScope
    {
        public DateTime value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "datetime_prog"
    // TimeDef.g:176:1: datetime_prog returns [DateTime value] : ( datetime_p EOF ) ;
    public TimeDefParser.datetime_prog_return datetime_prog() // throws RecognitionException [1]
    {   
        TimeDefParser.datetime_prog_return retval = new TimeDefParser.datetime_prog_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF77 = null;
        TimeDefParser.datetime_p_return datetime_p76 = default(TimeDefParser.datetime_p_return);


        object EOF77_tree=null;

        try 
    	{
            // TimeDef.g:176:39: ( ( datetime_p EOF ) )
            // TimeDef.g:176:41: ( datetime_p EOF )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:176:41: ( datetime_p EOF )
            	// TimeDef.g:177:4: datetime_p EOF
            	{
            		PushFollow(FOLLOW_datetime_p_in_datetime_prog960);
            		datetime_p76 = datetime_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, datetime_p76.Tree);
            		EOF77=(IToken)Match(input,EOF,FOLLOW_EOF_in_datetime_prog962); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{EOF77_tree = (object)adaptor.Create(EOF77);
            			adaptor.AddChild(root_0, EOF77_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((datetime_p76 != null) ? datetime_p76.value : default(DateTime)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "datetime_prog"

    public class year_p_return : ParserRuleReturnScope
    {
        public int value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "year_p"
    // TimeDef.g:180:1: year_p returns [int value] : UINT ;
    public TimeDefParser.year_p_return year_p() // throws RecognitionException [1]
    {   
        TimeDefParser.year_p_return retval = new TimeDefParser.year_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT78 = null;

        object UINT78_tree=null;

        try 
    	{
            // TimeDef.g:180:27: ( UINT )
            // TimeDef.g:180:29: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT78=(IToken)Match(input,UINT,FOLLOW_UINT_in_year_p977); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT78_tree = (object)adaptor.Create(UINT78);
            		adaptor.AddChild(root_0, UINT78_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT78 != null) ? UINT78.Text : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "year_p"

    public class month_p_return : ParserRuleReturnScope
    {
        public int value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "month_p"
    // TimeDef.g:181:1: month_p returns [int value] : UINT ;
    public TimeDefParser.month_p_return month_p() // throws RecognitionException [1]
    {   
        TimeDefParser.month_p_return retval = new TimeDefParser.month_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT79 = null;

        object UINT79_tree=null;

        try 
    	{
            // TimeDef.g:181:28: ( UINT )
            // TimeDef.g:181:30: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT79=(IToken)Match(input,UINT,FOLLOW_UINT_in_month_p989); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT79_tree = (object)adaptor.Create(UINT79);
            		adaptor.AddChild(root_0, UINT79_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT79 != null) ? UINT79.Text : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "month_p"

    public class day_p_return : ParserRuleReturnScope
    {
        public int value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "day_p"
    // TimeDef.g:182:1: day_p returns [int value] : UINT ;
    public TimeDefParser.day_p_return day_p() // throws RecognitionException [1]
    {   
        TimeDefParser.day_p_return retval = new TimeDefParser.day_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT80 = null;

        object UINT80_tree=null;

        try 
    	{
            // TimeDef.g:182:26: ( UINT )
            // TimeDef.g:182:28: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT80=(IToken)Match(input,UINT,FOLLOW_UINT_in_day_p1001); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT80_tree = (object)adaptor.Create(UINT80);
            		adaptor.AddChild(root_0, UINT80_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT80 != null) ? UINT80.Text : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "day_p"

    public class hour24_p_return : ParserRuleReturnScope
    {
        public int value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "hour24_p"
    // TimeDef.g:183:1: hour24_p returns [int value] : UINT ;
    public TimeDefParser.hour24_p_return hour24_p() // throws RecognitionException [1]
    {   
        TimeDefParser.hour24_p_return retval = new TimeDefParser.hour24_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT81 = null;

        object UINT81_tree=null;

        try 
    	{
            // TimeDef.g:183:29: ( UINT )
            // TimeDef.g:183:31: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT81=(IToken)Match(input,UINT,FOLLOW_UINT_in_hour24_p1013); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT81_tree = (object)adaptor.Create(UINT81);
            		adaptor.AddChild(root_0, UINT81_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT81 != null) ? UINT81.Text : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "hour24_p"

    public class minute60_p_return : ParserRuleReturnScope
    {
        public int value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "minute60_p"
    // TimeDef.g:184:1: minute60_p returns [int value] : UINT ;
    public TimeDefParser.minute60_p_return minute60_p() // throws RecognitionException [1]
    {   
        TimeDefParser.minute60_p_return retval = new TimeDefParser.minute60_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT82 = null;

        object UINT82_tree=null;

        try 
    	{
            // TimeDef.g:184:31: ( UINT )
            // TimeDef.g:184:33: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT82=(IToken)Match(input,UINT,FOLLOW_UINT_in_minute60_p1025); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT82_tree = (object)adaptor.Create(UINT82);
            		adaptor.AddChild(root_0, UINT82_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT82 != null) ? UINT82.Text : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "minute60_p"

    public class second60_p_return : ParserRuleReturnScope
    {
        public int value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "second60_p"
    // TimeDef.g:185:1: second60_p returns [int value] : UINT ;
    public TimeDefParser.second60_p_return second60_p() // throws RecognitionException [1]
    {   
        TimeDefParser.second60_p_return retval = new TimeDefParser.second60_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT83 = null;

        object UINT83_tree=null;

        try 
    	{
            // TimeDef.g:185:31: ( UINT )
            // TimeDef.g:185:33: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT83=(IToken)Match(input,UINT,FOLLOW_UINT_in_second60_p1037); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT83_tree = (object)adaptor.Create(UINT83);
            		adaptor.AddChild(root_0, UINT83_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT83 != null) ? UINT83.Text : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "second60_p"

    public class millisecond1000_p_return : ParserRuleReturnScope
    {
        public int value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "millisecond1000_p"
    // TimeDef.g:186:1: millisecond1000_p returns [int value] : UINT ;
    public TimeDefParser.millisecond1000_p_return millisecond1000_p() // throws RecognitionException [1]
    {   
        TimeDefParser.millisecond1000_p_return retval = new TimeDefParser.millisecond1000_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT84 = null;

        object UINT84_tree=null;

        try 
    	{
            // TimeDef.g:186:38: ( UINT )
            // TimeDef.g:186:40: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT84=(IToken)Match(input,UINT,FOLLOW_UINT_in_millisecond1000_p1049); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT84_tree = (object)adaptor.Create(UINT84);
            		adaptor.AddChild(root_0, UINT84_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT84 != null) ? UINT84.Text : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "millisecond1000_p"

    public class timespan_p_return : ParserRuleReturnScope
    {
        public TimeSpan value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "timespan_p"
    // TimeDef.g:188:1: timespan_p returns [TimeSpan value] : ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? ) ;
    public TimeDefParser.timespan_p_return timespan_p() // throws RecognitionException [1]
    {   
        TimeDefParser.timespan_p_return retval = new TimeDefParser.timespan_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal85 = null;
        IToken char_literal86 = null;
        IToken char_literal87 = null;
        IToken char_literal88 = null;
        IToken char_literal89 = null;
        TimeDefParser.days_p_return d = default(TimeDefParser.days_p_return);

        TimeDefParser.hours_p_return h = default(TimeDefParser.hours_p_return);

        TimeDefParser.minutes_p_return m = default(TimeDefParser.minutes_p_return);

        TimeDefParser.seconds_p_return s = default(TimeDefParser.seconds_p_return);

        TimeDefParser.milliseconds_p_return ms = default(TimeDefParser.milliseconds_p_return);


        object char_literal85_tree=null;
        object char_literal86_tree=null;
        object char_literal87_tree=null;
        object char_literal88_tree=null;
        object char_literal89_tree=null;

        try 
    	{
            // TimeDef.g:188:36: ( ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? ) )
            // TimeDef.g:188:38: ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:188:38: ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? )
            	// TimeDef.g:189:4: 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )?
            	{
            		char_literal85=(IToken)Match(input,27,FOLLOW_27_in_timespan_p1067); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal85_tree = (object)adaptor.Create(char_literal85);
            			adaptor.AddChild(root_0, char_literal85_tree);
            		}
            		// TimeDef.g:189:8: ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )?
            		int alt60 = 2;
            		int LA60_0 = input.LA(1);

            		if ( (LA60_0 == 18) )
            		{
            		    int LA60_1 = input.LA(2);

            		    if ( (LA60_1 == UINT) )
            		    {
            		        int LA60_2 = input.LA(3);

            		        if ( (LA60_2 == 25) )
            		        {
            		            alt60 = 1;
            		        }
            		        else if ( (LA60_2 == 26) )
            		        {
            		            int LA60_4 = input.LA(4);

            		            if ( (LA60_4 == 18) )
            		            {
            		                int LA60_6 = input.LA(5);

            		                if ( (LA60_6 == UINT) )
            		                {
            		                    int LA60_7 = input.LA(6);

            		                    if ( (LA60_7 == 25) )
            		                    {
            		                        alt60 = 1;
            		                    }
            		                }
            		            }
            		            else if ( (LA60_4 == UINT) )
            		            {
            		                int LA60_7 = input.LA(5);

            		                if ( (LA60_7 == 25) )
            		                {
            		                    alt60 = 1;
            		                }
            		            }
            		        }
            		    }
            		}
            		else if ( (LA60_0 == UINT) )
            		{
            		    int LA60_2 = input.LA(2);

            		    if ( (LA60_2 == 25) )
            		    {
            		        alt60 = 1;
            		    }
            		    else if ( (LA60_2 == 26) )
            		    {
            		        int LA60_4 = input.LA(3);

            		        if ( (LA60_4 == 18) )
            		        {
            		            int LA60_6 = input.LA(4);

            		            if ( (LA60_6 == UINT) )
            		            {
            		                int LA60_7 = input.LA(5);

            		                if ( (LA60_7 == 25) )
            		                {
            		                    alt60 = 1;
            		                }
            		            }
            		        }
            		        else if ( (LA60_4 == UINT) )
            		        {
            		            int LA60_7 = input.LA(4);

            		            if ( (LA60_7 == 25) )
            		            {
            		                alt60 = 1;
            		            }
            		        }
            		    }
            		}
            		switch (alt60) 
            		{
            		    case 1 :
            		        // TimeDef.g:189:9: ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':'
            		        {
            		        	// TimeDef.g:189:9: ( (d= days_p '.' )? h= hours_p ':' )?
            		        	int alt59 = 2;
            		        	int LA59_0 = input.LA(1);

            		        	if ( (LA59_0 == 18) )
            		        	{
            		        	    int LA59_1 = input.LA(2);

            		        	    if ( (LA59_1 == UINT) )
            		        	    {
            		        	        int LA59_2 = input.LA(3);

            		        	        if ( (LA59_2 == 25) )
            		        	        {
            		        	            int LA59_3 = input.LA(4);

            		        	            if ( (LA59_3 == 18) )
            		        	            {
            		        	                int LA59_5 = input.LA(5);

            		        	                if ( (LA59_5 == UINT) )
            		        	                {
            		        	                    int LA59_6 = input.LA(6);

            		        	                    if ( (LA59_6 == 25) )
            		        	                    {
            		        	                        alt59 = 1;
            		        	                    }
            		        	                }
            		        	            }
            		        	            else if ( (LA59_3 == UINT) )
            		        	            {
            		        	                int LA59_6 = input.LA(5);

            		        	                if ( (LA59_6 == 25) )
            		        	                {
            		        	                    alt59 = 1;
            		        	                }
            		        	            }
            		        	        }
            		        	        else if ( (LA59_2 == 26) )
            		        	        {
            		        	            alt59 = 1;
            		        	        }
            		        	    }
            		        	}
            		        	else if ( (LA59_0 == UINT) )
            		        	{
            		        	    int LA59_2 = input.LA(2);

            		        	    if ( (LA59_2 == 25) )
            		        	    {
            		        	        int LA59_3 = input.LA(3);

            		        	        if ( (LA59_3 == 18) )
            		        	        {
            		        	            int LA59_5 = input.LA(4);

            		        	            if ( (LA59_5 == UINT) )
            		        	            {
            		        	                int LA59_6 = input.LA(5);

            		        	                if ( (LA59_6 == 25) )
            		        	                {
            		        	                    alt59 = 1;
            		        	                }
            		        	            }
            		        	        }
            		        	        else if ( (LA59_3 == UINT) )
            		        	        {
            		        	            int LA59_6 = input.LA(4);

            		        	            if ( (LA59_6 == 25) )
            		        	            {
            		        	                alt59 = 1;
            		        	            }
            		        	        }
            		        	    }
            		        	    else if ( (LA59_2 == 26) )
            		        	    {
            		        	        alt59 = 1;
            		        	    }
            		        	}
            		        	switch (alt59) 
            		        	{
            		        	    case 1 :
            		        	        // TimeDef.g:189:10: (d= days_p '.' )? h= hours_p ':'
            		        	        {
            		        	        	// TimeDef.g:189:10: (d= days_p '.' )?
            		        	        	int alt58 = 2;
            		        	        	int LA58_0 = input.LA(1);

            		        	        	if ( (LA58_0 == 18) )
            		        	        	{
            		        	        	    int LA58_1 = input.LA(2);

            		        	        	    if ( (LA58_1 == UINT) )
            		        	        	    {
            		        	        	        int LA58_2 = input.LA(3);

            		        	        	        if ( (LA58_2 == 26) )
            		        	        	        {
            		        	        	            alt58 = 1;
            		        	        	        }
            		        	        	    }
            		        	        	}
            		        	        	else if ( (LA58_0 == UINT) )
            		        	        	{
            		        	        	    int LA58_2 = input.LA(2);

            		        	        	    if ( (LA58_2 == 26) )
            		        	        	    {
            		        	        	        alt58 = 1;
            		        	        	    }
            		        	        	}
            		        	        	switch (alt58) 
            		        	        	{
            		        	        	    case 1 :
            		        	        	        // TimeDef.g:189:11: d= days_p '.'
            		        	        	        {
            		        	        	        	PushFollow(FOLLOW_days_p_in_timespan_p1074);
            		        	        	        	d = days_p();
            		        	        	        	state.followingStackPointer--;
            		        	        	        	if (state.failed) return retval;
            		        	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, d.Tree);
            		        	        	        	char_literal86=(IToken)Match(input,26,FOLLOW_26_in_timespan_p1076); if (state.failed) return retval;
            		        	        	        	if ( state.backtracking == 0 )
            		        	        	        	{char_literal86_tree = (object)adaptor.Create(char_literal86);
            		        	        	        		adaptor.AddChild(root_0, char_literal86_tree);
            		        	        	        	}

            		        	        	        }
            		        	        	        break;

            		        	        	}

            		        	        	PushFollow(FOLLOW_hours_p_in_timespan_p1082);
            		        	        	h = hours_p();
            		        	        	state.followingStackPointer--;
            		        	        	if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            		        	        	char_literal87=(IToken)Match(input,25,FOLLOW_25_in_timespan_p1084); if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 )
            		        	        	{char_literal87_tree = (object)adaptor.Create(char_literal87);
            		        	        		adaptor.AddChild(root_0, char_literal87_tree);
            		        	        	}

            		        	        }
            		        	        break;

            		        	}

            		        	PushFollow(FOLLOW_minutes_p_in_timespan_p1090);
            		        	m = minutes_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            		        	char_literal88=(IToken)Match(input,25,FOLLOW_25_in_timespan_p1092); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{char_literal88_tree = (object)adaptor.Create(char_literal88);
            		        		adaptor.AddChild(root_0, char_literal88_tree);
            		        	}

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_seconds_p_in_timespan_p1098);
            		s = seconds_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            		// TimeDef.g:189:72: ( '.' ms= milliseconds_p )?
            		int alt61 = 2;
            		int LA61_0 = input.LA(1);

            		if ( (LA61_0 == 26) )
            		{
            		    alt61 = 1;
            		}
            		switch (alt61) 
            		{
            		    case 1 :
            		        // TimeDef.g:189:73: '.' ms= milliseconds_p
            		        {
            		        	char_literal89=(IToken)Match(input,26,FOLLOW_26_in_timespan_p1101); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{char_literal89_tree = (object)adaptor.Create(char_literal89);
            		        		adaptor.AddChild(root_0, char_literal89_tree);
            		        	}
            		        	PushFollow(FOLLOW_milliseconds_p_in_timespan_p1105);
            		        	ms = milliseconds_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ms.Tree);

            		        }
            		        break;

            		}


            	}

            	if ( (state.backtracking==0) )
            	{

            	     retval.value =  new TimeSpan(
            	        d==null ? 0 : ((d != null) ? d.value : default(int)),
            	        h==null ? 0 : ((h != null) ? h.value : default(int)),
            	        m==null ? 0 : ((m != null) ? m.value : default(int)),
            	        ((s != null) ? s.value : default(int)),
            	        ms==null ? 0 : ((ms != null) ? ms.value : default(int)));

            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "timespan_p"

    public class timespan_prog_return : ParserRuleReturnScope
    {
        public TimeSpan value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "timespan_prog"
    // TimeDef.g:199:1: timespan_prog returns [TimeSpan value] : ( timespan_p EOF ) ;
    public TimeDefParser.timespan_prog_return timespan_prog() // throws RecognitionException [1]
    {   
        TimeDefParser.timespan_prog_return retval = new TimeDefParser.timespan_prog_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF91 = null;
        TimeDefParser.timespan_p_return timespan_p90 = default(TimeDefParser.timespan_p_return);


        object EOF91_tree=null;

        try 
    	{
            // TimeDef.g:199:39: ( ( timespan_p EOF ) )
            // TimeDef.g:199:41: ( timespan_p EOF )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:199:41: ( timespan_p EOF )
            	// TimeDef.g:200:4: timespan_p EOF
            	{
            		PushFollow(FOLLOW_timespan_p_in_timespan_prog1127);
            		timespan_p90 = timespan_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, timespan_p90.Tree);
            		EOF91=(IToken)Match(input,EOF,FOLLOW_EOF_in_timespan_prog1129); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{EOF91_tree = (object)adaptor.Create(EOF91);
            			adaptor.AddChild(root_0, EOF91_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((timespan_p90 != null) ? timespan_p90.value : default(TimeSpan)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "timespan_prog"

    public class days_p_return : ParserRuleReturnScope
    {
        public int value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "days_p"
    // TimeDef.g:203:1: days_p returns [int value] : int_p ;
    public TimeDefParser.days_p_return days_p() // throws RecognitionException [1]
    {   
        TimeDefParser.days_p_return retval = new TimeDefParser.days_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p92 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:203:27: ( int_p )
            // TimeDef.g:203:29: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_days_p1144);
            	int_p92 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p92.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p92 != null) ? input.ToString((IToken)(int_p92.Start),(IToken)(int_p92.Stop)) : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "days_p"

    public class hours_p_return : ParserRuleReturnScope
    {
        public int value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "hours_p"
    // TimeDef.g:204:1: hours_p returns [int value] : int_p ;
    public TimeDefParser.hours_p_return hours_p() // throws RecognitionException [1]
    {   
        TimeDefParser.hours_p_return retval = new TimeDefParser.hours_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p93 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:204:28: ( int_p )
            // TimeDef.g:204:30: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_hours_p1156);
            	int_p93 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p93.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p93 != null) ? input.ToString((IToken)(int_p93.Start),(IToken)(int_p93.Stop)) : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "hours_p"

    public class minutes_p_return : ParserRuleReturnScope
    {
        public int value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "minutes_p"
    // TimeDef.g:205:1: minutes_p returns [int value] : int_p ;
    public TimeDefParser.minutes_p_return minutes_p() // throws RecognitionException [1]
    {   
        TimeDefParser.minutes_p_return retval = new TimeDefParser.minutes_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p94 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:205:30: ( int_p )
            // TimeDef.g:205:32: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_minutes_p1168);
            	int_p94 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p94.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p94 != null) ? input.ToString((IToken)(int_p94.Start),(IToken)(int_p94.Stop)) : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "minutes_p"

    public class seconds_p_return : ParserRuleReturnScope
    {
        public int value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "seconds_p"
    // TimeDef.g:206:1: seconds_p returns [int value] : int_p ;
    public TimeDefParser.seconds_p_return seconds_p() // throws RecognitionException [1]
    {   
        TimeDefParser.seconds_p_return retval = new TimeDefParser.seconds_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p95 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:206:30: ( int_p )
            // TimeDef.g:206:32: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_seconds_p1180);
            	int_p95 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p95.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p95 != null) ? input.ToString((IToken)(int_p95.Start),(IToken)(int_p95.Stop)) : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "seconds_p"

    public class milliseconds_p_return : ParserRuleReturnScope
    {
        public int value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "milliseconds_p"
    // TimeDef.g:207:1: milliseconds_p returns [int value] : int_p ;
    public TimeDefParser.milliseconds_p_return milliseconds_p() // throws RecognitionException [1]
    {   
        TimeDefParser.milliseconds_p_return retval = new TimeDefParser.milliseconds_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p96 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:207:35: ( int_p )
            // TimeDef.g:207:37: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_milliseconds_p1192);
            	int_p96 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p96.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p96 != null) ? input.ToString((IToken)(int_p96.Start),(IToken)(int_p96.Stop)) : null)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "milliseconds_p"

    public class cron_field_p_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "cron_field_p"
    // TimeDef.g:209:1: cron_field_p : cron_term_p ( ',' cron_term_p )* ;
    public TimeDefParser.cron_field_p_return cron_field_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_field_p_return retval = new TimeDefParser.cron_field_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal98 = null;
        TimeDefParser.cron_term_p_return cron_term_p97 = default(TimeDefParser.cron_term_p_return);

        TimeDefParser.cron_term_p_return cron_term_p99 = default(TimeDefParser.cron_term_p_return);


        object char_literal98_tree=null;

        try 
    	{
            // TimeDef.g:209:13: ( cron_term_p ( ',' cron_term_p )* )
            // TimeDef.g:209:15: cron_term_p ( ',' cron_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_cron_term_p_in_cron_field_p1201);
            	cron_term_p97 = cron_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cron_term_p97.Tree);
            	// TimeDef.g:209:27: ( ',' cron_term_p )*
            	do 
            	{
            	    int alt62 = 2;
            	    int LA62_0 = input.LA(1);

            	    if ( (LA62_0 == 19) )
            	    {
            	        int LA62_2 = input.LA(2);

            	        if ( (LA62_2 == 18 || (LA62_2 >= 28 && LA62_2 <= 32)) )
            	        {
            	            alt62 = 1;
            	        }
            	        else if ( (LA62_2 == UINT) )
            	        {
            	            int LA62_4 = input.LA(3);

            	            if ( (LA62_4 == 18) )
            	            {
            	                int LA62_5 = input.LA(4);

            	                if ( (LA62_5 == EOF || LA62_5 == WS || (LA62_5 >= 14 && LA62_5 <= 24) || LA62_5 == 27 || (LA62_5 >= 29 && LA62_5 <= 32)) )
            	                {
            	                    alt62 = 1;
            	                }
            	                else if ( (LA62_5 == UINT) )
            	                {
            	                    int LA62_6 = input.LA(5);

            	                    if ( (LA62_6 == EOF || (LA62_6 >= WS && LA62_6 <= UINT) || (LA62_6 >= 14 && LA62_6 <= 17) || (LA62_6 >= 19 && LA62_6 <= 24) || (LA62_6 >= 29 && LA62_6 <= 32)) )
            	                    {
            	                        alt62 = 1;
            	                    }
            	                    else if ( (LA62_6 == 18) )
            	                    {
            	                        int LA62_7 = input.LA(6);

            	                        if ( (LA62_7 == EOF || LA62_7 == WS || (LA62_7 >= 14 && LA62_7 <= 24) || LA62_7 == 27 || (LA62_7 >= 29 && LA62_7 <= 32)) )
            	                        {
            	                            alt62 = 1;
            	                        }
            	                        else if ( (LA62_7 == UINT) )
            	                        {
            	                            int LA62_8 = input.LA(7);

            	                            if ( (synpred70_TimeDef()) )
            	                            {
            	                                alt62 = 1;
            	                            }


            	                        }


            	                    }


            	                }


            	            }
            	            else if ( (LA62_4 == EOF || (LA62_4 >= WS && LA62_4 <= UINT) || (LA62_4 >= 14 && LA62_4 <= 17) || (LA62_4 >= 19 && LA62_4 <= 24) || (LA62_4 >= 29 && LA62_4 <= 32)) )
            	            {
            	                alt62 = 1;
            	            }


            	        }


            	    }


            	    switch (alt62) 
            		{
            			case 1 :
            			    // TimeDef.g:209:28: ',' cron_term_p
            			    {
            			    	char_literal98=(IToken)Match(input,19,FOLLOW_19_in_cron_field_p1204); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal98_tree = (object)adaptor.Create(char_literal98);
            			    		adaptor.AddChild(root_0, char_literal98_tree);
            			    	}
            			    	PushFollow(FOLLOW_cron_term_p_in_cron_field_p1206);
            			    	cron_term_p99 = cron_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cron_term_p99.Tree);

            			    }
            			    break;

            			default:
            			    goto loop62;
            	    }
            	} while (true);

            	loop62:
            		;	// Stops C# compiler whining that label 'loop62' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cron_field_p"

    public class cron_term_p_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "cron_term_p"
    // TimeDef.g:210:1: cron_term_p : ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+ ;
    public TimeDefParser.cron_term_p_return cron_term_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_term_p_return retval = new TimeDefParser.cron_term_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal100 = null;
        IToken set101 = null;

        object char_literal100_tree=null;
        object set101_tree=null;

        try 
    	{
            // TimeDef.g:210:12: ( ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+ )
            // TimeDef.g:210:14: ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:210:14: ( '!' )?
            	int alt63 = 2;
            	int LA63_0 = input.LA(1);

            	if ( (LA63_0 == 28) )
            	{
            	    alt63 = 1;
            	}
            	switch (alt63) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '!'
            	        {
            	        	char_literal100=(IToken)Match(input,28,FOLLOW_28_in_cron_term_p1214); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal100_tree = (object)adaptor.Create(char_literal100);
            	        		adaptor.AddChild(root_0, char_literal100_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:210:19: ( UINT | '/' | '-' | '*' | '>' | '<' )+
            	int cnt64 = 0;
            	do 
            	{
            	    int alt64 = 2;
            	    alt64 = dfa64.Predict(input);
            	    switch (alt64) 
            		{
            			case 1 :
            			    // TimeDef.g:
            			    {
            			    	set101 = (IToken)input.LT(1);
            			    	if ( input.LA(1) == UINT || input.LA(1) == 18 || (input.LA(1) >= 29 && input.LA(1) <= 32) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set101));
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}


            			    }
            			    break;

            			default:
            			    if ( cnt64 >= 1 ) goto loop64;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee64 =
            		                new EarlyExitException(64, input);
            		            throw eee64;
            	    }
            	    cnt64++;
            	} while (true);

            	loop64:
            		;	// Stops C# compiler whining that label 'loop64' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cron_term_p"

    public class intspec_p_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "intspec_p"
    // TimeDef.g:212:1: intspec_p : intspec_term_p ( ',' intspec_term_p )* ;
    public TimeDefParser.intspec_p_return intspec_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intspec_p_return retval = new TimeDefParser.intspec_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal103 = null;
        TimeDefParser.intspec_term_p_return intspec_term_p102 = default(TimeDefParser.intspec_term_p_return);

        TimeDefParser.intspec_term_p_return intspec_term_p104 = default(TimeDefParser.intspec_term_p_return);


        object char_literal103_tree=null;

        try 
    	{
            // TimeDef.g:212:10: ( intspec_term_p ( ',' intspec_term_p )* )
            // TimeDef.g:212:12: intspec_term_p ( ',' intspec_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_intspec_term_p_in_intspec_p1247);
            	intspec_term_p102 = intspec_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intspec_term_p102.Tree);
            	// TimeDef.g:212:27: ( ',' intspec_term_p )*
            	do 
            	{
            	    int alt65 = 2;
            	    int LA65_0 = input.LA(1);

            	    if ( (LA65_0 == 19) )
            	    {
            	        int LA65_2 = input.LA(2);

            	        if ( (LA65_2 == 18 || LA65_2 == 28 || LA65_2 == 30) )
            	        {
            	            alt65 = 1;
            	        }
            	        else if ( (LA65_2 == UINT) )
            	        {
            	            int LA65_4 = input.LA(3);

            	            if ( (LA65_4 == 18) )
            	            {
            	                int LA65_5 = input.LA(4);

            	                if ( (LA65_5 == WS || LA65_5 == 18 || LA65_5 == 27) )
            	                {
            	                    alt65 = 1;
            	                }
            	                else if ( (LA65_5 == UINT) )
            	                {
            	                    int LA65_6 = input.LA(5);

            	                    if ( (LA65_6 == EOF || LA65_6 == WS || (LA65_6 >= 14 && LA65_6 <= 17) || (LA65_6 >= 19 && LA65_6 <= 24) || LA65_6 == 29) )
            	                    {
            	                        alt65 = 1;
            	                    }
            	                    else if ( (LA65_6 == 18) )
            	                    {
            	                        int LA65_7 = input.LA(6);

            	                        if ( (LA65_7 == WS || LA65_7 == 27) )
            	                        {
            	                            alt65 = 1;
            	                        }


            	                    }


            	                }


            	            }
            	            else if ( (LA65_4 == EOF || LA65_4 == WS || (LA65_4 >= 14 && LA65_4 <= 17) || (LA65_4 >= 19 && LA65_4 <= 24) || LA65_4 == 29) )
            	            {
            	                alt65 = 1;
            	            }


            	        }


            	    }


            	    switch (alt65) 
            		{
            			case 1 :
            			    // TimeDef.g:212:28: ',' intspec_term_p
            			    {
            			    	char_literal103=(IToken)Match(input,19,FOLLOW_19_in_intspec_p1250); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal103_tree = (object)adaptor.Create(char_literal103);
            			    		adaptor.AddChild(root_0, char_literal103_tree);
            			    	}
            			    	PushFollow(FOLLOW_intspec_term_p_in_intspec_p1252);
            			    	intspec_term_p104 = intspec_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intspec_term_p104.Tree);

            			    }
            			    break;

            			default:
            			    goto loop65;
            	    }
            	} while (true);

            	loop65:
            		;	// Stops C# compiler whining that label 'loop65' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "intspec_p"

    public class intspec_term_p_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "intspec_term_p"
    // TimeDef.g:213:1: intspec_term_p : ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )? ;
    public TimeDefParser.intspec_term_p_return intspec_term_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intspec_term_p_return retval = new TimeDefParser.intspec_term_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal105 = null;
        IToken char_literal106 = null;
        IToken char_literal108 = null;
        IToken char_literal110 = null;
        IToken UINT111 = null;
        TimeDefParser.int_p_return int_p107 = default(TimeDefParser.int_p_return);

        TimeDefParser.int_p_return int_p109 = default(TimeDefParser.int_p_return);


        object char_literal105_tree=null;
        object char_literal106_tree=null;
        object char_literal108_tree=null;
        object char_literal110_tree=null;
        object UINT111_tree=null;

        try 
    	{
            // TimeDef.g:213:15: ( ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )? )
            // TimeDef.g:213:17: ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:213:17: ( '!' )?
            	int alt66 = 2;
            	int LA66_0 = input.LA(1);

            	if ( (LA66_0 == 28) )
            	{
            	    alt66 = 1;
            	}
            	switch (alt66) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '!'
            	        {
            	        	char_literal105=(IToken)Match(input,28,FOLLOW_28_in_intspec_term_p1260); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal105_tree = (object)adaptor.Create(char_literal105);
            	        		adaptor.AddChild(root_0, char_literal105_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:213:22: ( '*' | int_p ( '-' int_p )? )
            	int alt68 = 2;
            	int LA68_0 = input.LA(1);

            	if ( (LA68_0 == 30) )
            	{
            	    alt68 = 1;
            	}
            	else if ( (LA68_0 == UINT || LA68_0 == 18) )
            	{
            	    alt68 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d68s0 =
            	        new NoViableAltException("", 68, 0, input);

            	    throw nvae_d68s0;
            	}
            	switch (alt68) 
            	{
            	    case 1 :
            	        // TimeDef.g:213:24: '*'
            	        {
            	        	char_literal106=(IToken)Match(input,30,FOLLOW_30_in_intspec_term_p1265); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal106_tree = (object)adaptor.Create(char_literal106);
            	        		adaptor.AddChild(root_0, char_literal106_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // TimeDef.g:213:30: int_p ( '-' int_p )?
            	        {
            	        	PushFollow(FOLLOW_int_p_in_intspec_term_p1269);
            	        	int_p107 = int_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p107.Tree);
            	        	// TimeDef.g:213:36: ( '-' int_p )?
            	        	int alt67 = 2;
            	        	int LA67_0 = input.LA(1);

            	        	if ( (LA67_0 == 18) )
            	        	{
            	        	    int LA67_1 = input.LA(2);

            	        	    if ( (LA67_1 == UINT || LA67_1 == 18) )
            	        	    {
            	        	        alt67 = 1;
            	        	    }
            	        	}
            	        	switch (alt67) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:213:38: '-' int_p
            	        	        {
            	        	        	char_literal108=(IToken)Match(input,18,FOLLOW_18_in_intspec_term_p1273); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal108_tree = (object)adaptor.Create(char_literal108);
            	        	        		adaptor.AddChild(root_0, char_literal108_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_int_p_in_intspec_term_p1275);
            	        	        	int_p109 = int_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p109.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// TimeDef.g:213:53: ( '/' UINT )?
            	int alt69 = 2;
            	int LA69_0 = input.LA(1);

            	if ( (LA69_0 == 29) )
            	{
            	    alt69 = 1;
            	}
            	switch (alt69) 
            	{
            	    case 1 :
            	        // TimeDef.g:213:55: '/' UINT
            	        {
            	        	char_literal110=(IToken)Match(input,29,FOLLOW_29_in_intspec_term_p1284); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal110_tree = (object)adaptor.Create(char_literal110);
            	        		adaptor.AddChild(root_0, char_literal110_tree);
            	        	}
            	        	UINT111=(IToken)Match(input,UINT,FOLLOW_UINT_in_intspec_term_p1286); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UINT111_tree = (object)adaptor.Create(UINT111);
            	        		adaptor.AddChild(root_0, UINT111_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "intspec_term_p"

    public class int_p_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "int_p"
    // TimeDef.g:218:1: int_p : ( '-' )? UINT ;
    public TimeDefParser.int_p_return int_p() // throws RecognitionException [1]
    {   
        TimeDefParser.int_p_return retval = new TimeDefParser.int_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal112 = null;
        IToken UINT113 = null;

        object char_literal112_tree=null;
        object UINT113_tree=null;

        try 
    	{
            // TimeDef.g:218:6: ( ( '-' )? UINT )
            // TimeDef.g:218:8: ( '-' )? UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:218:8: ( '-' )?
            	int alt70 = 2;
            	int LA70_0 = input.LA(1);

            	if ( (LA70_0 == 18) )
            	{
            	    alt70 = 1;
            	}
            	switch (alt70) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '-'
            	        {
            	        	char_literal112=(IToken)Match(input,18,FOLLOW_18_in_int_p1299); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal112_tree = (object)adaptor.Create(char_literal112);
            	        		adaptor.AddChild(root_0, char_literal112_tree);
            	        	}

            	        }
            	        break;

            	}

            	UINT113=(IToken)Match(input,UINT,FOLLOW_UINT_in_int_p1302); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT113_tree = (object)adaptor.Create(UINT113);
            		adaptor.AddChild(root_0, UINT113_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }

           catch (RecognitionException) { throw; }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "int_p"

    // $ANTLR start "synpred8_TimeDef"
    public void synpred8_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        // TimeDef.g:59:22: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:59:22: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:59:22: ( WS )+
        	int cnt71 = 0;
        	do 
        	{
        	    int alt71 = 2;
        	    int LA71_0 = input.LA(1);

        	    if ( (LA71_0 == WS) )
        	    {
        	        alt71 = 1;
        	    }


        	    switch (alt71) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred8_TimeDef174); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt71 >= 1 ) goto loop71;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee71 =
        		                new EarlyExitException(71, input);
        		            throw eee71;
        	    }
        	    cnt71++;
        	} while (true);

        	loop71:
        		;	// Stops C# compiler whining that label 'loop71' has no statements

        	Match(input,7,FOLLOW_7_in_synpred8_TimeDef177); if (state.failed) return ;
        	// TimeDef.g:59:36: ( WS )+
        	int cnt72 = 0;
        	do 
        	{
        	    int alt72 = 2;
        	    int LA72_0 = input.LA(1);

        	    if ( (LA72_0 == WS) )
        	    {
        	        alt72 = 1;
        	    }


        	    switch (alt72) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred8_TimeDef179); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt72 >= 1 ) goto loop72;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee72 =
        		                new EarlyExitException(72, input);
        		            throw eee72;
        	    }
        	    cnt72++;
        	} while (true);

        	loop72:
        		;	// Stops C# compiler whining that label 'loop72' has no statements

        	PushFollow(FOLLOW_timespan_p_in_synpred8_TimeDef184);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_TimeDef"

    // $ANTLR start "synpred15_TimeDef"
    public void synpred15_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        // TimeDef.g:63:72: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:63:72: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:63:72: ( WS )+
        	int cnt75 = 0;
        	do 
        	{
        	    int alt75 = 2;
        	    int LA75_0 = input.LA(1);

        	    if ( (LA75_0 == WS) )
        	    {
        	        alt75 = 1;
        	    }


        	    switch (alt75) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred15_TimeDef231); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt75 >= 1 ) goto loop75;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee75 =
        		                new EarlyExitException(75, input);
        		            throw eee75;
        	    }
        	    cnt75++;
        	} while (true);

        	loop75:
        		;	// Stops C# compiler whining that label 'loop75' has no statements

        	Match(input,7,FOLLOW_7_in_synpred15_TimeDef234); if (state.failed) return ;
        	// TimeDef.g:63:86: ( WS )+
        	int cnt76 = 0;
        	do 
        	{
        	    int alt76 = 2;
        	    int LA76_0 = input.LA(1);

        	    if ( (LA76_0 == WS) )
        	    {
        	        alt76 = 1;
        	    }


        	    switch (alt76) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred15_TimeDef236); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt76 >= 1 ) goto loop76;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee76 =
        		                new EarlyExitException(76, input);
        		            throw eee76;
        	    }
        	    cnt76++;
        	} while (true);

        	loop76:
        		;	// Stops C# compiler whining that label 'loop76' has no statements

        	PushFollow(FOLLOW_timespan_p_in_synpred15_TimeDef241);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred15_TimeDef"

    // $ANTLR start "synpred23_TimeDef"
    public void synpred23_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        // TimeDef.g:73:5: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:73:5: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:73:5: ( WS )+
        	int cnt77 = 0;
        	do 
        	{
        	    int alt77 = 2;
        	    int LA77_0 = input.LA(1);

        	    if ( (LA77_0 == WS) )
        	    {
        	        alt77 = 1;
        	    }


        	    switch (alt77) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred23_TimeDef319); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt77 >= 1 ) goto loop77;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee77 =
        		                new EarlyExitException(77, input);
        		            throw eee77;
        	    }
        	    cnt77++;
        	} while (true);

        	loop77:
        		;	// Stops C# compiler whining that label 'loop77' has no statements

        	Match(input,7,FOLLOW_7_in_synpred23_TimeDef322); if (state.failed) return ;
        	// TimeDef.g:73:19: ( WS )+
        	int cnt78 = 0;
        	do 
        	{
        	    int alt78 = 2;
        	    int LA78_0 = input.LA(1);

        	    if ( (LA78_0 == WS) )
        	    {
        	        alt78 = 1;
        	    }


        	    switch (alt78) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred23_TimeDef324); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt78 >= 1 ) goto loop78;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee78 =
        		                new EarlyExitException(78, input);
        		            throw eee78;
        	    }
        	    cnt78++;
        	} while (true);

        	loop78:
        		;	// Stops C# compiler whining that label 'loop78' has no statements

        	PushFollow(FOLLOW_timespan_p_in_synpred23_TimeDef329);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred23_TimeDef"

    // $ANTLR start "synpred70_TimeDef"
    public void synpred70_TimeDef_fragment() {
        // TimeDef.g:209:28: ( ',' cron_term_p )
        // TimeDef.g:209:28: ',' cron_term_p
        {
        	Match(input,19,FOLLOW_19_in_synpred70_TimeDef1204); if (state.failed) return ;
        	PushFollow(FOLLOW_cron_term_p_in_synpred70_TimeDef1206);
        	cron_term_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred70_TimeDef"

    // Delegated rules

   	public bool synpred15_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred15_TimeDef_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred23_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred23_TimeDef_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred8_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred8_TimeDef_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred70_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred70_TimeDef_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA4 dfa4;
   	protected DFA8 dfa8;
   	protected DFA11 dfa11;
   	protected DFA19 dfa19;
   	protected DFA30 dfa30;
   	protected DFA34 dfa34;
   	protected DFA38 dfa38;
   	protected DFA41 dfa41;
   	protected DFA44 dfa44;
   	protected DFA47 dfa47;
   	protected DFA50 dfa50;
   	protected DFA54 dfa54;
   	protected DFA64 dfa64;
	private void InitializeCyclicDFAs()
	{
    	this.dfa4 = new DFA4(this);
    	this.dfa8 = new DFA8(this);
    	this.dfa11 = new DFA11(this);
    	this.dfa19 = new DFA19(this);
    	this.dfa30 = new DFA30(this);
    	this.dfa34 = new DFA34(this);
    	this.dfa38 = new DFA38(this);
    	this.dfa41 = new DFA41(this);
    	this.dfa44 = new DFA44(this);
    	this.dfa47 = new DFA47(this);
    	this.dfa50 = new DFA50(this);
    	this.dfa54 = new DFA54(this);
    	this.dfa64 = new DFA64(this);
	    this.dfa4.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA4_SpecialStateTransition);
	    this.dfa11.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA11_SpecialStateTransition);
	    this.dfa19.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA19_SpecialStateTransition);
	}

    const string DFA4_eotS =
        "\x09\uffff";
    const string DFA4_eofS =
        "\x02\x02\x07\uffff";
    const string DFA4_minS =
        "\x02\x04\x01\uffff\x02\x04\x02\x05\x01\x00\x01\uffff";
    const string DFA4_maxS =
        "\x02\x18\x01\uffff\x01\x04\x01\x1b\x01\x12\x01\x05\x01\x00\x01"+
        "\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01";
    const string DFA4_specialS =
        "\x07\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x01\x09\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x03\x06\uffff\x0b\x02",
            "",
            "\x01\x04",
            "\x01\x04\x16\uffff\x01\x05",
            "\x01\x07\x0c\uffff\x01\x06",
            "\x01\x07",
            "\x01\uffff",
            ""
    };

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "59:21: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?"; }
        }

    }


    protected internal int DFA4_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA4_7 = input.LA(1);

                   	 
                   	int index4_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_TimeDef()) ) { s = 8; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index4_7);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae4 =
            new NoViableAltException(dfa.Description, 4, _s, input);
        dfa.Error(nvae4);
        throw nvae4;
    }
    const string DFA8_eotS =
        "\x04\uffff";
    const string DFA8_eofS =
        "\x02\x02\x02\uffff";
    const string DFA8_minS =
        "\x02\x04\x02\uffff";
    const string DFA8_maxS =
        "\x02\x18\x02\uffff";
    const string DFA8_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA8_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x01\x01\x09\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x02\x01\uffff\x01\x03\x04\uffff\x0b"+
            "\x02",
            "",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "63:36: ( ( WS )+ 'since' ( WS )+ sync= datetime_p )?"; }
        }

    }

    const string DFA11_eotS =
        "\x09\uffff";
    const string DFA11_eofS =
        "\x02\x02\x07\uffff";
    const string DFA11_minS =
        "\x02\x04\x01\uffff\x02\x04\x02\x05\x01\x00\x01\uffff";
    const string DFA11_maxS =
        "\x02\x18\x01\uffff\x01\x04\x01\x1b\x01\x12\x01\x05\x01\x00\x01"+
        "\uffff";
    const string DFA11_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01";
    const string DFA11_specialS =
        "\x07\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x01\x09\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x03\x06\uffff\x0b\x02",
            "",
            "\x01\x04",
            "\x01\x04\x16\uffff\x01\x05",
            "\x01\x07\x0c\uffff\x01\x06",
            "\x01\x07",
            "\x01\uffff",
            ""
    };

    static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
    static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
    static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
    static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
    static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
    static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
    static readonly short[][] DFA11_transition = DFA.UnpackEncodedStringArray(DFA11_transitionS);

    protected class DFA11 : DFA
    {
        public DFA11(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;

        }

        override public string Description
        {
            get { return "63:71: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?"; }
        }

    }


    protected internal int DFA11_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA11_7 = input.LA(1);

                   	 
                   	int index11_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_TimeDef()) ) { s = 8; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index11_7);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae11 =
            new NoViableAltException(dfa.Description, 11, _s, input);
        dfa.Error(nvae11);
        throw nvae11;
    }
    const string DFA19_eotS =
        "\x09\uffff";
    const string DFA19_eofS =
        "\x02\x02\x07\uffff";
    const string DFA19_minS =
        "\x02\x04\x01\uffff\x02\x04\x02\x05\x01\x00\x01\uffff";
    const string DFA19_maxS =
        "\x02\x18\x01\uffff\x01\x04\x01\x1b\x01\x12\x01\x05\x01\x00\x01"+
        "\uffff";
    const string DFA19_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01";
    const string DFA19_specialS =
        "\x07\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x01\x01\x09\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x03\x06\uffff\x0b\x02",
            "",
            "\x01\x04",
            "\x01\x04\x16\uffff\x01\x05",
            "\x01\x07\x0c\uffff\x01\x06",
            "\x01\x07",
            "\x01\uffff",
            ""
    };

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "73:4: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?"; }
        }

    }


    protected internal int DFA19_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA19_7 = input.LA(1);

                   	 
                   	int index19_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred23_TimeDef()) ) { s = 8; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index19_7);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae19 =
            new NoViableAltException(dfa.Description, 19, _s, input);
        dfa.Error(nvae19);
        throw nvae19;
    }
    const string DFA30_eotS =
        "\x07\uffff";
    const string DFA30_eofS =
        "\x02\x02\x05\uffff";
    const string DFA30_minS =
        "\x02\x04\x05\uffff";
    const string DFA30_maxS =
        "\x02\x18\x05\uffff";
    const string DFA30_acceptS =
        "\x02\uffff\x01\x05\x01\x01\x01\x02\x01\x03\x01\x04";
    const string DFA30_specialS =
        "\x07\uffff}>";
    static readonly string[] DFA30_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x01\x03\x01\x04\x02\x05\x06\x02",
            "\x01\x01\x02\uffff\x01\x06\x06\uffff\x01\x02\x01\x03\x01\x04"+
            "\x02\x05\x06\x02",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA30_eot = DFA.UnpackEncodedString(DFA30_eotS);
    static readonly short[] DFA30_eof = DFA.UnpackEncodedString(DFA30_eofS);
    static readonly char[] DFA30_min = DFA.UnpackEncodedStringToUnsignedChars(DFA30_minS);
    static readonly char[] DFA30_max = DFA.UnpackEncodedStringToUnsignedChars(DFA30_maxS);
    static readonly short[] DFA30_accept = DFA.UnpackEncodedString(DFA30_acceptS);
    static readonly short[] DFA30_special = DFA.UnpackEncodedString(DFA30_specialS);
    static readonly short[][] DFA30_transition = DFA.UnpackEncodedStringArray(DFA30_transitionS);

    protected class DFA30 : DFA
    {
        public DFA30(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 30;
            this.eot = DFA30_eot;
            this.eof = DFA30_eof;
            this.min = DFA30_min;
            this.max = DFA30_max;
            this.accept = DFA30_accept;
            this.special = DFA30_special;
            this.transition = DFA30_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 92:34: ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*"; }
        }

    }

    const string DFA34_eotS =
        "\x04\uffff";
    const string DFA34_eofS =
        "\x02\x02\x02\uffff";
    const string DFA34_minS =
        "\x02\x04\x02\uffff";
    const string DFA34_maxS =
        "\x02\x13\x02\uffff";
    const string DFA34_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA34_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA34_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x04\uffff\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x04\uffff\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA34_eot = DFA.UnpackEncodedString(DFA34_eotS);
    static readonly short[] DFA34_eof = DFA.UnpackEncodedString(DFA34_eofS);
    static readonly char[] DFA34_min = DFA.UnpackEncodedStringToUnsignedChars(DFA34_minS);
    static readonly char[] DFA34_max = DFA.UnpackEncodedStringToUnsignedChars(DFA34_maxS);
    static readonly short[] DFA34_accept = DFA.UnpackEncodedString(DFA34_acceptS);
    static readonly short[] DFA34_special = DFA.UnpackEncodedString(DFA34_specialS);
    static readonly short[][] DFA34_transition = DFA.UnpackEncodedStringArray(DFA34_transitionS);

    protected class DFA34 : DFA
    {
        public DFA34(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 34;
            this.eot = DFA34_eot;
            this.eof = DFA34_eof;
            this.min = DFA34_min;
            this.max = DFA34_max;
            this.accept = DFA34_accept;
            this.special = DFA34_special;
            this.transition = DFA34_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 107:4: ( ( WS )* ',' ( WS )* B= boolnonintersection_p )*"; }
        }

    }

    const string DFA38_eotS =
        "\x04\uffff";
    const string DFA38_eofS =
        "\x02\x02\x02\uffff";
    const string DFA38_minS =
        "\x02\x04\x02\uffff";
    const string DFA38_maxS =
        "\x02\x14\x02\uffff";
    const string DFA38_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA38_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA38_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x04\uffff\x01\x02\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x04\uffff\x01\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA38_eot = DFA.UnpackEncodedString(DFA38_eotS);
    static readonly short[] DFA38_eof = DFA.UnpackEncodedString(DFA38_eofS);
    static readonly char[] DFA38_min = DFA.UnpackEncodedStringToUnsignedChars(DFA38_minS);
    static readonly char[] DFA38_max = DFA.UnpackEncodedStringToUnsignedChars(DFA38_maxS);
    static readonly short[] DFA38_accept = DFA.UnpackEncodedString(DFA38_acceptS);
    static readonly short[] DFA38_special = DFA.UnpackEncodedString(DFA38_specialS);
    static readonly short[][] DFA38_transition = DFA.UnpackEncodedStringArray(DFA38_transitionS);

    protected class DFA38 : DFA
    {
        public DFA38(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 38;
            this.eot = DFA38_eot;
            this.eof = DFA38_eof;
            this.min = DFA38_min;
            this.max = DFA38_max;
            this.accept = DFA38_accept;
            this.special = DFA38_special;
            this.transition = DFA38_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 115:4: ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*"; }
        }

    }

    const string DFA41_eotS =
        "\x04\uffff";
    const string DFA41_eofS =
        "\x02\x02\x02\uffff";
    const string DFA41_minS =
        "\x02\x04\x02\uffff";
    const string DFA41_maxS =
        "\x02\x15\x02\uffff";
    const string DFA41_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA41_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA41_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x04\uffff\x02\x02\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x04\uffff\x02\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA41_eot = DFA.UnpackEncodedString(DFA41_eotS);
    static readonly short[] DFA41_eof = DFA.UnpackEncodedString(DFA41_eofS);
    static readonly char[] DFA41_min = DFA.UnpackEncodedStringToUnsignedChars(DFA41_minS);
    static readonly char[] DFA41_max = DFA.UnpackEncodedStringToUnsignedChars(DFA41_maxS);
    static readonly short[] DFA41_accept = DFA.UnpackEncodedString(DFA41_acceptS);
    static readonly short[] DFA41_special = DFA.UnpackEncodedString(DFA41_specialS);
    static readonly short[][] DFA41_transition = DFA.UnpackEncodedStringArray(DFA41_transitionS);

    protected class DFA41 : DFA
    {
        public DFA41(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 41;
            this.eot = DFA41_eot;
            this.eof = DFA41_eof;
            this.min = DFA41_min;
            this.max = DFA41_max;
            this.accept = DFA41_accept;
            this.special = DFA41_special;
            this.transition = DFA41_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 123:4: ( ( WS )* '&&' ( WS )* B= union_p )*"; }
        }

    }

    const string DFA44_eotS =
        "\x04\uffff";
    const string DFA44_eofS =
        "\x02\x02\x02\uffff";
    const string DFA44_minS =
        "\x02\x04\x02\uffff";
    const string DFA44_maxS =
        "\x02\x16\x02\uffff";
    const string DFA44_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA44_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA44_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x04\uffff\x03\x02\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x04\uffff\x03\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA44_eot = DFA.UnpackEncodedString(DFA44_eotS);
    static readonly short[] DFA44_eof = DFA.UnpackEncodedString(DFA44_eofS);
    static readonly char[] DFA44_min = DFA.UnpackEncodedStringToUnsignedChars(DFA44_minS);
    static readonly char[] DFA44_max = DFA.UnpackEncodedStringToUnsignedChars(DFA44_maxS);
    static readonly short[] DFA44_accept = DFA.UnpackEncodedString(DFA44_acceptS);
    static readonly short[] DFA44_special = DFA.UnpackEncodedString(DFA44_specialS);
    static readonly short[][] DFA44_transition = DFA.UnpackEncodedStringArray(DFA44_transitionS);

    protected class DFA44 : DFA
    {
        public DFA44(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 44;
            this.eot = DFA44_eot;
            this.eof = DFA44_eof;
            this.min = DFA44_min;
            this.max = DFA44_max;
            this.accept = DFA44_accept;
            this.special = DFA44_special;
            this.transition = DFA44_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 135:4: ( ( WS )* '|' ( WS )* B= difference_p )*"; }
        }

    }

    const string DFA47_eotS =
        "\x04\uffff";
    const string DFA47_eofS =
        "\x02\x02\x02\uffff";
    const string DFA47_minS =
        "\x02\x04\x02\uffff";
    const string DFA47_maxS =
        "\x02\x17\x02\uffff";
    const string DFA47_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA47_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA47_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x04\uffff\x04\x02\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x04\uffff\x04\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA47_eot = DFA.UnpackEncodedString(DFA47_eotS);
    static readonly short[] DFA47_eof = DFA.UnpackEncodedString(DFA47_eofS);
    static readonly char[] DFA47_min = DFA.UnpackEncodedStringToUnsignedChars(DFA47_minS);
    static readonly char[] DFA47_max = DFA.UnpackEncodedStringToUnsignedChars(DFA47_maxS);
    static readonly short[] DFA47_accept = DFA.UnpackEncodedString(DFA47_acceptS);
    static readonly short[] DFA47_special = DFA.UnpackEncodedString(DFA47_specialS);
    static readonly short[][] DFA47_transition = DFA.UnpackEncodedStringArray(DFA47_transitionS);

    protected class DFA47 : DFA
    {
        public DFA47(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 47;
            this.eot = DFA47_eot;
            this.eof = DFA47_eof;
            this.min = DFA47_min;
            this.max = DFA47_max;
            this.accept = DFA47_accept;
            this.special = DFA47_special;
            this.transition = DFA47_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 147:4: ( ( WS )* '!&' ( WS )* B= intersection_p )*"; }
        }

    }

    const string DFA50_eotS =
        "\x04\uffff";
    const string DFA50_eofS =
        "\x02\x02\x02\uffff";
    const string DFA50_minS =
        "\x02\x04\x02\uffff";
    const string DFA50_maxS =
        "\x02\x18\x02\uffff";
    const string DFA50_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA50_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA50_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x04\uffff\x05\x02\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x04\uffff\x05\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA50_eot = DFA.UnpackEncodedString(DFA50_eotS);
    static readonly short[] DFA50_eof = DFA.UnpackEncodedString(DFA50_eofS);
    static readonly char[] DFA50_min = DFA.UnpackEncodedStringToUnsignedChars(DFA50_minS);
    static readonly char[] DFA50_max = DFA.UnpackEncodedStringToUnsignedChars(DFA50_maxS);
    static readonly short[] DFA50_accept = DFA.UnpackEncodedString(DFA50_acceptS);
    static readonly short[] DFA50_special = DFA.UnpackEncodedString(DFA50_specialS);
    static readonly short[][] DFA50_transition = DFA.UnpackEncodedStringArray(DFA50_transitionS);

    protected class DFA50 : DFA
    {
        public DFA50(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 50;
            this.eot = DFA50_eot;
            this.eof = DFA50_eof;
            this.min = DFA50_min;
            this.max = DFA50_max;
            this.accept = DFA50_accept;
            this.special = DFA50_special;
            this.transition = DFA50_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 156:4: ( ( WS )* '&' ( WS )* B= filter_p )*"; }
        }

    }

    const string DFA54_eotS =
        "\x04\uffff";
    const string DFA54_eofS =
        "\x02\x02\x02\uffff";
    const string DFA54_minS =
        "\x02\x04\x02\uffff";
    const string DFA54_maxS =
        "\x02\x18\x02\uffff";
    const string DFA54_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA54_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA54_transitionS = {
            "\x01\x01\x09\uffff\x0b\x02",
            "\x01\x01\x01\x03\x01\uffff\x01\x02\x06\uffff\x0b\x02",
            "",
            ""
    };

    static readonly short[] DFA54_eot = DFA.UnpackEncodedString(DFA54_eotS);
    static readonly short[] DFA54_eof = DFA.UnpackEncodedString(DFA54_eofS);
    static readonly char[] DFA54_min = DFA.UnpackEncodedStringToUnsignedChars(DFA54_minS);
    static readonly char[] DFA54_max = DFA.UnpackEncodedStringToUnsignedChars(DFA54_maxS);
    static readonly short[] DFA54_accept = DFA.UnpackEncodedString(DFA54_acceptS);
    static readonly short[] DFA54_special = DFA.UnpackEncodedString(DFA54_specialS);
    static readonly short[][] DFA54_transition = DFA.UnpackEncodedStringArray(DFA54_transitionS);

    protected class DFA54 : DFA
    {
        public DFA54(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 54;
            this.eot = DFA54_eot;
            this.eof = DFA54_eof;
            this.min = DFA54_min;
            this.max = DFA54_max;
            this.accept = DFA54_accept;
            this.special = DFA54_special;
            this.transition = DFA54_transition;

        }

        override public string Description
        {
            get { return "163:40: ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?"; }
        }

    }

    const string DFA64_eotS =
        "\x05\uffff";
    const string DFA64_eofS =
        "\x01\x01\x01\uffff\x01\x03\x01\uffff\x01\x03";
    const string DFA64_minS =
        "\x01\x04\x01\uffff\x01\x04\x01\uffff\x01\x04";
    const string DFA64_maxS =
        "\x01\x20\x01\uffff\x01\x20\x01\uffff\x01\x20";
    const string DFA64_acceptS =
        "\x01\uffff\x01\x02\x01\uffff\x01\x01\x01\uffff";
    const string DFA64_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA64_transitionS = {
            "\x01\x01\x01\x03\x08\uffff\x04\x01\x01\x02\x06\x01\x04\uffff"+
            "\x04\x03",
            "",
            "\x01\x04\x01\x03\x08\uffff\x0b\x03\x02\uffff\x01\x01\x01\uffff"+
            "\x04\x03",
            "",
            "\x01\x04\x01\x03\x01\uffff\x01\x03\x06\uffff\x0b\x03\x02\uffff"+
            "\x01\x01\x05\x03"
    };

    static readonly short[] DFA64_eot = DFA.UnpackEncodedString(DFA64_eotS);
    static readonly short[] DFA64_eof = DFA.UnpackEncodedString(DFA64_eofS);
    static readonly char[] DFA64_min = DFA.UnpackEncodedStringToUnsignedChars(DFA64_minS);
    static readonly char[] DFA64_max = DFA.UnpackEncodedStringToUnsignedChars(DFA64_maxS);
    static readonly short[] DFA64_accept = DFA.UnpackEncodedString(DFA64_acceptS);
    static readonly short[] DFA64_special = DFA.UnpackEncodedString(DFA64_specialS);
    static readonly short[][] DFA64_transition = DFA.UnpackEncodedStringArray(DFA64_transitionS);

    protected class DFA64 : DFA
    {
        public DFA64(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 64;
            this.eot = DFA64_eot;
            this.eof = DFA64_eof;
            this.min = DFA64_min;
            this.max = DFA64_max;
            this.accept = DFA64_accept;
            this.special = DFA64_special;
            this.transition = DFA64_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 210:19: ( UINT | '/' | '-' | '*' | '>' | '<' )+"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_prog62 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_prog64 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_once_p_in_atom102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_every_p_in_atom111 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cron_p_in_atom120 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dayofweek_p_in_atom129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_void_p_in_atom138 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paren_p_in_atom147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_datetime_p_in_once_p171 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_once_p174 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_once_p177 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_once_p179 = new BitSet(new ulong[]{0x0000000008000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_once_p184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_8_in_every_p206 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p208 = new BitSet(new ulong[]{0x0000000008000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_every_p213 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_every_p216 = new BitSet(new ulong[]{0x0000000000000210UL});
    public static readonly BitSet FOLLOW_9_in_every_p219 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p221 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_datetime_p_in_every_p226 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_every_p231 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_every_p234 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p236 = new BitSet(new ulong[]{0x0000000008000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_every_p241 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_10_in_cron_p263 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p265 = new BitSet(new ulong[]{0x00000001F0040030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p273 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p275 = new BitSet(new ulong[]{0x00000001F0040030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p283 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p285 = new BitSet(new ulong[]{0x00000001F0040030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p293 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p295 = new BitSet(new ulong[]{0x00000001F0040030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p303 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p305 = new BitSet(new ulong[]{0x00000001F0040030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p313 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p319 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_cron_p322 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p324 = new BitSet(new ulong[]{0x0000000008000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_cron_p329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_11_in_dayofweek_p351 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_dayofweek_p353 = new BitSet(new ulong[]{0x0000000050040030UL});
    public static readonly BitSet FOLLOW_intspec_p_in_dayofweek_p358 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_dayofweek_p360 = new BitSet(new ulong[]{0x0000000050040030UL});
    public static readonly BitSet FOLLOW_intspec_p_in_dayofweek_p365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_void_p383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_paren_p401 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_expr_in_paren_p403 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_14_in_paren_p405 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_filter_p429 = new BitSet(new ulong[]{0x0000000000078012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p442 = new BitSet(new ulong[]{0x0000000000008010UL});
    public static readonly BitSet FOLLOW_15_in_filter_p445 = new BitSet(new ulong[]{0x0000000050040030UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p447 = new BitSet(new ulong[]{0x0000000050040030UL});
    public static readonly BitSet FOLLOW_intspec_p_in_filter_p452 = new BitSet(new ulong[]{0x0000000000078012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p467 = new BitSet(new ulong[]{0x0000000000010010UL});
    public static readonly BitSet FOLLOW_16_in_filter_p470 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p472 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_UINT_in_filter_p477 = new BitSet(new ulong[]{0x0000000000078012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p492 = new BitSet(new ulong[]{0x0000000000060010UL});
    public static readonly BitSet FOLLOW_set_in_filter_p497 = new BitSet(new ulong[]{0x0000000008000010UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p503 = new BitSet(new ulong[]{0x0000000008000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_filter_p508 = new BitSet(new ulong[]{0x0000000000078012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p523 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_filter_p526 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p528 = new BitSet(new ulong[]{0x0000000008000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_filter_p533 = new BitSet(new ulong[]{0x0000000000078012UL});
    public static readonly BitSet FOLLOW_WS_in_expr567 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_boolnonintersection_p_in_expr572 = new BitSet(new ulong[]{0x0000000000080012UL});
    public static readonly BitSet FOLLOW_WS_in_expr580 = new BitSet(new ulong[]{0x0000000000080010UL});
    public static readonly BitSet FOLLOW_19_in_expr583 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_expr585 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_boolnonintersection_p_in_expr590 = new BitSet(new ulong[]{0x0000000000080012UL});
    public static readonly BitSet FOLLOW_WS_in_expr597 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_boolintersection_p_in_boolnonintersection_p621 = new BitSet(new ulong[]{0x0000000000100012UL});
    public static readonly BitSet FOLLOW_WS_in_boolnonintersection_p629 = new BitSet(new ulong[]{0x0000000000100010UL});
    public static readonly BitSet FOLLOW_20_in_boolnonintersection_p632 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_boolnonintersection_p634 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_boolintersection_p_in_boolnonintersection_p639 = new BitSet(new ulong[]{0x0000000000100012UL});
    public static readonly BitSet FOLLOW_union_p_in_boolintersection_p664 = new BitSet(new ulong[]{0x0000000000200012UL});
    public static readonly BitSet FOLLOW_WS_in_boolintersection_p672 = new BitSet(new ulong[]{0x0000000000200010UL});
    public static readonly BitSet FOLLOW_21_in_boolintersection_p675 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_boolintersection_p677 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_union_p_in_boolintersection_p682 = new BitSet(new ulong[]{0x0000000000200012UL});
    public static readonly BitSet FOLLOW_difference_p_in_union_p715 = new BitSet(new ulong[]{0x0000000000400012UL});
    public static readonly BitSet FOLLOW_WS_in_union_p723 = new BitSet(new ulong[]{0x0000000000400010UL});
    public static readonly BitSet FOLLOW_22_in_union_p726 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_union_p728 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_difference_p_in_union_p733 = new BitSet(new ulong[]{0x0000000000400012UL});
    public static readonly BitSet FOLLOW_intersection_p_in_difference_p769 = new BitSet(new ulong[]{0x0000000000800012UL});
    public static readonly BitSet FOLLOW_WS_in_difference_p777 = new BitSet(new ulong[]{0x0000000000800010UL});
    public static readonly BitSet FOLLOW_23_in_difference_p780 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_difference_p782 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_intersection_p_in_difference_p787 = new BitSet(new ulong[]{0x0000000000800012UL});
    public static readonly BitSet FOLLOW_filter_p_in_intersection_p816 = new BitSet(new ulong[]{0x0000000001000012UL});
    public static readonly BitSet FOLLOW_WS_in_intersection_p824 = new BitSet(new ulong[]{0x0000000001000010UL});
    public static readonly BitSet FOLLOW_24_in_intersection_p827 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_intersection_p829 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_filter_p_in_intersection_p834 = new BitSet(new ulong[]{0x0000000001000012UL});
    public static readonly BitSet FOLLOW_year_p_in_datetime_p861 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_datetime_p863 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_month_p_in_datetime_p867 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_datetime_p869 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_day_p_in_datetime_p873 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_datetime_p876 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_hour24_p_in_datetime_p881 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_datetime_p883 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_minute60_p_in_datetime_p887 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_25_in_datetime_p890 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_second60_p_in_datetime_p894 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_datetime_p897 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_millisecond1000_p_in_datetime_p901 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_hour24_p_in_datetime_p916 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_datetime_p918 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_minute60_p_in_datetime_p922 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_25_in_datetime_p925 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_second60_p_in_datetime_p929 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_datetime_p932 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_millisecond1000_p_in_datetime_p936 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_datetime_p_in_datetime_prog960 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_datetime_prog962 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_year_p977 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_month_p989 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_day_p1001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_hour24_p1013 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_minute60_p1025 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_second60_p1037 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_millisecond1000_p1049 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_timespan_p1067 = new BitSet(new ulong[]{0x0000000050040020UL});
    public static readonly BitSet FOLLOW_days_p_in_timespan_p1074 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_timespan_p1076 = new BitSet(new ulong[]{0x0000000050040020UL});
    public static readonly BitSet FOLLOW_hours_p_in_timespan_p1082 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_timespan_p1084 = new BitSet(new ulong[]{0x0000000050040020UL});
    public static readonly BitSet FOLLOW_minutes_p_in_timespan_p1090 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_timespan_p1092 = new BitSet(new ulong[]{0x0000000050040020UL});
    public static readonly BitSet FOLLOW_seconds_p_in_timespan_p1098 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_timespan_p1101 = new BitSet(new ulong[]{0x0000000050040020UL});
    public static readonly BitSet FOLLOW_milliseconds_p_in_timespan_p1105 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_timespan_p_in_timespan_prog1127 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_timespan_prog1129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_days_p1144 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_hours_p1156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_minutes_p1168 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_seconds_p1180 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_milliseconds_p1192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cron_term_p_in_cron_field_p1201 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_19_in_cron_field_p1204 = new BitSet(new ulong[]{0x00000001F0040020UL});
    public static readonly BitSet FOLLOW_cron_term_p_in_cron_field_p1206 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_28_in_cron_term_p1214 = new BitSet(new ulong[]{0x00000001E0040020UL});
    public static readonly BitSet FOLLOW_set_in_cron_term_p1217 = new BitSet(new ulong[]{0x00000001E0040022UL});
    public static readonly BitSet FOLLOW_intspec_term_p_in_intspec_p1247 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_19_in_intspec_p1250 = new BitSet(new ulong[]{0x0000000050040020UL});
    public static readonly BitSet FOLLOW_intspec_term_p_in_intspec_p1252 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_28_in_intspec_term_p1260 = new BitSet(new ulong[]{0x0000000050040020UL});
    public static readonly BitSet FOLLOW_30_in_intspec_term_p1265 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_int_p_in_intspec_term_p1269 = new BitSet(new ulong[]{0x0000000020040002UL});
    public static readonly BitSet FOLLOW_18_in_intspec_term_p1273 = new BitSet(new ulong[]{0x0000000050040020UL});
    public static readonly BitSet FOLLOW_int_p_in_intspec_term_p1275 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_29_in_intspec_term_p1284 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_UINT_in_intspec_term_p1286 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_18_in_int_p1299 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_UINT_in_int_p1302 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred8_TimeDef174 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred8_TimeDef177 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred8_TimeDef179 = new BitSet(new ulong[]{0x0000000008000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred8_TimeDef184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred15_TimeDef231 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred15_TimeDef234 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred15_TimeDef236 = new BitSet(new ulong[]{0x0000000008000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred15_TimeDef241 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred23_TimeDef319 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred23_TimeDef322 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred23_TimeDef324 = new BitSet(new ulong[]{0x0000000008000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred23_TimeDef329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_19_in_synpred70_TimeDef1204 = new BitSet(new ulong[]{0x00000001F0040020UL});
    public static readonly BitSet FOLLOW_cron_term_p_in_synpred70_TimeDef1206 = new BitSet(new ulong[]{0x0000000000000002UL});

}
