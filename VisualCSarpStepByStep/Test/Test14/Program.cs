namespace Test14;

static class Program
{
    public static int Negate(this int i)
    {
        return -i;
    }
    
    static void Main(string[] args)
    {
        int x = 591;

        Negate(x);

        x.Negate();
        
        Console.WriteLine($"x.Negate {x.Negate()}");
    }
}
