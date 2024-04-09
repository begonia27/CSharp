namespace UnitTests.Chapter17;
using Source.Chapter17;

[TestClass]
public class ContravarianceTests
{
    [TestMethod]
    public void Contravariance()
    {
        Object x = 1;
        Object y = 4;

        ObjectComparer objectComparer = new ObjectComparer();
        IComparer<Object> objectComparator = objectComparer;
        int result = objectComparator.Compare(x, y);

        Assert.AreEqual(-1,result);
    }
}
