using System;

public class DecisionMakingStatement
{
	public DecisionMakingStatement()
    {
        Console.WriteLine("Decision Making Statement in C#...!");

        //int age = 24;
        Console.WriteLine("Enter Your Age : ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age > 18)
        {
            Console.WriteLine("You are eligible for Drive...!");
        }
        else
        {
            Console.WriteLine("You are Not eligible for Drive...!");
        }
       
    }
}
