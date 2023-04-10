using System;

public class TakingInputFromUser
{
	public TakingInputFromUser()
    {
        Console.WriteLine("Taking Input From User in C#...!");

        Console.WriteLine("Enter Your Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Your Name Is : "+name);

        Console.WriteLine("What is Your Current Age ?");
        string age = Console.ReadLine();
        Console.WriteLine("Your age is : " +age+" add 4 more into your age : " + (Convert.ToInt32(age) + 4));

        Console.WriteLine("Enter your Graduation Percentage : ");
        double marks = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Your Graduation Percentage is : "+marks);
    }
}
