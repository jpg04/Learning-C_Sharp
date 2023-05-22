/* DirectoryInfo Class
DirectoryInfo class is a part of System.IO namespace. 
It is used to create, delete and move directory. 
It provides methods to perform operations related to directory and subdirectory. 
It is a sealed class so, we cannot inherit it.

The DirectoryInfo class provides constructors, methods and properties that are listed below. 
*/

/* C# DirectoryInfo Syntax
[SerializableAttribute]  
[ComVisibleAttribute(true)]  
public sealed class DirectoryInfo : FileSystemInfo  
*/

using System;
using System.IO;

class DirectoryInfoClass
{
    static void Main(string[] jp)
    {
        // Provide directory name with complete location.  
        DirectoryInfo dir = new DirectoryInfo("Thealgogeeks");

        try
        {
            // Check, directory exist or not.  
            if(dir.Exists)
            {
                System.Console.WriteLine("Directory Already Exist.");
                return;
            }
             // Creating a new directory.  
             dir.Create();
             System.Console.WriteLine("The Directory is Creaed Successfully.");
        }
        catch(IOException e)
        {
            System.Console.WriteLine("Directory is Not Created: {0}",e.ToString());
        }
    }
} 