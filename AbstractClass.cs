using System;

public abstract class AbstractClass
{
	public abstract void Draw();
}

public class AbstractClass2 : AbstractClass
{
	public override void Draw()
	{
        Console.WriteLine("Drawing Rectangle...!");
    }
}

public class AbstractClass3 : AbstractClass2
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle...!");
    }
}