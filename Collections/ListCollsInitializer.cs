using System;
using System.Collections.Generic;

class ListCollsInitializer
{
    static void Main(string[] jp)
    {
        // creating list using collection initializer

        var names = new List<string>() {"Jay","Deep","JP","Jaydeep"};

        // iterrate list using foreach loop

        foreach(var name in names)
        {
            System.Console.WriteLine(name);
        }
    }
}