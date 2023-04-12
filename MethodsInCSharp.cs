using System;

public class MethodsInCSharp
{
	public MethodsInCSharp()
	{
        Console.WriteLine("Methods In CSharp...!");
    }

    public static void Greet()
    {
        Console.WriteLine("Good AfterNoon JP...!");
    }

    public static void Greet(string name) 
    {
        Console.WriteLine("My Name is : "+name);
    }

    public static float Average(int i, int j, int k)
    {
        float sum = i+ j + k;
        return sum/3;
    }


}
