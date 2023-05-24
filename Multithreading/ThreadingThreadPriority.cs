/*  
* C# Threading ThreadPriority
* Let's see an example where we are changing the priority of the thread. 
* The high priority thread can be executed first. 
* But it is not guaranteed because thread is highly system dependent. 
* It increases the chance of the high priority thread to execute before low priority thread.
*/

using System;
using System.Threading;

class PriorityThread
{
    public void Thread1()
    {
        Thread t = Thread.CurrentThread;
        System.Console.WriteLine(t.Name+"is Running");
    }
}
class ThreadingThreadPriority
{
    static void Main(string[] jp)
    {
        PriorityThread tp = new PriorityThread();
        Thread t1 = new Thread(new ThreadStart(tp.Thread1));
        Thread t2 = new Thread(new ThreadStart(tp.Thread1));
        Thread t3 = new Thread(new ThreadStart(tp.Thread1));

        t1.Name = "Player 1 ";
        t2.Name = "Player 2 ";
        t3.Name = "Player 3 ";

        t3.Priority = ThreadPriority.Highest;
        t1.Priority = ThreadPriority.Normal;
        t2.Priority = ThreadPriority.Lowest;

        t1.Start();
        t2.Start();
        t3.Start(); 
    }
}
