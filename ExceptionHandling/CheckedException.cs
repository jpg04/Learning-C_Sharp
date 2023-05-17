/* C# Checked Example using checked
-This program throws an exception and stops program execution.
*/
using System;
class CheckedAndUnchecked
{
    static void Main(string[] arg)
    {
        checked
        {
            int val = int.MaxValue;
            System.Console.WriteLine(val + 2);
        }
    }
}

/* 
Unhandled Exception: System.OverflowException: Arithmetic operation resulted in an overflow.
 */