using System;

public class Strings
{
    public static void Main(string[] args)
    {
        string str = "Jaydeep";

        char[] str2 = {'J','A','Y'};

        string str3 = new string(str2);

        System.Console.WriteLine(str);
        System.Console.WriteLine(str2);
    }
}