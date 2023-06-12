using System;

class csDelegatesAnonymousFun
{
    public delegate void VoidDelegate();
    public delegate void VoidDelegateWithParam(string name);
    public delegate int Calculate(int x, int y);

    public static void Main(string[] jp)
    {
        VoidDelegateWithParam del = delegate(string s) //Anonymous Function
        {
            System.Console.WriteLine(s);
        };
        del("Jaydeep");
    }

}