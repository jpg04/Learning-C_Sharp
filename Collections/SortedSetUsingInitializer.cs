using System;
using System.Collections.Generic;

class SortedSetUsingInitializer
{
    static void Main(string[] jp)
    {
        var pl = new SortedSet<string>(){"C","HTML","CSS","C++","C#","Java","Python"};

        foreach(var lang in pl)
        {
            System.Console.WriteLine(lang);
        }
    }
}