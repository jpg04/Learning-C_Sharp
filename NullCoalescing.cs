using System;

public class NullCoalescing
{
    public NullCoalescing()
    {
        Console.WriteLine("Null Coalescing Operator");
        object obj = null;
        object obj2 = obj ?? new object();
        Console.WriteLine(obj2);
    }
}
