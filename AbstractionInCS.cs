using System;

public class AbstractionInCS
{
	private void run()
	{
		//int a = 4;
        Console.WriteLine("Inside run()...!");
    }
}

class AbstractionInCSX : AbstractionInCS
{
	public void sun()
	{
        Console.WriteLine("Inside sun()...!");
    }
}