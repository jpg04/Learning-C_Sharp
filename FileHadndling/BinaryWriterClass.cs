/* BinaryWriter
C# BinaryWriter class is used to write binary information into stream. 
It is found in System.IO namespace. 
It also supports writing string in specific encoding. 
*/

using System;
using System.IO;
class BinaryWriterClass
{
    static void Main(string[] jp)
    {
        string fileName = "Thealgogeeks.txt";
        using (BinaryWriter writer = new BinaryWriter(File.Open(fileName,FileMode.Create)))
        {
            writer.Write(2.5);
            writer.Write("This is String Data");
            writer.Write(true);

        }
        System.Console.WriteLine("Data Written Successfully");
    }
}