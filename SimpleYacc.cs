// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  IRU-TAULING
// DateTime: 29.04.2020 12:34:17
// UserName: ??????
// Input file <SimpleYacc.y>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using System.IO;
using ProgramTree;

namespace SimpleParser
{
public enum Tokens {
    error=1,EOF=2,BEGIN=3,END=4,ASSIGN=5,SEMICOLON=6,
    FOR=7,COMMA=8,COLON=9,LPAR=10,RPAR=11,WHILE=12,
    IF=13,ELSE=14,INPUT=15,PRINT=16,VAR=17,OR=18,
    AND=19,EQUAL=20,NOTEQUAL=21,LESS=22,GREATER=23,EQGREATER=24,
    EQLESS=25,GOTO=26,PLUS=27,MINUS=28,MULT=29,DIV=30,
    NOT=31,INUM=32,BOOL=33,ID=34};

public struct ValueType
{ 
			public bool bVal; 
			public int iVal; 
			public string sVal; 
			public Node nVal;
			public ExprNode eVal;
			public StatementNode stVal;
			public StListNode blVal;
       }
// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from SimpleYacc.y
    public StListNode root;
    public Parser(AbstractScanner<ValueType, LexLocation> scanner) : base(scanner) { }
	private bool InDefSect = false;
  // End verbatim content from SimpleYacc.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[56];
  private static State[] states = new State[105];
  private static string[] nonTerms = new string[] {
      "expr", "ident", "A", "B", "C", "E", "T", "F", "exprlist", "assign", "statement", 
      "for", "while", "if", "input", "print", "varlist", "var", "labelstatement", 
      "goto", "block", "stlist", "progr", "$accept", "Anon@1", };

  static Parser() {
    states[0] = new State(new int[]{34,23,7,52,12,60,13,64,3,70,15,75,16,81,17,90,26,98,32,101},new int[]{-23,1,-22,3,-11,104,-10,5,-2,7,-12,51,-13,59,-14,63,-21,69,-15,73,-16,79,-18,88,-20,96,-19,100});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{34,23,7,52,12,60,13,64,3,70,15,75,16,81,17,90,26,98,32,101,2,-2},new int[]{-11,4,-10,5,-2,7,-12,51,-13,59,-14,63,-21,69,-15,73,-16,79,-18,88,-20,96,-19,100});
    states[4] = new State(-4);
    states[5] = new State(new int[]{6,6});
    states[6] = new State(-5);
    states[7] = new State(new int[]{5,8});
    states[8] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-1,9,-3,28,-4,29,-5,50,-6,49,-7,44,-8,43,-2,22});
    states[9] = new State(new int[]{18,10,6,-16});
    states[10] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-3,11,-4,29,-5,50,-6,49,-7,44,-8,43,-2,22});
    states[11] = new State(new int[]{19,12,18,-22,6,-22,11,-22,8,-22,34,-22,7,-22,12,-22,13,-22,3,-22,15,-22,16,-22,17,-22,26,-22,32,-22});
    states[12] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-4,13,-5,50,-6,49,-7,44,-8,43,-2,22});
    states[13] = new State(new int[]{20,14,21,30,19,-24,18,-24,6,-24,11,-24,8,-24,34,-24,7,-24,12,-24,13,-24,3,-24,15,-24,16,-24,17,-24,26,-24,32,-24});
    states[14] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-5,15,-6,49,-7,44,-8,43,-2,22});
    states[15] = new State(new int[]{23,16,22,32,24,45,25,47,20,-26,21,-26,19,-26,18,-26,6,-26,11,-26,8,-26,34,-26,7,-26,12,-26,13,-26,3,-26,15,-26,16,-26,17,-26,26,-26,32,-26});
    states[16] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-6,17,-7,44,-8,43,-2,22});
    states[17] = new State(new int[]{27,18,28,34,23,-29,22,-29,24,-29,25,-29,20,-29,21,-29,19,-29,18,-29,6,-29,11,-29,8,-29,34,-29,7,-29,12,-29,13,-29,3,-29,15,-29,16,-29,17,-29,26,-29,32,-29});
    states[18] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-7,19,-8,43,-2,22});
    states[19] = new State(new int[]{29,20,30,36,27,-34,28,-34,23,-34,22,-34,24,-34,25,-34,20,-34,21,-34,19,-34,18,-34,6,-34,11,-34,8,-34,34,-34,7,-34,12,-34,13,-34,3,-34,15,-34,16,-34,17,-34,26,-34,32,-34});
    states[20] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-8,21,-2,22});
    states[21] = new State(-37);
    states[22] = new State(-40);
    states[23] = new State(-15);
    states[24] = new State(-41);
    states[25] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-1,26,-3,28,-4,29,-5,50,-6,49,-7,44,-8,43,-2,22});
    states[26] = new State(new int[]{11,27,18,10});
    states[27] = new State(-42);
    states[28] = new State(new int[]{19,12,18,-23,6,-23,11,-23,8,-23,34,-23,7,-23,12,-23,13,-23,3,-23,15,-23,16,-23,17,-23,26,-23,32,-23});
    states[29] = new State(new int[]{20,14,21,30,19,-25,18,-25,6,-25,11,-25,8,-25,34,-25,7,-25,12,-25,13,-25,3,-25,15,-25,16,-25,17,-25,26,-25,32,-25});
    states[30] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-5,31,-6,49,-7,44,-8,43,-2,22});
    states[31] = new State(new int[]{23,16,22,32,24,45,25,47,20,-27,21,-27,19,-27,18,-27,6,-27,11,-27,8,-27,34,-27,7,-27,12,-27,13,-27,3,-27,15,-27,16,-27,17,-27,26,-27,32,-27});
    states[32] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-6,33,-7,44,-8,43,-2,22});
    states[33] = new State(new int[]{27,18,28,34,23,-30,22,-30,24,-30,25,-30,20,-30,21,-30,19,-30,18,-30,6,-30,11,-30,8,-30,34,-30,7,-30,12,-30,13,-30,3,-30,15,-30,16,-30,17,-30,26,-30,32,-30});
    states[34] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-7,35,-8,43,-2,22});
    states[35] = new State(new int[]{29,20,30,36,27,-35,28,-35,23,-35,22,-35,24,-35,25,-35,20,-35,21,-35,19,-35,18,-35,6,-35,11,-35,8,-35,34,-35,7,-35,12,-35,13,-35,3,-35,15,-35,16,-35,17,-35,26,-35,32,-35});
    states[36] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-8,37,-2,22});
    states[37] = new State(-38);
    states[38] = new State(-43);
    states[39] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-8,40,-2,22});
    states[40] = new State(-44);
    states[41] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-8,42,-2,22});
    states[42] = new State(-45);
    states[43] = new State(-39);
    states[44] = new State(new int[]{29,20,30,36,27,-36,28,-36,23,-36,22,-36,24,-36,25,-36,20,-36,21,-36,19,-36,18,-36,6,-36,11,-36,8,-36,34,-36,7,-36,12,-36,13,-36,3,-36,15,-36,16,-36,17,-36,26,-36,32,-36});
    states[45] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-6,46,-7,44,-8,43,-2,22});
    states[46] = new State(new int[]{27,18,28,34,23,-31,22,-31,24,-31,25,-31,20,-31,21,-31,19,-31,18,-31,6,-31,11,-31,8,-31,34,-31,7,-31,12,-31,13,-31,3,-31,15,-31,16,-31,17,-31,26,-31,32,-31});
    states[47] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-6,48,-7,44,-8,43,-2,22});
    states[48] = new State(new int[]{27,18,28,34,23,-32,22,-32,24,-32,25,-32,20,-32,21,-32,19,-32,18,-32,6,-32,11,-32,8,-32,34,-32,7,-32,12,-32,13,-32,3,-32,15,-32,16,-32,17,-32,26,-32,32,-32});
    states[49] = new State(new int[]{27,18,28,34,23,-33,22,-33,24,-33,25,-33,20,-33,21,-33,19,-33,18,-33,6,-33,11,-33,8,-33,34,-33,7,-33,12,-33,13,-33,3,-33,15,-33,16,-33,17,-33,26,-33,32,-33});
    states[50] = new State(new int[]{23,16,22,32,24,45,25,47,20,-28,21,-28,19,-28,18,-28,6,-28,11,-28,8,-28,34,-28,7,-28,12,-28,13,-28,3,-28,15,-28,16,-28,17,-28,26,-28,32,-28});
    states[51] = new State(-6);
    states[52] = new State(new int[]{34,23},new int[]{-2,53});
    states[53] = new State(new int[]{5,54});
    states[54] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-1,55,-3,28,-4,29,-5,50,-6,49,-7,44,-8,43,-2,22});
    states[55] = new State(new int[]{8,56,18,10});
    states[56] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-1,57,-3,28,-4,29,-5,50,-6,49,-7,44,-8,43,-2,22});
    states[57] = new State(new int[]{18,10,34,23,7,52,12,60,13,64,3,70,15,75,16,81,17,90,26,98,32,101},new int[]{-11,58,-10,5,-2,7,-12,51,-13,59,-14,63,-21,69,-15,73,-16,79,-18,88,-20,96,-19,100});
    states[58] = new State(-18);
    states[59] = new State(-7);
    states[60] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-1,61,-3,28,-4,29,-5,50,-6,49,-7,44,-8,43,-2,22});
    states[61] = new State(new int[]{18,10,34,23,7,52,12,60,13,64,3,70,15,75,16,81,17,90,26,98,32,101},new int[]{-11,62,-10,5,-2,7,-12,51,-13,59,-14,63,-21,69,-15,73,-16,79,-18,88,-20,96,-19,100});
    states[62] = new State(-19);
    states[63] = new State(-8);
    states[64] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-1,65,-3,28,-4,29,-5,50,-6,49,-7,44,-8,43,-2,22});
    states[65] = new State(new int[]{18,10,34,23,7,52,12,60,13,64,3,70,15,75,16,81,17,90,26,98,32,101},new int[]{-11,66,-10,5,-2,7,-12,51,-13,59,-14,63,-21,69,-15,73,-16,79,-18,88,-20,96,-19,100});
    states[66] = new State(new int[]{14,67,34,-21,7,-21,12,-21,13,-21,3,-21,15,-21,16,-21,17,-21,26,-21,32,-21,2,-21,4,-21});
    states[67] = new State(new int[]{34,23,7,52,12,60,13,64,3,70,15,75,16,81,17,90,26,98,32,101},new int[]{-11,68,-10,5,-2,7,-12,51,-13,59,-14,63,-21,69,-15,73,-16,79,-18,88,-20,96,-19,100});
    states[68] = new State(-20);
    states[69] = new State(-9);
    states[70] = new State(new int[]{34,23,7,52,12,60,13,64,3,70,15,75,16,81,17,90,26,98,32,101},new int[]{-22,71,-11,104,-10,5,-2,7,-12,51,-13,59,-14,63,-21,69,-15,73,-16,79,-18,88,-20,96,-19,100});
    states[71] = new State(new int[]{4,72,34,23,7,52,12,60,13,64,3,70,15,75,16,81,17,90,26,98,32,101},new int[]{-11,4,-10,5,-2,7,-12,51,-13,59,-14,63,-21,69,-15,73,-16,79,-18,88,-20,96,-19,100});
    states[72] = new State(-17);
    states[73] = new State(new int[]{6,74});
    states[74] = new State(-10);
    states[75] = new State(new int[]{10,76});
    states[76] = new State(new int[]{34,23},new int[]{-2,77});
    states[77] = new State(new int[]{11,78});
    states[78] = new State(-46);
    states[79] = new State(new int[]{6,80});
    states[80] = new State(-11);
    states[81] = new State(new int[]{10,82});
    states[82] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-9,83,-1,87,-3,28,-4,29,-5,50,-6,49,-7,44,-8,43,-2,22});
    states[83] = new State(new int[]{11,84,8,85});
    states[84] = new State(-49);
    states[85] = new State(new int[]{34,23,32,24,10,25,33,38,28,39,31,41},new int[]{-1,86,-3,28,-4,29,-5,50,-6,49,-7,44,-8,43,-2,22});
    states[86] = new State(new int[]{18,10,11,-48,8,-48});
    states[87] = new State(new int[]{18,10,11,-47,8,-47});
    states[88] = new State(new int[]{6,89});
    states[89] = new State(-12);
    states[90] = new State(-52,new int[]{-25,91});
    states[91] = new State(new int[]{34,23},new int[]{-17,92,-2,95});
    states[92] = new State(new int[]{8,93,6,-53});
    states[93] = new State(new int[]{34,23},new int[]{-2,94});
    states[94] = new State(-51);
    states[95] = new State(-50);
    states[96] = new State(new int[]{6,97});
    states[97] = new State(-13);
    states[98] = new State(new int[]{32,99});
    states[99] = new State(-54);
    states[100] = new State(-14);
    states[101] = new State(new int[]{9,102});
    states[102] = new State(new int[]{34,23,7,52,12,60,13,64,3,70,15,75,16,81,17,90,26,98,32,101},new int[]{-11,103,-10,5,-2,7,-12,51,-13,59,-14,63,-21,69,-15,73,-16,79,-18,88,-20,96,-19,100});
    states[103] = new State(-55);
    states[104] = new State(-3);

    rules[1] = new Rule(-24, new int[]{-23,2});
    rules[2] = new Rule(-23, new int[]{-22});
    rules[3] = new Rule(-22, new int[]{-11});
    rules[4] = new Rule(-22, new int[]{-22,-11});
    rules[5] = new Rule(-11, new int[]{-10,6});
    rules[6] = new Rule(-11, new int[]{-12});
    rules[7] = new Rule(-11, new int[]{-13});
    rules[8] = new Rule(-11, new int[]{-14});
    rules[9] = new Rule(-11, new int[]{-21});
    rules[10] = new Rule(-11, new int[]{-15,6});
    rules[11] = new Rule(-11, new int[]{-16,6});
    rules[12] = new Rule(-11, new int[]{-18,6});
    rules[13] = new Rule(-11, new int[]{-20,6});
    rules[14] = new Rule(-11, new int[]{-19});
    rules[15] = new Rule(-2, new int[]{34});
    rules[16] = new Rule(-10, new int[]{-2,5,-1});
    rules[17] = new Rule(-21, new int[]{3,-22,4});
    rules[18] = new Rule(-12, new int[]{7,-2,5,-1,8,-1,-11});
    rules[19] = new Rule(-13, new int[]{12,-1,-11});
    rules[20] = new Rule(-14, new int[]{13,-1,-11,14,-11});
    rules[21] = new Rule(-14, new int[]{13,-1,-11});
    rules[22] = new Rule(-1, new int[]{-1,18,-3});
    rules[23] = new Rule(-1, new int[]{-3});
    rules[24] = new Rule(-3, new int[]{-3,19,-4});
    rules[25] = new Rule(-3, new int[]{-4});
    rules[26] = new Rule(-4, new int[]{-4,20,-5});
    rules[27] = new Rule(-4, new int[]{-4,21,-5});
    rules[28] = new Rule(-4, new int[]{-5});
    rules[29] = new Rule(-5, new int[]{-5,23,-6});
    rules[30] = new Rule(-5, new int[]{-5,22,-6});
    rules[31] = new Rule(-5, new int[]{-5,24,-6});
    rules[32] = new Rule(-5, new int[]{-5,25,-6});
    rules[33] = new Rule(-5, new int[]{-6});
    rules[34] = new Rule(-6, new int[]{-6,27,-7});
    rules[35] = new Rule(-6, new int[]{-6,28,-7});
    rules[36] = new Rule(-6, new int[]{-7});
    rules[37] = new Rule(-7, new int[]{-7,29,-8});
    rules[38] = new Rule(-7, new int[]{-7,30,-8});
    rules[39] = new Rule(-7, new int[]{-8});
    rules[40] = new Rule(-8, new int[]{-2});
    rules[41] = new Rule(-8, new int[]{32});
    rules[42] = new Rule(-8, new int[]{10,-1,11});
    rules[43] = new Rule(-8, new int[]{33});
    rules[44] = new Rule(-8, new int[]{28,-8});
    rules[45] = new Rule(-8, new int[]{31,-8});
    rules[46] = new Rule(-15, new int[]{15,10,-2,11});
    rules[47] = new Rule(-9, new int[]{-1});
    rules[48] = new Rule(-9, new int[]{-9,8,-1});
    rules[49] = new Rule(-16, new int[]{16,10,-9,11});
    rules[50] = new Rule(-17, new int[]{-2});
    rules[51] = new Rule(-17, new int[]{-17,8,-2});
    rules[52] = new Rule(-25, new int[]{});
    rules[53] = new Rule(-18, new int[]{17,-25,-17});
    rules[54] = new Rule(-20, new int[]{26,32});
    rules[55] = new Rule(-19, new int[]{32,9,-11});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 2: // progr -> stlist
{ root = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 3: // stlist -> statement
{ CurrentSemanticValue.blVal = new StListNode(ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 4: // stlist -> stlist, statement
{ 
				ValueStack[ValueStack.Depth-2].blVal.Add(ValueStack[ValueStack.Depth-1].stVal); 
				CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-2].blVal; 
			}
        break;
      case 5: // statement -> assign, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 6: // statement -> for
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 7: // statement -> while
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 8: // statement -> if
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 9: // statement -> block
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 10: // statement -> input, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 11: // statement -> print, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 12: // statement -> var, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 13: // statement -> goto, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 14: // statement -> labelstatement
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 15: // ident -> ID
{ 
			if (!InDefSect)
				if (!SymbolTable.vars.ContainsKey(ValueStack[ValueStack.Depth-1].sVal))
					throw new Exception("("+LocationStack[LocationStack.Depth-1].StartLine+","+LocationStack[LocationStack.Depth-1].StartColumn+"): Variable "+ValueStack[ValueStack.Depth-1].sVal+" not described");
			CurrentSemanticValue.eVal = new IdNode(ValueStack[ValueStack.Depth-1].sVal); 
		}
        break;
      case 16: // assign -> ident, ASSIGN, expr
{ CurrentSemanticValue.stVal = new AssignNode(ValueStack[ValueStack.Depth-3].eVal as IdNode, ValueStack[ValueStack.Depth-1].eVal); }
        break;
      case 17: // block -> BEGIN, stlist, END
{ CurrentSemanticValue.stVal = new BlockNode(ValueStack[ValueStack.Depth-2].blVal); }
        break;
      case 18: // for -> FOR, ident, ASSIGN, expr, COMMA, expr, statement
{ CurrentSemanticValue.stVal = new ForNode(ValueStack[ValueStack.Depth-6].eVal as IdNode, ValueStack[ValueStack.Depth-4].eVal, ValueStack[ValueStack.Depth-2].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 19: // while -> WHILE, expr, statement
{ CurrentSemanticValue.stVal = new WhileNode(ValueStack[ValueStack.Depth-2].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 20: // if -> IF, expr, statement, ELSE, statement
{ CurrentSemanticValue.stVal = new IfElseNode(ValueStack[ValueStack.Depth-4].eVal, ValueStack[ValueStack.Depth-3].stVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 21: // if -> IF, expr, statement
{ CurrentSemanticValue.stVal = new IfElseNode(ValueStack[ValueStack.Depth-2].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 22: // expr -> expr, OR, A
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.OR); }
        break;
      case 23: // expr -> A
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 24: // A -> A, AND, B
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.AND); }
        break;
      case 25: // A -> B
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 26: // B -> B, EQUAL, C
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.EQUAL); }
        break;
      case 27: // B -> B, NOTEQUAL, C
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.NOTEQUAL); }
        break;
      case 28: // B -> C
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 29: // C -> C, GREATER, E
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.GREATER); }
        break;
      case 30: // C -> C, LESS, E
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.LESS); }
        break;
      case 31: // C -> C, EQGREATER, E
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.EQGREATER); }
        break;
      case 32: // C -> C, EQLESS, E
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.EQLESS); }
        break;
      case 33: // C -> E
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 34: // E -> E, PLUS, T
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.PLUS); }
        break;
      case 35: // E -> E, MINUS, T
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.MINUS); }
        break;
      case 36: // E -> T
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 37: // T -> T, MULT, F
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.MULT); }
        break;
      case 38: // T -> T, DIV, F
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.DIV); }
        break;
      case 39: // T -> F
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 40: // F -> ident
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal as IdNode; }
        break;
      case 41: // F -> INUM
{ CurrentSemanticValue.eVal = new IntNumNode(ValueStack[ValueStack.Depth-1].iVal); }
        break;
      case 42: // F -> LPAR, expr, RPAR
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-2].eVal; }
        break;
      case 43: // F -> BOOL
{ CurrentSemanticValue.eVal = new BoolValNode(ValueStack[ValueStack.Depth-1].bVal); }
        break;
      case 44: // F -> MINUS, F
{ CurrentSemanticValue.eVal = new UnOpNode(ValueStack[ValueStack.Depth-1].eVal, OpType.UNMINUS); }
        break;
      case 45: // F -> NOT, F
{ CurrentSemanticValue.eVal = new UnOpNode(ValueStack[ValueStack.Depth-1].eVal, OpType.NOT);}
        break;
      case 46: // input -> INPUT, LPAR, ident, RPAR
{ CurrentSemanticValue.stVal = new InputNode(ValueStack[ValueStack.Depth-2].eVal as IdNode); }
        break;
      case 47: // exprlist -> expr
{ CurrentSemanticValue.eVal = new ExprListNode(ValueStack[ValueStack.Depth-1].eVal); }
        break;
      case 48: // exprlist -> exprlist, COMMA, expr
{	
			(ValueStack[ValueStack.Depth-3].eVal as ExprListNode).Add(ValueStack[ValueStack.Depth-1].eVal); 
			CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-3].eVal; 
		}
        break;
      case 49: // print -> PRINT, LPAR, exprlist, RPAR
{ CurrentSemanticValue.stVal = new PrintNode(ValueStack[ValueStack.Depth-2].eVal as ExprListNode); }
        break;
      case 50: // varlist -> ident
{ CurrentSemanticValue.stVal = new VarListNode(ValueStack[ValueStack.Depth-1].eVal as IdNode); }
        break;
      case 51: // varlist -> varlist, COMMA, ident
{
			(ValueStack[ValueStack.Depth-3].stVal as VarListNode).Add(ValueStack[ValueStack.Depth-1].eVal as IdNode); 
			CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-3].stVal; 
		}
        break;
      case 52: // Anon@1 -> /* empty */
{ InDefSect = true; }
        break;
      case 53: // var -> VAR, Anon@1, varlist
{ 
				foreach (var v in (ValueStack[ValueStack.Depth-1].stVal as VarListNode).vars)
					SymbolTable.NewVarDef(v.Name);
				InDefSect = false;	
			}
        break;
      case 54: // goto -> GOTO, INUM
{ CurrentSemanticValue.stVal = new GotoNode(ValueStack[ValueStack.Depth-1].iVal); }
        break;
      case 55: // labelstatement -> INUM, COLON, statement
{ CurrentSemanticValue.stVal = new LabelStatementNode(ValueStack[ValueStack.Depth-3].iVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
