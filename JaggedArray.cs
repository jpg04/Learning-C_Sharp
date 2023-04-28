using System;

public class JaggedArray
{
	public void JaggedArrayX()
	{
		int[][] Arr = new int[4][] 
		{ 
			new int[] { 11, 12, 13, 14, 15 },
			new int[] { 21,22,23,24},
			new int[] { 31,32,33},
			new int[] {41,42}
		};

		for(int i=0; i<Arr.Length; i++)
		{
			for(int j=0; j < Arr[i].Length; j++)
			{
				Console.Write(Arr[i][j]+"\t");
            }
            Console.WriteLine();
        }

	}
}
