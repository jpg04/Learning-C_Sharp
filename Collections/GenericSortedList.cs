/* 
    ? C# SortedList<TKey, TValue>
    * C# SortedList<TKey, TValue> is an array of key/value pairs. 
    * It stores values on the basis of key. 
    * The SortedList<TKey, TValue> class contains unique keys and -
    * maintains ascending order on the basis of key. 
    * By the help of key, we can easily search or remove elements. 
    * It is found in System.Collections.Generic namespace.
    
    * It is like SortedDictionary<TKey, TValue> class. 
*/

/* 
    ! C# SortedList<TKey, TValue> vs SortedDictionary<TKey, TValue>
    & SortedList<TKey, TValue> class uses less memory than SortedDictionary<TKey, TValue>. 
    & It is recommended to use SortedList<TKey, TValue> if you have to store and retrieve key/valye pairs. 
    & The SortedDictionary<TKey, TValue> class is faster than SortedList<TKey, TValue> class 
    & if you perform insertion and removal for unsorted data. 
*/
using System;
using System.Collections.Generic;

class GenericSortedList
{
    static void Main(string[] jp)
    {
        SortedList<string,string> names = new SortedList<string, string>();

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