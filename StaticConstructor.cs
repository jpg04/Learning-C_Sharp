using System;

public class StaticConstructor
{
	public int id;
	public string name;
	public static float rateOfInterest;
	public StaticConstructor(int id, string name)
	{
		this.id = id;
		this.name = name;
	}

	static StaticConstructor()
	{
		rateOfInterest = 9.5f;
	}

	public void Display()
	{
        Console.WriteLine("ID is : "+id+"\nName is : "+name+"\nRate of Interest is :"+rateOfInterest);
    }
}
