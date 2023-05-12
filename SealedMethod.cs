using System;

public class SealedMethod
{
	public virtual void eat()
    {
        Console.WriteLine("Eating");
    }

    public virtual void Run() 
    {
        Console.WriteLine("Running");
    }
}

public class SealedMethodDerived : SealedMethod
{
    public override void eat()
    {
        Console.WriteLine("Eating something");
    }
    public sealed override void Run() 
    {
        Console.WriteLine("I Am Running State");
    }
}
public class SealedMethodDerived2 : SealedMethodDerived
{
    public override void eat()
    {
        Console.WriteLine("Eating something");
    }
    public override void Run() 
    {
        Console.WriteLine("I Am Running State inside Sealed 2");
    }
}


