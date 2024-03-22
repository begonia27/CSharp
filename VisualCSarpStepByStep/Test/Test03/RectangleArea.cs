// 计算长方形的面积，已知的值是四个点的坐标

namespace Test03;

class Rectangle
{
    private readonly int _length;
    private readonly int _width;

    // 定义四个点 a b c d 字段, 每个点的坐标取 Point 类中的 x 和 y
    private Point _a;
    private Point _b;
    private Point _c;
    private Point _d;
    
    // 构造函数，从外部获得四个点的参数
    public Rectangle(Point a, Point b, Point c, Point d)
    {
        _a = a;
        _b = b;
        _c = c;
        _d = d;

        // 计算长和宽（使用相应点的 x 坐标和 y 坐标）
        _length = Math.Abs(a.X - b.X);
        _width = Math.Abs(a.Y - c.Y);
    }
    
    public int Area()
    {
        int area = _length * _width;
        return area;
    }
}
