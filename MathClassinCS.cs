using System;

public class MathClassinCS
{
	public MathClassinCS()
    {
        Console.WriteLine("Math Class in C#...!");

        int a= Math.Max(21, 233);
        int b= Math.Min(21, 233);
        Double c= Math.Sqrt(81);
        int  d= Math.Abs(-81);
        Console.WriteLine("Maxomim value is : "+a);
        Console.WriteLine("Minimum value is : "+b);
        Console.WriteLine("Square Root of Given value is : "+c);
        Console.WriteLine("Absolute of Given value is : "+d);
    }
}
