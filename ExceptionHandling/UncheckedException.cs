/* C# Unchecked
The Unchecked keyword ignores the integral type arithmetic exceptions. 
It does not check explicitly and produce result that may be truncated or wrong.
*/
using System;

class UncheckedException
{
   static void Main(string []arg)
   {
        unchecked
        {
            int val = int.MaxValue;
            System.Console.WriteLine(val+2);
        }
   }
}

/*
 -2147483647
*/