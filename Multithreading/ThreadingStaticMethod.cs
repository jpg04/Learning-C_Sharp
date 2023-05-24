/* C# Threading Example: static method
  * We can call static and non-static methods on the execution of the thread. 
  * To call the static and non-static methods, 
  * you need to pass method name in the constructor of ThreadStart class. 
  * For static method, we don't need to create the instance of the class. 
  * You can refer it by the name of class. 
*/
using System;
using System.Threading;

class MyThread
{
    public static void Thread1()
    {
        for(int i=0; i<10; i++)
        {
            System.Console.WriteLine(i);
        }
    }
}
class ThreadingStaticMethod
{
    public static void Main(string[] jp)
    {
        Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
        Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
        t1.Start();
        t2.Start();

    }
}

/* Output:
! The output of the above program can be anything because there is context switching between the threads.
*/

