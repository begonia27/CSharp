namespace Test15;

interface IComparable
{
    int CompareTo(object obj);
}

interface ILandBound
{
    int NumberOfLegs();
}

interface IGrazable
{
    string ChewGrass();
}

class Mammal
{
    
}

// use more interface, their order is: first one is base class, last one is interface
class Horse: Mammal, ILandBound, IGrazable
{
    public int NumberOfLegs()
    {
        return 4;
    }

    public string ChewGrass()
    {
        return $"chew some grass";
    }
}

// explicitly use interface
internal interface ILand
{
    int CountOfLegs();
}

internal interface IJourney
{
    int CountOfLegs();
}

internal class BlackHorse: ILand, IJourney
{
    int ILand.CountOfLegs()
    {
        return 4;
    }

    int IJourney.CountOfLegs()
    {
        return 3;
    }
}

// extend interface
public interface IMyInterface
{
    public string DoSomeWork();
}

public class SourceClass: IMyInterface
{
    public string DoSomeWork()
    {
        return $"source plan";
    }
}

// option one
// a usage interface inherits from another interface
public interface IExtendedInterface: IMyInterface
{
    public int AdditionalWork();
}

// must implement all of method
public class OtherClass: IExtendedInterface
{
    public string DoSomeWork()
    {
        return $"New plan";
    }
    
    public int AdditionalWork()
    {
        return 2;
    }
}

// option two
// throw new exception
public interface IThisInterface
{
    public double DoSomeWork();
    public string AdditionalWork()
    {
        throw new NotImplementedException();
    }
}

public class FirstClass: IThisInterface
{
    public double DoSomeWork()
    {
        return 1.2;
    }
}

public class SecondClass: IThisInterface
{
    public double DoSomeWork()
    {
        return 3.3;
    }

    public string AdditionalWork()
    {
        return $"All is well";
    }
}
