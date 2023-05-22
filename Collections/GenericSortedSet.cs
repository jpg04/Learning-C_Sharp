/* 
* C# SortedSet class can be used to store, remove or view elements. 
* It maintains ascending order and does not store duplicate elements. 
* It is suggested to use SortedSet class if you have to store unique elements and maintain ascending order. 
* It is found in System.Collections.Generic namespace.
*/

using System;
using System.Collections.Generic;

class GenericSortedSet
{
    static void Main(string[] jp)
    {
        // * creating sorted set of string 

        var pl = new SortedSet<string>();

        pl.Add("C");
        pl.Add("Java");
        pl.Add("C++");
        pl.Add("C#");
        pl.Add("HTML");
        pl.Add("CSS");
        pl.Add("Python");

        foreach(var lang in pl)
        {
            System.Console.WriteLine(lang);
        }



    }
}