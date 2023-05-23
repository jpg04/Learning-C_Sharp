/* 
* In C#, delegate is a reference to the method. 
* It works like function pointer in C and C++. 
* But it is objected-oriented, secured and type-safe than function pointer.

* For static method, delegate encapsulates method only. 
* But for instance method, it encapsulates method and instance both.

* The best use of delegate is to use as event.

* Internally a delegate declaration defines a class which is the derived class of System.Delegate
*/

using System;
delegate int Calculator(int n); // & declaring delegate   

class DelegatesClass
{
    static int number = 100;
    public static int add(int n)
    {
        number = number+n;
        return number;
    }

    public static int mul(int n)
    {
        number = number * n;
        return number;
        
    }

    public static int getNumber()
    {
        return number;
    }

    public static void Main(string[] jp)
    {
        Calculator c1 = new Calculator(add); // ^ instantiating delegate  
        Calculator c2 = new Calculator(mul); // ^ instantiating delegate  
        c1(50); // ~ calling method using delegate  
        System.Console.WriteLine("After c1 Delegate, Number is : "+getNumber());
        c2(3);
        System.Console.WriteLine("After c2 Delegate, Number is : "+getNumber());
    }
}