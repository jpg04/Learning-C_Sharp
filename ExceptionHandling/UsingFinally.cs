/* C# finally
C# finally block is used to execute important code which is to be executed whether exception is handled or not. It must be preceded by catch or try block.
*/
/* using System;
namespace ExceptionHandling
{
    class UsingFinally
    {
        public static void Main(string[] args)
        {
                try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
            finally
            {
                System.Console.WriteLine("Finally block is executed...!");
            }

            System.Console.WriteLine("Example Using Finally");
        }
    }
} */

using System;
namespace ExceptionHandling
{
    class UsingFinally
    {
        public static void Main(string[] args)
        {
                try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch (NullReferenceException e)
            {
                System.Console.WriteLine(e);
            }
            finally
            {
                System.Console.WriteLine("Finally block is executed...!");
            }

            System.Console.WriteLine("Example Using Finally");
        }
    }
}