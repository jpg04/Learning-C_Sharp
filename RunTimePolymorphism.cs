using System;

class BaseRunTimePolymorphism
{
	public virtual void Run()
	{
		Console.WriteLine("Inside Run()...!"); ;
    }
}
class RunTimePolymorphism : BaseRunTimePolymorphism
{
	public override void Run()
	{
		Console.WriteLine("Inside Run()...!");
        Console.WriteLine("Runtime polymorphism achieved...!");
    }
}
