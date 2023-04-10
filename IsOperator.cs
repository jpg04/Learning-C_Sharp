using System;

public class Ex1 { }
public class Ex2 : Ex1 { }

public class IsOperator : Ex2
{
    bool b = "Jaydeep" is string;
    public IsOperator()
    {
        Console.WriteLine(b);
    }
}
