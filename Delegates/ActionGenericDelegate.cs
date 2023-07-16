using System;
// Action has does not have any return value 
class ActionGenericDelegate
{
    public static void Main(string[] jp)
    {
        Action<int,int> func = Add;
        func(7,4);
    }

    static void Add(int a, int b)
    {
        System.Console.WriteLine("Addition is : "+ (a+b));
    }
}

// Action is a generic delegate included in the system Namespace.