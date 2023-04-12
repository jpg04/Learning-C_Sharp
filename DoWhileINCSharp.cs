using System;

public class DoWhileINCSharp
{
	public DoWhileINCSharp()
    {
        Console.WriteLine("do while loop in C#...!");

        Console.WriteLine("Enter Any Random Number You Want to Traverse...!");
        int num = Convert.ToInt32(Console.ReadLine());
        int i =0;
        do
        {
            Console.WriteLine(i);
            i++;
        }while (i<num);

    }
}
