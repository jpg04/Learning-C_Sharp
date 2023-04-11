using System;

public class StringMethod
{
	public StringMethod()
	{
		string name = "My Name is Jaydeep Popat Godase";
		//Console.WriteLine(name.Length);
		//Console.WriteLine(name.ToLower());
  //      Console.WriteLine(name.ToUpper());
  //      Console.WriteLine(string.Concat(name,"I am not arrogant...!"));
  //      Console.WriteLine(name+"I am not arrogant...!");

		//string fname = Console.ReadLine();
		//string rno = Console.ReadLine();
  //      Console.WriteLine($"Your Name is {fname}. and Your Roll Number is {rno}.");
		Console.WriteLine(name.IndexOf("Jaydeep"));
		Console.WriteLine(name.Substring(1));

		//Escape sequence character

		string fullname = "My Full Name Is \"Jaydeep Popat Godase \" ";
		string newline = "I want new line between\n Yes\n and\n No\n";
        Console.WriteLine(fullname);
		Console.WriteLine(newline);




    }
}
