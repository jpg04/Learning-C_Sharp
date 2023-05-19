/* C# FileStream example: reading all bytes from file */
using System;
using System.IO;
class FileStreamClass3
{
    static void Main(string []jp)
    {
        FileStream f = new FileStream("Thealgogeeks.txt",FileMode.OpenOrCreate);
        int i = 0;
        while((i=f.ReadByte())!= -1)
        {   
            Console.Write((char)i);
        }
        f.Close();
    }
}