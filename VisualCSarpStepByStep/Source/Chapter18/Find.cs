namespace Source.Chapter18;

public class T
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    
    public static bool operator ==(T? leftHandSide, T? rightHandSide)
    {
        if (leftHandSide is null && rightHandSide is null)
        {
            return true;
        }
    
        if (leftHandSide is null || rightHandSide is null)
        {
            return false;
        }

        return leftHandSide.ID == rightHandSide.ID &&
               leftHandSide.Name == rightHandSide.Name &&
               leftHandSide.Age == rightHandSide.Age;
    }
    
    public static bool operator !=(T leftHandSide, T rightHandSide)
    {
        return !(leftHandSide == rightHandSide);
    }
}

public class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public T t = new T(){};

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        
        if (obj is Person p)
        {
            return ID == p.ID && Name == p.Name && Age == p.Age;
        }
        else
        {
            return false;
        }
    }

    public static bool operator ==(Person? leftHandSide, Person? rightHandSide)
    {
        if (leftHandSide is null && rightHandSide is null)
        {
            return true;
        }
    
        if (leftHandSide is null || rightHandSide is null)
        {
            return false;
        }
        
        return leftHandSide.ID == rightHandSide.ID &&
               leftHandSide.Name == rightHandSide.Name &&
               leftHandSide.Age == rightHandSide.Age && 
               leftHandSide.t == rightHandSide.t;
    }
    
    public static bool operator !=(Person leftHandSide, Person rightHandSide)
    {
        return !(leftHandSide == rightHandSide);
    }
}
