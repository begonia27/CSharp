namespace Test03;

public class Point
{
    public  int X;
    public  int Y;

    public ABC p = new ABC();
    
    // 定义一个点的坐标 x 和 y
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }                

    public void CloneTo(Point other) 
    {
        other.X = X;
        other.Y = Y;
        // other.p = p;
        other.p.a = p.a;
        // gfsdagsdfafasdasdfg.b = p.b;
        other.p.c = p.c;
        // other.p.aaa = p.aaa;

        Point v1 = other;
        ABC v2 = v1.p;
        ABC2 v3 = v2.aaa;
        int v4 = v3.a;
        (v3).a = p.aaa.a;

        // 
        // p.CloneTo(other);
        System.Console.WriteLine();
    }
}

public class ABC
{
    public int a;
    public int b;
    public int c;
    public ABC2 aaa = new ABC2();
}

public class ABC2
{
    public int a;
}
