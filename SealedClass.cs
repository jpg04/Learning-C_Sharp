using System;

sealed public class SealedClass
{
	public void Eat()
	{
        Console.WriteLine("Eat Something");
    }
}

public class SealedDerived : SealedClass
{
    public void Eating()
    {
        Console.WriteLine("I am Eating");
    }
}
