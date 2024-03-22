using System;

namespace DailyRate;

class Program
{
    static void Main(string[] args)
    {
        (new Program()).Run();
    }

    void Run()
    {
        double dailyRate = ReadDouble("Enter your daily rate: ");
        int noOfDays = ReadInt("Enter the number of days: ");
        WriteFee(CalculateFee(dailyRate, noOfDays));

        return;
        
        int ReadInt(string v)
        {
            Console.WriteLine(v);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        double ReadDouble(string v)
        {
            Console.WriteLine(v);
            string line = Console.ReadLine();
            return double.Parse(line);
        }
    }

    private void WriteFee(double v) => Console.WriteLine($"The consultant's fee is: {v * 1.1}");

    private double CalculateFee(double dailyRate, int noOfDays) => dailyRate * noOfDays;
}
