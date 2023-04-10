using System;

internal class Box
{
    private int length;
    private int width;
    private int height;

    public Box(int length, int width, int height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public int GetLength()
    {
        return length;
    }
    public int GetWidth()
    {
        return width;
    }
    public int GetHeight()
    {
        return height;
    }

    public static Box operator +(Box box1, Box box2)
    {
        return new Box(box1.GetLength() + box2.GetLength(),
            box1.GetWidth() + box2.GetWidth(),
            box1.GetHeight() + box2.GetHeight());
    }

}

public class OperatorOverloading
{
    public OperatorOverloading()
    {
        Console.WriteLine("Operator Overloading");
        Console.WriteLine("Operator Overloading");
    }
}
