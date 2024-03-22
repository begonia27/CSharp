namespace Factorial;

class Program
{
    static void Main(string[] args)
    {
        (new Program()).Run();
    }

    void Run()
    {
        Console.Write("Please enter a positive integer: ");
        string inputValue = Console.ReadLine();
        long factorialValue = CalculateFactorial(inputValue);
        
        Console.WriteLine($"Factorial({inputValue}) is {factorialValue}");
    }
    
    long CalculateFactorial(string input)
    {
        int inputValue = int.Parse(input);
        long factorialValue = Factorial(inputValue);
        
        long Factorial(int dataValue)
        {
            if (dataValue == 1)
            {
                return 1;
            }
            else
            {
                return dataValue * Factorial(dataValue - 1);
            }
        }
        return factorialValue;
    }
}
