using System;


class Base
{
	public int a = 20, b = 10, c=0;
	public void Add()
	{
		int c = a + b;
        Console.WriteLine("Addition is : "+c);
    }
}

class HierarchicalInheritance : Base
{
	public void sub()
	{
		c = a - b;
		Console.WriteLine("Subtraction is : " + c);
	}
}
class HierarchicalInheritance1 : Base
{
	public void mul()
	{
		c=a*b;
        Console.WriteLine("Multiplication is : "+c);
    }
}
