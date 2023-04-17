using System;

public class SingleLevelInheritance
{
	protected int a=20, b=10, c=0;

    public void Add()
    {
        c = a + b;
        Console.WriteLine("Addition is : "+c);
    }

    public void Sub()
    {
        c=a - b;
        Console.WriteLine("Subtraction is : " + c);
    }
}

class SingleLevelInheritanceX : SingleLevelInheritance
{
    public void Mul()
    {
        c = a * b;
        Console.WriteLine("Multiplication is : " + c);
    }

    public void Div()
    {
        c=a/ b;
        Console.WriteLine("Division is : " + c);
    }
}