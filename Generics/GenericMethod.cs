/* 
* C# allows us to create generic methods also. 
* In the following example, we are creating generic method 
* that can be called by passing any type of argument. 
*/

using System;

class GenericMethod
{
    public void show<J>(J msg)
    {
        System.Console.WriteLine(msg);
    }
}

class GenericMethodProgram 
{
    static void Main(string[] jp)
    {
        GenericMethod genMethod = new GenericMethod();

        genMethod.show("My Name is Jaydeep and This is generic Method");
        genMethod.show("My Roll Number is : "+18);
        genMethod.show("My Div is : " + 'A');
    }
}