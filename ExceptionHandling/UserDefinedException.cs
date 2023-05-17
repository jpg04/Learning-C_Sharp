/* C# User-Defined Exceptions
    *C# allows us to create user-defined or custom exception. 
    *It is used to make the meaningful exception. 
    *To do this, we need to inherit Exception class.
*/

using System;

class InvalidAgeException : Exception
{
    public InvalidAgeException(String message) : base(message)
    {

    }
}
class UserDefinedException
{
    static void Validate(int age)
    {
        if(age<18)
        {
            throw new InvalidAgeException("Sorry, Age Must be Greater than 18...!");
        }
    }
    public static void Main(string[] args)
    {
        try
        {
            Validate(12);    
        }
        catch(InvalidAgeException e)
        {
            System.Console.WriteLine(e);
        }

        System.Console.WriteLine("Some of Remaining Code...!");
    }
}
