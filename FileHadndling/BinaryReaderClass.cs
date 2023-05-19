/* BinaryReader
C# BinaryReader class is used to read binary information from stream. 
It is found in System.IO namespace. 
It also supports reading string in specific encoding.
*/
using System;
using System.IO;

class BinaryReaderClass
{
    static void Main(string[] jp)
    {
        WriteBinaryFile();
        ReadBinaryFile();
        Console.ReadKey();
    }
    static void WriteBinaryFile()
    {
        using(BinaryWriter writer = new BinaryWriter(File.Open("Thealgogeeks.txt",FileMode.Create)))
        {
            writer.Write(12.5);
            writer.Write("This is String Data");
            writer.Write(true);
        }

    }
    static void ReadBinaryFile()
    {
        using(BinaryReader reader = new BinaryReader(File.Open("Thealgogeeks.txt",FileMode.Open)))
        {
            System.Console.WriteLine("Double Value : "+reader.ReadDouble());
            System.Console.WriteLine("String Data : "+reader.ReadString());
            System.Console.WriteLine("Boolean Value : "+reader.ReadBoolean());
        }
    }
}
