/*
 C# FileStream example: writing multiple bytes into file
*/
// write multiple bytes of data into file using loop.

using System;
using System.IO;

class FileStreamClass2
{
    static void Main(string []jp)
    {
        FileStream f = new FileStream("Thealgeegeeks.txt",FileMode.OpenOrCreate);
        for(int i=65; i<=90; i++)
        {
            f.WriteByte((byte)i);
        }
        f.Close();

    }
}