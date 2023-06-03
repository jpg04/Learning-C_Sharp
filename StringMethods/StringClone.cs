using System;
namespace StringMethods
{
    class StringClone
    {
        public static void Main(string[] args)
        {

        string s1 = "Jaydeep";
        string s2 = (String)s1.Clone();

        System.Console.WriteLine(s1);
        System.Console.WriteLine(s2);
        }

    }
}