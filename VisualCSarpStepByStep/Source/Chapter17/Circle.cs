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


















// 自定义类型
// public class Toy
// {
//     public string Name { get; set; }
//
//     public Toy(string name)
//     {
//         Name = name;
//     }
//
//     public void Play()
//     {
//         Console.WriteLine($"{Name} is being played with.");
//     }
// }
//
// // 泛型类
// public class Box<T>
// {
//     private List<T> items = new List<T>();
//
//     public void Add(T item)
//     {
//         items.Add(item);
//     }
//
//     public T Get(T item)
//     {
//         int index = items.IndexOf(item);
//         if (index != -1)
//         {
//             return items[index];
//         }
//         else
//         {
//             return default(T);
//         }
//     }
//
//     public bool IsEmpty
//     {
//         get { return items.Count == 0; }
//     }
// }
//
// // 主程序
// class Program
// {
//     static void Main()
//     {
//         // 创建一个玩具盒子
//         Box<Toy> toyBox = new Box<Toy>();
//
//         // 添加一些玩具
//         Toy teddyBear = new Toy("Teddy Bear");
//         Toy actionFigure = new Toy("Action Figure");
//         toyBox.Add(teddyBear);
//         toyBox.Add(actionFigure);
//
//         // 检查盒子是否为空
//         Console.WriteLine(toyBox.IsEmpty); // 输出: False
//
//         // 获取并玩耍一个玩具
//         Toy toyToPlay = toyBox.Get(teddyBear);
//         toyToPlay?.Play(); // 输出: Teddy Bear is being played with.
//     }
// }
