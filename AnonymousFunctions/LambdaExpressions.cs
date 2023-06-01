/* C# Lambda Expressions
* Lambda expression is an anonymous function which we can use to create delegates. 
* We can use lambda expression to create local functions that can be passed as an argument. 
* It is also helpful to write LINQ queries.
*/

/* 
    C# Lambda Expression Syntax
    !(input-parameters) => expression   
*/
using System;

class LambdaExpressions
{
    delegate int Square(int num);
    static void Main(string[] jp)
    {
        Square GetSquare = x => x * x;
        int j = GetSquare(5);
        System.Console.WriteLine("Square is : "+j);

    }
}