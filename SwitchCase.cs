using System;

public class SwitchCase
{
	public SwitchCase()
    {
        Console.WriteLine("switch Case in C#");

        Console.WriteLine("Enter Your Standard : ");
        int std = Convert.ToInt32 (Console.ReadLine());
        
        switch(std)
        {
            case 1:
                Console.WriteLine("You are in 1st Std...!");
                break;
            case 2:
                Console.WriteLine("You are in 2nd Std...!");
                break;
            case 3:
                Console.WriteLine("You are in 3rd Std...!");
                break;
            default:
                Console.WriteLine("InValid Input...!");
                break;
        }
    }
}
