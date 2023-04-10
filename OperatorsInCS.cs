using System;

public class OperatorsInCS
{
	public OperatorsInCS()
    {
        Console.WriteLine("Operators in C#...!");
        /* 
            1. Arithmetic Operators
            2. Assignment Operators
            3. Comparison Operators
            4. Logical Operators
        */

        Console.WriteLine("Arithmetic Operator in C#...!");
        int a = 33; int b = 4;
        Console.WriteLine("The value of a + b is : " + (a + b));
        Console.WriteLine("The value of a - b is : " + (a - b));
        Console.WriteLine("The value of a * b is : " + (a * b));
        Console.WriteLine("The value of a / b is : " + (a / b));

        Console.WriteLine("Assignment Operators in C#...!");
        int c = 5;
        int d = c;
        d += 5;
        Console.WriteLine("Value of d is : " + d);
        d -= 5;
        Console.WriteLine("Value of d is : " + d);
        d *= 5;
        Console.WriteLine("Value of d is : " + d);
        d /= 5;
        Console.WriteLine("Value of d is : " + d);

        Console.WriteLine("Logical Operators in C#...!");

        Console.WriteLine(true && false);
        Console.WriteLine(true && true);
        Console.WriteLine(false && true);
        Console.WriteLine(false && false);
        Console.WriteLine();
        Console.WriteLine(true || false);
        Console.WriteLine(true || true);
        Console.WriteLine(false|| true);
        Console.WriteLine(false|| false);
        Console.WriteLine();
        Console.WriteLine(!true);
        Console.WriteLine(!false);

        Console.WriteLine();

        Console.WriteLine("Comparison Operator in C#...!");
        Console.WriteLine(12>13);
        Console.WriteLine(12<13);
        Console.WriteLine(12<=13);
        Console.WriteLine(12>=13);
        Console.WriteLine(12!=13);
        Console.WriteLine(12==13);
    }
}
