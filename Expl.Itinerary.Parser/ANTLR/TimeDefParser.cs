// $ANTLR 3.2 Sep 23, 2009 12:02:23 TimeDef.g 2011-06-20 11:12:49

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
		"'to'", 
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
		"'beginning'", 
		"'end'", 
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
    public const int T__33 = 33;
    public const int T__16 = 16;
    public const int T__34 = 34;
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
            case 25:
            case 26:
            	{
                alt1 = 1;
                }
                break;
            case 9:
            	{
                alt1 = 2;
                }
                break;
            case 11:
            	{
                alt1 = 3;
                }
                break;
            case 12:
            	{
                alt1 = 4;
                }
                break;
            case 13:
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
    // TimeDef.g:58:1: once_p returns [OneTimeSchedule value] : (start= datetime_p ( ( WS )+ ( 'lasting' ( WS )+ duration= timespan_p | 'to' ( WS )+ enddatetime= datetime_p ) )? ) ;
    public TimeDefParser.once_p_return once_p() // throws RecognitionException [1]
    {   
        TimeDefParser.once_p_return retval = new TimeDefParser.once_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS8 = null;
        IToken string_literal9 = null;
        IToken WS10 = null;
        IToken string_literal11 = null;
        IToken WS12 = null;
        TimeDefParser.datetime_p_return start = default(TimeDefParser.datetime_p_return);

        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);

        TimeDefParser.datetime_p_return enddatetime = default(TimeDefParser.datetime_p_return);


        object WS8_tree=null;
        object string_literal9_tree=null;
        object WS10_tree=null;
        object string_literal11_tree=null;
        object WS12_tree=null;

        try 
    	{
            // TimeDef.g:58:39: ( (start= datetime_p ( ( WS )+ ( 'lasting' ( WS )+ duration= timespan_p | 'to' ( WS )+ enddatetime= datetime_p ) )? ) )
            // TimeDef.g:58:41: (start= datetime_p ( ( WS )+ ( 'lasting' ( WS )+ duration= timespan_p | 'to' ( WS )+ enddatetime= datetime_p ) )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:58:41: (start= datetime_p ( ( WS )+ ( 'lasting' ( WS )+ duration= timespan_p | 'to' ( WS )+ enddatetime= datetime_p ) )? )
            	// TimeDef.g:59:4: start= datetime_p ( ( WS )+ ( 'lasting' ( WS )+ duration= timespan_p | 'to' ( WS )+ enddatetime= datetime_p ) )?
            	{
            		PushFollow(FOLLOW_datetime_p_in_once_p163);
            		start = datetime_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, start.Tree);
            		// TimeDef.g:59:21: ( ( WS )+ ( 'lasting' ( WS )+ duration= timespan_p | 'to' ( WS )+ enddatetime= datetime_p ) )?
            		int alt6 = 2;
            		alt6 = dfa6.Predict(input);
            		switch (alt6) 
            		{
            		    case 1 :
            		        // TimeDef.g:59:22: ( WS )+ ( 'lasting' ( WS )+ duration= timespan_p | 'to' ( WS )+ enddatetime= datetime_p )
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

            		        	// TimeDef.g:59:26: ( 'lasting' ( WS )+ duration= timespan_p | 'to' ( WS )+ enddatetime= datetime_p )
            		        	int alt5 = 2;
            		        	int LA5_0 = input.LA(1);

            		        	if ( (LA5_0 == 7) )
            		        	{
            		        	    alt5 = 1;
            		        	}
            		        	else if ( (LA5_0 == 8) )
            		        	{
            		        	    alt5 = 2;
            		        	}
            		        	else 
            		        	{
            		        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        	    NoViableAltException nvae_d5s0 =
            		        	        new NoViableAltException("", 5, 0, input);

            		        	    throw nvae_d5s0;
            		        	}
            		        	switch (alt5) 
            		        	{
            		        	    case 1 :
            		        	        // TimeDef.g:59:27: 'lasting' ( WS )+ duration= timespan_p
            		        	        {
            		        	        	string_literal9=(IToken)Match(input,7,FOLLOW_7_in_once_p170); if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 )
            		        	        	{string_literal9_tree = (object)adaptor.Create(string_literal9);
            		        	        		adaptor.AddChild(root_0, string_literal9_tree);
            		        	        	}
            		        	        	// TimeDef.g:59:37: ( WS )+
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
            		        	        			    	WS10=(IToken)Match(input,WS,FOLLOW_WS_in_once_p172); if (state.failed) return retval;
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

            		        	        	PushFollow(FOLLOW_timespan_p_in_once_p177);
            		        	        	duration = timespan_p();
            		        	        	state.followingStackPointer--;
            		        	        	if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, duration.Tree);

            		        	        }
            		        	        break;
            		        	    case 2 :
            		        	        // TimeDef.g:59:63: 'to' ( WS )+ enddatetime= datetime_p
            		        	        {
            		        	        	string_literal11=(IToken)Match(input,8,FOLLOW_8_in_once_p181); if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 )
            		        	        	{string_literal11_tree = (object)adaptor.Create(string_literal11);
            		        	        		adaptor.AddChild(root_0, string_literal11_tree);
            		        	        	}
            		        	        	// TimeDef.g:59:68: ( WS )+
            		        	        	int cnt4 = 0;
            		        	        	do 
            		        	        	{
            		        	        	    int alt4 = 2;
            		        	        	    int LA4_0 = input.LA(1);

            		        	        	    if ( (LA4_0 == WS) )
            		        	        	    {
            		        	        	        alt4 = 1;
            		        	        	    }


            		        	        	    switch (alt4) 
            		        	        		{
            		        	        			case 1 :
            		        	        			    // TimeDef.g:0:0: WS
            		        	        			    {
            		        	        			    	WS12=(IToken)Match(input,WS,FOLLOW_WS_in_once_p183); if (state.failed) return retval;
            		        	        			    	if ( state.backtracking == 0 )
            		        	        			    	{WS12_tree = (object)adaptor.Create(WS12);
            		        	        			    		adaptor.AddChild(root_0, WS12_tree);
            		        	        			    	}

            		        	        			    }
            		        	        			    break;

            		        	        			default:
            		        	        			    if ( cnt4 >= 1 ) goto loop4;
            		        	        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        	        		            EarlyExitException eee4 =
            		        	        		                new EarlyExitException(4, input);
            		        	        		            throw eee4;
            		        	        	    }
            		        	        	    cnt4++;
            		        	        	} while (true);

            		        	        	loop4:
            		        	        		;	// Stops C# compiler whining that label 'loop4' has no statements

            		        	        	PushFollow(FOLLOW_datetime_p_in_once_p188);
            		        	        	enddatetime = datetime_p();
            		        	        	state.followingStackPointer--;
            		        	        	if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, enddatetime.Tree);

            		        	        }
            		        	        break;

            		        	}


            		        }
            		        break;

            		}


            	}

            	if ( (state.backtracking==0) )
            	{

            	      retval.value =  enddatetime != null ?
            	          new OneTimeSchedule(((start != null) ? start.value : default(DateTime)), ((enddatetime != null) ? enddatetime.value : default(DateTime))) : // 'to' syntax
            	          new OneTimeSchedule(((start != null) ? start.value : default(DateTime)), duration==null ? TimeSpan.Zero : ((duration != null) ? duration.value : default(TimeSpan))); // 'lasting' syntax

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
    // TimeDef.g:66:1: every_p returns [IntervalSchedule value] : ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) ;
    public TimeDefParser.every_p_return every_p() // throws RecognitionException [1]
    {   
        TimeDefParser.every_p_return retval = new TimeDefParser.every_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal13 = null;
        IToken WS14 = null;
        IToken WS15 = null;
        IToken string_literal16 = null;
        IToken WS17 = null;
        IToken WS18 = null;
        IToken string_literal19 = null;
        IToken WS20 = null;
        TimeDefParser.timespan_p_return interval = default(TimeDefParser.timespan_p_return);

        TimeDefParser.datetime_p_return sync = default(TimeDefParser.datetime_p_return);

        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        object string_literal13_tree=null;
        object WS14_tree=null;
        object WS15_tree=null;
        object string_literal16_tree=null;
        object WS17_tree=null;
        object WS18_tree=null;
        object string_literal19_tree=null;
        object WS20_tree=null;

        try 
    	{
            // TimeDef.g:66:41: ( ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:66:43: ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:66:43: ( 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:67:4: 'every' ( WS )+ interval= timespan_p ( ( WS )+ 'since' ( WS )+ sync= datetime_p )? ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		string_literal13=(IToken)Match(input,9,FOLLOW_9_in_every_p211); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{string_literal13_tree = (object)adaptor.Create(string_literal13);
            			adaptor.AddChild(root_0, string_literal13_tree);
            		}
            		// TimeDef.g:67:12: ( WS )+
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
            				    	WS14=(IToken)Match(input,WS,FOLLOW_WS_in_every_p213); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS14_tree = (object)adaptor.Create(WS14);
            				    		adaptor.AddChild(root_0, WS14_tree);
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

            		PushFollow(FOLLOW_timespan_p_in_every_p218);
            		interval = timespan_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, interval.Tree);
            		// TimeDef.g:67:36: ( ( WS )+ 'since' ( WS )+ sync= datetime_p )?
            		int alt10 = 2;
            		alt10 = dfa10.Predict(input);
            		switch (alt10) 
            		{
            		    case 1 :
            		        // TimeDef.g:67:37: ( WS )+ 'since' ( WS )+ sync= datetime_p
            		        {
            		        	// TimeDef.g:67:37: ( WS )+
            		        	int cnt8 = 0;
            		        	do 
            		        	{
            		        	    int alt8 = 2;
            		        	    int LA8_0 = input.LA(1);

            		        	    if ( (LA8_0 == WS) )
            		        	    {
            		        	        alt8 = 1;
            		        	    }


            		        	    switch (alt8) 
            		        		{
            		        			case 1 :
            		        			    // TimeDef.g:0:0: WS
            		        			    {
            		        			    	WS15=(IToken)Match(input,WS,FOLLOW_WS_in_every_p221); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS15_tree = (object)adaptor.Create(WS15);
            		        			    		adaptor.AddChild(root_0, WS15_tree);
            		        			    	}

            		        			    }
            		        			    break;

            		        			default:
            		        			    if ( cnt8 >= 1 ) goto loop8;
            		        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        		            EarlyExitException eee8 =
            		        		                new EarlyExitException(8, input);
            		        		            throw eee8;
            		        	    }
            		        	    cnt8++;
            		        	} while (true);

            		        	loop8:
            		        		;	// Stops C# compiler whining that label 'loop8' has no statements

            		        	string_literal16=(IToken)Match(input,10,FOLLOW_10_in_every_p224); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal16_tree = (object)adaptor.Create(string_literal16);
            		        		adaptor.AddChild(root_0, string_literal16_tree);
            		        	}
            		        	// TimeDef.g:67:49: ( WS )+
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
            		        			    	WS17=(IToken)Match(input,WS,FOLLOW_WS_in_every_p226); if (state.failed) return retval;
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

            		        	PushFollow(FOLLOW_datetime_p_in_every_p231);
            		        	sync = datetime_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sync.Tree);

            		        }
            		        break;

            		}

            		// TimeDef.g:67:71: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            		int alt13 = 2;
            		alt13 = dfa13.Predict(input);
            		switch (alt13) 
            		{
            		    case 1 :
            		        // TimeDef.g:67:72: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
            		        {
            		        	// TimeDef.g:67:72: ( WS )+
            		        	int cnt11 = 0;
            		        	do 
            		        	{
            		        	    int alt11 = 2;
            		        	    int LA11_0 = input.LA(1);

            		        	    if ( (LA11_0 == WS) )
            		        	    {
            		        	        alt11 = 1;
            		        	    }


            		        	    switch (alt11) 
            		        		{
            		        			case 1 :
            		        			    // TimeDef.g:0:0: WS
            		        			    {
            		        			    	WS18=(IToken)Match(input,WS,FOLLOW_WS_in_every_p236); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS18_tree = (object)adaptor.Create(WS18);
            		        			    		adaptor.AddChild(root_0, WS18_tree);
            		        			    	}

            		        			    }
            		        			    break;

            		        			default:
            		        			    if ( cnt11 >= 1 ) goto loop11;
            		        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        		            EarlyExitException eee11 =
            		        		                new EarlyExitException(11, input);
            		        		            throw eee11;
            		        	    }
            		        	    cnt11++;
            		        	} while (true);

            		        	loop11:
            		        		;	// Stops C# compiler whining that label 'loop11' has no statements

            		        	string_literal19=(IToken)Match(input,7,FOLLOW_7_in_every_p239); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal19_tree = (object)adaptor.Create(string_literal19);
            		        		adaptor.AddChild(root_0, string_literal19_tree);
            		        	}
            		        	// TimeDef.g:67:86: ( WS )+
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
            		        			    	WS20=(IToken)Match(input,WS,FOLLOW_WS_in_every_p241); if (state.failed) return retval;
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

            		        	PushFollow(FOLLOW_timespan_p_in_every_p246);
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
    // TimeDef.g:70:1: cron_p returns [CronSchedule value] : ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) ;
    public TimeDefParser.cron_p_return cron_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_p_return retval = new TimeDefParser.cron_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal21 = null;
        IToken WS22 = null;
        IToken WS23 = null;
        IToken WS24 = null;
        IToken WS25 = null;
        IToken WS26 = null;
        IToken WS27 = null;
        IToken string_literal28 = null;
        IToken WS29 = null;
        TimeDefParser.cron_field_p_return minute = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.cron_field_p_return hour = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.cron_field_p_return day = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.cron_field_p_return month = default(TimeDefParser.cron_field_p_return);

        TimeDefParser.dow_cron_field_p_return dow = default(TimeDefParser.dow_cron_field_p_return);

        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        object string_literal21_tree=null;
        object WS22_tree=null;
        object WS23_tree=null;
        object WS24_tree=null;
        object WS25_tree=null;
        object WS26_tree=null;
        object WS27_tree=null;
        object string_literal28_tree=null;
        object WS29_tree=null;

        try 
    	{
            // TimeDef.g:70:36: ( ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? ) )
            // TimeDef.g:70:38: ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:70:38: ( 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )? )
            	// TimeDef.g:71:4: 'cron' ( WS )+ minute= cron_field_p ( WS )+ hour= cron_field_p ( WS )+ day= cron_field_p ( WS )+ month= cron_field_p ( WS )+ dow= dow_cron_field_p ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            	{
            		string_literal21=(IToken)Match(input,11,FOLLOW_11_in_cron_p268); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{string_literal21_tree = (object)adaptor.Create(string_literal21);
            			adaptor.AddChild(root_0, string_literal21_tree);
            		}
            		// TimeDef.g:71:11: ( WS )+
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
            				    	WS22=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p270); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p278);
            		minute = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, minute.Tree);
            		// TimeDef.g:72:24: ( WS )+
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
            				    	WS23=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p280); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p288);
            		hour = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, hour.Tree);
            		// TimeDef.g:73:22: ( WS )+
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
            				    	WS24=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p290); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p298);
            		day = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, day.Tree);
            		// TimeDef.g:74:21: ( WS )+
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
            				    	WS25=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p300); if (state.failed) return retval;
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

            		PushFollow(FOLLOW_cron_field_p_in_cron_p308);
            		month = cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, month.Tree);
            		// TimeDef.g:75:23: ( WS )+
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
            				    	WS26=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p310); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS26_tree = (object)adaptor.Create(WS26);
            				    		adaptor.AddChild(root_0, WS26_tree);
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

            		PushFollow(FOLLOW_dow_cron_field_p_in_cron_p318);
            		dow = dow_cron_field_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dow.Tree);
            		// TimeDef.g:77:4: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?
            		int alt21 = 2;
            		alt21 = dfa21.Predict(input);
            		switch (alt21) 
            		{
            		    case 1 :
            		        // TimeDef.g:77:5: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
            		        {
            		        	// TimeDef.g:77:5: ( WS )+
            		        	int cnt19 = 0;
            		        	do 
            		        	{
            		        	    int alt19 = 2;
            		        	    int LA19_0 = input.LA(1);

            		        	    if ( (LA19_0 == WS) )
            		        	    {
            		        	        alt19 = 1;
            		        	    }


            		        	    switch (alt19) 
            		        		{
            		        			case 1 :
            		        			    // TimeDef.g:0:0: WS
            		        			    {
            		        			    	WS27=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p324); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS27_tree = (object)adaptor.Create(WS27);
            		        			    		adaptor.AddChild(root_0, WS27_tree);
            		        			    	}

            		        			    }
            		        			    break;

            		        			default:
            		        			    if ( cnt19 >= 1 ) goto loop19;
            		        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		        		            EarlyExitException eee19 =
            		        		                new EarlyExitException(19, input);
            		        		            throw eee19;
            		        	    }
            		        	    cnt19++;
            		        	} while (true);

            		        	loop19:
            		        		;	// Stops C# compiler whining that label 'loop19' has no statements

            		        	string_literal28=(IToken)Match(input,7,FOLLOW_7_in_cron_p327); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{string_literal28_tree = (object)adaptor.Create(string_literal28);
            		        		adaptor.AddChild(root_0, string_literal28_tree);
            		        	}
            		        	// TimeDef.g:77:19: ( WS )+
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
            		        			    	WS29=(IToken)Match(input,WS,FOLLOW_WS_in_cron_p329); if (state.failed) return retval;
            		        			    	if ( state.backtracking == 0 )
            		        			    	{WS29_tree = (object)adaptor.Create(WS29);
            		        			    		adaptor.AddChild(root_0, WS29_tree);
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

            		        	PushFollow(FOLLOW_timespan_p_in_cron_p334);
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
    // TimeDef.g:80:1: void_p returns [VoidSchedule value] : 'void' ;
    public TimeDefParser.void_p_return void_p() // throws RecognitionException [1]
    {   
        TimeDefParser.void_p_return retval = new TimeDefParser.void_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal30 = null;

        object string_literal30_tree=null;

        try 
    	{
            // TimeDef.g:80:36: ( 'void' )
            // TimeDef.g:81:4: 'void'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal30=(IToken)Match(input,12,FOLLOW_12_in_void_p354); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal30_tree = (object)adaptor.Create(string_literal30);
            		adaptor.AddChild(root_0, string_literal30_tree);
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

        IToken char_literal31 = null;
        IToken char_literal33 = null;
        TimeDefParser.expr_return expr32 = default(TimeDefParser.expr_return);


        object char_literal31_tree=null;
        object char_literal33_tree=null;

        try 
    	{
            // TimeDef.g:83:34: ( ( '(' expr ')' ) )
            // TimeDef.g:83:36: ( '(' expr ')' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:83:36: ( '(' expr ')' )
            	// TimeDef.g:84:4: '(' expr ')'
            	{
            		char_literal31=(IToken)Match(input,13,FOLLOW_13_in_paren_p372); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal31_tree = (object)adaptor.Create(char_literal31);
            			adaptor.AddChild(root_0, char_literal31_tree);
            		}
            		PushFollow(FOLLOW_expr_in_paren_p374);
            		expr32 = expr();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr32.Tree);
            		char_literal33=(IToken)Match(input,14,FOLLOW_14_in_paren_p376); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal33_tree = (object)adaptor.Create(char_literal33);
            			adaptor.AddChild(root_0, char_literal33_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((expr32 != null) ? expr32.value : default(ISchedule)); 
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
        IToken WS34 = null;
        IToken char_literal35 = null;
        IToken WS36 = null;
        IToken WS37 = null;
        IToken char_literal38 = null;
        IToken WS39 = null;
        IToken WS40 = null;
        IToken WS41 = null;
        IToken WS42 = null;
        IToken string_literal43 = null;
        IToken WS44 = null;
        TimeDefParser.atom_return A = default(TimeDefParser.atom_return);

        TimeDefParser.intspec_p_return index_intspec = default(TimeDefParser.intspec_p_return);

        TimeDefParser.timespan_p_return offset_timespan = default(TimeDefParser.timespan_p_return);

        TimeDefParser.timespan_p_return lasting_timespan = default(TimeDefParser.timespan_p_return);


        object repeatcount_tree=null;
        object op_tree=null;
        object WS34_tree=null;
        object char_literal35_tree=null;
        object WS36_tree=null;
        object WS37_tree=null;
        object char_literal38_tree=null;
        object WS39_tree=null;
        object WS40_tree=null;
        object WS41_tree=null;
        object WS42_tree=null;
        object string_literal43_tree=null;
        object WS44_tree=null;

        try 
    	{
            // TimeDef.g:91:35: (A= atom ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )* )
            // TimeDef.g:92:4: A= atom ( ( ( WS )* '#' ( WS )* index_intspec= intspec_p ) | ( ( WS )* 'x' ( WS )* repeatcount= UINT ) | ( ( WS )* op= ( '+' | '-' ) ( WS )* offset_timespan= timespan_p ) | ( ( WS )+ 'lasting' ( WS )+ lasting_timespan= timespan_p ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_filter_p400);
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
            			    				    	WS34=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p413); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS34_tree = (object)adaptor.Create(WS34);
            			    				    		adaptor.AddChild(root_0, WS34_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop22;
            			    		    }
            			    		} while (true);

            			    		loop22:
            			    			;	// Stops C# compiler whining that label 'loop22' has no statements

            			    		char_literal35=(IToken)Match(input,15,FOLLOW_15_in_filter_p416); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal35_tree = (object)adaptor.Create(char_literal35);
            			    			adaptor.AddChild(root_0, char_literal35_tree);
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
            			    				    	WS36=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p418); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS36_tree = (object)adaptor.Create(WS36);
            			    				    		adaptor.AddChild(root_0, WS36_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop23;
            			    		    }
            			    		} while (true);

            			    		loop23:
            			    			;	// Stops C# compiler whining that label 'loop23' has no statements

            			    		PushFollow(FOLLOW_intspec_p_in_filter_p423);
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
            			    				    	WS37=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p438); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS37_tree = (object)adaptor.Create(WS37);
            			    				    		adaptor.AddChild(root_0, WS37_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop24;
            			    		    }
            			    		} while (true);

            			    		loop24:
            			    			;	// Stops C# compiler whining that label 'loop24' has no statements

            			    		char_literal38=(IToken)Match(input,16,FOLLOW_16_in_filter_p441); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal38_tree = (object)adaptor.Create(char_literal38);
            			    			adaptor.AddChild(root_0, char_literal38_tree);
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
            			    				    	WS39=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p443); if (state.failed) return retval;
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

            			    		repeatcount=(IToken)Match(input,UINT,FOLLOW_UINT_in_filter_p448); if (state.failed) return retval;
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
            			    				    	WS40=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p463); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS40_tree = (object)adaptor.Create(WS40);
            			    				    		adaptor.AddChild(root_0, WS40_tree);
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
            			    				    	WS41=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p474); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS41_tree = (object)adaptor.Create(WS41);
            			    				    		adaptor.AddChild(root_0, WS41_tree);
            			    				    	}

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop27;
            			    		    }
            			    		} while (true);

            			    		loop27:
            			    			;	// Stops C# compiler whining that label 'loop27' has no statements

            			    		PushFollow(FOLLOW_timespan_p_in_filter_p479);
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
            			    				    	WS42=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p494); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS42_tree = (object)adaptor.Create(WS42);
            			    				    		adaptor.AddChild(root_0, WS42_tree);
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

            			    		string_literal43=(IToken)Match(input,7,FOLLOW_7_in_filter_p497); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{string_literal43_tree = (object)adaptor.Create(string_literal43);
            			    			adaptor.AddChild(root_0, string_literal43_tree);
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
            			    				    	WS44=(IToken)Match(input,WS,FOLLOW_WS_in_filter_p499); if (state.failed) return retval;
            			    				    	if ( state.backtracking == 0 )
            			    				    	{WS44_tree = (object)adaptor.Create(WS44);
            			    				    		adaptor.AddChild(root_0, WS44_tree);
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

            			    		PushFollow(FOLLOW_timespan_p_in_filter_p504);
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

        IToken WS45 = null;
        IToken WS46 = null;
        IToken char_literal47 = null;
        IToken WS48 = null;
        IToken WS49 = null;
        TimeDefParser.boolnonintersection_p_return A = default(TimeDefParser.boolnonintersection_p_return);

        TimeDefParser.boolnonintersection_p_return B = default(TimeDefParser.boolnonintersection_p_return);


        object WS45_tree=null;
        object WS46_tree=null;
        object char_literal47_tree=null;
        object WS48_tree=null;
        object WS49_tree=null;


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
            				    	WS45=(IToken)Match(input,WS,FOLLOW_WS_in_expr538); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS45_tree = (object)adaptor.Create(WS45);
            				    		adaptor.AddChild(root_0, WS45_tree);
            				    	}

            				    }
            				    break;

            				default:
            				    goto loop31;
            		    }
            		} while (true);

            		loop31:
            			;	// Stops C# compiler whining that label 'loop31' has no statements

            		PushFollow(FOLLOW_boolnonintersection_p_in_expr543);
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
            				    			    	WS46=(IToken)Match(input,WS,FOLLOW_WS_in_expr551); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS46_tree = (object)adaptor.Create(WS46);
            				    			    		adaptor.AddChild(root_0, WS46_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop32;
            				    	    }
            				    	} while (true);

            				    	loop32:
            				    		;	// Stops C# compiler whining that label 'loop32' has no statements

            				    	char_literal47=(IToken)Match(input,19,FOLLOW_19_in_expr554); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{char_literal47_tree = (object)adaptor.Create(char_literal47);
            				    		adaptor.AddChild(root_0, char_literal47_tree);
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
            				    			    	WS48=(IToken)Match(input,WS,FOLLOW_WS_in_expr556); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS48_tree = (object)adaptor.Create(WS48);
            				    			    		adaptor.AddChild(root_0, WS48_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop33;
            				    	    }
            				    	} while (true);

            				    	loop33:
            				    		;	// Stops C# compiler whining that label 'loop33' has no statements

            				    	PushFollow(FOLLOW_boolnonintersection_p_in_expr561);
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
            				    	WS49=(IToken)Match(input,WS,FOLLOW_WS_in_expr568); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{WS49_tree = (object)adaptor.Create(WS49);
            				    		adaptor.AddChild(root_0, WS49_tree);
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

        IToken WS50 = null;
        IToken string_literal51 = null;
        IToken WS52 = null;
        TimeDefParser.boolintersection_p_return A = default(TimeDefParser.boolintersection_p_return);

        TimeDefParser.boolintersection_p_return B = default(TimeDefParser.boolintersection_p_return);


        object WS50_tree=null;
        object string_literal51_tree=null;
        object WS52_tree=null;

        try 
    	{
            // TimeDef.g:113:48: (A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )* )
            // TimeDef.g:114:4: A= boolintersection_p ( ( WS )* '!&&' ( WS )* B= boolintersection_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_boolintersection_p_in_boolnonintersection_p592);
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
            			    			    	WS50=(IToken)Match(input,WS,FOLLOW_WS_in_boolnonintersection_p600); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS50_tree = (object)adaptor.Create(WS50);
            			    			    		adaptor.AddChild(root_0, WS50_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop36;
            			    	    }
            			    	} while (true);

            			    	loop36:
            			    		;	// Stops C# compiler whining that label 'loop36' has no statements

            			    	string_literal51=(IToken)Match(input,20,FOLLOW_20_in_boolnonintersection_p603); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal51_tree = (object)adaptor.Create(string_literal51);
            			    		adaptor.AddChild(root_0, string_literal51_tree);
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
            			    			    	WS52=(IToken)Match(input,WS,FOLLOW_WS_in_boolnonintersection_p605); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS52_tree = (object)adaptor.Create(WS52);
            			    			    		adaptor.AddChild(root_0, WS52_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop37;
            			    	    }
            			    	} while (true);

            			    	loop37:
            			    		;	// Stops C# compiler whining that label 'loop37' has no statements

            			    	PushFollow(FOLLOW_boolintersection_p_in_boolnonintersection_p610);
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

        IToken WS53 = null;
        IToken string_literal54 = null;
        IToken WS55 = null;
        TimeDefParser.union_p_return A = default(TimeDefParser.union_p_return);

        TimeDefParser.union_p_return B = default(TimeDefParser.union_p_return);


        object WS53_tree=null;
        object string_literal54_tree=null;
        object WS55_tree=null;

        try 
    	{
            // TimeDef.g:121:45: (A= union_p ( ( WS )* '&&' ( WS )* B= union_p )* )
            // TimeDef.g:122:4: A= union_p ( ( WS )* '&&' ( WS )* B= union_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_union_p_in_boolintersection_p635);
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
            			    			    	WS53=(IToken)Match(input,WS,FOLLOW_WS_in_boolintersection_p643); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS53_tree = (object)adaptor.Create(WS53);
            			    			    		adaptor.AddChild(root_0, WS53_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop39;
            			    	    }
            			    	} while (true);

            			    	loop39:
            			    		;	// Stops C# compiler whining that label 'loop39' has no statements

            			    	string_literal54=(IToken)Match(input,21,FOLLOW_21_in_boolintersection_p646); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal54_tree = (object)adaptor.Create(string_literal54);
            			    		adaptor.AddChild(root_0, string_literal54_tree);
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
            			    			    	WS55=(IToken)Match(input,WS,FOLLOW_WS_in_boolintersection_p648); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS55_tree = (object)adaptor.Create(WS55);
            			    			    		adaptor.AddChild(root_0, WS55_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop40;
            			    	    }
            			    	} while (true);

            			    	loop40:
            			    		;	// Stops C# compiler whining that label 'loop40' has no statements

            			    	PushFollow(FOLLOW_union_p_in_boolintersection_p653);
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
    // TimeDef.g:129:1: union_p returns [ISchedule value] : (A= subtract_p ( ( WS )* '|' ( WS )* B= subtract_p )* ) ;
    public TimeDefParser.union_p_return union_p() // throws RecognitionException [1]
    {   
        TimeDefParser.union_p_return retval = new TimeDefParser.union_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS56 = null;
        IToken char_literal57 = null;
        IToken WS58 = null;
        TimeDefParser.subtract_p_return A = default(TimeDefParser.subtract_p_return);

        TimeDefParser.subtract_p_return B = default(TimeDefParser.subtract_p_return);


        object WS56_tree=null;
        object char_literal57_tree=null;
        object WS58_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:133:1: ( (A= subtract_p ( ( WS )* '|' ( WS )* B= subtract_p )* ) )
            // TimeDef.g:133:3: (A= subtract_p ( ( WS )* '|' ( WS )* B= subtract_p )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:133:3: (A= subtract_p ( ( WS )* '|' ( WS )* B= subtract_p )* )
            	// TimeDef.g:134:4: A= subtract_p ( ( WS )* '|' ( WS )* B= subtract_p )*
            	{
            		PushFollow(FOLLOW_subtract_p_in_union_p686);
            		A = subtract_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:135:4: ( ( WS )* '|' ( WS )* B= subtract_p )*
            		do 
            		{
            		    int alt44 = 2;
            		    alt44 = dfa44.Predict(input);
            		    switch (alt44) 
            			{
            				case 1 :
            				    // TimeDef.g:135:5: ( WS )* '|' ( WS )* B= subtract_p
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
            				    			    	WS56=(IToken)Match(input,WS,FOLLOW_WS_in_union_p694); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS56_tree = (object)adaptor.Create(WS56);
            				    			    		adaptor.AddChild(root_0, WS56_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop42;
            				    	    }
            				    	} while (true);

            				    	loop42:
            				    		;	// Stops C# compiler whining that label 'loop42' has no statements

            				    	char_literal57=(IToken)Match(input,22,FOLLOW_22_in_union_p697); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{char_literal57_tree = (object)adaptor.Create(char_literal57);
            				    		adaptor.AddChild(root_0, char_literal57_tree);
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
            				    			    	WS58=(IToken)Match(input,WS,FOLLOW_WS_in_union_p699); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS58_tree = (object)adaptor.Create(WS58);
            				    			    		adaptor.AddChild(root_0, WS58_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop43;
            				    	    }
            				    	} while (true);

            				    	loop43:
            				    		;	// Stops C# compiler whining that label 'loop43' has no statements

            				    	PushFollow(FOLLOW_subtract_p_in_union_p704);
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
    // TimeDef.g:141:1: subtract_p returns [ISchedule value] : A= difference_p ( ( WS )* '-' ( WS )* B= difference_p )* ;
    public TimeDefParser.subtract_p_return subtract_p() // throws RecognitionException [1]
    {   
        TimeDefParser.subtract_p_return retval = new TimeDefParser.subtract_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS59 = null;
        IToken char_literal60 = null;
        IToken WS61 = null;
        TimeDefParser.difference_p_return A = default(TimeDefParser.difference_p_return);

        TimeDefParser.difference_p_return B = default(TimeDefParser.difference_p_return);


        object WS59_tree=null;
        object char_literal60_tree=null;
        object WS61_tree=null;

        try 
    	{
            // TimeDef.g:141:37: (A= difference_p ( ( WS )* '-' ( WS )* B= difference_p )* )
            // TimeDef.g:142:4: A= difference_p ( ( WS )* '-' ( WS )* B= difference_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_difference_p_in_subtract_p732);
            	A = difference_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:143:4: ( ( WS )* '-' ( WS )* B= difference_p )*
            	do 
            	{
            	    int alt47 = 2;
            	    alt47 = dfa47.Predict(input);
            	    switch (alt47) 
            		{
            			case 1 :
            			    // TimeDef.g:143:5: ( WS )* '-' ( WS )* B= difference_p
            			    {
            			    	// TimeDef.g:143:5: ( WS )*
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
            			    			    	WS59=(IToken)Match(input,WS,FOLLOW_WS_in_subtract_p740); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS59_tree = (object)adaptor.Create(WS59);
            			    			    		adaptor.AddChild(root_0, WS59_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop45;
            			    	    }
            			    	} while (true);

            			    	loop45:
            			    		;	// Stops C# compiler whining that label 'loop45' has no statements

            			    	char_literal60=(IToken)Match(input,18,FOLLOW_18_in_subtract_p743); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal60_tree = (object)adaptor.Create(char_literal60);
            			    		adaptor.AddChild(root_0, char_literal60_tree);
            			    	}
            			    	// TimeDef.g:143:13: ( WS )*
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
            			    			    	WS61=(IToken)Match(input,WS,FOLLOW_WS_in_subtract_p745); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS61_tree = (object)adaptor.Create(WS61);
            			    			    		adaptor.AddChild(root_0, WS61_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop46;
            			    	    }
            			    	} while (true);

            			    	loop46:
            			    		;	// Stops C# compiler whining that label 'loop46' has no statements

            			    	PushFollow(FOLLOW_difference_p_in_subtract_p750);
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
            			    goto loop47;
            	    }
            	} while (true);

            	loop47:
            		;	// Stops C# compiler whining that label 'loop47' has no statements


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
    // TimeDef.g:149:1: difference_p returns [ISchedule value] : (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* ) ;
    public TimeDefParser.difference_p_return difference_p() // throws RecognitionException [1]
    {   
        TimeDefParser.difference_p_return retval = new TimeDefParser.difference_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS62 = null;
        IToken string_literal63 = null;
        IToken WS64 = null;
        TimeDefParser.intersection_p_return A = default(TimeDefParser.intersection_p_return);

        TimeDefParser.intersection_p_return B = default(TimeDefParser.intersection_p_return);


        object WS62_tree=null;
        object string_literal63_tree=null;
        object WS64_tree=null;


           List<ISchedule> Schedules = new List<ISchedule>();

        try 
    	{
            // TimeDef.g:153:1: ( (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* ) )
            // TimeDef.g:153:3: (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:153:3: (A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )* )
            	// TimeDef.g:154:4: A= intersection_p ( ( WS )* '!&' ( WS )* B= intersection_p )*
            	{
            		PushFollow(FOLLOW_intersection_p_in_difference_p783);
            		A = intersection_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            		if ( (state.backtracking==0) )
            		{
            		   Schedules.Add(((A != null) ? A.value : default(ISchedule))); 
            		}
            		// TimeDef.g:155:4: ( ( WS )* '!&' ( WS )* B= intersection_p )*
            		do 
            		{
            		    int alt50 = 2;
            		    alt50 = dfa50.Predict(input);
            		    switch (alt50) 
            			{
            				case 1 :
            				    // TimeDef.g:155:5: ( WS )* '!&' ( WS )* B= intersection_p
            				    {
            				    	// TimeDef.g:155:5: ( WS )*
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
            				    			    	WS62=(IToken)Match(input,WS,FOLLOW_WS_in_difference_p791); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS62_tree = (object)adaptor.Create(WS62);
            				    			    		adaptor.AddChild(root_0, WS62_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop48;
            				    	    }
            				    	} while (true);

            				    	loop48:
            				    		;	// Stops C# compiler whining that label 'loop48' has no statements

            				    	string_literal63=(IToken)Match(input,23,FOLLOW_23_in_difference_p794); if (state.failed) return retval;
            				    	if ( state.backtracking == 0 )
            				    	{string_literal63_tree = (object)adaptor.Create(string_literal63);
            				    		adaptor.AddChild(root_0, string_literal63_tree);
            				    	}
            				    	// TimeDef.g:155:14: ( WS )*
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
            				    			    	WS64=(IToken)Match(input,WS,FOLLOW_WS_in_difference_p796); if (state.failed) return retval;
            				    			    	if ( state.backtracking == 0 )
            				    			    	{WS64_tree = (object)adaptor.Create(WS64);
            				    			    		adaptor.AddChild(root_0, WS64_tree);
            				    			    	}

            				    			    }
            				    			    break;

            				    			default:
            				    			    goto loop49;
            				    	    }
            				    	} while (true);

            				    	loop49:
            				    		;	// Stops C# compiler whining that label 'loop49' has no statements

            				    	PushFollow(FOLLOW_intersection_p_in_difference_p801);
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
            				    goto loop50;
            		    }
            		} while (true);

            		loop50:
            			;	// Stops C# compiler whining that label 'loop50' has no statements


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
    // TimeDef.g:162:1: intersection_p returns [ISchedule value] : A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )* ;
    public TimeDefParser.intersection_p_return intersection_p() // throws RecognitionException [1]
    {   
        TimeDefParser.intersection_p_return retval = new TimeDefParser.intersection_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS65 = null;
        IToken char_literal66 = null;
        IToken WS67 = null;
        TimeDefParser.filter_p_return A = default(TimeDefParser.filter_p_return);

        TimeDefParser.filter_p_return B = default(TimeDefParser.filter_p_return);


        object WS65_tree=null;
        object char_literal66_tree=null;
        object WS67_tree=null;

        try 
    	{
            // TimeDef.g:162:41: (A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )* )
            // TimeDef.g:163:4: A= filter_p ( ( WS )* '&' ( WS )* B= filter_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_filter_p_in_intersection_p830);
            	A = filter_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, A.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((A != null) ? A.value : default(ISchedule)); 
            	}
            	// TimeDef.g:164:4: ( ( WS )* '&' ( WS )* B= filter_p )*
            	do 
            	{
            	    int alt53 = 2;
            	    alt53 = dfa53.Predict(input);
            	    switch (alt53) 
            		{
            			case 1 :
            			    // TimeDef.g:164:5: ( WS )* '&' ( WS )* B= filter_p
            			    {
            			    	// TimeDef.g:164:5: ( WS )*
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
            			    			    	WS65=(IToken)Match(input,WS,FOLLOW_WS_in_intersection_p838); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS65_tree = (object)adaptor.Create(WS65);
            			    			    		adaptor.AddChild(root_0, WS65_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop51;
            			    	    }
            			    	} while (true);

            			    	loop51:
            			    		;	// Stops C# compiler whining that label 'loop51' has no statements

            			    	char_literal66=(IToken)Match(input,24,FOLLOW_24_in_intersection_p841); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal66_tree = (object)adaptor.Create(char_literal66);
            			    		adaptor.AddChild(root_0, char_literal66_tree);
            			    	}
            			    	// TimeDef.g:164:13: ( WS )*
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
            			    			    	WS67=(IToken)Match(input,WS,FOLLOW_WS_in_intersection_p843); if (state.failed) return retval;
            			    			    	if ( state.backtracking == 0 )
            			    			    	{WS67_tree = (object)adaptor.Create(WS67);
            			    			    		adaptor.AddChild(root_0, WS67_tree);
            			    			    	}

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop52;
            			    	    }
            			    	} while (true);

            			    	loop52:
            			    		;	// Stops C# compiler whining that label 'loop52' has no statements

            			    	PushFollow(FOLLOW_filter_p_in_intersection_p848);
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
            			    goto loop53;
            	    }
            	} while (true);

            	loop53:
            		;	// Stops C# compiler whining that label 'loop53' has no statements


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
    // TimeDef.g:170:1: datetime_p returns [DateTime value] : (keyword= ( 'beginning' | 'end' ) | y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? ) ;
    public TimeDefParser.datetime_p_return datetime_p() // throws RecognitionException [1]
    {   
        TimeDefParser.datetime_p_return retval = new TimeDefParser.datetime_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken keyword = null;
        IToken char_literal68 = null;
        IToken char_literal69 = null;
        IToken WS70 = null;
        IToken char_literal71 = null;
        IToken char_literal72 = null;
        IToken char_literal73 = null;
        IToken char_literal74 = null;
        IToken char_literal75 = null;
        IToken char_literal76 = null;
        TimeDefParser.year_p_return y = default(TimeDefParser.year_p_return);

        TimeDefParser.month_p_return mo = default(TimeDefParser.month_p_return);

        TimeDefParser.day_p_return d = default(TimeDefParser.day_p_return);

        TimeDefParser.hour24_p_return h = default(TimeDefParser.hour24_p_return);

        TimeDefParser.minute60_p_return m = default(TimeDefParser.minute60_p_return);

        TimeDefParser.second60_p_return s = default(TimeDefParser.second60_p_return);

        TimeDefParser.millisecond1000_p_return ms = default(TimeDefParser.millisecond1000_p_return);


        object keyword_tree=null;
        object char_literal68_tree=null;
        object char_literal69_tree=null;
        object WS70_tree=null;
        object char_literal71_tree=null;
        object char_literal72_tree=null;
        object char_literal73_tree=null;
        object char_literal74_tree=null;
        object char_literal75_tree=null;
        object char_literal76_tree=null;

        try 
    	{
            // TimeDef.g:170:36: ( (keyword= ( 'beginning' | 'end' ) | y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? ) )
            // TimeDef.g:170:38: (keyword= ( 'beginning' | 'end' ) | y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:170:38: (keyword= ( 'beginning' | 'end' ) | y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )? | h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )
            	int alt60 = 3;
            	int LA60_0 = input.LA(1);

            	if ( ((LA60_0 >= 25 && LA60_0 <= 26)) )
            	{
            	    alt60 = 1;
            	}
            	else if ( (LA60_0 == UINT) )
            	{
            	    int LA60_2 = input.LA(2);

            	    if ( (LA60_2 == 18) )
            	    {
            	        alt60 = 2;
            	    }
            	    else if ( (LA60_2 == 27) )
            	    {
            	        alt60 = 3;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d60s2 =
            	            new NoViableAltException("", 60, 2, input);

            	        throw nvae_d60s2;
            	    }
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d60s0 =
            	        new NoViableAltException("", 60, 0, input);

            	    throw nvae_d60s0;
            	}
            	switch (alt60) 
            	{
            	    case 1 :
            	        // TimeDef.g:171:4: keyword= ( 'beginning' | 'end' )
            	        {
            	        	keyword = (IToken)input.LT(1);
            	        	if ( (input.LA(1) >= 25 && input.LA(1) <= 26) ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(keyword));
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
            	    case 2 :
            	        // TimeDef.g:172:4: y= year_p '-' mo= month_p '-' d= day_p ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?
            	        {
            	        	PushFollow(FOLLOW_year_p_in_datetime_p890);
            	        	y = year_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, y.Tree);
            	        	char_literal68=(IToken)Match(input,18,FOLLOW_18_in_datetime_p892); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal68_tree = (object)adaptor.Create(char_literal68);
            	        		adaptor.AddChild(root_0, char_literal68_tree);
            	        	}
            	        	PushFollow(FOLLOW_month_p_in_datetime_p896);
            	        	mo = month_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mo.Tree);
            	        	char_literal69=(IToken)Match(input,18,FOLLOW_18_in_datetime_p898); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal69_tree = (object)adaptor.Create(char_literal69);
            	        		adaptor.AddChild(root_0, char_literal69_tree);
            	        	}
            	        	PushFollow(FOLLOW_day_p_in_datetime_p902);
            	        	d = day_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, d.Tree);
            	        	// TimeDef.g:172:40: ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?
            	        	int alt57 = 2;
            	        	alt57 = dfa57.Predict(input);
            	        	switch (alt57) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:172:41: ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	        {
            	        	        	// TimeDef.g:172:41: ( WS )+
            	        	        	int cnt54 = 0;
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
            	        	        			    	WS70=(IToken)Match(input,WS,FOLLOW_WS_in_datetime_p905); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{WS70_tree = (object)adaptor.Create(WS70);
            	        	        			    		adaptor.AddChild(root_0, WS70_tree);
            	        	        			    	}

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    if ( cnt54 >= 1 ) goto loop54;
            	        	        			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	        		            EarlyExitException eee54 =
            	        	        		                new EarlyExitException(54, input);
            	        	        		            throw eee54;
            	        	        	    }
            	        	        	    cnt54++;
            	        	        	} while (true);

            	        	        	loop54:
            	        	        		;	// Stops C# compiler whining that label 'loop54' has no statements

            	        	        	PushFollow(FOLLOW_hour24_p_in_datetime_p910);
            	        	        	h = hour24_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            	        	        	char_literal71=(IToken)Match(input,27,FOLLOW_27_in_datetime_p912); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal71_tree = (object)adaptor.Create(char_literal71);
            	        	        		adaptor.AddChild(root_0, char_literal71_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_minute60_p_in_datetime_p916);
            	        	        	m = minute60_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            	        	        	// TimeDef.g:172:73: ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	        	int alt56 = 2;
            	        	        	int LA56_0 = input.LA(1);

            	        	        	if ( (LA56_0 == 27) )
            	        	        	{
            	        	        	    alt56 = 1;
            	        	        	}
            	        	        	switch (alt56) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // TimeDef.g:172:74: ':' s= second60_p ( '.' ms= millisecond1000_p )?
            	        	        	        {
            	        	        	        	char_literal72=(IToken)Match(input,27,FOLLOW_27_in_datetime_p919); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{char_literal72_tree = (object)adaptor.Create(char_literal72);
            	        	        	        		adaptor.AddChild(root_0, char_literal72_tree);
            	        	        	        	}
            	        	        	        	PushFollow(FOLLOW_second60_p_in_datetime_p923);
            	        	        	        	s = second60_p();
            	        	        	        	state.followingStackPointer--;
            	        	        	        	if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            	        	        	        	// TimeDef.g:172:91: ( '.' ms= millisecond1000_p )?
            	        	        	        	int alt55 = 2;
            	        	        	        	int LA55_0 = input.LA(1);

            	        	        	        	if ( (LA55_0 == 28) )
            	        	        	        	{
            	        	        	        	    alt55 = 1;
            	        	        	        	}
            	        	        	        	switch (alt55) 
            	        	        	        	{
            	        	        	        	    case 1 :
            	        	        	        	        // TimeDef.g:172:92: '.' ms= millisecond1000_p
            	        	        	        	        {
            	        	        	        	        	char_literal73=(IToken)Match(input,28,FOLLOW_28_in_datetime_p926); if (state.failed) return retval;
            	        	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	        	{char_literal73_tree = (object)adaptor.Create(char_literal73);
            	        	        	        	        		adaptor.AddChild(root_0, char_literal73_tree);
            	        	        	        	        	}
            	        	        	        	        	PushFollow(FOLLOW_millisecond1000_p_in_datetime_p930);
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
            	    case 3 :
            	        // TimeDef.g:173:4: h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        {
            	        	PushFollow(FOLLOW_hour24_p_in_datetime_p945);
            	        	h = hour24_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            	        	char_literal74=(IToken)Match(input,27,FOLLOW_27_in_datetime_p947); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal74_tree = (object)adaptor.Create(char_literal74);
            	        		adaptor.AddChild(root_0, char_literal74_tree);
            	        	}
            	        	PushFollow(FOLLOW_minute60_p_in_datetime_p951);
            	        	m = minute60_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            	        	// TimeDef.g:173:32: ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )?
            	        	int alt59 = 2;
            	        	int LA59_0 = input.LA(1);

            	        	if ( (LA59_0 == 27) )
            	        	{
            	        	    alt59 = 1;
            	        	}
            	        	switch (alt59) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:173:33: ':' s= second60_p ( '.' ms= millisecond1000_p )?
            	        	        {
            	        	        	char_literal75=(IToken)Match(input,27,FOLLOW_27_in_datetime_p954); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal75_tree = (object)adaptor.Create(char_literal75);
            	        	        		adaptor.AddChild(root_0, char_literal75_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_second60_p_in_datetime_p958);
            	        	        	s = second60_p();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            	        	        	// TimeDef.g:173:50: ( '.' ms= millisecond1000_p )?
            	        	        	int alt58 = 2;
            	        	        	int LA58_0 = input.LA(1);

            	        	        	if ( (LA58_0 == 28) )
            	        	        	{
            	        	        	    alt58 = 1;
            	        	        	}
            	        	        	switch (alt58) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // TimeDef.g:173:51: '.' ms= millisecond1000_p
            	        	        	        {
            	        	        	        	char_literal76=(IToken)Match(input,28,FOLLOW_28_in_datetime_p961); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{char_literal76_tree = (object)adaptor.Create(char_literal76);
            	        	        	        		adaptor.AddChild(root_0, char_literal76_tree);
            	        	        	        	}
            	        	        	        	PushFollow(FOLLOW_millisecond1000_p_in_datetime_p965);
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

            	     if (((keyword != null) ? keyword.Text : null) == "beginning") {
            	        retval.value =  DateTime.MinValue;
            	     }
            	     else if (((keyword != null) ? keyword.Text : null) == "end") {
            	        retval.value =  DateTime.MaxValue;
            	     }
            	     else {
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
    // TimeDef.g:193:1: datetime_prog returns [DateTime value] : ( datetime_p EOF ) ;
    public TimeDefParser.datetime_prog_return datetime_prog() // throws RecognitionException [1]
    {   
        TimeDefParser.datetime_prog_return retval = new TimeDefParser.datetime_prog_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF78 = null;
        TimeDefParser.datetime_p_return datetime_p77 = default(TimeDefParser.datetime_p_return);


        object EOF78_tree=null;

        try 
    	{
            // TimeDef.g:193:39: ( ( datetime_p EOF ) )
            // TimeDef.g:193:41: ( datetime_p EOF )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:193:41: ( datetime_p EOF )
            	// TimeDef.g:194:4: datetime_p EOF
            	{
            		PushFollow(FOLLOW_datetime_p_in_datetime_prog989);
            		datetime_p77 = datetime_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, datetime_p77.Tree);
            		EOF78=(IToken)Match(input,EOF,FOLLOW_EOF_in_datetime_prog991); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{EOF78_tree = (object)adaptor.Create(EOF78);
            			adaptor.AddChild(root_0, EOF78_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((datetime_p77 != null) ? datetime_p77.value : default(DateTime)); 
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
    // TimeDef.g:197:1: year_p returns [int value] : UINT ;
    public TimeDefParser.year_p_return year_p() // throws RecognitionException [1]
    {   
        TimeDefParser.year_p_return retval = new TimeDefParser.year_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT79 = null;

        object UINT79_tree=null;

        try 
    	{
            // TimeDef.g:197:27: ( UINT )
            // TimeDef.g:197:29: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT79=(IToken)Match(input,UINT,FOLLOW_UINT_in_year_p1006); if (state.failed) return retval;
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
    // TimeDef.g:198:1: month_p returns [int value] : UINT ;
    public TimeDefParser.month_p_return month_p() // throws RecognitionException [1]
    {   
        TimeDefParser.month_p_return retval = new TimeDefParser.month_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT80 = null;

        object UINT80_tree=null;

        try 
    	{
            // TimeDef.g:198:28: ( UINT )
            // TimeDef.g:198:30: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT80=(IToken)Match(input,UINT,FOLLOW_UINT_in_month_p1018); if (state.failed) return retval;
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
    // TimeDef.g:199:1: day_p returns [int value] : UINT ;
    public TimeDefParser.day_p_return day_p() // throws RecognitionException [1]
    {   
        TimeDefParser.day_p_return retval = new TimeDefParser.day_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT81 = null;

        object UINT81_tree=null;

        try 
    	{
            // TimeDef.g:199:26: ( UINT )
            // TimeDef.g:199:28: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT81=(IToken)Match(input,UINT,FOLLOW_UINT_in_day_p1030); if (state.failed) return retval;
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
    // TimeDef.g:200:1: hour24_p returns [int value] : UINT ;
    public TimeDefParser.hour24_p_return hour24_p() // throws RecognitionException [1]
    {   
        TimeDefParser.hour24_p_return retval = new TimeDefParser.hour24_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT82 = null;

        object UINT82_tree=null;

        try 
    	{
            // TimeDef.g:200:29: ( UINT )
            // TimeDef.g:200:31: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT82=(IToken)Match(input,UINT,FOLLOW_UINT_in_hour24_p1042); if (state.failed) return retval;
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
    // TimeDef.g:201:1: minute60_p returns [int value] : UINT ;
    public TimeDefParser.minute60_p_return minute60_p() // throws RecognitionException [1]
    {   
        TimeDefParser.minute60_p_return retval = new TimeDefParser.minute60_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT83 = null;

        object UINT83_tree=null;

        try 
    	{
            // TimeDef.g:201:31: ( UINT )
            // TimeDef.g:201:33: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT83=(IToken)Match(input,UINT,FOLLOW_UINT_in_minute60_p1054); if (state.failed) return retval;
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
    // TimeDef.g:202:1: second60_p returns [int value] : UINT ;
    public TimeDefParser.second60_p_return second60_p() // throws RecognitionException [1]
    {   
        TimeDefParser.second60_p_return retval = new TimeDefParser.second60_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT84 = null;

        object UINT84_tree=null;

        try 
    	{
            // TimeDef.g:202:31: ( UINT )
            // TimeDef.g:202:33: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT84=(IToken)Match(input,UINT,FOLLOW_UINT_in_second60_p1066); if (state.failed) return retval;
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
    // TimeDef.g:203:1: millisecond1000_p returns [int value] : UINT ;
    public TimeDefParser.millisecond1000_p_return millisecond1000_p() // throws RecognitionException [1]
    {   
        TimeDefParser.millisecond1000_p_return retval = new TimeDefParser.millisecond1000_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UINT85 = null;

        object UINT85_tree=null;

        try 
    	{
            // TimeDef.g:203:38: ( UINT )
            // TimeDef.g:203:40: UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UINT85=(IToken)Match(input,UINT,FOLLOW_UINT_in_millisecond1000_p1078); if (state.failed) return retval;
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
    // TimeDef.g:205:1: timespan_p returns [TimeSpan value] : ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? ) ;
    public TimeDefParser.timespan_p_return timespan_p() // throws RecognitionException [1]
    {   
        TimeDefParser.timespan_p_return retval = new TimeDefParser.timespan_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal86 = null;
        IToken char_literal87 = null;
        IToken char_literal88 = null;
        IToken char_literal89 = null;
        IToken char_literal90 = null;
        TimeDefParser.days_p_return d = default(TimeDefParser.days_p_return);

        TimeDefParser.hours_p_return h = default(TimeDefParser.hours_p_return);

        TimeDefParser.minutes_p_return m = default(TimeDefParser.minutes_p_return);

        TimeDefParser.seconds_p_return s = default(TimeDefParser.seconds_p_return);

        TimeDefParser.milliseconds_p_return ms = default(TimeDefParser.milliseconds_p_return);


        object char_literal86_tree=null;
        object char_literal87_tree=null;
        object char_literal88_tree=null;
        object char_literal89_tree=null;
        object char_literal90_tree=null;

        try 
    	{
            // TimeDef.g:205:36: ( ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? ) )
            // TimeDef.g:205:38: ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:205:38: ( 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )? )
            	// TimeDef.g:206:4: 'T' ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )? s= seconds_p ( '.' ms= milliseconds_p )?
            	{
            		char_literal86=(IToken)Match(input,29,FOLLOW_29_in_timespan_p1096); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{char_literal86_tree = (object)adaptor.Create(char_literal86);
            			adaptor.AddChild(root_0, char_literal86_tree);
            		}
            		// TimeDef.g:206:8: ( ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':' )?
            		int alt63 = 2;
            		int LA63_0 = input.LA(1);

            		if ( (LA63_0 == 18) )
            		{
            		    int LA63_1 = input.LA(2);

            		    if ( (LA63_1 == UINT) )
            		    {
            		        int LA63_2 = input.LA(3);

            		        if ( (LA63_2 == 27) )
            		        {
            		            alt63 = 1;
            		        }
            		        else if ( (LA63_2 == 28) )
            		        {
            		            int LA63_4 = input.LA(4);

            		            if ( (LA63_4 == 18) )
            		            {
            		                int LA63_6 = input.LA(5);

            		                if ( (LA63_6 == UINT) )
            		                {
            		                    int LA63_7 = input.LA(6);

            		                    if ( (LA63_7 == 27) )
            		                    {
            		                        alt63 = 1;
            		                    }
            		                }
            		            }
            		            else if ( (LA63_4 == UINT) )
            		            {
            		                int LA63_7 = input.LA(5);

            		                if ( (LA63_7 == 27) )
            		                {
            		                    alt63 = 1;
            		                }
            		            }
            		        }
            		    }
            		}
            		else if ( (LA63_0 == UINT) )
            		{
            		    int LA63_2 = input.LA(2);

            		    if ( (LA63_2 == 27) )
            		    {
            		        alt63 = 1;
            		    }
            		    else if ( (LA63_2 == 28) )
            		    {
            		        int LA63_4 = input.LA(3);

            		        if ( (LA63_4 == 18) )
            		        {
            		            int LA63_6 = input.LA(4);

            		            if ( (LA63_6 == UINT) )
            		            {
            		                int LA63_7 = input.LA(5);

            		                if ( (LA63_7 == 27) )
            		                {
            		                    alt63 = 1;
            		                }
            		            }
            		        }
            		        else if ( (LA63_4 == UINT) )
            		        {
            		            int LA63_7 = input.LA(4);

            		            if ( (LA63_7 == 27) )
            		            {
            		                alt63 = 1;
            		            }
            		        }
            		    }
            		}
            		switch (alt63) 
            		{
            		    case 1 :
            		        // TimeDef.g:206:9: ( (d= days_p '.' )? h= hours_p ':' )? m= minutes_p ':'
            		        {
            		        	// TimeDef.g:206:9: ( (d= days_p '.' )? h= hours_p ':' )?
            		        	int alt62 = 2;
            		        	int LA62_0 = input.LA(1);

            		        	if ( (LA62_0 == 18) )
            		        	{
            		        	    int LA62_1 = input.LA(2);

            		        	    if ( (LA62_1 == UINT) )
            		        	    {
            		        	        int LA62_2 = input.LA(3);

            		        	        if ( (LA62_2 == 27) )
            		        	        {
            		        	            int LA62_3 = input.LA(4);

            		        	            if ( (LA62_3 == 18) )
            		        	            {
            		        	                int LA62_5 = input.LA(5);

            		        	                if ( (LA62_5 == UINT) )
            		        	                {
            		        	                    int LA62_6 = input.LA(6);

            		        	                    if ( (LA62_6 == 27) )
            		        	                    {
            		        	                        alt62 = 1;
            		        	                    }
            		        	                }
            		        	            }
            		        	            else if ( (LA62_3 == UINT) )
            		        	            {
            		        	                int LA62_6 = input.LA(5);

            		        	                if ( (LA62_6 == 27) )
            		        	                {
            		        	                    alt62 = 1;
            		        	                }
            		        	            }
            		        	        }
            		        	        else if ( (LA62_2 == 28) )
            		        	        {
            		        	            alt62 = 1;
            		        	        }
            		        	    }
            		        	}
            		        	else if ( (LA62_0 == UINT) )
            		        	{
            		        	    int LA62_2 = input.LA(2);

            		        	    if ( (LA62_2 == 27) )
            		        	    {
            		        	        int LA62_3 = input.LA(3);

            		        	        if ( (LA62_3 == 18) )
            		        	        {
            		        	            int LA62_5 = input.LA(4);

            		        	            if ( (LA62_5 == UINT) )
            		        	            {
            		        	                int LA62_6 = input.LA(5);

            		        	                if ( (LA62_6 == 27) )
            		        	                {
            		        	                    alt62 = 1;
            		        	                }
            		        	            }
            		        	        }
            		        	        else if ( (LA62_3 == UINT) )
            		        	        {
            		        	            int LA62_6 = input.LA(4);

            		        	            if ( (LA62_6 == 27) )
            		        	            {
            		        	                alt62 = 1;
            		        	            }
            		        	        }
            		        	    }
            		        	    else if ( (LA62_2 == 28) )
            		        	    {
            		        	        alt62 = 1;
            		        	    }
            		        	}
            		        	switch (alt62) 
            		        	{
            		        	    case 1 :
            		        	        // TimeDef.g:206:10: (d= days_p '.' )? h= hours_p ':'
            		        	        {
            		        	        	// TimeDef.g:206:10: (d= days_p '.' )?
            		        	        	int alt61 = 2;
            		        	        	int LA61_0 = input.LA(1);

            		        	        	if ( (LA61_0 == 18) )
            		        	        	{
            		        	        	    int LA61_1 = input.LA(2);

            		        	        	    if ( (LA61_1 == UINT) )
            		        	        	    {
            		        	        	        int LA61_2 = input.LA(3);

            		        	        	        if ( (LA61_2 == 28) )
            		        	        	        {
            		        	        	            alt61 = 1;
            		        	        	        }
            		        	        	    }
            		        	        	}
            		        	        	else if ( (LA61_0 == UINT) )
            		        	        	{
            		        	        	    int LA61_2 = input.LA(2);

            		        	        	    if ( (LA61_2 == 28) )
            		        	        	    {
            		        	        	        alt61 = 1;
            		        	        	    }
            		        	        	}
            		        	        	switch (alt61) 
            		        	        	{
            		        	        	    case 1 :
            		        	        	        // TimeDef.g:206:11: d= days_p '.'
            		        	        	        {
            		        	        	        	PushFollow(FOLLOW_days_p_in_timespan_p1103);
            		        	        	        	d = days_p();
            		        	        	        	state.followingStackPointer--;
            		        	        	        	if (state.failed) return retval;
            		        	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, d.Tree);
            		        	        	        	char_literal87=(IToken)Match(input,28,FOLLOW_28_in_timespan_p1105); if (state.failed) return retval;
            		        	        	        	if ( state.backtracking == 0 )
            		        	        	        	{char_literal87_tree = (object)adaptor.Create(char_literal87);
            		        	        	        		adaptor.AddChild(root_0, char_literal87_tree);
            		        	        	        	}

            		        	        	        }
            		        	        	        break;

            		        	        	}

            		        	        	PushFollow(FOLLOW_hours_p_in_timespan_p1111);
            		        	        	h = hours_p();
            		        	        	state.followingStackPointer--;
            		        	        	if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, h.Tree);
            		        	        	char_literal88=(IToken)Match(input,27,FOLLOW_27_in_timespan_p1113); if (state.failed) return retval;
            		        	        	if ( state.backtracking == 0 )
            		        	        	{char_literal88_tree = (object)adaptor.Create(char_literal88);
            		        	        		adaptor.AddChild(root_0, char_literal88_tree);
            		        	        	}

            		        	        }
            		        	        break;

            		        	}

            		        	PushFollow(FOLLOW_minutes_p_in_timespan_p1119);
            		        	m = minutes_p();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, m.Tree);
            		        	char_literal89=(IToken)Match(input,27,FOLLOW_27_in_timespan_p1121); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{char_literal89_tree = (object)adaptor.Create(char_literal89);
            		        		adaptor.AddChild(root_0, char_literal89_tree);
            		        	}

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_seconds_p_in_timespan_p1127);
            		s = seconds_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, s.Tree);
            		// TimeDef.g:206:72: ( '.' ms= milliseconds_p )?
            		int alt64 = 2;
            		int LA64_0 = input.LA(1);

            		if ( (LA64_0 == 28) )
            		{
            		    alt64 = 1;
            		}
            		switch (alt64) 
            		{
            		    case 1 :
            		        // TimeDef.g:206:73: '.' ms= milliseconds_p
            		        {
            		        	char_literal90=(IToken)Match(input,28,FOLLOW_28_in_timespan_p1130); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{char_literal90_tree = (object)adaptor.Create(char_literal90);
            		        		adaptor.AddChild(root_0, char_literal90_tree);
            		        	}
            		        	PushFollow(FOLLOW_milliseconds_p_in_timespan_p1134);
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
    // TimeDef.g:216:1: timespan_prog returns [TimeSpan value] : ( timespan_p EOF ) ;
    public TimeDefParser.timespan_prog_return timespan_prog() // throws RecognitionException [1]
    {   
        TimeDefParser.timespan_prog_return retval = new TimeDefParser.timespan_prog_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF92 = null;
        TimeDefParser.timespan_p_return timespan_p91 = default(TimeDefParser.timespan_p_return);


        object EOF92_tree=null;

        try 
    	{
            // TimeDef.g:216:39: ( ( timespan_p EOF ) )
            // TimeDef.g:216:41: ( timespan_p EOF )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:216:41: ( timespan_p EOF )
            	// TimeDef.g:217:4: timespan_p EOF
            	{
            		PushFollow(FOLLOW_timespan_p_in_timespan_prog1156);
            		timespan_p91 = timespan_p();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, timespan_p91.Tree);
            		EOF92=(IToken)Match(input,EOF,FOLLOW_EOF_in_timespan_prog1158); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{EOF92_tree = (object)adaptor.Create(EOF92);
            			adaptor.AddChild(root_0, EOF92_tree);
            		}

            	}

            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  ((timespan_p91 != null) ? timespan_p91.value : default(TimeSpan)); 
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
    // TimeDef.g:220:1: days_p returns [int value] : int_p ;
    public TimeDefParser.days_p_return days_p() // throws RecognitionException [1]
    {   
        TimeDefParser.days_p_return retval = new TimeDefParser.days_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p93 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:220:27: ( int_p )
            // TimeDef.g:220:29: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_days_p1173);
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
    // TimeDef.g:221:1: hours_p returns [int value] : int_p ;
    public TimeDefParser.hours_p_return hours_p() // throws RecognitionException [1]
    {   
        TimeDefParser.hours_p_return retval = new TimeDefParser.hours_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p94 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:221:28: ( int_p )
            // TimeDef.g:221:30: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_hours_p1185);
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
    // TimeDef.g:222:1: minutes_p returns [int value] : int_p ;
    public TimeDefParser.minutes_p_return minutes_p() // throws RecognitionException [1]
    {   
        TimeDefParser.minutes_p_return retval = new TimeDefParser.minutes_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p95 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:222:30: ( int_p )
            // TimeDef.g:222:32: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_minutes_p1197);
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
    // TimeDef.g:223:1: seconds_p returns [int value] : int_p ;
    public TimeDefParser.seconds_p_return seconds_p() // throws RecognitionException [1]
    {   
        TimeDefParser.seconds_p_return retval = new TimeDefParser.seconds_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p96 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:223:30: ( int_p )
            // TimeDef.g:223:32: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_seconds_p1209);
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
    // TimeDef.g:224:1: milliseconds_p returns [int value] : int_p ;
    public TimeDefParser.milliseconds_p_return milliseconds_p() // throws RecognitionException [1]
    {   
        TimeDefParser.milliseconds_p_return retval = new TimeDefParser.milliseconds_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        TimeDefParser.int_p_return int_p97 = default(TimeDefParser.int_p_return);



        try 
    	{
            // TimeDef.g:224:35: ( int_p )
            // TimeDef.g:224:37: int_p
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_p_in_milliseconds_p1221);
            	int_p97 = int_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p97.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   retval.value =  int.Parse(((int_p97 != null) ? input.ToString((IToken)(int_p97.Start),(IToken)(int_p97.Stop)) : null)); 
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
    // TimeDef.g:226:1: cron_field_p : cron_term_p ( ',' cron_term_p )* ;
    public TimeDefParser.cron_field_p_return cron_field_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_field_p_return retval = new TimeDefParser.cron_field_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal99 = null;
        TimeDefParser.cron_term_p_return cron_term_p98 = default(TimeDefParser.cron_term_p_return);

        TimeDefParser.cron_term_p_return cron_term_p100 = default(TimeDefParser.cron_term_p_return);


        object char_literal99_tree=null;

        try 
    	{
            // TimeDef.g:226:13: ( cron_term_p ( ',' cron_term_p )* )
            // TimeDef.g:226:15: cron_term_p ( ',' cron_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_cron_term_p_in_cron_field_p1230);
            	cron_term_p98 = cron_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cron_term_p98.Tree);
            	// TimeDef.g:226:27: ( ',' cron_term_p )*
            	do 
            	{
            	    int alt65 = 2;
            	    int LA65_0 = input.LA(1);

            	    if ( (LA65_0 == 19) )
            	    {
            	        alt65 = 1;
            	    }


            	    switch (alt65) 
            		{
            			case 1 :
            			    // TimeDef.g:226:28: ',' cron_term_p
            			    {
            			    	char_literal99=(IToken)Match(input,19,FOLLOW_19_in_cron_field_p1233); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal99_tree = (object)adaptor.Create(char_literal99);
            			    		adaptor.AddChild(root_0, char_literal99_tree);
            			    	}
            			    	PushFollow(FOLLOW_cron_term_p_in_cron_field_p1235);
            			    	cron_term_p100 = cron_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cron_term_p100.Tree);

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
    // TimeDef.g:227:1: cron_term_p : ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+ ;
    public TimeDefParser.cron_term_p_return cron_term_p() // throws RecognitionException [1]
    {   
        TimeDefParser.cron_term_p_return retval = new TimeDefParser.cron_term_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal101 = null;
        IToken set102 = null;

        object char_literal101_tree=null;
        object set102_tree=null;

        try 
    	{
            // TimeDef.g:227:12: ( ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+ )
            // TimeDef.g:227:14: ( '!' )? ( UINT | '/' | '-' | '*' | '>' | '<' )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:227:14: ( '!' )?
            	int alt66 = 2;
            	int LA66_0 = input.LA(1);

            	if ( (LA66_0 == 30) )
            	{
            	    alt66 = 1;
            	}
            	switch (alt66) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '!'
            	        {
            	        	char_literal101=(IToken)Match(input,30,FOLLOW_30_in_cron_term_p1243); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal101_tree = (object)adaptor.Create(char_literal101);
            	        		adaptor.AddChild(root_0, char_literal101_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:227:19: ( UINT | '/' | '-' | '*' | '>' | '<' )+
            	int cnt67 = 0;
            	do 
            	{
            	    int alt67 = 2;
            	    int LA67_0 = input.LA(1);

            	    if ( (LA67_0 == UINT || LA67_0 == 18 || (LA67_0 >= 31 && LA67_0 <= 34)) )
            	    {
            	        alt67 = 1;
            	    }


            	    switch (alt67) 
            		{
            			case 1 :
            			    // TimeDef.g:
            			    {
            			    	set102 = (IToken)input.LT(1);
            			    	if ( input.LA(1) == UINT || input.LA(1) == 18 || (input.LA(1) >= 31 && input.LA(1) <= 34) ) 
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
            			    if ( cnt67 >= 1 ) goto loop67;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee67 =
            		                new EarlyExitException(67, input);
            		            throw eee67;
            	    }
            	    cnt67++;
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
    // TimeDef.g:229:1: dow_cron_field_p : dow_cron_term_p ( ',' dow_cron_term_p )* ;
    public TimeDefParser.dow_cron_field_p_return dow_cron_field_p() // throws RecognitionException [1]
    {   
        TimeDefParser.dow_cron_field_p_return retval = new TimeDefParser.dow_cron_field_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal104 = null;
        TimeDefParser.dow_cron_term_p_return dow_cron_term_p103 = default(TimeDefParser.dow_cron_term_p_return);

        TimeDefParser.dow_cron_term_p_return dow_cron_term_p105 = default(TimeDefParser.dow_cron_term_p_return);


        object char_literal104_tree=null;

        try 
    	{
            // TimeDef.g:229:17: ( dow_cron_term_p ( ',' dow_cron_term_p )* )
            // TimeDef.g:229:19: dow_cron_term_p ( ',' dow_cron_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_dow_cron_term_p_in_dow_cron_field_p1276);
            	dow_cron_term_p103 = dow_cron_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dow_cron_term_p103.Tree);
            	// TimeDef.g:229:35: ( ',' dow_cron_term_p )*
            	do 
            	{
            	    int alt68 = 2;
            	    int LA68_0 = input.LA(1);

            	    if ( (LA68_0 == 19) )
            	    {
            	        int LA68_2 = input.LA(2);

            	        if ( (LA68_2 == UINT) )
            	        {
            	            int LA68_3 = input.LA(3);

            	            if ( (LA68_3 == 18) )
            	            {
            	                int LA68_5 = input.LA(4);

            	                if ( (LA68_5 == UINT) )
            	                {
            	                    int LA68_6 = input.LA(5);

            	                    if ( (LA68_6 == EOF || (LA68_6 >= WS && LA68_6 <= ALPHA) || (LA68_6 >= 14 && LA68_6 <= 17) || (LA68_6 >= 19 && LA68_6 <= 24) || LA68_6 == 27 || (LA68_6 >= 31 && LA68_6 <= 34)) )
            	                    {
            	                        alt68 = 1;
            	                    }
            	                    else if ( (LA68_6 == 18) )
            	                    {
            	                        int LA68_7 = input.LA(6);

            	                        if ( (LA68_7 == EOF || LA68_7 == WS || LA68_7 == ALPHA || LA68_7 == 9 || (LA68_7 >= 11 && LA68_7 <= 26) || LA68_7 == 29 || (LA68_7 >= 31 && LA68_7 <= 34)) )
            	                        {
            	                            alt68 = 1;
            	                        }
            	                        else if ( (LA68_7 == UINT) )
            	                        {
            	                            int LA68_8 = input.LA(7);

            	                            if ( (synpred82_TimeDef()) )
            	                            {
            	                                alt68 = 1;
            	                            }


            	                        }


            	                    }


            	                }
            	                else if ( (LA68_5 == EOF || LA68_5 == WS || LA68_5 == ALPHA || LA68_5 == 9 || (LA68_5 >= 11 && LA68_5 <= 26) || LA68_5 == 29 || (LA68_5 >= 31 && LA68_5 <= 34)) )
            	                {
            	                    alt68 = 1;
            	                }


            	            }
            	            else if ( (LA68_3 == EOF || (LA68_3 >= WS && LA68_3 <= ALPHA) || (LA68_3 >= 14 && LA68_3 <= 17) || (LA68_3 >= 19 && LA68_3 <= 24) || (LA68_3 >= 31 && LA68_3 <= 34)) )
            	            {
            	                alt68 = 1;
            	            }


            	        }
            	        else if ( (LA68_2 == ALPHA || LA68_2 == 15 || LA68_2 == 18 || (LA68_2 >= 30 && LA68_2 <= 34)) )
            	        {
            	            alt68 = 1;
            	        }


            	    }


            	    switch (alt68) 
            		{
            			case 1 :
            			    // TimeDef.g:229:36: ',' dow_cron_term_p
            			    {
            			    	char_literal104=(IToken)Match(input,19,FOLLOW_19_in_dow_cron_field_p1279); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal104_tree = (object)adaptor.Create(char_literal104);
            			    		adaptor.AddChild(root_0, char_literal104_tree);
            			    	}
            			    	PushFollow(FOLLOW_dow_cron_term_p_in_dow_cron_field_p1281);
            			    	dow_cron_term_p105 = dow_cron_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dow_cron_term_p105.Tree);

            			    }
            			    break;

            			default:
            			    goto loop68;
            	    }
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
    // TimeDef.g:230:1: dow_cron_term_p : ( '!' )? ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+ ;
    public TimeDefParser.dow_cron_term_p_return dow_cron_term_p() // throws RecognitionException [1]
    {   
        TimeDefParser.dow_cron_term_p_return retval = new TimeDefParser.dow_cron_term_p_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal106 = null;
        IToken set107 = null;

        object char_literal106_tree=null;
        object set107_tree=null;

        try 
    	{
            // TimeDef.g:230:16: ( ( '!' )? ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+ )
            // TimeDef.g:230:18: ( '!' )? ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:230:18: ( '!' )?
            	int alt69 = 2;
            	int LA69_0 = input.LA(1);

            	if ( (LA69_0 == 30) )
            	{
            	    alt69 = 1;
            	}
            	switch (alt69) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '!'
            	        {
            	        	char_literal106=(IToken)Match(input,30,FOLLOW_30_in_dow_cron_term_p1289); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal106_tree = (object)adaptor.Create(char_literal106);
            	        		adaptor.AddChild(root_0, char_literal106_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:230:23: ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+
            	int cnt70 = 0;
            	do 
            	{
            	    int alt70 = 2;
            	    alt70 = dfa70.Predict(input);
            	    switch (alt70) 
            		{
            			case 1 :
            			    // TimeDef.g:
            			    {
            			    	set107 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= UINT && input.LA(1) <= ALPHA) || input.LA(1) == 15 || input.LA(1) == 18 || (input.LA(1) >= 31 && input.LA(1) <= 34) ) 
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
            			    if ( cnt70 >= 1 ) goto loop70;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee70 =
            		                new EarlyExitException(70, input);
            		            throw eee70;
            	    }
            	    cnt70++;
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
    // TimeDef.g:232:1: intspec_p : intspec_term_p ( ',' intspec_term_p )* ;
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
            // TimeDef.g:232:10: ( intspec_term_p ( ',' intspec_term_p )* )
            // TimeDef.g:232:12: intspec_term_p ( ',' intspec_term_p )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_intspec_term_p_in_intspec_p1330);
            	intspec_term_p108 = intspec_term_p();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intspec_term_p108.Tree);
            	// TimeDef.g:232:27: ( ',' intspec_term_p )*
            	do 
            	{
            	    int alt71 = 2;
            	    alt71 = dfa71.Predict(input);
            	    switch (alt71) 
            		{
            			case 1 :
            			    // TimeDef.g:232:28: ',' intspec_term_p
            			    {
            			    	char_literal109=(IToken)Match(input,19,FOLLOW_19_in_intspec_p1333); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal109_tree = (object)adaptor.Create(char_literal109);
            			    		adaptor.AddChild(root_0, char_literal109_tree);
            			    	}
            			    	PushFollow(FOLLOW_intspec_term_p_in_intspec_p1335);
            			    	intspec_term_p110 = intspec_term_p();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intspec_term_p110.Tree);

            			    }
            			    break;

            			default:
            			    goto loop71;
            	    }
            	} while (true);

            	loop71:
            		;	// Stops C# compiler whining that label 'loop71' has no statements


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
    // TimeDef.g:233:1: intspec_term_p : ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )? ;
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
            // TimeDef.g:233:15: ( ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )? )
            // TimeDef.g:233:17: ( '!' )? ( '*' | int_p ( '-' int_p )? ) ( '/' UINT )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:233:17: ( '!' )?
            	int alt72 = 2;
            	int LA72_0 = input.LA(1);

            	if ( (LA72_0 == 30) )
            	{
            	    alt72 = 1;
            	}
            	switch (alt72) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '!'
            	        {
            	        	char_literal111=(IToken)Match(input,30,FOLLOW_30_in_intspec_term_p1343); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal111_tree = (object)adaptor.Create(char_literal111);
            	        		adaptor.AddChild(root_0, char_literal111_tree);
            	        	}

            	        }
            	        break;

            	}

            	// TimeDef.g:233:22: ( '*' | int_p ( '-' int_p )? )
            	int alt74 = 2;
            	int LA74_0 = input.LA(1);

            	if ( (LA74_0 == 32) )
            	{
            	    alt74 = 1;
            	}
            	else if ( (LA74_0 == UINT || LA74_0 == 18) )
            	{
            	    alt74 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d74s0 =
            	        new NoViableAltException("", 74, 0, input);

            	    throw nvae_d74s0;
            	}
            	switch (alt74) 
            	{
            	    case 1 :
            	        // TimeDef.g:233:24: '*'
            	        {
            	        	char_literal112=(IToken)Match(input,32,FOLLOW_32_in_intspec_term_p1348); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal112_tree = (object)adaptor.Create(char_literal112);
            	        		adaptor.AddChild(root_0, char_literal112_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // TimeDef.g:233:30: int_p ( '-' int_p )?
            	        {
            	        	PushFollow(FOLLOW_int_p_in_intspec_term_p1352);
            	        	int_p113 = int_p();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, int_p113.Tree);
            	        	// TimeDef.g:233:36: ( '-' int_p )?
            	        	int alt73 = 2;
            	        	alt73 = dfa73.Predict(input);
            	        	switch (alt73) 
            	        	{
            	        	    case 1 :
            	        	        // TimeDef.g:233:38: '-' int_p
            	        	        {
            	        	        	char_literal114=(IToken)Match(input,18,FOLLOW_18_in_intspec_term_p1356); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal114_tree = (object)adaptor.Create(char_literal114);
            	        	        		adaptor.AddChild(root_0, char_literal114_tree);
            	        	        	}
            	        	        	PushFollow(FOLLOW_int_p_in_intspec_term_p1358);
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

            	// TimeDef.g:233:53: ( '/' UINT )?
            	int alt75 = 2;
            	int LA75_0 = input.LA(1);

            	if ( (LA75_0 == 31) )
            	{
            	    alt75 = 1;
            	}
            	switch (alt75) 
            	{
            	    case 1 :
            	        // TimeDef.g:233:55: '/' UINT
            	        {
            	        	char_literal116=(IToken)Match(input,31,FOLLOW_31_in_intspec_term_p1367); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal116_tree = (object)adaptor.Create(char_literal116);
            	        		adaptor.AddChild(root_0, char_literal116_tree);
            	        	}
            	        	UINT117=(IToken)Match(input,UINT,FOLLOW_UINT_in_intspec_term_p1369); if (state.failed) return retval;
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
    // TimeDef.g:238:1: int_p : ( '-' )? UINT ;
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
            // TimeDef.g:238:6: ( ( '-' )? UINT )
            // TimeDef.g:238:8: ( '-' )? UINT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// TimeDef.g:238:8: ( '-' )?
            	int alt76 = 2;
            	int LA76_0 = input.LA(1);

            	if ( (LA76_0 == 18) )
            	{
            	    alt76 = 1;
            	}
            	switch (alt76) 
            	{
            	    case 1 :
            	        // TimeDef.g:0:0: '-'
            	        {
            	        	char_literal118=(IToken)Match(input,18,FOLLOW_18_in_int_p1382); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal118_tree = (object)adaptor.Create(char_literal118);
            	        		adaptor.AddChild(root_0, char_literal118_tree);
            	        	}

            	        }
            	        break;

            	}

            	UINT119=(IToken)Match(input,UINT,FOLLOW_UINT_in_int_p1385); if (state.failed) return retval;
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

    // $ANTLR start "synpred9_TimeDef"
    public void synpred9_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);

        TimeDefParser.datetime_p_return enddatetime = default(TimeDefParser.datetime_p_return);


        // TimeDef.g:59:22: ( ( WS )+ ( 'lasting' ( WS )+ duration= timespan_p | 'to' ( WS )+ enddatetime= datetime_p ) )
        // TimeDef.g:59:22: ( WS )+ ( 'lasting' ( WS )+ duration= timespan_p | 'to' ( WS )+ enddatetime= datetime_p )
        {
        	// TimeDef.g:59:22: ( WS )+
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
        			    	Match(input,WS,FOLLOW_WS_in_synpred9_TimeDef166); if (state.failed) return ;

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

        	// TimeDef.g:59:26: ( 'lasting' ( WS )+ duration= timespan_p | 'to' ( WS )+ enddatetime= datetime_p )
        	int alt81 = 2;
        	int LA81_0 = input.LA(1);

        	if ( (LA81_0 == 7) )
        	{
        	    alt81 = 1;
        	}
        	else if ( (LA81_0 == 8) )
        	{
        	    alt81 = 2;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    NoViableAltException nvae_d81s0 =
        	        new NoViableAltException("", 81, 0, input);

        	    throw nvae_d81s0;
        	}
        	switch (alt81) 
        	{
        	    case 1 :
        	        // TimeDef.g:59:27: 'lasting' ( WS )+ duration= timespan_p
        	        {
        	        	Match(input,7,FOLLOW_7_in_synpred9_TimeDef170); if (state.failed) return ;
        	        	// TimeDef.g:59:37: ( WS )+
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
        	        			    	Match(input,WS,FOLLOW_WS_in_synpred9_TimeDef172); if (state.failed) return ;

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

        	        	PushFollow(FOLLOW_timespan_p_in_synpred9_TimeDef177);
        	        	duration = timespan_p();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;
        	    case 2 :
        	        // TimeDef.g:59:63: 'to' ( WS )+ enddatetime= datetime_p
        	        {
        	        	Match(input,8,FOLLOW_8_in_synpred9_TimeDef181); if (state.failed) return ;
        	        	// TimeDef.g:59:68: ( WS )+
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
        	        			    	Match(input,WS,FOLLOW_WS_in_synpred9_TimeDef183); if (state.failed) return ;

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

        	        	PushFollow(FOLLOW_datetime_p_in_synpred9_TimeDef188);
        	        	enddatetime = datetime_p();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred9_TimeDef"

    // $ANTLR start "synpred16_TimeDef"
    public void synpred16_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        // TimeDef.g:67:72: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:67:72: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:67:72: ( WS )+
        	int cnt84 = 0;
        	do 
        	{
        	    int alt84 = 2;
        	    int LA84_0 = input.LA(1);

        	    if ( (LA84_0 == WS) )
        	    {
        	        alt84 = 1;
        	    }


        	    switch (alt84) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred16_TimeDef236); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt84 >= 1 ) goto loop84;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee84 =
        		                new EarlyExitException(84, input);
        		            throw eee84;
        	    }
        	    cnt84++;
        	} while (true);

        	loop84:
        		;	// Stops C# compiler whining that label 'loop84' has no statements

        	Match(input,7,FOLLOW_7_in_synpred16_TimeDef239); if (state.failed) return ;
        	// TimeDef.g:67:86: ( WS )+
        	int cnt85 = 0;
        	do 
        	{
        	    int alt85 = 2;
        	    int LA85_0 = input.LA(1);

        	    if ( (LA85_0 == WS) )
        	    {
        	        alt85 = 1;
        	    }


        	    switch (alt85) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred16_TimeDef241); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt85 >= 1 ) goto loop85;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee85 =
        		                new EarlyExitException(85, input);
        		            throw eee85;
        	    }
        	    cnt85++;
        	} while (true);

        	loop85:
        		;	// Stops C# compiler whining that label 'loop85' has no statements

        	PushFollow(FOLLOW_timespan_p_in_synpred16_TimeDef246);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred16_TimeDef"

    // $ANTLR start "synpred24_TimeDef"
    public void synpred24_TimeDef_fragment() {
        TimeDefParser.timespan_p_return duration = default(TimeDefParser.timespan_p_return);


        // TimeDef.g:77:5: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )
        // TimeDef.g:77:5: ( WS )+ 'lasting' ( WS )+ duration= timespan_p
        {
        	// TimeDef.g:77:5: ( WS )+
        	int cnt86 = 0;
        	do 
        	{
        	    int alt86 = 2;
        	    int LA86_0 = input.LA(1);

        	    if ( (LA86_0 == WS) )
        	    {
        	        alt86 = 1;
        	    }


        	    switch (alt86) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred24_TimeDef324); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt86 >= 1 ) goto loop86;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee86 =
        		                new EarlyExitException(86, input);
        		            throw eee86;
        	    }
        	    cnt86++;
        	} while (true);

        	loop86:
        		;	// Stops C# compiler whining that label 'loop86' has no statements

        	Match(input,7,FOLLOW_7_in_synpred24_TimeDef327); if (state.failed) return ;
        	// TimeDef.g:77:19: ( WS )+
        	int cnt87 = 0;
        	do 
        	{
        	    int alt87 = 2;
        	    int LA87_0 = input.LA(1);

        	    if ( (LA87_0 == WS) )
        	    {
        	        alt87 = 1;
        	    }


        	    switch (alt87) 
        		{
        			case 1 :
        			    // TimeDef.g:0:0: WS
        			    {
        			    	Match(input,WS,FOLLOW_WS_in_synpred24_TimeDef329); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt87 >= 1 ) goto loop87;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee87 =
        		                new EarlyExitException(87, input);
        		            throw eee87;
        	    }
        	    cnt87++;
        	} while (true);

        	loop87:
        		;	// Stops C# compiler whining that label 'loop87' has no statements

        	PushFollow(FOLLOW_timespan_p_in_synpred24_TimeDef334);
        	duration = timespan_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred24_TimeDef"

    // $ANTLR start "synpred82_TimeDef"
    public void synpred82_TimeDef_fragment() {
        // TimeDef.g:229:36: ( ',' dow_cron_term_p )
        // TimeDef.g:229:36: ',' dow_cron_term_p
        {
        	Match(input,19,FOLLOW_19_in_synpred82_TimeDef1279); if (state.failed) return ;
        	PushFollow(FOLLOW_dow_cron_term_p_in_synpred82_TimeDef1281);
        	dow_cron_term_p();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred82_TimeDef"

    // Delegated rules

   	public bool synpred82_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred82_TimeDef_fragment(); // can never throw exception
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
   	public bool synpred9_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred9_TimeDef_fragment(); // can never throw exception
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
   	public bool synpred24_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred24_TimeDef_fragment(); // can never throw exception
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
   	public bool synpred16_TimeDef() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred16_TimeDef_fragment(); // can never throw exception
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


   	protected DFA6 dfa6;
   	protected DFA10 dfa10;
   	protected DFA13 dfa13;
   	protected DFA21 dfa21;
   	protected DFA30 dfa30;
   	protected DFA34 dfa34;
   	protected DFA38 dfa38;
   	protected DFA41 dfa41;
   	protected DFA44 dfa44;
   	protected DFA47 dfa47;
   	protected DFA50 dfa50;
   	protected DFA53 dfa53;
   	protected DFA57 dfa57;
   	protected DFA70 dfa70;
   	protected DFA71 dfa71;
   	protected DFA73 dfa73;
	private void InitializeCyclicDFAs()
	{
    	this.dfa6 = new DFA6(this);
    	this.dfa10 = new DFA10(this);
    	this.dfa13 = new DFA13(this);
    	this.dfa21 = new DFA21(this);
    	this.dfa30 = new DFA30(this);
    	this.dfa34 = new DFA34(this);
    	this.dfa38 = new DFA38(this);
    	this.dfa41 = new DFA41(this);
    	this.dfa44 = new DFA44(this);
    	this.dfa47 = new DFA47(this);
    	this.dfa50 = new DFA50(this);
    	this.dfa53 = new DFA53(this);
    	this.dfa57 = new DFA57(this);
    	this.dfa70 = new DFA70(this);
    	this.dfa71 = new DFA71(this);
    	this.dfa73 = new DFA73(this);
	    this.dfa6.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA6_SpecialStateTransition);
	    this.dfa13.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA13_SpecialStateTransition);
	    this.dfa21.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA21_SpecialStateTransition);
	}

    const string DFA6_eotS =
        "\x09\uffff";
    const string DFA6_eofS =
        "\x02\x02\x07\uffff";
    const string DFA6_minS =
        "\x02\x04\x01\uffff\x01\x04\x01\uffff\x01\x04\x02\x05\x01\x00";
    const string DFA6_maxS =
        "\x02\x18\x01\uffff\x01\x04\x01\uffff\x01\x1d\x01\x12\x01\x05\x01"+
        "\x00";
    const string DFA6_acceptS =
        "\x02\uffff\x01\x02\x01\uffff\x01\x01\x04\uffff";
    const string DFA6_specialS =
        "\x08\uffff\x01\x00}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x01\x09\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x03\x01\x04\x05\uffff\x0b\x02",
            "",
            "\x01\x05",
            "",
            "\x01\x05\x18\uffff\x01\x06",
            "\x01\x08\x0c\uffff\x01\x07",
            "\x01\x08",
            "\x01\uffff"
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "59:21: ( ( WS )+ ( 'lasting' ( WS )+ duration= timespan_p | 'to' ( WS )+ enddatetime= datetime_p ) )?"; }
        }

    }


    protected internal int DFA6_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA6_8 = input.LA(1);

                   	 
                   	int index6_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_TimeDef()) ) { s = 4; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index6_8);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae6 =
            new NoViableAltException(dfa.Description, 6, _s, input);
        dfa.Error(nvae6);
        throw nvae6;
    }
    const string DFA10_eotS =
        "\x04\uffff";
    const string DFA10_eofS =
        "\x02\x02\x02\uffff";
    const string DFA10_minS =
        "\x02\x04\x02\uffff";
    const string DFA10_maxS =
        "\x02\x18\x02\uffff";
    const string DFA10_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA10_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x01\x01\x09\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x02\x02\uffff\x01\x03\x03\uffff\x0b"+
            "\x02",
            "",
            ""
    };

    static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
    static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
    static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
    static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
    static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
    static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
    static readonly short[][] DFA10_transition = DFA.UnpackEncodedStringArray(DFA10_transitionS);

    protected class DFA10 : DFA
    {
        public DFA10(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 10;
            this.eot = DFA10_eot;
            this.eof = DFA10_eof;
            this.min = DFA10_min;
            this.max = DFA10_max;
            this.accept = DFA10_accept;
            this.special = DFA10_special;
            this.transition = DFA10_transition;

        }

        override public string Description
        {
            get { return "67:36: ( ( WS )+ 'since' ( WS )+ sync= datetime_p )?"; }
        }

    }

    const string DFA13_eotS =
        "\x09\uffff";
    const string DFA13_eofS =
        "\x02\x02\x07\uffff";
    const string DFA13_minS =
        "\x02\x04\x01\uffff\x02\x04\x02\x05\x01\x00\x01\uffff";
    const string DFA13_maxS =
        "\x02\x18\x01\uffff\x01\x04\x01\x1d\x01\x12\x01\x05\x01\x00\x01"+
        "\uffff";
    const string DFA13_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01";
    const string DFA13_specialS =
        "\x07\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x01\x01\x09\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x03\x06\uffff\x0b\x02",
            "",
            "\x01\x04",
            "\x01\x04\x18\uffff\x01\x05",
            "\x01\x07\x0c\uffff\x01\x06",
            "\x01\x07",
            "\x01\uffff",
            ""
    };

    static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
    static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
    static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
    static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
    static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
    static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
    static readonly short[][] DFA13_transition = DFA.UnpackEncodedStringArray(DFA13_transitionS);

    protected class DFA13 : DFA
    {
        public DFA13(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 13;
            this.eot = DFA13_eot;
            this.eof = DFA13_eof;
            this.min = DFA13_min;
            this.max = DFA13_max;
            this.accept = DFA13_accept;
            this.special = DFA13_special;
            this.transition = DFA13_transition;

        }

        override public string Description
        {
            get { return "67:71: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?"; }
        }

    }


    protected internal int DFA13_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA13_7 = input.LA(1);

                   	 
                   	int index13_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred16_TimeDef()) ) { s = 8; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index13_7);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae13 =
            new NoViableAltException(dfa.Description, 13, _s, input);
        dfa.Error(nvae13);
        throw nvae13;
    }
    const string DFA21_eotS =
        "\x09\uffff";
    const string DFA21_eofS =
        "\x02\x02\x07\uffff";
    const string DFA21_minS =
        "\x02\x04\x01\uffff\x02\x04\x02\x05\x01\x00\x01\uffff";
    const string DFA21_maxS =
        "\x02\x18\x01\uffff\x01\x04\x01\x1d\x01\x12\x01\x05\x01\x00\x01"+
        "\uffff";
    const string DFA21_acceptS =
        "\x02\uffff\x01\x02\x05\uffff\x01\x01";
    const string DFA21_specialS =
        "\x07\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA21_transitionS = {
            "\x01\x01\x09\uffff\x0b\x02",
            "\x01\x01\x02\uffff\x01\x03\x06\uffff\x0b\x02",
            "",
            "\x01\x04",
            "\x01\x04\x18\uffff\x01\x05",
            "\x01\x07\x0c\uffff\x01\x06",
            "\x01\x07",
            "\x01\uffff",
            ""
    };

    static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
    static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
    static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
    static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
    static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
    static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
    static readonly short[][] DFA21_transition = DFA.UnpackEncodedStringArray(DFA21_transitionS);

    protected class DFA21 : DFA
    {
        public DFA21(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 21;
            this.eot = DFA21_eot;
            this.eof = DFA21_eof;
            this.min = DFA21_min;
            this.max = DFA21_max;
            this.accept = DFA21_accept;
            this.special = DFA21_special;
            this.transition = DFA21_transition;

        }

        override public string Description
        {
            get { return "77:4: ( ( WS )+ 'lasting' ( WS )+ duration= timespan_p )?"; }
        }

    }


    protected internal int DFA21_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA21_7 = input.LA(1);

                   	 
                   	int index21_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_TimeDef()) ) { s = 8; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index21_7);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae21 =
            new NoViableAltException(dfa.Description, 21, _s, input);
        dfa.Error(nvae21);
        throw nvae21;
    }
    const string DFA30_eotS =
        "\x09\uffff";
    const string DFA30_eofS =
        "\x02\x02\x07\uffff";
    const string DFA30_minS =
        "\x02\x04\x01\uffff\x01\x04\x04\uffff\x01\x04";
    const string DFA30_maxS =
        "\x02\x18\x01\uffff\x01\x1d\x04\uffff\x01\x1d";
    const string DFA30_acceptS =
        "\x02\uffff\x01\x05\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01"+
        "\uffff";
    const string DFA30_specialS =
        "\x09\uffff}>";
    static readonly string[] DFA30_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x01\x04\x01\x05\x01\x06\x01\x03"+
            "\x06\x02",
            "\x01\x01\x02\uffff\x01\x07\x06\uffff\x01\x02\x01\x04\x01\x05"+
            "\x01\x06\x01\x03\x06\x02",
            "",
            "\x01\x08\x01\x02\x03\uffff\x01\x02\x01\uffff\x03\x02\x0b\uffff"+
            "\x02\x02\x02\uffff\x01\x06",
            "",
            "",
            "",
            "",
            "\x01\x08\x01\x02\x03\uffff\x01\x02\x01\uffff\x03\x02\x0b\uffff"+
            "\x02\x02\x02\uffff\x01\x06"
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
            get { return "()* loopback of 135:4: ( ( WS )* '|' ( WS )* B= subtract_p )*"; }
        }

    }

    const string DFA47_eotS =
        "\x04\uffff";
    const string DFA47_eofS =
        "\x02\x02\x02\uffff";
    const string DFA47_minS =
        "\x02\x04\x02\uffff";
    const string DFA47_maxS =
        "\x02\x16\x02\uffff";
    const string DFA47_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA47_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA47_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x03\uffff\x01\x03\x04\x02",
            "\x01\x01\x09\uffff\x01\x02\x03\uffff\x01\x03\x04\x02",
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
            get { return "()* loopback of 143:4: ( ( WS )* '-' ( WS )* B= difference_p )*"; }
        }

    }

    const string DFA50_eotS =
        "\x04\uffff";
    const string DFA50_eofS =
        "\x02\x02\x02\uffff";
    const string DFA50_minS =
        "\x02\x04\x02\uffff";
    const string DFA50_maxS =
        "\x02\x17\x02\uffff";
    const string DFA50_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA50_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA50_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x03\uffff\x05\x02\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x03\uffff\x05\x02\x01\x03",
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
            get { return "()* loopback of 155:4: ( ( WS )* '!&' ( WS )* B= intersection_p )*"; }
        }

    }

    const string DFA53_eotS =
        "\x04\uffff";
    const string DFA53_eofS =
        "\x02\x02\x02\uffff";
    const string DFA53_minS =
        "\x02\x04\x02\uffff";
    const string DFA53_maxS =
        "\x02\x18\x02\uffff";
    const string DFA53_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA53_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA53_transitionS = {
            "\x01\x01\x09\uffff\x01\x02\x03\uffff\x06\x02\x01\x03",
            "\x01\x01\x09\uffff\x01\x02\x03\uffff\x06\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA53_eot = DFA.UnpackEncodedString(DFA53_eotS);
    static readonly short[] DFA53_eof = DFA.UnpackEncodedString(DFA53_eofS);
    static readonly char[] DFA53_min = DFA.UnpackEncodedStringToUnsignedChars(DFA53_minS);
    static readonly char[] DFA53_max = DFA.UnpackEncodedStringToUnsignedChars(DFA53_maxS);
    static readonly short[] DFA53_accept = DFA.UnpackEncodedString(DFA53_acceptS);
    static readonly short[] DFA53_special = DFA.UnpackEncodedString(DFA53_specialS);
    static readonly short[][] DFA53_transition = DFA.UnpackEncodedStringArray(DFA53_transitionS);

    protected class DFA53 : DFA
    {
        public DFA53(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 53;
            this.eot = DFA53_eot;
            this.eof = DFA53_eof;
            this.min = DFA53_min;
            this.max = DFA53_max;
            this.accept = DFA53_accept;
            this.special = DFA53_special;
            this.transition = DFA53_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 164:4: ( ( WS )* '&' ( WS )* B= filter_p )*"; }
        }

    }

    const string DFA57_eotS =
        "\x04\uffff";
    const string DFA57_eofS =
        "\x02\x02\x02\uffff";
    const string DFA57_minS =
        "\x02\x04\x02\uffff";
    const string DFA57_maxS =
        "\x02\x18\x02\uffff";
    const string DFA57_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA57_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA57_transitionS = {
            "\x01\x01\x09\uffff\x0b\x02",
            "\x01\x01\x01\x03\x01\uffff\x02\x02\x05\uffff\x0b\x02",
            "",
            ""
    };

    static readonly short[] DFA57_eot = DFA.UnpackEncodedString(DFA57_eotS);
    static readonly short[] DFA57_eof = DFA.UnpackEncodedString(DFA57_eofS);
    static readonly char[] DFA57_min = DFA.UnpackEncodedStringToUnsignedChars(DFA57_minS);
    static readonly char[] DFA57_max = DFA.UnpackEncodedStringToUnsignedChars(DFA57_maxS);
    static readonly short[] DFA57_accept = DFA.UnpackEncodedString(DFA57_acceptS);
    static readonly short[] DFA57_special = DFA.UnpackEncodedString(DFA57_specialS);
    static readonly short[][] DFA57_transition = DFA.UnpackEncodedStringArray(DFA57_transitionS);

    protected class DFA57 : DFA
    {
        public DFA57(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 57;
            this.eot = DFA57_eot;
            this.eof = DFA57_eof;
            this.min = DFA57_min;
            this.max = DFA57_max;
            this.accept = DFA57_accept;
            this.special = DFA57_special;
            this.transition = DFA57_transition;

        }

        override public string Description
        {
            get { return "172:40: ( ( WS )+ h= hour24_p ':' m= minute60_p ( ':' s= second60_p ( '.' ms= millisecond1000_p )? )? )?"; }
        }

    }

    const string DFA70_eotS =
        "\x1b\uffff";
    const string DFA70_eofS =
        "\x01\x01\x01\uffff\x02\x08\x01\uffff\x01\x08\x01\uffff\x01\x08"+
        "\x01\uffff\x02\x0c\x02\uffff\x01\x0c\x01\x01\x01\x0c\x01\uffff\x01"+
        "\x0c\x01\x01\x02\uffff\x01\x13\x01\uffff\x01\x01\x01\uffff\x01\x01"+
        "\x01\uffff";
    const string DFA70_minS =
        "\x01\x04\x01\uffff\x02\x04\x01\uffff\x01\x04\x01\uffff\x01\x04"+
        "\x01\uffff\x03\x04\x01\uffff\x06\x04\x01\uffff\x07\x04";
    const string DFA70_maxS =
        "\x01\x22\x01\uffff\x02\x22\x01\uffff\x01\x20\x01\uffff\x01\x22"+
        "\x01\uffff\x01\x1d\x01\x22\x01\x1d\x01\uffff\x01\x22\x01\x1f\x01"+
        "\x22\x01\x1d\x01\x22\x01\x1f\x01\uffff\x01\x1d\x01\x1b\x01\x1d\x01"+
        "\x1b\x01\x1d\x01\x1b\x01\x1d";
    const string DFA70_acceptS =
        "\x01\uffff\x01\x02\x02\uffff\x01\x01\x01\uffff\x01\x01\x01\uffff"+
        "\x01\x01\x03\uffff\x01\x01\x06\uffff\x01\x01\x07\uffff";
    const string DFA70_specialS =
        "\x1b\uffff}>";
    static readonly string[] DFA70_transitionS = {
            "\x01\x01\x02\x04\x07\uffff\x01\x01\x01\x02\x02\x01\x01\x03"+
            "\x06\x01\x06\uffff\x04\x04",
            "",
            "\x01\x05\x01\x08\x01\x04\x07\uffff\x04\x08\x01\x07\x06\x08"+
            "\x05\uffff\x01\x01\x01\x04\x01\x06\x02\x04",
            "\x01\x09\x01\x0a\x01\x04\x02\uffff\x01\x01\x01\uffff\x03\x01"+
            "\x0b\x08\x02\x01\x02\uffff\x01\x01\x01\uffff\x04\x04",
            "",
            "\x01\x05\x01\x01\x01\uffff\x01\x08\x06\uffff\x04\x08\x01\x0b"+
            "\x06\x08\x05\uffff\x01\x01\x01\uffff\x01\x01",
            "",
            "\x01\x08\x01\x0c\x01\x04\x02\uffff\x01\x0c\x01\uffff\x03\x0c"+
            "\x0b\x08\x02\x0c\x02\uffff\x01\x0c\x01\uffff\x04\x04",
            "",
            "\x01\x09\x01\x01\x01\uffff\x01\x0c\x01\uffff\x01\x01\x01\uffff"+
            "\x03\x01\x0b\x0c\x02\x01\x02\uffff\x01\x01",
            "\x01\x0c\x02\x04\x07\uffff\x04\x0c\x01\x0d\x06\x0c\x02\uffff"+
            "\x01\x01\x03\uffff\x04\x04",
            "\x01\x0c\x01\x0e\x03\uffff\x01\x0c\x01\uffff\x03\x0c\x0b\uffff"+
            "\x02\x0c\x02\uffff\x01\x0c",
            "",
            "\x01\x0c\x01\x0f\x01\x04\x02\uffff\x01\x0c\x01\uffff\x10\x0c"+
            "\x02\uffff\x01\x0c\x01\uffff\x04\x04",
            "\x01\x01\x09\uffff\x04\x01\x01\x10\x06\x01\x02\uffff\x01\x0c"+
            "\x03\uffff\x01\x01",
            "\x01\x0c\x02\x04\x07\uffff\x04\x0c\x01\x11\x06\x0c\x02\uffff"+
            "\x01\x0c\x03\uffff\x04\x04",
            "\x01\x01\x01\x12\x03\uffff\x01\x01\x01\uffff\x03\x01\x04\uffff"+
            "\x01\x01\x06\uffff\x02\x01\x02\uffff\x01\x01",
            "\x01\x0c\x01\x13\x01\x04\x02\uffff\x01\x13\x01\uffff\x03\x13"+
            "\x0b\x0c\x02\x13\x02\uffff\x01\x13\x01\uffff\x04\x04",
            "\x01\x01\x09\uffff\x04\x01\x01\x14\x06\x01\x02\uffff\x01\x01"+
            "\x03\uffff\x01\x01",
            "",
            "\x01\x01\x01\x15\x03\uffff\x01\x01\x01\uffff\x03\x01\x0b\uffff"+
            "\x02\x01\x02\uffff\x01\x01",
            "\x01\x13\x09\uffff\x04\x13\x01\x16\x06\x13\x02\uffff\x01\x01",
            "\x01\x13\x01\x17\x03\uffff\x01\x13\x01\uffff\x03\x13\x0b\uffff"+
            "\x02\x13\x02\uffff\x01\x13",
            "\x01\x01\x09\uffff\x04\x01\x01\x18\x06\x01\x02\uffff\x01\x13",
            "\x01\x01\x01\x19\x03\uffff\x01\x01\x01\uffff\x03\x01\x0b\uffff"+
            "\x02\x01\x02\uffff\x01\x01",
            "\x01\x01\x09\uffff\x04\x01\x01\x1a\x06\x01\x02\uffff\x01\x01",
            "\x01\x01\x01\x15\x03\uffff\x01\x01\x01\uffff\x03\x01\x0b\uffff"+
            "\x02\x01\x02\uffff\x01\x01"
    };

    static readonly short[] DFA70_eot = DFA.UnpackEncodedString(DFA70_eotS);
    static readonly short[] DFA70_eof = DFA.UnpackEncodedString(DFA70_eofS);
    static readonly char[] DFA70_min = DFA.UnpackEncodedStringToUnsignedChars(DFA70_minS);
    static readonly char[] DFA70_max = DFA.UnpackEncodedStringToUnsignedChars(DFA70_maxS);
    static readonly short[] DFA70_accept = DFA.UnpackEncodedString(DFA70_acceptS);
    static readonly short[] DFA70_special = DFA.UnpackEncodedString(DFA70_specialS);
    static readonly short[][] DFA70_transition = DFA.UnpackEncodedStringArray(DFA70_transitionS);

    protected class DFA70 : DFA
    {
        public DFA70(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 70;
            this.eot = DFA70_eot;
            this.eof = DFA70_eof;
            this.min = DFA70_min;
            this.max = DFA70_max;
            this.accept = DFA70_accept;
            this.special = DFA70_special;
            this.transition = DFA70_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 230:23: ( UINT | ALPHA | '/' | '-' | '*' | '>' | '<' | '#' )+"; }
        }

    }

    const string DFA71_eotS =
        "\x10\uffff";
    const string DFA71_eofS =
        "\x01\x01\x02\uffff\x01\x04\x02\uffff\x01\x04\x01\uffff\x01\x01"+
        "\x01\uffff\x01\x04\x01\uffff\x01\x04\x01\uffff\x01\x01\x01\uffff";
    const string DFA71_minS =
        "\x01\x04\x01\uffff\x02\x04\x01\uffff\x0b\x04";
    const string DFA71_maxS =
        "\x01\x18\x01\uffff\x01\x20\x01\x1f\x01\uffff\x01\x1d\x01\x1f\x01"+
        "\x1d\x01\x1b\x01\x1d\x01\x1b\x01\x1d\x01\x1b\x01\x1d\x01\x1b\x01"+
        "\x1d";
    const string DFA71_acceptS =
        "\x01\uffff\x01\x02\x02\uffff\x01\x01\x0b\uffff";
    const string DFA71_specialS =
        "\x10\uffff}>";
    static readonly string[] DFA71_transitionS = {
            "\x01\x01\x09\uffff\x05\x01\x01\x02\x05\x01",
            "",
            "\x01\x01\x01\x03\x03\uffff\x01\x01\x01\uffff\x03\x01\x04\uffff"+
            "\x01\x04\x06\uffff\x02\x01\x03\uffff\x01\x04\x01\uffff\x01\x04",
            "\x01\x04\x09\uffff\x04\x04\x01\x05\x06\x04\x02\uffff\x01\x01"+
            "\x03\uffff\x01\x04",
            "",
            "\x01\x04\x01\x06\x03\uffff\x01\x04\x01\uffff\x03\x04\x04\uffff"+
            "\x01\x04\x06\uffff\x02\x04\x02\uffff\x01\x04",
            "\x01\x04\x09\uffff\x04\x04\x01\x07\x06\x04\x02\uffff\x01\x04"+
            "\x03\uffff\x01\x04",
            "\x01\x04\x01\x08\x03\uffff\x01\x04\x01\uffff\x03\x04\x0b\uffff"+
            "\x02\x04\x02\uffff\x01\x04",
            "\x01\x01\x09\uffff\x04\x01\x01\x09\x06\x01\x02\uffff\x01\x04",
            "\x01\x01\x01\x0a\x03\uffff\x01\x01\x01\uffff\x03\x01\x0b\uffff"+
            "\x02\x01\x02\uffff\x01\x01",
            "\x01\x04\x09\uffff\x04\x04\x01\x0b\x06\x04\x02\uffff\x01\x01",
            "\x01\x04\x01\x0c\x03\uffff\x01\x04\x01\uffff\x03\x04\x0b\uffff"+
            "\x02\x04\x02\uffff\x01\x04",
            "\x01\x04\x09\uffff\x04\x04\x01\x0d\x06\x04\x02\uffff\x01\x04",
            "\x01\x04\x01\x0e\x03\uffff\x01\x04\x01\uffff\x03\x04\x0b\uffff"+
            "\x02\x04\x02\uffff\x01\x04",
            "\x01\x01\x09\uffff\x04\x01\x01\x0f\x06\x01\x02\uffff\x01\x04",
            "\x01\x01\x01\x0a\x03\uffff\x01\x01\x01\uffff\x03\x01\x0b\uffff"+
            "\x02\x01\x02\uffff\x01\x01"
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
            get { return "()* loopback of 232:27: ( ',' intspec_term_p )*"; }
        }

    }

    const string DFA73_eotS =
        "\x0c\uffff";
    const string DFA73_eofS =
        "\x01\x02\x03\uffff\x01\x03\x03\uffff\x01\x02\x01\uffff\x01\x03"+
        "\x01\uffff";
    const string DFA73_minS =
        "\x02\x04\x02\uffff\x02\x04\x01\x12\x01\x05\x04\x04";
    const string DFA73_maxS =
        "\x01\x1f\x01\x1d\x02\uffff\x01\x1f\x01\x1d\x01\x1b\x01\x05\x01"+
        "\x18\x01\x1d\x01\x1b\x01\x1d";
    const string DFA73_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x08\uffff";
    const string DFA73_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA73_transitionS = {
            "\x01\x02\x09\uffff\x04\x02\x01\x01\x06\x02\x06\uffff\x01\x02",
            "\x01\x02\x01\x04\x03\uffff\x01\x02\x01\uffff\x03\x02\x04\uffff"+
            "\x01\x03\x06\uffff\x02\x02\x02\uffff\x01\x02",
            "",
            "",
            "\x01\x03\x09\uffff\x04\x03\x01\x05\x06\x03\x02\uffff\x01\x02"+
            "\x03\uffff\x01\x03",
            "\x01\x03\x01\x06\x03\uffff\x01\x03\x01\uffff\x03\x03\x0b\uffff"+
            "\x02\x03\x02\uffff\x01\x03",
            "\x01\x07\x08\uffff\x01\x03",
            "\x01\x08",
            "\x01\x02\x09\uffff\x04\x02\x01\x09\x06\x02",
            "\x01\x02\x01\x0a\x03\uffff\x01\x02\x01\uffff\x03\x02\x0b\uffff"+
            "\x02\x02\x02\uffff\x01\x02",
            "\x01\x03\x09\uffff\x04\x03\x01\x0b\x06\x03\x02\uffff\x01\x02",
            "\x01\x03\x01\x06\x03\uffff\x01\x03\x01\uffff\x03\x03\x0b\uffff"+
            "\x02\x03\x02\uffff\x01\x03"
    };

    static readonly short[] DFA73_eot = DFA.UnpackEncodedString(DFA73_eotS);
    static readonly short[] DFA73_eof = DFA.UnpackEncodedString(DFA73_eofS);
    static readonly char[] DFA73_min = DFA.UnpackEncodedStringToUnsignedChars(DFA73_minS);
    static readonly char[] DFA73_max = DFA.UnpackEncodedStringToUnsignedChars(DFA73_maxS);
    static readonly short[] DFA73_accept = DFA.UnpackEncodedString(DFA73_acceptS);
    static readonly short[] DFA73_special = DFA.UnpackEncodedString(DFA73_specialS);
    static readonly short[][] DFA73_transition = DFA.UnpackEncodedStringArray(DFA73_transitionS);

    protected class DFA73 : DFA
    {
        public DFA73(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 73;
            this.eot = DFA73_eot;
            this.eof = DFA73_eof;
            this.min = DFA73_min;
            this.max = DFA73_max;
            this.accept = DFA73_accept;
            this.special = DFA73_special;
            this.transition = DFA73_transition;

        }

        override public string Description
        {
            get { return "233:36: ( '-' int_p )?"; }
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
    public static readonly BitSet FOLLOW_WS_in_once_p166 = new BitSet(new ulong[]{0x0000000000000190UL});
    public static readonly BitSet FOLLOW_7_in_once_p170 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_once_p172 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_once_p177 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_8_in_once_p181 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_once_p183 = new BitSet(new ulong[]{0x0000000006000030UL});
    public static readonly BitSet FOLLOW_datetime_p_in_once_p188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_9_in_every_p211 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p213 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_every_p218 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_every_p221 = new BitSet(new ulong[]{0x0000000000000410UL});
    public static readonly BitSet FOLLOW_10_in_every_p224 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p226 = new BitSet(new ulong[]{0x0000000006000030UL});
    public static readonly BitSet FOLLOW_datetime_p_in_every_p231 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_every_p236 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_every_p239 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_every_p241 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_every_p246 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_11_in_cron_p268 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p270 = new BitSet(new ulong[]{0x00000007C0040030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p278 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p280 = new BitSet(new ulong[]{0x00000007C0040030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p288 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p290 = new BitSet(new ulong[]{0x00000007C0040030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p298 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p300 = new BitSet(new ulong[]{0x00000007C0040030UL});
    public static readonly BitSet FOLLOW_cron_field_p_in_cron_p308 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p310 = new BitSet(new ulong[]{0x00000007C0048070UL});
    public static readonly BitSet FOLLOW_dow_cron_field_p_in_cron_p318 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p324 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_cron_p327 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_cron_p329 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_cron_p334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_void_p354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_paren_p372 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_expr_in_paren_p374 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_14_in_paren_p376 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_filter_p400 = new BitSet(new ulong[]{0x0000000000078012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p413 = new BitSet(new ulong[]{0x0000000000008010UL});
    public static readonly BitSet FOLLOW_15_in_filter_p416 = new BitSet(new ulong[]{0x0000000140040030UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p418 = new BitSet(new ulong[]{0x0000000140040030UL});
    public static readonly BitSet FOLLOW_intspec_p_in_filter_p423 = new BitSet(new ulong[]{0x0000000000078012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p438 = new BitSet(new ulong[]{0x0000000000010010UL});
    public static readonly BitSet FOLLOW_16_in_filter_p441 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p443 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_UINT_in_filter_p448 = new BitSet(new ulong[]{0x0000000000078012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p463 = new BitSet(new ulong[]{0x0000000000060010UL});
    public static readonly BitSet FOLLOW_set_in_filter_p468 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p474 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_filter_p479 = new BitSet(new ulong[]{0x0000000000078012UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p494 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_filter_p497 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_filter_p499 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_filter_p504 = new BitSet(new ulong[]{0x0000000000078012UL});
    public static readonly BitSet FOLLOW_WS_in_expr538 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_boolnonintersection_p_in_expr543 = new BitSet(new ulong[]{0x0000000000080012UL});
    public static readonly BitSet FOLLOW_WS_in_expr551 = new BitSet(new ulong[]{0x0000000000080010UL});
    public static readonly BitSet FOLLOW_19_in_expr554 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_WS_in_expr556 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_boolnonintersection_p_in_expr561 = new BitSet(new ulong[]{0x0000000000080012UL});
    public static readonly BitSet FOLLOW_WS_in_expr568 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_boolintersection_p_in_boolnonintersection_p592 = new BitSet(new ulong[]{0x0000000000100012UL});
    public static readonly BitSet FOLLOW_WS_in_boolnonintersection_p600 = new BitSet(new ulong[]{0x0000000000100010UL});
    public static readonly BitSet FOLLOW_20_in_boolnonintersection_p603 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_WS_in_boolnonintersection_p605 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_boolintersection_p_in_boolnonintersection_p610 = new BitSet(new ulong[]{0x0000000000100012UL});
    public static readonly BitSet FOLLOW_union_p_in_boolintersection_p635 = new BitSet(new ulong[]{0x0000000000200012UL});
    public static readonly BitSet FOLLOW_WS_in_boolintersection_p643 = new BitSet(new ulong[]{0x0000000000200010UL});
    public static readonly BitSet FOLLOW_21_in_boolintersection_p646 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_WS_in_boolintersection_p648 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_union_p_in_boolintersection_p653 = new BitSet(new ulong[]{0x0000000000200012UL});
    public static readonly BitSet FOLLOW_subtract_p_in_union_p686 = new BitSet(new ulong[]{0x0000000000400012UL});
    public static readonly BitSet FOLLOW_WS_in_union_p694 = new BitSet(new ulong[]{0x0000000000400010UL});
    public static readonly BitSet FOLLOW_22_in_union_p697 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_WS_in_union_p699 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_subtract_p_in_union_p704 = new BitSet(new ulong[]{0x0000000000400012UL});
    public static readonly BitSet FOLLOW_difference_p_in_subtract_p732 = new BitSet(new ulong[]{0x0000000000040012UL});
    public static readonly BitSet FOLLOW_WS_in_subtract_p740 = new BitSet(new ulong[]{0x0000000000040010UL});
    public static readonly BitSet FOLLOW_18_in_subtract_p743 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_WS_in_subtract_p745 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_difference_p_in_subtract_p750 = new BitSet(new ulong[]{0x0000000000040012UL});
    public static readonly BitSet FOLLOW_intersection_p_in_difference_p783 = new BitSet(new ulong[]{0x0000000000800012UL});
    public static readonly BitSet FOLLOW_WS_in_difference_p791 = new BitSet(new ulong[]{0x0000000000800010UL});
    public static readonly BitSet FOLLOW_23_in_difference_p794 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_WS_in_difference_p796 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_intersection_p_in_difference_p801 = new BitSet(new ulong[]{0x0000000000800012UL});
    public static readonly BitSet FOLLOW_filter_p_in_intersection_p830 = new BitSet(new ulong[]{0x0000000001000012UL});
    public static readonly BitSet FOLLOW_WS_in_intersection_p838 = new BitSet(new ulong[]{0x0000000001000010UL});
    public static readonly BitSet FOLLOW_24_in_intersection_p841 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_WS_in_intersection_p843 = new BitSet(new ulong[]{0x0000000006003A30UL});
    public static readonly BitSet FOLLOW_filter_p_in_intersection_p848 = new BitSet(new ulong[]{0x0000000001000012UL});
    public static readonly BitSet FOLLOW_set_in_datetime_p875 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_year_p_in_datetime_p890 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_datetime_p892 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_month_p_in_datetime_p896 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_datetime_p898 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_day_p_in_datetime_p902 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_WS_in_datetime_p905 = new BitSet(new ulong[]{0x0000000006000030UL});
    public static readonly BitSet FOLLOW_hour24_p_in_datetime_p910 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_datetime_p912 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_minute60_p_in_datetime_p916 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_27_in_datetime_p919 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_second60_p_in_datetime_p923 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_datetime_p926 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_millisecond1000_p_in_datetime_p930 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_hour24_p_in_datetime_p945 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_datetime_p947 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_minute60_p_in_datetime_p951 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_27_in_datetime_p954 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_second60_p_in_datetime_p958 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_datetime_p961 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_millisecond1000_p_in_datetime_p965 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_datetime_p_in_datetime_prog989 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_datetime_prog991 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_year_p1006 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_month_p1018 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_day_p1030 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_hour24_p1042 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_minute60_p1054 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_second60_p1066 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UINT_in_millisecond1000_p1078 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_timespan_p1096 = new BitSet(new ulong[]{0x0000000140040030UL});
    public static readonly BitSet FOLLOW_days_p_in_timespan_p1103 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_timespan_p1105 = new BitSet(new ulong[]{0x0000000140040030UL});
    public static readonly BitSet FOLLOW_hours_p_in_timespan_p1111 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_timespan_p1113 = new BitSet(new ulong[]{0x0000000140040030UL});
    public static readonly BitSet FOLLOW_minutes_p_in_timespan_p1119 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_timespan_p1121 = new BitSet(new ulong[]{0x0000000140040030UL});
    public static readonly BitSet FOLLOW_seconds_p_in_timespan_p1127 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_timespan_p1130 = new BitSet(new ulong[]{0x0000000140040030UL});
    public static readonly BitSet FOLLOW_milliseconds_p_in_timespan_p1134 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_timespan_p_in_timespan_prog1156 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_timespan_prog1158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_days_p1173 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_hours_p1185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_minutes_p1197 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_seconds_p1209 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_p_in_milliseconds_p1221 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cron_term_p_in_cron_field_p1230 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_19_in_cron_field_p1233 = new BitSet(new ulong[]{0x00000007C0040020UL});
    public static readonly BitSet FOLLOW_cron_term_p_in_cron_field_p1235 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_30_in_cron_term_p1243 = new BitSet(new ulong[]{0x0000000780040020UL});
    public static readonly BitSet FOLLOW_set_in_cron_term_p1246 = new BitSet(new ulong[]{0x0000000780040022UL});
    public static readonly BitSet FOLLOW_dow_cron_term_p_in_dow_cron_field_p1276 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_19_in_dow_cron_field_p1279 = new BitSet(new ulong[]{0x00000007C0048060UL});
    public static readonly BitSet FOLLOW_dow_cron_term_p_in_dow_cron_field_p1281 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_30_in_dow_cron_term_p1289 = new BitSet(new ulong[]{0x0000000780048060UL});
    public static readonly BitSet FOLLOW_set_in_dow_cron_term_p1292 = new BitSet(new ulong[]{0x0000000780048062UL});
    public static readonly BitSet FOLLOW_intspec_term_p_in_intspec_p1330 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_19_in_intspec_p1333 = new BitSet(new ulong[]{0x0000000140040030UL});
    public static readonly BitSet FOLLOW_intspec_term_p_in_intspec_p1335 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_30_in_intspec_term_p1343 = new BitSet(new ulong[]{0x0000000140040030UL});
    public static readonly BitSet FOLLOW_32_in_intspec_term_p1348 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_int_p_in_intspec_term_p1352 = new BitSet(new ulong[]{0x0000000080040002UL});
    public static readonly BitSet FOLLOW_18_in_intspec_term_p1356 = new BitSet(new ulong[]{0x0000000140040030UL});
    public static readonly BitSet FOLLOW_int_p_in_intspec_term_p1358 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_31_in_intspec_term_p1367 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_UINT_in_intspec_term_p1369 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_18_in_int_p1382 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_UINT_in_int_p1385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred9_TimeDef166 = new BitSet(new ulong[]{0x0000000000000190UL});
    public static readonly BitSet FOLLOW_7_in_synpred9_TimeDef170 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred9_TimeDef172 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred9_TimeDef177 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_8_in_synpred9_TimeDef181 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred9_TimeDef183 = new BitSet(new ulong[]{0x0000000006000030UL});
    public static readonly BitSet FOLLOW_datetime_p_in_synpred9_TimeDef188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred16_TimeDef236 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred16_TimeDef239 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred16_TimeDef241 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred16_TimeDef246 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_synpred24_TimeDef324 = new BitSet(new ulong[]{0x0000000000000090UL});
    public static readonly BitSet FOLLOW_7_in_synpred24_TimeDef327 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_WS_in_synpred24_TimeDef329 = new BitSet(new ulong[]{0x0000000020000010UL});
    public static readonly BitSet FOLLOW_timespan_p_in_synpred24_TimeDef334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_19_in_synpred82_TimeDef1279 = new BitSet(new ulong[]{0x00000007C0048060UL});
    public static readonly BitSet FOLLOW_dow_cron_term_p_in_synpred82_TimeDef1281 = new BitSet(new ulong[]{0x0000000000000002UL});

}
