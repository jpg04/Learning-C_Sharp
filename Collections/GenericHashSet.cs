using System;
using System.Collections.Generic;
class GenericHashSet
{
    static void Main(string[] jp)
    {
        /* // creating set of string using hashset

        var names = new HashSet<string>();

        names.Add("Jay");
        names.Add("Deep");
        names.Add("JP");
        names.Add("Jaydeep");
        names.Add("Jay"); //this will not be added

         // Iterate HashSet elements using foreach loop  
        foreach(var name in names)
        {
            System.Console.WriteLine(name);
        } */


        /* HashSet<int> evenNum = new HashSet<int>();
        HashSet<int> oddNum = new HashSet<int>();

        for(int i = 0; i<=5; i++)
        {
            // Populate numbers with just even numbers.
            evenNum.Add(i*2);

            // Populate numbers with just odd numbers.
            oddNum.Add((i*2)+1);
        }

        System.Console.WriteLine("evenNum contains {0} elements : ",evenNum.Count);
        DisplaySet(evenNum);

        System.Console.WriteLine("oddNum contains {0} elements : ",evenNum.Count);
        DisplaySet(oddNum);

        // Create a new HashSet populated with even numbers.
        HashSet<int> num = new HashSet<int>(evenNum);
        System.Console.WriteLine("Number Union with oddNumbers...!");
        num.UnionWith(oddNum);

        System.Console.WriteLine("num contains {0} elements : ",num.Count);
        DisplaySet(num);
        void DisplaySet (HashSet<int> collection)
        {   
            System.Console.Write("{");
            foreach(int i in collection)
            {
                System.Console.Write("{0}",i);
            }
            System.Console.WriteLine("}");
        } */

        // creating a hashset of odd numbers 
        /* HashSet<int> odd = new HashSet<int>();

        // Inserting elements in HashSet
        for(int i=0; i<5; i++)
        {
            odd.Add((i*2)+1);
        } */
        // Displaying the elements in the HashSet
        /* foreach(int i in odd)
        {
            System.Console.WriteLine(i);
        } */

        // System.Console.WriteLine(odd.Count);

        

        // /*C# code to Check if a HashSet is
        //   a subset of the specified collection */

        // // Creating a HashSet of integers
        // HashSet<int> set1 = new HashSet<int>();
        // /* 
        // * Set1 only contains even numbers less than
        // * equal to 10 
        // */

        // for(int i = 1; i<=5; i++ )
        // {
        //     set1.Add(i*2);
        // }

        // // Creating 2md HashSet of integers
        // HashSet<int> set2 = new HashSet<int>();
        // /* 
        // * Inserting elements in HashSet
        // * Set2 contains all numbers from 1 to 10*/
        // for(int i=1; i<=10; i++)
        // {
        //     set2.Add(i);
        // }
        // /* 
        // * Check if a HashSet Set1 is a subset
        // * of the HashSet Set2 */
        // System.Console.WriteLine(set1.IsSubsetOf(set2)); 
        

        HashSet<string> Languages = new HashSet<string>();

        Languages.Add("C");
        Languages.Add("C++");
        Languages.Add("C#");
        Languages.Add("JAVA");

        if(Languages.Contains("C"))
        {
            System.Console.WriteLine("Required Element is Present");
        }
        else
        {
            System.Console.WriteLine("Required Element is Not Present");
        }
        

    }
}