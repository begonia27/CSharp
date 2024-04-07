using Source.Chapter17;

namespace UnitTests.Chapter17;

[TestClass]
public class BinaryTreeTests
{
    [TestMethod]
    public void BinaryTreeTest()
    {
        Tree<int> tree1 = new Tree<int>(10);

        List<int> values = [-12, -8, 0, 5, 5, 8, 8, 10, 11, 14, 15];

        foreach (int value in values)
        {
            tree1.Insert(value);
        }

        List<int> sortedData = tree1.WalkTree();
        string expectedData = "-12 -8 0 5 5 8 8 10 10 11 14 15";
        
        Assert.AreEqual(expectedData, String.Join(" ", sortedData.Select(n => n.ToString())));
    }
}
