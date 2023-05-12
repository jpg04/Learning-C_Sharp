using System;

public class RunTimePoly
{
	public virtual void draw()
	{
        Console.WriteLine("Drawing Something");
    }
}

public class Rectangles : RunTimePoly
{
    public override void draw()
    {
        Console.WriteLine("Drawing Rectangles");
    }
}

public class Circle : RunTimePoly
{
    public override void draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}


//Another example of runtime polymorphism in C# where we are having two derived classes.