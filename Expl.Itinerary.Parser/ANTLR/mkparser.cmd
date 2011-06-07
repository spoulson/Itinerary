@echo off
pushd %~dp0

:: Compile ANTLR grammar to lexer/parser code.
:: Outputs files: TimeDefLexer.cs, TimeDefParser.cs
java -cp antlr-3.2.jar org.antlr.Tool TimeDef.g

popd
