/* C# Threading Example: non-static method
 * For non-static method, you need to create instance of the class 
 * so that you can refer it in the constructor of ThreadStart class. 
*/
using System;
using System.Threading;

public class NonStaticThread
{
    public void Thread1()
    {
        for(int i=0; i<10; i++)
        {
            System.Console.WriteLine(i);
        }
    }
}

public class ThreadingNonStaticMethod
{
    public static void Main(string[] jp)
    {
        NonStaticThread nst = new NonStaticThread();
        Thread t1 = new Thread(new ThreadStart(nst.Thread1));
        Thread t2 = new Thread(new ThreadStart(nst.Thread1));
        t1.Start();
        t2.Start();
    }
}