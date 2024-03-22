namespace Test07;

class Program
{
    // int? i = 111;
    //
    // if (i is int ii)
    // new Circle(ii);
    
    static void UseIfStatement()
    {
        Circle c = new Circle(42);
        Square s = new Square(55);
        Triangle t = new Triangle(33);
        
        object o = s;
    
        if (o is Circle myCircle)
        {
            Console.WriteLine($"o is Circle type, myCircle exist a reference");
        }
        else if (o is Square mySquare)
        {
            Console.WriteLine($"o is Square type, mySquare exist a reference");    
        }
        else if (o is Triangle myTriangle)
        {
            Console.WriteLine($"o is Triangle type, myTriangle exist a reference");
        }
    }

    static void UseSwitchStatement()
    {
        Circle c = new Circle(42);
        Square s = new Square(55);
        Triangle t = new Triangle(33);
        
        object o = s;

        switch (o)
        {
            case Circle myCircle:
                Console.WriteLine($"o is Circle type, myCircle exist a reference");
                break;
            case Square mySquare:
                Console.WriteLine($"o is Square type, mySquare exist a reference");
                break;
            case Triangle myTriangle:
                Console.WriteLine($"o is Triangle type, myTriangle exist a reference");
                break;
            default:
                throw new ArgumentException("变量不是可识别的几何图形");
                break;
        }
    }

    static void Main(string[] args)
    {
        UseIfStatement();
        UseSwitchStatement();
    }
}
