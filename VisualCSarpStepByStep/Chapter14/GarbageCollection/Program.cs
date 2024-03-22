using System.Net.Http.Headers;

namespace GarbageCollection;

class Program
{
    static void DoWork()
    {
        using (Calculator calculator = new Calculator())
        {
            // Console.WriteLine($"120/15 = {calculator.Divide(120, 0)}");
            Console.WriteLine($"120/15 = {calculator.Divide(120, 15)}");
        }
        Console.WriteLine("Program finishing");
    }
    
    static void Main(string[] args)
    {
        try
        {
            DoWork();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
