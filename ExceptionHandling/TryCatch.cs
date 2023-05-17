/* C# Exception Handling
Exception Handling in C# is a process to handle runtime errors. 
We perform exception handling so that normal flow of the application can be maintained even after runtime errors.

In C#, exception is an event or object which is thrown at runtime. 
All exceptions the derived from System.Exception class. It is a runtime error which can be handled. 
If we don't handle the exception, it prints exception message and terminates the program.
*/
using System;
namespace ExceptionHandling
{
    class TryCatch
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            int c = a / b;

            System.Console.WriteLine("Some another code...!");
        }
    }
}

/* 
Unhandled Exception: System.DivideByZeroException: Attempted to divide by zero.
   at ExceptionHandling.TryCatch.Main(String[] args)
 */