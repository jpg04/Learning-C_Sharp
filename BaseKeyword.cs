using System;

public class BaseKeyword
{
    public string Name = "Godase";
	
	public void Cricket()
	{
        Console.WriteLine("Bowling All-Rounder");
    }
    
}

public class BaseKeywordChild : BaseKeyword
{
    string Name = "Jaydeep";

    public void showName()
    {
        base.Cricket();
        Console.WriteLine(base.Name);
        Console.WriteLine(Name);
    }


}