namespace DailyRateUsingOptionalParameters;

class Program
{
    static void Main(string[] args)
    {
        (new Program()).Run();
    }

    public void Run()
    {
        double fee = CalculateFee(defaultNoOfDays: 2);
        Console.WriteLine($"Fee is {fee}");
    }

    private double CalculateFee(double dailyRate, int noOfDays)
    {
        Console.WriteLine("calculateFee using two optional parameters");
        return dailyRate * noOfDays;
    }
    
    private double CalculateFee(double dailyRate)
    {
        Console.WriteLine("calculateFee using two optional parameters");
    
        int dafaultNoOfDays = 1;
        return dailyRate * dafaultNoOfDays;
    }
    
    private double CalculateFee(int defaultNoOfDays)
    {
        Console.WriteLine("calculateFee using two optional parameters");
    
        double dailyRate = 500.0;
        return dailyRate * defaultNoOfDays;
    }
    
    private double CalculateFee()
    {
        Console.WriteLine("calculateFee using hardcoded values");
        double defaultDailyRate = 400.0;
        int defaultNoOfDays = 1;
        return defaultDailyRate * defaultNoOfDays;
    }
    
    private double CalculateFee2(double dailyRate = 500.0, int noOfDays = 1)
    {
        Console.WriteLine("calculateFee2 using two optional parameters");
        return dailyRate * noOfDays;
    }
}
