/* 
* C# Dictionary<TKey, TValue> class uses the concept of hashtable. 
* It stores values on the basis of key. It contains unique keys only. 
* By the help of key, we can easily search or remove elements. 
* It is found in System.Collections.Generic namespace. 
*/

using System;
using System.Collections.Generic;

class GenericDictionary
{
    static void Main(string[] jp)
    {
        Dictionary<string,string> names = new Dictionary<string, string>();

        names.Add("1","Jaydeep");
        names.Add("2","Jay");
        names.Add("3","Deep");
        names.Add("4","JD");
        names.Add("5","JP");

        foreach(KeyValuePair<string,string> kv in names)
        {
            System.Console.WriteLine(kv.Key+" "+kv.Value);
        }
    }
}