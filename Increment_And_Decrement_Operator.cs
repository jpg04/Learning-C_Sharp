using System;
using System.Diagnostics;

public class Increment_And_Decrement_Operator
{
    int a = 1;
    public int b = 2;
    public int c = 3;
    public Increment_And_Decrement_Operator()
    {
        Console.WriteLine(a);
        a++;
        Console.WriteLine(a);
        a--;
        Console.WriteLine(a);
    }
}
