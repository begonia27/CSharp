namespace Vehicle;

public class Airplane: Vehicle
{
    // 起飞
    public void TakeOff()
    {
        Console.WriteLine("Taking off");
    }

    // 着陆
    public void Land()
    {
        Console.WriteLine("Landing");
    }

    public override void Drive()
    {
        Console.WriteLine("Flying");
    }
}
