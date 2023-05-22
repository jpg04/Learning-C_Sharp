/* C# List<T> class is used to store and fetch elements. 
It can have duplicate elements. 
It is found in System.Collections.Generic namespace. 
*/

/* xample of generic List<T> class that stores elements using Add() method and 
iterates the list using for-each loop. 
*/

using System;
using System.Collections.Generic;

class GenericListAdd
{
    static void Main(string[] jp)
    {
        // creating list of String

        var names = new List<string>();

        names.Add("Jay");
        names.Add("Deep");
        names.Add("Jaydeep");
        names.Add("JP");

        // Iterate list element using foreach loop  
        foreach(var name in names)
        {
            System.Console.WriteLine(name);
        }
    }
}