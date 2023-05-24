/* 
    * C# Threading Join() method
    * It causes all the calling threads to wait until 
    * the current thread (joined thread) is terminated or completes its task.
*/
using System;
using System.Threading;

class JoinMethod
{
    public void Thread1()
    {
        for(int i=0; i<5; i++)
        {
            System.Console.WriteLine(i);
            Thread.Sleep(200);
        }
    }
}
class ThreadingJoinMethod
{
    static void Main(string[] jp)
    {
        JoinMethod jm = new JoinMethod();
        Thread t1 = new Thread(new ThreadStart(jm.Thread1));
        Thread t2 = new Thread(new ThreadStart(jm.Thread1));
        Thread t3 = new Thread(new ThreadStart(jm.Thread1));

            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
    }
}