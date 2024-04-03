// 题目： 创建一个泛型类 Box<T>，它可以存储任何类型的物品。这个类应该包含以下功能：
// 一个添加物品的方法 Add(T item)。
// 一个获取物品的方法 Get(T item)，如果物品存在则返回它，否则返回 default(T)。
// 一个检查盒子是否为空的属性 IsEmpty。
// 接下来，定义一个自定义类型 Toy，并使用 Box<Toy> 类来存储 Toy 对象。Toy 类应该有一个 Name 属性和一个 Play() 方法，该方法打印出玩具的名字和 “is being played with” 的信息。
namespace Source.Chapter17;

public class Toy
{
    private string name;
    
    public Toy(string toyName)
    {
        this.name = toyName;
    }

    public string Name
    {
        get => name;
        set => name = (value);
    }

    public string Play()
    {
        return $"{name} is being played with";
    }
}
