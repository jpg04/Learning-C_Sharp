using System;

public class TernaryOprator
{
    public int a = 12; public int b = 13;
    public TernaryOprator()
    {
        Console.WriteLine("Ternary Operator");
        bool isGreater = a < b ? true : false;
        Console.WriteLine("Statement is : " + isGreater);

    }
}
