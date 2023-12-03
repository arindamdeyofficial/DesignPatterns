using System.Numerics;

public class exc
{
    public exc()
    {
        division();
    }
    public void division()
    {
        Console.WriteLine(2/10);
        int n = 2;
        int r = 2 / 10;
        int s = 2 % 10;
        var x = 2 / 10;
        decimal y = 2 / 10;
        double d = 2 / 10;
        float f = 2 / 10;
        double g = 2d / 10d;
        double h = 2.0 / 10;
        Console.WriteLine(x);//var
        Console.WriteLine(s);//division
        Console.WriteLine(r);//reminder
        Console.WriteLine(y);//decimal
        Console.WriteLine(d);//double
        Console.WriteLine(f);//float
        Console.WriteLine(g);//point
        Console.WriteLine(h);//point
    }
}
public class A:B
{
    public A() 
    {
        Console.WriteLine("A");
    }
}
public class B:C
{
    public B()
    {
        Console.WriteLine("B");
    }
}
public class C
{
    public C()
    {
        Console.WriteLine("C");
    }
}