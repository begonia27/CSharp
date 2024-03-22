namespace Test15;

class Program
{
    static void Main(string[] args)
    {
        Horse myHorse = new Horse();
        
        Console.WriteLine(myHorse.NumberOfLegs());
        Console.WriteLine(myHorse.ChewGrass());

        Horse highHorse = new Horse();
        ILandBound iHighHorse = highHorse;
        Console.WriteLine(iHighHorse.NumberOfLegs());

        if (iHighHorse is ILandBound)
        {
            ILandBound iLandBoundAnimal = iHighHorse;
        }

        // 类与实例、接口与实例、类继承自不同的接口所调用的同名方法代表了不同的含义
        BlackHorse cuteHorse = new BlackHorse();
        ILand animalHorse = cuteHorse;
        IJourney tripHorse = cuteHorse;
        Console.WriteLine(animalHorse.CountOfLegs());
        Console.WriteLine(tripHorse.CountOfLegs());
        
        // access extend interface from option one:
        SourceClass source = new SourceClass();
        Console.WriteLine(source.DoSomeWork());
        
        OtherClass other = new OtherClass();
        Console.WriteLine(other.DoSomeWork());
        Console.WriteLine(other.AdditionalWork());
        
        // access extend interface from option two:
        IThisInterface previous = new FirstClass();
        Console.WriteLine(previous.DoSomeWork());
        
        // throw an exception
        // Console.WriteLine(previous.AdditionalWork()); 
        
        IThisInterface current = new SecondClass();
        Console.WriteLine(current.DoSomeWork());
        Console.WriteLine(current.AdditionalWork());
        
        // abstract class
        // Cannot create an instance of the abstract class 'Test15.LungBreathingMammal'
        // like this:
        // LungBreathingMammal dogAnimal = new LungBreathingMammal();
        Dog myDog = new Dog();
        myDog.Name = "Dog";
        IBreathing dogAnimal = myDog;
        Console.WriteLine(dogAnimal.Breath());
        Console.WriteLine(myDog.DigestWay());

        Rat myRat = new Rat();
        myRat.Name = "Rat";
        IBreathing ratAnimal = myRat;
        Console.WriteLine(ratAnimal.Breath());
        Console.WriteLine(myRat.DigestWay());

        // MammalAnimal arg = new();
        // arg.Name = "dfsfadsaf";
        // Console.WriteLine(myRat.DigestWay(arg));

        Wolf myWolf = new Wolf();
        IOtherBreathing wolfAnimal = myWolf;
        Console.WriteLine(wolfAnimal.Breath());
        Console.WriteLine(myWolf.DigestWay("Wolf"));

        Sheep mySheep = new Sheep();
        IOtherBreathing sheepAnimal = mySheep;
        Console.WriteLine(sheepAnimal.Breath());
        Console.WriteLine(mySheep.DigestWay("Sheep"));
    }
}

interface IIIII
{
    void I();
}

internal class C1: IIIII
{
    public void C1Function()
    {
        
    }

    public void I()
    {
        
    }
}

internal class C2: IIIII
{
    public void C2Function()
    {
        
    }

    public void I()
    {
        
    }
}

internal class C3: IIIII
{
    public void C3Function()
    {
        
    }

    public void I()
    {
        
    }
}

class MyClass
{
    public static void Test()
    {
        // 三个类调用了同一个接口，因此它们的实例也可以一同传给以接口作为参数的函数
        // 这样就可以获取不同类型的实参了
        C1 c1 = new C1();
        C2 c2 = new C2();
        C3 c3 = new C3();

        Test1(c1);
        Test1(c2);
        Test1(c3);
    }
    
    // 形参只能调用接口内定义的函数，不能调用其他类里定义的函数
    public static void Test1(IIIII a)
    {
        a.I();
        // 例如 a.C1Function() ，这样非法
    }
}
