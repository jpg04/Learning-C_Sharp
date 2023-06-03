using System;
namespace StringMethods
{
    class StringCompare
    {
        public static void Main(string[] args)
        {
            string s1 = "hello";    
            string s2 = "hello";    
            string s3 = "csharp";  
            string s4 = "mello";  

            System.Console.WriteLine(string.Compare(s1,s2));
            System.Console.WriteLine(string.Compare(s2,s3));
            System.Console.WriteLine(string.Compare(s3,s4));
        }
    }
}

/*  String Signatures
public static int Compare(String first, String second)  
public static int Compare(String, Int32, String, Int32, Int32)  
public static int Compare(String, Int32, Int32, String, Int32, Boolean)   
public static int Compare(String, Boolean, Int32, Int32, String, Int32, CultureInfo)   
public static int Compare(String, CultureInfo, Int32, Int32, String, Int32, CompareOptions)   
public static int Compare(String, Int32, Int32, String, Int32, StringComparison)  
public static int Compare(String, String, Boolean)   
public static int Compare(String, String, Boolean, CultureInfo)   
public static int Compare(String, String, CultureInfo, CompareOptions)  
public static int Compare(String, String, StringComparison)  
 */