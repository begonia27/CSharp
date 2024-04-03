using System.Numerics;

namespace Source.Chapter17;

public class Circle<T> where T: IMultiplyOperators<T, T, T>
{
    private T side;
    
    public Circle(T sideLength)
    {
        side = sideLength;
    }

    public T Area()
    {
        T circleArea = side * side;

        return circleArea;
    }
}
