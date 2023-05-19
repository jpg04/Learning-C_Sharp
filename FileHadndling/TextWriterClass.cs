/* C# TextWriter class is an abstract class. 
It is used to write text or sequential series of characters into file. 
It is found in System.
IO namespace. 
*/
using System;
using System.IO;
class TextWriterClass
{
    static void Main(string[] jp)
    {
        using(TextWriter writer = File.CreateText("Thealgogeeks.txt"))
        {
            writer.WriteLine("Hello Algogeeks");
            writer.WriteLine("Here I am performing File handling Operation in C#");
        }
        System.Console.WriteLine("Data Written SuccessFully...!");

    }
}