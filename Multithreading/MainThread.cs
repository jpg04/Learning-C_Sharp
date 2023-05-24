/* C# Main Thread Example
*The first thread which is created inside a process is called Main thread. 
*It starts first and ends at last. 
*/
using System;
using System.Threading;

class MainThread
{
    static void Main(string[] jp)
    {
        Thread t = Thread.CurrentThread;
        t.Name = "MainThread";
        System.Console.WriteLine(t.Name);
    }
}