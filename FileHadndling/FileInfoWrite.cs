/* FileInfoWrite 
Write into the File
*/

using System;
using System.IO;

class FileInfoWrite
{
    static void Main(string[] jp)
    {
        try
        {
            // Specifying file location 
            string loc = "Thealgogeeks.txt";

             // Creating FileInfo instance  
             FileInfo file = new FileInfo(loc);

             // Creating an file instance to write  
             StreamWriter sw = file.CreateText();

            //  Wrriting to the file
            sw.WriteLine("This text is Written to the file by using Stream Writer Class.");
            sw.Close();


        }
        catch(IOException e)
        {
            System.Console.WriteLine("Something went wrong : "+e);
        }
    }
}

