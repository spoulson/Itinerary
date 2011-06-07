// $ANTLR 3.2 Sep 23, 2009 12:02:23 TimeDef.g 2011-06-07 17:49:19

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
		"'<='", 
		"'<'", 
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
		"'>'"
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
    public const int T__33 = 33;
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
    // TimeDef.g:47:1: atom returns [ISchedule value] : ( once_p | every_p | cron_p | dayofweek_p | void_p | paren_p );
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
            // TimeDef.g:47:31: ( once_p | every_p | cron_p | dayofweek_p | void_p | paren_p )
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
                    // TimeDef.g:48:4: once_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_once_p_in_atom103);
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
                    // TimeDef.g:49:4: every_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_every_p_in_atom112);
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
                    // TimeDef.g:50:4: cron_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_cron_p_in_atom121);
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
                    // TimeDef.g:51:4: dayofweek_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dayofweek_p_in_atom130);
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
                    // TimeDef.g:52:4: void_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_void_p_in_atom139);
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
                    // TimeDef.g:53:4: paren_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_paren_p_in_atom148);
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
    // TimeDef.g:59:1: once_p returns [OneTimeSchedule value] : (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) ;
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
            // TimeDef.g:59:39: ( (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:59:41: (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:59:41: (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:60:4: start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		PushFollow(FOLLOW_datetime_p_in_once_p172);
            		start = datetime_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, start.Tree);
            		// TimeDef.g:60:21: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            		int alt4 = 2;
            		alt4 = dfa4.Predict(input);
            		switch (alt4) 
            		{
            		    case 1 :
            		        // TimeDef.g:60:22: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
            		        {
            		        	// TimeDef.g:60:22: ( WS )+
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
            		        			    	WS9=(IToken)Match(input,WS,FOLLOW_WS_in_once_p175); if (state.failed) return retval;
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

            		        	string_literal10=(IToken)Match(input,7,FOLLOW_7_in_once_p178); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal10_tree = (object)adaptor.Create(string_literal10);
            		        		adaptor.AddChild(root_0, string_literal10_tree);
            		        	}
            		        	// TimeDef.g:60:36: ( WS )+
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
            		        			    	WS11=(IToken)Match(input,WS,FOLLOW_WS_in_once_p180); if (state.failed) return retval;
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

            		        	PushFollow(FOLLOW_timespan_p_in_once_p185);
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
    // TimeDef.g:63:1: every_p returns [IntervalSchedule value] : ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) ;
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
            // TimeDef.g:63:41: ( ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:63:43: ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:63:43: ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:64:4: 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		string_literal12=(IToken)Match(input,8,FOLLOW_8_in_every_p207); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{string_literal12_tree = (object)adaptor.Create(string_literal12);
            			adaptor.AddChild(root_0, string_literal12_tree);
            		}
            		// TimeDef.g:64:12: ( WS )+
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
            				    	WS13=(IToken)Match(input,WS,FOLLOW_WS_in_every_p209); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_timespan_p_in_every_p214);
            		interval = timespan_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, interval.Tree);
            		// TimeDef.g:64:36: ( ( WS )+ 'since' ( WS )+ sync= datetime_p )?
            		int alt8 = 2;
            		alt8 = dfa8.Predict(input);
            		switch (alt8) 
            		{
            		    case 1 :
            		        // TimeDef.g:64:37: ( WS )+ 'since' ( WS )+ sync= datetime_p
            		        {
            		        	// TimeDef.g:64:37: ( WS )+
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
            		        			    	WS14=(IToken)Match(input,WS,FOLLOW_WS_in_every_p217); if (state.failed) return retval;
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

            		        	string_literal15=(IToken)Match(input,9,FOLLOW_9_in_every_p220); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal15_tree = (object)adaptor.Create(string_literal15);
            		        		adaptor.AddChild(root_0, string_literal15_tree);
            		        	}
            		        	// TimeDef.g:64:49: ( WS )+
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
            		        			    	WS16=(IToken)Match(input,WS,FOLLOW_WS_in_every_p222); if (state.failed) return retval;
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

            		        	PushFollow(FOLLOW_datetime_p_in_every_p227);
            		        	sync = datetime_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sync.Tree);

            		        }
            		        break;

            		}

            		// TimeDef.g:64:71: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            		int alt11 = 2;
            		alt11 = dfa11.Predict(input);
            		switch (alt11) 
            		{
            		    case 1 :
            		        // TimeDef.g:64:72: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
            		        {
            		        	// TimeDef.g:64:72: ( WS )+
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
            		        			    	WS17=(IToken)Match(input,WS,FOLLOW_WS_in_every_p232); if (state.failed) return retval;
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

            		        	string_literal18=(IToken)Match(input,7,FOLLOW_7_in_every_p235); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal18_tree = (object)adaptor.Create(string_literal18);
            		        		adaptor.AddChild(root_0, string_literal18_tree);
            		        	}
            		        	// TimeDef.g:64:86: ( WS )+
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
            		        			    	WS19=(IToken)Match(input,WS,FOLLOW_WS_in_every_p237); if (state.failed) return retval;
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

            		        	PushFollow(FOLLOW_timespan_p_in_every_p242);
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
    // TimeDef.g:67:1: cron_p returns [CronSchedule value] : ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) ;
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
            // TimeDef.g:67:36: ( ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:67:38: ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:67:38: ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:68:4: 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		string_literal20=(IToken)Match(input,10,FOLLOW_10_in_cron_p264); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{string_literal20_tree = (object)adaptor.Create(string_literal20);
            			adaptor.AddChild(root_0, string_literal20_tree);
            		}
            		// TimeDef.g:68:11: ( WS )+
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
            				    	WS21=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p266); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p274);
            		minute = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, minute.Tree);
            		// TimeDef.g:69:24: ( WS )+
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
            				    	WS22=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p276); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p284);
            		hour = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, hour.Tree);
            		// TimeDef.g:70:22: ( WS )+
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
            				    	WS23=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p286); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p294);
            		day = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, day.Tree);
            		// TimeDef.g:71:21: ( WS )+
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
            				    	WS24=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p296); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p304);
            		month = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, month.Tree);
            		// TimeDef.g:72:23: ( WS )+
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
            				    	WS25=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p306); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p314);
            		dow = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dow.Tree);
            		// TimeDef.g:74:4: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            		int alt19 = 2;
            		alt19 = dfa19.Predict(input);
            		switch (alt19) 
            		{
            		    case 1 :
            		        // TimeDef.g:74:5: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
            		        {
            		        	// TimeDef.g:74:5: ( WS )+
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
            		        			    	WS26=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p320); if (state.failed) return retval;
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

            		        	string_literal27=(IToken)Match(input,7,FOLLOW_7_in_cron_p323); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal27_tree = (object)adaptor.Create(string_literal27);
            		        		adaptor.AddChild(root_0, string_literal27_tree);
            		        	}
            		        	// TimeDef.g:74:19: ( WS )+
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
            		        			    	WS28=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p325); if (state.failed) return retval;
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

            		        	PushFollow(FOLLOW_timespan_p_in_cron_p330);
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
    // TimeDef.g:77:1: dayofweek_p returns [DayOfWeekSchedule value] : ( 'week' ( WS )+ ordinal= intspec_p ( WS )+ dayofweek= intspec_p ) ;
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
            // TimeDef.g:77:46: ( ( 'week' ( WS )+ ordinal= intspec_p ( WS )+ dayofweek= intspec_p ) )
            // TimeDef.g:77:48: ( 'week' ( WS )+ ordinal= intspec_p ( WS )+ dayofweek= intspec_p )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:77:48: ( 'week' ( WS )+ ordinal= intspec_p ( WS )+ dayofweek= intspec_p )
            	// TimeDef.g:78:4: 'week' ( WS )+ ordinal= intspec_p ( WS )+ dayofweek= intspec_p
            	{
            		string_literal29=(IToken)Match(input,11,FOLLOW_11_in_dayofweek_p352); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{string_literal29_tree = (object)adaptor.Create(string_literal29);
            			adaptor.AddChild(root_0, string_literal29_tree);
            		}
            		// TimeDef.g:78:11: ( WS )+
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
            				    	WS30=(IToken)Match(input,WS,FOLLOW_WS_in_dayofweek_p354); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_intspec_p_in_dayofweek_p359);
            		ordinal = intspec_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ordinal.Tree);
            		// TimeDef.g:78:33: ( WS )+
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
            				    	WS31=(IToken)Match(input,WS,FOLLOW_WS_in_dayofweek_p361); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_intspec_p_in_dayofweek_p366);
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
    // TimeDef.g:81:1: void_p returns [VoidSchedule value] : 'void' ;
    public TimeDefParser.void_p_return void_p() // throws RecognitionException [1]
    {   
        TimeDefParser.void_p_return retval = new TimeDefParser.void_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal32 = null;

        object string_literal32_tree=null;

        try 
    	{
            // TimeDef.g:81:36: ( 'void' )
            // TimeDef.g:82:4: 'void'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal32=(IToken)Match(input,12,FOLLOW_12_in_void_p384); if (state.failed) return retval;
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
    // TimeDef.g:84:1: paren_p returns [ISchedule value] : ( '(' expr ')' ) ;
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
            // TimeDef.g:84:34: ( ( '(' expr ')' ) )
            // TimeDef.g:84:36: ( '(' expr ')' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:84:36: ( '(' expr ')' )
            	// TimeDef.g:85:4: '(' expr ')'
            	{
            		char_literal33=(IToken)Match(input,13,FOLLOW_13_in_paren_p402); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal33_tree = (object)adaptor.Create(char_literal33);
            			adaptor.AddChild(root_0, char_literal33_tree);
            		}
            		PushFollow(FOLLOW_expr_in_paren_p404);
            		expr34 = expr();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr34.Tree);
            		char_literal35=(IToken)Match(input,14,FOLLOW_14_in_paren_p406); if (state.failed) return retval;
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

    public class limit_p_return : ParserRuleReturnScope
    {
        public ISchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "limit_p"
    // TimeDef.g:92:1: limit_p returns [ISchedule value] : ( (limit_start= datetime_p ( WS )* '<=' ( WS )* A= filter_p ( WS )* '<' ( WS )* limit_end= datetime_p ) | B= atom );
    public TimeDefParser.limit_p_return limit_p() // throws RecognitionException [1]
    {   
        TimeDefParser.limit_p_return retval = new TimeDefParser.limit_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS36 = null;
        IToken string_literal37 = null;
        IToken WS38 = null;
        IToken WS39 = null;
        IToken char_literal40 = null;
        IToken WS41 = null;
        TimeDefParser.datetime_p_return limit_start = default(TimeDefParser.datetime_p_return);

        TimeDefParser.filter_p_return A = default(TimeDefParser.filter_p_return);

        TimeDefParser.datetime_p_return limit_end = default(TimeDefParser.datetime_p_return);

        TimeDefParser.atom_return B = default(TimeDefParser.atom_return);


        object WS36_tree=null;
        object string_literal37_tree=null;
        object WS38_tree=null;
        object WS39_tree=null;
        object char_literal40_tree=null;
        object WS41_tree=null;

        try 
    	{
            // TimeDef.g:92:34: ( (limit_start= datetime_p ( WS )* '<=' ( WS )* A= filter_p ( WS )* '<' ( WS )* limit_end= datetime_p ) | B= atom )
            int alt26 = 2;
            alt26 = dfa26.Predict(input);
            switch (alt26) 
            {
                case 1 :
                    // TimeDef.g:93:4: (limit_start= datetime_p ( WS )* '<=' ( WS )* A= filter_p ( WS )* '<' ( WS )* limit_end= datetime_p )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// TimeDef.g:93:4: (limit_start= datetime_p ( WS )* '<=' ( WS )* A= filter_p ( WS )* '<' ( WS )* limit_end= datetime_p )
                    	// TimeDef.g:93:5: limit_start= datetime_p ( WS )* '<=' ( WS )* A= filter_p ( WS )* '<' ( WS )* limit_end= datetime_p
                    	{
                    		PushFollow(FOLLOW_datetime_p_in_limit_p431);
                    		limit_start = datetime_p();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, limit_start.Tree);
                    		// TimeDef.g:93:28: ( WS )*
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
                    				    	WS36=(IToken)Match(input,WS,FOLLOW_WS_in_limit_p433); if (state.failed) return retval;
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

                    		string_literal37=(IToken)Match(input,15,FOLLOW_15_in_limit_p436); if (state.failed) return retval;
                    		if ( state.backtracking == 0 )
                    		{string_literal37_tree = (object)adaptor.Create(string_literal37);
                    			adaptor.AddChild(root_0, string_literal37_tree);
                    		}
                    		// TimeDef.g:93:37: ( WS )*
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
                    				    	WS38=(IToken)Match(input,WS,FOLLOW_WS_in_limit_p438); if (state.failed) return retval;
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

                    		PushFollow(FOLLOW_filter_p_in_limit_p443);
                    		A = filter_p();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
                    		// TimeDef.g:93:52: ( WS )*
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
                    				    	WS39=(IToken)Match(input,WS,FOLLOW_WS_in_limit_p445); if (state.failed) return retval;
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

                    		char_literal40=(IToken)Match(input,16,FOLLOW_16_in_limit_p448); if (state.failed) return retval;
                    		if ( state.backtracking == 0 )
                    		{char_literal40_tree = (object)adaptor.Create(char_literal40);
                    			adaptor.AddChild(root_0, char_literal40_tree);
                    		}
                    		// TimeDef.g:93:60: ( WS )*
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
                    				    	WS41=(IToken)Match(input,WS,FOLLOW_WS_in_limit_p450); if (state.failed) return retval;
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

                    		PushFollow(FOLLOW_datetime_p_in_limit_p455);
                    		limit_end = datetime_p();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, limit_end.Tree);

                    	}

                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  new LimitSchedule(((limit_start != null) ? limit_start.value : default(DateTime)), ((limit_end != null) ? limit_end.value : default(DateTime)), ((A != null) ? A.value : default(ISchedule))); 
                    	}

                    }
                    break;
                case 2 :
                    // TimeDef.g:94:4: B= atom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_atom_in_limit_p467);
                    	B = atom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, B.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((B != null) ? B.value : default(ISchedule)); 
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
    // $ANTLR end "limit_p"

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
    // TimeDef.g:97:1: filter_p returns [ISchedule value] : A= limit_p ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )* ;
    public TimeDefParser.filter_p_return filter_p() // throws RecognitionException [1]
    {   
        TimeDefParser.filter_p_return retval = new TimeDefParser.filter_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken repeatcount = null;
        IToken op = null;
        IToken WS42 = null;
        IToken char_literal43 = null;
        IToken WS44 = null;
        IToken WS45 = null;
        IToken char_literal46 = null;
        IToken WS47 = null;
        IToken WS48 = null;
        IToken WS49 = null;
        IToken WS50 = null;
        IToken string_literal51 = null;
        IToken WS52 = null;
        TimeDefParser.limit_p_return A = default(TimeDefParser.limit_p_return);

        TimeDefParser.intspec_p_return index_intspec = default(TimeDefParser.intspec_p_return);

        TimeDefParser.timespan_p_return offset_timespan = default(TimeDefParser.timespan_p_return);

        TimeDefParser.timespan_p_return lasting_timespan = default(TimeDefParser.timespan_p_return);


        object repeatcount_tree=null;
        object op_tree=null;
        object WS42_tree=null;
        object char_literal43_tree=null;
        object WS44_tree=null;
        object WS45_tree=null;
        object char_literal46_tree=null;
        object WS47_tree=null;
        object WS48_tree=null;
        object WS49_tree=null;
        object WS50_tree=null;
        object string_literal51_tree=null;
        object WS52_tree=null;

        try 
    	{
            // TimeDef.g:97:35: (A= limit_p ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )* )
            // TimeDef.g:98:4: A= limit_p ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_limit_p_in_filter_p486);
            	A = limit_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:98:37: ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*
            	do 
            	{
            	    int alt35 = 5;
            	    alt35 = dfa35.Predict(input);
            	    switch (alt35) 
            		{
            			case 1 :
            			    // TimeDef.g:99:7: ( ( WS )* '#' ( WS )* index_intspec= intspec_p )
            			    {
            			    	// TimeDef.g:99:7: ( ( WS )* '#' ( WS )* index_intspec= intspec_p )
            			    	// TimeDef.g:99:8: ( WS )* '#' ( WS )* index_intspec= intspec_p
            			    	{
            			    		// TimeDef.g:99:8: ( WS )*
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
            			    				    	WS42=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p499); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS42_tree = (object)adaptor.Create(WS42);
            			    				    		adaptor.AddChild(root_0, WS42_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop27;
            			    		    }
            			    		} while (true);

            			    		loop27:
            			    			;	// Stops C# compiler whining that label 'loop27' has no statements

            			    		char_literal43=(IToken)Match(input,17,FOLLOW_17_in_filter_p502); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal43_tree = (object)adaptor.Create(char_literal43);
            			    			adaptor.AddChild(root_0, char_literal43_tree);
            			    		}
            			    		// TimeDef.g:99:16: ( WS )*
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
            			    				    	WS44=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p504); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS44_tree = (object)adaptor.Create(WS44);
            			    				    		adaptor.AddChild(root_0, WS44_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop28;
            			    		    }
            			    		} while (true);

            			    		loop28:
            			    			;	// Stops C# compiler whining that label 'loop28' has no statements

            			    		PushFollow(FOLLOW_intspec_p_in_filter_p509);
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
            			    // TimeDef.g:100:7: ( ( WS )* 'x' ( WS )* repeatcount= UINT )
            			    {
            			    	// TimeDef.g:100:7: ( ( WS )* 'x' ( WS )* repeatcount= UINT )
            			    	// TimeDef.g:100:8: ( WS )* 'x' ( WS )* repeatcount= UINT
            			    	{
            			    		// TimeDef.g:100:8: ( WS )*
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
            			    				    	WS45=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p524); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS45_tree = (object)adaptor.Create(WS45);
            			    				    		adaptor.AddChild(root_0, WS45_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop29;
            			    		    }
            			    		} while (true);

            			    		loop29:
            			    			;	// Stops C# compiler whining that label 'loop29' has no statements

            			    		char_literal46=(IToken)Match(input,18,FOLLOW_18_in_filter_p527); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal46_tree = (object)adaptor.Create(char_literal46);
            			    			adaptor.AddChild(root_0, char_literal46_tree);
            			    		}
            			    		// TimeDef.g:100:16: ( WS )*
            			    		do 
            			    		{
            			    		    int alt30 = 2;
            			    		    int LA30_0 = input.LA(1);

            			    		    if ( (LA30_0 == WS) )
            			    		    {
            			    		        alt30 = 1;
            			    		    }


            			    		    switch (alt30) 
            			    			{
            			    				case 1 :
            			    				    // TimeDef.g:0:0: WS
            			    				    {
            			    				    	WS47=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p529); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS47_tree = (object)adaptor.Create(WS47);
            			    				    		adaptor.AddChild(root_0, WS47_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop30;
            			    		    }
            			    		} while (true);

            			    		loop30:
            			    			;	// Stops C# compiler whining that label 'loop30' has no statements

            			    		repeatcount=(IToken)Match(input,UINT,FOLLOW_UINT_in_filter_p534); if (state.failed) return retval;
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
            			    // TimeDef.g:101:7: ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p )
            			    {
            			    	// TimeDef.g:101:7: ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p )
            			    	// TimeDef.g:101:8: ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p
            			    	{
            			    		// TimeDef.g:101:8: ( WS )*
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
            			    				    	WS48=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p549); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS48_tree = (object)adaptor.Create(WS48);
            			    				    		adaptor.AddChild(root_0, WS48_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop31;
            			    		    }
            			    		} while (true);

            			    		loop31:
            			    			;	// Stops C# compiler whining that label 'loop31' has no statements

            			    		op = (IToken)input.LT(1);
            			    		if ( (input.LA(1) >= 19 && input.LA(1) <= 20) ) 
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

            			    		// TimeDef.g:101:25: ( WS )*
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
            			    				    	WS49=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p560); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS49_tree = (object)adaptor.Create(WS49);
            			    				    		adaptor.AddChild(root_0, WS49_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop32;
            			    		    }
            			    		} while (true);

            			    		loop32:
            			    			;	// Stops C# compiler whining that label 'loop32' has no statements

            			    		PushFollow(FOLLOW_timespan_p_in_filter_p565);
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
            			    // TimeDef.g:102:7: ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p )
            			    {
            			    	// TimeDef.g:102:7: ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p )
            			    	// TimeDef.g:102:8: ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p
            			    	{
            			    		// TimeDef.g:102:8: ( WS )+
            			    		int cnt33 = 0;
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
            			    				    	WS50=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p580); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS50_tree = (object)adaptor.Create(WS50);
            			    				    		adaptor.AddChild(root_0, WS50_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    if ( cnt33 >= 1 ) goto loop33;
            			    				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    			            EarlyExitException eee33 =
            			    			                new EarlyExitException(33, input);
            			    			            throw eee33;
            			    		    }
            			    		    cnt33++;
            			    		} while (true);

            			    		loop33:
            			    			;	// Stops C# compiler whining that label 'loop33' has no statements

            			    		string_literal51=(IToken)Match(input,7,FOLLOW_7_in_filter_p583); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{string_literal51_tree = (object)adaptor.Create(string_literal51);
            			    			adaptor.AddChild(root_0, string_literal51_tree);
            			    		}
            			    		// TimeDef.g:102:22: ( WS )+
            			    		int cnt34 = 0;
            			    		do 
            			    		{
            			    		    int alt34 = 2;
            			    		    int LA34_0 = input.LA(1);

            			    		    if ( (LA34_0 == WS) )
            			    		    {
            			    		        alt34 = 1;
            			    		    }


            			    		    switch (alt34) 
            			    			{
            			    				case 1 :
            			    				    // TimeDef.g:0:0: WS
            			    				    {
            			    				    	WS52=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p585); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS52_tree = (object)adaptor.Create(WS52);
            			    				    		adaptor.AddChild(root_0, WS52_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    if ( cnt34 >= 1 ) goto loop34;
            			    				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    			            EarlyExitException eee34 =
            			    			                new EarlyExitException(34, input);
            			    			            throw eee34;
            			    		    }
            			    		    cnt34++;
            			    		} while (true);

            			    		loop34:
            			    			;	// Stops C# compiler whining that label 'loop34' has no statements

            			    		PushFollow(FOLLOW_timespan_p_in_filter_p590);
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
            			    goto loop35;
            	    }
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements


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
    // TimeDef.g:107:1: expr returns [ISchedule value] : ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* ) ;
    public TimeDefParser.expr_return expr() // throws RecognitionException [1]
    {   
        TimeDefParser.expr_return retval = new TimeDefParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS53 = null;
        IToken WS54 = null;
        IToken char_literal55 = null;
        IToken WS56 = null;
        IToken WS57 = null;
        TimeDefParser.boolnonintersection_p_return A = default(TimeDefParser.boolnonintersection_p_return);

        TimeDefParser.boolnonintersection_p_return B = default(TimeDefParser.boolnonintersection_p_return);


        object WS53_tree=null;
        object WS54_tree=null;
        object char_literal55_tree=null;
        object WS56_tree=null;
        object WS57_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:111:1: ( ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* ) )
            // TimeDef.g:111:3: ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:111:3: ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* )
            	// TimeDef.g:112:4: ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )*
            	{
            		// TimeDef.g:112:4: ( WS )*
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
            				    	WS53=(IToken)Match(input,WS,FOLLOW_WS_in_expr624); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS53_tree = (object)adaptor.Create(WS53);
            				    		adaptor.AddChild(root_0, WS53_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    goto loop36;
            		    }
            		} while (true);

            		loop36:
            			;	// Stops C# compiler whining that label 'loop36' has no statements

            		PushFollow(FOLLOW_boolnonintersection_p_in_expr629);
            		A = boolnonintersection_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:113:4: ( ( WS )* ',' ( WS )* B= boolnonintersection_p )*
            		do 
            		{
            		    int alt39 = 2;
            		    alt39 = dfa39.Predict(input);
            		    switch (alt39) 
            			{
            				case 1 :
            				    // TimeDef.g:113:5: ( WS )* ',' ( WS )* B= boolnonintersection_p
            				    {
            				    	// TimeDef.g:113:5: ( WS )*
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
            				    			    	WS54=(IToken)Match(input,WS,FOLLOW_WS_in_expr637); if (state.failed) return retval;
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

            				    	char_literal55=(IToken)Match(input,21,FOLLOW_21_in_expr640); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{char_literal55_tree = (object)adaptor.Create(char_literal55);
            				    		adaptor.AddChild(root_0, char_literal55_tree);
            				    	}
            				    	// TimeDef.g:113:13: ( WS )*
            				    	do 
            				    	{
            				    	    int alt38 = 2;
            				    	    int LA38_0 = input.LA(1);

            				    	    if ( (LA38_0 == WS) )
            				    	    {
            				    	        alt38 = 1;
            				    	    }


            				    	    switch (alt38) 
            				    		{
            				    			case 1 :
            				    			    // TimeDef.g:0:0: WS
            				    			    {
            				    			    	WS56=(IToken)Match(input,WS,FOLLOW_WS_in_expr642); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS56_tree = (object)adaptor.Create(WS56);
            				    			    		adaptor.AddChild(root_0, WS56_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop38;
            				    	    }
            				    	} while (true);

            				    	loop38:
            				    		;	// Stops C# compiler whining that label 'loop38' has no statements

            				    	PushFollow(FOLLOW_boolnonintersection_p_in_expr647);
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
            				    goto loop39;
            		    }
            		} while (true);

            		loop39:
            			;	// Stops C# compiler whining that label 'loop39' has no statements

            		// TimeDef.g:113:73: ( WS )*
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
            				    	WS57=(IToken)Match(input,WS,FOLLOW_WS_in_expr654); if (state.failed) return retval;
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
    // TimeDef.g:119:1: boolnonintersection_p returns [ISchedule value] : A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )* ;
    public TimeDefParser.boolnonintersection_p_return boolnonintersection_p() // throws RecognitionException [1]
    {   
        TimeDefParser.boolnonintersection_p_return retval = new TimeDefParser.boolnonintersection_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS58 = null;
        IToken string_literal59 = null;
        IToken WS60 = null;
        TimeDefParser.boolintersection_p_return A = default(TimeDefParser.boolintersection_p_return);

        TimeDefParser.boolintersection_p_return B = default(TimeDefParser.boolintersection_p_return);


        object WS58_tree=null;
        object string_literal59_tree=null;
        object WS60_tree=null;

        try 
    	{
            // TimeDef.g:119:48: (A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )* )
            // TimeDef.g:120:4: A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_boolintersection_p_in_boolnonintersection_p678);
            	A = boolintersection_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:121:4: ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*
            	do 
            	{
            	    int alt43 = 2;
            	    alt43 = dfa43.Predict(input);
            	    switch (alt43) 
            		{
            			case 1 :
            			    // TimeDef.g:121:5: ( WS )* '!&&' ( WS )* B= boolintersection_p
            			    {
            			    	// TimeDef.g:121:5: ( WS )*
            			    	do 
            			    	{
            			    	    int alt41 = 2;
            			    	    int LA41_0 = input.LA(1);

            			    	    if ( (LA41_0 == WS) )
            			    	    {
            			    	        alt41 = 1;
            			    	    }


            			    	    switch (alt41) 
            			    		{
            			    			case 1 :
            			    			    // TimeDef.g:0:0: WS
            			    			    {
            			    			    	WS58=(IToken)Match(input,WS,FOLLOW_WS_in_boolnonintersection_p686); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS58_tree = (object)adaptor.Create(WS58);
            			    			    		adaptor.AddChild(root_0, WS58_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop41;
            			    	    }
            			    	} while (true);

            			    	loop41:
            			    		;	// Stops C# compiler whining that label 'loop41' has no statements

            			    	string_literal59=(IToken)Match(input,22,FOLLOW_22_in_boolnonintersection_p689); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal59_tree = (object)adaptor.Create(string_literal59);
            			    		adaptor.AddChild(root_0, string_literal59_tree);
            			    	}
            			    	// TimeDef.g:121:15: ( WS )*
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
            			    			    	WS60=(IToken)Match(input,WS,FOLLOW_WS_in_boolnonintersection_p691); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS60_tree = (object)adaptor.Create(WS60);
            			    			    		adaptor.AddChild(root_0, WS60_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop42;
            			    	    }
            			    	} while (true);

            			    	loop42:
            			    		;	// Stops C# compiler whining that label 'loop42' has no statements

            			    	PushFollow(FOLLOW_boolintersection_p_in_boolnonintersection_p696);
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
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements


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
    // TimeDef.g:127:1: boolintersection_p returns [ISchedule value] : A= union_p ( ( WS )* '&&' ( WS )* B= union_p )* ;
    public TimeDefParser.boolintersection_p_return boolintersection_p() // throws RecognitionException [1]
    {   
        TimeDefParser.boolintersection_p_return retval = new TimeDefParser.boolintersection_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS61 = null;
        IToken string_literal62 = null;
        IToken WS63 = null;
        TimeDefParser.union_p_return A = default(TimeDefParser.union_p_return);

        TimeDefParser.union_p_return B = default(TimeDefParser.union_p_return);


        object WS61_tree=null;
        object string_literal62_tree=null;
        object WS63_tree=null;

        try 
    	{
            // TimeDef.g:127:45: (A= union_p ( ( WS )* '&&' ( WS )* B= union_p )* )
            // TimeDef.g:128:4: A= union_p ( ( WS )* '&&' ( WS )* B= union_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_union_p_in_boolintersection_p721);
            	A = union_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:129:4: ( ( WS )* '&&' ( WS )* B= union_p )*
            	do 
            	{
            	    int alt46 = 2;
            	    alt46 = dfa46.Predict(input);
            	    switch (alt46) 
            		{
            			case 1 :
            			    // TimeDef.g:129:5: ( WS )* '&&' ( WS )* B= union_p
            			    {
            			    	// TimeDef.g:129:5: ( WS )*
            			    	do 
            			    	{
            			    	    int alt44 = 2;
            			    	    int LA44_0 = input.LA(1);

            			    	    if ( (LA44_0 == WS) )
            			    	    {
            			    	        alt44 = 1;
            			    	    }


            			    	    switch (alt44) 
            			    		{
            			    			case 1 :
            			    			    // TimeDef.g:0:0: WS
            			    			    {
            			    			    	WS61=(IToken)Match(input,WS,FOLLOW_WS_in_boolintersection_p729); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS61_tree = (object)adaptor.Create(WS61);
            			    			    		adaptor.AddChild(root_0, WS61_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop44;
            			    	    }
            			    	} while (true);

            			    	loop44:
            			    		;	// Stops C# compiler whining that label 'loop44' has no statements

            			    	string_literal62=(IToken)Match(input,23,FOLLOW_23_in_boolintersection_p732); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal62_tree = (object)adaptor.Create(string_literal62);
            			    		adaptor.AddChild(root_0, string_literal62_tree);
            			    	}
            			    	// TimeDef.g:129:14: ( WS )*
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
            			    			    	WS63=(IToken)Match(input,WS,FOLLOW_WS_in_boolintersection_p734); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS63_tree = (object)adaptor.Create(WS63);
            			    			    		adaptor.AddChild(root_0, WS63_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop45;
            			    	    }
            			    	} while (true);

            			    	loop45:
            			    		;	// Stops C# compiler whining that label 'loop45' has no statements

            			    	PushFollow(FOLLOW_union_p_in_boolintersection_p739);
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
            			    goto loop46;
            	    }
            	} while (true);

            	loop46:
            		;	// Stops C# compiler whining that label 'loop46' has no statements


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
    // TimeDef.g:135:1: union_p returns [ISchedule value] : (A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )* ) ;
    public TimeDefParser.union_p_return union_p() // throws RecognitionException [1]
    {   
        TimeDefParser.union_p_return retval = new TimeDefParser.union_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS64 = null;
        IToken char_literal65 = null;
        IToken WS66 = null;
        TimeDefParser.difference_p_return A = default(TimeDefParser.difference_p_return);

        TimeDefParser.difference_p_return B = default(TimeDefParser.difference_p_return);


        object WS64_tree=null;
        object char_literal65_tree=null;
        object WS66_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:139:1: ( (A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )* ) )
            // TimeDef.g:139:3: (A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:139:3: (A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )* )
            	// TimeDef.g:140:4: A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )*
            	{
            		PushFollow(FOLLOW_difference_p_in_union_p772);
            		A = difference_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:141:4: ( ( WS )* '|' ( WS )* B= difference_p )*
            		do 
            		{
            		    int alt49 = 2;
            		    alt49 = dfa49.Predict(input);
            		    switch (alt49) 
            			{
            				case 1 :
            				    // TimeDef.g:141:5: ( WS )* '|' ( WS )* B= difference_p
            				    {
            				    	// TimeDef.g:141:5: ( WS )*
            				    	do 
            				    	{
            				    	    int alt47 = 2;
            				    	    int LA47_0 = input.LA(1);

            				    	    if ( (LA47_0 == WS) )
            				    	    {
            				    	        alt47 = 1;
            				    	    }


            				    	    switch (alt47) 
            				    		{
            				    			case 1 :
            				    			    // TimeDef.g:0:0: WS
            				    			    {
            				    			    	WS64=(IToken)Match(input,WS,FOLLOW_WS_in_union_p780); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS64_tree = (object)adaptor.Create(WS64);
            				    			    		adaptor.AddChild(root_0, WS64_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop47;
            				    	    }
            				    	} while (true);

            				    	loop47:
            				    		;	// Stops C# compiler whining that label 'loop47' has no statements

            				    	char_literal65=(IToken)Match(input,24,FOLLOW_24_in_union_p783); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{char_literal65_tree = (object)adaptor.Create(char_literal65);
            				    		adaptor.AddChild(root_0, char_literal65_tree);
            				    	}
            				    	// TimeDef.g:141:13: ( WS )*
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
            				    			    	WS66=(IToken)Match(input,WS,FOLLOW_WS_in_union_p785); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS66_tree = (object)adaptor.Create(WS66);
            				    			    		adaptor.AddChild(root_0, WS66_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop48;
            				    	    }
            				    	} while (true);

            				    	loop48:
            				    		;	// Stops C# compiler whining that label 'loop48' has no statements

            				    	PushFollow(FOLLOW_difference_p_in_union_p790);
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
            				    goto loop49;
            		    }
            		} while (true);

            		loop49:
            			;	// Stops C# compiler whining that label 'loop49' has no statements


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
    // TimeDef.g:147:1: difference_p returns [ISchedule value] : (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* ) ;
    public TimeDefParser.difference_p_return difference_p() // throws RecognitionException [1]
    {   
        TimeDefParser.difference_p_return retval = new TimeDefParser.difference_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS67 = null;
        IToken string_literal68 = null;
        IToken WS69 = null;
        TimeDefParser.intersection_p_return A = default(TimeDefParser.intersection_p_return);

        TimeDefParser.intersection_p_return B = default(TimeDefParser.intersection_p_return);


        object WS67_tree=null;
        object string_literal68_tree=null;
        object WS69_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:151:1: ( (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* ) )
            // TimeDef.g:151:3: (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:151:3: (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* )
            	// TimeDef.g:152:4: A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )*
            	{
            		PushFollow(FOLLOW_intersection_p_in_difference_p826);
            		A = intersection_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:153:4: ( ( WS )* '!&' ( WS )* B= intersection_p )*
            		do 
            		{
            		    int alt52 = 2;
            		    alt52 = dfa52.Predict(input);
            		    switch (alt52) 
            			{
            				case 1 :
            				    // TimeDef.g:153:5: ( WS )* '!&' ( WS )* B= intersection_p
            				    {
            				    	// TimeDef.g:153:5: ( WS )*
            				    	do 
            				    	{
            				    	    int alt50 = 2;
            				    	    int LA50_0 = input.LA(1);

            				    	    if ( (LA50_0 == WS) )
            				    	    {
            				    	        alt50 = 1;
            				    	    }


            				    	    switch (alt50) 
            				    		{
            				    			case 1 :
            				    			    // TimeDef.g:0:0: WS
            				    			    {
            				    			    	WS67=(IToken)Match(input,WS,FOLLOW_WS_in_difference_p834); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS67_tree = (object)adaptor.Create(WS67);
            				    			    		adaptor.AddChild(root_0, WS67_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop50;
            				    	    }
            				    	} while (true);

            				    	loop50:
            				    		;	// Stops C# compiler whining that label 'loop50' has no statements

            				    	string_literal68=(IToken)Match(input,25,FOLLOW_25_in_difference_p837); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{string_literal68_tree = (object)adaptor.Create(string_literal68);
            				    		adaptor.AddChild(root_0, string_literal68_tree);
            				    	}
            				    	// TimeDef.g:153:14: ( WS )*
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
            				    			    	WS69=(IToken)Match(input,WS,FOLLOW_WS_in_difference_p839); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS69_tree = (object)adaptor.Create(WS69);
            				    			    		adaptor.AddChild(root_0, WS69_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop51;
            				    	    }
            				    	} while (true);

            				    	loop51:
            				    		;	// Stops C# compiler whining that label 'loop51' has no statements

            				    	PushFollow(FOLLOW_intersection_p_in_difference_p844);
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
            				    goto loop52;
            		    }
            		} while (true);

            		loop52:
            			;	// Stops C# compiler whining that label 'loop52' has no statements


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
    // TimeDef.g:160:1: intersection_p returns [ISchedule value] : A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )* ;
    public TimeDefParser.intersection_p_return intersection_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intersection_p_return retval = new TimeDefParser.intersection_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS70 = null;
        IToken char_literal71 = null;
        IToken WS72 = null;
        TimeDefParser.filter_p_return A = default(TimeDefParser.filter_p_return);

        TimeDefParser.filter_p_return B = default(TimeDefParser.filter_p_return);


        object WS70_tree=null;
        object char_literal71_tree=null;
        object WS72_tree=null;

        try 
    	{
            // TimeDef.g:160:41: (A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )* )
            // TimeDef.g:161:4: A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_filter_p_in_intersection_p873);
            	A = filter_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:162:4: ( ( WS )* '&' ( WS )* B= filter_p )*
            	do 
            	{
            	    int alt55 = 2;
            	    alt55 = dfa55.Predict(input);
            	    switch (alt55) 
            		{
            			case 1 :
            			    // TimeDef.g:162:5: ( WS )* '&' ( WS )* B= filter_p
            			    {
            			    	// TimeDef.g:162:5: ( WS )*
            			    	do 
            			    	{
            			    	    int alt53 = 2;
            			    	    int LA53_0 = input.LA(1);

            			    	    if ( (LA53_0 == WS) )
            			    	    {
            			    	        alt53 = 1;
            			    	    }


            			    	    switch (alt53) 
            			    		{
            			    			case 1 :
            			    			    // TimeDef.g:0:0: WS
            			    			    {
            			    			    	WS70=(IToken)Match(input,WS,FOLLOW_WS_in_intersection_p881); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS70_tree = (object)adaptor.Create(WS70);
            			    			    		adaptor.AddChild(root_0, WS70_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop53;
            			    	    }
            			    	} while (true);

            			    	loop53:
            			    		;	// Stops C# compiler whining that label 'loop53' has no statements

            			    	char_literal71=(IToken)Match(input,26,FOLLOW_26_in_intersection_p884); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal71_tree = (object)adaptor.Create(char_literal71);
            			    		adaptor.AddChild(root_0, char_literal71_tree);
            			    	}
            			    	// TimeDef.g:162:13: ( WS )*
            			    	do 
            			    	{
            			    	    int alt54 = 2;
            			    	    int LA54_0 = input.LA(1);

            			    	    if ( (LA54_0 == WS) )
            			    	    {
            			    	        alt54 = 1;
            			    	    }


            			    	    switch (alt54) 
            			    		{
            			    			case 1 :
            			    			    // TimeDef.g:0:0: WS
            			    			    {
            			    			    	WS72=(IToken)Match(input,WS,FOLLOW_WS_in_intersection_p886); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS72_tree = (object)adaptor.Create(WS72);
            			    			    		adaptor.AddChild(root_0, WS72_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop54;
            			    	    }
            			    	} while (true);

            			    	loop54:
            			    		;	// Stops C# compiler whining that label 'loop54' has no statements

            			    	PushFollow(FOLLOW_filter_p_in_intersection_p891);
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
            			    goto loop55;
            	    }
            	} while (true);

            	loop55:
            		;	// Stops C# compiler whining that label 'loop55' has no statements


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
    // TimeDef.g:168:1: datetime_p returns [DateTime value] : (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? ) ;
    public TimeDefParser.datetime_p_return datetime_p() // throws RecognitionException [1]
    {   
        TimeDefParser.datetime_p_return retval = new TimeDefParser.datetime_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal73 = null;
        IToken char_literal74 = null;
        IToken WS75 = null;
        IToken char_literal76 = null;
        IToken char_literal77 = null;
        IToken char_literal78 = null;
        IToken char_literal79 = null;
        IToken char_literal80 = null;
        IToken char_literal81 = null;
        TimeDefParser.year_p_return y = default(TimeDefParser.year_p_return);

        TimeDefParser.month_p_return mo = default(TimeDefParser.month_p_return);

        TimeDefParser.day_p_return d = default(TimeDefParser.day_p_return);

        TimeDefParser.hour24_p_return h = default(TimeDefParser.hour24_p_return);

        TimeDefParser.minute60_p_return m = default(TimeDefParser.minute60_p_return);

        TimeDefParser.second60_p_return s = default(TimeDefParser.second60_p_return);

        TimeDefParser.millisecond1000_p_return ms = default(TimeDefParser.millisecond1000_p_return);


        object char_literal73_tree=null;
        object char_literal74_tree=null;
        object WS75_tree=null;
        object char_literal76_tree=null;
        object char_literal77_tree=null;
        object char_literal78_tree=null;
        object char_literal79_tree=null;
        object char_literal80_tree=null;
        object char_literal81_tree=null;

        try 
    	{
            // TimeDef.g:168:36: ( (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? ) )
            // TimeDef.g:168:38: (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:168:38: (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )
            	int alt62 = 2;
            	int LA62_0 = input.LA(1);

            	if ( (LA62_0 == UINT) )
            	{
            	    int LA62_1 = input.LA(2);

            	    if ( (LA62_1 == 20) )
            	    {
            	        alt62 = 1;
            	    }
            	    else if ( (LA62_1 == 27) )
            	    {
            	        alt62 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d62s1 =
            	            new NoViableAltException("", 62, 1, input);

            	        throw nvae_d62s1;
            	    }
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d62s0 =
            	        new NoViableAltException("", 62, 0, input);

            	    throw nvae_d62s0;
            	}
            	switch (alt62) 
            	{
            	    case 1 :
            	        // TimeDef.g:169:4: y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?
            	        {
            	        	PushFollow(FOLLOW_year_p_in_datetime_p918);
            	        	y = year_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, y.Tree);
            	        	char_literal73=(IToken)Match(input,20,FOLLOW_20_in_datetime_p920); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal73_tree = (object)adaptor.Create(char_literal73);
            	        		adaptor.AddChild(root_0, char_literal73_tree);
            	        	}
            	        	PushFollow(FOLLOW_month_p_in_datetime_p924);
            	        	mo = month_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mo.Tree);
            	        	char_literal74=(IToken)Match(input,20,FOLLOW_20_in_datetime_p926); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal74_tree = (object)adaptor.Create(char_literal74);
            	        		adaptor.AddChild(root_0, char_literal74_tree);
            	        	}
            	        	PushFollow(FOLLOW_day_p_in_datetime_p930);
            	        	d = day_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, d.Tree);
            	        	// TimeDef.g:169:40: ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?
            	        	int alt59 = 2;
            	        	alt59 = dfa59.Predict(input);
            	        	switch (alt59) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:169:41: ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	        {
            	        	        	// TimeDef.g:169:41: ( WS )+
            	        	        	int cnt56 = 0;
            	        	        	do 
            	        	        	{
            	        	        	    int alt56 = 2;
            	        	        	    int LA56_0 = input.LA(1);

            	        	        	    if ( (LA56_0 == WS) )
            	        	        	    {
            	        	        	        alt56 = 1;
            	        	        	    }


            	        	        	    switch (alt56) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // TimeDef.g:0:0: WS
            	        	        			    {
            	        	        			    	WS75=(IToken)Match(input,WS,FOLLOW_WS_in_datetime_p933); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{WS75_tree = (object)adaptor.Create(WS75);
            	        	        			    		adaptor.AddChild(root_0, WS75_tree);
            	        	        			    	}

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    if ( cnt56 >= 1 ) goto loop56;
            	        	        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	        		            EarlyExitException eee56 =
            	        	        		                new EarlyExitException(56, input);
            	        	        		            throw eee56;
            	        	        	    }
            	        	        	    cnt56++;
            	        	        	} while (true);

            	        	        	loop56:
            	        	        		;	// Stops C# compiler whining that label 'loop56' has no statements

            	        	        	PushFollow(FOLLOW_hour24_p_in_datetime_p938);
            	        	        	h = hour24_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            	        	        	char_literal76=(IToken)Match(input,27,FOLLOW_27_in_datetime_p940); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal76_tree = (object)adaptor.Create(char_literal76);
            	        	        		adaptor.AddChild(root_0, char_literal76_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_minute60_p_in_datetime_p944);
            	        	        	m = minute60_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            	        	        	// TimeDef.g:169:73: ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	        	int alt58 = 2;
            	        	        	int LA58_0 = input.LA(1);

            	        	        	if ( (LA58_0 == 27) )
            	        	        	{
            	        	        	    alt58 = 1;
            	        	        	}
            	        	        	switch (alt58) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // TimeDef.g:169:74: ':' s= second60_p ( '.' ms= millisecond1000_p )?
            	        	        	        {
            	        	        	        	char_literal77=(IToken)Match(input,27,FOLLOW_27_in_datetime_p947); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{char_literal77_tree = (object)adaptor.Create(char_literal77);
            	        	        	        		adaptor.AddChild(root_0, char_literal77_tree);
            	        	        	        	}
            	        	        	        	PushFollow(FOLLOW_second60_p_in_datetime_p951);
            	        	        	        	s = second60_p();
            	        	        	        	state.followingStackPointer--;
            	        	        	        	if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            	        	        	        	// TimeDef.g:169:91: ( '.' ms= millisecond1000_p )?
            	        	        	        	int alt57 = 2;
            	        	        	        	int LA57_0 = input.LA(1);

            	        	        	        	if ( (LA57_0 == 28) )
            	        	        	        	{
            	        	        	        	    alt57 = 1;
            	        	        	        	}
            	        	        	        	switch (alt57) 
            	        	        	        	{
            	        	        	        	    case 1 :
            	        	        	        	        // TimeDef.g:169:92: '.' ms= millisecond1000_p
            	        	        	        	        {
            	        	        	        	        	char_literal78=(IToken)Match(input,28,FOLLOW_28_in_datetime_p954); if (state.failed) return retval;
            	        	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	        	{char_literal78_tree = (object)adaptor.Create(char_literal78);
            	        	        	        	        		adaptor.AddChild(root_0, char_literal78_tree);
            	        	        	        	        	}
            	        	        	        	        	PushFollow(FOLLOW_millisecond1000_p_in_datetime_p958);
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
            	        // TimeDef.g:170:4: h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        {
            	        	PushFollow(FOLLOW_hour24_p_in_datetime_p973);
            	        	h = hour24_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            	        	char_literal79=(IToken)Match(input,27,FOLLOW_27_in_datetime_p975); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal79_tree = (object)adaptor.Create(char_literal79);
            	        		adaptor.AddChild(root_0, char_literal79_tree);
            	        	}
            	        	PushFollow(FOLLOW_minute60_p_in_datetime_p979);
            	        	m = minute60_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            	        	// TimeDef.g:170:32: ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	int alt61 = 2;
            	        	int LA61_0 = input.LA(1);

            	        	if ( (LA61_0 == 27) )
            	        	{
            	        	    alt61 = 1;
            	        	}
            	        	switch (alt61) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:170:33: ':' s= second60_p ( '.' ms= millisecond1000_p )?
            	        	        {
            	        	        	char_literal80=(IToken)Match(input,27,FOLLOW_27_in_datetime_p982); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal80_tree = (object)adaptor.Create(char_literal80);
            	        	        		adaptor.AddChild(root_0, char_literal80_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_second60_p_in_datetime_p986);
            	        	        	s = second60_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            	        	        	// TimeDef.g:170:50: ( '.' ms= millisecond1000_p )?
            	        	        	int alt60 = 2;
            	        	        	int LA60_0 = input.LA(1);

            	        	        	if ( (LA60_0 == 28) )
            	        	        	{
            	        	        	    alt60 = 1;
            	        	        	}
            	        	        	switch (alt60) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // TimeDef.g:170:51: '.' ms= millisecond1000_p
            	        	        	        {
            	        	        	        	char_literal81=(IToken)Match(input,28,FOLLOW_28_in_datetime_p989); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{char_literal81_tree = (object)adaptor.Create(char_literal81);
            	        	        	        		adaptor.AddChild(root_0, char_literal81_tree);
            	        	        	        	}
            	        	        	        	PushFollow(FOLLOW_millisecond1000_p_in_datetime_p993);
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
    // TimeDef.g:182:1: datetime_prog returns [DateTime value] : ( datetime_p EOF ) ;
    public TimeDefParser.datetime_prog_return datetime_prog() // throws RecognitionException [1]
    {   
        TimeDefParser.datetime_prog_return retval = new TimeDefParser.datetime_prog_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF83 = null;
        TimeDefParser.datetime_p_return datetime_p82 = default(TimeDefParser.datetime_p_return);


        object EOF83_tree=null;

        try 
    	{
            // TimeDef.g:182:39: ( ( datetime_p EOF ) )
            // TimeDef.g:182:41: ( datetime_p EOF )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:182:41: ( datetime_p EOF )
            	// TimeDef.g:183:4: datetime_p EOF
            	{
            		PushFollow(FOLLOW_datetime_p_in_datetime_prog1017);
            		datetime_p82 = datetime_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, datetime_p82.Tree);
            		EOF83=(IToken)Match(input,EOF,FOLLOW_EOF_in_datetime_prog1019); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{EOF83_tree = (object)adaptor.Create(EOF83);
            			adaptor.AddChild(root_0, EOF83_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((datetime_p82 != null) ? datetime_p82.value : default(DateTime)); 
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
    // TimeDef.g:186:1: year_p returns [int value] : UINT ;
    public TimeDefParser.year_p_return year_p() // throws RecognitionException [1]
    {   
        TimeDefParser.year_p_return retval = new TimeDefParser.year_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT84 = null;

        object UINT84_tree=null;

        try 
    	{
            // TimeDef.g:186:27: ( UINT )
            // TimeDef.g:186:29: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT84=(IToken)Match(input,UINT,FOLLOW_UINT_in_year_p1034); if (state.failed) return retval;
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
    // TimeDef.g:187:1: month_p returns [int value] : UINT ;
    public TimeDefParser.month_p_return month_p() // throws RecognitionException [1]
    {   
        TimeDefParser.month_p_return retval = new TimeDefParser.month_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT85 = null;

        object UINT85_tree=null;

        try 
    	{
            // TimeDef.g:187:28: ( UINT )
            // TimeDef.g:187:30: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT85=(IToken)Match(input,UINT,FOLLOW_UINT_in_month_p1046); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT85_tree = (object)adaptor.Create(UINT85);
            		adaptor.AddChild(root_0, UINT85_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT85 != null) ? UINT85.Text : null)); 
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
    // TimeDef.g:188:1: day_p returns [int value] : UINT ;
    public TimeDefParser.day_p_return day_p() // throws RecognitionException [1]
    {   
        TimeDefParser.day_p_return retval = new TimeDefParser.day_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT86 = null;

        object UINT86_tree=null;

        try 
    	{
            // TimeDef.g:188:26: ( UINT )
            // TimeDef.g:188:28: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT86=(IToken)Match(input,UINT,FOLLOW_UINT_in_day_p1058); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT86_tree = (object)adaptor.Create(UINT86);
            		adaptor.AddChild(root_0, UINT86_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT86 != null) ? UINT86.Text : null)); 
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
    // TimeDef.g:189:1: hour24_p returns [int value] : UINT ;
    public TimeDefParser.hour24_p_return hour24_p() // throws RecognitionException [1]
    {   
        TimeDefParser.hour24_p_return retval = new TimeDefParser.hour24_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT87 = null;

        object UINT87_tree=null;

        try 
    	{
            // TimeDef.g:189:29: ( UINT )
            // TimeDef.g:189:31: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT87=(IToken)Match(input,UINT,FOLLOW_UINT_in_hour24_p1070); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT87_tree = (object)adaptor.Create(UINT87);
            		adaptor.AddChild(root_0, UINT87_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT87 != null) ? UINT87.Text : null)); 
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
    // TimeDef.g:190:1: minute60_p returns [int value] : UINT ;
    public TimeDefParser.minute60_p_return minute60_p() // throws RecognitionException [1]
    {   
        TimeDefParser.minute60_p_return retval = new TimeDefParser.minute60_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT88 = null;

        object UINT88_tree=null;

        try 
    	{
            // TimeDef.g:190:31: ( UINT )
            // TimeDef.g:190:33: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT88=(IToken)Match(input,UINT,FOLLOW_UINT_in_minute60_p1082); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT88_tree = (object)adaptor.Create(UINT88);
            		adaptor.AddChild(root_0, UINT88_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT88 != null) ? UINT88.Text : null)); 
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
    // TimeDef.g:191:1: second60_p returns [int value] : UINT ;
    public TimeDefParser.second60_p_return second60_p() // throws RecognitionException [1]
    {   
        TimeDefParser.second60_p_return retval = new TimeDefParser.second60_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT89 = null;

        object UINT89_tree=null;

        try 
    	{
            // TimeDef.g:191:31: ( UINT )
            // TimeDef.g:191:33: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT89=(IToken)Match(input,UINT,FOLLOW_UINT_in_second60_p1094); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT89_tree = (object)adaptor.Create(UINT89);
            		adaptor.AddChild(root_0, UINT89_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT89 != null) ? UINT89.Text : null)); 
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
    // TimeDef.g:192:1: millisecond1000_p returns [int value] : UINT ;
    public TimeDefParser.millisecond1000_p_return millisecond1000_p() // throws RecognitionException [1]
    {   
        TimeDefParser.millisecond1000_p_return retval = new TimeDefParser.millisecond1000_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT90 = null;

        object UINT90_tree=null;

        try 
    	{
            // TimeDef.g:192:38: ( UINT )
            // TimeDef.g:192:40: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT90=(IToken)Match(input,UINT,FOLLOW_UINT_in_millisecond1000_p1106); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT90_tree = (object)adaptor.Create(UINT90);
            		adaptor.AddChild(root_0, UINT90_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT90 != null) ? UINT90.Text : null)); 
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
    // TimeDef.g:194:1: timespan_p returns [TimeSpan value] : ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? ) ;
    public TimeDefParser.timespan_p_return timespan_p() // throws RecognitionException [1]
    {   
        TimeDefParser.timespan_p_return retval = new TimeDefParser.timespan_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal91 = null;
        IToken char_literal92 = null;
        IToken char_literal93 = null;
        IToken char_literal94 = null;
        IToken char_literal95 = null;
        TimeDefParser.days_p_return d = default(TimeDefParser.days_p_return);

        TimeDefParser.hours_p_return h = default(TimeDefParser.hours_p_return);

        TimeDefParser.minutes_p_return m = default(TimeDefParser.minutes_p_return);

        TimeDefParser.seconds_p_return s = default(TimeDefParser.seconds_p_return);

        TimeDefParser.milliseconds_p_return ms = default(TimeDefParser.milliseconds_p_return);


        object char_literal91_tree=null;
        object char_literal92_tree=null;
        object char_literal93_tree=null;
        object char_literal94_tree=null;
        object char_literal95_tree=null;

        try 
    	{
            // TimeDef.g:194:36: ( ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? ) )
            // TimeDef.g:194:38: ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:194:38: ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? )
            	// TimeDef.g:195:4: 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )?
            	{
            		char_literal91=(IToken)Match(input,29,FOLLOW_29_in_timespan_p1124); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal91_tree = (object)adaptor.Create(char_literal91);
            			adaptor.AddChild(root_0, char_literal91_tree);
            		}
            		// TimeDef.g:195:8: ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )?
            		int alt65 = 2;
            		int LA65_0 = input.LA(1);

            		if ( (LA65_0 == 20) )
            		{
            		    int LA65_1 = input.LA(2);

            		    if ( (LA65_1 == UINT) )
            		    {
            		        int LA65_2 = input.LA(3);

            		        if ( (LA65_2 == 27) )
            		        {
            		            alt65 = 1;
            		        }
            		        else if ( (LA65_2 == 28) )
            		        {
            		            int LA65_4 = input.LA(4);

            		            if ( (LA65_4 == 20) )
            		            {
            		                int LA65_6 = input.LA(5);

            		                if ( (LA65_6 == UINT) )
            		                {
            		                    int LA65_7 = input.LA(6);

            		                    if ( (LA65_7 == 27) )
            		                    {
            		                        alt65 = 1;
            		                    }
            		                }
            		            }
            		            else if ( (LA65_4 == UINT) )
            		            {
            		                int LA65_7 = input.LA(5);

            		                if ( (LA65_7 == 27) )
            		                {
            		                    alt65 = 1;
            		                }
            		            }
            		        }
            		    }
            		}
            		else if ( (LA65_0 == UINT) )
            		{
            		    int LA65_2 = input.LA(2);

            		    if ( (LA65_2 == 27) )
            		    {
            		        alt65 = 1;
            		    }
            		    else if ( (LA65_2 == 28) )
            		    {
            		        int LA65_4 = input.LA(3);

            		        if ( (LA65_4 == 20) )
            		        {
            		            int LA65_6 = input.LA(4);

            		            if ( (LA65_6 == UINT) )
            		            {
            		                int LA65_7 = input.LA(5);

            		                if ( (LA65_7 == 27) )
            		                {
            		                    alt65 = 1;
            		                }
            		            }
            		        }
            		        else if ( (LA65_4 == UINT) )
            		        {
            		            int LA65_7 = input.LA(4);

            		            if ( (LA65_7 == 27) )
            		            {
            		                alt65 = 1;
            		            }
            		        }
            		    }
            		}
            		switch (alt65) 
            		{
            		    case 1 :
            		        // TimeDef.g:195:9: ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':'
            		        {
            		        	// TimeDef.g:195:9: ( (d= days_p '.' )? h= hours_p ':' )?
            		        	int alt64 = 2;
            		        	int LA64_0 = input.LA(1);

            		        	if ( (LA64_0 == 20) )
            		        	{
            		        	    int LA64_1 = input.LA(2);

            		        	    if ( (LA64_1 == UINT) )
            		        	    {
            		        	        int LA64_2 = input.LA(3);

            		        	        if ( (LA64_2 == 27) )
            		        	        {
            		        	            int LA64_3 = input.LA(4);

            		        	            if ( (LA64_3 == 20) )
            		        	            {
            		        	                int LA64_5 = input.LA(5);

            		        	                if ( (LA64_5 == UINT) )
            		        	                {
            		        	                    int LA64_6 = input.LA(6);

            		        	                    if ( (LA64_6 == 27) )
            		        	                    {
            		        	                        alt64 = 1;
            		        	                    }
            		        	                }
            		        	            }
            		        	            else if ( (LA64_3 == UINT) )
            		        	            {
            		        	                int LA64_6 = input.LA(5);

            		        	                if ( (LA64_6 == 27) )
            		        	                {
            		        	                    alt64 = 1;
            		        	                }
            		        	            }
            		        	        }
            		        	        else if ( (LA64_2 == 28) )
            		        	        {
            		        	            alt64 = 1;
            		        	        }
            		        	    }
            		        	}
            		        	else if ( (LA64_0 == UINT) )
            		        	{
            		        	    int LA64_2 = input.LA(2);

            		        	    if ( (LA64_2 == 27) )
            		        	    {
            		        	        int LA64_3 = input.LA(3);

            		        	        if ( (LA64_3 == 20) )
            		        	        {
            		        	            int LA64_5 = input.LA(4);

            		        	            if ( (LA64_5 == UINT) )
            		        	            {
            		        	                int LA64_6 = input.LA(5);

            		        	                if ( (LA64_6 == 27) )
            		        	                {
            		        	                    alt64 = 1;
            		        	                }
            		        	            }
            		        	        }
            		        	        else if ( (LA64_3 == UINT) )
            		        	        {
            		        	            int LA64_6 = input.LA(4);

            		        	            if ( (LA64_6 == 27) )
            		        	            {
            		        	                alt64 = 1;
            		        	            }
            		        	        }
            		        	    }
            		        	    else if ( (LA64_2 == 28) )
            		        	    {
            		        	        alt64 = 1;
            		        	    }
            		        	}
            		        	switch (alt64) 
            		        	{
            		        	    case 1 :
            		        	        // TimeDef.g:195:10: (d= days_p '.' )? h= hours_p ':'
            		        	        {
            		        	        	// TimeDef.g:195:10: (d= days_p '.' )?
            		        	        	int alt63 = 2;
            		        	        	int LA63_0 = input.LA(1);

            		        	        	if ( (LA63_0 == 20) )
            		        	        	{
            		        	        	    int LA63_1 = input.LA(2);

            		        	        	    if ( (LA63_1 == UINT) )
            		        	        	    {
            		        	        	        int LA63_2 = input.LA(3);

            		        	        	        if ( (LA63_2 == 28) )
            		        	        	        {
            		        	        	            alt63 = 1;
            		        	        	        }
            		        	        	    }
            		        	        	}
            		        	        	else if ( (LA63_0 == UINT) )
            		        	        	{
            		        	        	    int LA63_2 = input.LA(2);

            		        	        	    if ( (LA63_2 == 28) )
            		        	        	    {
            		        	        	        alt63 = 1;
            		        	        	    }
            		        	        	}
            		        	        	switch (alt63) 
            		        	        	{
            		        	        	    case 1 :
            		        	        	        // TimeDef.g:195:11: d= days_p '.'
            		        	        	        {
            		        	        	        	PushFollow(FOLLOW_days_p_in_timespan_p1131);
            		        	        	        	d = days_p();
            		        	        	        	state.followingStackPointer--;
            		        	        	        	if (state.failed) return retval;
            		        	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, d.Tree);
            		        	        	        	char_literal92=(IToken)Match(input,28,FOLLOW_28_in_timespan_p1133); if (state.failed) return retval;
            		        	        	        	if ( state.backtracking == 0 )
            		        	        	        	{char_literal92_tree = (object)adaptor.Create(char_literal92);
            		        	        	        		adaptor.AddChild(root_0, char_literal92_tree);
            		        	        	        	}

            		        	        	        }
            		        	        	        break;

            		        	        	}

            		        	        	PushFollow(FOLLOW_hours_p_in_timespan_p1139);
            		        	        	h = hours_p();
            		        	        	state.followingStackPointer--;
            		        	        	if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            		        	        	char_literal93=(IToken)Match(input,27,FOLLOW_27_in_timespan_p1141); if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 )
            		        	        	{char_literal93_tree = (object)adaptor.Create(char_literal93);
            		        	        		adaptor.AddChild(root_0, char_literal93_tree);
            		        	        	}

            		        	        }
            		        	        break;

            		        	}

            		        	PushFollow(FOLLOW_minutes_p_in_timespan_p1147);
            		        	m = minutes_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            		        	char_literal94=(IToken)Match(input,27,FOLLOW_27_in_timespan_p1149); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{char_literal94_tree = (object)adaptor.Create(char_literal94);
            		        		adaptor.AddChild(root_0, char_literal94_tree);
            		        	}

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_seconds_p_in_timespan_p1155);
            		s = seconds_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            		// TimeDef.g:195:72: ( '.' ms= milliseconds_p )?
            		int alt66 = 2;
            		int LA66_0 = input.LA(1);

            		if ( (LA66_0 == 28) )
            		{
            		    alt66 = 1;
            		}
            		switch (alt66) 
            		{
            		    case 1 :
            		        // TimeDef.g:195:73: '.' ms= milliseconds_p
            		        {
            		        	char_literal95=(IToken)Match(input,28,FOLLOW_28_in_timespan_p1158); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{char_literal95_tree = (object)adaptor.Create(char_literal95);
            		        		adaptor.AddChild(root_0, char_literal95_tree);
            		        	}
            		        	PushFollow(FOLLOW_milliseconds_p_in_timespan_p1162);
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
    // TimeDef.g:205:1: timespan_prog returns [TimeSpan value] : ( timespan_p EOF ) ;
    public TimeDefParser.timespan_prog_return timespan_prog() // throws RecognitionException [1]
    {   
        TimeDefParser.timespan_prog_return retval = new TimeDefParser.timespan_prog_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF97 = null;
        TimeDefParser.timespan_p_return timespan_p96 = default(TimeDefParser.timespan_p_return);


        object EOF97_tree=null;

        try 
    	{
            // TimeDef.g:205:39: ( ( timespan_p EOF ) )
            // TimeDef.g:205:41: ( timespan_p EOF )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:205:41: ( timespan_p EOF )
            	// TimeDef.g:206:4: timespan_p EOF
            	{
            		PushFollow(FOLLOW_timespan_p_in_timespan_prog1184);
            		timespan_p96 = timespan_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, timespan_p96.Tree);
            		EOF97=(IToken)Match(input,EOF,FOLLOW_EOF_in_timespan_prog1186); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{EOF97_tree = (object)adaptor.Create(EOF97);
            			adaptor.AddChild(root_0, EOF97_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((timespan_p96 != null) ? timespan_p96.value : default(TimeSpan)); 
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
    // TimeDef.g:209:1: days_p returns [int value] : int_p ;
    public TimeDefParser.days_p_return days_p() // throws RecognitionException [1]
    {   
        TimeDefParser.days_p_return retval = new TimeDefParser.days_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p98 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:209:27: ( int_p )
            // TimeDef.g:209:29: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_days_p1201);
            	int_p98 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p98.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p98 != null) ? input.ToString((IToken)(int_p98.Start),(IToken)(int_p98.Stop)) : null)); 
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
    // TimeDef.g:210:1: hours_p returns [int value] : int_p ;
    public TimeDefParser.hours_p_return hours_p() // throws RecognitionException [1]
    {   
        TimeDefParser.hours_p_return retval = new TimeDefParser.hours_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p99 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:210:28: ( int_p )
            // TimeDef.g:210:30: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_hours_p1213);
            	int_p99 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p99.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p99 != null) ? input.ToString((IToken)(int_p99.Start),(IToken)(int_p99.Stop)) : null)); 
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
    // TimeDef.g:211:1: minutes_p returns [int value] : int_p ;
    public TimeDefParser.minutes_p_return minutes_p() // throws RecognitionException [1]
    {   
        TimeDefParser.minutes_p_return retval = new TimeDefParser.minutes_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p100 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:211:30: ( int_p )
            // TimeDef.g:211:32: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_minutes_p1225);
            	int_p100 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p100.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p100 != null) ? input.ToString((IToken)(int_p100.Start),(IToken)(int_p100.Stop)) : null)); 
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
    // TimeDef.g:212:1: seconds_p returns [int value] : int_p ;
    public TimeDefParser.seconds_p_return seconds_p() // throws RecognitionException [1]
    {   
        TimeDefParser.seconds_p_return retval = new TimeDefParser.seconds_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p101 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:212:30: ( int_p )
            // TimeDef.g:212:32: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_seconds_p1237);
            	int_p101 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p101.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p101 != null) ? input.ToString((IToken)(int_p101.Start),(IToken)(int_p101.Stop)) : null)); 
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
    // TimeDef.g:213:1: milliseconds_p returns [int value] : int_p ;
    public TimeDefParser.milliseconds_p_return milliseconds_p() // throws RecognitionException [1]
    {   
        TimeDefParser.milliseconds_p_return retval = new TimeDefParser.milliseconds_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p102 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:213:35: ( int_p )
            // TimeDef.g:213:37: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_milliseconds_p1249);
            	int_p102 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p102.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p102 != null) ? input.ToString((IToken)(int_p102.Start),(IToken)(int_p102.Stop)) : null)); 
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
    // TimeDef.g:215:1: cron_field_p : cron_term_p ( ',' cron_term_p )* ;
    public TimeDefParser.cron_field_p_return cron_field_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_field_p_return retval = new TimeDefParser.cron_field_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal104 = null;
        TimeDefParser.cron_term_p_return cron_term_p103 = default(TimeDefParser.cron_term_p_return);

        TimeDefParser.cron_term_p_return cron_term_p105 = default(TimeDefParser.cron_term_p_return);


        object char_literal104_tree=null;

        try 
    	{
            // TimeDef.g:215:13: ( cron_term_p ( ',' cron_term_p )* )
            // TimeDef.g:215:15: cron_term_p ( ',' cron_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_cron_term_p_in_cron_field_p1258);
            	cron_term_p103 = cron_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cron_term_p103.Tree);
            	// TimeDef.g:215:27: ( ',' cron_term_p )*
            	do 
            	{
            	    int alt67 = 2;
            	    int LA67_0 = input.LA(1);

            	    if ( (LA67_0 == 21) )
            	    {
            	        int LA67_2 = input.LA(2);

            	        if ( (LA67_2 == 16 || LA67_2 == 20 || (LA67_2 >= 30 && LA67_2 <= 33)) )
            	        {
            	            alt67 = 1;
            	        }
            	        else if ( (LA67_2 == UINT) )
            	        {
            	            int LA67_4 = input.LA(3);

            	            if ( (LA67_4 == EOF || (LA67_4 >= WS && LA67_4 <= UINT) || LA67_4 == 14 || (LA67_4 >= 16 && LA67_4 <= 19) || (LA67_4 >= 21 && LA67_4 <= 26) || (LA67_4 >= 31 && LA67_4 <= 33)) )
            	            {
            	                alt67 = 1;
            	            }
            	            else if ( (LA67_4 == 20) )
            	            {
            	                int LA67_5 = input.LA(4);

            	                if ( (LA67_5 == EOF || LA67_5 == WS || LA67_5 == 14 || (LA67_5 >= 16 && LA67_5 <= 26) || LA67_5 == 29 || (LA67_5 >= 31 && LA67_5 <= 33)) )
            	                {
            	                    alt67 = 1;
            	                }
            	                else if ( (LA67_5 == UINT) )
            	                {
            	                    int LA67_6 = input.LA(5);

            	                    if ( (LA67_6 == 20) )
            	                    {
            	                        int LA67_7 = input.LA(6);

            	                        if ( (LA67_7 == UINT) )
            	                        {
            	                            int LA67_8 = input.LA(7);

            	                            if ( (synpred75_TimeDef()) )
            	                            {
            	                                alt67 = 1;
            	                            }


            	                        }
            	                        else if ( (LA67_7 == EOF || LA67_7 == WS || LA67_7 == 14 || (LA67_7 >= 16 && LA67_7 <= 26) || LA67_7 == 29 || (LA67_7 >= 31 && LA67_7 <= 33)) )
            	                        {
            	                            alt67 = 1;
            	                        }


            	                    }
            	                    else if ( (LA67_6 == EOF || (LA67_6 >= WS && LA67_6 <= UINT) || LA67_6 == 14 || (LA67_6 >= 16 && LA67_6 <= 19) || (LA67_6 >= 21 && LA67_6 <= 26) || (LA67_6 >= 31 && LA67_6 <= 33)) )
            	                    {
            	                        alt67 = 1;
            	                    }


            	                }


            	            }


            	        }


            	    }


            	    switch (alt67) 
            		{
            			case 1 :
            			    // TimeDef.g:215:28: ',' cron_term_p
            			    {
            			    	char_literal104=(IToken)Match(input,21,FOLLOW_21_in_cron_field_p1261); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal104_tree = (object)adaptor.Create(char_literal104);
            			    		adaptor.AddChild(root_0, char_literal104_tree);
            			    	}
            			    	PushFollow(FOLLOW_cron_term_p_in_cron_field_p1263);
            			    	cron_term_p105 = cron_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cron_term_p105.Tree);

            			    }
            			    break;

            			default:
            			    goto loop67;
            	    }
            	} while (true);

            	loop67:
            		;	// Stops C# compiler whining that label 'loop67' has no statements


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
    // TimeDef.g:216:1: cron_term_p : ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+ ;
    public TimeDefParser.cron_term_p_return cron_term_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_term_p_return retval = new TimeDefParser.cron_term_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal106 = null;
        IToken set107 = null;

        object char_literal106_tree=null;
        object set107_tree=null;

        try 
    	{
            // TimeDef.g:216:12: ( ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+ )
            // TimeDef.g:216:14: ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:216:14: ( '!' )?
            	int alt68 = 2;
            	int LA68_0 = input.LA(1);

            	if ( (LA68_0 == 30) )
            	{
            	    alt68 = 1;
            	}
            	switch (alt68) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '!'
            	        {
            	        	char_literal106=(IToken)Match(input,30,FOLLOW_30_in_cron_term_p1271); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal106_tree = (object)adaptor.Create(char_literal106);
            	        		adaptor.AddChild(root_0, char_literal106_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:216:19: ( UINT | '/' | '-' | '*' | '>' | '<' )+
            	int cnt69 = 0;
            	do 
            	{
            	    int alt69 = 2;
            	    alt69 = dfa69.Predict(input);
            	    switch (alt69) 
            		{
            			case 1 :
            			    // TimeDef.g:
            			    {
            			    	set107 = (IToken)input.LT(1);
            			    	if ( input.LA(1) == UINT || input.LA(1) == 16 || input.LA(1) == 20 || (input.LA(1) >= 31 && input.LA(1) <= 33) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set107));
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
            			    if ( cnt69 >= 1 ) goto loop69;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee69 =
            		                new EarlyExitException(69, input);
            		            throw eee69;
            	    }
            	    cnt69++;
            	} while (true);

            	loop69:
            		;	// Stops C# compiler whining that label 'loop69' has no statements


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
    // TimeDef.g:218:1: intspec_p : intspec_term_p ( ',' intspec_term_p )* ;
    public TimeDefParser.intspec_p_return intspec_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intspec_p_return retval = new TimeDefParser.intspec_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal109 = null;
        TimeDefParser.intspec_term_p_return intspec_term_p108 = default(TimeDefParser.intspec_term_p_return);

        TimeDefParser.intspec_term_p_return intspec_term_p110 = default(TimeDefParser.intspec_term_p_return);


        object char_literal109_tree=null;

        try 
    	{
            // TimeDef.g:218:10: ( intspec_term_p ( ',' intspec_term_p )* )
            // TimeDef.g:218:12: intspec_term_p ( ',' intspec_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_intspec_term_p_in_intspec_p1304);
            	intspec_term_p108 = intspec_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intspec_term_p108.Tree);
            	// TimeDef.g:218:27: ( ',' intspec_term_p )*
            	do 
            	{
            	    int alt70 = 2;
            	    int LA70_0 = input.LA(1);

            	    if ( (LA70_0 == 21) )
            	    {
            	        int LA70_2 = input.LA(2);

            	        if ( (LA70_2 == 20 || LA70_2 == 30 || LA70_2 == 32) )
            	        {
            	            alt70 = 1;
            	        }
            	        else if ( (LA70_2 == UINT) )
            	        {
            	            int LA70_4 = input.LA(3);

            	            if ( (LA70_4 == 20) )
            	            {
            	                int LA70_5 = input.LA(4);

            	                if ( (LA70_5 == UINT) )
            	                {
            	                    int LA70_6 = input.LA(5);

            	                    if ( (LA70_6 == 20) )
            	                    {
            	                        int LA70_7 = input.LA(6);

            	                        if ( (LA70_7 == WS || LA70_7 == 29) )
            	                        {
            	                            alt70 = 1;
            	                        }


            	                    }
            	                    else if ( (LA70_6 == EOF || LA70_6 == WS || LA70_6 == 14 || (LA70_6 >= 16 && LA70_6 <= 19) || (LA70_6 >= 21 && LA70_6 <= 26) || LA70_6 == 31) )
            	                    {
            	                        alt70 = 1;
            	                    }


            	                }
            	                else if ( (LA70_5 == WS || LA70_5 == 20 || LA70_5 == 29) )
            	                {
            	                    alt70 = 1;
            	                }


            	            }
            	            else if ( (LA70_4 == EOF || LA70_4 == WS || LA70_4 == 14 || (LA70_4 >= 16 && LA70_4 <= 19) || (LA70_4 >= 21 && LA70_4 <= 26) || LA70_4 == 31) )
            	            {
            	                alt70 = 1;
            	            }


            	        }


            	    }


            	    switch (alt70) 
            		{
            			case 1 :
            			    // TimeDef.g:218:28: ',' intspec_term_p
            			    {
            			    	char_literal109=(IToken)Match(input,21,FOLLOW_21_in_intspec_p1307); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal109_tree = (object)adaptor.Create(char_literal109);
            			    		adaptor.AddChild(root_0, char_literal109_tree);
            			    	}
            			    	PushFollow(FOLLOW_intspec_term_p_in_intspec_p1309);
            			    	intspec_term_p110 = intspec_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intspec_term_p110.Tree);

            			    }
            			    break;

            			default:
            			    goto loop70;
            	    }
            	} while (true);

            	loop70:
            		;	// Stops C# compiler whining that label 'loop70' has no statements


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
    // TimeDef.g:219:1: intspec_term_p : ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )? ;
    public TimeDefParser.intspec_term_p_return intspec_term_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intspec_term_p_return retval = new TimeDefParser.intspec_term_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal111 = null;
        IToken char_literal112 = null;
        IToken char_literal114 = null;
        IToken char_literal116 = null;
        IToken UINT117 = null;
        TimeDefParser.int_p_return int_p113 = default(TimeDefParser.int_p_return);

        TimeDefParser.int_p_return int_p115 = default(TimeDefParser.int_p_return);


        object char_literal111_tree=null;
        object char_literal112_tree=null;
        object char_literal114_tree=null;
        object char_literal116_tree=null;
        object UINT117_tree=null;

        try 
    	{
            // TimeDef.g:219:15: ( ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )? )
            // TimeDef.g:219:17: ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:219:17: ( '!' )?
            	int alt71 = 2;
            	int LA71_0 = input.LA(1);

            	if ( (LA71_0 == 30) )
            	{
            	    alt71 = 1;
            	}
            	switch (alt71) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '!'
            	        {
            	        	char_literal111=(IToken)Match(input,30,FOLLOW_30_in_intspec_term_p1317); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal111_tree = (object)adaptor.Create(char_literal111);
            	        		adaptor.AddChild(root_0, char_literal111_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:219:22: ( '*' | int_p ( '-' int_p )? )
            	int alt73 = 2;
            	int LA73_0 = input.LA(1);

            	if ( (LA73_0 == 32) )
            	{
            	    alt73 = 1;
            	}
            	else if ( (LA73_0 == UINT || LA73_0 == 20) )
            	{
            	    alt73 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d73s0 =
            	        new NoViableAltException("", 73, 0, input);

            	    throw nvae_d73s0;
            	}
            	switch (alt73) 
            	{
            	    case 1 :
            	        // TimeDef.g:219:24: '*'
            	        {
            	        	char_literal112=(IToken)Match(input,32,FOLLOW_32_in_intspec_term_p1322); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal112_tree = (object)adaptor.Create(char_literal112);
            	        		adaptor.AddChild(root_0, char_literal112_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // TimeDef.g:219:30: int_p ( '-' int_p )?
            	        {
            	        	PushFollow(FOLLOW_int_p_in_intspec_term_p1326);
            	        	int_p113 = int_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p113.Tree);
            	        	// TimeDef.g:219:36: ( '-' int_p )?
            	        	int alt72 = 2;
            	        	int LA72_0 = input.LA(1);

            	        	if ( (LA72_0 == 20) )
            	        	{
            	        	    int LA72_1 = input.LA(2);

            	        	    if ( (LA72_1 == UINT || LA72_1 == 20) )
            	        	    {
            	        	        alt72 = 1;
            	        	    }
            	        	}
            	        	switch (alt72) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:219:38: '-' int_p
            	        	        {
            	        	        	char_literal114=(IToken)Match(input,20,FOLLOW_20_in_intspec_term_p1330); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal114_tree = (object)adaptor.Create(char_literal114);
            	        	        		adaptor.AddChild(root_0, char_literal114_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_int_p_in_intspec_term_p1332);
            	        	        	int_p115 = int_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p115.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// TimeDef.g:219:53: ( '/' UINT )?
            	int alt74 = 2;
            	int LA74_0 = input.LA(1);

            	if ( (LA74_0 == 31) )
            	{
            	    alt74 = 1;
            	}
            	switch (alt74) 
            	{
            	    case 1 :
            	        // TimeDef.g:219:55: '/' UINT
            	        {
            	        	char_literal116=(IToken)Match(input,31,FOLLOW_31_in_intspec_term_p1341); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal116_tree = (object)adaptor.Create(char_literal116);
            	        		adaptor.AddChild(root_0, char_literal116_tree);
            	        	}
            	        	UINT117=(IToken)Match(input,UINT,FOLLOW_UINT_in_intspec_term_p1343); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UINT117_tree = (object)adaptor.Create(UINT117);
            	        		adaptor.AddChild(root_0, UINT117_tree);
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
    // TimeDef.g:224:1: int_p : ( '-' )? UINT ;
    public TimeDefParser.int_p_return int_p() // throws RecognitionException [1]
    {   
        TimeDefParser.int_p_return retval = new TimeDefParser.int_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal118 = null;
        IToken UINT119 = null;

        object char_literal118_tree=null;
        object UINT119_tree=null;

        try 
    	{
            // TimeDef.g:224:6: ( ( '-' )? UINT )
            // TimeDef.g:224:8: ( '-' )? UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:224:8: ( '-' )?
            	int alt75 = 2;
            	int LA75_0 = input.LA(1);

            	if ( (LA75_0 == 20) )
            	{
            	    alt75 = 1;
            	}
            	switch (alt75) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '-'
            	        {
            	        	char_literal118=(IToken)Match(input,20,FOLLOW_20_in_int_p1356); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal118_tree = (object)adaptor.Create(char_literal118);
            	        		adaptor.AddChild(root_0, char_literal118_tree);
            	        	}

            	        }
            	        break;

            	}

            	UINT119=(IToken)Match(input,UINT,FOLLOW_UINT_in_int_p1359); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT119_tree = (object)adaptor.Create(UINT119);
            		adaptor.AddChild(root_0, UINT119_tree);
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


        // TimeDef.g:60:22: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:60:22: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:60:22: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred8_TimeDef175); if (state.failed) return ;

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

        	Match(input,7,FOLLOW_7_in_synpred8_TimeDef178); if (state.failed) return ;
        	// TimeDef.g:60:36: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred8_TimeDef180); if (state.failed) return ;

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

        	PushFollow(FOLLOW_timespan_p_in_synpred8_TimeDef185);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_TimeDef"

    // $ANTLR start "synpred15_TimeDef"
    public void synpred15_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        // TimeDef.g:64:72: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:64:72: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:64:72: ( WS )+
        	int cnt80 = 0;
        	do 
        	{
        	    int alt80 = 2;
        	    int LA80_0 = input.LA(1);

        	    if ( (LA80_0 == WS) )
        	    {
        	        alt80 = 1;
        	    }


        	    switch (alt80) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred15_TimeDef232); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt80 >= 1 ) goto loop80;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee80 =
        		                new EarlyExitException(80, input);
        		            throw eee80;
        	    }
        	    cnt80++;
        	} while (true);

        	loop80:
        		;	// Stops C# compiler whining that label 'loop80' has no statements

        	Match(input,7,FOLLOW_7_in_synpred15_TimeDef235); if (state.failed) return ;
        	// TimeDef.g:64:86: ( WS )+
        	int cnt81 = 0;
        	do 
        	{
        	    int alt81 = 2;
        	    int LA81_0 = input.LA(1);

        	    if ( (LA81_0 == WS) )
        	    {
        	        alt81 = 1;
        	    }


        	    switch (alt81) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred15_TimeDef237); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt81 >= 1 ) goto loop81;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee81 =
        		                new EarlyExitException(81, input);
        		            throw eee81;
        	    }
        	    cnt81++;
        	} while (true);

        	loop81:
        		;	// Stops C# compiler whining that label 'loop81' has no statements

        	PushFollow(FOLLOW_timespan_p_in_synpred15_TimeDef242);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred15_TimeDef"

    // $ANTLR start "synpred23_TimeDef"
    public void synpred23_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        // TimeDef.g:74:5: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:74:5: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:74:5: ( WS )+
        	int cnt82 = 0;
        	do 
        	{
        	    int alt82 = 2;
        	    int LA82_0 = input.LA(1);

        	    if ( (LA82_0 == WS) )
        	    {
        	        alt82 = 1;
        	    }


        	    switch (alt82) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred23_TimeDef320); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt82 >= 1 ) goto loop82;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee82 =
        		                new EarlyExitException(82, input);
        		            throw eee82;
        	    }
        	    cnt82++;
        	} while (true);

        	loop82:
        		;	// Stops C# compiler whining that label 'loop82' has no statements

        	Match(input,7,FOLLOW_7_in_synpred23_TimeDef323); if (state.failed) return ;
        	// TimeDef.g:74:19: ( WS )+
        	int cnt83 = 0;
        	do 
        	{
        	    int alt83 = 2;
        	    int LA83_0 = input.LA(1);

        	    if ( (LA83_0 == WS) )
        	    {
        	        alt83 = 1;
        	    }


        	    switch (alt83) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred23_TimeDef325); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt83 >= 1 ) goto loop83;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee83 =
        		                new EarlyExitException(83, input);
        		            throw eee83;
        	    }
        	    cnt83++;
        	} while (true);

        	loop83:
        		;	// Stops C# compiler whining that label 'loop83' has no statements

        	PushFollow(FOLLOW_timespan_p_in_synpred23_TimeDef330);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred23_TimeDef"

    // $ANTLR start "synpred75_TimeDef"
    public void synpred75_TimeDef_fragment() {
        // TimeDef.g:215:28: ( ',' cron_term_p )
        // TimeDef.g:215:28: ',' cron_term_p
        {
        	Match(input,21,FOLLOW_21_in_synpred75_TimeDef1261); if (state.failed) return ;
        	PushFollow(FOLLOW_cron_term_p_in_synpred75_TimeDef1263);
        	cron_term_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred75_TimeDef"

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
   	public bool synpred75_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred75_TimeDef_fragment(); // can never throw exception
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


   	protected DFA4 dfa4;
   	protected DFA8 dfa8;
   	protected DFA11 dfa11;
   	protected DFA19 dfa19;
   	protected DFA26 dfa26;
   	protected DFA35 dfa35;
   	protected DFA39 dfa39;
   	protected DFA43 dfa43;
   	protected DFA46 dfa46;
   	protected DFA49 dfa49;
   	protected DFA52 dfa52;
   	protected DFA55 dfa55;
   	protected DFA59 dfa59;
   	protected DFA69 dfa69;
	private void InitializeCyclicDFAs()
	{
    	this.dfa4 = new DFA4(this);
    	this.dfa8 = new DFA8(this);
    	this.dfa11 = new DFA11(this);
    	this.dfa19 = new DFA19(this);
    	this.dfa26 = new DFA26(this);
    	this.dfa35 = new DFA35(this);
    	this.dfa39 = new DFA39(this);
    	this.dfa43 = new DFA43(this);
    	this.dfa46 = new DFA46(this);
    	this.dfa49 = new DFA49(this);
    	this.dfa52 = new DFA52(this);
    	this.dfa55 = new DFA55(this);
    	this.dfa59 = new DFA59(this);
    	this.dfa69 = new DFA69(this);
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
        "\x02\x1a\x01\uffff\x01\x04\x01\x1d\x01\x14\x01\x05\x01\x00\x01"+
        "\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01";
    const string DFA4_specialS =
        "\x07\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x01\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x03\x06\uffff\x01\x02\x01\uffff\x0b"+
            "\x02",
            "",
            "\x01\x04",
            "\x01\x04\x18\uffff\x01\x05",
            "\x01\x07\x0e\uffff\x01\x06",
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
            get { return "60:21: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?"; }
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
        "\x02\x1a\x02\uffff";
    const string DFA8_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA8_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x01\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x02\x01\uffff\x01\x03\x04\uffff\x01"+
            "\x02\x01\uffff\x0b\x02",
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
            get { return "64:36: ( ( WS )+ 'since' ( WS )+ sync= datetime_p )?"; }
        }

    }

    const string DFA11_eotS =
        "\x09\uffff";
    const string DFA11_eofS =
        "\x02\x02\x07\uffff";
    const string DFA11_minS =
        "\x02\x04\x01\uffff\x02\x04\x02\x05\x01\x00\x01\uffff";
    const string DFA11_maxS =
        "\x02\x1a\x01\uffff\x01\x04\x01\x1d\x01\x14\x01\x05\x01\x00\x01"+
        "\uffff";
    const string DFA11_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01";
    const string DFA11_specialS =
        "\x07\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x01\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x03\x06\uffff\x01\x02\x01\uffff\x0b"+
            "\x02",
            "",
            "\x01\x04",
            "\x01\x04\x18\uffff\x01\x05",
            "\x01\x07\x0e\uffff\x01\x06",
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
            get { return "64:71: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?"; }
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
        "\x02\x1a\x01\uffff\x01\x04\x01\x1d\x01\x14\x01\x05\x01\x00\x01"+
        "\uffff";
    const string DFA19_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01";
    const string DFA19_specialS =
        "\x07\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x01\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x03\x06\uffff\x01\x02\x01\uffff\x0b"+
            "\x02",
            "",
            "\x01\x04",
            "\x01\x04\x18\uffff\x01\x05",
            "\x01\x07\x0e\uffff\x01\x06",
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
            get { return "74:4: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?"; }
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
    const string DFA26_eotS =
        "\x17\uffff";
    const string DFA26_eofS =
        "\x05\uffff\x01\x02\x02\uffff\x01\x02\x02\uffff\x02\x02\x01\uffff"+
        "\x02\x02\x02\uffff\x01\x02\x01\uffff\x01\x02\x01\uffff\x01\x02";
    const string DFA26_minS =
        "\x01\x05\x01\x14\x01\uffff\x02\x05\x01\x04\x01\x14\x01\x05\x01"+
        "\x04\x01\uffff\x01\x05\x02\x04\x01\x05\x02\x04\x01\x1b\x01\x05\x01"+
        "\x04\x01\x05\x01\x04\x01\x05\x01\x04";
    const string DFA26_maxS =
        "\x01\x0d\x01\x1b\x01\uffff\x02\x05\x01\x1b\x01\x14\x01\x05\x01"+
        "\x1a\x01\uffff\x01\x05\x01\x1c\x01\x1a\x01\x05\x02\x1a\x01\x1b\x01"+
        "\x05\x01\x1b\x01\x05\x01\x1c\x01\x05\x01\x1a";
    const string DFA26_acceptS =
        "\x02\uffff\x01\x02\x06\uffff\x01\x01\x0d\uffff";
    const string DFA26_specialS =
        "\x17\uffff}>";
    static readonly string[] DFA26_transitionS = {
            "\x01\x01\x02\uffff\x01\x02\x01\uffff\x04\x02",
            "\x01\x04\x06\uffff\x01\x03",
            "",
            "\x01\x05",
            "\x01\x06",
            "\x01\x08\x09\uffff\x01\x02\x01\x09\x0b\x02\x01\x07",
            "\x01\x0a",
            "\x01\x0b",
            "\x01\x08\x02\uffff\x01\x02\x06\uffff\x01\x02\x01\x09\x0b\x02",
            "",
            "\x01\x0c",
            "\x01\x08\x09\uffff\x01\x02\x01\x09\x0b\x02\x01\uffff\x01\x0d",
            "\x01\x0e\x09\uffff\x01\x02\x01\x09\x0b\x02",
            "\x01\x0f",
            "\x01\x0e\x01\x10\x01\uffff\x01\x02\x06\uffff\x01\x02\x01\x09"+
            "\x0b\x02",
            "\x01\x08\x09\uffff\x01\x02\x01\x09\x0b\x02",
            "\x01\x11",
            "\x01\x12",
            "\x01\x08\x09\uffff\x01\x02\x01\x09\x0b\x02\x01\x13",
            "\x01\x14",
            "\x01\x08\x09\uffff\x01\x02\x01\x09\x0b\x02\x01\uffff\x01\x15",
            "\x01\x16",
            "\x01\x08\x09\uffff\x01\x02\x01\x09\x0b\x02"
    };

    static readonly short[] DFA26_eot = DFA.UnpackEncodedString(DFA26_eotS);
    static readonly short[] DFA26_eof = DFA.UnpackEncodedString(DFA26_eofS);
    static readonly char[] DFA26_min = DFA.UnpackEncodedStringToUnsignedChars(DFA26_minS);
    static readonly char[] DFA26_max = DFA.UnpackEncodedStringToUnsignedChars(DFA26_maxS);
    static readonly short[] DFA26_accept = DFA.UnpackEncodedString(DFA26_acceptS);
    static readonly short[] DFA26_special = DFA.UnpackEncodedString(DFA26_specialS);
    static readonly short[][] DFA26_transition = DFA.UnpackEncodedStringArray(DFA26_transitionS);

    protected class DFA26 : DFA
    {
        public DFA26(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 26;
            this.eot = DFA26_eot;
            this.eof = DFA26_eof;
            this.min = DFA26_min;
            this.max = DFA26_max;
            this.accept = DFA26_accept;
            this.special = DFA26_special;
            this.transition = DFA26_transition;

        }

        override public string Description
        {
            get { return "92:1: limit_p returns [ISchedule value] : ( (limit_start= datetime_p ( WS )* '<=' ( WS )* A= filter_p ( WS )* '<' ( WS )* limit_end= datetime_p ) | B= atom );"; }
        }

    }

    const string DFA35_eotS =
        "\x07\uffff";
    const string DFA35_eofS =
        "\x02\x02\x05\uffff";
    const string DFA35_minS =
        "\x02\x04\x05\uffff";
    const string DFA35_maxS =
        "\x02\x1a\x05\uffff";
    const string DFA35_acceptS =
        "\x02\uffff\x01\x05\x01\x01\x01\x02\x01\x03\x01\x04";
    const string DFA35_specialS =
        "\x07\uffff}>";
    static readonly string[] DFA35_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x01\uffff\x01\x02\x01\x03\x01\x04"+
            "\x02\x05\x06\x02",
            "\x01\x01\x02\uffff\x01\x06\x06\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x01\x03\x01\x04\x02\x05\x06\x02",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA35_eot = DFA.UnpackEncodedString(DFA35_eotS);
    static readonly short[] DFA35_eof = DFA.UnpackEncodedString(DFA35_eofS);
    static readonly char[] DFA35_min = DFA.UnpackEncodedStringToUnsignedChars(DFA35_minS);
    static readonly char[] DFA35_max = DFA.UnpackEncodedStringToUnsignedChars(DFA35_maxS);
    static readonly short[] DFA35_accept = DFA.UnpackEncodedString(DFA35_acceptS);
    static readonly short[] DFA35_special = DFA.UnpackEncodedString(DFA35_specialS);
    static readonly short[][] DFA35_transition = DFA.UnpackEncodedStringArray(DFA35_transitionS);

    protected class DFA35 : DFA
    {
        public DFA35(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 35;
            this.eot = DFA35_eot;
            this.eof = DFA35_eof;
            this.min = DFA35_min;
            this.max = DFA35_max;
            this.accept = DFA35_accept;
            this.special = DFA35_special;
            this.transition = DFA35_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 98:37: ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*"; }
        }

    }

    const string DFA39_eotS =
        "\x04\uffff";
    const string DFA39_eofS =
        "\x02\x02\x02\uffff";
    const string DFA39_minS =
        "\x02\x04\x02\uffff";
    const string DFA39_maxS =
        "\x02\x15\x02\uffff";
    const string DFA39_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA39_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA39_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x06\uffff\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x06\uffff\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA39_eot = DFA.UnpackEncodedString(DFA39_eotS);
    static readonly short[] DFA39_eof = DFA.UnpackEncodedString(DFA39_eofS);
    static readonly char[] DFA39_min = DFA.UnpackEncodedStringToUnsignedChars(DFA39_minS);
    static readonly char[] DFA39_max = DFA.UnpackEncodedStringToUnsignedChars(DFA39_maxS);
    static readonly short[] DFA39_accept = DFA.UnpackEncodedString(DFA39_acceptS);
    static readonly short[] DFA39_special = DFA.UnpackEncodedString(DFA39_specialS);
    static readonly short[][] DFA39_transition = DFA.UnpackEncodedStringArray(DFA39_transitionS);

    protected class DFA39 : DFA
    {
        public DFA39(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 39;
            this.eot = DFA39_eot;
            this.eof = DFA39_eof;
            this.min = DFA39_min;
            this.max = DFA39_max;
            this.accept = DFA39_accept;
            this.special = DFA39_special;
            this.transition = DFA39_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 113:4: ( ( WS )* ',' ( WS )* B= boolnonintersection_p )*"; }
        }

    }

    const string DFA43_eotS =
        "\x04\uffff";
    const string DFA43_eofS =
        "\x02\x02\x02\uffff";
    const string DFA43_minS =
        "\x02\x04\x02\uffff";
    const string DFA43_maxS =
        "\x02\x16\x02\uffff";
    const string DFA43_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA43_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA43_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x06\uffff\x01\x02\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x06\uffff\x01\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA43_eot = DFA.UnpackEncodedString(DFA43_eotS);
    static readonly short[] DFA43_eof = DFA.UnpackEncodedString(DFA43_eofS);
    static readonly char[] DFA43_min = DFA.UnpackEncodedStringToUnsignedChars(DFA43_minS);
    static readonly char[] DFA43_max = DFA.UnpackEncodedStringToUnsignedChars(DFA43_maxS);
    static readonly short[] DFA43_accept = DFA.UnpackEncodedString(DFA43_acceptS);
    static readonly short[] DFA43_special = DFA.UnpackEncodedString(DFA43_specialS);
    static readonly short[][] DFA43_transition = DFA.UnpackEncodedStringArray(DFA43_transitionS);

    protected class DFA43 : DFA
    {
        public DFA43(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 43;
            this.eot = DFA43_eot;
            this.eof = DFA43_eof;
            this.min = DFA43_min;
            this.max = DFA43_max;
            this.accept = DFA43_accept;
            this.special = DFA43_special;
            this.transition = DFA43_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 121:4: ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*"; }
        }

    }

    const string DFA46_eotS =
        "\x04\uffff";
    const string DFA46_eofS =
        "\x02\x02\x02\uffff";
    const string DFA46_minS =
        "\x02\x04\x02\uffff";
    const string DFA46_maxS =
        "\x02\x17\x02\uffff";
    const string DFA46_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA46_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA46_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x06\uffff\x02\x02\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x06\uffff\x02\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA46_eot = DFA.UnpackEncodedString(DFA46_eotS);
    static readonly short[] DFA46_eof = DFA.UnpackEncodedString(DFA46_eofS);
    static readonly char[] DFA46_min = DFA.UnpackEncodedStringToUnsignedChars(DFA46_minS);
    static readonly char[] DFA46_max = DFA.UnpackEncodedStringToUnsignedChars(DFA46_maxS);
    static readonly short[] DFA46_accept = DFA.UnpackEncodedString(DFA46_acceptS);
    static readonly short[] DFA46_special = DFA.UnpackEncodedString(DFA46_specialS);
    static readonly short[][] DFA46_transition = DFA.UnpackEncodedStringArray(DFA46_transitionS);

    protected class DFA46 : DFA
    {
        public DFA46(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 46;
            this.eot = DFA46_eot;
            this.eof = DFA46_eof;
            this.min = DFA46_min;
            this.max = DFA46_max;
            this.accept = DFA46_accept;
            this.special = DFA46_special;
            this.transition = DFA46_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 129:4: ( ( WS )* '&&' ( WS )* B= union_p )*"; }
        }

    }

    const string DFA49_eotS =
        "\x04\uffff";
    const string DFA49_eofS =
        "\x02\x02\x02\uffff";
    const string DFA49_minS =
        "\x02\x04\x02\uffff";
    const string DFA49_maxS =
        "\x02\x18\x02\uffff";
    const string DFA49_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA49_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA49_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x06\uffff\x03\x02\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x06\uffff\x03\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA49_eot = DFA.UnpackEncodedString(DFA49_eotS);
    static readonly short[] DFA49_eof = DFA.UnpackEncodedString(DFA49_eofS);
    static readonly char[] DFA49_min = DFA.UnpackEncodedStringToUnsignedChars(DFA49_minS);
    static readonly char[] DFA49_max = DFA.UnpackEncodedStringToUnsignedChars(DFA49_maxS);
    static readonly short[] DFA49_accept = DFA.UnpackEncodedString(DFA49_acceptS);
    static readonly short[] DFA49_special = DFA.UnpackEncodedString(DFA49_specialS);
    static readonly short[][] DFA49_transition = DFA.UnpackEncodedStringArray(DFA49_transitionS);

    protected class DFA49 : DFA
    {
        public DFA49(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 49;
            this.eot = DFA49_eot;
            this.eof = DFA49_eof;
            this.min = DFA49_min;
            this.max = DFA49_max;
            this.accept = DFA49_accept;
            this.special = DFA49_special;
            this.transition = DFA49_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 141:4: ( ( WS )* '|' ( WS )* B= difference_p )*"; }
        }

    }

    const string DFA52_eotS =
        "\x04\uffff";
    const string DFA52_eofS =
        "\x02\x02\x02\uffff";
    const string DFA52_minS =
        "\x02\x04\x02\uffff";
    const string DFA52_maxS =
        "\x02\x19\x02\uffff";
    const string DFA52_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA52_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA52_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x06\uffff\x04\x02\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x06\uffff\x04\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA52_eot = DFA.UnpackEncodedString(DFA52_eotS);
    static readonly short[] DFA52_eof = DFA.UnpackEncodedString(DFA52_eofS);
    static readonly char[] DFA52_min = DFA.UnpackEncodedStringToUnsignedChars(DFA52_minS);
    static readonly char[] DFA52_max = DFA.UnpackEncodedStringToUnsignedChars(DFA52_maxS);
    static readonly short[] DFA52_accept = DFA.UnpackEncodedString(DFA52_acceptS);
    static readonly short[] DFA52_special = DFA.UnpackEncodedString(DFA52_specialS);
    static readonly short[][] DFA52_transition = DFA.UnpackEncodedStringArray(DFA52_transitionS);

    protected class DFA52 : DFA
    {
        public DFA52(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 52;
            this.eot = DFA52_eot;
            this.eof = DFA52_eof;
            this.min = DFA52_min;
            this.max = DFA52_max;
            this.accept = DFA52_accept;
            this.special = DFA52_special;
            this.transition = DFA52_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 153:4: ( ( WS )* '!&' ( WS )* B= intersection_p )*"; }
        }

    }

    const string DFA55_eotS =
        "\x04\uffff";
    const string DFA55_eofS =
        "\x02\x02\x02\uffff";
    const string DFA55_minS =
        "\x02\x04\x02\uffff";
    const string DFA55_maxS =
        "\x02\x1a\x02\uffff";
    const string DFA55_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA55_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA55_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x06\uffff\x05\x02\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x06\uffff\x05\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA55_eot = DFA.UnpackEncodedString(DFA55_eotS);
    static readonly short[] DFA55_eof = DFA.UnpackEncodedString(DFA55_eofS);
    static readonly char[] DFA55_min = DFA.UnpackEncodedStringToUnsignedChars(DFA55_minS);
    static readonly char[] DFA55_max = DFA.UnpackEncodedStringToUnsignedChars(DFA55_maxS);
    static readonly short[] DFA55_accept = DFA.UnpackEncodedString(DFA55_acceptS);
    static readonly short[] DFA55_special = DFA.UnpackEncodedString(DFA55_specialS);
    static readonly short[][] DFA55_transition = DFA.UnpackEncodedStringArray(DFA55_transitionS);

    protected class DFA55 : DFA
    {
        public DFA55(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 55;
            this.eot = DFA55_eot;
            this.eof = DFA55_eof;
            this.min = DFA55_min;
            this.max = DFA55_max;
            this.accept = DFA55_accept;
            this.special = DFA55_special;
            this.transition = DFA55_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 162:4: ( ( WS )* '&' ( WS )* B= filter_p )*"; }
        }

    }

    const string DFA59_eotS =
        "\x04\uffff";
    const string DFA59_eofS =
        "\x02\x02\x02\uffff";
    const string DFA59_minS =
        "\x02\x04\x02\uffff";
    const string DFA59_maxS =
        "\x02\x1a\x02\uffff";
    const string DFA59_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA59_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA59_transitionS = {
            "\x01\x01\x09\uffff\x0d\x02",
            "\x01\x01\x01\x03\x01\uffff\x01\x02\x06\uffff\x0d\x02",
            "",
            ""
    };

    static readonly short[] DFA59_eot = DFA.UnpackEncodedString(DFA59_eotS);
    static readonly short[] DFA59_eof = DFA.UnpackEncodedString(DFA59_eofS);
    static readonly char[] DFA59_min = DFA.UnpackEncodedStringToUnsignedChars(DFA59_minS);
    static readonly char[] DFA59_max = DFA.UnpackEncodedStringToUnsignedChars(DFA59_maxS);
    static readonly short[] DFA59_accept = DFA.UnpackEncodedString(DFA59_acceptS);
    static readonly short[] DFA59_special = DFA.UnpackEncodedString(DFA59_specialS);
    static readonly short[][] DFA59_transition = DFA.UnpackEncodedStringArray(DFA59_transitionS);

    protected class DFA59 : DFA
    {
        public DFA59(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 59;
            this.eot = DFA59_eot;
            this.eof = DFA59_eof;
            this.min = DFA59_min;
            this.max = DFA59_max;
            this.accept = DFA59_accept;
            this.special = DFA59_special;
            this.transition = DFA59_transition;

        }

        override public string Description
        {
            get { return "169:40: ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?"; }
        }

    }

    const string DFA69_eotS =
        "\x11\uffff";
    const string DFA69_eofS =
        "\x01\x01\x01\uffff\x02\x04\x01\uffff\x08\x04\x01\x0f\x01\x10\x02"+
        "\uffff";
    const string DFA69_minS =
        "\x01\x04\x01\uffff\x02\x04\x01\uffff\x0a\x04\x02\uffff";
    const string DFA69_maxS =
        "\x01\x21\x01\uffff\x02\x21\x01\uffff\x0a\x21\x02\uffff";
    const string DFA69_acceptS =
        "\x01\uffff\x01\x02\x02\uffff\x01\x01\x0a\uffff\x02\x01";
    const string DFA69_specialS =
        "\x11\uffff}>";
    static readonly string[] DFA69_transitionS = {
            "\x01\x01\x01\x04\x08\uffff\x01\x01\x01\uffff\x01\x03\x03\x01"+
            "\x01\x02\x06\x01\x04\uffff\x03\x04",
            "",
            "\x01\x05\x01\x04\x08\uffff\x01\x04\x01\uffff\x0b\x04\x02\uffff"+
            "\x01\x01\x01\uffff\x03\x04",
            "\x01\x06\x01\x07\x08\uffff\x01\x04\x01\uffff\x0b\x04\x04\uffff"+
            "\x03\x04",
            "",
            "\x01\x05\x01\x04\x01\uffff\x01\x04\x06\uffff\x01\x04\x01\uffff"+
            "\x0b\x04\x02\uffff\x01\x01\x04\x04",
            "\x01\x06\x01\x08\x01\uffff\x01\x04\x06\uffff\x01\x04\x01\uffff"+
            "\x0b\x04\x03\uffff\x04\x04",
            "\x02\x04\x08\uffff\x01\x04\x01\uffff\x04\x04\x01\x09\x06\x04"+
            "\x01\x01\x03\uffff\x03\x04",
            "\x02\x04\x08\uffff\x01\x04\x01\uffff\x04\x04\x01\x0a\x06\x04"+
            "\x01\x01\x03\uffff\x03\x04",
            "\x01\x04\x01\x0b\x08\uffff\x01\x04\x01\uffff\x0b\x04\x02\uffff"+
            "\x01\x04\x01\uffff\x03\x04",
            "\x01\x04\x01\x0c\x08\uffff\x01\x04\x01\uffff\x0b\x04\x02\uffff"+
            "\x01\x04\x01\uffff\x03\x04",
            "\x02\x04\x08\uffff\x01\x04\x01\uffff\x04\x04\x01\x0d\x06\x04"+
            "\x04\uffff\x03\x04",
            "\x02\x04\x08\uffff\x01\x04\x01\uffff\x04\x04\x01\x0e\x06\x04"+
            "\x04\uffff\x03\x04",
            "\x02\x0f\x08\uffff\x01\x0f\x01\uffff\x0b\x0f\x02\uffff\x01"+
            "\x0f\x01\uffff\x03\x04",
            "\x02\x10\x08\uffff\x01\x10\x01\uffff\x0b\x10\x02\uffff\x01"+
            "\x10\x01\uffff\x03\x10",
            "",
            ""
    };

    static readonly short[] DFA69_eot = DFA.UnpackEncodedString(DFA69_eotS);
    static readonly short[] DFA69_eof = DFA.UnpackEncodedString(DFA69_eofS);
    static readonly char[] DFA69_min = DFA.UnpackEncodedStringToUnsignedChars(DFA69_minS);
    static readonly char[] DFA69_max = DFA.UnpackEncodedStringToUnsignedChars(DFA69_maxS);
    static readonly short[] DFA69_accept = DFA.UnpackEncodedString(DFA69_acceptS);
    static readonly short[] DFA69_special = DFA.UnpackEncodedString(DFA69_specialS);
    static readonly short[][] DFA69_transition = DFA.UnpackEncodedStringArray(DFA69_transitionS);

    protected class DFA69 : DFA
    {
        public DFA69(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 69;
            this.eot = DFA69_eot;
            this.eof = DFA69_eof;
            this.min = DFA69_min;
            this.max = DFA69_max;
            this.accept = DFA69_accept;
            this.special = DFA69_special;
            this.transition = DFA69_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 216:19: ( UINT | '/' | '-' | '*' | '>' | '<' )+"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_prog62 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_prog64 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_once_p_in_atom103 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_every_p_in_atom112 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cron_p_in_atom121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dayofweek_p_in_atom130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_void_p_in_atom139 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paren_p_in_atom148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_datetime_p_in_once_p172 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_once_p175 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_once_p178 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_once_p180 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_once_p185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_8_in_every_p207 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p209 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_every_p214 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_every_p217 = new BitSet(new ulong[]{0x0000000000000210UL});
    public static readonly BitSet FOLLOW_9_in_every_p220 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p222 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_datetime_p_in_every_p227 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_every_p232 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_every_p235 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p237 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_every_p242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_10_in_cron_p264 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p266 = new BitSet(new ulong[]{0x00000003C0110030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p274 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p276 = new BitSet(new ulong[]{0x00000003C0110030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p284 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p286 = new BitSet(new ulong[]{0x00000003C0110030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p294 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p296 = new BitSet(new ulong[]{0x00000003C0110030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p304 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p306 = new BitSet(new ulong[]{0x00000003C0110030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p314 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p320 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_cron_p323 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p325 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_cron_p330 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_11_in_dayofweek_p352 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_dayofweek_p354 = new BitSet(new ulong[]{0x0000000140100030UL});
    public static readonly BitSet FOLLOW_intspec_p_in_dayofweek_p359 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_dayofweek_p361 = new BitSet(new ulong[]{0x0000000140100030UL});
    public static readonly BitSet FOLLOW_intspec_p_in_dayofweek_p366 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_void_p384 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_paren_p402 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_expr_in_paren_p404 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_14_in_paren_p406 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_datetime_p_in_limit_p431 = new BitSet(new ulong[]{0x0000000000008010UL});
    public static readonly BitSet FOLLOW_WS_in_limit_p433 = new BitSet(new ulong[]{0x0000000000008010UL});
    public static readonly BitSet FOLLOW_15_in_limit_p436 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_limit_p438 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_filter_p_in_limit_p443 = new BitSet(new ulong[]{0x0000000000010010UL});
    public static readonly BitSet FOLLOW_WS_in_limit_p445 = new BitSet(new ulong[]{0x0000000000010010UL});
    public static readonly BitSet FOLLOW_16_in_limit_p448 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_WS_in_limit_p450 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_datetime_p_in_limit_p455 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_limit_p467 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_limit_p_in_filter_p486 = new BitSet(new ulong[]{0x00000000001E0012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p499 = new BitSet(new ulong[]{0x0000000000020010UL});
    public static readonly BitSet FOLLOW_17_in_filter_p502 = new BitSet(new ulong[]{0x0000000140100030UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p504 = new BitSet(new ulong[]{0x0000000140100030UL});
    public static readonly BitSet FOLLOW_intspec_p_in_filter_p509 = new BitSet(new ulong[]{0x00000000001E0012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p524 = new BitSet(new ulong[]{0x0000000000040010UL});
    public static readonly BitSet FOLLOW_18_in_filter_p527 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p529 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_UINT_in_filter_p534 = new BitSet(new ulong[]{0x00000000001E0012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p549 = new BitSet(new ulong[]{0x0000000000180010UL});
    public static readonly BitSet FOLLOW_set_in_filter_p554 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p560 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_filter_p565 = new BitSet(new ulong[]{0x00000000001E0012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p580 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_filter_p583 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p585 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_filter_p590 = new BitSet(new ulong[]{0x00000000001E0012UL});
    public static readonly BitSet FOLLOW_WS_in_expr624 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_boolnonintersection_p_in_expr629 = new BitSet(new ulong[]{0x0000000000200012UL});
    public static readonly BitSet FOLLOW_WS_in_expr637 = new BitSet(new ulong[]{0x0000000000200010UL});
    public static readonly BitSet FOLLOW_21_in_expr640 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_expr642 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_boolnonintersection_p_in_expr647 = new BitSet(new ulong[]{0x0000000000200012UL});
    public static readonly BitSet FOLLOW_WS_in_expr654 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_boolintersection_p_in_boolnonintersection_p678 = new BitSet(new ulong[]{0x0000000000400012UL});
    public static readonly BitSet FOLLOW_WS_in_boolnonintersection_p686 = new BitSet(new ulong[]{0x0000000000400010UL});
    public static readonly BitSet FOLLOW_22_in_boolnonintersection_p689 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_boolnonintersection_p691 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_boolintersection_p_in_boolnonintersection_p696 = new BitSet(new ulong[]{0x0000000000400012UL});
    public static readonly BitSet FOLLOW_union_p_in_boolintersection_p721 = new BitSet(new ulong[]{0x0000000000800012UL});
    public static readonly BitSet FOLLOW_WS_in_boolintersection_p729 = new BitSet(new ulong[]{0x0000000000800010UL});
    public static readonly BitSet FOLLOW_23_in_boolintersection_p732 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_boolintersection_p734 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_union_p_in_boolintersection_p739 = new BitSet(new ulong[]{0x0000000000800012UL});
    public static readonly BitSet FOLLOW_difference_p_in_union_p772 = new BitSet(new ulong[]{0x0000000001000012UL});
    public static readonly BitSet FOLLOW_WS_in_union_p780 = new BitSet(new ulong[]{0x0000000001000010UL});
    public static readonly BitSet FOLLOW_24_in_union_p783 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_union_p785 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_difference_p_in_union_p790 = new BitSet(new ulong[]{0x0000000001000012UL});
    public static readonly BitSet FOLLOW_intersection_p_in_difference_p826 = new BitSet(new ulong[]{0x0000000002000012UL});
    public static readonly BitSet FOLLOW_WS_in_difference_p834 = new BitSet(new ulong[]{0x0000000002000010UL});
    public static readonly BitSet FOLLOW_25_in_difference_p837 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_difference_p839 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_intersection_p_in_difference_p844 = new BitSet(new ulong[]{0x0000000002000012UL});
    public static readonly BitSet FOLLOW_filter_p_in_intersection_p873 = new BitSet(new ulong[]{0x0000000004000012UL});
    public static readonly BitSet FOLLOW_WS_in_intersection_p881 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_26_in_intersection_p884 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_WS_in_intersection_p886 = new BitSet(new ulong[]{0x0000000000003D30UL});
    public static readonly BitSet FOLLOW_filter_p_in_intersection_p891 = new BitSet(new ulong[]{0x0000000004000012UL});
    public static readonly BitSet FOLLOW_year_p_in_datetime_p918 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_datetime_p920 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_month_p_in_datetime_p924 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_datetime_p926 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_day_p_in_datetime_p930 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_datetime_p933 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_hour24_p_in_datetime_p938 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_datetime_p940 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_minute60_p_in_datetime_p944 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_27_in_datetime_p947 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_second60_p_in_datetime_p951 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_datetime_p954 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_millisecond1000_p_in_datetime_p958 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_hour24_p_in_datetime_p973 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_datetime_p975 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_minute60_p_in_datetime_p979 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_27_in_datetime_p982 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_second60_p_in_datetime_p986 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_datetime_p989 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_millisecond1000_p_in_datetime_p993 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_datetime_p_in_datetime_prog1017 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_datetime_prog1019 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_year_p1034 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_month_p1046 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_day_p1058 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_hour24_p1070 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_minute60_p1082 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_second60_p1094 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_millisecond1000_p1106 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_timespan_p1124 = new BitSet(new ulong[]{0x0000000140100020UL});
    public static readonly BitSet FOLLOW_days_p_in_timespan_p1131 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_timespan_p1133 = new BitSet(new ulong[]{0x0000000140100020UL});
    public static readonly BitSet FOLLOW_hours_p_in_timespan_p1139 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_timespan_p1141 = new BitSet(new ulong[]{0x0000000140100020UL});
    public static readonly BitSet FOLLOW_minutes_p_in_timespan_p1147 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_timespan_p1149 = new BitSet(new ulong[]{0x0000000140100020UL});
    public static readonly BitSet FOLLOW_seconds_p_in_timespan_p1155 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_timespan_p1158 = new BitSet(new ulong[]{0x0000000140100020UL});
    public static readonly BitSet FOLLOW_milliseconds_p_in_timespan_p1162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_timespan_p_in_timespan_prog1184 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_timespan_prog1186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_days_p1201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_hours_p1213 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_minutes_p1225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_seconds_p1237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_milliseconds_p1249 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cron_term_p_in_cron_field_p1258 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_21_in_cron_field_p1261 = new BitSet(new ulong[]{0x00000003C0110020UL});
    public static readonly BitSet FOLLOW_cron_term_p_in_cron_field_p1263 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_30_in_cron_term_p1271 = new BitSet(new ulong[]{0x0000000380110020UL});
    public static readonly BitSet FOLLOW_set_in_cron_term_p1274 = new BitSet(new ulong[]{0x0000000380110022UL});
    public static readonly BitSet FOLLOW_intspec_term_p_in_intspec_p1304 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_21_in_intspec_p1307 = new BitSet(new ulong[]{0x0000000140100020UL});
    public static readonly BitSet FOLLOW_intspec_term_p_in_intspec_p1309 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_30_in_intspec_term_p1317 = new BitSet(new ulong[]{0x0000000140100020UL});
    public static readonly BitSet FOLLOW_32_in_intspec_term_p1322 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_int_p_in_intspec_term_p1326 = new BitSet(new ulong[]{0x0000000080100002UL});
    public static readonly BitSet FOLLOW_20_in_intspec_term_p1330 = new BitSet(new ulong[]{0x0000000140100020UL});
    public static readonly BitSet FOLLOW_int_p_in_intspec_term_p1332 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_31_in_intspec_term_p1341 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_UINT_in_intspec_term_p1343 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_20_in_int_p1356 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_UINT_in_int_p1359 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred8_TimeDef175 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred8_TimeDef178 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred8_TimeDef180 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred8_TimeDef185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred15_TimeDef232 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred15_TimeDef235 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred15_TimeDef237 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred15_TimeDef242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred23_TimeDef320 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred23_TimeDef323 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred23_TimeDef325 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred23_TimeDef330 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_21_in_synpred75_TimeDef1261 = new BitSet(new ulong[]{0x00000003C0110020UL});
    public static readonly BitSet FOLLOW_cron_term_p_in_synpred75_TimeDef1263 = new BitSet(new ulong[]{0x0000000000000002UL});

}
