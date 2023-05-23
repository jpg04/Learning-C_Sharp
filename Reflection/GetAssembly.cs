    using System;

    class GetAssembly
    {
        static void Main(string[] jp)
        {
            Type t = typeof(System.String);
            System.Console.WriteLine(t.Assembly);
        }
    }