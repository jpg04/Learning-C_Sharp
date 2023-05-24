/* C# Threading Example: 
* performing different tasks on each thread
* executing different methods on each thread. 
*/
using System;
using System.Threading;

class DifferentTask
{
    public static void Thread1()
    {
        System.Console.WriteLine("Task One");
    }
    public static void Thread2()
    {
        System.Console.WriteLine("Task Two");
    }
}

class ThreadingDifferentTask
{
        static void Main(string[] jp)
    {
        Thread t1 = new Thread(new ThreadStart(DifferentTask.Thread1));
        Thread t2 = new Thread(new ThreadStart(DifferentTask.Thread2));
        t1.Start();
        t2.Start();

    }
}