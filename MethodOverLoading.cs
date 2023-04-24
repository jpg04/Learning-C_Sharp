using System;

public class MethodOverLoading
{
	public int Addition(int a, int b)
	{
        return a + b;
    }
    public float Addition(float a, float b, float c)
	{
        return a + b + c;
    }
    public double Addition(double a, double b, double c,double d)
	{
        return a + b + c + d;
    }

}
