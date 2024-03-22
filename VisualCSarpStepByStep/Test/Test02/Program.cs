using System.Formats.Asn1;
using Test02;

namespace Test02;

class Program
{
    static void Main(string[] args)
    {
        Triangle result = new(4, 5);
        Console.WriteLine($"The circumference is: {result.Circumference()}");

        // Triangle c = new(8, 3);
        Triangle c = null;
        Console.WriteLine($"The area of circle c is {c?.Circumference()}");

        Triangle c2 = c ?? new Triangle(2, 2);
        Console.WriteLine($"The area of circle c is {c2.Circumference()}");
    }
}
