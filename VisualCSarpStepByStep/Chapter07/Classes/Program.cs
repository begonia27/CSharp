namespace Classes;

class Program
{
    static void DoWork()
    {
        Point origin = new();

        origin._x = -1;
        origin._y = -1;
        ++Point._objectCount;
    
        Point bottomRight = new();

        bottomRight._x = 1366;
        bottomRight._y = 768;

        ++Point._objectCount;

        double distance = DistanceTo(origin._x, bottomRight._x, origin._y, bottomRight._y);
        
        Console.WriteLine($"Distance is: {distance}");
        Console.WriteLine($"Number of Point objects: {Point.ObjectCount()}");
    }

    private static double DistanceTo(int x1, int x2, int y1, int y2)
    {
        return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    }
    
    static void Main(string[] args)
    {
        try
        {
            DoWork();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
