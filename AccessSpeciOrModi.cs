using System;

/*
 * Public Access Specifier or Modifier
 * 
class AccessSpeciOrModi
{
	public string Name = "Jaydeep Popat Godase";

	public void DisplayMsg(string msg)
	{
        Console.WriteLine("Hello "+msg);
    }
}
*/

/*
 * Protected Access Specifier or Modifier
 *
class AccessSpeciOrModi
{
	protected string Name = "Jaydeep Popat Godase";

	protected void DisplayMsg(string msg)
	{
        Console.WriteLine("Hello"+msg);
    }
}
*/

/* Example 2
 * Here, we are accessing protected members within child class by inheritance.

class AccessSpeciOrModi
{
	protected string Name = "Jaydeep Popat Godase";

	protected void DisplayMsg(string msg)
	{
        Console.WriteLine("Hello "+msg);
    }
}
*/

/*
 * C# Internal Access Specifier
 * The internal keyword is used to specify the internal access specifier for the variables and functions. 
 * This specifier is accessible only within files in the same assembly.

class AccessSpeciOrModi
{
	internal string Name = "Jaydeep Popat Godase";
	internal void DisplayMsg(string msg)
	{
        Console.WriteLine("Hello "+msg);
    }
}
*/

/*C# Protected Internal Access Specifier
 * 
 * Variable or function declared protected internal can be accessed in the assembly in which it is declared. 
 * It can also be accessed within a derived class in another assembly.
 * 
 
class AccessSpeciOrModi
{
    protected internal string Name = "Jaydeep Popat Godase";
    protected internal void DisplayMsg(string msg)
    {
        Console.WriteLine("Hello " + msg);
    }
}
*/

/*5) C# Private Access Specifier
 * 
 * Private Access Specifier is used to specify private accessibility to the variable or function. 
 * It is most restrictive and accessible only within the body of class in which it is declared.

class AccessSpeciOrModi
{
    private string Name = "Jaydeep Popat Godase";
    private void DisplayMsg(string msg)
    {
        Console.WriteLine("Hello " + msg);
    }
}

 */