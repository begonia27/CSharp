namespace Test11;

// 三角形判断：
// 创建一个名为 Triangle 的类，具有三个属性：_oneEdgeLength、_twoEdgeLength 和 _threeEdgeLength。
// 编写构造函数，接受三个参数（三角形的三条边长），并将其分配给相应的属性。
// 实现一个方法 is_valid_triangle，用于判断这三条边是否能构成一个有效的三角形。
// 三角形的判断条件是：任意两边之和大于第三边，且任意两边之差小于第三边。
// 创建一个三角形对象，设置其三条边分别为3、4和5，然后调用 is_valid_triangle 方法并输出结果。

internal class Triangle
{
    private readonly int _a;
    private readonly int _b;
    private readonly int _c;

    // ReSharper disable once ConvertToPrimaryConstructor
    public Triangle(int a, int b, int c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public bool IsValidTriangle()
    {
        bool b1 = (_a + _b) > _c;
        bool b2 = (_b + _c) > _a;
        bool b3 = (_a + _c) > _b;
        
        return b1 && b2 && b3;
    }
}
