/* 
    * C# Queue<T> class is used to Enqueue and Dequeue elements. 
    * It uses the concept of Queue that arranges elements in FIFO (First In First Out) order. 
    * It can have duplicate elements. 
    * It is found in System.Collections.Generic namespace.
*/

using System;
using System.Collections.Generic;

class GenericQueue
{
    static void Main(string[] jp)
    {
        Queue<string> games = new Queue<string>();
        games.Enqueue("Cricket");
        games.Enqueue("Kabbadi");
        games.Enqueue("Football");
        games.Enqueue("Baseball");
        games.Enqueue("Chess");
        games.Enqueue("Kho-Kho");

        foreach(string game in games)
        {
            System.Console.WriteLine(game);
        }

        System.Console.WriteLine();

        System.Console.WriteLine("Peek Elements : "+games.Peek());
        System.Console.WriteLine("Dequeue Elements : "+games.Dequeue());
        System.Console.WriteLine("After Dequeue, Peek Element : "+games.Peek());
    }
}