using System;

public class MultiDimensionalArray
{
	public void MDArray()
	{
		int[,] arr = new int[3, 3];

		arr[0,1] = 20;
		arr[1,2] = 30;
		arr[2,0]= 50;

		for(int i=0; i<3; i++)
		{
			for(int j=0; j<3; j++)
			{
				Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
	}
}
