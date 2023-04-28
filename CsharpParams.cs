using System;

public class CsharpParams
{
	/* public void ShowParams(params int[] val)
	{
		for(int i=0; i<val.Length; i++) 
		{
			Console.WriteLine(val[i]);
        }
	}
	*/

	public void ShowParamsObjetcs(params object[] items)
	{
		for (int i=0; i<items.Length; i++)
		{
			Console.WriteLine(items[i]);
		}
	}
}
