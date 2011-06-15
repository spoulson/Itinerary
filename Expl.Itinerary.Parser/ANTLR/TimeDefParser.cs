// $ANTLR 3.2 Sep 23, 2009 12:02:23 TimeDef.g 2011-06-15 15:24:05

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
    // TimeDef.g:46:1: atom returns [ISchedule value] : ( once_p | every_p | cron_p | void_p | paren_p );
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
            // TimeDef.g:46:31: ( once_p | every_p | cron_p | void_p | paren_p )
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
                    // TimeDef.g:50:4: void_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_void_p_in_atom129);
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
                    // TimeDef.g:51:4: paren_p
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_paren_p_in_atom138);
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
    // TimeDef.g:57:1: once_p returns [OneTimeSchedule value] : (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) ;
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
            // TimeDef.g:57:39: ( (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:57:41: (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:57:41: (start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:58:4: start= datetime_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		PushFollow(FOLLOW_datetime_p_in_once_p162);
            		start = datetime_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, start.Tree);
            		// TimeDef.g:58:21: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            		int alt4 = 2;
            		alt4 = dfa4.Predict(input);
            		switch (alt4) 
            		{
            		    case 1 :
            		        // TimeDef.g:58:22: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
            		        {
            		        	// TimeDef.g:58:22: ( WS )+
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
            		        			    	WS8=(IToken)Match(input,WS,FOLLOW_WS_in_once_p165); if (state.failed) return retval;
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

            		        	string_literal9=(IToken)Match(input,7,FOLLOW_7_in_once_p168); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal9_tree = (object)adaptor.Create(string_literal9);
            		        		adaptor.AddChild(root_0, string_literal9_tree);
            		        	}
            		        	// TimeDef.g:58:36: ( WS )+
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
            		        			    	WS10=(IToken)Match(input,WS,FOLLOW_WS_in_once_p170); if (state.failed) return retval;
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

            		        	PushFollow(FOLLOW_timespan_p_in_once_p175);
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
    // TimeDef.g:61:1: every_p returns [IntervalSchedule value] : ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) ;
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
            // TimeDef.g:61:41: ( ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:61:43: ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:61:43: ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:62:4: 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		string_literal11=(IToken)Match(input,8,FOLLOW_8_in_every_p197); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{string_literal11_tree = (object)adaptor.Create(string_literal11);
            			adaptor.AddChild(root_0, string_literal11_tree);
            		}
            		// TimeDef.g:62:12: ( WS )+
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
            				    	WS12=(IToken)Match(input,WS,FOLLOW_WS_in_every_p199); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_timespan_p_in_every_p204);
            		interval = timespan_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, interval.Tree);
            		// TimeDef.g:62:36: ( ( WS )+ 'since' ( WS )+ sync= datetime_p )?
            		int alt8 = 2;
            		alt8 = dfa8.Predict(input);
            		switch (alt8) 
            		{
            		    case 1 :
            		        // TimeDef.g:62:37: ( WS )+ 'since' ( WS )+ sync= datetime_p
            		        {
            		        	// TimeDef.g:62:37: ( WS )+
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
            		        			    	WS13=(IToken)Match(input,WS,FOLLOW_WS_in_every_p207); if (state.failed) return retval;
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

            		        	string_literal14=(IToken)Match(input,9,FOLLOW_9_in_every_p210); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal14_tree = (object)adaptor.Create(string_literal14);
            		        		adaptor.AddChild(root_0, string_literal14_tree);
            		        	}
            		        	// TimeDef.g:62:49: ( WS )+
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
            		        			    	WS15=(IToken)Match(input,WS,FOLLOW_WS_in_every_p212); if (state.failed) return retval;
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

            		        	PushFollow(FOLLOW_datetime_p_in_every_p217);
            		        	sync = datetime_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sync.Tree);

            		        }
            		        break;

            		}

            		// TimeDef.g:62:71: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            		int alt11 = 2;
            		alt11 = dfa11.Predict(input);
            		switch (alt11) 
            		{
            		    case 1 :
            		        // TimeDef.g:62:72: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
            		        {
            		        	// TimeDef.g:62:72: ( WS )+
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
            		        			    	WS16=(IToken)Match(input,WS,FOLLOW_WS_in_every_p222); if (state.failed) return retval;
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

            		        	string_literal17=(IToken)Match(input,7,FOLLOW_7_in_every_p225); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal17_tree = (object)adaptor.Create(string_literal17);
            		        		adaptor.AddChild(root_0, string_literal17_tree);
            		        	}
            		        	// TimeDef.g:62:86: ( WS )+
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
            		        			    	WS18=(IToken)Match(input,WS,FOLLOW_WS_in_every_p227); if (state.failed) return retval;
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

            		        	PushFollow(FOLLOW_timespan_p_in_every_p232);
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
    // TimeDef.g:65:1: cron_p returns [CronSchedule value] : ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) ;
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
            // TimeDef.g:65:36: ( ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:65:38: ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:65:38: ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:66:4: 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		string_literal19=(IToken)Match(input,10,FOLLOW_10_in_cron_p254); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{string_literal19_tree = (object)adaptor.Create(string_literal19);
            			adaptor.AddChild(root_0, string_literal19_tree);
            		}
            		// TimeDef.g:66:11: ( WS )+
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
            				    	WS20=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p256); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p264);
            		minute = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, minute.Tree);
            		// TimeDef.g:67:24: ( WS )+
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
            				    	WS21=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p266); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p274);
            		hour = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, hour.Tree);
            		// TimeDef.g:68:22: ( WS )+
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
            				    	WS22=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p276); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p284);
            		day = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, day.Tree);
            		// TimeDef.g:69:21: ( WS )+
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
            				    	WS23=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p286); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p294);
            		month = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, month.Tree);
            		// TimeDef.g:70:23: ( WS )+
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
            				    	WS24=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p296); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_dow_cron_field_p_in_cron_p304);
            		dow = dow_cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dow.Tree);
            		// TimeDef.g:72:4: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            		int alt19 = 2;
            		alt19 = dfa19.Predict(input);
            		switch (alt19) 
            		{
            		    case 1 :
            		        // TimeDef.g:72:5: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
            		        {
            		        	// TimeDef.g:72:5: ( WS )+
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
            		        			    	WS25=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p310); if (state.failed) return retval;
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

            		        	string_literal26=(IToken)Match(input,7,FOLLOW_7_in_cron_p313); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal26_tree = (object)adaptor.Create(string_literal26);
            		        		adaptor.AddChild(root_0, string_literal26_tree);
            		        	}
            		        	// TimeDef.g:72:19: ( WS )+
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
            		        			    	WS27=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p315); if (state.failed) return retval;
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

            		        	PushFollow(FOLLOW_timespan_p_in_cron_p320);
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
    // TimeDef.g:75:1: void_p returns [VoidSchedule value] : 'void' ;
    public TimeDefParser.void_p_return void_p() // throws RecognitionException [1]
    {   
        TimeDefParser.void_p_return retval = new TimeDefParser.void_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal28 = null;

        object string_literal28_tree=null;

        try 
    	{
            // TimeDef.g:75:36: ( 'void' )
            // TimeDef.g:76:4: 'void'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal28=(IToken)Match(input,11,FOLLOW_11_in_void_p340); if (state.failed) return retval;
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
    // TimeDef.g:78:1: paren_p returns [ISchedule value] : ( '(' expr ')' ) ;
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
            // TimeDef.g:78:34: ( ( '(' expr ')' ) )
            // TimeDef.g:78:36: ( '(' expr ')' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:78:36: ( '(' expr ')' )
            	// TimeDef.g:79:4: '(' expr ')'
            	{
            		char_literal29=(IToken)Match(input,12,FOLLOW_12_in_paren_p358); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal29_tree = (object)adaptor.Create(char_literal29);
            			adaptor.AddChild(root_0, char_literal29_tree);
            		}
            		PushFollow(FOLLOW_expr_in_paren_p360);
            		expr30 = expr();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr30.Tree);
            		char_literal31=(IToken)Match(input,13,FOLLOW_13_in_paren_p362); if (state.failed) return retval;
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
    // TimeDef.g:86:1: filter_p returns [ISchedule value] : A= atom ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )* ;
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
            // TimeDef.g:86:35: (A= atom ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )* )
            // TimeDef.g:87:4: A= atom ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_filter_p386);
            	A = atom();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:87:34: ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*
            	do 
            	{
            	    int alt28 = 5;
            	    alt28 = dfa28.Predict(input);
            	    switch (alt28) 
            		{
            			case 1 :
            			    // TimeDef.g:88:7: ( ( WS )* '#' ( WS )* index_intspec= intspec_p )
            			    {
            			    	// TimeDef.g:88:7: ( ( WS )* '#' ( WS )* index_intspec= intspec_p )
            			    	// TimeDef.g:88:8: ( WS )* '#' ( WS )* index_intspec= intspec_p
            			    	{
            			    		// TimeDef.g:88:8: ( WS )*
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
            			    				    	WS32=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p399); if (state.failed) return retval;
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

            			    		char_literal33=(IToken)Match(input,14,FOLLOW_14_in_filter_p402); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal33_tree = (object)adaptor.Create(char_literal33);
            			    			adaptor.AddChild(root_0, char_literal33_tree);
            			    		}
            			    		// TimeDef.g:88:16: ( WS )*
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
            			    				    	WS34=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p404); if (state.failed) return retval;
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

            			    		PushFollow(FOLLOW_intspec_p_in_filter_p409);
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
            			    // TimeDef.g:89:7: ( ( WS )* 'x' ( WS )* repeatcount= UINT )
            			    {
            			    	// TimeDef.g:89:7: ( ( WS )* 'x' ( WS )* repeatcount= UINT )
            			    	// TimeDef.g:89:8: ( WS )* 'x' ( WS )* repeatcount= UINT
            			    	{
            			    		// TimeDef.g:89:8: ( WS )*
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
            			    				    	WS35=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p424); if (state.failed) return retval;
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

            			    		char_literal36=(IToken)Match(input,15,FOLLOW_15_in_filter_p427); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal36_tree = (object)adaptor.Create(char_literal36);
            			    			adaptor.AddChild(root_0, char_literal36_tree);
            			    		}
            			    		// TimeDef.g:89:16: ( WS )*
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
            			    				    	WS37=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p429); if (state.failed) return retval;
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

            			    		repeatcount=(IToken)Match(input,UINT,FOLLOW_UINT_in_filter_p434); if (state.failed) return retval;
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
            			    // TimeDef.g:90:7: ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p )
            			    {
            			    	// TimeDef.g:90:7: ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p )
            			    	// TimeDef.g:90:8: ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p
            			    	{
            			    		// TimeDef.g:90:8: ( WS )*
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
            			    				    	WS38=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p449); if (state.failed) return retval;
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

            			    		// TimeDef.g:90:25: ( WS )*
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
            			    				    	WS39=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p460); if (state.failed) return retval;
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

            			    		PushFollow(FOLLOW_timespan_p_in_filter_p465);
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
            			    // TimeDef.g:91:7: ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p )
            			    {
            			    	// TimeDef.g:91:7: ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p )
            			    	// TimeDef.g:91:8: ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p
            			    	{
            			    		// TimeDef.g:91:8: ( WS )+
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
            			    				    	WS40=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p480); if (state.failed) return retval;
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

            			    		string_literal41=(IToken)Match(input,7,FOLLOW_7_in_filter_p483); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{string_literal41_tree = (object)adaptor.Create(string_literal41);
            			    			adaptor.AddChild(root_0, string_literal41_tree);
            			    		}
            			    		// TimeDef.g:91:22: ( WS )+
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
            			    				    	WS42=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p485); if (state.failed) return retval;
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

            			    		PushFollow(FOLLOW_timespan_p_in_filter_p490);
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
    // TimeDef.g:96:1: expr returns [ISchedule value] : ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* ) ;
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
            // TimeDef.g:100:1: ( ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* ) )
            // TimeDef.g:100:3: ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:100:3: ( ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )* )
            	// TimeDef.g:101:4: ( WS )* A= boolnonintersection_p ( ( WS )* ',' ( WS )* B= boolnonintersection_p )* ( WS )*
            	{
            		// TimeDef.g:101:4: ( WS )*
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
            				    	WS43=(IToken)Match(input,WS,FOLLOW_WS_in_expr524); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_boolnonintersection_p_in_expr529);
            		A = boolnonintersection_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:102:4: ( ( WS )* ',' ( WS )* B= boolnonintersection_p )*
            		do 
            		{
            		    int alt32 = 2;
            		    alt32 = dfa32.Predict(input);
            		    switch (alt32) 
            			{
            				case 1 :
            				    // TimeDef.g:102:5: ( WS )* ',' ( WS )* B= boolnonintersection_p
            				    {
            				    	// TimeDef.g:102:5: ( WS )*
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
            				    			    	WS44=(IToken)Match(input,WS,FOLLOW_WS_in_expr537); if (state.failed) return retval;
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

            				    	char_literal45=(IToken)Match(input,18,FOLLOW_18_in_expr540); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{char_literal45_tree = (object)adaptor.Create(char_literal45);
            				    		adaptor.AddChild(root_0, char_literal45_tree);
            				    	}
            				    	// TimeDef.g:102:13: ( WS )*
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
            				    			    	WS46=(IToken)Match(input,WS,FOLLOW_WS_in_expr542); if (state.failed) return retval;
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

            				    	PushFollow(FOLLOW_boolnonintersection_p_in_expr547);
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

            		// TimeDef.g:102:73: ( WS )*
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
            				    	WS47=(IToken)Match(input,WS,FOLLOW_WS_in_expr554); if (state.failed) return retval;
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
    // TimeDef.g:108:1: boolnonintersection_p returns [ISchedule value] : A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )* ;
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
            // TimeDef.g:108:48: (A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )* )
            // TimeDef.g:109:4: A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_boolintersection_p_in_boolnonintersection_p578);
            	A = boolintersection_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:110:4: ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*
            	do 
            	{
            	    int alt36 = 2;
            	    alt36 = dfa36.Predict(input);
            	    switch (alt36) 
            		{
            			case 1 :
            			    // TimeDef.g:110:5: ( WS )* '!&&' ( WS )* B= boolintersection_p
            			    {
            			    	// TimeDef.g:110:5: ( WS )*
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
            			    			    	WS48=(IToken)Match(input,WS,FOLLOW_WS_in_boolnonintersection_p586); if (state.failed) return retval;
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

            			    	string_literal49=(IToken)Match(input,19,FOLLOW_19_in_boolnonintersection_p589); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal49_tree = (object)adaptor.Create(string_literal49);
            			    		adaptor.AddChild(root_0, string_literal49_tree);
            			    	}
            			    	// TimeDef.g:110:15: ( WS )*
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
            			    			    	WS50=(IToken)Match(input,WS,FOLLOW_WS_in_boolnonintersection_p591); if (state.failed) return retval;
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

            			    	PushFollow(FOLLOW_boolintersection_p_in_boolnonintersection_p596);
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
    // TimeDef.g:116:1: boolintersection_p returns [ISchedule value] : A= union_p ( ( WS )* '&&' ( WS )* B= union_p )* ;
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
            // TimeDef.g:116:45: (A= union_p ( ( WS )* '&&' ( WS )* B= union_p )* )
            // TimeDef.g:117:4: A= union_p ( ( WS )* '&&' ( WS )* B= union_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_union_p_in_boolintersection_p621);
            	A = union_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:118:4: ( ( WS )* '&&' ( WS )* B= union_p )*
            	do 
            	{
            	    int alt39 = 2;
            	    alt39 = dfa39.Predict(input);
            	    switch (alt39) 
            		{
            			case 1 :
            			    // TimeDef.g:118:5: ( WS )* '&&' ( WS )* B= union_p
            			    {
            			    	// TimeDef.g:118:5: ( WS )*
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
            			    			    	WS51=(IToken)Match(input,WS,FOLLOW_WS_in_boolintersection_p629); if (state.failed) return retval;
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

            			    	string_literal52=(IToken)Match(input,20,FOLLOW_20_in_boolintersection_p632); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal52_tree = (object)adaptor.Create(string_literal52);
            			    		adaptor.AddChild(root_0, string_literal52_tree);
            			    	}
            			    	// TimeDef.g:118:14: ( WS )*
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
            			    			    	WS53=(IToken)Match(input,WS,FOLLOW_WS_in_boolintersection_p634); if (state.failed) return retval;
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

            			    	PushFollow(FOLLOW_union_p_in_boolintersection_p639);
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
    // TimeDef.g:124:1: union_p returns [ISchedule value] : (A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )* ) ;
    public TimeDefParser.union_p_return union_p() // throws RecognitionException [1]
    {   
        TimeDefParser.union_p_return retval = new TimeDefParser.union_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS54 = null;
        IToken char_literal55 = null;
        IToken WS56 = null;
        TimeDefParser.difference_p_return A = default(TimeDefParser.difference_p_return);

        TimeDefParser.difference_p_return B = default(TimeDefParser.difference_p_return);


        object WS54_tree=null;
        object char_literal55_tree=null;
        object WS56_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:128:1: ( (A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )* ) )
            // TimeDef.g:128:3: (A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:128:3: (A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )* )
            	// TimeDef.g:129:4: A= difference_p ( ( WS )* '|' ( WS )* B= difference_p )*
            	{
            		PushFollow(FOLLOW_difference_p_in_union_p672);
            		A = difference_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:130:4: ( ( WS )* '|' ( WS )* B= difference_p )*
            		do 
            		{
            		    int alt42 = 2;
            		    alt42 = dfa42.Predict(input);
            		    switch (alt42) 
            			{
            				case 1 :
            				    // TimeDef.g:130:5: ( WS )* '|' ( WS )* B= difference_p
            				    {
            				    	// TimeDef.g:130:5: ( WS )*
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
            				    			    	WS54=(IToken)Match(input,WS,FOLLOW_WS_in_union_p680); if (state.failed) return retval;
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

            				    	char_literal55=(IToken)Match(input,21,FOLLOW_21_in_union_p683); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{char_literal55_tree = (object)adaptor.Create(char_literal55);
            				    		adaptor.AddChild(root_0, char_literal55_tree);
            				    	}
            				    	// TimeDef.g:130:13: ( WS )*
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
            				    			    	WS56=(IToken)Match(input,WS,FOLLOW_WS_in_union_p685); if (state.failed) return retval;
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

            				    	PushFollow(FOLLOW_difference_p_in_union_p690);
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
    // TimeDef.g:136:1: difference_p returns [ISchedule value] : (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* ) ;
    public TimeDefParser.difference_p_return difference_p() // throws RecognitionException [1]
    {   
        TimeDefParser.difference_p_return retval = new TimeDefParser.difference_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS57 = null;
        IToken string_literal58 = null;
        IToken WS59 = null;
        TimeDefParser.intersection_p_return A = default(TimeDefParser.intersection_p_return);

        TimeDefParser.intersection_p_return B = default(TimeDefParser.intersection_p_return);


        object WS57_tree=null;
        object string_literal58_tree=null;
        object WS59_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:140:1: ( (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* ) )
            // TimeDef.g:140:3: (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:140:3: (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* )
            	// TimeDef.g:141:4: A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )*
            	{
            		PushFollow(FOLLOW_intersection_p_in_difference_p726);
            		A = intersection_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:142:4: ( ( WS )* '!&' ( WS )* B= intersection_p )*
            		do 
            		{
            		    int alt45 = 2;
            		    alt45 = dfa45.Predict(input);
            		    switch (alt45) 
            			{
            				case 1 :
            				    // TimeDef.g:142:5: ( WS )* '!&' ( WS )* B= intersection_p
            				    {
            				    	// TimeDef.g:142:5: ( WS )*
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
            				    			    	WS57=(IToken)Match(input,WS,FOLLOW_WS_in_difference_p734); if (state.failed) return retval;
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

            				    	string_literal58=(IToken)Match(input,22,FOLLOW_22_in_difference_p737); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{string_literal58_tree = (object)adaptor.Create(string_literal58);
            				    		adaptor.AddChild(root_0, string_literal58_tree);
            				    	}
            				    	// TimeDef.g:142:14: ( WS )*
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
            				    			    	WS59=(IToken)Match(input,WS,FOLLOW_WS_in_difference_p739); if (state.failed) return retval;
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

            				    	PushFollow(FOLLOW_intersection_p_in_difference_p744);
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
            				    goto loop45;
            		    }
            		} while (true);

            		loop45:
            			;	// Stops C# compiler whining that label 'loop45' has no statements


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
    // TimeDef.g:149:1: intersection_p returns [ISchedule value] : A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )* ;
    public TimeDefParser.intersection_p_return intersection_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intersection_p_return retval = new TimeDefParser.intersection_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS60 = null;
        IToken char_literal61 = null;
        IToken WS62 = null;
        TimeDefParser.filter_p_return A = default(TimeDefParser.filter_p_return);

        TimeDefParser.filter_p_return B = default(TimeDefParser.filter_p_return);


        object WS60_tree=null;
        object char_literal61_tree=null;
        object WS62_tree=null;

        try 
    	{
            // TimeDef.g:149:41: (A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )* )
            // TimeDef.g:150:4: A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_filter_p_in_intersection_p773);
            	A = filter_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:151:4: ( ( WS )* '&' ( WS )* B= filter_p )*
            	do 
            	{
            	    int alt48 = 2;
            	    alt48 = dfa48.Predict(input);
            	    switch (alt48) 
            		{
            			case 1 :
            			    // TimeDef.g:151:5: ( WS )* '&' ( WS )* B= filter_p
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
            			    			    	WS60=(IToken)Match(input,WS,FOLLOW_WS_in_intersection_p781); if (state.failed) return retval;
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

            			    	char_literal61=(IToken)Match(input,23,FOLLOW_23_in_intersection_p784); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal61_tree = (object)adaptor.Create(char_literal61);
            			    		adaptor.AddChild(root_0, char_literal61_tree);
            			    	}
            			    	// TimeDef.g:151:13: ( WS )*
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
            			    			    	WS62=(IToken)Match(input,WS,FOLLOW_WS_in_intersection_p786); if (state.failed) return retval;
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

            			    	PushFollow(FOLLOW_filter_p_in_intersection_p791);
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
            			    goto loop48;
            	    }
            	} while (true);

            	loop48:
            		;	// Stops C# compiler whining that label 'loop48' has no statements


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
    // TimeDef.g:157:1: datetime_p returns [DateTime value] : (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? ) ;
    public TimeDefParser.datetime_p_return datetime_p() // throws RecognitionException [1]
    {   
        TimeDefParser.datetime_p_return retval = new TimeDefParser.datetime_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal63 = null;
        IToken char_literal64 = null;
        IToken WS65 = null;
        IToken char_literal66 = null;
        IToken char_literal67 = null;
        IToken char_literal68 = null;
        IToken char_literal69 = null;
        IToken char_literal70 = null;
        IToken char_literal71 = null;
        TimeDefParser.year_p_return y = default(TimeDefParser.year_p_return);

        TimeDefParser.month_p_return mo = default(TimeDefParser.month_p_return);

        TimeDefParser.day_p_return d = default(TimeDefParser.day_p_return);

        TimeDefParser.hour24_p_return h = default(TimeDefParser.hour24_p_return);

        TimeDefParser.minute60_p_return m = default(TimeDefParser.minute60_p_return);

        TimeDefParser.second60_p_return s = default(TimeDefParser.second60_p_return);

        TimeDefParser.millisecond1000_p_return ms = default(TimeDefParser.millisecond1000_p_return);


        object char_literal63_tree=null;
        object char_literal64_tree=null;
        object WS65_tree=null;
        object char_literal66_tree=null;
        object char_literal67_tree=null;
        object char_literal68_tree=null;
        object char_literal69_tree=null;
        object char_literal70_tree=null;
        object char_literal71_tree=null;

        try 
    	{
            // TimeDef.g:157:36: ( (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? ) )
            // TimeDef.g:157:38: (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:157:38: (y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )
            	int alt55 = 2;
            	int LA55_0 = input.LA(1);

            	if ( (LA55_0 == UINT) )
            	{
            	    int LA55_1 = input.LA(2);

            	    if ( (LA55_1 == 24) )
            	    {
            	        alt55 = 2;
            	    }
            	    else if ( (LA55_1 == 17) )
            	    {
            	        alt55 = 1;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d55s1 =
            	            new NoViableAltException("", 55, 1, input);

            	        throw nvae_d55s1;
            	    }
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d55s0 =
            	        new NoViableAltException("", 55, 0, input);

            	    throw nvae_d55s0;
            	}
            	switch (alt55) 
            	{
            	    case 1 :
            	        // TimeDef.g:158:4: y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?
            	        {
            	        	PushFollow(FOLLOW_year_p_in_datetime_p818);
            	        	y = year_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, y.Tree);
            	        	char_literal63=(IToken)Match(input,17,FOLLOW_17_in_datetime_p820); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal63_tree = (object)adaptor.Create(char_literal63);
            	        		adaptor.AddChild(root_0, char_literal63_tree);
            	        	}
            	        	PushFollow(FOLLOW_month_p_in_datetime_p824);
            	        	mo = month_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mo.Tree);
            	        	char_literal64=(IToken)Match(input,17,FOLLOW_17_in_datetime_p826); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal64_tree = (object)adaptor.Create(char_literal64);
            	        		adaptor.AddChild(root_0, char_literal64_tree);
            	        	}
            	        	PushFollow(FOLLOW_day_p_in_datetime_p830);
            	        	d = day_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, d.Tree);
            	        	// TimeDef.g:158:40: ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?
            	        	int alt52 = 2;
            	        	alt52 = dfa52.Predict(input);
            	        	switch (alt52) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:158:41: ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	        {
            	        	        	// TimeDef.g:158:41: ( WS )+
            	        	        	int cnt49 = 0;
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
            	        	        			    	WS65=(IToken)Match(input,WS,FOLLOW_WS_in_datetime_p833); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{WS65_tree = (object)adaptor.Create(WS65);
            	        	        			    		adaptor.AddChild(root_0, WS65_tree);
            	        	        			    	}

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    if ( cnt49 >= 1 ) goto loop49;
            	        	        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	        		            EarlyExitException eee49 =
            	        	        		                new EarlyExitException(49, input);
            	        	        		            throw eee49;
            	        	        	    }
            	        	        	    cnt49++;
            	        	        	} while (true);

            	        	        	loop49:
            	        	        		;	// Stops C# compiler whining that label 'loop49' has no statements

            	        	        	PushFollow(FOLLOW_hour24_p_in_datetime_p838);
            	        	        	h = hour24_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            	        	        	char_literal66=(IToken)Match(input,24,FOLLOW_24_in_datetime_p840); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal66_tree = (object)adaptor.Create(char_literal66);
            	        	        		adaptor.AddChild(root_0, char_literal66_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_minute60_p_in_datetime_p844);
            	        	        	m = minute60_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            	        	        	// TimeDef.g:158:73: ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	        	int alt51 = 2;
            	        	        	int LA51_0 = input.LA(1);

            	        	        	if ( (LA51_0 == 24) )
            	        	        	{
            	        	        	    alt51 = 1;
            	        	        	}
            	        	        	switch (alt51) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // TimeDef.g:158:74: ':' s= second60_p ( '.' ms= millisecond1000_p )?
            	        	        	        {
            	        	        	        	char_literal67=(IToken)Match(input,24,FOLLOW_24_in_datetime_p847); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{char_literal67_tree = (object)adaptor.Create(char_literal67);
            	        	        	        		adaptor.AddChild(root_0, char_literal67_tree);
            	        	        	        	}
            	        	        	        	PushFollow(FOLLOW_second60_p_in_datetime_p851);
            	        	        	        	s = second60_p();
            	        	        	        	state.followingStackPointer--;
            	        	        	        	if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            	        	        	        	// TimeDef.g:158:91: ( '.' ms= millisecond1000_p )?
            	        	        	        	int alt50 = 2;
            	        	        	        	int LA50_0 = input.LA(1);

            	        	        	        	if ( (LA50_0 == 25) )
            	        	        	        	{
            	        	        	        	    alt50 = 1;
            	        	        	        	}
            	        	        	        	switch (alt50) 
            	        	        	        	{
            	        	        	        	    case 1 :
            	        	        	        	        // TimeDef.g:158:92: '.' ms= millisecond1000_p
            	        	        	        	        {
            	        	        	        	        	char_literal68=(IToken)Match(input,25,FOLLOW_25_in_datetime_p854); if (state.failed) return retval;
            	        	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	        	{char_literal68_tree = (object)adaptor.Create(char_literal68);
            	        	        	        	        		adaptor.AddChild(root_0, char_literal68_tree);
            	        	        	        	        	}
            	        	        	        	        	PushFollow(FOLLOW_millisecond1000_p_in_datetime_p858);
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
            	        // TimeDef.g:159:4: h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        {
            	        	PushFollow(FOLLOW_hour24_p_in_datetime_p873);
            	        	h = hour24_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            	        	char_literal69=(IToken)Match(input,24,FOLLOW_24_in_datetime_p875); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal69_tree = (object)adaptor.Create(char_literal69);
            	        		adaptor.AddChild(root_0, char_literal69_tree);
            	        	}
            	        	PushFollow(FOLLOW_minute60_p_in_datetime_p879);
            	        	m = minute60_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            	        	// TimeDef.g:159:32: ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	int alt54 = 2;
            	        	int LA54_0 = input.LA(1);

            	        	if ( (LA54_0 == 24) )
            	        	{
            	        	    alt54 = 1;
            	        	}
            	        	switch (alt54) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:159:33: ':' s= second60_p ( '.' ms= millisecond1000_p )?
            	        	        {
            	        	        	char_literal70=(IToken)Match(input,24,FOLLOW_24_in_datetime_p882); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal70_tree = (object)adaptor.Create(char_literal70);
            	        	        		adaptor.AddChild(root_0, char_literal70_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_second60_p_in_datetime_p886);
            	        	        	s = second60_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            	        	        	// TimeDef.g:159:50: ( '.' ms= millisecond1000_p )?
            	        	        	int alt53 = 2;
            	        	        	int LA53_0 = input.LA(1);

            	        	        	if ( (LA53_0 == 25) )
            	        	        	{
            	        	        	    alt53 = 1;
            	        	        	}
            	        	        	switch (alt53) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // TimeDef.g:159:51: '.' ms= millisecond1000_p
            	        	        	        {
            	        	        	        	char_literal71=(IToken)Match(input,25,FOLLOW_25_in_datetime_p889); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{char_literal71_tree = (object)adaptor.Create(char_literal71);
            	        	        	        		adaptor.AddChild(root_0, char_literal71_tree);
            	        	        	        	}
            	        	        	        	PushFollow(FOLLOW_millisecond1000_p_in_datetime_p893);
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
    // TimeDef.g:171:1: datetime_prog returns [DateTime value] : ( datetime_p EOF ) ;
    public TimeDefParser.datetime_prog_return datetime_prog() // throws RecognitionException [1]
    {   
        TimeDefParser.datetime_prog_return retval = new TimeDefParser.datetime_prog_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF73 = null;
        TimeDefParser.datetime_p_return datetime_p72 = default(TimeDefParser.datetime_p_return);


        object EOF73_tree=null;

        try 
    	{
            // TimeDef.g:171:39: ( ( datetime_p EOF ) )
            // TimeDef.g:171:41: ( datetime_p EOF )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:171:41: ( datetime_p EOF )
            	// TimeDef.g:172:4: datetime_p EOF
            	{
            		PushFollow(FOLLOW_datetime_p_in_datetime_prog917);
            		datetime_p72 = datetime_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, datetime_p72.Tree);
            		EOF73=(IToken)Match(input,EOF,FOLLOW_EOF_in_datetime_prog919); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{EOF73_tree = (object)adaptor.Create(EOF73);
            			adaptor.AddChild(root_0, EOF73_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((datetime_p72 != null) ? datetime_p72.value : default(DateTime)); 
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
    // TimeDef.g:175:1: year_p returns [int value] : UINT ;
    public TimeDefParser.year_p_return year_p() // throws RecognitionException [1]
    {   
        TimeDefParser.year_p_return retval = new TimeDefParser.year_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT74 = null;

        object UINT74_tree=null;

        try 
    	{
            // TimeDef.g:175:27: ( UINT )
            // TimeDef.g:175:29: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT74=(IToken)Match(input,UINT,FOLLOW_UINT_in_year_p934); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT74_tree = (object)adaptor.Create(UINT74);
            		adaptor.AddChild(root_0, UINT74_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT74 != null) ? UINT74.Text : null)); 
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
    // TimeDef.g:176:1: month_p returns [int value] : UINT ;
    public TimeDefParser.month_p_return month_p() // throws RecognitionException [1]
    {   
        TimeDefParser.month_p_return retval = new TimeDefParser.month_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT75 = null;

        object UINT75_tree=null;

        try 
    	{
            // TimeDef.g:176:28: ( UINT )
            // TimeDef.g:176:30: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT75=(IToken)Match(input,UINT,FOLLOW_UINT_in_month_p946); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT75_tree = (object)adaptor.Create(UINT75);
            		adaptor.AddChild(root_0, UINT75_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT75 != null) ? UINT75.Text : null)); 
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
    // TimeDef.g:177:1: day_p returns [int value] : UINT ;
    public TimeDefParser.day_p_return day_p() // throws RecognitionException [1]
    {   
        TimeDefParser.day_p_return retval = new TimeDefParser.day_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT76 = null;

        object UINT76_tree=null;

        try 
    	{
            // TimeDef.g:177:26: ( UINT )
            // TimeDef.g:177:28: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT76=(IToken)Match(input,UINT,FOLLOW_UINT_in_day_p958); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT76_tree = (object)adaptor.Create(UINT76);
            		adaptor.AddChild(root_0, UINT76_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((UINT76 != null) ? UINT76.Text : null)); 
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
    // TimeDef.g:178:1: hour24_p returns [int value] : UINT ;
    public TimeDefParser.hour24_p_return hour24_p() // throws RecognitionException [1]
    {   
        TimeDefParser.hour24_p_return retval = new TimeDefParser.hour24_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT77 = null;

        object UINT77_tree=null;

        try 
    	{
            // TimeDef.g:178:29: ( UINT )
            // TimeDef.g:178:31: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT77=(IToken)Match(input,UINT,FOLLOW_UINT_in_hour24_p970); if (state.failed) return retval;
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
    // TimeDef.g:179:1: minute60_p returns [int value] : UINT ;
    public TimeDefParser.minute60_p_return minute60_p() // throws RecognitionException [1]
    {   
        TimeDefParser.minute60_p_return retval = new TimeDefParser.minute60_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT78 = null;

        object UINT78_tree=null;

        try 
    	{
            // TimeDef.g:179:31: ( UINT )
            // TimeDef.g:179:33: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT78=(IToken)Match(input,UINT,FOLLOW_UINT_in_minute60_p982); if (state.failed) return retval;
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
    // TimeDef.g:180:1: second60_p returns [int value] : UINT ;
    public TimeDefParser.second60_p_return second60_p() // throws RecognitionException [1]
    {   
        TimeDefParser.second60_p_return retval = new TimeDefParser.second60_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT79 = null;

        object UINT79_tree=null;

        try 
    	{
            // TimeDef.g:180:31: ( UINT )
            // TimeDef.g:180:33: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT79=(IToken)Match(input,UINT,FOLLOW_UINT_in_second60_p994); if (state.failed) return retval;
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
    // TimeDef.g:181:1: millisecond1000_p returns [int value] : UINT ;
    public TimeDefParser.millisecond1000_p_return millisecond1000_p() // throws RecognitionException [1]
    {   
        TimeDefParser.millisecond1000_p_return retval = new TimeDefParser.millisecond1000_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT80 = null;

        object UINT80_tree=null;

        try 
    	{
            // TimeDef.g:181:38: ( UINT )
            // TimeDef.g:181:40: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT80=(IToken)Match(input,UINT,FOLLOW_UINT_in_millisecond1000_p1006); if (state.failed) return retval;
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
    // TimeDef.g:183:1: timespan_p returns [TimeSpan value] : ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? ) ;
    public TimeDefParser.timespan_p_return timespan_p() // throws RecognitionException [1]
    {   
        TimeDefParser.timespan_p_return retval = new TimeDefParser.timespan_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal81 = null;
        IToken char_literal82 = null;
        IToken char_literal83 = null;
        IToken char_literal84 = null;
        IToken char_literal85 = null;
        TimeDefParser.days_p_return d = default(TimeDefParser.days_p_return);

        TimeDefParser.hours_p_return h = default(TimeDefParser.hours_p_return);

        TimeDefParser.minutes_p_return m = default(TimeDefParser.minutes_p_return);

        TimeDefParser.seconds_p_return s = default(TimeDefParser.seconds_p_return);

        TimeDefParser.milliseconds_p_return ms = default(TimeDefParser.milliseconds_p_return);


        object char_literal81_tree=null;
        object char_literal82_tree=null;
        object char_literal83_tree=null;
        object char_literal84_tree=null;
        object char_literal85_tree=null;

        try 
    	{
            // TimeDef.g:183:36: ( ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? ) )
            // TimeDef.g:183:38: ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:183:38: ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? )
            	// TimeDef.g:184:4: 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )?
            	{
            		char_literal81=(IToken)Match(input,26,FOLLOW_26_in_timespan_p1024); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal81_tree = (object)adaptor.Create(char_literal81);
            			adaptor.AddChild(root_0, char_literal81_tree);
            		}
            		// TimeDef.g:184:8: ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )?
            		int alt58 = 2;
            		int LA58_0 = input.LA(1);

            		if ( (LA58_0 == 17) )
            		{
            		    int LA58_1 = input.LA(2);

            		    if ( (LA58_1 == UINT) )
            		    {
            		        int LA58_2 = input.LA(3);

            		        if ( (LA58_2 == 24) )
            		        {
            		            alt58 = 1;
            		        }
            		        else if ( (LA58_2 == 25) )
            		        {
            		            int LA58_4 = input.LA(4);

            		            if ( (LA58_4 == 17) )
            		            {
            		                int LA58_6 = input.LA(5);

            		                if ( (LA58_6 == UINT) )
            		                {
            		                    int LA58_7 = input.LA(6);

            		                    if ( (LA58_7 == 24) )
            		                    {
            		                        alt58 = 1;
            		                    }
            		                }
            		            }
            		            else if ( (LA58_4 == UINT) )
            		            {
            		                int LA58_7 = input.LA(5);

            		                if ( (LA58_7 == 24) )
            		                {
            		                    alt58 = 1;
            		                }
            		            }
            		        }
            		    }
            		}
            		else if ( (LA58_0 == UINT) )
            		{
            		    int LA58_2 = input.LA(2);

            		    if ( (LA58_2 == 24) )
            		    {
            		        alt58 = 1;
            		    }
            		    else if ( (LA58_2 == 25) )
            		    {
            		        int LA58_4 = input.LA(3);

            		        if ( (LA58_4 == 17) )
            		        {
            		            int LA58_6 = input.LA(4);

            		            if ( (LA58_6 == UINT) )
            		            {
            		                int LA58_7 = input.LA(5);

            		                if ( (LA58_7 == 24) )
            		                {
            		                    alt58 = 1;
            		                }
            		            }
            		        }
            		        else if ( (LA58_4 == UINT) )
            		        {
            		            int LA58_7 = input.LA(4);

            		            if ( (LA58_7 == 24) )
            		            {
            		                alt58 = 1;
            		            }
            		        }
            		    }
            		}
            		switch (alt58) 
            		{
            		    case 1 :
            		        // TimeDef.g:184:9: ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':'
            		        {
            		        	// TimeDef.g:184:9: ( (d= days_p '.' )? h= hours_p ':' )?
            		        	int alt57 = 2;
            		        	int LA57_0 = input.LA(1);

            		        	if ( (LA57_0 == 17) )
            		        	{
            		        	    int LA57_1 = input.LA(2);

            		        	    if ( (LA57_1 == UINT) )
            		        	    {
            		        	        int LA57_2 = input.LA(3);

            		        	        if ( (LA57_2 == 24) )
            		        	        {
            		        	            int LA57_3 = input.LA(4);

            		        	            if ( (LA57_3 == 17) )
            		        	            {
            		        	                int LA57_5 = input.LA(5);

            		        	                if ( (LA57_5 == UINT) )
            		        	                {
            		        	                    int LA57_6 = input.LA(6);

            		        	                    if ( (LA57_6 == 24) )
            		        	                    {
            		        	                        alt57 = 1;
            		        	                    }
            		        	                }
            		        	            }
            		        	            else if ( (LA57_3 == UINT) )
            		        	            {
            		        	                int LA57_6 = input.LA(5);

            		        	                if ( (LA57_6 == 24) )
            		        	                {
            		        	                    alt57 = 1;
            		        	                }
            		        	            }
            		        	        }
            		        	        else if ( (LA57_2 == 25) )
            		        	        {
            		        	            alt57 = 1;
            		        	        }
            		        	    }
            		        	}
            		        	else if ( (LA57_0 == UINT) )
            		        	{
            		        	    int LA57_2 = input.LA(2);

            		        	    if ( (LA57_2 == 24) )
            		        	    {
            		        	        int LA57_3 = input.LA(3);

            		        	        if ( (LA57_3 == 17) )
            		        	        {
            		        	            int LA57_5 = input.LA(4);

            		        	            if ( (LA57_5 == UINT) )
            		        	            {
            		        	                int LA57_6 = input.LA(5);

            		        	                if ( (LA57_6 == 24) )
            		        	                {
            		        	                    alt57 = 1;
            		        	                }
            		        	            }
            		        	        }
            		        	        else if ( (LA57_3 == UINT) )
            		        	        {
            		        	            int LA57_6 = input.LA(4);

            		        	            if ( (LA57_6 == 24) )
            		        	            {
            		        	                alt57 = 1;
            		        	            }
            		        	        }
            		        	    }
            		        	    else if ( (LA57_2 == 25) )
            		        	    {
            		        	        alt57 = 1;
            		        	    }
            		        	}
            		        	switch (alt57) 
            		        	{
            		        	    case 1 :
            		        	        // TimeDef.g:184:10: (d= days_p '.' )? h= hours_p ':'
            		        	        {
            		        	        	// TimeDef.g:184:10: (d= days_p '.' )?
            		        	        	int alt56 = 2;
            		        	        	int LA56_0 = input.LA(1);

            		        	        	if ( (LA56_0 == 17) )
            		        	        	{
            		        	        	    int LA56_1 = input.LA(2);

            		        	        	    if ( (LA56_1 == UINT) )
            		        	        	    {
            		        	        	        int LA56_2 = input.LA(3);

            		        	        	        if ( (LA56_2 == 25) )
            		        	        	        {
            		        	        	            alt56 = 1;
            		        	        	        }
            		        	        	    }
            		        	        	}
            		        	        	else if ( (LA56_0 == UINT) )
            		        	        	{
            		        	        	    int LA56_2 = input.LA(2);

            		        	        	    if ( (LA56_2 == 25) )
            		        	        	    {
            		        	        	        alt56 = 1;
            		        	        	    }
            		        	        	}
            		        	        	switch (alt56) 
            		        	        	{
            		        	        	    case 1 :
            		        	        	        // TimeDef.g:184:11: d= days_p '.'
            		        	        	        {
            		        	        	        	PushFollow(FOLLOW_days_p_in_timespan_p1031);
            		        	        	        	d = days_p();
            		        	        	        	state.followingStackPointer--;
            		        	        	        	if (state.failed) return retval;
            		        	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, d.Tree);
            		        	        	        	char_literal82=(IToken)Match(input,25,FOLLOW_25_in_timespan_p1033); if (state.failed) return retval;
            		        	        	        	if ( state.backtracking == 0 )
            		        	        	        	{char_literal82_tree = (object)adaptor.Create(char_literal82);
            		        	        	        		adaptor.AddChild(root_0, char_literal82_tree);
            		        	        	        	}

            		        	        	        }
            		        	        	        break;

            		        	        	}

            		        	        	PushFollow(FOLLOW_hours_p_in_timespan_p1039);
            		        	        	h = hours_p();
            		        	        	state.followingStackPointer--;
            		        	        	if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            		        	        	char_literal83=(IToken)Match(input,24,FOLLOW_24_in_timespan_p1041); if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 )
            		        	        	{char_literal83_tree = (object)adaptor.Create(char_literal83);
            		        	        		adaptor.AddChild(root_0, char_literal83_tree);
            		        	        	}

            		        	        }
            		        	        break;

            		        	}

            		        	PushFollow(FOLLOW_minutes_p_in_timespan_p1047);
            		        	m = minutes_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            		        	char_literal84=(IToken)Match(input,24,FOLLOW_24_in_timespan_p1049); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{char_literal84_tree = (object)adaptor.Create(char_literal84);
            		        		adaptor.AddChild(root_0, char_literal84_tree);
            		        	}

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_seconds_p_in_timespan_p1055);
            		s = seconds_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            		// TimeDef.g:184:72: ( '.' ms= milliseconds_p )?
            		int alt59 = 2;
            		int LA59_0 = input.LA(1);

            		if ( (LA59_0 == 25) )
            		{
            		    alt59 = 1;
            		}
            		switch (alt59) 
            		{
            		    case 1 :
            		        // TimeDef.g:184:73: '.' ms= milliseconds_p
            		        {
            		        	char_literal85=(IToken)Match(input,25,FOLLOW_25_in_timespan_p1058); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{char_literal85_tree = (object)adaptor.Create(char_literal85);
            		        		adaptor.AddChild(root_0, char_literal85_tree);
            		        	}
            		        	PushFollow(FOLLOW_milliseconds_p_in_timespan_p1062);
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
    // TimeDef.g:194:1: timespan_prog returns [TimeSpan value] : ( timespan_p EOF ) ;
    public TimeDefParser.timespan_prog_return timespan_prog() // throws RecognitionException [1]
    {   
        TimeDefParser.timespan_prog_return retval = new TimeDefParser.timespan_prog_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF87 = null;
        TimeDefParser.timespan_p_return timespan_p86 = default(TimeDefParser.timespan_p_return);


        object EOF87_tree=null;

        try 
    	{
            // TimeDef.g:194:39: ( ( timespan_p EOF ) )
            // TimeDef.g:194:41: ( timespan_p EOF )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:194:41: ( timespan_p EOF )
            	// TimeDef.g:195:4: timespan_p EOF
            	{
            		PushFollow(FOLLOW_timespan_p_in_timespan_prog1084);
            		timespan_p86 = timespan_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, timespan_p86.Tree);
            		EOF87=(IToken)Match(input,EOF,FOLLOW_EOF_in_timespan_prog1086); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{EOF87_tree = (object)adaptor.Create(EOF87);
            			adaptor.AddChild(root_0, EOF87_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((timespan_p86 != null) ? timespan_p86.value : default(TimeSpan)); 
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
    // TimeDef.g:198:1: days_p returns [int value] : int_p ;
    public TimeDefParser.days_p_return days_p() // throws RecognitionException [1]
    {   
        TimeDefParser.days_p_return retval = new TimeDefParser.days_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p88 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:198:27: ( int_p )
            // TimeDef.g:198:29: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_days_p1101);
            	int_p88 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p88.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p88 != null) ? input.ToString((IToken)(int_p88.Start),(IToken)(int_p88.Stop)) : null)); 
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
    // TimeDef.g:199:1: hours_p returns [int value] : int_p ;
    public TimeDefParser.hours_p_return hours_p() // throws RecognitionException [1]
    {   
        TimeDefParser.hours_p_return retval = new TimeDefParser.hours_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p89 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:199:28: ( int_p )
            // TimeDef.g:199:30: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_hours_p1113);
            	int_p89 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p89.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p89 != null) ? input.ToString((IToken)(int_p89.Start),(IToken)(int_p89.Stop)) : null)); 
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
    // TimeDef.g:200:1: minutes_p returns [int value] : int_p ;
    public TimeDefParser.minutes_p_return minutes_p() // throws RecognitionException [1]
    {   
        TimeDefParser.minutes_p_return retval = new TimeDefParser.minutes_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p90 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:200:30: ( int_p )
            // TimeDef.g:200:32: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_minutes_p1125);
            	int_p90 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p90.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p90 != null) ? input.ToString((IToken)(int_p90.Start),(IToken)(int_p90.Stop)) : null)); 
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
    // TimeDef.g:201:1: seconds_p returns [int value] : int_p ;
    public TimeDefParser.seconds_p_return seconds_p() // throws RecognitionException [1]
    {   
        TimeDefParser.seconds_p_return retval = new TimeDefParser.seconds_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p91 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:201:30: ( int_p )
            // TimeDef.g:201:32: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_seconds_p1137);
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
    // TimeDef.g:202:1: milliseconds_p returns [int value] : int_p ;
    public TimeDefParser.milliseconds_p_return milliseconds_p() // throws RecognitionException [1]
    {   
        TimeDefParser.milliseconds_p_return retval = new TimeDefParser.milliseconds_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p92 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:202:35: ( int_p )
            // TimeDef.g:202:37: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_milliseconds_p1149);
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
    // TimeDef.g:204:1: cron_field_p : cron_term_p ( ',' cron_term_p )* ;
    public TimeDefParser.cron_field_p_return cron_field_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_field_p_return retval = new TimeDefParser.cron_field_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal94 = null;
        TimeDefParser.cron_term_p_return cron_term_p93 = default(TimeDefParser.cron_term_p_return);

        TimeDefParser.cron_term_p_return cron_term_p95 = default(TimeDefParser.cron_term_p_return);


        object char_literal94_tree=null;

        try 
    	{
            // TimeDef.g:204:13: ( cron_term_p ( ',' cron_term_p )* )
            // TimeDef.g:204:15: cron_term_p ( ',' cron_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_cron_term_p_in_cron_field_p1158);
            	cron_term_p93 = cron_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cron_term_p93.Tree);
            	// TimeDef.g:204:27: ( ',' cron_term_p )*
            	do 
            	{
            	    int alt60 = 2;
            	    int LA60_0 = input.LA(1);

            	    if ( (LA60_0 == 18) )
            	    {
            	        alt60 = 1;
            	    }


            	    switch (alt60) 
            		{
            			case 1 :
            			    // TimeDef.g:204:28: ',' cron_term_p
            			    {
            			    	char_literal94=(IToken)Match(input,18,FOLLOW_18_in_cron_field_p1161); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal94_tree = (object)adaptor.Create(char_literal94);
            			    		adaptor.AddChild(root_0, char_literal94_tree);
            			    	}
            			    	PushFollow(FOLLOW_cron_term_p_in_cron_field_p1163);
            			    	cron_term_p95 = cron_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cron_term_p95.Tree);

            			    }
            			    break;

            			default:
            			    goto loop60;
            	    }
            	} while (true);

            	loop60:
            		;	// Stops C# compiler whining that label 'loop60' has no statements


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
    // TimeDef.g:205:1: cron_term_p : ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+ ;
    public TimeDefParser.cron_term_p_return cron_term_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_term_p_return retval = new TimeDefParser.cron_term_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal96 = null;
        IToken set97 = null;

        object char_literal96_tree=null;
        object set97_tree=null;

        try 
    	{
            // TimeDef.g:205:12: ( ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+ )
            // TimeDef.g:205:14: ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:205:14: ( '!' )?
            	int alt61 = 2;
            	int LA61_0 = input.LA(1);

            	if ( (LA61_0 == 27) )
            	{
            	    alt61 = 1;
            	}
            	switch (alt61) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '!'
            	        {
            	        	char_literal96=(IToken)Match(input,27,FOLLOW_27_in_cron_term_p1171); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal96_tree = (object)adaptor.Create(char_literal96);
            	        		adaptor.AddChild(root_0, char_literal96_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:205:19: ( UINT | '/' | '-' | '*' | '>' | '<' )+
            	int cnt62 = 0;
            	do 
            	{
            	    int alt62 = 2;
            	    int LA62_0 = input.LA(1);

            	    if ( (LA62_0 == UINT || LA62_0 == 17 || (LA62_0 >= 28 && LA62_0 <= 31)) )
            	    {
            	        alt62 = 1;
            	    }


            	    switch (alt62) 
            		{
            			case 1 :
            			    // TimeDef.g:
            			    {
            			    	set97 = (IToken)input.LT(1);
            			    	if ( input.LA(1) == UINT || input.LA(1) == 17 || (input.LA(1) >= 28 && input.LA(1) <= 31) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set97));
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
            			    if ( cnt62 >= 1 ) goto loop62;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee62 =
            		                new EarlyExitException(62, input);
            		            throw eee62;
            	    }
            	    cnt62++;
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
    // TimeDef.g:207:1: dow_cron_field_p : dow_cron_term_p ( ',' dow_cron_term_p )* ;
    public TimeDefParser.dow_cron_field_p_return dow_cron_field_p() // throws RecognitionException [1]
    {   
        TimeDefParser.dow_cron_field_p_return retval = new TimeDefParser.dow_cron_field_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal99 = null;
        TimeDefParser.dow_cron_term_p_return dow_cron_term_p98 = default(TimeDefParser.dow_cron_term_p_return);

        TimeDefParser.dow_cron_term_p_return dow_cron_term_p100 = default(TimeDefParser.dow_cron_term_p_return);


        object char_literal99_tree=null;

        try 
    	{
            // TimeDef.g:207:17: ( dow_cron_term_p ( ',' dow_cron_term_p )* )
            // TimeDef.g:207:19: dow_cron_term_p ( ',' dow_cron_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_dow_cron_term_p_in_dow_cron_field_p1204);
            	dow_cron_term_p98 = dow_cron_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dow_cron_term_p98.Tree);
            	// TimeDef.g:207:35: ( ',' dow_cron_term_p )*
            	do 
            	{
            	    int alt63 = 2;
            	    int LA63_0 = input.LA(1);

            	    if ( (LA63_0 == 18) )
            	    {
            	        int LA63_2 = input.LA(2);

            	        if ( (LA63_2 == ALPHA || LA63_2 == 14 || LA63_2 == 17 || (LA63_2 >= 27 && LA63_2 <= 31)) )
            	        {
            	            alt63 = 1;
            	        }
            	        else if ( (LA63_2 == UINT) )
            	        {
            	            int LA63_4 = input.LA(3);

            	            if ( (LA63_4 == EOF || (LA63_4 >= WS && LA63_4 <= ALPHA) || (LA63_4 >= 13 && LA63_4 <= 16) || (LA63_4 >= 18 && LA63_4 <= 23) || (LA63_4 >= 28 && LA63_4 <= 31)) )
            	            {
            	                alt63 = 1;
            	            }
            	            else if ( (LA63_4 == 17) )
            	            {
            	                int LA63_5 = input.LA(4);

            	                if ( (LA63_5 == EOF || LA63_5 == WS || LA63_5 == ALPHA || (LA63_5 >= 13 && LA63_5 <= 23) || LA63_5 == 26 || (LA63_5 >= 28 && LA63_5 <= 31)) )
            	                {
            	                    alt63 = 1;
            	                }
            	                else if ( (LA63_5 == UINT) )
            	                {
            	                    int LA63_6 = input.LA(5);

            	                    if ( (LA63_6 == EOF || (LA63_6 >= WS && LA63_6 <= ALPHA) || (LA63_6 >= 13 && LA63_6 <= 16) || (LA63_6 >= 18 && LA63_6 <= 23) || (LA63_6 >= 28 && LA63_6 <= 31)) )
            	                    {
            	                        alt63 = 1;
            	                    }
            	                    else if ( (LA63_6 == 17) )
            	                    {
            	                        int LA63_7 = input.LA(6);

            	                        if ( (LA63_7 == EOF || LA63_7 == WS || LA63_7 == ALPHA || (LA63_7 >= 13 && LA63_7 <= 23) || LA63_7 == 26 || (LA63_7 >= 28 && LA63_7 <= 31)) )
            	                        {
            	                            alt63 = 1;
            	                        }
            	                        else if ( (LA63_7 == UINT) )
            	                        {
            	                            int LA63_8 = input.LA(7);

            	                            if ( (synpred75_TimeDef()) )
            	                            {
            	                                alt63 = 1;
            	                            }


            	                        }


            	                    }


            	                }


            	            }


            	        }


            	    }


            	    switch (alt63) 
            		{
            			case 1 :
            			    // TimeDef.g:207:36: ',' dow_cron_term_p
            			    {
            			    	char_literal99=(IToken)Match(input,18,FOLLOW_18_in_dow_cron_field_p1207); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal99_tree = (object)adaptor.Create(char_literal99);
            			    		adaptor.AddChild(root_0, char_literal99_tree);
            			    	}
            			    	PushFollow(FOLLOW_dow_cron_term_p_in_dow_cron_field_p1209);
            			    	dow_cron_term_p100 = dow_cron_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dow_cron_term_p100.Tree);

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
    // TimeDef.g:208:1: dow_cron_term_p : ( '!' )? ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+ ;
    public TimeDefParser.dow_cron_term_p_return dow_cron_term_p() // throws RecognitionException [1]
    {   
        TimeDefParser.dow_cron_term_p_return retval = new TimeDefParser.dow_cron_term_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal101 = null;
        IToken set102 = null;

        object char_literal101_tree=null;
        object set102_tree=null;

        try 
    	{
            // TimeDef.g:208:16: ( ( '!' )? ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+ )
            // TimeDef.g:208:18: ( '!' )? ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:208:18: ( '!' )?
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
            	        	char_literal101=(IToken)Match(input,27,FOLLOW_27_in_dow_cron_term_p1217); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal101_tree = (object)adaptor.Create(char_literal101);
            	        		adaptor.AddChild(root_0, char_literal101_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:208:23: ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+
            	int cnt65 = 0;
            	do 
            	{
            	    int alt65 = 2;
            	    alt65 = dfa65.Predict(input);
            	    switch (alt65) 
            		{
            			case 1 :
            			    // TimeDef.g:
            			    {
            			    	set102 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= UINT && input.LA(1) <= ALPHA) || input.LA(1) == 14 || input.LA(1) == 17 || (input.LA(1) >= 28 && input.LA(1) <= 31) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set102));
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
    // TimeDef.g:210:1: intspec_p : intspec_term_p ( ',' intspec_term_p )* ;
    public TimeDefParser.intspec_p_return intspec_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intspec_p_return retval = new TimeDefParser.intspec_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal104 = null;
        TimeDefParser.intspec_term_p_return intspec_term_p103 = default(TimeDefParser.intspec_term_p_return);

        TimeDefParser.intspec_term_p_return intspec_term_p105 = default(TimeDefParser.intspec_term_p_return);


        object char_literal104_tree=null;

        try 
    	{
            // TimeDef.g:210:10: ( intspec_term_p ( ',' intspec_term_p )* )
            // TimeDef.g:210:12: intspec_term_p ( ',' intspec_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_intspec_term_p_in_intspec_p1258);
            	intspec_term_p103 = intspec_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intspec_term_p103.Tree);
            	// TimeDef.g:210:27: ( ',' intspec_term_p )*
            	do 
            	{
            	    int alt66 = 2;
            	    int LA66_0 = input.LA(1);

            	    if ( (LA66_0 == 18) )
            	    {
            	        int LA66_2 = input.LA(2);

            	        if ( (LA66_2 == 17 || LA66_2 == 27 || LA66_2 == 29) )
            	        {
            	            alt66 = 1;
            	        }
            	        else if ( (LA66_2 == UINT) )
            	        {
            	            int LA66_4 = input.LA(3);

            	            if ( (LA66_4 == 17) )
            	            {
            	                int LA66_5 = input.LA(4);

            	                if ( (LA66_5 == WS || LA66_5 == 17 || LA66_5 == 26) )
            	                {
            	                    alt66 = 1;
            	                }
            	                else if ( (LA66_5 == UINT) )
            	                {
            	                    int LA66_6 = input.LA(5);

            	                    if ( (LA66_6 == EOF || LA66_6 == WS || (LA66_6 >= 13 && LA66_6 <= 16) || (LA66_6 >= 18 && LA66_6 <= 23) || LA66_6 == 28) )
            	                    {
            	                        alt66 = 1;
            	                    }
            	                    else if ( (LA66_6 == 17) )
            	                    {
            	                        int LA66_7 = input.LA(6);

            	                        if ( (LA66_7 == WS || LA66_7 == 26) )
            	                        {
            	                            alt66 = 1;
            	                        }


            	                    }


            	                }


            	            }
            	            else if ( (LA66_4 == EOF || LA66_4 == WS || (LA66_4 >= 13 && LA66_4 <= 16) || (LA66_4 >= 18 && LA66_4 <= 23) || LA66_4 == 28) )
            	            {
            	                alt66 = 1;
            	            }


            	        }


            	    }


            	    switch (alt66) 
            		{
            			case 1 :
            			    // TimeDef.g:210:28: ',' intspec_term_p
            			    {
            			    	char_literal104=(IToken)Match(input,18,FOLLOW_18_in_intspec_p1261); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal104_tree = (object)adaptor.Create(char_literal104);
            			    		adaptor.AddChild(root_0, char_literal104_tree);
            			    	}
            			    	PushFollow(FOLLOW_intspec_term_p_in_intspec_p1263);
            			    	intspec_term_p105 = intspec_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intspec_term_p105.Tree);

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
    // TimeDef.g:211:1: intspec_term_p : ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )? ;
    public TimeDefParser.intspec_term_p_return intspec_term_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intspec_term_p_return retval = new TimeDefParser.intspec_term_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal106 = null;
        IToken char_literal107 = null;
        IToken char_literal109 = null;
        IToken char_literal111 = null;
        IToken UINT112 = null;
        TimeDefParser.int_p_return int_p108 = default(TimeDefParser.int_p_return);

        TimeDefParser.int_p_return int_p110 = default(TimeDefParser.int_p_return);


        object char_literal106_tree=null;
        object char_literal107_tree=null;
        object char_literal109_tree=null;
        object char_literal111_tree=null;
        object UINT112_tree=null;

        try 
    	{
            // TimeDef.g:211:15: ( ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )? )
            // TimeDef.g:211:17: ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:211:17: ( '!' )?
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
            	        	char_literal106=(IToken)Match(input,27,FOLLOW_27_in_intspec_term_p1271); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal106_tree = (object)adaptor.Create(char_literal106);
            	        		adaptor.AddChild(root_0, char_literal106_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:211:22: ( '*' | int_p ( '-' int_p )? )
            	int alt69 = 2;
            	int LA69_0 = input.LA(1);

            	if ( (LA69_0 == 29) )
            	{
            	    alt69 = 1;
            	}
            	else if ( (LA69_0 == UINT || LA69_0 == 17) )
            	{
            	    alt69 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d69s0 =
            	        new NoViableAltException("", 69, 0, input);

            	    throw nvae_d69s0;
            	}
            	switch (alt69) 
            	{
            	    case 1 :
            	        // TimeDef.g:211:24: '*'
            	        {
            	        	char_literal107=(IToken)Match(input,29,FOLLOW_29_in_intspec_term_p1276); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal107_tree = (object)adaptor.Create(char_literal107);
            	        		adaptor.AddChild(root_0, char_literal107_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // TimeDef.g:211:30: int_p ( '-' int_p )?
            	        {
            	        	PushFollow(FOLLOW_int_p_in_intspec_term_p1280);
            	        	int_p108 = int_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p108.Tree);
            	        	// TimeDef.g:211:36: ( '-' int_p )?
            	        	int alt68 = 2;
            	        	int LA68_0 = input.LA(1);

            	        	if ( (LA68_0 == 17) )
            	        	{
            	        	    int LA68_1 = input.LA(2);

            	        	    if ( (LA68_1 == UINT || LA68_1 == 17) )
            	        	    {
            	        	        alt68 = 1;
            	        	    }
            	        	}
            	        	switch (alt68) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:211:38: '-' int_p
            	        	        {
            	        	        	char_literal109=(IToken)Match(input,17,FOLLOW_17_in_intspec_term_p1284); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal109_tree = (object)adaptor.Create(char_literal109);
            	        	        		adaptor.AddChild(root_0, char_literal109_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_int_p_in_intspec_term_p1286);
            	        	        	int_p110 = int_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p110.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// TimeDef.g:211:53: ( '/' UINT )?
            	int alt70 = 2;
            	int LA70_0 = input.LA(1);

            	if ( (LA70_0 == 28) )
            	{
            	    alt70 = 1;
            	}
            	switch (alt70) 
            	{
            	    case 1 :
            	        // TimeDef.g:211:55: '/' UINT
            	        {
            	        	char_literal111=(IToken)Match(input,28,FOLLOW_28_in_intspec_term_p1295); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal111_tree = (object)adaptor.Create(char_literal111);
            	        		adaptor.AddChild(root_0, char_literal111_tree);
            	        	}
            	        	UINT112=(IToken)Match(input,UINT,FOLLOW_UINT_in_intspec_term_p1297); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UINT112_tree = (object)adaptor.Create(UINT112);
            	        		adaptor.AddChild(root_0, UINT112_tree);
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
    // TimeDef.g:216:1: int_p : ( '-' )? UINT ;
    public TimeDefParser.int_p_return int_p() // throws RecognitionException [1]
    {   
        TimeDefParser.int_p_return retval = new TimeDefParser.int_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal113 = null;
        IToken UINT114 = null;

        object char_literal113_tree=null;
        object UINT114_tree=null;

        try 
    	{
            // TimeDef.g:216:6: ( ( '-' )? UINT )
            // TimeDef.g:216:8: ( '-' )? UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:216:8: ( '-' )?
            	int alt71 = 2;
            	int LA71_0 = input.LA(1);

            	if ( (LA71_0 == 17) )
            	{
            	    alt71 = 1;
            	}
            	switch (alt71) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '-'
            	        {
            	        	char_literal113=(IToken)Match(input,17,FOLLOW_17_in_int_p1310); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal113_tree = (object)adaptor.Create(char_literal113);
            	        		adaptor.AddChild(root_0, char_literal113_tree);
            	        	}

            	        }
            	        break;

            	}

            	UINT114=(IToken)Match(input,UINT,FOLLOW_UINT_in_int_p1313); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UINT114_tree = (object)adaptor.Create(UINT114);
            		adaptor.AddChild(root_0, UINT114_tree);
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


        // TimeDef.g:58:22: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:58:22: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:58:22: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred7_TimeDef165); if (state.failed) return ;

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

        	Match(input,7,FOLLOW_7_in_synpred7_TimeDef168); if (state.failed) return ;
        	// TimeDef.g:58:36: ( WS )+
        	int cnt73 = 0;
        	do 
        	{
        	    int alt73 = 2;
        	    int LA73_0 = input.LA(1);

        	    if ( (LA73_0 == WS) )
        	    {
        	        alt73 = 1;
        	    }


        	    switch (alt73) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred7_TimeDef170); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt73 >= 1 ) goto loop73;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee73 =
        		                new EarlyExitException(73, input);
        		            throw eee73;
        	    }
        	    cnt73++;
        	} while (true);

        	loop73:
        		;	// Stops C# compiler whining that label 'loop73' has no statements

        	PushFollow(FOLLOW_timespan_p_in_synpred7_TimeDef175);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_TimeDef"

    // $ANTLR start "synpred14_TimeDef"
    public void synpred14_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        // TimeDef.g:62:72: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:62:72: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:62:72: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred14_TimeDef222); if (state.failed) return ;

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

        	Match(input,7,FOLLOW_7_in_synpred14_TimeDef225); if (state.failed) return ;
        	// TimeDef.g:62:86: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred14_TimeDef227); if (state.failed) return ;

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

        	PushFollow(FOLLOW_timespan_p_in_synpred14_TimeDef232);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred14_TimeDef"

    // $ANTLR start "synpred22_TimeDef"
    public void synpred22_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        // TimeDef.g:72:5: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:72:5: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:72:5: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred22_TimeDef310); if (state.failed) return ;

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

        	Match(input,7,FOLLOW_7_in_synpred22_TimeDef313); if (state.failed) return ;
        	// TimeDef.g:72:19: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred22_TimeDef315); if (state.failed) return ;

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

        	PushFollow(FOLLOW_timespan_p_in_synpred22_TimeDef320);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred22_TimeDef"

    // $ANTLR start "synpred75_TimeDef"
    public void synpred75_TimeDef_fragment() {
        // TimeDef.g:207:36: ( ',' dow_cron_term_p )
        // TimeDef.g:207:36: ',' dow_cron_term_p
        {
        	Match(input,18,FOLLOW_18_in_synpred75_TimeDef1207); if (state.failed) return ;
        	PushFollow(FOLLOW_dow_cron_term_p_in_synpred75_TimeDef1209);
        	dow_cron_term_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred75_TimeDef"

    // Delegated rules

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
   	protected DFA52 dfa52;
   	protected DFA65 dfa65;
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
    	this.dfa52 = new DFA52(this);
    	this.dfa65 = new DFA65(this);
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
            get { return "58:21: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?"; }
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
            get { return "62:36: ( ( WS )+ 'since' ( WS )+ sync= datetime_p )?"; }
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
            get { return "62:71: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?"; }
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
            get { return "72:4: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?"; }
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
        "\x07\uffff";
    const string DFA28_eofS =
        "\x02\x02\x05\uffff";
    const string DFA28_minS =
        "\x02\x04\x05\uffff";
    const string DFA28_maxS =
        "\x02\x17\x05\uffff";
    const string DFA28_acceptS =
        "\x02\uffff\x01\x05\x01\x01\x01\x02\x01\x03\x01\x04";
    const string DFA28_specialS =
        "\x07\uffff}>";
    static readonly string[] DFA28_transitionS = {
            "\x01\x01\x08\uffff\x01\x02\x01\x03\x01\x04\x02\x05\x06\x02",
            "\x01\x01\x02\uffff\x01\x06\x05\uffff\x01\x02\x01\x03\x01\x04"+
            "\x02\x05\x06\x02",
            "",
            "",
            "",
            "",
            ""
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
            get { return "()* loopback of 87:34: ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*"; }
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
            get { return "()* loopback of 102:4: ( ( WS )* ',' ( WS )* B= boolnonintersection_p )*"; }
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
            get { return "()* loopback of 110:4: ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*"; }
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
            get { return "()* loopback of 118:4: ( ( WS )* '&&' ( WS )* B= union_p )*"; }
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
            get { return "()* loopback of 130:4: ( ( WS )* '|' ( WS )* B= difference_p )*"; }
        }

    }

    const string DFA45_eotS =
        "\x04\uffff";
    const string DFA45_eofS =
        "\x02\x02\x02\uffff";
    const string DFA45_minS =
        "\x02\x04\x02\uffff";
    const string DFA45_maxS =
        "\x02\x16\x02\uffff";
    const string DFA45_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA45_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA45_transitionS = {
            "\x01\x01\x08\uffff\x01\x02\x04\uffff\x04\x02\x01\x03",
            "\x01\x01\x08\uffff\x01\x02\x04\uffff\x04\x02\x01\x03",
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
            get { return "()* loopback of 142:4: ( ( WS )* '!&' ( WS )* B= intersection_p )*"; }
        }

    }

    const string DFA48_eotS =
        "\x04\uffff";
    const string DFA48_eofS =
        "\x02\x02\x02\uffff";
    const string DFA48_minS =
        "\x02\x04\x02\uffff";
    const string DFA48_maxS =
        "\x02\x17\x02\uffff";
    const string DFA48_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA48_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA48_transitionS = {
            "\x01\x01\x08\uffff\x01\x02\x04\uffff\x05\x02\x01\x03",
            "\x01\x01\x08\uffff\x01\x02\x04\uffff\x05\x02\x01\x03",
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
            get { return "()* loopback of 151:4: ( ( WS )* '&' ( WS )* B= filter_p )*"; }
        }

    }

    const string DFA52_eotS =
        "\x04\uffff";
    const string DFA52_eofS =
        "\x02\x02\x02\uffff";
    const string DFA52_minS =
        "\x02\x04\x02\uffff";
    const string DFA52_maxS =
        "\x02\x17\x02\uffff";
    const string DFA52_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA52_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA52_transitionS = {
            "\x01\x01\x08\uffff\x0b\x02",
            "\x01\x01\x01\x03\x01\uffff\x01\x02\x05\uffff\x0b\x02",
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
            get { return "158:40: ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?"; }
        }

    }

    const string DFA65_eotS =
        "\x0b\uffff";
    const string DFA65_eofS =
        "\x01\x01\x01\uffff\x01\x04\x01\x08\x01\uffff\x02\x08\x02\uffff"+
        "\x01\x08\x01\uffff";
    const string DFA65_minS =
        "\x01\x04\x01\uffff\x02\x04\x01\uffff\x02\x04\x02\uffff\x02\x04";
    const string DFA65_maxS =
        "\x01\x1f\x01\uffff\x02\x1f\x01\uffff\x01\x1d\x01\x1f\x02\uffff"+
        "\x02\x1a";
    const string DFA65_acceptS =
        "\x01\uffff\x01\x02\x02\uffff\x01\x01\x02\uffff\x02\x01\x02\uffff";
    const string DFA65_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA65_transitionS = {
            "\x01\x01\x02\x04\x06\uffff\x01\x01\x01\x02\x02\x01\x01\x03"+
            "\x06\x01\x04\uffff\x04\x04",
            "",
            "\x01\x05\x01\x08\x01\x04\x06\uffff\x04\x04\x01\x06\x06\x04"+
            "\x03\uffff\x01\x01\x01\x04\x01\x07\x02\x04",
            "\x01\x09\x02\x04\x06\uffff\x0b\x08\x02\uffff\x01\x01\x01\uffff"+
            "\x04\x04",
            "",
            "\x01\x05\x01\x01\x01\uffff\x01\x08\x05\uffff\x04\x08\x01\x0a"+
            "\x06\x08\x03\uffff\x01\x01\x01\uffff\x01\x01",
            "\x02\x08\x01\x04\x06\uffff\x0b\x08\x02\uffff\x01\x08\x01\uffff"+
            "\x04\x04",
            "",
            "",
            "\x01\x09\x02\uffff\x01\x08\x05\uffff\x0b\x08\x02\uffff\x01"+
            "\x01",
            "\x01\x08\x01\x01\x14\uffff\x01\x08"
    };

    static readonly short[] DFA65_eot = DFA.UnpackEncodedString(DFA65_eotS);
    static readonly short[] DFA65_eof = DFA.UnpackEncodedString(DFA65_eofS);
    static readonly char[] DFA65_min = DFA.UnpackEncodedStringToUnsignedChars(DFA65_minS);
    static readonly char[] DFA65_max = DFA.UnpackEncodedStringToUnsignedChars(DFA65_maxS);
    static readonly short[] DFA65_accept = DFA.UnpackEncodedString(DFA65_acceptS);
    static readonly short[] DFA65_special = DFA.UnpackEncodedString(DFA65_specialS);
    static readonly short[][] DFA65_transition = DFA.UnpackEncodedStringArray(DFA65_transitionS);

    protected class DFA65 : DFA
    {
        public DFA65(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 65;
            this.eot = DFA65_eot;
            this.eof = DFA65_eof;
            this.min = DFA65_min;
            this.max = DFA65_max;
            this.accept = DFA65_accept;
            this.special = DFA65_special;
            this.transition = DFA65_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 208:23: ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_prog62 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_prog64 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_once_p_in_atom102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_every_p_in_atom111 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cron_p_in_atom120 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_void_p_in_atom129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paren_p_in_atom138 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_datetime_p_in_once_p162 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_once_p165 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_once_p168 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_once_p170 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_once_p175 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_8_in_every_p197 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p199 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_every_p204 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_every_p207 = new BitSet(new ulong[]{0x0000000000000210UL});
    public static readonly BitSet FOLLOW_9_in_every_p210 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p212 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_datetime_p_in_every_p217 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_every_p222 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_every_p225 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p227 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_every_p232 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_10_in_cron_p254 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p256 = new BitSet(new ulong[]{0x00000000F8020030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p264 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p266 = new BitSet(new ulong[]{0x00000000F8020030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p274 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p276 = new BitSet(new ulong[]{0x00000000F8020030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p284 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p286 = new BitSet(new ulong[]{0x00000000F8020030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p294 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p296 = new BitSet(new ulong[]{0x00000000F8024070UL});
    public static readonly BitSet FOLLOW_dow_cron_field_p_in_cron_p304 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p310 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_cron_p313 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p315 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_cron_p320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_11_in_void_p340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_paren_p358 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_expr_in_paren_p360 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_13_in_paren_p362 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_filter_p386 = new BitSet(new ulong[]{0x000000000003C012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p399 = new BitSet(new ulong[]{0x0000000000004010UL});
    public static readonly BitSet FOLLOW_14_in_filter_p402 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p404 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_intspec_p_in_filter_p409 = new BitSet(new ulong[]{0x000000000003C012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p424 = new BitSet(new ulong[]{0x0000000000008010UL});
    public static readonly BitSet FOLLOW_15_in_filter_p427 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p429 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_UINT_in_filter_p434 = new BitSet(new ulong[]{0x000000000003C012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p449 = new BitSet(new ulong[]{0x0000000000030010UL});
    public static readonly BitSet FOLLOW_set_in_filter_p454 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p460 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_filter_p465 = new BitSet(new ulong[]{0x000000000003C012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p480 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_filter_p483 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p485 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_filter_p490 = new BitSet(new ulong[]{0x000000000003C012UL});
    public static readonly BitSet FOLLOW_WS_in_expr524 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_boolnonintersection_p_in_expr529 = new BitSet(new ulong[]{0x0000000000040012UL});
    public static readonly BitSet FOLLOW_WS_in_expr537 = new BitSet(new ulong[]{0x0000000000040010UL});
    public static readonly BitSet FOLLOW_18_in_expr540 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_expr542 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_boolnonintersection_p_in_expr547 = new BitSet(new ulong[]{0x0000000000040012UL});
    public static readonly BitSet FOLLOW_WS_in_expr554 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_boolintersection_p_in_boolnonintersection_p578 = new BitSet(new ulong[]{0x0000000000080012UL});
    public static readonly BitSet FOLLOW_WS_in_boolnonintersection_p586 = new BitSet(new ulong[]{0x0000000000080010UL});
    public static readonly BitSet FOLLOW_19_in_boolnonintersection_p589 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_boolnonintersection_p591 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_boolintersection_p_in_boolnonintersection_p596 = new BitSet(new ulong[]{0x0000000000080012UL});
    public static readonly BitSet FOLLOW_union_p_in_boolintersection_p621 = new BitSet(new ulong[]{0x0000000000100012UL});
    public static readonly BitSet FOLLOW_WS_in_boolintersection_p629 = new BitSet(new ulong[]{0x0000000000100010UL});
    public static readonly BitSet FOLLOW_20_in_boolintersection_p632 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_boolintersection_p634 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_union_p_in_boolintersection_p639 = new BitSet(new ulong[]{0x0000000000100012UL});
    public static readonly BitSet FOLLOW_difference_p_in_union_p672 = new BitSet(new ulong[]{0x0000000000200012UL});
    public static readonly BitSet FOLLOW_WS_in_union_p680 = new BitSet(new ulong[]{0x0000000000200010UL});
    public static readonly BitSet FOLLOW_21_in_union_p683 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_union_p685 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_difference_p_in_union_p690 = new BitSet(new ulong[]{0x0000000000200012UL});
    public static readonly BitSet FOLLOW_intersection_p_in_difference_p726 = new BitSet(new ulong[]{0x0000000000400012UL});
    public static readonly BitSet FOLLOW_WS_in_difference_p734 = new BitSet(new ulong[]{0x0000000000400010UL});
    public static readonly BitSet FOLLOW_22_in_difference_p737 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_difference_p739 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_intersection_p_in_difference_p744 = new BitSet(new ulong[]{0x0000000000400012UL});
    public static readonly BitSet FOLLOW_filter_p_in_intersection_p773 = new BitSet(new ulong[]{0x0000000000800012UL});
    public static readonly BitSet FOLLOW_WS_in_intersection_p781 = new BitSet(new ulong[]{0x0000000000800010UL});
    public static readonly BitSet FOLLOW_23_in_intersection_p784 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_WS_in_intersection_p786 = new BitSet(new ulong[]{0x0000000000001D30UL});
    public static readonly BitSet FOLLOW_filter_p_in_intersection_p791 = new BitSet(new ulong[]{0x0000000000800012UL});
    public static readonly BitSet FOLLOW_year_p_in_datetime_p818 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_datetime_p820 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_month_p_in_datetime_p824 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_datetime_p826 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_day_p_in_datetime_p830 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_datetime_p833 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_hour24_p_in_datetime_p838 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_datetime_p840 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_minute60_p_in_datetime_p844 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_24_in_datetime_p847 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_second60_p_in_datetime_p851 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_25_in_datetime_p854 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_millisecond1000_p_in_datetime_p858 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_hour24_p_in_datetime_p873 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_datetime_p875 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_minute60_p_in_datetime_p879 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_24_in_datetime_p882 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_second60_p_in_datetime_p886 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_25_in_datetime_p889 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_millisecond1000_p_in_datetime_p893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_datetime_p_in_datetime_prog917 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_datetime_prog919 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_year_p934 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_month_p946 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_day_p958 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_hour24_p970 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_minute60_p982 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_second60_p994 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_millisecond1000_p1006 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_timespan_p1024 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_days_p_in_timespan_p1031 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_timespan_p1033 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_hours_p_in_timespan_p1039 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_timespan_p1041 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_minutes_p_in_timespan_p1047 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_timespan_p1049 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_seconds_p_in_timespan_p1055 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_25_in_timespan_p1058 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_milliseconds_p_in_timespan_p1062 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_timespan_p_in_timespan_prog1084 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_timespan_prog1086 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_days_p1101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_hours_p1113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_minutes_p1125 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_seconds_p1137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_milliseconds_p1149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cron_term_p_in_cron_field_p1158 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_18_in_cron_field_p1161 = new BitSet(new ulong[]{0x00000000F8020020UL});
    public static readonly BitSet FOLLOW_cron_term_p_in_cron_field_p1163 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_27_in_cron_term_p1171 = new BitSet(new ulong[]{0x00000000F0020020UL});
    public static readonly BitSet FOLLOW_set_in_cron_term_p1174 = new BitSet(new ulong[]{0x00000000F0020022UL});
    public static readonly BitSet FOLLOW_dow_cron_term_p_in_dow_cron_field_p1204 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_18_in_dow_cron_field_p1207 = new BitSet(new ulong[]{0x00000000F8024060UL});
    public static readonly BitSet FOLLOW_dow_cron_term_p_in_dow_cron_field_p1209 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_27_in_dow_cron_term_p1217 = new BitSet(new ulong[]{0x00000000F0024060UL});
    public static readonly BitSet FOLLOW_set_in_dow_cron_term_p1220 = new BitSet(new ulong[]{0x00000000F0024062UL});
    public static readonly BitSet FOLLOW_intspec_term_p_in_intspec_p1258 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_18_in_intspec_p1261 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_intspec_term_p_in_intspec_p1263 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_27_in_intspec_term_p1271 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_29_in_intspec_term_p1276 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_int_p_in_intspec_term_p1280 = new BitSet(new ulong[]{0x0000000010020002UL});
    public static readonly BitSet FOLLOW_17_in_intspec_term_p1284 = new BitSet(new ulong[]{0x0000000028020030UL});
    public static readonly BitSet FOLLOW_int_p_in_intspec_term_p1286 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_intspec_term_p1295 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_UINT_in_intspec_term_p1297 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_17_in_int_p1310 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_UINT_in_int_p1313 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred7_TimeDef165 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred7_TimeDef168 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred7_TimeDef170 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred7_TimeDef175 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred14_TimeDef222 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred14_TimeDef225 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred14_TimeDef227 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred14_TimeDef232 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred22_TimeDef310 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred22_TimeDef313 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred22_TimeDef315 = new BitSet(new ulong[]{0x0000000004000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred22_TimeDef320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_18_in_synpred75_TimeDef1207 = new BitSet(new ulong[]{0x00000000F8024060UL});
    public static readonly BitSet FOLLOW_dow_cron_term_p_in_synpred75_TimeDef1209 = new BitSet(new ulong[]{0x0000000000000002UL});

}
