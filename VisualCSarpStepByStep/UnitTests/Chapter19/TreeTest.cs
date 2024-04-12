using Source.Chapter17;

namespace UnitTests.Chapter19;

[TestClass]
public class TreeTests
{
    [TestMethod]
    public void TreeNumberTest()
    {
        Tree<int> tree1 = new Tree<int>(10);
        List<int> originNumbers = [5, 11, 5, -12, 15, 0, 14, -8, 10];
        List<int> valuesExpected = [-12, -8, 0, 5, 5, 10, 10, 11, 14, 15];
        
        foreach (int number in originNumbers)
        {
            tree1.Insert(number);
        }

        List<int> finalValues = tree1.WalkTree();
        
        CollectionAssert.AreEqual(valuesExpected, finalValues);
    }
    
    [TestMethod]
    public void TreeStringTest()
    {
        Tree<string> tree2 = new Tree<string>("Today");
        List<string> originValue = ["I", "Say", "Hello", "World"];
        List<string> valuesExpected = ["Hello", "I", "Say", "Today", "World"];
        
        foreach (string values in originValue)
        {
            tree2.Insert(values);
        }

        List<string> finalValues = tree2.WalkTree();
        
        CollectionAssert.AreEqual(valuesExpected, finalValues);
    }
}
