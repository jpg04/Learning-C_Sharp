using System;

public class CallByReference
{
	public void show(ref int val)
	{
		val *= val;
        Console.WriteLine("Value inside the show function : "+val);
    }
}
