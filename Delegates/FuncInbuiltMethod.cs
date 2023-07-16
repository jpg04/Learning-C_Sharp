using System;

/* class FuncInbuiltMethod
{
    public static void Main(string[] jp)
    {
        Func<string> func = GetMessage;
        System.Console.WriteLine(func());
    }

    public static string GetMessage()
    {
        return "Jaydeep You Have New Message";
    }   
}
 */

 /* class FuncInbuiltMethod
{
    public static void Main(string[] jp)
    {
        Func<string,string> func = GetMessage;
        System.Console.WriteLine(func("The Message is : Meeting is Scheduled By JP Sir"));
    }

    public static string GetMessage(string msg)
    {
        return "Jaydeep You Have New Message " + msg;
    }   
}
 */

 class FuncInbuiltMethod
{
    public static void Main(string[] jp)
    {
        Func<int, string> func = GetMessage;
        System.Console.WriteLine(func(4));
    }

    public static string GetMessage(int msg)
    {
        return "Jaydeep You Have New Message " + msg;
    }   
}
