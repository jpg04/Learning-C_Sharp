/* C# StreamReader
C# StreamReader class is used to read string from the stream. 
It inherits TextReader class. 
It provides Read() and ReadLine() methods to read data from the stream. 
*/

/* using System;
using System.IO;

class StreamReaderClass
{
    static void Main(string[] jp)
    {
        FileStream f = new FileStream("Thealgogeeks.txt",FileMode.OpenOrCreate);

        StreamReader s = new StreamReader(f);

        string line = s.ReadLine();
        System.Console.WriteLine(line);

        s.Close();
        f.Close();
            
    }
} */

using System;
using System.IO;

class StreamReaderClass 
{
    static void Main(string[] jp)
    {
        FileStream f = new FileStream("Thealgogeeks.txt",FileMode.OpenOrCreate);

        StreamReader s = new StreamReader(f);

        string line = "";

        while((line=s.ReadLine())!=null)
        {
            System.Console.WriteLine(line);
        }
        s.Close();
        f.Close();
    }
}