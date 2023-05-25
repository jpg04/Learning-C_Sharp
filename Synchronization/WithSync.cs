/* C# Thread Synchronization Example
In this example, I am using lock. This example executes synchronously. 
In other words, there is no context-switching between the threads. 
In the output section, 
we can see that second thread starts working after first threads finishes its tasks.
*/
using System;
using System.Threading;

class PrinterClass
{
    public void PrintTable()
    {
        lock(this)
        {    
            for(int i=0; i<10; i++)
            {
                Thread.Sleep(200);
                System.Console.WriteLine(i);
            }
        }
    }
}
class WithSync
{
    static void Main(string[] jp)
    {   
        PrinterClass pc = new PrinterClass();
        Thread t1 = new Thread(new ThreadStart(pc.PrintTable));
        Thread t2 = new Thread(new ThreadStart(pc.PrintTable));

        t1.Start();
        t2.Start();
    }
}