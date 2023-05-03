using System;

public class ArrayClass
{
	public ArrayClass()
	{
        // Creating an array  
        int[] Arr = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
        // Creating an empty array
        int[] Arr2 = new int[7];
        Console.WriteLine("Length of First Array is : " + Arr.Length);
        // Sorting array  
        Array.Sort(Arr);
        Console.WriteLine("First Array element is :");
        // Displaying sorted array  
        for (int i = 0; i < Arr.Length; i++)
        {
            Console.WriteLine(Arr[i]);

        }
        // Finding index of an array element
        Console.WriteLine("Index of position 5 is : " + Array.IndexOf(Arr, 5));
        // Coping first array to empty array  
        Array.Copy(Arr, Arr2, Arr.Length);
        Console.WriteLine("Second Array Element is : "+Arr2);
        // Displaying second array 
        //PrintArray(Arr2);
        Array.Reverse(Arr2);
        Console.WriteLine("First Array element is Reverse order : ");
        //PrintArray(Arr);

        foreach (int i in Arr) Console.WriteLine(i);

    }
}
