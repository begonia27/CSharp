namespace Test01
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Farm fruit = new Farm(new List<string>(){"apple", "orange"}, 
                    new List<string>(){"autumn", "winter"});
                Farm vegetable = new(new List<string>() {"tomato", "potato"},
                    new List<string>() {"autumn"});
            }       
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
