using System;

public class ThisKeyword
{
	public ThisKeyword()
	{
        Console.WriteLine("Default Constructor....!");
    }

    public int id;
    public string name;
    public float salary;
    public ThisKeyword(int id, string name, float salary)
    {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }

    public void Display()
    {
        Console.WriteLine(id+" "+name +" "+salary);
    }
}

