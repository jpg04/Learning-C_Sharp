using System;
using System.Collections.Generic;

class HashSetCollInitializer
{
    static void Main(string[] jp)
    {
        // creating set of string 

        var names = new HashSet<string>() {"Jay","Deep","JP","Jaydeep","Jay"};

        // Iterate HashSet elements using foreach loop  

        foreach(var name in names)
        {
            System.Console.WriteLine(name);
        }
    }
}