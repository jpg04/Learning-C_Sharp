﻿using Microsoft.VisualBasic;
using System;
using System.Xml.Linq;

namespace ExampleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Shree Ganesha");
            //System.Console.WriteLine("String is : " + str2);
            //Loops loops = new Loops();
            //WhileLoop whileLoop = new WhileLoop();
            //Variables variables = new Variables();
            //DataTypes dataTypes = new DataTypes();  

            //Function function = new Function();
            //function.msg();

            //BasicSyntax basic = new BasicSyntax();
            //basic.DisplayBasicSyntax();

            //ModulasOperator mod = new ModulasOperator();

            //Increment_And_Decrement_Operator inde = new Increment_And_Decrement_Operator();

            //IsOperator isop = new IsOperator();

            //bool b = isop is Ex1;
            //Console.WriteLine(b);

            //AsOperator asop = new AsOperator();
            //string str = "Jaydeep";
            //object obj = str;
            //string str2 = obj as string;

            //TernaryOprator ternary = new TernaryOprator();

            //NullCoalescing nullCoalescing = new NullCoalescing();

            //SizeOfOperator sizeOfOperator = new SizeOfOperator();

            //TypeOfOperator typeOfOperator = new TypeOfOperator();

            //Box box1 = new Box(2, 2, 2);
            //Box box2 = new Box(2, 2, 2);
            //Box box3 = box1 + box2;

            //Console.WriteLine("Length : " + box3.GetLength());
            //Console.WriteLine("Width : " + box3.GetWidth());
            //Console.WriteLine("Height : " + box3.GetHeight());

            //BuiltInDataTyes builtInDataTyes = new BuiltInDataTyes();

            //TypeCasting typeCasting = new TypeCasting();

            //TakingInputFromUser takingInputFromUser = new TakingInputFromUser();

            //OperatorsInCS operatorsInCS = new OperatorsInCS();

            //MathClassinCS mathClassinCS = new MathClassinCS();

            //StringMethod stringMethod = new StringMethod();

            //DecisionMakingStatement decisionMakingStatement = new DecisionMakingStatement();

            //IfElseLadder ifElseLadder = new IfElseLadder();

            //IfElseLadderInLogicalOperator ifElseLadderInLogicalOperator = new IfElseLadderInLogicalOperator();

            //SwitchCase switchCase = new SwitchCase();

            //LoopInCSharp loopInCSharp = new LoopInCSharp(); 

            //ForLoopInCSharp loopInCSharp = new ForLoopInCSharp();   

            //DoWhileINCSharp doWhileINCSharp = new DoWhileINCSharp();

            //BreakAndContinue breakAndContinue   = new BreakAndContinue();

            MethodsInCSharp methodsInCSharp = new MethodsInCSharp();

            MethodsInCSharp.Greet();
            MethodsInCSharp.Greet("Jaydeep");

            Console.WriteLine("Average of Given Number is : "+MethodsInCSharp.Average(12, 123, 213));

            float temp = MethodsInCSharp.Average(12, 23, 12);
            Console.WriteLine(temp);








        }
    }
}
