/* 
* Generic is a concept that allows us to define classes and methods with placeholder. 
* C# compiler replaces these placeholders with specified type at compile time. 
* The concept of generics is used to create general purpose classes and methods.

* o define generic class, we must use angle <> brackets. 
* The angle brackets are used to declare a class or method as generic type. 
* In the following example, we are creating generic class that can be used to deal with any type of data. 
*/


using System;

class GenericClass<J>
{
    public GenericClass(J msg)
    {
        System.Console.WriteLine(msg);
    }
}

class GenericClassProgram
{
    static void Main(string[] jp)
    {
        GenericClass<string> genStr = new GenericClass<string>("This is Generic Class");
        GenericClass<int> genInt = new GenericClass<int>(18);
        GenericClass<char> genChar = new GenericClass<char>('J');
    }
}