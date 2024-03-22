using System.Diagnostics.CodeAnalysis;

namespace Test11;

// 三角形判断：
// 创建一个名为 Triangle 的类，具有三个属性：_oneEdgeLength、_twoEdgeLength 和 _threeEdgeLength。
// 编写构造函数，接受三个参数（三角形的三条边长），并将其分配给相应的属性。
// 实现一个方法 is_valid_triangle，用于判断这三条边是否能构成一个有效的三角形。
// 三角形的判断条件是：任意两边之和大于第三边，且任意两边之差小于第三边。（注意，这里的任意是指必须都满足“每个两边”）
// 创建一个三角形对象，设置其三条边分别为3、4和5，然后调用 is_valid_triangle 方法并输出结果。
// 写好之后可以再修改一下，改成从控制台询问用户输入数字，以此进行判断

internal static class Program
{
    [SuppressMessage("Performance", "CA1806:不要忽略方法结果")]
    internal static int Main()
    {
        Console.WriteLine("Enter three number with triangle edge length (use comma spacing):");

        string input = Console.ReadLine() ?? string.Empty;
        string[] numbers = input.Split(',');

        if (numbers.Length != 3)
        {
            Console.WriteLine("Invalid Arguments.");

            return -1;
        }

        int.TryParse(numbers[0], out int num1);
        int.TryParse(numbers[1], out int num2);
        int.TryParse(numbers[2], out int num3);

        Triangle triangle = new(num1, num2, num3);
        string message = triangle.IsValidTriangle() ? "This is valid triangle" : "Not belong to triangle";

        Console.WriteLine(message);

        return 0;
    }
}
