/* 
    * C# Threading Sleep() method
    * The Sleep() method suspends the current thread for the specified milliseconds. 
    * So, other threads get the chance to start execution.
*/
using System;
using System.Threading;

class SleepMethod
{
    public void Thread1()
    {
        for(int i=0; i<10; i++)
        {
            System.Console.WriteLine(i);
            Thread.Sleep(2000);
        }
    }
}
class ThreadingSleepMethod
{
    static void Main(string[] jp)
    {
        SleepMethod sm = new SleepMethod();
        Thread t1 = new Thread(new ThreadStart(sm.Thread1));
        Thread t2 = new Thread(new ThreadStart(sm.Thread1));
        t1.Start();
        t2.Start();
    }
}