using System;

public class IfElseLadder
{
	public IfElseLadder()
    {
        Console.WriteLine("Enter Your Age : ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 10)
        {
            Console.WriteLine("You are child...!");
        }
        else if (age <18 ) 
        {
            Console.WriteLine("You are Teenager...!");
        }
        else if(age > 18 && age <75)
        {
            Console.WriteLine("You are eligible for Driving...!");
        }
        else
        {
            Console.WriteLine("You are not eligible for Drive...!");
        }
    }
}
