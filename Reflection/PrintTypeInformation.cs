using System;

class PrintTypeInformation
{
    static void Main(string[] jp)
    {
        Type t = typeof(System.String);
        System.Console.WriteLine(t.FullName);
        System.Console.WriteLine(t.BaseType);
        System.Console.WriteLine(t.IsClass);
        System.Console.WriteLine(t.IsEnum);
        System.Console.WriteLine(t.IsInterface);
    }
}