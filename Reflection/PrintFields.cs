using System;
using System.Reflection;

class PrintFields
{
    static void Main(string[] jp)
    {
        Type t = typeof(System.String);

        System.Console.WriteLine("Constructors of {0} type : ",t);

        FieldInfo[] fi = t.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);

        foreach(FieldInfo f in fi)
        {
            System.Console.WriteLine(f);
        }
    }
}