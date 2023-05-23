/* 
    * C# SortedDictionary<TKey, TValue> class uses the concept of hashtable. 
    * It stores values on the basis of key. 
    * It contains unique keys and maintains ascending order on the basis of key. 
    * By the help of key, we can easily search or remove elements. 
    * It is found in System.Collections.Generic namespace. 
*/

using System;
using System.Collections.Generic;

class GenericSortedDictionary
{
    static void Main(string[] jp)
    {
        SortedDictionary<string,string> names = new SortedDictionary<string, string>();

        names.Add("1","Jaydeep");
        names.Add("4","JD");
        names.Add("3","Deep");
        names.Add("5","JP");
        names.Add("2","Jay");

        foreach(KeyValuePair<string,string> kv in names)
        {
            System.Console.WriteLine(kv.Key+" "+kv.Value);
        }
    }
}