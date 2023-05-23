using System;
using System.Reflection;

class PrintMethod
{
    static void Main(string[] jp)
    {
        Type t = typeof(System.String);

        System.Console.WriteLine("Constructors of {0} type : ",t);

        MethodInfo[] mi = t.GetMethods(BindingFlags.Public | BindingFlags.Instance);

        foreach(MethodInfo m in mi)
        {
            System.Console.WriteLine(m);
        }
    }
}