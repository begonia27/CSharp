namespace Test05;

class Program
{
    static void Main(string[] args)
    {
        // int? i = 56;
        int? i = null;

        if (!i.HasValue)
        {
            i = 99;
            Console.WriteLine(i.Value);
        }
        else
        {
            Console.WriteLine(i.Value);
        }
    }
}
