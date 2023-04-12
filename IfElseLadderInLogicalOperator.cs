using System;

public class IfElseLadderInLogicalOperator
{
	public IfElseLadderInLogicalOperator()
	{
        Console.WriteLine("IfElse Ladder In LogicalOperator");
        Console.WriteLine("Enter Your Age : ");
        int age = Convert.ToInt32(Console.ReadLine());
        bool OverAged = true;
        bool Underaged = true; 
        
        if (age > 75 && OverAged)
        {
            Console.WriteLine("You are not eligible for Driving or You are Overaged...!");
        }
        else if(age < 18  && Underaged) 
        {
            Console.WriteLine("You are teenager or You are Underaged...!");
        }
        else
        {
            Console.WriteLine("You are Eligible for Drive...!");
        }
    }
}
