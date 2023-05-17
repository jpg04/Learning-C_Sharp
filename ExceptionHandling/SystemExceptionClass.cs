/* C# SystemException class
The SystemException is a predefined exception class in C#. 
It is used to handle system related exceptions. 
It works as base class for system exception namespace. 
It has various child classes 
like: ValidationException, ArgumentException, ArithmeticException, DataException, StackOverflowException etc.

It consists of rich constructors, properties and methods that we have tabled below.
*/

/* C# SystemException Signature

    [SerializableAttribute]  
    [ComVisibleAttribute(true)]  
    public class SystemException : Exception  

*/


/* C# SystemException Example

This class can be used to handle exception of subclasses. 
Here, in the following program, program throws an IndexOutOfRangeException that is subclass of SystemException class. 

*/
using System;
class SystemExceptionClass
{
    static void Main(string[] args)
    {
        try
        {
            int[] Arr = new int[5];
            Arr[10] = 25;
        }
        catch(SystemException e)
        {
            System.Console.WriteLine(e);
        }
    }
}