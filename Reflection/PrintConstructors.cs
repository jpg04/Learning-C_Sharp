using System;
using System.Reflection;

public class PrintConstructors
{
    public static void Main(string[] jp)
    {
        Type t = typeof(System.String);

        System.Console.WriteLine("Constructors of {0} type : ",t);

        ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);

        foreach(ConstructorInfo c in ci)
        {
            System.Console.WriteLine(c);
        }
    }
}