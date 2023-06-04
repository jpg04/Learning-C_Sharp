using System;
namespace StringMethods
{
    class StringContains
    {
        public static void Main(string[] args)
        {
            string s1 = "Jaydeep";
            string s2 = "Jay";
            string s3 = "JP";

            System.Console.WriteLine(s1.Contains(s2));
            System.Console.WriteLine(s1.Contains(s3));
        }
    }
}