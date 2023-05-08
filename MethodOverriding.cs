using System;

/*
public class MethodOverriding
{
	public virtual void Fun()
	{
        Console.WriteLine("Inside the Base Fun...!");
    }public virtual void Gun()
	{
        Console.WriteLine("Inside the Base Gun...!");
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
*/

public class MethodOverriding
{
    public virtual void Eat()
    {
        Console.WriteLine("Eating in Base");
    }
}

public class IwillOverrideYou : MethodOverriding
{
    public override void Eat()
    {
        Console.WriteLine("I eaten You and Overridden on You...!");
    }
}