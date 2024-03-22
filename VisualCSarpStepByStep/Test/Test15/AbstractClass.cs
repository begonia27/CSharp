namespace Test15;

class OtherMammal
{
    
}

internal interface IOtherBreathing
{
    public string Breath();
}

internal abstract class OtherLungBreathingMammal: OtherMammal, IOtherBreathing
{
    public abstract string Breath();
}

class Wolf: OtherMammal, IOtherBreathing
{
    public string Breath()
    {
        return "Their usage lung breathing";
    }
    
    public string DigestWay(string name)
    {
        return $"{name} digest way";
    }
}

class Sheep: OtherMammal, IOtherBreathing
{
    public string Breath()
    {
        return "Their usage lung breathing";
    }

    public string DigestWay(string name)
    {
        return $"{name} digest way";
    }
}
