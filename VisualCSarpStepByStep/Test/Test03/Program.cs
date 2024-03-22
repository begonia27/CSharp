// 四个点：(2, 5) (3, 5) (2, -6) (3, -6)

namespace Test03;

class Program
{
    static void Main(string[] args)
    {
        // Point a = new Point(-2, 5);
        // Point b = new Point(3, 5);
        // Point c = new Point(-2, -6);
        // Point d = new Point(3, -6);
        
        // RectangleArea result = new RectangleArea(a, b, c, d);
        
        Rectangle rect = new(new Point(2, 5),new Point(3, 5), 
            new Point(2, -6), new Point(3, -6));
        
        Console.WriteLine($"The rectangle area is: {rect.Area()}");

        Point a = new Point(3, 5);
        Point b = new Point(4, 6);

        Point c = new Point(1, 3);
        // a.X;
        int x;
        // Point pppppp = new Point(); 
        // c = b;
        b.CloneTo(c);
        b.p.a = 999;
        Console.WriteLine(b.p.a);
        Console.WriteLine(b.p.b);
        Console.WriteLine(c.p.a);
        Console.WriteLine(c.p.b);
    }
}
