/* C# Type class
* C# Type class represents type declarations for 
* class types, interface types, enumeration types, array types, value types etc. 
* It is found in System namespace. 
* It inherits System.Reflection.MemberInfo class.
*/

using System;

class GetType
{
    public static void Main(string[] jp)
    {
        int a = 10;

        Type type = a.GetType();
        System.Console.WriteLine("Tyep of int a is : "+type);
    }
}