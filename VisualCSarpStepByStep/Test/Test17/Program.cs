using System.Reflection.Metadata.Ecma335;
namespace Test17;

struct MyWay
{
    static void Main(string[] args)
    {
        ScreenPosition origin = new ScreenPosition(21, 5);

        origin.XX = 96;
        origin.Y = 123;
        origin.Q = 67;
       
        Console.WriteLine($"a is {origin.XX}, b is {origin.Y}, c is {origin.Z}");
        Console.WriteLine($"e is {origin.W}");
        Console.WriteLine($"Result is {origin.F(3)}");
        
        // Inaccessible this variable, there is no initialization with "new":
        // ScreenPosition location;
        // location.XX = 40;
        // Console.WriteLine(location.XX);
        
        // 银行卡余额从外部只能读取不能修改
        // origin.Z = 35;
        
        // 密码从外部只能设置，不能读取
        // Console.WriteLine($"d is {origin.Q}");
    }
}
 
