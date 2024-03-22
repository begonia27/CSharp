namespace Test13;

public class Circle: Shape
{
    private readonly double _radius;

    // Explicitly call the base class constructor in the derived class
    // public Circle(double radius): base()
    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double Area()
    {
        // use "base.Area" explicitly call the base class method in the derived class
        // base.Area();
        // double area = Math.PI * _radius * _radius;
        // return area;
        
        return Math.PI * _radius * _radius;
    }
}
