/* C# Checked and Unchecked

C# provides checked and unchecked keyword to handle integral type exceptions. 
Checked and unchecked keywords specify checked context and unchecked context respectively. 
In checked context, arithmetic overflow raises an exception whereas, in an unchecked context, 
arithmetic overflow is ignored and result is truncated.

*/

using System;

class WithoutUsingCheckedKeyword
{
    static void Main(string[] args)
    {
        int val = int.MaxValue;
        System.Console.WriteLine(val+2);
    }
}