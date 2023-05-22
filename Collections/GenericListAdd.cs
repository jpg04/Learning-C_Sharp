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
    
        System.Console.WriteLine("---RemoveAt(3)--- This Function Will remove elements at index No 3");
        names.RemoveAt(3);

        foreach(var name in names)
        {
            System.Console.WriteLine(name);
        }

        System.Console.WriteLine();

        System.Console.WriteLine("---Insert(3)--- This Function will insert new elements at index no 3");
        names.Insert(3,"Jaydeep Godase");
        foreach(var name in names)
        {
            System.Console.WriteLine(name);
        }

        System.Console.WriteLine();

        System.Console.WriteLine("Before using Clear()");
        System.Console.WriteLine("---Clear--- This Function will remove or clear all elements presents in the list.");
        names.Clear();
        System.Console.WriteLine("Clear()");
        System.Console.WriteLine("Capacity : {0}",names.Capacity);
        System.Console.WriteLine("Count : {0}",names.Count);

        foreach(var name in names)
        {
            System.Console.WriteLine("Given Name list Is : "+name);
        }
        System.Console.WriteLine("After Using Clear()");

    }

}