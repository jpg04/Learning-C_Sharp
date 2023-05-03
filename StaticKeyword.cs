using System;

public class StaticKeyword
{
	public int accNo;
	public String name;
	public static int count = 0;
	public static float rateOfInterest = 8.8f;
	public StaticKeyword(int accNo, String name)
	{
		this.accNo = accNo;	
		this.name = name;
		count++;
	}

	public void Display()
	{
        Console.WriteLine("Account Number is :"+accNo+"\nName is :"+name+ "\nRate of Interest is :"+rateOfInterest);
    }
}
