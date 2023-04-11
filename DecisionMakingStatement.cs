using System;

public class DecisionMakingStatement
{
	public DecisionMakingStatement()
    {
        Console.WriteLine("Decision Making Statement in C#...!");

        //int age = 24;
        Console.WriteLine("Enter Your Age : ");
        string agestr = Console.ReadLine();
        int  age = Convert.ToInt32(agestr);
        bool isBanned = true;

        if (age <10 && isBanned)
        {
            Console.WriteLine("You are child or You Are Banned...!");
        }
        else if(age < 18 && isBanned)
        {
            Console.WriteLine("You are Teenager or You are Banned...!");
        }
        else if(age < 75)
        {
            Console.WriteLine("You are eligible for Drive...!");
        }
        else
        {
            Console.WriteLine("You are Not eligible for Drive...!");
        }
       
    }
}
