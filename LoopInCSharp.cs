using System;

public class LoopInCSharp
{
	public LoopInCSharp()
    {
        Console.WriteLine("While Loop in C#...!");

        Console.WriteLine("Enter The traverse Number...!");
        int num = Convert.ToInt32(Console.ReadLine());

        int i = 0;
        while (i < num)
        {
            Console.WriteLine(i);
            i++;
        }


    }
}
