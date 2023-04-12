using System;

public class ForLoopInCSharp
{

    public ForLoopInCSharp()
    {
        Console.WriteLine("For Loop in C Sharp...!");

        Console.WriteLine("Enter Any Random Number You want to traverse : ");
        int num = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < num; i++)
        {
            Console.WriteLine(i+1);
        }
    }
}
