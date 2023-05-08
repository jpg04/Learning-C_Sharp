using System;

public class MethodOverriding
{
	public virtual void Fun()
	{
        Console.WriteLine("Inside the Base Fun...!");
    }public virtual void Gun()
	{
        Console.WriteLine("EaInside the Base Gun...!");
    }public virtual void Sun()
	{
        Console.WriteLine("Inside the Base Sun...!");
    }
}

public class DerivedMethodOverriding : MethodOverriding
{
    public override void Gun()
    {
        Console.WriteLine("Inside the Derived Gun...!");
    }
    public override void Sun()
    {
        Console.WriteLine("Inside the Derived Gun...!");
    }
    //public override void Run()
    //{
    //    Console.WriteLine("Inside the Derived Run...!");
    //}
}

