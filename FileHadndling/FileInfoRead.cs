/*FileInfoRead
Reading text from the file 
*/

using System;
using System.IO;

class FileInfoRead
{
    static void Main(string[] jp)
    {
        try
        {
            // Specifying file to read  
            string loc = "Thealgogeeks.txt";

             // Creating FileInfo instance  
             FileInfo file = new FileInfo(loc);

            // Opening file to read  
            StreamReader reader = file.OpenText();

            string data = "";

            while((data=reader.ReadLine())!=null)
            {
                System.Console.WriteLine(data);
            }
        }
        catch(IOException e)
        {
            System.Console.WriteLine("Something went wrong : "+e);
        }
    }
}