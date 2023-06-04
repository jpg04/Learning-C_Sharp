using System;
namespace StringMethods
{
    class StringCopyTo
    {
        public static void Main(string[] args)
        {
            string s1 = "Hello, I am Jaydeep";
            char[] ch = new char[15];

            s1.CopyTo(7,ch,0,12);
            System.Console.WriteLine(ch); 
        }
    }
}