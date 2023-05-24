using System;
using System.Threading;

class AbortMethod
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
class ThreadingAbortMethod
{
    static void Main(string[] jp)
    {
        System.Console.WriteLine("Start of Main");
        AbortMethod am = new AbortMethod();
        Thread t1 = new Thread(new ThreadStart(am.Thread1));
        Thread t2 = new Thread(new ThreadStart(am.Thread1));
        t1.Start();
        t2.Start();

        try
        {
            t1.Abort();
            t2.Abort();
        }
        catch(ThreadAbortException tae)
        {
            System.Console.WriteLine(tae.ToString());
        }
        System.Console.WriteLine("End of Main");
    }
}