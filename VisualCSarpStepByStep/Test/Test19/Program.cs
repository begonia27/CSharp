namespace Test19
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri1 = new Triangle("") { Side3Length = 15 };
            Triangle tri2 = new Triangle("") { Side1Length = 15, Side3Length = 20 };
            Triangle tri3 = new Triangle("") { Side2Length = 12, Side3Length = 17 };
            Triangle tri4 = new Triangle("") { Side1Length = 9, Side2Length = 12, Side3Length = 15};
            Triangle tri5 = new Triangle("equilateral triangle") {Side1Length = 6, Side2Length = 6, Side3Length = 6};
            
            Console.WriteLine($"In tri1, Side1Length is {tri1.Side1Length}, Side2Length is {tri1.Side2Length}, Side3Length is {tri1.Side3Length}");
            Console.WriteLine($"In tri2, Side1Length is {tri2.Side1Length}, Side2Length is {tri2.Side2Length}, Side3Length is {tri2.Side3Length}");
            Console.WriteLine($"In tri3, Side1Length is {tri3.Side1Length}, Side2Length is {tri3.Side2Length}, Side3Length is {tri3.Side3Length}");
            Console.WriteLine($"In tri4, Side1Length is {tri4.Side1Length}, Side2Length is {tri4.Side2Length}, Side3Length is {tri4.Side3Length}");
            Console.WriteLine($"In tri5, shape is {tri5.shapeName}, Side1Length is {tri5.Side1Length}, Side2Length is {tri5.Side2Length}, Side3Length is {tri5.Side3Length}");
        }
    }
}
