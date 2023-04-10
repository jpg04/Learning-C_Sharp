using System;

public class PublicAccessModifier
{

    public int eg = 5;
    public PublicAccessModifier()
    {

    }

    public void fun()
    {
        Console.WriteLine("This exaple is for public access modifier");
    }
}

internal class PublicAccessModifierDerived : PublicAccessModifier
{
    public PublicAccessModifierDerived()
    {

    }
}