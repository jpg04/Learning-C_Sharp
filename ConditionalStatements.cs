using System;

namespace ExampleProject
{
    internal class ConditionalStatements
    {
        public ConditionalStatements()
        {
            int No = 5;

            if (No % 2 == 0)
            {
                System.Console.WriteLine("Number is Even : " + No);
            }
            else
            {
                System.Console.WriteLine("Number is Odd : " + No);
            }
        }
    }
}