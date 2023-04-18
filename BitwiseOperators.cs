using System;

public class BitwiseOperators
{
	public BitwiseOperators()
	{
		Console.WriteLine("Bitwise Operator in C#...!");

		int a = 5, b = 10, result;

		//Bitwise AND Operator
		result = a & b;
		Console.WriteLine("Bitwise AND : " + result);
		result = a | b;
		Console.WriteLine("Bitwise OR : " + result);
	}
}
