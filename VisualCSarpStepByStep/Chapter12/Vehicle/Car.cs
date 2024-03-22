namespace Vehicle;

public class Car: Vehicle
{
    // 加速
    public void Accelerate()
    {
        Console.WriteLine("Accelerating");
    }

    // 刹车
    public void Brake()
    {
        Console.WriteLine("Braking");
    }

    public override void Drive()
    {
        Console.WriteLine("Motoring");
    }
}
