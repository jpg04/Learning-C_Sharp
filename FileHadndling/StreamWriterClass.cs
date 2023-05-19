/*  C# StreamWriter
    C# StreamWriter class is used to write characters to a stream in specific encoding. 
    It inherits TextWriter class. 
    It provides overloaded write() and writeln() methods to write data into file.
*/
using System;
using System.IO;

class StreamWriterClass
{
    static void Main(string[] jp)
    {
        FileStream f = new FileStream("Thealgogeeks.txt",FileMode.Create);

        StreamWriter s = new StreamWriter(f);

        s.WriteLine("Hello Thealgogeeks");
        s.Close();
        f.Close();
        System.Console.WriteLine("File Created Successfully");
    }
}