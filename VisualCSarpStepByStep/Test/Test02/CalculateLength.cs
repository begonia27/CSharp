using Test02;

namespace Test02;

class Triangle
{
    private readonly int _oneEdgeLength;
    private readonly int _twoEdgeLength;
    private readonly int _threeEdgeLength;

    public Triangle()
    {
        // _oneEdgeLength = 3;
        _oneEdgeLength = 0;
    }

    public Triangle(int y, int z):this()
    {
        
        this._twoEdgeLength = y;
        this._threeEdgeLength = z;
    }

    public int Circumference()
    {
        return this._oneEdgeLength + this._twoEdgeLength + this._threeEdgeLength;
    }
}
