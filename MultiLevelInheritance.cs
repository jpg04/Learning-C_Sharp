using System;

public class MultiLevelInheritance
{
	protected int a = 30, b=20, c = 0;
	public void Add()
	{
		c = a + b;
        Console.WriteLine("Addition is : "+c);
    }

	public void Sub()
	{
		c = a - b;
        Console.WriteLine("Subtraction is : "+c);
    }
}

class MultiLevelInheritanceX : MultiLevelInheritance
{
	public void Mul()
	{
		c = a * b;
        Console.WriteLine("Multiplication is : "+c);
    }

	public void Div()
	{
		c= a / b;
		Console.WriteLine("Division is : " + c);
	}
}

class MultiLevelInheritanceXX : MultiLevelInheritanceX
{
	public void Mod()
	{
		c = a % b;
		Console.WriteLine("Modulo is : " + c);
	}
}