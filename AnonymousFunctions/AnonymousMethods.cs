/* C# Anonymous Methods
* Anonymous method provides the same functionality as lambda expression, 
* except that it allows us to omit parameter list.
*/

using System;

class AnonymousMethods
{
    public delegate void AnonymousFun();
    static void Main(string[] jp)
    {
        AnonymousFun fun = delegate()
        {
            System.Console.WriteLine("This is Anonymous Function");
        };
        fun();
    }
}