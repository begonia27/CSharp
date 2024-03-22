namespace ParamArrays;

class Program
{
    static void DoWork()
    {
        // Console.WriteLine(Util.Sum(null));
        // Console.WriteLine(Util.Sum());
        // Console.WriteLine(Util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));
        Console.WriteLine(Util.Sum(2, 4, 6, 8));
        Console.WriteLine(Util.Sum(2, 4, 6));
        Console.WriteLine(Util.Sum(2, 4, 6, 8, 10));
    }
    
    static void Main(string[] args)
    {
        try
        {
            DoWork();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: {0}", ex.Message);
        }
    }
}
