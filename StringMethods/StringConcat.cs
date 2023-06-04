using System;
namespace StringMethods
{
    class StringConcat
    {
        public static void Main(String[] args)
        {
            string s1 = "Jaydeep ";

            string s2 = "Godase";

            System.Console.WriteLine(string.Concat(s1,s2));
        }
    }
}

/* 
Signature

public static string Concat(String, String)  
public static string Concat(IEnumerable<String>)  
public static string Concat(Object)  
public static string Concat(Object, Object)  
public static string Concat(Object, Object, Object)  
public static string Concat(Object, Object, Object, Object)  
public static string Concat(params Object[])  
public static string Concat(String, String, String)  
public static string Concat(String, String, String,?String)  
public static string Concat(params String[])  
[ComVisibleAttribute(false)]  
public static string Concat<T>(IEnumerable<T>)  
 */