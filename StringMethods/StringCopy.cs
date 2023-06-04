using System;
namespace StringMethods
{
    class StringCopy 
    {
        public static void Main(string []args)
        {
            string s1 = "Jaydeep";
            string s2 = string.Copy(s1);

            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
        }
    }
}

/* 
Signature
public static string Copy(String str)   
*/