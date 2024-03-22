namespace Test13;

public class Square: Shape
{
    private readonly double _side;

    // Explicitly call the base class constructor in the derived class
    // public Square(double side): base()
    public Square(double side)
    {
        _side = side;
    }

    public override double Area()
    {
        // use "base.Area" explicitly call the base class method in the derived class
        // base.Area();
        // double area = _side * _side;
        // return area;
        
        return _side * _side;
    }
}
