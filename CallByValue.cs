using System;

public class CallByValue
{
	public void Show(int val)
	{
		val *= val;
        Console.WriteLine("Value inside the show function "+val);
    }
}
