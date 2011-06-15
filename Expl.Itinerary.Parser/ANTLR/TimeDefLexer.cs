// $ANTLR 3.2 Sep 23, 2009 12:02:23 TimeDef.g 2011-06-15 15:24:06

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class TimeDefLexer : Lexer {
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
    public const int T__19 = 19;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__16 = 16;
    public const int WS = 4;
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

    public TimeDefLexer() 
    {
		InitializeCyclicDFAs();
    }
    public TimeDefLexer(ICharStream input)
		: this(input, null) {
    }
    public TimeDefLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "TimeDef.g";} 
    }

    // $ANTLR start "T__7"
    public void mT__7() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__7;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:7:6: ( 'lasting' )
            // TimeDef.g:7:8: 'lasting'
            {
            	Match("lasting"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__7"

    // $ANTLR start "T__8"
    public void mT__8() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__8;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:8:6: ( 'every' )
            // TimeDef.g:8:8: 'every'
            {
            	Match("every"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__8"

    // $ANTLR start "T__9"
    public void mT__9() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__9;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:9:6: ( 'since' )
            // TimeDef.g:9:8: 'since'
            {
            	Match("since"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__9"

    // $ANTLR start "T__10"
    public void mT__10() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__10;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:10:7: ( 'cron' )
            // TimeDef.g:10:9: 'cron'
            {
            	Match("cron"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__10"

    // $ANTLR start "T__11"
    public void mT__11() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__11;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:11:7: ( 'void' )
            // TimeDef.g:11:9: 'void'
            {
            	Match("void"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__11"

    // $ANTLR start "T__12"
    public void mT__12() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__12;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:12:7: ( '(' )
            // TimeDef.g:12:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__12"

    // $ANTLR start "T__13"
    public void mT__13() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__13;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:13:7: ( ')' )
            // TimeDef.g:13:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__13"

    // $ANTLR start "T__14"
    public void mT__14() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__14;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:14:7: ( '#' )
            // TimeDef.g:14:9: '#'
            {
            	Match('#'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__14"

    // $ANTLR start "T__15"
    public void mT__15() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__15;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:15:7: ( 'x' )
            // TimeDef.g:15:9: 'x'
            {
            	Match('x'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__15"

    // $ANTLR start "T__16"
    public void mT__16() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__16;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:16:7: ( '+' )
            // TimeDef.g:16:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__16"

    // $ANTLR start "T__17"
    public void mT__17() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__17;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:17:7: ( '-' )
            // TimeDef.g:17:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__17"

    // $ANTLR start "T__18"
    public void mT__18() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__18;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:18:7: ( ',' )
            // TimeDef.g:18:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__18"

    // $ANTLR start "T__19"
    public void mT__19() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__19;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:19:7: ( '!&&' )
            // TimeDef.g:19:9: '!&&'
            {
            	Match("!&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:20:7: ( '&&' )
            // TimeDef.g:20:9: '&&'
            {
            	Match("&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__20"

    // $ANTLR start "T__21"
    public void mT__21() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__21;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:21:7: ( '|' )
            // TimeDef.g:21:9: '|'
            {
            	Match('|'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__21"

    // $ANTLR start "T__22"
    public void mT__22() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__22;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:22:7: ( '!&' )
            // TimeDef.g:22:9: '!&'
            {
            	Match("!&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__22"

    // $ANTLR start "T__23"
    public void mT__23() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__23;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:23:7: ( '&' )
            // TimeDef.g:23:9: '&'
            {
            	Match('&'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__23"

    // $ANTLR start "T__24"
    public void mT__24() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__24;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:24:7: ( ':' )
            // TimeDef.g:24:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__24"

    // $ANTLR start "T__25"
    public void mT__25() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__25;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:25:7: ( '.' )
            // TimeDef.g:25:9: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__25"

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:26:7: ( 'T' )
            // TimeDef.g:26:9: 'T'
            {
            	Match('T'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__26"

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:27:7: ( '!' )
            // TimeDef.g:27:9: '!'
            {
            	Match('!'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:28:7: ( '/' )
            // TimeDef.g:28:9: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:29:7: ( '*' )
            // TimeDef.g:29:9: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:30:7: ( '>' )
            // TimeDef.g:30:9: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:31:7: ( '<' )
            // TimeDef.g:31:9: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__31"

    // $ANTLR start "UINT"
    public void mUINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UINT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:218:5: ( ( '0' .. '9' )+ )
            // TimeDef.g:218:7: ( '0' .. '9' )+
            {
            	// TimeDef.g:218:7: ( '0' .. '9' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // TimeDef.g:218:8: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UINT"

    // $ANTLR start "ALPHA"
    public void mALPHA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ALPHA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:219:6: ( ( 'A' .. 'Z' | 'a' .. 'z' )+ )
            // TimeDef.g:219:8: ( 'A' .. 'Z' | 'a' .. 'z' )+
            {
            	// TimeDef.g:219:8: ( 'A' .. 'Z' | 'a' .. 'z' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= 'A' && LA2_0 <= 'Z') || (LA2_0 >= 'a' && LA2_0 <= 'z')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // TimeDef.g:
            			    {
            			    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ALPHA"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TimeDef.g:220:3: ( ( ' ' | '\\t' | '\\r\\n' | '\\r' )+ )
            // TimeDef.g:220:5: ( ' ' | '\\t' | '\\r\\n' | '\\r' )+
            {
            	// TimeDef.g:220:5: ( ' ' | '\\t' | '\\r\\n' | '\\r' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 5;
            	    switch ( input.LA(1) ) 
            	    {
            	    case ' ':
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    case '\t':
            	    	{
            	        alt3 = 2;
            	        }
            	        break;
            	    case '\r':
            	    	{
            	        int LA3_4 = input.LA(2);

            	        if ( (LA3_4 == '\n') )
            	        {
            	            alt3 = 3;
            	        }

            	        else 
            	        {
            	            alt3 = 4;
            	        }

            	        }
            	        break;

            	    }

            	    switch (alt3) 
            		{
            			case 1 :
            			    // TimeDef.g:220:6: ' '
            			    {
            			    	Match(' '); 

            			    }
            			    break;
            			case 2 :
            			    // TimeDef.g:220:10: '\\t'
            			    {
            			    	Match('\t'); 

            			    }
            			    break;
            			case 3 :
            			    // TimeDef.g:220:15: '\\r\\n'
            			    {
            			    	Match("\r\n"); 


            			    }
            			    break;
            			case 4 :
            			    // TimeDef.g:220:22: '\\r'
            			    {
            			    	Match('\r'); 

            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    override public void mTokens() // throws RecognitionException 
    {
        // TimeDef.g:1:8: ( T__7 | T__8 | T__9 | T__10 | T__11 | T__12 | T__13 | T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | UINT | ALPHA | WS )
        int alt4 = 28;
        alt4 = dfa4.Predict(input);
        switch (alt4) 
        {
            case 1 :
                // TimeDef.g:1:10: T__7
                {
                	mT__7(); 

                }
                break;
            case 2 :
                // TimeDef.g:1:15: T__8
                {
                	mT__8(); 

                }
                break;
            case 3 :
                // TimeDef.g:1:20: T__9
                {
                	mT__9(); 

                }
                break;
            case 4 :
                // TimeDef.g:1:25: T__10
                {
                	mT__10(); 

                }
                break;
            case 5 :
                // TimeDef.g:1:31: T__11
                {
                	mT__11(); 

                }
                break;
            case 6 :
                // TimeDef.g:1:37: T__12
                {
                	mT__12(); 

                }
                break;
            case 7 :
                // TimeDef.g:1:43: T__13
                {
                	mT__13(); 

                }
                break;
            case 8 :
                // TimeDef.g:1:49: T__14
                {
                	mT__14(); 

                }
                break;
            case 9 :
                // TimeDef.g:1:55: T__15
                {
                	mT__15(); 

                }
                break;
            case 10 :
                // TimeDef.g:1:61: T__16
                {
                	mT__16(); 

                }
                break;
            case 11 :
                // TimeDef.g:1:67: T__17
                {
                	mT__17(); 

                }
                break;
            case 12 :
                // TimeDef.g:1:73: T__18
                {
                	mT__18(); 

                }
                break;
            case 13 :
                // TimeDef.g:1:79: T__19
                {
                	mT__19(); 

                }
                break;
            case 14 :
                // TimeDef.g:1:85: T__20
                {
                	mT__20(); 

                }
                break;
            case 15 :
                // TimeDef.g:1:91: T__21
                {
                	mT__21(); 

                }
                break;
            case 16 :
                // TimeDef.g:1:97: T__22
                {
                	mT__22(); 

                }
                break;
            case 17 :
                // TimeDef.g:1:103: T__23
                {
                	mT__23(); 

                }
                break;
            case 18 :
                // TimeDef.g:1:109: T__24
                {
                	mT__24(); 

                }
                break;
            case 19 :
                // TimeDef.g:1:115: T__25
                {
                	mT__25(); 

                }
                break;
            case 20 :
                // TimeDef.g:1:121: T__26
                {
                	mT__26(); 

                }
                break;
            case 21 :
                // TimeDef.g:1:127: T__27
                {
                	mT__27(); 

                }
                break;
            case 22 :
                // TimeDef.g:1:133: T__28
                {
                	mT__28(); 

                }
                break;
            case 23 :
                // TimeDef.g:1:139: T__29
                {
                	mT__29(); 

                }
                break;
            case 24 :
                // TimeDef.g:1:145: T__30
                {
                	mT__30(); 

                }
                break;
            case 25 :
                // TimeDef.g:1:151: T__31
                {
                	mT__31(); 

                }
                break;
            case 26 :
                // TimeDef.g:1:157: UINT
                {
                	mUINT(); 

                }
                break;
            case 27 :
                // TimeDef.g:1:162: ALPHA
                {
                	mALPHA(); 

                }
                break;
            case 28 :
                // TimeDef.g:1:168: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA4 dfa4;
	private void InitializeCyclicDFAs()
	{
	    this.dfa4 = new DFA4(this);
	}

    const string DFA4_eotS =
        "\x01\uffff\x05\x18\x03\uffff\x01\x1f\x03\uffff\x01\x21\x01\x23"+
        "\x03\uffff\x01\x24\x07\uffff\x05\x18\x01\uffff\x01\x2b\x04\uffff"+
        "\x05\x18\x02\uffff\x03\x18\x01\x34\x01\x35\x01\x18\x01\x37\x01\x38"+
        "\x02\uffff\x01\x18\x02\uffff\x01\x3a\x01\uffff";
    const string DFA4_eofS =
        "\x3b\uffff";
    const string DFA4_minS =
        "\x01\x09\x01\x61\x01\x76\x01\x69\x01\x72\x01\x6f\x03\uffff\x01"+
        "\x41\x03\uffff\x02\x26\x03\uffff\x01\x41\x07\uffff\x01\x73\x01\x65"+
        "\x01\x6e\x01\x6f\x01\x69\x01\uffff\x01\x26\x04\uffff\x01\x74\x01"+
        "\x72\x01\x63\x01\x6e\x01\x64\x02\uffff\x01\x69\x01\x79\x01\x65\x02"+
        "\x41\x01\x6e\x02\x41\x02\uffff\x01\x67\x02\uffff\x01\x41\x01\uffff";
    const string DFA4_maxS =
        "\x01\x7c\x01\x61\x01\x76\x01\x69\x01\x72\x01\x6f\x03\uffff\x01"+
        "\x7a\x03\uffff\x02\x26\x03\uffff\x01\x7a\x07\uffff\x01\x73\x01\x65"+
        "\x01\x6e\x01\x6f\x01\x69\x01\uffff\x01\x26\x04\uffff\x01\x74\x01"+
        "\x72\x01\x63\x01\x6e\x01\x64\x02\uffff\x01\x69\x01\x79\x01\x65\x02"+
        "\x7a\x01\x6e\x02\x7a\x02\uffff\x01\x67\x02\uffff\x01\x7a\x01\uffff";
    const string DFA4_acceptS =
        "\x06\uffff\x01\x06\x01\x07\x01\x08\x01\uffff\x01\x0a\x01\x0b\x01"+
        "\x0c\x02\uffff\x01\x0f\x01\x12\x01\x13\x01\uffff\x01\x16\x01\x17"+
        "\x01\x18\x01\x19\x01\x1a\x01\x1b\x01\x1c\x05\uffff\x01\x09\x01\uffff"+
        "\x01\x15\x01\x0e\x01\x11\x01\x14\x05\uffff\x01\x0d\x01\x10\x08\uffff"+
        "\x01\x04\x01\x05\x01\uffff\x01\x02\x01\x03\x01\uffff\x01\x01";
    const string DFA4_specialS =
        "\x3b\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x19\x03\uffff\x01\x19\x12\uffff\x01\x19\x01\x0d\x01\uffff"+
            "\x01\x08\x02\uffff\x01\x0e\x01\uffff\x01\x06\x01\x07\x01\x14"+
            "\x01\x0a\x01\x0c\x01\x0b\x01\x11\x01\x13\x0a\x17\x01\x10\x01"+
            "\uffff\x01\x16\x01\uffff\x01\x15\x02\uffff\x13\x18\x01\x12\x06"+
            "\x18\x06\uffff\x02\x18\x01\x04\x01\x18\x01\x02\x06\x18\x01\x01"+
            "\x06\x18\x01\x03\x02\x18\x01\x05\x01\x18\x01\x09\x02\x18\x01"+
            "\uffff\x01\x0f",
            "\x01\x1a",
            "\x01\x1b",
            "\x01\x1c",
            "\x01\x1d",
            "\x01\x1e",
            "",
            "",
            "",
            "\x1a\x18\x06\uffff\x1a\x18",
            "",
            "",
            "",
            "\x01\x20",
            "\x01\x22",
            "",
            "",
            "",
            "\x1a\x18\x06\uffff\x1a\x18",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x25",
            "\x01\x26",
            "\x01\x27",
            "\x01\x28",
            "\x01\x29",
            "",
            "\x01\x2a",
            "",
            "",
            "",
            "",
            "\x01\x2c",
            "\x01\x2d",
            "\x01\x2e",
            "\x01\x2f",
            "\x01\x30",
            "",
            "",
            "\x01\x31",
            "\x01\x32",
            "\x01\x33",
            "\x1a\x18\x06\uffff\x1a\x18",
            "\x1a\x18\x06\uffff\x1a\x18",
            "\x01\x36",
            "\x1a\x18\x06\uffff\x1a\x18",
            "\x1a\x18\x06\uffff\x1a\x18",
            "",
            "",
            "\x01\x39",
            "",
            "",
            "\x1a\x18\x06\uffff\x1a\x18",
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
            get { return "1:1: Tokens : ( T__7 | T__8 | T__9 | T__10 | T__11 | T__12 | T__13 | T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | UINT | ALPHA | WS );"; }
        }

    }

 
    
}
