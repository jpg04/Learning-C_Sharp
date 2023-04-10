using System;

public class TypeCasting
{
    public TypeCasting()
    {
        Console.WriteLine("Type Cating in C#");

        //Type Casting : Converting one data type into another data type is known as typcating
        /* 
         There are two types of Type Casting 
            1. Implicit Casting : char to int to long to float to                        

         */

        int x = 21;
        double y = x;
        int z = 'j';

        Console.WriteLine("Value of X is : " + x);
        Console.WriteLine("Double to Integer Type Casting : " + y);
        Console.WriteLine("Character to Integer Type Casting : " + z);

        //2. Explicit Casting 

        double a = (int)3.23;
        int c = (char)'j';
        Console.WriteLine("Double to Integer Type Casting : " + a);
        Console.WriteLine("Character to Integer Type Casting : " + c);

        //Type Casting Using Methods

        float f = Convert.ToInt32(21.21);
        string j = Convert.ToString(5);
        Console.WriteLine(f);
        Console.WriteLine(j);

        // Convert.ToString
        // Convert.ToInt32
        // Convert.ToDouble
    }

}
