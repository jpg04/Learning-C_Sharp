using System;

namespace ExampleProject
{
    internal class Loops
    {
        public Loops()
        {

            System.Console.WriteLine("Loops in C#");

            List<String> collection = new List<String>() { "j", "a", "y", "d", "e", "e", "p" };
            for (int i = 0; i < collection.Count; i++)
            {
                System.Console.WriteLine(i + ": " + collection[i]);
            }
        }
    }
}