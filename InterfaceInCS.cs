using System;

public interface InterfaceInCS
{
    void Draw();
}

public class InterfaceInCS2 : InterfaceInCS
{
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle...!");
    }
}

public class InterfaceInCS3 : InterfaceInCS
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle...!");
    }
}