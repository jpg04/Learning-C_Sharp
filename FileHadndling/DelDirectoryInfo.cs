/* Deleting Directory
The DirectoryInfo class also provides a delete method to delete created directory. 
In the following program, we are deleting a directory that we created in previous program.
*/

using System;
using System.IO;

class DelDirectoryInfo
{
    static void Main(string[] jp)
    {
        DirectoryInfo dir = new DirectoryInfo("Thealgogeeks");

        try
        {
            dir.Delete();
            System.Console.WriteLine("The Directory is Deleted Successfully.");
        }
        catch(IOException e)
        {
            System.Console.WriteLine("Something Went wrong : {0}"+e);
        }
    }
}


/* 
It throws a System.IO.DirectoryNotFoundException exception if the specified directory not present at the location.
*/