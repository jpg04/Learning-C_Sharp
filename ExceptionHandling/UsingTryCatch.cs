/* C# try/catch
 
In C# programming, exception handling is performed by try/catch statement. 
The try block in C# is used to place the code that may throw exception. 
The catch block is used to handled the exception. The catch block must be preceded by try 
.
*/
using System;
namespace ExceptionHandling
{
    class TryCatch
    {
        public static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("Using Try Catch");
        }
    }
}

/* 
Unhandled Exception: System.DivideByZeroException: Attempted to divide by zero.
   at ExceptionHandling.TryCatch.Main(String[] args)
 */