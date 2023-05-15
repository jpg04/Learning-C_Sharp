using System;

abstract class AbstractionUsingAbstractKeyword
{ 
    public abstract void run();

    public void sleep()
    {
        Console.WriteLine("I am Sleeping...!");
    }
}

class AbstractionUsingAbstractKeywordX : AbstractionUsingAbstractKeyword
{
    public override void run()
    {
        Console.WriteLine("I am Running...!");
    }
    public void sun()
    {
        Console.WriteLine("Inside sun()...!");
    }
}