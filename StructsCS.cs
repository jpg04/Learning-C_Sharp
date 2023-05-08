using System;

/*public struct Rectangle
{
	public int height, width;
} 
*/

public struct Rectangle
{
	public int height, width;

	public Rectangle(int h, int w)
	{
		height = h;
		width = w;
	}

	public void arearOfRectangle()
	{
        Console.WriteLine("Area of Rectangle is : "+(width*height));
    }
}