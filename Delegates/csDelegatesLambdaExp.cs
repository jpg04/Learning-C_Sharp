using System;

class csDelegatesLambdaExp
{
    public delegate void VoidDelegate();
    public delegate void VoidDelegateWithParam(string name);
    public delegate int Calculate(int x, int y);

    public static void Main(string[] jp)
    {
        VoidDelegateWithParam del = s=>  // Lambda Expression
        {
            System.Console.WriteLine(s);
        };
        del("Jaydeep");
    }

}