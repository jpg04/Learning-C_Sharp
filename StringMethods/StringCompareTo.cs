using System;
namespace StringMethods
{
    class StringCompareTo
    {
        public static void Main(string[] args)
        {
            string s1 = "hello";    
            string s2 = "hello";    
            string s3 = "csharp";  

            System.Console.WriteLine(s1.CompareTo(s2));
            System.Console.WriteLine(s2.CompareTo(s3));
        }
    }
}