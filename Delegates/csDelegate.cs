using System;
public delegate void VoidDelegate();
public delegate void VoidDelegateParams(string name);
public delegate int CalculationDelegates(int x, int y);
class csDelegate
{
    public static void Main(string[] jp)
    {
        VoidDelegate del1 = Print1;
        VoidDelegateParams del2 = Print2;
        // del1 +=Print1;
        // del1 = del1 + Print1;
        Child.ExecuteDelegate(del1);
        Child.ExecuteDelegate(del2);

        CalculationDelegates del3 = Add;
        CalculationDelegates del4 = Sub;
        Child.ExecuteDelegate(del3);
        Child.ExecuteDelegate(del4);
    }
    private static void Print1()
    {
        System.Console.WriteLine("Hello JP This is Method 1");
    }
    private static void Print2(string name)
    {
        System.Console.WriteLine(name);
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }
    public static int Sub(int x, int y)
    {
        return x - y;
    }
}
class Child
{
    /* 
    private static void Print2()
    {
        csDelegate.Print(); // Cannot access Private method due security reasons
    } 
    */

    public static void ExecuteDelegate(VoidDelegate del)
    {
        del(); // accessing Private method using delegate
    } 
    public static void ExecuteDelegate(VoidDelegateParams del)
    {
        del("Jaydeep"); //accessing Private method using delegate
    } 
    public static void ExecuteDelegate(CalculationDelegates del)
    {
       System.Console.WriteLine(del(5,3)); //Use of Existing methods of delegates
}
