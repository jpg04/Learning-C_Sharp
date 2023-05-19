/* StringWriter Class
    *This class is used to write and deal with string data rather than files. 
    It is derived class of TextWriter class. 
    The string data written by StringWriter class is stored into StringBuilder.

    *The purpose of this class is to manipulate string and save result into the StringBuilder. 
*/

/* StringWriter Class Signature
    [SerializableAttribute]  
    [ComVisibleAttribute(true)]  
    public class StringWriter : TextWriter   
*/

using System;
using System.IO;
using System.Text;

class StringWriterClass
{
    static void Main(string[] jp)
    {
        string text = "Hello, WelCome to The TheAlgoGeeks.\n" +
        "It is Useful site.\n" +
        "It Provodes technical contents.";

        // Creating StringBuilder instance  
        StringBuilder sb = new StringBuilder();

        // Passing StringBuilder instance into StringWriter  
        StringWriter writer = new StringWriter(sb);

        // Writing data using StringWriter  
        writer.WriteLine(text);
        writer.Flush();

        // Closing writer connection  
        writer.Close();

        // Creating StringReader instance and passing StringBuilder 
        StringReader reader = new StringReader(sb.ToString());

        // Reading data  
        while (reader.Peek() > -1)
        {
            System.Console.WriteLine(reader.ReadLine());
        }

    }
}