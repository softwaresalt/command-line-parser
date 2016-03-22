//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CommandLine.g4 by ANTLR 4.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace System.CommandLine.Parser.Antlr {
using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
internal partial class CommandLineParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, UnixStyleFlaggedIdentifiers=4, WindowsStyleIdentifier=5, 
		UnixStyleIdentifier=6, AssignmentOperator=7, True=8, False=9, Number=10, 
		Digit=11, String=12, QuotedString=13, WhiteSpaces=14;
	public const int
		RULE_commandLine = 0, RULE_defaultParameter = 1, RULE_parameter = 2, RULE_value = 3;
	public static readonly string[] ruleNames = {
		"commandLine", "defaultParameter", "parameter", "value"
	};

	private static readonly string[] _LiteralNames = {
		null, "'['", "','", "']'", null, null, null, null, "'true'", "'false'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "UnixStyleFlaggedIdentifiers", "WindowsStyleIdentifier", 
		"UnixStyleIdentifier", "AssignmentOperator", "True", "False", "Number", 
		"Digit", "String", "QuotedString", "WhiteSpaces"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "CommandLine.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public CommandLineParser(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this,_ATN);
	}
	public partial class CommandLineContext : ParserRuleContext {
		public DefaultParameterContext[] defaultParameter() {
			return GetRuleContexts<DefaultParameterContext>();
		}
		public DefaultParameterContext defaultParameter(int i) {
			return GetRuleContext<DefaultParameterContext>(i);
		}
		public ParameterContext[] parameter() {
			return GetRuleContexts<ParameterContext>();
		}
		public ParameterContext parameter(int i) {
			return GetRuleContext<ParameterContext>(i);
		}
		public CommandLineContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_commandLine; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICommandLineVisitor<TResult> typedVisitor = visitor as ICommandLineVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCommandLine(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CommandLineContext commandLine() {
		CommandLineContext _localctx = new CommandLineContext(Context, State);
		EnterRule(_localctx, 0, RULE_commandLine);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 11;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==String || _la==QuotedString) {
				{
				{
				State = 8; defaultParameter();
				}
				}
				State = 13;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			State = 17;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << UnixStyleFlaggedIdentifiers) | (1L << WindowsStyleIdentifier) | (1L << UnixStyleIdentifier))) != 0)) {
				{
				{
				State = 14; parameter();
				}
				}
				State = 19;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DefaultParameterContext : ParserRuleContext {
		public ITerminalNode String() { return GetToken(CommandLineParser.String, 0); }
		public ITerminalNode QuotedString() { return GetToken(CommandLineParser.QuotedString, 0); }
		public DefaultParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_defaultParameter; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICommandLineVisitor<TResult> typedVisitor = visitor as ICommandLineVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDefaultParameter(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DefaultParameterContext defaultParameter() {
		DefaultParameterContext _localctx = new DefaultParameterContext(Context, State);
		EnterRule(_localctx, 2, RULE_defaultParameter);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 20;
			_la = TokenStream.La(1);
			if ( !(_la==String || _la==QuotedString) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ParameterContext : ParserRuleContext {
		public ParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameter; } }
	 
		public ParameterContext() { }
		public virtual void CopyFrom(ParameterContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class UnixStyleSwitchContext : ParameterContext {
		public ITerminalNode UnixStyleIdentifier() { return GetToken(CommandLineParser.UnixStyleIdentifier, 0); }
		public UnixStyleSwitchContext(ParameterContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICommandLineVisitor<TResult> typedVisitor = visitor as ICommandLineVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnixStyleSwitch(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class WindowsStyleParameterContext : ParameterContext {
		public ITerminalNode WindowsStyleIdentifier() { return GetToken(CommandLineParser.WindowsStyleIdentifier, 0); }
		public ITerminalNode AssignmentOperator() { return GetToken(CommandLineParser.AssignmentOperator, 0); }
		public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		public WindowsStyleParameterContext(ParameterContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICommandLineVisitor<TResult> typedVisitor = visitor as ICommandLineVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWindowsStyleParameter(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class UnixStyleParameterContext : ParameterContext {
		public ITerminalNode UnixStyleIdentifier() { return GetToken(CommandLineParser.UnixStyleIdentifier, 0); }
		public ITerminalNode AssignmentOperator() { return GetToken(CommandLineParser.AssignmentOperator, 0); }
		public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		public UnixStyleParameterContext(ParameterContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICommandLineVisitor<TResult> typedVisitor = visitor as ICommandLineVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnixStyleParameter(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class UnixStyleFlaggedSwitchContext : ParameterContext {
		public ITerminalNode UnixStyleFlaggedIdentifiers() { return GetToken(CommandLineParser.UnixStyleFlaggedIdentifiers, 0); }
		public UnixStyleFlaggedSwitchContext(ParameterContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICommandLineVisitor<TResult> typedVisitor = visitor as ICommandLineVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnixStyleFlaggedSwitch(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class WindowsStyleSwitchContext : ParameterContext {
		public ITerminalNode WindowsStyleIdentifier() { return GetToken(CommandLineParser.WindowsStyleIdentifier, 0); }
		public WindowsStyleSwitchContext(ParameterContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICommandLineVisitor<TResult> typedVisitor = visitor as ICommandLineVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWindowsStyleSwitch(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParameterContext parameter() {
		ParameterContext _localctx = new ParameterContext(Context, State);
		EnterRule(_localctx, 4, RULE_parameter);
		try {
			State = 35;
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				_localctx = new WindowsStyleSwitchContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 22; Match(WindowsStyleIdentifier);
				}
				break;
			case 2:
				_localctx = new WindowsStyleParameterContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 23; Match(WindowsStyleIdentifier);
				State = 24; Match(AssignmentOperator);
				State = 25; value();
				}
				break;
			case 3:
				_localctx = new WindowsStyleParameterContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 26; Match(WindowsStyleIdentifier);
				State = 27; value();
				}
				break;
			case 4:
				_localctx = new UnixStyleSwitchContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 28; Match(UnixStyleIdentifier);
				}
				break;
			case 5:
				_localctx = new UnixStyleParameterContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 29; Match(UnixStyleIdentifier);
				State = 30; Match(AssignmentOperator);
				State = 31; value();
				}
				break;
			case 6:
				_localctx = new UnixStyleParameterContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 32; Match(UnixStyleIdentifier);
				State = 33; value();
				}
				break;
			case 7:
				_localctx = new UnixStyleFlaggedSwitchContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 34; Match(UnixStyleFlaggedIdentifiers);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ValueContext : ParserRuleContext {
		public ValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_value; } }
	 
		public ValueContext() { }
		public virtual void CopyFrom(ValueContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class NumberContext : ValueContext {
		public ITerminalNode Number() { return GetToken(CommandLineParser.Number, 0); }
		public NumberContext(ValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICommandLineVisitor<TResult> typedVisitor = visitor as ICommandLineVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumber(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class StringContext : ValueContext {
		public ITerminalNode String() { return GetToken(CommandLineParser.String, 0); }
		public ITerminalNode QuotedString() { return GetToken(CommandLineParser.QuotedString, 0); }
		public StringContext(ValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICommandLineVisitor<TResult> typedVisitor = visitor as ICommandLineVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitString(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ArrayContext : ValueContext {
		public ValueContext[] value() {
			return GetRuleContexts<ValueContext>();
		}
		public ValueContext value(int i) {
			return GetRuleContext<ValueContext>(i);
		}
		public ArrayContext(ValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICommandLineVisitor<TResult> typedVisitor = visitor as ICommandLineVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArray(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BooleanContext : ValueContext {
		public ITerminalNode True() { return GetToken(CommandLineParser.True, 0); }
		public ITerminalNode False() { return GetToken(CommandLineParser.False, 0); }
		public BooleanContext(ValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICommandLineVisitor<TResult> typedVisitor = visitor as ICommandLineVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBoolean(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ValueContext value() {
		ValueContext _localctx = new ValueContext(Context, State);
		EnterRule(_localctx, 6, RULE_value);
		int _la;
		try {
			State = 54;
			switch (TokenStream.La(1)) {
			case String:
				_localctx = new StringContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 37; Match(String);
				}
				break;
			case QuotedString:
				_localctx = new StringContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 38; Match(QuotedString);
				}
				break;
			case Number:
				_localctx = new NumberContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 39; Match(Number);
				}
				break;
			case T__0:
				_localctx = new ArrayContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 40; Match(T__0);
				State = 49;
				_la = TokenStream.La(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << True) | (1L << False) | (1L << Number) | (1L << String) | (1L << QuotedString))) != 0)) {
					{
					State = 41; value();
					State = 46;
					ErrorHandler.Sync(this);
					_la = TokenStream.La(1);
					while (_la==T__1) {
						{
						{
						State = 42; Match(T__1);
						State = 43; value();
						}
						}
						State = 48;
						ErrorHandler.Sync(this);
						_la = TokenStream.La(1);
					}
					}
				}

				State = 51; Match(T__2);
				}
				break;
			case True:
				_localctx = new BooleanContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 52; Match(True);
				}
				break;
			case False:
				_localctx = new BooleanContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 53; Match(False);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\x10;\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x3\x2\a\x2\f\n\x2\f\x2\xE\x2\xF\v\x2"+
		"\x3\x2\a\x2\x12\n\x2\f\x2\xE\x2\x15\v\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4&\n"+
		"\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\a\x5/\n\x5\f\x5\xE\x5\x32"+
		"\v\x5\x5\x5\x34\n\x5\x3\x5\x3\x5\x3\x5\x5\x5\x39\n\x5\x3\x5\x2\x2\x6\x2"+
		"\x4\x6\b\x2\x3\x3\x2\xE\xF\x45\x2\r\x3\x2\x2\x2\x4\x16\x3\x2\x2\x2\x6"+
		"%\x3\x2\x2\x2\b\x38\x3\x2\x2\x2\n\f\x5\x4\x3\x2\v\n\x3\x2\x2\x2\f\xF\x3"+
		"\x2\x2\x2\r\v\x3\x2\x2\x2\r\xE\x3\x2\x2\x2\xE\x13\x3\x2\x2\x2\xF\r\x3"+
		"\x2\x2\x2\x10\x12\x5\x6\x4\x2\x11\x10\x3\x2\x2\x2\x12\x15\x3\x2\x2\x2"+
		"\x13\x11\x3\x2\x2\x2\x13\x14\x3\x2\x2\x2\x14\x3\x3\x2\x2\x2\x15\x13\x3"+
		"\x2\x2\x2\x16\x17\t\x2\x2\x2\x17\x5\x3\x2\x2\x2\x18&\a\a\x2\x2\x19\x1A"+
		"\a\a\x2\x2\x1A\x1B\a\t\x2\x2\x1B&\x5\b\x5\x2\x1C\x1D\a\a\x2\x2\x1D&\x5"+
		"\b\x5\x2\x1E&\a\b\x2\x2\x1F \a\b\x2\x2 !\a\t\x2\x2!&\x5\b\x5\x2\"#\a\b"+
		"\x2\x2#&\x5\b\x5\x2$&\a\x6\x2\x2%\x18\x3\x2\x2\x2%\x19\x3\x2\x2\x2%\x1C"+
		"\x3\x2\x2\x2%\x1E\x3\x2\x2\x2%\x1F\x3\x2\x2\x2%\"\x3\x2\x2\x2%$\x3\x2"+
		"\x2\x2&\a\x3\x2\x2\x2\'\x39\a\xE\x2\x2(\x39\a\xF\x2\x2)\x39\a\f\x2\x2"+
		"*\x33\a\x3\x2\x2+\x30\x5\b\x5\x2,-\a\x4\x2\x2-/\x5\b\x5\x2.,\x3\x2\x2"+
		"\x2/\x32\x3\x2\x2\x2\x30.\x3\x2\x2\x2\x30\x31\x3\x2\x2\x2\x31\x34\x3\x2"+
		"\x2\x2\x32\x30\x3\x2\x2\x2\x33+\x3\x2\x2\x2\x33\x34\x3\x2\x2\x2\x34\x35"+
		"\x3\x2\x2\x2\x35\x39\a\x5\x2\x2\x36\x39\a\n\x2\x2\x37\x39\a\v\x2\x2\x38"+
		"\'\x3\x2\x2\x2\x38(\x3\x2\x2\x2\x38)\x3\x2\x2\x2\x38*\x3\x2\x2\x2\x38"+
		"\x36\x3\x2\x2\x2\x38\x37\x3\x2\x2\x2\x39\t\x3\x2\x2\x2\b\r\x13%\x30\x33"+
		"\x38";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace System.CommandLine.Parser.Antlr
