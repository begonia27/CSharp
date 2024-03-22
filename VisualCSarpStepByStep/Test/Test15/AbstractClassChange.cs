namespace Test15;

class MammalAnimal
{
    public string Name;
}

internal interface IBreathing
{
    public string Breath();
}

internal abstract class LungBreathingMammal: MammalAnimal, IBreathing
{
    public abstract string Breath();
}

class Dog: MammalAnimal, IBreathing
{
    public string Breath()
    {
        return "Their both usage lung breathing";
    }

    public string DigestWay()
    {
        return $"{Name} digest way";
    }
}

class Rat: MammalAnimal, IBreathing
{
    public string Breath()
    {
        return "Their both usage lung breathing";
    }

    public string DigestWay()
    {
        return $"{Name} digest way";
    }
}
