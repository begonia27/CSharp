namespace Vehicle;

class Program
{
    static void DoWork()
    {
        Console.WriteLine("Journey by airplane:");
        Airplane myPlane = new Airplane();
        myPlane.StartEngine("Contact");
        myPlane.TakeOff();
        myPlane.Drive();
        // 上一行等同于下面两行
        // Vehicle v = myPlane;
        // v.Drive();
        myPlane.Land();
        myPlane.StopEngine("Whirr");
        
        Console.WriteLine("Journey by car:");
        Car myCar = new Car();
        myCar.StartEngine("Brm brm");
        myCar.Accelerate();
        myCar.Drive(); 
        // 上一行等同于下面两行
        // Vehicle v = myCar;
        // v.Drive();
        myCar.Brake();
        myCar.StopEngine("Phut phut");
        
        Console.WriteLine("\nTesting polymorphism");
        Vehicle v = myCar;
        v.Drive();
        v = myPlane;
        v.Drive();

        // Vehicle v = new Car();
        // v.Drive();
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
