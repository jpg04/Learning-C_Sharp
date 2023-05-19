/*TextReader
C# TextReader class is found in System.
IO namespace. 
It represents a reader that can be used to read text or sequential series of characters. 
*/

/* using System;
using System.IO;

class TextReaderClass
{
    static void Main(string[] jp)
    {
        using(TextReader tr = File.OpenText("Thealgogeeks.txt"))
        {
            System.Console.WriteLine(tr.ReadToEnd());
        }
    }
}
 */

/* C# TextReader Example: Read One Line */
using System;
using System.IO;

class TextReaderClass
{
    static void Main(string[] jp)
    {
        using(TextReader tr = File.OpenText("Thealgogeeks.txt"))
        {
            System.Console.WriteLine(tr.ReadLine());
        }
    }
}
