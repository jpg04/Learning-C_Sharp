using System;
//Abstraction
abstract class AbstractionUsingAbstractKeyword
{ 
    public abstract void run();

    public abstract void sleep();
    
}

class AbstractionUsingAbstractKeywordX : AbstractionUsingAbstractKeyword
{
    public override void run()
    {
        Console.WriteLine("I am Running...!");
    }
    public override void sleep()
    {
        Console.WriteLine("I am Sleeping...!");
    }
    public void sun()
    {
        Console.WriteLine("Inside sun()...!");
    }
}