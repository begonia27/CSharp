// 题目： 创建一个泛型类 Box<T>，它可以存储任何类型的物品。这个类应该包含以下功能：
// 一个添加物品的方法 Add(T item)。
// 一个获取物品的方法 Get(T item)，如果物品存在则返回它，否则返回 default(T)。
// 一个检查盒子是否为空的属性 IsEmpty。
// 接下来，定义一个自定义类型 Toy，并使用 Box<Toy> 类来存储 Toy 对象。Toy 类应该有一个 Name 属性和一个 Play() 方法，该方法打印出玩具的名字和 “is being played with” 的信息。

using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;
using Source.Chapter17;

namespace UnitTests.Chapter17;

[TestClass]
public class BoxTests
{
    [TestMethod]
    public void BoxTest()
    {
        Box<string> stringBox = new Box<string>(3);
        stringBox.Add("car");
        stringBox.Add("doll");
        
        Assert.AreEqual("car", stringBox.Get(0));
        Assert.AreEqual("doll", stringBox.Get(1));
    }
    
    [TestMethod]
    public void BoxToyTest()
    {
        Box<Toy> toyBox = new Box<Toy>(3);
        Toy one = new Toy("car");
        Toy two = new Toy("doll");

        toyBox.Add(new Toy("car"));
        toyBox.Add(two);
        
        Assert.AreEqual("car is being played with", toyBox.Get(0).Play());
        Assert.AreEqual("doll is being played with", toyBox.Get(1).Play());
    }
}
