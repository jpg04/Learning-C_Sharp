using System;
namespace StringMethods
{
    class StringCompareOrdinal
    {
        public static void Main(string[] args)
        {
            string s1 = "Ajay";    
            string s2 = "Ajay";    
            string s3 = "Bjay";  
            string s4 = "CJay";

            System.Console.WriteLine(string.CompareOrdinal(s1,s2));
            System.Console.WriteLine(string.CompareOrdinal(s1,s3));
            System.Console.WriteLine(string.CompareOrdinal(s1,s4));
        }
    }
}