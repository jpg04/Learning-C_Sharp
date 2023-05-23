/* C# LinkedList<T>
* C# LinkedList<T> class uses the concept of linked list. 
* It allows us to insert and delete elements fastly. 
* It can have duplicate elements. 
* It is found in System.Collections.Generic namespace.

It allows us to add and remove element at before or last index. 
*/
using System;
using System.Collections.Generic;

class GenericLinkedList
{
    static void Main(string[] jp)
    {
        // create a list of list using linkedlist

        /* var names = new LinkedList<string>();

        names.AddLast("Jaydeep");
        names.AddLast("Jay");
        names.AddLast("Deep");
        names.AddLast("JD");
        names.AddFirst("JP"); // * added to first index  

            * Iterate list element using foreach loop  
         foreach(var name in names)
         {
            System.Console.WriteLine(name);
         } */


         var names = new LinkedList<string>();
        //  ! Note: Unlike List, you cannot create LinkedList using Collection initializer.

        names.AddLast("Jaydeep");
        names.AddLast("Jay");
        names.AddLast("Deep");
        names.AddLast("JD");
        names.AddLast("JP"); // * added to first index  

        //insert new element before "Peter"  
        LinkedListNode<string> node = names.Find("JP");
        names.AddBefore(node,"Anna");
        names.AddAfter(node,"Godase");

         // * Iterate list element using foreach loop  
         foreach(var name in names)
         {
            System.Console.WriteLine(name);
         }
    }
}