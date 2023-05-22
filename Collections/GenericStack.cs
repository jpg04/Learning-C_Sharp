/*  
*C# Stack<T> class is used to push and pop elements. 
*It uses the concept of Stack that arranges elements in LIFO (Last In First Out) order. 
*It can have duplicate elements. 
*It is found in System.Collections.Generic namespace.
*/

using System;
using System.Collections.Generic;

class GenericStack
{
    static void Main(string[] jp)
    {
        Stack<string> names = new Stack<string>();

        names.Push("Jaydeep");
        names.Push("Jay");
        names.Push("Deep");
        names.Push("JP");
        names.Push("JD");
        names.Push("Anna");

        foreach(string name in names)
        {
            System.Console.WriteLine(name);
        }
        System.Console.WriteLine("Peek element : "+names.Peek());
        System.Console.WriteLine("Pop element : "+names.Pop());
        System.Console.WriteLine("After POP, Peek element is : "+names.Peek ());


    }
}