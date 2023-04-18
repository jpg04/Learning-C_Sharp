using System;

interface X
{
	void Add();  //by default public
}

interface XX
{
	void Sub(); // by default public
}
public class MultipleInheritance : X,XX
{
	public void Add()
	{
		int a = 10, b = 20;
        Console.WriteLine(a+b);
    }
	public void Sub()
	{
		int a = 10, b = 20;
		Console.WriteLine(a-b);
	}
}


