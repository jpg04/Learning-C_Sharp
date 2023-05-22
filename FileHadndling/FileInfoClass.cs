/* FileInfo Class
The FileInfo class is used to deal with file and its operations in C#. 
It provides properties and methods that are used to create, delete and read file. 
It uses StreamWriter class to write data to the file. 
It is a part of System.IO namespace. 
*/

/* C# FileInfo Class Signature
[SerializableAttribute]  
[ComVisibleAttribute(true)]  
public sealed class FileInfo : FileSystemInfo   
*/
using System;
using System.IO;

class FileInfoClass
{
    static void Main(string[] jp)
    {
        try
        {
             // Specifying file location  
             string loc = "Thealgogeeks.txt";

             // Creating FileInfo instance
             FileInfo file = new FileInfo(loc);
        
            // Creating an empty file  
            file.Create();
            System.Console.WriteLine("File Created Successfully.");
        }
        catch(IOException e)
        {
            System.Console.WriteLine("SomeThing Went Wrong");
        }
    }
}


