// $ANTLR 3.2 Sep 23, 2009 12:02:23 TimeDef.g 2011-06-19 12:45:11

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
    // TimeDef.g:47:1: atom returns [ISchedule value] : ( once_p | every_p | cron_p | void_p | paren_p );
    public TimeDefParser.atom_return atom() // throws RecognitionException [1]
    {   
        TimeDefParser.atom_return retval = new TimeDefParser.atom_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.once_p_return once_p3 = default(TimeDefParser.once_p_return);

        TimeDefParser.every_p_return every_p4 = default(TimeDefParser.every_p_return);

        TimeDefParser.cron_p_return cron_p5 = default(TimeDefParser.cron_p_return);

        TimeDefParser.void_p_return void_p6 = default(TimeDefParser.void_p_return);

        TimeDefParser.paren_p_return paren_p7 = default(TimeDefParser.paren_p_return);



        try 
    	{
            // TimeDef.g:47:31: ( once_p | every_p | cron_p | void_p | paren_p )
            int alt1 = 5;
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
                    // TimeDef.g:51:4: void_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_void_p_in_atom130);
                    	void_p6 = void_p();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, void_p6.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((void_p6 != null) ? void_p6.value : default(VoidSchedule)); 
                    	}

                    }
                    break;
                case 5 :
                    // TimeDef.g:52:4: paren_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_paren_p_in_atom139);
                    	paren_p7 = paren_p();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, paren_p7.Tree);
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.value =  ((paren_p7 != null) ? paren_p7.value : default(ISchedule)); 
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

        IToken WS8 = null;
        IToken string_literal9 = null;
        IToken WS10 = null;
        TimeDefParser.datetime_p_return start = default(TimeDefParser.datetime_p_return);

        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        object WS8_tree=null;
        object string_literal9_tree=null;
        object WS10_tree=null;

        try 
    	{
            // TimeDef.g:58:39: ( (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:58:41: (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:58:41: (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:59:4: start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		PushFollow(FOLLOW_datetime_p_in_once_p163);
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
            		        			    	WS8=(IToken)Match(input,WS,FOLLOW_WS_in_once_p166); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS8_tree = (object)adaptor.Create(WS8);
            		        			    		adaptor.AddChild(root_0, WS8_tree);
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

            		        	string_literal9=(IToken)Match(input,7,FOLLOW_7_in_once_p169); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal9_tree = (object)adaptor.Create(string_literal9);
            		        		adaptor.AddChild(root_0, string_literal9_tree);
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
            		        			    	WS10=(IToken)Match(input,WS,FOLLOW_WS_in_once_p171); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS10_tree = (object)adaptor.Create(WS10);
            		        			    		adaptor.AddChild(root_0, WS10_tree);
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

            		        	PushFollow(FOLLOW_timespan_p_in_once_p176);
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

        IToken string_literal11 = null;
        IToken WS12 = null;
        IToken WS13 = null;
        IToken string_literal14 = null;
        IToken WS15 = null;
        IToken WS16 = null;
        IToken string_literal17 = null;
        IToken WS18 = null;
        TimeDefParser.timespan_p_return interval = default(TimeDefParser.timespan_p_return);

        TimeDefParser.datetime_p_return sync = default(TimeDefParser.datetime_p_return);

        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        object string_literal11_tree=null;
        object WS12_tree=null;
        object WS13_tree=null;
        object string_literal14_tree=null;
        object WS15_tree=null;
        object WS16_tree=null;
        object string_literal17_tree=null;
        object WS18_tree=null;

        try 
    	{
            // TimeDef.g:62:41: ( ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:62:43: ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:62:43: ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:63:4: 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		string_literal11=(IToken)Match(input,8,FOLLOW_8_in_every_p198); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{string_literal11_tree = (object)adaptor.Create(string_literal11);
            			adaptor.AddChild(root_0, string_literal11_tree);
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
            				    	WS12=(IToken)Match(input,WS,FOLLOW_WS_in_every_p200); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS12_tree = (object)adaptor.Create(WS12);
            				    		adaptor.AddChild(root_0, WS12_tree);
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

            		PushFollow(FOLLOW_timespan_p_in_every_p205);
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
            		        			    	WS13=(IToken)Match(input,WS,FOLLOW_WS_in_every_p208); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS13_tree = (object)adaptor.Create(WS13);
            		        			    		adaptor.AddChild(root_0, WS13_tree);
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

            		        	string_literal14=(IToken)Match(input,9,FOLLOW_9_in_every_p211); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal14_tree = (object)adaptor.Create(string_literal14);
            		        		adaptor.AddChild(root_0, string_literal14_tree);
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
            		        			    	WS15=(IToken)Match(input,WS,FOLLOW_WS_in_every_p213); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS15_tree = (object)adaptor.Create(WS15);
            		        			    		adaptor.AddChild(root_0, WS15_tree);
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

            		        	PushFollow(FOLLOW_datetime_p_in_every_p218);
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
            		        			    	WS16=(IToken)Match(input,WS,FOLLOW_WS_in_every_p223); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS16_tree = (object)adaptor.Create(WS16);
            		        			    		adaptor.AddChild(root_0, WS16_tree);
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

            		        	string_literal17=(IToken)Match(input,7,FOLLOW_7_in_every_p226); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal17_tree = (object)adaptor.Create(string_literal17);
            		        		adaptor.AddChild(root_0, string_literal17_tree);
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
            		        			    	WS18=(IToken)Match(input,WS,FOLLOW_WS_in_every_p228); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS18_tree = (object)adaptor.Create(WS18);
            		        			    		adaptor.AddChild(root_0, WS18_tree);
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

            		        	PushFollow(FOLLOW_timespan_p_in_every_p233);
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
    // TimeDef.g:66:1: cron_p returns [CronSchedule value] : ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) ;
    public TimeDefParser.cron_p_return cron_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_p_return retval = new TimeDefParser.cron_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal19 = null;
        IToken WS20 = null;
        IToken WS21 = null;
        IToken WS22 = null;
        IToken WS23 = null;
        IToken WS24 = null;
        IToken WS25 = null;
        IToken string_literal26 = null;
        IToken WS27 = null;
        TimeDefParser.cron_field_p_return minute = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.cron_field_p_return hour = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.cron_field_p_return day = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.cron_field_p_return month = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.dow_cron_field_p_return dow = default(TimeDefParser.dow_cron_field_p_return);

        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        object string_literal19_tree=null;
        object WS20_tree=null;
        object WS21_tree=null;
        object WS22_tree=null;
        object WS23_tree=null;
        object WS24_tree=null;
        object WS25_tree=null;
        object string_literal26_tree=null;
        object WS27_tree=null;

        try 
    	{
            // TimeDef.g:66:36: ( ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:66:38: ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:66:38: ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:67:4: 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		string_literal19=(IToken)Match(input,10,FOLLOW_10_in_cron_p255); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{string_literal19_tree = (object)adaptor.Create(string_literal19);
            			adaptor.AddChild(root_0, string_literal19_tree);
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
            				    	WS20=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p257); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS20_tree = (object)adaptor.Create(WS20);
            				    		adaptor.AddChild(root_0, WS20_tree);
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p265);
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
            				    	WS21=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p267); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS21_tree = (object)adaptor.Create(WS21);
            				    		adaptor.AddChild(root_0, WS21_tree);
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p275);
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
            				    	WS22=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p277); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS22_tree = (object)adaptor.Create(WS22);
            				    		adaptor.AddChild(root_0, WS22_tree);
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p285);
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
            				    	WS23=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p287); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS23_tree = (object)adaptor.Create(WS23);
            				    		adaptor.AddChild(root_0, WS23_tree);
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p295);
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
            				    	WS24=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p297); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS24_tree = (object)adaptor.Create(WS24);
            				    		adaptor.AddChild(root_0, WS24_tree);
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

            		PushFollow(FOLLOW_dow_cron_field_p_in_cron_p305);
            		dow = dow_cron_field_p();
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
            		        			    	WS25=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p311); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS25_tree = (object)adaptor.Create(WS25);
            		        			    		adaptor.AddChild(root_0, WS25_tree);
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

            		        	string_literal26=(IToken)Match(input,7,FOLLOW_7_in_cron_p314); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal26_tree = (object)adaptor.Create(string_literal26);
            		        		adaptor.AddChild(root_0, string_literal26_tree);
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
            		        			    	WS27=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p316); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS27_tree = (object)adaptor.Create(WS27);
            		        			    		adaptor.AddChild(root_0, WS27_tree);
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

            		        	PushFollow(FOLLOW_timespan_p_in_cron_p321);
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
    // TimeDef.g:76:1: void_p returns [VoidSchedule value] : 'void' ;
    public TimeDefParser.void_p_return void_p() // throws RecognitionException [1]
    {   
        TimeDefParser.void_p_return retval = new TimeDefParser.void_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal28 = null;

        object string_literal28_tree=null;

        try 
    	{
            // TimeDef.g:76:36: ( 'void' )
            // TimeDef.g:77:4: 'void'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal28=(IToken)Match(input,11,FOLLOW_11_in_void_p341); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal28_tree = (object)adaptor.Create(string_literal28);
            		adaptor.AddChild(root_0, string_literal28_tree);
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
    // TimeDef.g:79:1: paren_p returns [ISchedule value] : ( '(' expr ')' ) ;
    public TimeDefParser.paren_p_return paren_p() // throws RecognitionException [1]
    {   
        TimeDefParser.paren_p_return retval = new TimeDefParser.paren_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal29 = null;
        IToken char_literal31 = null;
        TimeDefParser.expr_return expr30 = default(TimeDefParser.expr_return);


        object char_literal29_tree=null;
        object char_literal31_tree=null;

        try 
    	{
            // TimeDef.g:79:34: ( ( '(' expr ')' ) )
            // TimeDef.g:79:36: ( '(' expr ')' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:79:36: ( '(' expr ')' )
            	// TimeDef.g:80:4: '(' expr ')'
            	{
            		char_literal29=(IToken)Match(input,12,FOLLOW_12_in_paren_p359); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal29_tree = (object)adaptor.Create(char_literal29);
            			adaptor.AddChild(root_0, char_literal29_tree);
            		}
            		PushFollow(FOLLOW_expr_in_paren_p361);
            		expr30 = expr();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr30.Tree);
            		char_literal31=(IToken)Match(input,13,FOLLOW_13_in_paren_p363); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal31_tree = (object)adaptor.Create(char_literal31);
            			adaptor.AddChild(root_0, char_literal31_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((expr30 != null) ? expr30.value : default(ISchedule)); 
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
    // TimeDef.g:87:1: filter_p returns [ISchedule value] : A= atom ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )* ;
    public TimeDefParser.filter_p_return filter_p() // throws RecognitionException [1]
    {   
        TimeDefParser.filter_p_return retval = new TimeDefParser.filter_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken repeatcount = null;
        IToken op = null;
        IToken WS32 = null;
        IToken char_literal33 = null;
        IToken WS34 = null;
        IToken WS35 = null;
        IToken char_literal36 = null;
        IToken WS37 = null;
        IToken WS38 = null;
        IToken WS39 = null;
        IToken WS40 = null;
        IToken string_literal41 = null;
        IToken WS42 = null;
        TimeDefParser.atom_return A = default(TimeDefParser.atom_return);

        TimeDefParser.intspec_p_return index_intspec = default(TimeDefParser.intspec_p_return);

        TimeDefParser.timespan_p_return offset_timespan = default(TimeDefParser.timespan_p_return);

        TimeDefParser.timespan_p_return lasting_timespan = default(TimeDefParser.timespan_p_return);


        object repeatcount_tree=null;
        object op_tree=null;
        object WS32_tree=null;
        object char_literal33_tree=null;
        object WS34_tree=null;
        object WS35_tree=null;
        object char_literal36_tree=null;
        object WS37_tree=null;
        object WS38_tree=null;
        object WS39_tree=null;
        object WS40_tree=null;
        object string_literal41_tree=null;
        object WS42_tree=null;

        try 
    	{
            // TimeDef.g:87:35: (A= atom ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )* )
            // TimeDef.g:88:4: A= atom ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_filter_p387);
            	A = atom();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:88:34: ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*
            	do 
            	{
            	    int alt28 = 5;
            	    alt28 = dfa28.Predict(input);
            	    switch (alt28) 
            		{
            			case 1 :
            			    // TimeDef.g:89:7: ( ( WS )* '#' ( WS )* index_intspec= intspec_p )
            			    {
            			    	// TimeDef.g:89:7: ( ( WS )* '#' ( WS )* index_intspec= intspec_p )
            			    	// TimeDef.g:89:8: ( WS )* '#' ( WS )* index_intspec= intspec_p
            			    	{
            			    		// TimeDef.g:89:8: ( WS )*
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
            			    				    	WS32=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p400); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS32_tree = (object)adaptor.Create(WS32);
            			    				    		adaptor.AddChild(root_0, WS32_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop20;
            			    		    }
            			    		} while (true);

            			    		loop20:
            			    			;	// Stops C# compiler whining that label 'loop20' has no statements

            			    		char_literal33=(IToken)Match(input,14,FOLLOW_14_in_filter_p403); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal33_tree = (object)adaptor.Create(char_literal33);
            			    			adaptor.AddChild(root_0, char_literal33_tree);
            			    		}
            			    		// TimeDef.g:89:16: ( WS )*
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
            			    				    	WS34=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p405); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS34_tree = (object)adaptor.Create(WS34);
            			    				    		adaptor.AddChild(root_0, WS34_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop21;
            			    		    }
            			    		} while (true);

            			    		loop21:
            			    			;	// Stops C# compiler whining that label 'loop21' has no statements

            			    		PushFollow(FOLLOW_intspec_p_in_filter_p410);
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
            			    // TimeDef.g:90:7: ( ( WS )* 'x' ( WS )* repeatcount= UINT )
            			    {
            			    	// TimeDef.g:90:7: ( ( WS )* 'x' ( WS )* repeatcount= UINT )
            			    	// TimeDef.g:90:8: ( WS )* 'x' ( WS )* repeatcount= UINT
            			    	{
            			    		// TimeDef.g:90:8: ( WS )*
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
            			    				    	WS35=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p425); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS35_tree = (object)adaptor.Create(WS35);
            			    				    		adaptor.AddChild(root_0, WS35_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop22;
            			    		    }
            			    		} while (true);

            			    		loop22:
            			    			;	// Stops C# compiler whining that label 'loop22' has no statements

            			    		char_literal36=(IToken)Match(input,15,FOLLOW_15_in_filter_p428); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal36_tree = (object)adaptor.Create(char_literal36);
            			    			adaptor.AddChild(root_0, char_literal36_tree);
            			    		}
            			    		// TimeDef.g:90:16: ( WS )*
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
            			    				    	WS37=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p430); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS37_tree = (object)adaptor.Create(WS37);
            			    				    		adaptor.AddChild(root_0, WS37_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop23;
            			    		    }
            			    		} while (true);

            			    		loop23:
            			    			;	// Stops C# compiler whining that label 'loop23' has no statements

            			    		repeatcount=(IToken)Match(input,UINT,FOLLOW_UINT_in_filter_p435); if (state.failed) return retval;
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
            			    // TimeDef.g:91:7: ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p )
            			    {
            			    	// TimeDef.g:91:7: ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p )
            			    	// TimeDef.g:91:8: ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p
            			    	{
            			    		// TimeDef.g:91:8: ( WS )*
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
            			    				    	WS38=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p450); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS38_tree = (object)adaptor.Create(WS38);
            			    				    		adaptor.AddChild(root_0, WS38_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop24;
            			    		    }
            			    		} while (true);

            			    		loop24:
            			    			;	// Stops C# compiler whining that label 'loop24' has no statements

            			    		op = (IToken)input.LT(1);
            			    		if ( (input.LA(1) >= 16 && input.LA(1) <= 17) ) 
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

            			    		// TimeDef.g:91:25: ( WS )*
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
            			    				    	WS39=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p461); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS39_tree = (object)adaptor.Create(WS39);
            			    				    		adaptor.AddChild(root_0, WS39_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop25;
            			    		    }
            			    		} while (true);

            			    		loop25:
            			    			;	// Stops C# compiler whining that label 'loop25' has no statements

            			    		PushFollow(FOLLOW_timespan_p_in_filter_p466);
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
            			    // TimeDef.g:92:7: ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p )
            			    {
            			    	// TimeDef.g:92:7: ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p )
            			    	// TimeDef.g:92:8: ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p
            			    	{
            			    		// TimeDef.g:92:8: ( WS )+
            			    		int cnt26 = 0;
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
            			    				    	WS40=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p481); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS40_tree = (object)adaptor.Create(WS40);
            			    				    		adaptor.AddChild(root_0, WS40_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    if ( cnt26 >= 1 ) goto loop26;
            			    				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    			            EarlyExitException eee26 =
            			    			                new EarlyExitException(26, input);
            			    			            throw eee26;
            			    		    }
            			    		    cnt26++;
            			    		} while (true);

            			    		loop26:
            			    			;	// Stops C# compiler whining that label 'loop26' has no statements

            			    		string_literal41=(IToken)Match(input,7,FOLLOW_7_in_filter_p484); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{string_literal41_tree = (object)adaptor.Create(string_literal41);
            			    			adaptor.AddChild(root_0, string_literal41_tree);
            			    		}
            			    		// TimeDef.g:92:22: ( WS )+
            			    		int cnt27 = 0;
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
            			    				    	WS42=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p486); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS42_tree = (object)adaptor.Create(WS42);
            			    				    		adaptor.AddChild(root_0, WS42_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    if ( cnt27 >= 1 ) goto loop27;
            			    				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    			            EarlyExitException eee27 =
            			    			                new EarlyExitException(27, input);
            			    			            throw eee27;
            			    		    }
            			    		    cnt27++;
            			    		} while (true);

            			    		loop27:
            			    			;	// Stops C# compiler whining that label 'loop27' has no statements

            			    		PushFollow(FOLLOW_timespan_p_in_filter_p491);
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
            			    goto loop28;
            	    }
            	} while (true);

            	loop28:
            		;	// Stops C# compiler whining that label 'loop28' has no statements


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
    // TimeDef.g:97:1: expr returns [ISchedule value] : ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* ) ;
    public TimeDefParser.expr_return expr() // throws RecognitionException [1]
    {   
        TimeDefParser.expr_return retval = new TimeDefParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS43 = null;
        IToken WS44 = null;
        IToken char_literal45 = null;
        IToken WS46 = null;
        IToken WS47 = null;
        TimeDefParser.boolnonintersection_p_return A = default(TimeDefParser.boolnonintersection_p_return);

        TimeDefParser.boolnonintersection_p_return B = default(TimeDefParser.boolnonintersection_p_return);


        object WS43_tree=null;
        object WS44_tree=null;
        object char_literal45_tree=null;
        object WS46_tree=null;
        object WS47_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:101:1: ( ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* ) )
            // TimeDef.g:101:3: ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:101:3: ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* )
            	// TimeDef.g:102:4: ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )*
            	{
            		// TimeDef.g:102:4: ( WS )*
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
            				    	WS43=(IToken)Match(input,WS,FOLLOW_WS_in_expr525); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS43_tree = (object)adaptor.Create(WS43);
            				    		adaptor.AddChild(root_0, WS43_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    goto loop29;
            		    }
            		} while (true);

            		loop29:
            			;	// Stops C# compiler whining that label 'loop29' has no statements

            		PushFollow(FOLLOW_boolnonintersection_p_in_expr530);
            		A = boolnonintersection_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:103:4: ( ( WS )* ',' ( WS )* B= boolnonintersection_p )*
            		do 
            		{
            		    int alt32 = 2;
            		    alt32 = dfa32.Predict(input);
            		    switch (alt32) 
            			{
            				case 1 :
            				    // TimeDef.g:103:5: ( WS )* ',' ( WS )* B= boolnonintersection_p
            				    {
            				    	// TimeDef.g:103:5: ( WS )*
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
            				    			    	WS44=(IToken)Match(input,WS,FOLLOW_WS_in_expr538); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS44_tree = (object)adaptor.Create(WS44);
            				    			    		adaptor.AddChild(root_0, WS44_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop30;
            				    	    }
            				    	} while (true);

            				    	loop30:
            				    		;	// Stops C# compiler whining that label 'loop30' has no statements

            				    	char_literal45=(IToken)Match(input,18,FOLLOW_18_in_expr541); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{char_literal45_tree = (object)adaptor.Create(char_literal45);
            				    		adaptor.AddChild(root_0, char_literal45_tree);
            				    	}
            				    	// TimeDef.g:103:13: ( WS )*
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
            				    			    	WS46=(IToken)Match(input,WS,FOLLOW_WS_in_expr543); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS46_tree = (object)adaptor.Create(WS46);
            				    			    		adaptor.AddChild(root_0, WS46_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop31;
            				    	    }
            				    	} while (true);

            				    	loop31:
            				    		;	// Stops C# compiler whining that label 'loop31' has no statements

            				    	PushFollow(FOLLOW_boolnonintersection_p_in_expr548);
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
            				    goto loop32;
            		    }
            		} while (true);

            		loop32:
            			;	// Stops C# compiler whining that label 'loop32' has no statements

            		// TimeDef.g:103:73: ( WS )*
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
            				    	WS47=(IToken)Match(input,WS,FOLLOW_WS_in_expr555); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS47_tree = (object)adaptor.Create(WS47);
            				    		adaptor.AddChild(root_0, WS47_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    goto loop33;
            		    }
            		} while (true);

            		loop33:
            			;	// Stops C# compiler whining that label 'loop33' has no statements


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
    // TimeDef.g:109:1: boolnonintersection_p returns [ISchedule value] : A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )* ;
    public TimeDefParser.boolnonintersection_p_return boolnonintersection_p() // throws RecognitionException [1]
    {   
        TimeDefParser.boolnonintersection_p_return retval = new TimeDefParser.boolnonintersection_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS48 = null;
        IToken string_literal49 = null;
        IToken WS50 = null;
        TimeDefParser.boolintersection_p_return A = default(TimeDefParser.boolintersection_p_return);

        TimeDefParser.boolintersection_p_return B = default(TimeDefParser.boolintersection_p_return);


        object WS48_tree=null;
        object string_literal49_tree=null;
        object WS50_tree=null;

        try 
    	{
            // TimeDef.g:109:48: (A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )* )
            // TimeDef.g:110:4: A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_boolintersection_p_in_boolnonintersection_p579);
            	A = boolintersection_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:111:4: ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*
            	do 
            	{
            	    int alt36 = 2;
            	    alt36 = dfa36.Predict(input);
            	    switch (alt36) 
            		{
            			case 1 :
            			    // TimeDef.g:111:5: ( WS )* '!&&' ( WS )* B= boolintersection_p
            			    {
            			    	// TimeDef.g:111:5: ( WS )*
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
            			    			    	WS48=(IToken)Match(input,WS,FOLLOW_WS_in_boolnonintersection_p587); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS48_tree = (object)adaptor.Create(WS48);
            			    			    		adaptor.AddChild(root_0, WS48_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop34;
            			    	    }
            			    	} while (true);

            			    	loop34:
            			    		;	// Stops C# compiler whining that label 'loop34' has no statements

            			    	string_literal49=(IToken)Match(input,19,FOLLOW_19_in_boolnonintersection_p590); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal49_tree = (object)adaptor.Create(string_literal49);
            			    		adaptor.AddChild(root_0, string_literal49_tree);
            			    	}
            			    	// TimeDef.g:111:15: ( WS )*
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
            			    			    	WS50=(IToken)Match(input,WS,FOLLOW_WS_in_boolnonintersection_p592); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS50_tree = (object)adaptor.Create(WS50);
            			    			    		adaptor.AddChild(root_0, WS50_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop35;
            			    	    }
            			    	} while (true);

            			    	loop35:
            			    		;	// Stops C# compiler whining that label 'loop35' has no statements

            			    	PushFollow(FOLLOW_boolintersection_p_in_boolnonintersection_p597);
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
            			    goto loop36;
            	    }
            	} while (true);

            	loop36:
            		;	// Stops C# compiler whining that label 'loop36' has no statements


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
    // TimeDef.g:117:1: boolintersection_p returns [ISchedule value] : A= union_p ( ( WS )* '&&' ( WS )* B= union_p )* ;
    public TimeDefParser.boolintersection_p_return boolintersection_p() // throws RecognitionException [1]
    {   
        TimeDefParser.boolintersection_p_return retval = new TimeDefParser.boolintersection_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS51 = null;
        IToken string_literal52 = null;
        IToken WS53 = null;
        TimeDefParser.union_p_return A = default(TimeDefParser.union_p_return);

        TimeDefParser.union_p_return B = default(TimeDefParser.union_p_return);


        object WS51_tree=null;
        object string_literal52_tree=null;
        object WS53_tree=null;

        try 
    	{
            // TimeDef.g:117:45: (A= union_p ( ( WS )* '&&' ( WS )* B= union_p )* )
            // TimeDef.g:118:4: A= union_p ( ( WS )* '&&' ( WS )* B= union_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_union_p_in_boolintersection_p622);
            	A = union_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:119:4: ( ( WS )* '&&' ( WS )* B= union_p )*
            	do 
            	{
            	    int alt39 = 2;
            	    alt39 = dfa39.Predict(input);
            	    switch (alt39) 
            		{
            			case 1 :
            			    // TimeDef.g:119:5: ( WS )* '&&' ( WS )* B= union_p
            			    {
            			    	// TimeDef.g:119:5: ( WS )*
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
            			    			    	WS51=(IToken)Match(input,WS,FOLLOW_WS_in_boolintersection_p630); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS51_tree = (object)adaptor.Create(WS51);
            			    			    		adaptor.AddChild(root_0, WS51_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop37;
            			    	    }
            			    	} while (true);

            			    	loop37:
            			    		;	// Stops C# compiler whining that label 'loop37' has no statements

            			    	string_literal52=(IToken)Match(input,20,FOLLOW_20_in_boolintersection_p633); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal52_tree = (object)adaptor.Create(string_literal52);
            			    		adaptor.AddChild(root_0, string_literal52_tree);
            			    	}
            			    	// TimeDef.g:119:14: ( WS )*
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
            			    			    	WS53=(IToken)Match(input,WS,FOLLOW_WS_in_boolintersection_p635); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS53_tree = (object)adaptor.Create(WS53);
            			    			    		adaptor.AddChild(root_0, WS53_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop38;
            			    	    }
            			    	} while (true);

            			    	loop38:
            			    		;	// Stops C# compiler whining that label 'loop38' has no statements

            			    	PushFollow(FOLLOW_union_p_in_boolintersection_p640);
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
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements


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
    // TimeDef.g:125:1: union_p returns [ISchedule value] : (A= subtract_p ( ( WS )* '|' ( WS )* B= subtract_p )* ) ;
    public TimeDefParser.union_p_return union_p() // throws RecognitionException [1]
    {   
        TimeDefParser.union_p_return retval = new TimeDefParser.union_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS54 = null;
        IToken char_literal55 = null;
        IToken WS56 = null;
        TimeDefParser.subtract_p_return A = default(TimeDefParser.subtract_p_return);

        TimeDefParser.subtract_p_return B = default(TimeDefParser.subtract_p_return);


        object WS54_tree=null;
        object char_literal55_tree=null;
        object WS56_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:129:1: ( (A= subtract_p ( ( WS )* '|' ( WS )* B= subtract_p )* ) )
            // TimeDef.g:129:3: (A= subtract_p ( ( WS )* '|' ( WS )* B= subtract_p )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:129:3: (A= subtract_p ( ( WS )* '|' ( WS )* B= subtract_p )* )
            	// TimeDef.g:130:4: A= subtract_p ( ( WS )* '|' ( WS )* B= subtract_p )*
            	{
            		PushFollow(FOLLOW_subtract_p_in_union_p673);
            		A = subtract_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:131:4: ( ( WS )* '|' ( WS )* B= subtract_p )*
            		do 
            		{
            		    int alt42 = 2;
            		    alt42 = dfa42.Predict(input);
            		    switch (alt42) 
            			{
            				case 1 :
            				    // TimeDef.g:131:5: ( WS )* '|' ( WS )* B= subtract_p
            				    {
            				    	// TimeDef.g:131:5: ( WS )*
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
            				    			    	WS54=(IToken)Match(input,WS,FOLLOW_WS_in_union_p681); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS54_tree = (object)adaptor.Create(WS54);
            				    			    		adaptor.AddChild(root_0, WS54_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop40;
            				    	    }
            				    	} while (true);

            				    	loop40:
            				    		;	// Stops C# compiler whining that label 'loop40' has no statements

            				    	char_literal55=(IToken)Match(input,21,FOLLOW_21_in_union_p684); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{char_literal55_tree = (object)adaptor.Create(char_literal55);
            				    		adaptor.AddChild(root_0, char_literal55_tree);
            				    	}
            				    	// TimeDef.g:131:13: ( WS )*
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
            				    			    	WS56=(IToken)Match(input,WS,FOLLOW_WS_in_union_p686); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS56_tree = (object)adaptor.Create(WS56);
            				    			    		adaptor.AddChild(root_0, WS56_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop41;
            				    	    }
            				    	} while (true);

            				    	loop41:
            				    		;	// Stops C# compiler whining that label 'loop41' has no statements

            				    	PushFollow(FOLLOW_subtract_p_in_union_p691);
            				    	B = subtract_p();
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
            				    goto loop42;
            		    }
            		} while (true);

            		loop42:
            			;	// Stops C# compiler whining that label 'loop42' has no statements


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

    public class subtract_p_return : ParserRuleReturnScope
    {
        public ISchedule value;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "subtract_p"
    // TimeDef.g:137:1: subtract_p returns [ISchedule value] : A= difference_p ( ( WS )* '-' ( WS )* B= difference_p )* ;
    public TimeDefParser.subtract_p_return subtract_p() // throws RecognitionException [1]
    {   
        TimeDefParser.subtract_p_return retval = new TimeDefParser.subtract_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS57 = null;
        IToken char_literal58 = null;
        IToken WS59 = null;
        TimeDefParser.difference_p_return A = default(TimeDefParser.difference_p_return);

        TimeDefParser.difference_p_return B = default(TimeDefParser.difference_p_return);


        object WS57_tree=null;
        object char_literal58_tree=null;
        object WS59_tree=null;

        try 
    	{
            // TimeDef.g:137:37: (A= difference_p ( ( WS )* '-' ( WS )* B= difference_p )* )
            // TimeDef.g:138:4: A= difference_p ( ( WS )* '-' ( WS )* B= difference_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_difference_p_in_subtract_p719);
            	A = difference_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:139:4: ( ( WS )* '-' ( WS )* B= difference_p )*
            	do 
            	{
            	    int alt45 = 2;
            	    alt45 = dfa45.Predict(input);
            	    switch (alt45) 
            		{
            			case 1 :
            			    // TimeDef.g:139:5: ( WS )* '-' ( WS )* B= difference_p
            			    {
            			    	// TimeDef.g:139:5: ( WS )*
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
            			    			    	WS57=(IToken)Match(input,WS,FOLLOW_WS_in_subtract_p727); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS57_tree = (object)adaptor.Create(WS57);
            			    			    		adaptor.AddChild(root_0, WS57_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop43;
            			    	    }
            			    	} while (true);

            			    	loop43:
            			    		;	// Stops C# compiler whining that label 'loop43' has no statements

            			    	char_literal58=(IToken)Match(input,17,FOLLOW_17_in_subtract_p730); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal58_tree = (object)adaptor.Create(char_literal58);
            			    		adaptor.AddChild(root_0, char_literal58_tree);
            			    	}
            			    	// TimeDef.g:139:13: ( WS )*
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
            			    			    	WS59=(IToken)Match(input,WS,FOLLOW_WS_in_subtract_p732); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS59_tree = (object)adaptor.Create(WS59);
            			    			    		adaptor.AddChild(root_0, WS59_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop44;
            			    	    }
            			    	} while (true);

            			    	loop44:
            			    		;	// Stops C# compiler whining that label 'loop44' has no statements

            			    	PushFollow(FOLLOW_difference_p_in_subtract_p737);
            			    	B = difference_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, B.Tree);
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   retval.value =  new SubtractSchedule(retval.value, ((B != null) ? B.value : default(ISchedule))); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop45;
            	    }
            	} while (true);

            	loop45:
            		;	// Stops C# compiler whining that label 'loop45' has no statements


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
    // $ANTLR end "subtract_p"

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
    // TimeDef.g:145:1: difference_p returns [ISchedule value] : (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* ) ;
    public TimeDefParser.difference_p_return difference_p() // throws RecognitionException [1]
    {   
        TimeDefParser.difference_p_return retval = new TimeDefParser.difference_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS60 = null;
        IToken string_literal61 = null;
        IToken WS62 = null;
        TimeDefParser.intersection_p_return A = default(TimeDefParser.intersection_p_return);

        TimeDefParser.intersection_p_return B = default(TimeDefParser.intersection_p_return);


        object WS60_tree=null;
        object string_literal61_tree=null;
        object WS62_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:149:1: ( (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* ) )
            // TimeDef.g:149:3: (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:149:3: (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* )
            	// TimeDef.g:150:4: A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )*
            	{
            		PushFollow(FOLLOW_intersection_p_in_difference_p770);
            		A = intersection_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:151:4: ( ( WS )* '!&' ( WS )* B= intersection_p )*
            		do 
            		{
            		    int alt48 = 2;
            		    alt48 = dfa48.Predict(input);
            		    switch (alt48) 
            			{
            				case 1 :
            				    // TimeDef.g:151:5: ( WS )* '!&' ( WS )* B= intersection_p
            				    {
            				    	// TimeDef.g:151:5: ( WS )*
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
            				    			    	WS60=(IToken)Match(input,WS,FOLLOW_WS_in_difference_p778); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS60_tree = (object)adaptor.Create(WS60);
            				    			    		adaptor.AddChild(root_0, WS60_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop46;
            				    	    }
            				    	} while (true);

            				    	loop46:
            				    		;	// Stops C# compiler whining that label 'loop46' has no statements

            				    	string_literal61=(IToken)Match(input,22,FOLLOW_22_in_difference_p781); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{string_literal61_tree = (object)adaptor.Create(string_literal61);
            				    		adaptor.AddChild(root_0, string_literal61_tree);
            				    	}
            				    	// TimeDef.g:151:14: ( WS )*
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
            				    			    	WS62=(IToken)Match(input,WS,FOLLOW_WS_in_difference_p783); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS62_tree = (object)adaptor.Create(WS62);
            				    			    		adaptor.AddChild(root_0, WS62_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop47;
            				    	    }
            				    	} while (true);

            				    	loop47:
            				    		;	// Stops C# compiler whining that label 'loop47' has no statements

            				    	PushFollow(FOLLOW_intersection_p_in_difference_p788);
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
            				    goto loop48;
            		    }
            		} while (true);

            		loop48:
            			;	// Stops C# compiler whining that label 'loop48' has no statements


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
    // TimeDef.g:158:1: intersection_p returns [ISchedule value] : A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )* ;
    public TimeDefParser.intersection_p_return intersection_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intersection_p_return retval = new TimeDefParser.intersection_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS63 = null;
        IToken char_literal64 = null;
        IToken WS65 = null;
        TimeDefParser.filter_p_return A = default(TimeDefParser.filter_p_return);

        TimeDefParser.filter_p_return B = default(TimeDefParser.filter_p_return);


        object WS63_tree=null;
        object char_literal64_tree=null;
        object WS65_tree=null;

        try 
    	{
            // TimeDef.g:158:41: (A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )* )
            // TimeDef.g:159:4: A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_filter_p_in_intersection_p817);
            	A = filter_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:160:4: ( ( WS )* '&' ( WS )* B= filter_p )*
            	do 
            	{
            	    int alt51 = 2;
            	    alt51 = dfa51.Predict(input);
            	    switch (alt51) 
            		{
            			case 1 :
            			    // TimeDef.g:160:5: ( WS )* '&' ( WS )* B= filter_p
            			    {
            			    	// TimeDef.g:160:5: ( WS )*
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
            			    			    	WS63=(IToken)Match(input,WS,FOLLOW_WS_in_intersection_p825); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS63_tree = (object)adaptor.Create(WS63);
            			    			    		adaptor.AddChild(root_0, WS63_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop49;
            			    	    }
            			    	} while (true);

            			    	loop49:
            			    		;	// Stops C# compiler whining that label 'loop49' has no statements

            			    	char_literal64=(IToken)Match(input,23,FOLLOW_23_in_intersection_p828); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal64_tree = (object)adaptor.Create(char_literal64);
            			    		adaptor.AddChild(root_0, char_literal64_tree);
            			    	}
            			    	// TimeDef.g:160:13: ( WS )*
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
            			    			    	WS65=(IToken)Match(input,WS,FOLLOW_WS_in_intersection_p830); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS65_tree = (object)adaptor.Create(WS65);
            			    			    		adaptor.AddChild(root_0, WS65_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop50;
            			    	    }
            			    	} while (true);

            			    	loop50:
            			    		;	// Stops C# compiler whining that label 'loop50' has no statements

            			    	PushFollow(FOLLOW_filter_p_in_intersection_p835);
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
            			    goto loop51;
            	    }
            	} while (true);

            	loop51:
            		;	// Stops C# compiler whining that label 'loop51' has no statements


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
    // TimeDef.g:166:1: datetime_p returns [DateTime value] : (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? ) ;
    public TimeDefParser.datetime_p_return datetime_p() // throws RecognitionException [1]
    {   
        TimeDefParser.datetime_p_return retval = new TimeDefParser.datetime_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal66 = null;
        IToken char_literal67 = null;
        IToken WS68 = null;
        IToken char_literal69 = null;
        IToken char_literal70 = null;
        IToken char_literal71 = null;
        IToken char_literal72 = null;
        IToken char_literal73 = null;
        IToken char_literal74 = null;
        TimeDefParser.year_p_return y = default(TimeDefParser.year_p_return);

        TimeDefParser.month_p_return mo = default(TimeDefParser.month_p_return);

        TimeDefParser.day_p_return d = default(TimeDefParser.day_p_return);

        TimeDefParser.hour24_p_return h = default(TimeDefParser.hour24_p_return);

        TimeDefParser.minute60_p_return m = default(TimeDefParser.minute60_p_return);

        TimeDefParser.second60_p_return s = default(TimeDefParser.second60_p_return);

        TimeDefParser.millisecond1000_p_return ms = default(TimeDefParser.millisecond1000_p_return);


        object char_literal66_tree=null;
        object char_literal67_tree=null;
        object WS68_tree=null;
        object char_literal69_tree=null;
        object char_literal70_tree=null;
        object char_literal71_tree=null;
        object char_literal72_tree=null;
        object char_literal73_tree=null;
        object char_literal74_tree=null;

        try 
    	{
            // TimeDef.g:166:36: ( (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? ) )
            // TimeDef.g:166:38: (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:166:38: (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )
            	int alt58 = 2;
            	int LA58_0 = input.LA(1);

            	if ( (LA58_0 == UINT) )
            	{
            	    int LA58_1 = input.LA(2);

            	    if ( (LA58_1 == 24) )
            	    {
            	        alt58 = 2;
            	    }
            	    else if ( (LA58_1 == 17) )
            	    {
            	        alt58 = 1;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d58s1 =
            	            new NoViableAltException("", 58, 1, input);

            	        throw nvae_d58s1;
            	    }
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d58s0 =
            	        new NoViableAltException("", 58, 0, input);

            	    throw nvae_d58s0;
            	}
            	switch (alt58) 
            	{
            	    case 1 :
            	        // TimeDef.g:167:4: y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?
            	        {
            	        	PushFollow(FOLLOW_year_p_in_datetime_p862);
            	        	y = year_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, y.Tree);
            	        	char_literal66=(IToken)Match(input,17,FOLLOW_17_in_datetime_p864); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal66_tree = (object)adaptor.Create(char_literal66);
            	        		adaptor.AddChild(root_0, char_literal66_tree);
            	        	}
            	        	PushFollow(FOLLOW_month_p_in_datetime_p868);
            	        	mo = month_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mo.Tree);
            	        	char_literal67=(IToken)Match(input,17,FOLLOW_17_in_datetime_p870); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal67_tree = (object)adaptor.Create(char_literal67);
            	        		adaptor.AddChild(root_0, char_literal67_tree);
            	        	}
            	        	PushFollow(FOLLOW_day_p_in_datetime_p874);
            	        	d = day_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, d.Tree);
            	        	// TimeDef.g:167:40: ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?
            	        	int alt55 = 2;
            	        	alt55 = dfa55.Predict(input);
            	        	switch (alt55) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:167:41: ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	        {
            	        	        	// TimeDef.g:167:41: ( WS )+
            	        	        	int cnt52 = 0;
            	        	        	do 
            	        	        	{
            	        	        	    int alt52 = 2;
            	        	        	    int LA52_0 = input.LA(1);

            	        	        	    if ( (LA52_0 == WS) )
            	        	        	    {
            	        	        	        alt52 = 1;
            	        	        	    }


            	        	        	    switch (alt52) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // TimeDef.g:0:0: WS
            	        	        			    {
            	        	        			    	WS68=(IToken)Match(input,WS,FOLLOW_WS_in_datetime_p877); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{WS68_tree = (object)adaptor.Create(WS68);
            	        	        			    		adaptor.AddChild(root_0, WS68_tree);
            	        	        			    	}

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    if ( cnt52 >= 1 ) goto loop52;
            	        	        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	        		            EarlyExitException eee52 =
            	        	        		                new EarlyExitException(52, input);
            	        	        		            throw eee52;
            	        	        	    }
            	        	        	    cnt52++;
            	        	        	} while (true);

            	        	        	loop52:
            	        	        		;	// Stops C# compiler whining that label 'loop52' has no statements

            	        	        	PushFollow(FOLLOW_hour24_p_in_datetime_p882);
            	        	        	h = hour24_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            	        	        	char_literal69=(IToken)Match(input,24,FOLLOW_24_in_datetime_p884); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal69_tree = (object)adaptor.Create(char_literal69);
            	        	        		adaptor.AddChild(root_0, char_literal69_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_minute60_p_in_datetime_p888);
            	        	        	m = minute60_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            	        	        	// TimeDef.g:167:73: ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	        	int alt54 = 2;
            	        	        	int LA54_0 = input.LA(1);

            	        	        	if ( (LA54_0 == 24) )
            	        	        	{
            	        	        	    alt54 = 1;
            	        	        	}
            	        	        	switch (alt54) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // TimeDef.g:167:74: ':' s= second60_p ( '.' ms= millisecond1000_p )?
            	        	        	        {
            	        	        	        	char_literal70=(IToken)Match(input,24,FOLLOW_24_in_datetime_p891); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{char_literal70_tree = (object)adaptor.Create(char_literal70);
            	        	        	        		adaptor.AddChild(root_0, char_literal70_tree);
            	        	        	        	}
            	        	        	        	PushFollow(FOLLOW_second60_p_in_datetime_p895);
            	        	        	        	s = second60_p();
            	        	        	        	state.followingStackPointer--;
            	        	        	        	if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            	        	        	        	// TimeDef.g:167:91: ( '.' ms= millisecond1000_p )?
            	        	        	        	int alt53 = 2;
            	        	        	        	int LA53_0 = input.LA(1);

            	        	        	        	if ( (LA53_0 == 25) )
            	        	        	        	{
            	        	        	        	    alt53 = 1;
            	        	        	        	}
            	        	        	        	switch (alt53) 
            	        	        	        	{
            	        	        	        	    case 1 :
            	        	        	        	        // TimeDef.g:167:92: '.' ms= millisecond1000_p
            	        	        	        	        {
            	        	        	        	        	char_literal71=(IToken)Match(input,25,FOLLOW_25_in_datetime_p898); if (state.failed) return retval;
            	        	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	        	{char_literal71_tree = (object)adaptor.Create(char_literal71);
            	        	        	        	        		adaptor.AddChild(root_0, char_literal71_tree);
            	        	        	        	        	}
            	        	        	        	        	PushFollow(FOLLOW_millisecond1000_p_in_datetime_p902);
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
            	        // TimeDef.g:168:4: h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        {
            	        	PushFollow(FOLLOW_hour24_p_in_datetime_p917);
            	        	h = hour24_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            	        	char_literal72=(IToken)Match(input,24,FOLLOW_24_in_datetime_p919); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal72_tree = (object)adaptor.Create(char_literal72);
            	        		adaptor.AddChild(root_0, char_literal72_tree);
            	        	}
            	        	PushFollow(FOLLOW_minute60_p_in_datetime_p923);
            	        	m = minute60_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            	        	// TimeDef.g:168:32: ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	int alt57 = 2;
            	        	int LA57_0 = input.LA(1);

            	        	if ( (LA57_0 == 24) )
            	        	{
            	        	    alt57 = 1;
            	        	}
            	        	switch (alt57) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:168:33: ':' s= second60_p ( '.' ms= millisecond1000_p )?
            	        	        {
            	        	        	char_literal73=(IToken)Match(input,24,FOLLOW_24_in_datetime_p926); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal73_tree = (object)adaptor.Create(char_literal73);
            	        	        		adaptor.AddChild(root_0, char_literal73_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_second60_p_in_datetime_p930);
            	        	        	s = second60_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            	        	        	// TimeDef.g:168:50: ( '.' ms= millisecond1000_p )?
            	        	        	int alt56 = 2;
            	        	        	int LA56_0 = input.LA(1);

            	        	        	if ( (LA56_0 == 25) )
            	        	        	{
            	        	        	    alt56 = 1;
            	        	        	}
            	        	        	switch (alt56) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // TimeDef.g:168:51: '.' ms= millisecond1000_p
            	        	        	        {
            	        	        	        	char_literal74=(IToken)Match(input,25,FOLLOW_25_in_datetime_p933); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{char_literal74_tree = (object)adaptor.Create(char_literal74);
            	        	        	        		adaptor.AddChild(root_0, char_literal74_tree);
            	        	        	        	}
            	        	        	        	PushFollow(FOLLOW_millisecond1000_p_in_datetime_p937);
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
    // TimeDef.g:180:1: datetime_prog returns [DateTime value] : ( datetime_p EOF ) ;
    public TimeDefParser.datetime_prog_return datetime_prog() // throws RecognitionException [1]
    {   
        TimeDefParser.datetime_prog_return retval = new TimeDefParser.datetime_prog_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF76 = null;
        TimeDefParser.datetime_p_return datetime_p75 = default(TimeDefParser.datetime_p_return);


        object EOF76_tree=null;

        try 
    	{
            // TimeDef.g:180:39: ( ( datetime_p EOF ) )
            // TimeDef.g:180:41: ( datetime_p EOF )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:180:41: ( datetime_p EOF )
            	// TimeDef.g:181:4: datetime_p EOF
            	{
            		PushFollow(FOLLOW_datetime_p_in_datetime_prog961);
            		datetime_p75 = datetime_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, datetime_p75.Tree);
            		EOF76=(IToken)Match(input,EOF,FOLLOW_EOF_in_datetime_prog963); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{EOF76_tree = (object)adaptor.Create(EOF76);
            			adaptor.AddChild(root_0, EOF76_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((datetime_p75 != null) ? datetime_p75.value : default(DateTime)); 
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
    // TimeDef.g:184:1: year_p returns [int value] : UINT ;
    public TimeDefParser.year_p_return year_p() // throws RecognitionException [1]
    {   
        TimeDefParser.year_p_return retval = new TimeDefParser.year_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT77 = null;

        object UINT77_tree=null;

        try 
    	{
            // TimeDef.g:184:27: ( UINT )
            // TimeDef.g:184:29: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT77=(IToken)Match(input,UINT,FOLLOW_UINT_in_year_p978); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT77_tree = (object)adaptor.Create(UINT77);
            		adaptor.AddChild(root_0, UINT77_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT77 != null) ? UINT77.Text : null)); 
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
    // TimeDef.g:185:1: month_p returns [int value] : UINT ;
    public TimeDefParser.month_p_return month_p() // throws RecognitionException [1]
    {   
        TimeDefParser.month_p_return retval = new TimeDefParser.month_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT78 = null;

        object UINT78_tree=null;

        try 
    	{
            // TimeDef.g:185:28: ( UINT )
            // TimeDef.g:185:30: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT78=(IToken)Match(input,UINT,FOLLOW_UINT_in_month_p990); if (state.failed) return retval;
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
    // TimeDef.g:186:1: day_p returns [int value] : UINT ;
    public TimeDefParser.day_p_return day_p() // throws RecognitionException [1]
    {   
        TimeDefParser.day_p_return retval = new TimeDefParser.day_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT79 = null;

        object UINT79_tree=null;

        try 
    	{
            // TimeDef.g:186:26: ( UINT )
            // TimeDef.g:186:28: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT79=(IToken)Match(input,UINT,FOLLOW_UINT_in_day_p1002); if (state.failed) return retval;
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
    // TimeDef.g:187:1: hour24_p returns [int value] : UINT ;
    public TimeDefParser.hour24_p_return hour24_p() // throws RecognitionException [1]
    {   
        TimeDefParser.hour24_p_return retval = new TimeDefParser.hour24_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT80 = null;

        object UINT80_tree=null;

        try 
    	{
            // TimeDef.g:187:29: ( UINT )
            // TimeDef.g:187:31: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT80=(IToken)Match(input,UINT,FOLLOW_UINT_in_hour24_p1014); if (state.failed) return retval;
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
    // TimeDef.g:188:1: minute60_p returns [int value] : UINT ;
    public TimeDefParser.minute60_p_return minute60_p() // throws RecognitionException [1]
    {   
        TimeDefParser.minute60_p_return retval = new TimeDefParser.minute60_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT81 = null;

        object UINT81_tree=null;

        try 
    	{
            // TimeDef.g:188:31: ( UINT )
            // TimeDef.g:188:33: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT81=(IToken)Match(input,UINT,FOLLOW_UINT_in_minute60_p1026); if (state.failed) return retval;
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
    // TimeDef.g:189:1: second60_p returns [int value] : UINT ;
    public TimeDefParser.second60_p_return second60_p() // throws RecognitionException [1]
    {   
        TimeDefParser.second60_p_return retval = new TimeDefParser.second60_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT82 = null;

        object UINT82_tree=null;

        try 
    	{
            // TimeDef.g:189:31: ( UINT )
            // TimeDef.g:189:33: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT82=(IToken)Match(input,UINT,FOLLOW_UINT_in_second60_p1038); if (state.failed) return retval;
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
    // TimeDef.g:190:1: millisecond1000_p returns [int value] : UINT ;
    public TimeDefParser.millisecond1000_p_return millisecond1000_p() // throws RecognitionException [1]
    {   
        TimeDefParser.millisecond1000_p_return retval = new TimeDefParser.millisecond1000_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT83 = null;

        object UINT83_tree=null;

        try 
    	{
            // TimeDef.g:190:38: ( UINT )
            // TimeDef.g:190:40: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT83=(IToken)Match(input,UINT,FOLLOW_UINT_in_millisecond1000_p1050); if (state.failed) return retval;
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
    // TimeDef.g:192:1: timespan_p returns [TimeSpan value] : ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? ) ;
    public TimeDefParser.timespan_p_return timespan_p() // throws RecognitionException [1]
    {   
        TimeDefParser.timespan_p_return retval = new TimeDefParser.timespan_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal84 = null;
        IToken char_literal85 = null;
        IToken char_literal86 = null;
        IToken char_literal87 = null;
        IToken char_literal88 = null;
        TimeDefParser.days_p_return d = default(TimeDefParser.days_p_return);

        TimeDefParser.hours_p_return h = default(TimeDefParser.hours_p_return);

        TimeDefParser.minutes_p_return m = default(TimeDefParser.minutes_p_return);

        TimeDefParser.seconds_p_return s = default(TimeDefParser.seconds_p_return);

        TimeDefParser.milliseconds_p_return ms = default(TimeDefParser.milliseconds_p_return);


        object char_literal84_tree=null;
        object char_literal85_tree=null;
        object char_literal86_tree=null;
        object char_literal87_tree=null;
        object char_literal88_tree=null;

        try 
    	{
            // TimeDef.g:192:36: ( ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? ) )
            // TimeDef.g:192:38: ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:192:38: ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? )
            	// TimeDef.g:193:4: 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )?
            	{
            		char_literal84=(IToken)Match(input,26,FOLLOW_26_in_timespan_p1068); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal84_tree = (object)adaptor.Create(char_literal84);
            			adaptor.AddChild(root_0, char_literal84_tree);
            		}
            		// TimeDef.g:193:8: ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )?
            		int alt61 = 2;
            		int LA61_0 = input.LA(1);

            		if ( (LA61_0 == 17) )
            		{
            		    int LA61_1 = input.LA(2);

            		    if ( (LA61_1 == UINT) )
            		    {
            		        int LA61_2 = input.LA(3);

            		        if ( (LA61_2 == 25) )
            		        {
            		            int LA61_3 = input.LA(4);

            		            if ( (LA61_3 == 17) )
            		            {
            		                int LA61_6 = input.LA(5);

            		                if ( (LA61_6 == UINT) )
            		                {
            		                    int LA61_7 = input.LA(6);

            		                    if ( (LA61_7 == 24) )
            		                    {
            		                        alt61 = 1;
            		                    }
            		                }
            		            }
            		            else if ( (LA61_3 == UINT) )
            		            {
            		                int LA61_7 = input.LA(5);

            		                if ( (LA61_7 == 24) )
            		                {
            		                    alt61 = 1;
            		                }
            		            }
            		        }
            		        else if ( (LA61_2 == 24) )
            		        {
            		            alt61 = 1;
            		        }
            		    }
            		}
            		else if ( (LA61_0 == UINT) )
            		{
            		    int LA61_2 = input.LA(2);

            		    if ( (LA61_2 == 25) )
            		    {
            		        int LA61_3 = input.LA(3);

            		        if ( (LA61_3 == 17) )
            		        {
            		            int LA61_6 = input.LA(4);

            		            if ( (LA61_6 == UINT) )
            		            {
            		                int LA61_7 = input.LA(5);

            		                if ( (LA61_7 == 24) )
            		                {
            		                    alt61 = 1;
            		                }
            		            }
            		        }
            		        else if ( (LA61_3 == UINT) )
            		        {
            		            int LA61_7 = input.LA(4);

            		            if ( (LA61_7 == 24) )
            		            {
            		                alt61 = 1;
            		            }
            		        }
            		    }
            		    else if ( (LA61_2 == 24) )
            		    {
            		        alt61 = 1;
            		    }
            		}
            		switch (alt61) 
            		{
            		    case 1 :
            		        // TimeDef.g:193:9: ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':'
            		        {
            		        	// TimeDef.g:193:9: ( (d= days_p '.' )? h= hours_p ':' )?
            		        	int alt60 = 2;
            		        	int LA60_0 = input.LA(1);

            		        	if ( (LA60_0 == 17) )
            		        	{
            		        	    int LA60_1 = input.LA(2);

            		        	    if ( (LA60_1 == UINT) )
            		        	    {
            		        	        int LA60_2 = input.LA(3);

            		        	        if ( (LA60_2 == 25) )
            		        	        {
            		        	            alt60 = 1;
            		        	        }
            		        	        else if ( (LA60_2 == 24) )
            		        	        {
            		        	            int LA60_4 = input.LA(4);

            		        	            if ( (LA60_4 == 17) )
            		        	            {
            		        	                int LA60_5 = input.LA(5);

            		        	                if ( (LA60_5 == UINT) )
            		        	                {
            		        	                    int LA60_6 = input.LA(6);

            		        	                    if ( (LA60_6 == 24) )
            		        	                    {
            		        	                        alt60 = 1;
            		        	                    }
            		        	                }
            		        	            }
            		        	            else if ( (LA60_4 == UINT) )
            		        	            {
            		        	                int LA60_6 = input.LA(5);

            		        	                if ( (LA60_6 == 24) )
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
            		        	    else if ( (LA60_2 == 24) )
            		        	    {
            		        	        int LA60_4 = input.LA(3);

            		        	        if ( (LA60_4 == 17) )
            		        	        {
            		        	            int LA60_5 = input.LA(4);

            		        	            if ( (LA60_5 == UINT) )
            		        	            {
            		        	                int LA60_6 = input.LA(5);

            		        	                if ( (LA60_6 == 24) )
            		        	                {
            		        	                    alt60 = 1;
            		        	                }
            		        	            }
            		        	        }
            		        	        else if ( (LA60_4 == UINT) )
            		        	        {
            		        	            int LA60_6 = input.LA(4);

            		        	            if ( (LA60_6 == 24) )
            		        	            {
            		        	                alt60 = 1;
            		        	            }
            		        	        }
            		        	    }
            		        	}
            		        	switch (alt60) 
            		        	{
            		        	    case 1 :
            		        	        // TimeDef.g:193:10: (d= days_p '.' )? h= hours_p ':'
            		        	        {
            		        	        	// TimeDef.g:193:10: (d= days_p '.' )?
            		        	        	int alt59 = 2;
            		        	        	int LA59_0 = input.LA(1);

            		        	        	if ( (LA59_0 == 17) )
            		        	        	{
            		        	        	    int LA59_1 = input.LA(2);

            		        	        	    if ( (LA59_1 == UINT) )
            		        	        	    {
            		        	        	        int LA59_2 = input.LA(3);

            		        	        	        if ( (LA59_2 == 25) )
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
            		        	        	        alt59 = 1;
            		        	        	    }
            		        	        	}
            		        	        	switch (alt59) 
            		        	        	{
            		        	        	    case 1 :
            		        	        	        // TimeDef.g:193:11: d= days_p '.'
            		        	        	        {
            		        	        	        	PushFollow(FOLLOW_days_p_in_timespan_p1075);
            		        	        	        	d = days_p();
            		        	        	        	state.followingStackPointer--;
            		        	        	        	if (state.failed) return retval;
            		        	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, d.Tree);
            		        	        	        	char_literal85=(IToken)Match(input,25,FOLLOW_25_in_timespan_p1077); if (state.failed) return retval;
            		        	        	        	if ( state.backtracking == 0 )
            		        	        	        	{char_literal85_tree = (object)adaptor.Create(char_literal85);
            		        	        	        		adaptor.AddChild(root_0, char_literal85_tree);
            		        	        	        	}

            		        	        	        }
            		        	        	        break;

            		        	        	}

            		        	        	PushFollow(FOLLOW_hours_p_in_timespan_p1083);
            		        	        	h = hours_p();
            		        	        	state.followingStackPointer--;
            		        	        	if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            		        	        	char_literal86=(IToken)Match(input,24,FOLLOW_24_in_timespan_p1085); if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 )
            		        	        	{char_literal86_tree = (object)adaptor.Create(char_literal86);
            		        	        		adaptor.AddChild(root_0, char_literal86_tree);
            		        	        	}

            		        	        }
            		        	        break;

            		        	}

            		        	PushFollow(FOLLOW_minutes_p_in_timespan_p1091);
            		        	m = minutes_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            		        	char_literal87=(IToken)Match(input,24,FOLLOW_24_in_timespan_p1093); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{char_literal87_tree = (object)adaptor.Create(char_literal87);
            		        		adaptor.AddChild(root_0, char_literal87_tree);
            		        	}

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_seconds_p_in_timespan_p1099);
            		s = seconds_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            		// TimeDef.g:193:72: ( '.' ms= milliseconds_p )?
            		int alt62 = 2;
            		int LA62_0 = input.LA(1);

            		if ( (LA62_0 == 25) )
            		{
            		    alt62 = 1;
            		}
            		switch (alt62) 
            		{
            		    case 1 :
            		        // TimeDef.g:193:73: '.' ms= milliseconds_p
            		        {
            		        	char_literal88=(IToken)Match(input,25,FOLLOW_25_in_timespan_p1102); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{char_literal88_tree = (object)adaptor.Create(char_literal88);
            		        		adaptor.AddChild(root_0, char_literal88_tree);
            		        	}
            		        	PushFollow(FOLLOW_milliseconds_p_in_timespan_p1106);
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
    // TimeDef.g:203:1: timespan_prog returns [TimeSpan value] : ( timespan_p EOF ) ;
    public TimeDefParser.timespan_prog_return timespan_prog() // throws RecognitionException [1]
    {   
        TimeDefParser.timespan_prog_return retval = new TimeDefParser.timespan_prog_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF90 = null;
        TimeDefParser.timespan_p_return timespan_p89 = default(TimeDefParser.timespan_p_return);


        object EOF90_tree=null;

        try 
    	{
            // TimeDef.g:203:39: ( ( timespan_p EOF ) )
            // TimeDef.g:203:41: ( timespan_p EOF )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:203:41: ( timespan_p EOF )
            	// TimeDef.g:204:4: timespan_p EOF
            	{
            		PushFollow(FOLLOW_timespan_p_in_timespan_prog1128);
            		timespan_p89 = timespan_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, timespan_p89.Tree);
            		EOF90=(IToken)Match(input,EOF,FOLLOW_EOF_in_timespan_prog1130); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{EOF90_tree = (object)adaptor.Create(EOF90);
            			adaptor.AddChild(root_0, EOF90_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((timespan_p89 != null) ? timespan_p89.value : default(TimeSpan)); 
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
    // TimeDef.g:207:1: days_p returns [int value] : int_p ;
    public TimeDefParser.days_p_return days_p() // throws RecognitionException [1]
    {   
        TimeDefParser.days_p_return retval = new TimeDefParser.days_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p91 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:207:27: ( int_p )
            // TimeDef.g:207:29: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_days_p1145);
            	int_p91 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p91.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p91 != null) ? input.ToString((IToken)(int_p91.Start),(IToken)(int_p91.Stop)) : null)); 
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
    // TimeDef.g:208:1: hours_p returns [int value] : int_p ;
    public TimeDefParser.hours_p_return hours_p() // throws RecognitionException [1]
    {   
        TimeDefParser.hours_p_return retval = new TimeDefParser.hours_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p92 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:208:28: ( int_p )
            // TimeDef.g:208:30: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_hours_p1157);
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
    // TimeDef.g:209:1: minutes_p returns [int value] : int_p ;
    public TimeDefParser.minutes_p_return minutes_p() // throws RecognitionException [1]
    {   
        TimeDefParser.minutes_p_return retval = new TimeDefParser.minutes_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p93 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:209:30: ( int_p )
            // TimeDef.g:209:32: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_minutes_p1169);
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
    // TimeDef.g:210:1: seconds_p returns [int value] : int_p ;
    public TimeDefParser.seconds_p_return seconds_p() // throws RecognitionException [1]
    {   
        TimeDefParser.seconds_p_return retval = new TimeDefParser.seconds_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p94 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:210:30: ( int_p )
            // TimeDef.g:210:32: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_seconds_p1181);
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
    // TimeDef.g:211:1: milliseconds_p returns [int value] : int_p ;
    public TimeDefParser.milliseconds_p_return milliseconds_p() // throws RecognitionException [1]
    {   
        TimeDefParser.milliseconds_p_return retval = new TimeDefParser.milliseconds_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p95 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:211:35: ( int_p )
            // TimeDef.g:211:37: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_milliseconds_p1193);
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
    // TimeDef.g:213:1: cron_field_p : cron_term_p ( ',' cron_term_p )* ;
    public TimeDefParser.cron_field_p_return cron_field_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_field_p_return retval = new TimeDefParser.cron_field_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal97 = null;
        TimeDefParser.cron_term_p_return cron_term_p96 = default(TimeDefParser.cron_term_p_return);

        TimeDefParser.cron_term_p_return cron_term_p98 = default(TimeDefParser.cron_term_p_return);


        object char_literal97_tree=null;

        try 
    	{
            // TimeDef.g:213:13: ( cron_term_p ( ',' cron_term_p )* )
            // TimeDef.g:213:15: cron_term_p ( ',' cron_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_cron_term_p_in_cron_field_p1202);
            	cron_term_p96 = cron_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cron_term_p96.Tree);
            	// TimeDef.g:213:27: ( ',' cron_term_p )*
            	do 
            	{
            	    int alt63 = 2;
            	    int LA63_0 = input.LA(1);

            	    if ( (LA63_0 == 18) )
            	    {
            	        alt63 = 1;
            	    }


            	    switch (alt63) 
            		{
            			case 1 :
            			    // TimeDef.g:213:28: ',' cron_term_p
            			    {
            			    	char_literal97=(IToken)Match(input,18,FOLLOW_18_in_cron_field_p1205); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal97_tree = (object)adaptor.Create(char_literal97);
            			    		adaptor.AddChild(root_0, char_literal97_tree);
            			    	}
            			    	PushFollow(FOLLOW_cron_term_p_in_cron_field_p1207);
            			    	cron_term_p98 = cron_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cron_term_p98.Tree);

            			    }
            			    break;

            			default:
            			    goto loop63;
            	    }
            	} while (true);

            	loop63:
            		;	// Stops C# compiler whining that label 'loop63' has no statements


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
    // TimeDef.g:214:1: cron_term_p : ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+ ;
    public TimeDefParser.cron_term_p_return cron_term_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_term_p_return retval = new TimeDefParser.cron_term_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal99 = null;
        IToken set100 = null;

        object char_literal99_tree=null;
        object set100_tree=null;

        try 
    	{
            // TimeDef.g:214:12: ( ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+ )
            // TimeDef.g:214:14: ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:214:14: ( '!' )?
            	int alt64 = 2;
            	int LA64_0 = input.LA(1);

            	if ( (LA64_0 == 27) )
            	{
            	    alt64 = 1;
            	}
            	switch (alt64) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '!'
            	        {
            	        	char_literal99=(IToken)Match(input,27,FOLLOW_27_in_cron_term_p1215); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal99_tree = (object)adaptor.Create(char_literal99);
            	        		adaptor.AddChild(root_0, char_literal99_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:214:19: ( UINT | '/' | '-' | '*' | '>' | '<' )+
            	int cnt65 = 0;
            	do 
            	{
            	    int alt65 = 2;
            	    int LA65_0 = input.LA(1);

            	    if ( (LA65_0 == UINT || LA65_0 == 17 || (LA65_0 >= 28 && LA65_0 <= 31)) )
            	    {
            	        alt65 = 1;
            	    }


            	    switch (alt65) 
            		{
            			case 1 :
            			    // TimeDef.g:
            			    {
            			    	set100 = (IToken)input.LT(1);
            			    	if ( input.LA(1) == UINT || input.LA(1) == 17 || (input.LA(1) >= 28 && input.LA(1) <= 31) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set100));
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
            			    if ( cnt65 >= 1 ) goto loop65;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee65 =
            		                new EarlyExitException(65, input);
            		            throw eee65;
            	    }
            	    cnt65++;
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
    // $ANTLR end "cron_term_p"

    public class dow_cron_field_p_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "dow_cron_field_p"
    // TimeDef.g:216:1: dow_cron_field_p : dow_cron_term_p ( ',' dow_cron_term_p )* ;
    public TimeDefParser.dow_cron_field_p_return dow_cron_field_p() // throws RecognitionException [1]
    {   
        TimeDefParser.dow_cron_field_p_return retval = new TimeDefParser.dow_cron_field_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal102 = null;
        TimeDefParser.dow_cron_term_p_return dow_cron_term_p101 = default(TimeDefParser.dow_cron_term_p_return);

        TimeDefParser.dow_cron_term_p_return dow_cron_term_p103 = default(TimeDefParser.dow_cron_term_p_return);


        object char_literal102_tree=null;

        try 
    	{
            // TimeDef.g:216:17: ( dow_cron_term_p ( ',' dow_cron_term_p )* )
            // TimeDef.g:216:19: dow_cron_term_p ( ',' dow_cron_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_dow_cron_term_p_in_dow_cron_field_p1248);
            	dow_cron_term_p101 = dow_cron_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dow_cron_term_p101.Tree);
            	// TimeDef.g:216:35: ( ',' dow_cron_term_p )*
            	do 
            	{
            	    int alt66 = 2;
            	    int LA66_0 = input.LA(1);

            	    if ( (LA66_0 == 18) )
            	    {
            	        int LA66_2 = input.LA(2);

            	        if ( (LA66_2 == UINT) )
            	        {
            	            int LA66_3 = input.LA(3);

            	            if ( (LA66_3 == EOF || (LA66_3 >= WS && LA66_3 <= ALPHA) || (LA66_3 >= 13 && LA66_3 <= 16) || (LA66_3 >= 18 && LA66_3 <= 23) || (LA66_3 >= 28 && LA66_3 <= 31)) )
            	            {
            	                alt66 = 1;
            	            }
            	            else if ( (LA66_3 == 17) )
            	            {
            	                int LA66_5 = input.LA(4);

            	                if ( (LA66_5 == UINT) )
            	                {
            	                    int LA66_6 = input.LA(5);

            	                    if ( (LA66_6 == EOF || (LA66_6 >= WS && LA66_6 <= ALPHA) || (LA66_6 >= 13 && LA66_6 <= 16) || (LA66_6 >= 18 && LA66_6 <= 24) || (LA66_6 >= 28 && LA66_6 <= 31)) )
            	                    {
            	                        alt66 = 1;
            	                    }
            	                    else if ( (LA66_6 == 17) )
            	                    {
            	                        int LA66_7 = input.LA(6);

            	                        if ( (LA66_7 == UINT) )
            	                        {
            	                            int LA66_8 = input.LA(7);

            	                            if ( (synpred78_TimeDef()) )
            	                            {
            	                                alt66 = 1;
            	                            }


            	                        }
            	                        else if ( (LA66_7 == EOF || LA66_7 == WS || LA66_7 == ALPHA || LA66_7 == 8 || (LA66_7 >= 10 && LA66_7 <= 23) || LA66_7 == 26 || (LA66_7 >= 28 && LA66_7 <= 31)) )
            	                        {
            	                            alt66 = 1;
            	                        }


            	                    }


            	                }
            	                else if ( (LA66_5 == EOF || LA66_5 == WS || LA66_5 == ALPHA || LA66_5 == 8 || (LA66_5 >= 10 && LA66_5 <= 23) || LA66_5 == 26 || (LA66_5 >= 28 && LA66_5 <= 31)) )
            	                {
            	                    alt66 = 1;
            	                }


            	            }


            	        }
            	        else if ( (LA66_2 == ALPHA || LA66_2 == 14 || LA66_2 == 17 || (LA66_2 >= 27 && LA66_2 <= 31)) )
            	        {
            	            alt66 = 1;
            	        }


            	    }


            	    switch (alt66) 
            		{
            			case 1 :
            			    // TimeDef.g:216:36: ',' dow_cron_term_p
            			    {
            			    	char_literal102=(IToken)Match(input,18,FOLLOW_18_in_dow_cron_field_p1251); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal102_tree = (object)adaptor.Create(char_literal102);
            			    		adaptor.AddChild(root_0, char_literal102_tree);
            			    	}
            			    	PushFollow(FOLLOW_dow_cron_term_p_in_dow_cron_field_p1253);
            			    	dow_cron_term_p103 = dow_cron_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dow_cron_term_p103.Tree);

            			    }
            			    break;

            			default:
            			    goto loop66;
            	    }
            	} while (true);

            	loop66:
            		;	// Stops C# compiler whining that label 'loop66' has no statements


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
    // $ANTLR end "dow_cron_field_p"

    public class dow_cron_term_p_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "dow_cron_term_p"
    // TimeDef.g:217:1: dow_cron_term_p : ( '!' )? ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+ ;
    public TimeDefParser.dow_cron_term_p_return dow_cron_term_p() // throws RecognitionException [1]
    {   
        TimeDefParser.dow_cron_term_p_return retval = new TimeDefParser.dow_cron_term_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal104 = null;
        IToken set105 = null;

        object char_literal104_tree=null;
        object set105_tree=null;

        try 
    	{
            // TimeDef.g:217:16: ( ( '!' )? ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+ )
            // TimeDef.g:217:18: ( '!' )? ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:217:18: ( '!' )?
            	int alt67 = 2;
            	int LA67_0 = input.LA(1);

            	if ( (LA67_0 == 27) )
            	{
            	    alt67 = 1;
            	}
            	switch (alt67) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '!'
            	        {
            	        	char_literal104=(IToken)Match(input,27,FOLLOW_27_in_dow_cron_term_p1261); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal104_tree = (object)adaptor.Create(char_literal104);
            	        		adaptor.AddChild(root_0, char_literal104_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:217:23: ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+
            	int cnt68 = 0;
            	do 
            	{
            	    int alt68 = 2;
            	    alt68 = dfa68.Predict(input);
            	    switch (alt68) 
            		{
            			case 1 :
            			    // TimeDef.g:
            			    {
            			    	set105 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= UINT && input.LA(1) <= ALPHA) || input.LA(1) == 14 || input.LA(1) == 17 || (input.LA(1) >= 28 && input.LA(1) <= 31) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set105));
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
            			    if ( cnt68 >= 1 ) goto loop68;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee68 =
            		                new EarlyExitException(68, input);
            		            throw eee68;
            	    }
            	    cnt68++;
            	} while (true);

            	loop68:
            		;	// Stops C# compiler whining that label 'loop68' has no statements


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
    // $ANTLR end "dow_cron_term_p"

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
    // TimeDef.g:219:1: intspec_p : intspec_term_p ( ',' intspec_term_p )* ;
    public TimeDefParser.intspec_p_return intspec_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intspec_p_return retval = new TimeDefParser.intspec_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal107 = null;
        TimeDefParser.intspec_term_p_return intspec_term_p106 = default(TimeDefParser.intspec_term_p_return);

        TimeDefParser.intspec_term_p_return intspec_term_p108 = default(TimeDefParser.intspec_term_p_return);


        object char_literal107_tree=null;

        try 
    	{
            // TimeDef.g:219:10: ( intspec_term_p ( ',' intspec_term_p )* )
            // TimeDef.g:219:12: intspec_term_p ( ',' intspec_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_intspec_term_p_in_intspec_p1302);
            	intspec_term_p106 = intspec_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intspec_term_p106.Tree);
            	// TimeDef.g:219:27: ( ',' intspec_term_p )*
            	do 
            	{
            	    int alt69 = 2;
            	    alt69 = dfa69.Predict(input);
            	    switch (alt69) 
            		{
            			case 1 :
            			    // TimeDef.g:219:28: ',' intspec_term_p
            			    {
            			    	char_literal107=(IToken)Match(input,18,FOLLOW_18_in_intspec_p1305); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal107_tree = (object)adaptor.Create(char_literal107);
            			    		adaptor.AddChild(root_0, char_literal107_tree);
            			    	}
            			    	PushFollow(FOLLOW_intspec_term_p_in_intspec_p1307);
            			    	intspec_term_p108 = intspec_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intspec_term_p108.Tree);

            			    }
            			    break;

            			default:
            			    goto loop69;
            	    }
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
    // TimeDef.g:220:1: intspec_term_p : ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )? ;
    public TimeDefParser.intspec_term_p_return intspec_term_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intspec_term_p_return retval = new TimeDefParser.intspec_term_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal109 = null;
        IToken char_literal110 = null;
        IToken char_literal112 = null;
        IToken char_literal114 = null;
        IToken UINT115 = null;
        TimeDefParser.int_p_return int_p111 = default(TimeDefParser.int_p_return);

        TimeDefParser.int_p_return int_p113 = default(TimeDefParser.int_p_return);


        object char_literal109_tree=null;
        object char_literal110_tree=null;
        object char_literal112_tree=null;
        object char_literal114_tree=null;
        object UINT115_tree=null;

        try 
    	{
            // TimeDef.g:220:15: ( ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )? )
            // TimeDef.g:220:17: ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:220:17: ( '!' )?
            	int alt70 = 2;
            	int LA70_0 = input.LA(1);

            	if ( (LA70_0 == 27) )
            	{
            	    alt70 = 1;
            	}
            	switch (alt70) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '!'
            	        {
            	        	char_literal109=(IToken)Match(input,27,FOLLOW_27_in_intspec_term_p1315); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal109_tree = (object)adaptor.Create(char_literal109);
            	        		adaptor.AddChild(root_0, char_literal109_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:220:22: ( '*' | int_p ( '-' int_p )? )
            	int alt72 = 2;
            	int LA72_0 = input.LA(1);

            	if ( (LA72_0 == 29) )
            	{
            	    alt72 = 1;
            	}
            	else if ( (LA72_0 == UINT || LA72_0 == 17) )
            	{
            	    alt72 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d72s0 =
            	        new NoViableAltException("", 72, 0, input);

            	    throw nvae_d72s0;
            	}
            	switch (alt72) 
            	{
            	    case 1 :
            	        // TimeDef.g:220:24: '*'
            	        {
            	        	char_literal110=(IToken)Match(input,29,FOLLOW_29_in_intspec_term_p1320); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal110_tree = (object)adaptor.Create(char_literal110);
            	        		adaptor.AddChild(root_0, char_literal110_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // TimeDef.g:220:30: int_p ( '-' int_p )?
            	        {
            	        	PushFollow(FOLLOW_int_p_in_intspec_term_p1324);
            	        	int_p111 = int_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p111.Tree);
            	        	// TimeDef.g:220:36: ( '-' int_p )?
            	        	int alt71 = 2;
            	        	alt71 = dfa71.Predict(input);
            	        	switch (alt71) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:220:38: '-' int_p
            	        	        {
            	        	        	char_literal112=(IToken)Match(input,17,FOLLOW_17_in_intspec_term_p1328); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal112_tree = (object)adaptor.Create(char_literal112);
            	        	        		adaptor.AddChild(root_0, char_literal112_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_int_p_in_intspec_term_p1330);
            	        	        	int_p113 = int_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p113.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// TimeDef.g:220:53: ( '/' UINT )?
            	int alt73 = 2;
            	int LA73_0 = input.LA(1);

            	if ( (LA73_0 == 28) )
            	{
            	    alt73 = 1;
            	}
            	switch (alt73) 
            	{
            	    case 1 :
            	        // TimeDef.g:220:55: '/' UINT
            	        {
            	        	char_literal114=(IToken)Match(input,28,FOLLOW_28_in_intspec_term_p1339); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal114_tree = (object)adaptor.Create(char_literal114);
            	        		adaptor.AddChild(root_0, char_literal114_tree);
            	        	}
            	        	UINT115=(IToken)Match(input,UINT,FOLLOW_UINT_in_intspec_term_p1341); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UINT115_tree = (object)adaptor.Create(UINT115);
            	        		adaptor.AddChild(root_0, UINT115_tree);
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
    // TimeDef.g:225:1: int_p : ( '-' )? UINT ;
    public TimeDefParser.int_p_return int_p() // throws RecognitionException [1]
    {   
        TimeDefParser.int_p_return retval = new TimeDefParser.int_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal116 = null;
        IToken UINT117 = null;

        object char_literal116_tree=null;
        object UINT117_tree=null;

        try 
    	{
            // TimeDef.g:225:6: ( ( '-' )? UINT )
            // TimeDef.g:225:8: ( '-' )? UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:225:8: ( '-' )?
            	int alt74 = 2;
            	int LA74_0 = input.LA(1);

            	if ( (LA74_0 == 17) )
            	{
            	    alt74 = 1;
            	}
            	switch (alt74) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '-'
            	        {
            	        	char_literal116=(IToken)Match(input,17,FOLLOW_17_in_int_p1354); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal116_tree = (object)adaptor.Create(char_literal116);
            	        		adaptor.AddChild(root_0, char_literal116_tree);
            	        	}

            	        }
            	        break;

            	}

            	UINT117=(IToken)Match(input,UINT,FOLLOW_UINT_in_int_p1357); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT117_tree = (object)adaptor.Create(UINT117);
            		adaptor.AddChild(root_0, UINT117_tree);
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

    // $ANTLR start "synpred7_TimeDef"
    public void synpred7_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        // TimeDef.g:59:22: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:59:22: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:59:22: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred7_TimeDef166); if (state.failed) return ;

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

        	Match(input,7,FOLLOW_7_in_synpred7_TimeDef169); if (state.failed) return ;
        	// TimeDef.g:59:36: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred7_TimeDef171); if (state.failed) return ;

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

        	PushFollow(FOLLOW_timespan_p_in_synpred7_TimeDef176);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_TimeDef"

    // $ANTLR start "synpred14_TimeDef"
    public void synpred14_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        // TimeDef.g:63:72: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:63:72: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:63:72: ( WS )+
        	int cnt79 = 0;
        	do 
        	{
        	    int alt79 = 2;
        	    int LA79_0 = input.LA(1);

        	    if ( (LA79_0 == WS) )
        	    {
        	        alt79 = 1;
        	    }


        	    switch (alt79) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred14_TimeDef223); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt79 >= 1 ) goto loop79;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee79 =
        		                new EarlyExitException(79, input);
        		            throw eee79;
        	    }
        	    cnt79++;
        	} while (true);

        	loop79:
        		;	// Stops C# compiler whining that label 'loop79' has no statements

        	Match(input,7,FOLLOW_7_in_synpred14_TimeDef226); if (state.failed) return ;
        	// TimeDef.g:63:86: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred14_TimeDef228); if (state.failed) return ;

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

        	PushFollow(FOLLOW_timespan_p_in_synpred14_TimeDef233);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred14_TimeDef"

    // $ANTLR start "synpred22_TimeDef"
    public void synpred22_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        // TimeDef.g:73:5: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:73:5: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:73:5: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred22_TimeDef311); if (state.failed) return ;

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

        	Match(input,7,FOLLOW_7_in_synpred22_TimeDef314); if (state.failed) return ;
        	// TimeDef.g:73:19: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred22_TimeDef316); if (state.failed) return ;

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

        	PushFollow(FOLLOW_timespan_p_in_synpred22_TimeDef321);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred22_TimeDef"

    // $ANTLR start "synpred78_TimeDef"
    public void synpred78_TimeDef_fragment() {
        // TimeDef.g:216:36: ( ',' dow_cron_term_p )
        // TimeDef.g:216:36: ',' dow_cron_term_p
        {
        	Match(input,18,FOLLOW_18_in_synpred78_TimeDef1251); if (state.failed) return ;
        	PushFollow(FOLLOW_dow_cron_term_p_in_synpred78_TimeDef1253);
        	dow_cron_term_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred78_TimeDef"

    // Delegated rules

   	public bool synpred22_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred22_TimeDef_fragment(); // can never throw exception
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
   	public bool synpred7_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_TimeDef_fragment(); // can never throw exception
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
   	public bool synpred14_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred14_TimeDef_fragment(); // can never throw exception
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
   	public bool synpred78_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred78_TimeDef_fragment(); // can never throw exception
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
   	protected DFA28 dfa28;
   	protected DFA32 dfa32;
   	protected DFA36 dfa36;
   	protected DFA39 dfa39;
   	protected DFA42 dfa42;
   	protected DFA45 dfa45;
   	protected DFA48 dfa48;
   	protected DFA51 dfa51;
   	protected DFA55 dfa55;
   	protected DFA68 dfa68;
   	protected DFA69 dfa69;
   	protected DFA71 dfa71;
	private void InitializeCyclicDFAs()
	{
    	this.dfa4 = new DFA4(this);
    	this.dfa8 = new DFA8(this);
    	this.dfa11 = new DFA11(this);
    	this.dfa19 = new DFA19(this);
    	this.dfa28 = new DFA28(this);
    	this.dfa32 = new DFA32(this);
    	this.dfa36 = new DFA36(this);
    	this.dfa39 = new DFA39(this);
    	this.dfa42 = new DFA42(this);
    	this.dfa45 = new DFA45(this);
    	this.dfa48 = new DFA48(this);
    	this.dfa51 = new DFA51(this);
    	this.dfa55 = new DFA55(this);
    	this.dfa68 = new DFA68(this);
    	this.dfa69 = new DFA69(this);
    	this.dfa71 = new DFA71(this);
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
        "\x02\x17\x01\uffff\x01\x04\x01\x1a\x01\x11\x01\x05\x01\x00\x01"+
        "\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01";
    const string DFA4_specialS =
        "\x07\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x01\x08\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x03\x05\uffff\x0b\x02",
            "",
            "\x01\x04",
            "\x01\x04\x15\uffff\x01\x05",
            "\x01\x07\x0b\uffff\x01\x06",
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
                   	if ( (synpred7_TimeDef()) ) { s = 8; }

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
        "\x02\x17\x02\uffff";
    const string DFA8_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA8_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x01\x01\x08\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x02\x01\uffff\x01\x03\x03\uffff\x0b"+
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
        "\x02\x17\x01\uffff\x01\x04\x01\x1a\x01\x11\x01\x05\x01\x00\x01"+
        "\uffff";
    const string DFA11_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01";
    const string DFA11_specialS =
        "\x07\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x01\x08\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x03\x05\uffff\x0b\x02",
            "",
            "\x01\x04",
            "\x01\x04\x15\uffff\x01\x05",
            "\x01\x07\x0b\uffff\x01\x06",
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
                   	if ( (synpred14_TimeDef()) ) { s = 8; }

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
        "\x02\x17\x01\uffff\x01\x04\x01\x1a\x01\x11\x01\x05\x01\x00\x01"+
        "\uffff";
    const string DFA19_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01";
    const string DFA19_specialS =
        "\x07\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x01\x01\x08\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x03\x05\uffff\x0b\x02",
            "",
            "\x01\x04",
            "\x01\x04\x15\uffff\x01\x05",
            "\x01\x07\x0b\uffff\x01\x06",
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
                   	if ( (synpred22_TimeDef()) ) { s = 8; }

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
    const string DFA28_eotS =
        "\x09\uffff";
    const string DFA28_eofS =
        "\x02\x02\x07\uffff";
    const string DFA28_minS =
        "\x02\x04\x01\uffff\x01\x04\x04\uffff\x01\x04";
    const string DFA28_maxS =
        "\x02\x17\x01\uffff\x01\x1a\x04\uffff\x01\x1a";
    const string DFA28_acceptS =
        "\x02\uffff\x01\x05\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01"+
        "\uffff";
    const string DFA28_specialS =
        "\x09\uffff}>";
    static readonly string[] DFA28_transitionS = {
            "\x01\x01\x08\uffff\x01\x02\x01\x04\x01\x05\x01\x06\x01\x03"+
            "\x06\x02",
            "\x01\x01\x02\uffff\x01\x07\x05\uffff\x01\x02\x01\x04\x01\x05"+
            "\x01\x06\x01\x03\x06\x02",
            "",
            "\x01\x08\x01\x02\x02\uffff\x01\x02\x01\uffff\x03\x02\x0d\uffff"+
            "\x01\x06",
            "",
            "",
            "",
            "",
            "\x01\x08\x01\x02\x02\uffff\x01\x02\x01\uffff\x03\x02\x0d\uffff"+
            "\x01\x06"
    };

    static readonly short[] DFA28_eot = DFA.UnpackEncodedString(DFA28_eotS);
    static readonly short[] DFA28_eof = DFA.UnpackEncodedString(DFA28_eofS);
    static readonly char[] DFA28_min = DFA.UnpackEncodedStringToUnsignedChars(DFA28_minS);
    static readonly char[] DFA28_max = DFA.UnpackEncodedStringToUnsignedChars(DFA28_maxS);
    static readonly short[] DFA28_accept = DFA.UnpackEncodedString(DFA28_acceptS);
    static readonly short[] DFA28_special = DFA.UnpackEncodedString(DFA28_specialS);
    static readonly short[][] DFA28_transition = DFA.UnpackEncodedStringArray(DFA28_transitionS);

    protected class DFA28 : DFA
    {
        public DFA28(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 28;
            this.eot = DFA28_eot;
            this.eof = DFA28_eof;
            this.min = DFA28_min;
            this.max = DFA28_max;
            this.accept = DFA28_accept;
            this.special = DFA28_special;
            this.transition = DFA28_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 88:34: ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*"; }
        }

    }

    const string DFA32_eotS =
        "\x04\uffff";
    const string DFA32_eofS =
        "\x02\x02\x02\uffff";
    const string DFA32_minS =
        "\x02\x04\x02\uffff";
    const string DFA32_maxS =
        "\x02\x12\x02\uffff";
    const string DFA32_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA32_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA32_transitionS = {
            "\x01\x01\x08\uffff\x01\x02\x04\uffff\x01\x03",
            "\x01\x01\x08\uffff\x01\x02\x04\uffff\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA32_eot = DFA.UnpackEncodedString(DFA32_eotS);
    static readonly short[] DFA32_eof = DFA.UnpackEncodedString(DFA32_eofS);
    static readonly char[] DFA32_min = DFA.UnpackEncodedStringToUnsignedChars(DFA32_minS);
    static readonly char[] DFA32_max = DFA.UnpackEncodedStringToUnsignedChars(DFA32_maxS);
    static readonly short[] DFA32_accept = DFA.UnpackEncodedString(DFA32_acceptS);
    static readonly short[] DFA32_special = DFA.UnpackEncodedString(DFA32_specialS);
    static readonly short[][] DFA32_transition = DFA.UnpackEncodedStringArray(DFA32_transitionS);

    protected class DFA32 : DFA
    {
        public DFA32(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 32;
            this.eot = DFA32_eot;
            this.eof = DFA32_eof;
            this.min = DFA32_min;
            this.max = DFA32_max;
            this.accept = DFA32_accept;
            this.special = DFA32_special;
            this.transition = DFA32_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 103:4: ( ( WS )* ',' ( WS )* B= boolnonintersection_p )*"; }
        }

    }

    const string DFA36_eotS =
        "\x04\uffff";
    const string DFA36_eofS =
        "\x02\x02\x02\uffff";
    const string DFA36_minS =
        "\x02\x04\x02\uffff";
    const string DFA36_maxS =
        "\x02\x13\x02\uffff";
    const string DFA36_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA36_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA36_transitionS = {
            "\x01\x01\x08\uffff\x01\x02\x04\uffff\x01\x02\x01\x03",
            "\x01\x01\x08\uffff\x01\x02\x04\uffff\x01\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA36_eot = DFA.UnpackEncodedString(DFA36_eotS);
    static readonly short[] DFA36_eof = DFA.UnpackEncodedString(DFA36_eofS);
    static readonly char[] DFA36_min = DFA.UnpackEncodedStringToUnsignedChars(DFA36_minS);
    static readonly char[] DFA36_max = DFA.UnpackEncodedStringToUnsignedChars(DFA36_maxS);
    static readonly short[] DFA36_accept = DFA.UnpackEncodedString(DFA36_acceptS);
    static readonly short[] DFA36_special = DFA.UnpackEncodedString(DFA36_specialS);
    static readonly short[][] DFA36_transition = DFA.UnpackEncodedStringArray(DFA36_transitionS);

    protected class DFA36 : DFA
    {
        public DFA36(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 36;
            this.eot = DFA36_eot;
            this.eof = DFA36_eof;
            this.min = DFA36_min;
            this.max = DFA36_max;
            this.accept = DFA36_accept;
            this.special = DFA36_special;
            this.transition = DFA36_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 111:4: ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*"; }
        }

    }

    const string DFA39_eotS =
        "\x04\uffff";
    const string DFA39_eofS =
        "\x02\x02\x02\uffff";
    const string DFA39_minS =
        "\x02\x04\x02\uffff";
    const string DFA39_maxS =
        "\x02\x14\x02\uffff";
    const string DFA39_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA39_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA39_transitionS = {
            "\x01\x01\x08\uffff\x01\x02\x04\uffff\x02\x02\x01\x03",
            "\x01\x01\x08\uffff\x01\x02\x04\uffff\x02\x02\x01\x03",
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
            get { return "()* loopback of 119:4: ( ( WS )* '&&' ( WS )* B= union_p )*"; }
        }

    }

    const string DFA42_eotS =
        "\x04\uffff";
    const string DFA42_eofS =
        "\x02\x02\x02\uffff";
    const string DFA42_minS =
        "\x02\x04\x02\uffff";
    const string DFA42_maxS =
        "\x02\x15\x02\uffff";
    const string DFA42_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA42_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA42_transitionS = {
            "\x01\x01\x08\uffff\x01\x02\x04\uffff\x03\x02\x01\x03",
            "\x01\x01\x08\uffff\x01\x02\x04\uffff\x03\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA42_eot = DFA.UnpackEncodedString(DFA42_eotS);
    static readonly short[] DFA42_eof = DFA.UnpackEncodedString(DFA42_eofS);
    static readonly char[] DFA42_min = DFA.UnpackEncodedStringToUnsignedChars(DFA42_minS);
    static readonly char[] DFA42_max = DFA.UnpackEncodedStringToUnsignedChars(DFA42_maxS);
    static readonly short[] DFA42_accept = DFA.UnpackEncodedString(DFA42_acceptS);
    static readonly short[] DFA42_special = DFA.UnpackEncodedString(DFA42_specialS);
    static readonly short[][] DFA42_transition = DFA.UnpackEncodedStringArray(DFA42_transitionS);

    protected class DFA42 : DFA
    {
        public DFA42(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 42;
            this.eot = DFA42_eot;
            this.eof = DFA42_eof;
            this.min = DFA42_min;
            this.max = DFA42_max;
            this.accept = DFA42_accept;
            this.special = DFA42_special;
            this.transition = DFA42_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 131:4: ( ( WS )* '|' ( WS )* B= subtract_p )*"; }
        }

    }

    const string DFA45_eotS =
        "\x04\uffff";
    const string DFA45_eofS =
        "\x02\x02\x02\uffff";
    const string DFA45_minS =
        "\x02\x04\x02\uffff";
    const string DFA45_maxS =
        "\x02\x15\x02\uffff";
    const string DFA45_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA45_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA45_transitionS = {
            "\x01\x01\x08\uffff\x01\x02\x03\uffff\x01\x03\x04\x02",
            "\x01\x01\x08\uffff\x01\x02\x03\uffff\x01\x03\x04\x02",
            "",
            ""
    };

    static readonly short[] DFA45_eot = DFA.UnpackEncodedString(DFA45_eotS);
    static readonly short[] DFA45_eof = DFA.UnpackEncodedString(DFA45_eofS);
    static readonly char[] DFA45_min = DFA.UnpackEncodedStringToUnsignedChars(DFA45_minS);
    static readonly char[] DFA45_max = DFA.UnpackEncodedStringToUnsignedChars(DFA45_maxS);
    static readonly short[] DFA45_accept = DFA.UnpackEncodedString(DFA45_acceptS);
    static readonly short[] DFA45_special = DFA.UnpackEncodedString(DFA45_specialS);
    static readonly short[][] DFA45_transition = DFA.UnpackEncodedStringArray(DFA45_transitionS);

    protected class DFA45 : DFA
    {
        public DFA45(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 45;
            this.eot = DFA45_eot;
            this.eof = DFA45_eof;
            this.min = DFA45_min;
            this.max = DFA45_max;
            this.accept = DFA45_accept;
            this.special = DFA45_special;
            this.transition = DFA45_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 139:4: ( ( WS )* '-' ( WS )* B= difference_p )*"; }
        }

    }

    const string DFA48_eotS =
        "\x04\uffff";
    const string DFA48_eofS =
        "\x02\x02\x02\uffff";
    const string DFA48_minS =
        "\x02\x04\x02\uffff";
    const string DFA48_maxS =
        "\x02\x16\x02\uffff";
    const string DFA48_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA48_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA48_transitionS = {
            "\x01\x01\x08\uffff\x01\x02\x03\uffff\x05\x02\x01\x03",
            "\x01\x01\x08\uffff\x01\x02\x03\uffff\x05\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA48_eot = DFA.UnpackEncodedString(DFA48_eotS);
    static readonly short[] DFA48_eof = DFA.UnpackEncodedString(DFA48_eofS);
    static readonly char[] DFA48_min = DFA.UnpackEncodedStringToUnsignedChars(DFA48_minS);
    static readonly char[] DFA48_max = DFA.UnpackEncodedStringToUnsignedChars(DFA48_maxS);
    static readonly short[] DFA48_accept = DFA.UnpackEncodedString(DFA48_acceptS);
    static readonly short[] DFA48_special = DFA.UnpackEncodedString(DFA48_specialS);
    static readonly short[][] DFA48_transition = DFA.UnpackEncodedStringArray(DFA48_transitionS);

    protected class DFA48 : DFA
    {
        public DFA48(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 48;
            this.eot = DFA48_eot;
            this.eof = DFA48_eof;
            this.min = DFA48_min;
            this.max = DFA48_max;
            this.accept = DFA48_accept;
            this.special = DFA48_special;
            this.transition = DFA48_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 151:4: ( ( WS )* '!&' ( WS )* B= intersection_p )*"; }
        }

    }

    const string DFA51_eotS =
        "\x04\uffff";
    const string DFA51_eofS =
        "\x02\x02\x02\uffff";
    const string DFA51_minS =
        "\x02\x04\x02\uffff";
    const string DFA51_maxS =
        "\x02\x17\x02\uffff";
    const string DFA51_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA51_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA51_transitionS = {
            "\x01\x01\x08\uffff\x01\x02\x03\uffff\x06\x02\x01\x03",
            "\x01\x01\x08\uffff\x01\x02\x03\uffff\x06\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA51_eot = DFA.UnpackEncodedString(DFA51_eotS);
    static readonly short[] DFA51_eof = DFA.UnpackEncodedString(DFA51_eofS);
    static readonly char[] DFA51_min = DFA.UnpackEncodedStringToUnsignedChars(DFA51_minS);
    static readonly char[] DFA51_max = DFA.UnpackEncodedStringToUnsignedChars(DFA51_maxS);
    static readonly short[] DFA51_accept = DFA.UnpackEncodedString(DFA51_acceptS);
    static readonly short[] DFA51_special = DFA.UnpackEncodedString(DFA51_specialS);
    static readonly short[][] DFA51_transition = DFA.UnpackEncodedStringArray(DFA51_transitionS);

    protected class DFA51 : DFA
    {
        public DFA51(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 51;
            this.eot = DFA51_eot;
            this.eof = DFA51_eof;
            this.min = DFA51_min;
            this.max = DFA51_max;
            this.accept = DFA51_accept;
            this.special = DFA51_special;
            this.transition = DFA51_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 160:4: ( ( WS )* '&' ( WS )* B= filter_p )*"; }
        }

    }

    const string DFA55_eotS =
        "\x04\uffff";
    const string DFA55_eofS =
        "\x02\x02\x02\uffff";
    const string DFA55_minS =
        "\x02\x04\x02\uffff";
    const string DFA55_maxS =
        "\x02\x17\x02\uffff";
    const string DFA55_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA55_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA55_transitionS = {
            "\x01\x01\x08\uffff\x0b\x02",
            "\x01\x01\x01\x03\x01\uffff\x01\x02\x05\uffff\x0b\x02",
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
            get { return "167:40: ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?"; }
        }

    }

    const string DFA68_eotS =
        "\x1b\uffff";
    const string DFA68_eofS =
        "\x01\x01\x01\uffff\x02\x08\x01\uffff\x01\x08\x01\uffff\x01\x08"+
        "\x01\uffff\x02\x0c\x02\uffff\x01\x0c\x01\x01\x01\x0c\x01\uffff\x01"+
        "\x13\x01\x01\x02\uffff\x01\x13\x01\uffff\x01\x01\x01\uffff\x01\x01"+
        "\x01\uffff";
    const string DFA68_minS =
        "\x01\x04\x01\uffff\x02\x04\x01\uffff\x01\x04\x01\uffff\x01\x04"+
        "\x01\uffff\x03\x04\x01\uffff\x06\x04\x01\uffff\x07\x04";
    const string DFA68_maxS =
        "\x01\x1f\x01\uffff\x02\x1f\x01\uffff\x01\x1d\x01\uffff\x01\x1f"+
        "\x01\uffff\x01\x1a\x01\x1f\x01\x1a\x01\uffff\x01\x1f\x01\x1c\x01"+
        "\x1f\x01\x1a\x01\x1f\x01\x1c\x01\uffff\x01\x1a\x01\x18\x01\x1a\x01"+
        "\x18\x01\x1a\x01\x18\x01\x1a";
    const string DFA68_acceptS =
        "\x01\uffff\x01\x02\x02\uffff\x01\x01\x01\uffff\x01\x01\x01\uffff"+
        "\x01\x01\x03\uffff\x01\x01\x06\uffff\x01\x01\x07\uffff";
    const string DFA68_specialS =
        "\x1b\uffff}>";
    static readonly string[] DFA68_transitionS = {
            "\x01\x01\x02\x04\x06\uffff\x01\x01\x01\x02\x02\x01\x01\x03"+
            "\x06\x01\x04\uffff\x04\x04",
            "",
            "\x01\x05\x01\x08\x01\x04\x06\uffff\x04\x08\x01\x07\x06\x08"+
            "\x03\uffff\x01\x01\x01\x04\x01\x06\x02\x04",
            "\x01\x09\x01\x0a\x01\x04\x01\uffff\x01\x01\x01\uffff\x03\x01"+
            "\x0b\x08\x02\uffff\x01\x01\x01\uffff\x04\x04",
            "",
            "\x01\x05\x01\x01\x01\uffff\x01\x08\x05\uffff\x04\x08\x01\x0b"+
            "\x06\x08\x03\uffff\x01\x01\x01\uffff\x01\x01",
            "",
            "\x01\x08\x01\x0c\x01\x04\x01\uffff\x01\x0c\x01\uffff\x03\x0c"+
            "\x0b\x08\x02\uffff\x01\x0c\x01\uffff\x04\x04",
            "",
            "\x01\x09\x01\x01\x01\uffff\x01\x0c\x01\x01\x01\uffff\x03\x01"+
            "\x0b\x0c\x02\uffff\x01\x01",
            "\x01\x0c\x02\x04\x06\uffff\x04\x0c\x01\x0d\x06\x0c\x01\x01"+
            "\x03\uffff\x04\x04",
            "\x01\x0c\x01\x0e\x02\uffff\x01\x0c\x01\uffff\x03\x0c\x0d\uffff"+
            "\x01\x0c",
            "",
            "\x01\x0c\x01\x0f\x01\x04\x01\uffff\x01\x0c\x01\uffff\x0e\x0c"+
            "\x02\uffff\x01\x0c\x01\uffff\x04\x04",
            "\x01\x01\x08\uffff\x04\x01\x01\x10\x06\x01\x01\x0c\x03\uffff"+
            "\x01\x01",
            "\x01\x0c\x02\x04\x06\uffff\x04\x0c\x01\x11\x07\x0c\x03\uffff"+
            "\x04\x04",
            "\x01\x01\x01\x12\x02\uffff\x01\x01\x01\uffff\x03\x01\x04\uffff"+
            "\x01\x01\x08\uffff\x01\x01",
            "\x02\x13\x01\x04\x01\uffff\x01\x13\x01\uffff\x0e\x13\x02\uffff"+
            "\x01\x13\x01\uffff\x04\x04",
            "\x01\x01\x08\uffff\x04\x01\x01\x14\x07\x01\x03\uffff\x01\x01",
            "",
            "\x01\x01\x01\x15\x02\uffff\x01\x01\x01\uffff\x03\x01\x0d\uffff"+
            "\x01\x01",
            "\x01\x13\x08\uffff\x04\x13\x01\x16\x06\x13\x01\x01",
            "\x01\x13\x01\x17\x02\uffff\x01\x13\x01\uffff\x03\x13\x0d\uffff"+
            "\x01\x13",
            "\x01\x01\x08\uffff\x04\x01\x01\x18\x06\x01\x01\x13",
            "\x01\x01\x01\x19\x02\uffff\x01\x01\x01\uffff\x03\x01\x0d\uffff"+
            "\x01\x01",
            "\x01\x01\x08\uffff\x04\x01\x01\x1a\x07\x01",
            "\x01\x01\x01\x15\x02\uffff\x01\x01\x01\uffff\x03\x01\x0d\uffff"+
            "\x01\x01"
    };

    static readonly short[] DFA68_eot = DFA.UnpackEncodedString(DFA68_eotS);
    static readonly short[] DFA68_eof = DFA.UnpackEncodedString(DFA68_eofS);
    static readonly char[] DFA68_min = DFA.UnpackEncodedStringToUnsignedChars(DFA68_minS);
    static readonly char[] DFA68_max = DFA.UnpackEncodedStringToUnsignedChars(DFA68_maxS);
    static readonly short[] DFA68_accept = DFA.UnpackEncodedString(DFA68_acceptS);
    static readonly short[] DFA68_special = DFA.UnpackEncodedString(DFA68_specialS);
    static readonly short[][] DFA68_transition = DFA.UnpackEncodedStringArray(DFA68_transitionS);

    protected class DFA68 : DFA
    {
        public DFA68(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 68;
            this.eot = DFA68_eot;
            this.eof = DFA68_eof;
            this.min = DFA68_min;
            this.max = DFA68_max;
            this.accept = DFA68_accept;
            this.special = DFA68_special;
            this.transition = DFA68_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 217:23: ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+"; }
        }

    }

    const string DFA69_eotS =
        "\x10\uffff";
    const string DFA69_eofS =
        "\x01\x01\x03\uffff\x01\x03\x01\uffff\x01\x03\x01\uffff\x01\x01"+
        "\x01\uffff\x01\x03\x01\uffff\x01\x03\x01\uffff\x01\x01\x01\uffff";
    const string DFA69_minS =
        "\x01\x04\x01\uffff\x01\x04\x01\uffff\x0c\x04";
    const string DFA69_maxS =
        "\x01\x17\x01\uffff\x01\x1d\x01\uffff\x01\x1c\x01\x1a\x01\x1c\x01"+
        "\x1a\x01\x18\x01\x1a\x01\x18\x01\x1a\x01\x18\x01\x1a\x01\x18\x01"+
        "\x1a";
    const string DFA69_acceptS =
        "\x01\uffff\x01\x02\x01\uffff\x01\x01\x0c\uffff";
    const string DFA69_specialS =
        "\x10\uffff}>";
    static readonly string[] DFA69_transitionS = {
            "\x01\x01\x08\uffff\x05\x01\x01\x02\x05\x01",
            "",
            "\x01\x01\x01\x04\x02\uffff\x01\x01\x01\uffff\x03\x01\x04\uffff"+
            "\x01\x03\x09\uffff\x01\x03\x01\uffff\x01\x03",
            "",
            "\x01\x03\x08\uffff\x04\x03\x01\x05\x06\x03\x01\x01\x03\uffff"+
            "\x01\x03",
            "\x01\x03\x01\x06\x02\uffff\x01\x03\x01\uffff\x03\x03\x04\uffff"+
            "\x01\x03\x08\uffff\x01\x03",
            "\x01\x03\x08\uffff\x04\x03\x01\x07\x07\x03\x03\uffff\x01\x03",
            "\x01\x03\x01\x08\x02\uffff\x01\x03\x01\uffff\x03\x03\x0d\uffff"+
            "\x01\x03",
            "\x01\x01\x08\uffff\x04\x01\x01\x09\x06\x01\x01\x03",
            "\x01\x01\x01\x0a\x02\uffff\x01\x01\x01\uffff\x03\x01\x0d\uffff"+
            "\x01\x01",
            "\x01\x03\x08\uffff\x04\x03\x01\x0b\x06\x03\x01\x01",
            "\x01\x03\x01\x0c\x02\uffff\x01\x03\x01\uffff\x03\x03\x0d\uffff"+
            "\x01\x03",
            "\x01\x03\x08\uffff\x04\x03\x01\x0d\x07\x03",
            "\x01\x03\x01\x0e\x02\uffff\x01\x03\x01\uffff\x03\x03\x0d\uffff"+
            "\x01\x03",
            "\x01\x01\x08\uffff\x04\x01\x01\x0f\x06\x01\x01\x03",
            "\x01\x01\x01\x0a\x02\uffff\x01\x01\x01\uffff\x03\x01\x0d\uffff"+
            "\x01\x01"
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
            get { return "()* loopback of 219:27: ( ',' intspec_term_p )*"; }
        }

    }

    const string DFA71_eotS =
        "\x0c\uffff";
    const string DFA71_eofS =
        "\x01\x02\x03\uffff\x01\x03\x03\uffff\x01\x02\x01\uffff\x01\x03"+
        "\x01\uffff";
    const string DFA71_minS =
        "\x02\x04\x02\uffff\x02\x04\x01\x11\x01\x05\x04\x04";
    const string DFA71_maxS =
        "\x01\x1c\x01\x1a\x02\uffff\x01\x1c\x01\x1a\x01\x18\x01\x05\x01"+
        "\x17\x01\x1a\x01\x18\x01\x1a";
    const string DFA71_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x08\uffff";
    const string DFA71_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA71_transitionS = {
            "\x01\x02\x08\uffff\x04\x02\x01\x01\x06\x02\x04\uffff\x01\x02",
            "\x01\x02\x01\x04\x02\uffff\x01\x02\x01\uffff\x03\x02\x04\uffff"+
            "\x01\x03\x08\uffff\x01\x02",
            "",
            "",
            "\x01\x03\x08\uffff\x04\x03\x01\x05\x06\x03\x01\x02\x03\uffff"+
            "\x01\x03",
            "\x01\x03\x01\x06\x02\uffff\x01\x03\x01\uffff\x03\x03\x0d\uffff"+
            "\x01\x03",
            "\x01\x07\x06\uffff\x01\x03",
            "\x01\x08",
            "\x01\x02\x08\uffff\x04\x02\x01\x09\x06\x02",
            "\x01\x02\x01\x0a\x02\uffff\x01\x02\x01\uffff\x03\x02\x0d\uffff"+
            "\x01\x02",
            "\x01\x03\x08\uffff\x04\x03\x01\x0b\x06\x03\x01\x02",
            "\x01\x03\x01\x06\x02\uffff\x01\x03\x01\uffff\x03\x03\x0d\uffff"+
            "\x01\x03"
    };

    static readonly short[] DFA71_eot = DFA.UnpackEncodedString(DFA71_eotS);
    static readonly short[] DFA71_eof = DFA.UnpackEncodedString(DFA71_eofS);
    static readonly char[] DFA71_min = DFA.UnpackEncodedStringToUnsignedChars(DFA71_minS);
    static readonly char[] DFA71_max = DFA.UnpackEncodedStringToUnsignedChars(DFA71_maxS);
    static readonly short[] DFA71_accept = DFA.UnpackEncodedString(DFA71_acceptS);
    static readonly short[] DFA71_special = DFA.UnpackEncodedString(DFA71_specialS);
    static readonly short[][] DFA71_transition = DFA.UnpackEncodedStringArray(DFA71_transitionS);

    protected class DFA71 : DFA
    {
        public DFA71(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 71;
            this.eot = DFA71_eot;
            this.eof = DFA71_eof;
            this.min = DFA71_min;
            this.max = DFA71_max;
            this.accept = DFA71_accept;
            this.special = DFA71_special;
            this.transition = DFA71_transition;

        }

        override public string Description
        {
            get { return "220:36: ( '-' int_p )?"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_prog62 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_prog64 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_once_p_in_atom103 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_every_p_in_atom112 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cron_p_in_atom121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_void_p_in_atom130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paren_p_in_atom139 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_datetime_p_in_once_p163 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_once_p166 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_once_p169 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_once_p171 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_once_p176 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_8_in_every_p198 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p200 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_every_p205 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_every_p208 = new BitSet(new ulong[]{0x0000000000000210UL});
    public static readonly BitSet FOLLOW_9_in_every_p211 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p213 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_datetime_p_in_every_p218 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_every_p223 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_every_p226 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p228 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_every_p233 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_10_in_cron_p255 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p257 = new BitSet(new ulong[]{0x00000000F8020030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p265 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p267 = new BitSet(new ulong[]{0x00000000F8020030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p275 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p277 = new BitSet(new ulong[]{0x00000000F8020030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p285 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p287 = new BitSet(new ulong[]{0x00000000F8020030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p295 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p297 = new BitSet(new ulong[]{0x00000000F8024070UL});
    public static readonly BitSet FOLLOW_dow_cron_field_p_in_cron_p305 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p311 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_cron_p314 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p316 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_cron_p321 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_11_in_void_p341 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_paren_p359 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_expr_in_paren_p361 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_13_in_paren_p363 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_filter_p387 = new BitSet(new ulong[]{0x000000000003C012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p400 = new BitSet(new ulong[]{0x0000000000004010UL});
    public static readonly BitSet FOLLOW_14_in_filter_p403 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p405 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_intspec_p_in_filter_p410 = new BitSet(new ulong[]{0x000000000003C012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p425 = new BitSet(new ulong[]{0x0000000000008010UL});
    public static readonly BitSet FOLLOW_15_in_filter_p428 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p430 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_UINT_in_filter_p435 = new BitSet(new ulong[]{0x000000000003C012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p450 = new BitSet(new ulong[]{0x0000000000030010UL});
    public static readonly BitSet FOLLOW_set_in_filter_p455 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p461 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_filter_p466 = new BitSet(new ulong[]{0x000000000003C012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p481 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_filter_p484 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p486 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_filter_p491 = new BitSet(new ulong[]{0x000000000003C012UL});
    public static readonly BitSet FOLLOW_WS_in_expr525 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_boolnonintersection_p_in_expr530 = new BitSet(new ulong[]{0x0000000000040012UL});
    public static readonly BitSet FOLLOW_WS_in_expr538 = new BitSet(new ulong[]{0x0000000000040010UL});
    public static readonly BitSet FOLLOW_18_in_expr541 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_expr543 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_boolnonintersection_p_in_expr548 = new BitSet(new ulong[]{0x0000000000040012UL});
    public static readonly BitSet FOLLOW_WS_in_expr555 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_boolintersection_p_in_boolnonintersection_p579 = new BitSet(new ulong[]{0x0000000000080012UL});
    public static readonly BitSet FOLLOW_WS_in_boolnonintersection_p587 = new BitSet(new ulong[]{0x0000000000080010UL});
    public static readonly BitSet FOLLOW_19_in_boolnonintersection_p590 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_boolnonintersection_p592 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_boolintersection_p_in_boolnonintersection_p597 = new BitSet(new ulong[]{0x0000000000080012UL});
    public static readonly BitSet FOLLOW_union_p_in_boolintersection_p622 = new BitSet(new ulong[]{0x0000000000100012UL});
    public static readonly BitSet FOLLOW_WS_in_boolintersection_p630 = new BitSet(new ulong[]{0x0000000000100010UL});
    public static readonly BitSet FOLLOW_20_in_boolintersection_p633 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_boolintersection_p635 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_union_p_in_boolintersection_p640 = new BitSet(new ulong[]{0x0000000000100012UL});
    public static readonly BitSet FOLLOW_subtract_p_in_union_p673 = new BitSet(new ulong[]{0x0000000000200012UL});
    public static readonly BitSet FOLLOW_WS_in_union_p681 = new BitSet(new ulong[]{0x0000000000200010UL});
    public static readonly BitSet FOLLOW_21_in_union_p684 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_union_p686 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_subtract_p_in_union_p691 = new BitSet(new ulong[]{0x0000000000200012UL});
    public static readonly BitSet FOLLOW_difference_p_in_subtract_p719 = new BitSet(new ulong[]{0x0000000000020012UL});
    public static readonly BitSet FOLLOW_WS_in_subtract_p727 = new BitSet(new ulong[]{0x0000000000020010UL});
    public static readonly BitSet FOLLOW_17_in_subtract_p730 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_subtract_p732 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_difference_p_in_subtract_p737 = new BitSet(new ulong[]{0x0000000000020012UL});
    public static readonly BitSet FOLLOW_intersection_p_in_difference_p770 = new BitSet(new ulong[]{0x0000000000400012UL});
    public static readonly BitSet FOLLOW_WS_in_difference_p778 = new BitSet(new ulong[]{0x0000000000400010UL});
    public static readonly BitSet FOLLOW_22_in_difference_p781 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_difference_p783 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_intersection_p_in_difference_p788 = new BitSet(new ulong[]{0x0000000000400012UL});
    public static readonly BitSet FOLLOW_filter_p_in_intersection_p817 = new BitSet(new ulong[]{0x0000000000800012UL});
    public static readonly BitSet FOLLOW_WS_in_intersection_p825 = new BitSet(new ulong[]{0x0000000000800010UL});
    public static readonly BitSet FOLLOW_23_in_intersection_p828 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_intersection_p830 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_filter_p_in_intersection_p835 = new BitSet(new ulong[]{0x0000000000800012UL});
    public static readonly BitSet FOLLOW_year_p_in_datetime_p862 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_datetime_p864 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_month_p_in_datetime_p868 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_datetime_p870 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_day_p_in_datetime_p874 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_datetime_p877 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_hour24_p_in_datetime_p882 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_datetime_p884 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_minute60_p_in_datetime_p888 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_24_in_datetime_p891 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_second60_p_in_datetime_p895 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_25_in_datetime_p898 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_millisecond1000_p_in_datetime_p902 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_hour24_p_in_datetime_p917 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_datetime_p919 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_minute60_p_in_datetime_p923 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_24_in_datetime_p926 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_second60_p_in_datetime_p930 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_25_in_datetime_p933 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_millisecond1000_p_in_datetime_p937 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_datetime_p_in_datetime_prog961 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_datetime_prog963 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_year_p978 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_month_p990 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_day_p1002 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_hour24_p1014 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_minute60_p1026 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_second60_p1038 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_millisecond1000_p1050 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_timespan_p1068 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_days_p_in_timespan_p1075 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_timespan_p1077 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_hours_p_in_timespan_p1083 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_timespan_p1085 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_minutes_p_in_timespan_p1091 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_timespan_p1093 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_seconds_p_in_timespan_p1099 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_25_in_timespan_p1102 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_milliseconds_p_in_timespan_p1106 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_timespan_p_in_timespan_prog1128 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_timespan_prog1130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_days_p1145 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_hours_p1157 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_minutes_p1169 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_seconds_p1181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_milliseconds_p1193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cron_term_p_in_cron_field_p1202 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_18_in_cron_field_p1205 = new BitSet(new ulong[]{0x00000000F8020020UL});
    public static readonly BitSet FOLLOW_cron_term_p_in_cron_field_p1207 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_27_in_cron_term_p1215 = new BitSet(new ulong[]{0x00000000F0020020UL});
    public static readonly BitSet FOLLOW_set_in_cron_term_p1218 = new BitSet(new ulong[]{0x00000000F0020022UL});
    public static readonly BitSet FOLLOW_dow_cron_term_p_in_dow_cron_field_p1248 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_18_in_dow_cron_field_p1251 = new BitSet(new ulong[]{0x00000000F8024060UL});
    public static readonly BitSet FOLLOW_dow_cron_term_p_in_dow_cron_field_p1253 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_27_in_dow_cron_term_p1261 = new BitSet(new ulong[]{0x00000000F0024060UL});
    public static readonly BitSet FOLLOW_set_in_dow_cron_term_p1264 = new BitSet(new ulong[]{0x00000000F0024062UL});
    public static readonly BitSet FOLLOW_intspec_term_p_in_intspec_p1302 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_18_in_intspec_p1305 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_intspec_term_p_in_intspec_p1307 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_27_in_intspec_term_p1315 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_29_in_intspec_term_p1320 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_int_p_in_intspec_term_p1324 = new BitSet(new ulong[]{0x0000000010020002UL});
    public static readonly BitSet FOLLOW_17_in_intspec_term_p1328 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_int_p_in_intspec_term_p1330 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_intspec_term_p1339 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_UINT_in_intspec_term_p1341 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_17_in_int_p1354 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_UINT_in_int_p1357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred7_TimeDef166 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred7_TimeDef169 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred7_TimeDef171 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred7_TimeDef176 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred14_TimeDef223 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred14_TimeDef226 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred14_TimeDef228 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred14_TimeDef233 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred22_TimeDef311 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred22_TimeDef314 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred22_TimeDef316 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred22_TimeDef321 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_18_in_synpred78_TimeDef1251 = new BitSet(new ulong[]{0x00000000F8024060UL});
    public static readonly BitSet FOLLOW_dow_cron_term_p_in_synpred78_TimeDef1253 = new BitSet(new ulong[]{0x0000000000000002UL});

}
