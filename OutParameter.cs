using System;

public class OutParameter
{
	public void show(out int val)
	{
		int square = 8;
		val = square;
		val *= val;

	}
}
