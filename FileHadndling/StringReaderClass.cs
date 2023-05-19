/* StringReader Class
StringReader class is used to read data written by the StringWriter class. 
It is subclass of TextReader class. It enables us to read a string synchronously or asynchronously. 
It provides constructors and methods to perform read operations. 
*/

/* C# StringReader Signature
[SerializableAttribute]  
[ComVisibleAttribute(true)]  
public class StringReader : TextReader   
*/

using System;
using System.IO;

class StringReaderClass
{
    static void Main(string[] jp)
    {
        StringWriter str = new StringWriter();
        str.WriteLine("This Message is Read by StringReader Class.");
        str.Close();

        // Creating StringReader instance and passing StringWriter  
        StringReader reader = new StringReader(str.ToString());

        // Reading data 
        while(reader.Peek()>-1)
        {
            System.Console.WriteLine(reader.ReadLine());
        }
    }
}