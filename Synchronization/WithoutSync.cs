
/*  
In this example, I am not using lock. This example executes asynchronously. 
In other words, there is context-switching between the threads.
*/
using System;
using System.Threading;

class Printer
{
    public void PrintTable()
    {
        for(int i=0; i<10; i++)
        {
            Thread.Sleep(200);
            System.Console.WriteLine(i);
        }
    }
}
class WithoutSync
{
    static void Main(string[] jp)
    {   
        Printer p = new Printer();
        Thread t1 = new Thread(new ThreadStart(p.PrintTable));
        Thread t2 = new Thread(new ThreadStart(p.PrintTable));

        t1.Start();
        t2.Start();
    }
}