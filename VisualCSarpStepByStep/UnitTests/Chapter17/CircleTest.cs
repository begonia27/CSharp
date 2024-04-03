using Source.Chapter17;

namespace UnitTests.Chapter17;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void CircleTest()
    {
        Circle<int> areaOne = new Circle<int>(5);
        Circle<double> areaTwo = new Circle<double>(2.1);
        
        Assert.AreEqual(25, areaOne.Area());
        Assert.AreEqual(4.41, areaTwo.Area());
    }
}
