/*  
    *   C# Threading Naming Thread
    *   You can change or get the name of the thread by using Name property of Thread class. 
    *   Let's see an example where we are setting and getting names of the threads.
*/
using System;
using System.Threading;
class NamingThread
{   
    public void Thread1()
    {
        // Thread.Sleep(2000);
        Thread t = Thread.CurrentThread;
        System.Console.WriteLine(t.Name+"is Running");
    }   
}
class ThreadingNamingThread
{
    static void Main(string[] jp)
    {
        NamingThread nt = new NamingThread();
        Thread t1 = new Thread(new ThreadStart(nt.Thread1));
        Thread t2 = new Thread(new ThreadStart(nt.Thread1));
        Thread t3 = new Thread(new ThreadStart(nt.Thread1));

        t1.Name = "Player 1 ";
        t2.Name = "Player 2 ";
        t3.Name = "Player 3 ";

        t1.Start();
        t2.Start();
        t3.Start();

    }
}