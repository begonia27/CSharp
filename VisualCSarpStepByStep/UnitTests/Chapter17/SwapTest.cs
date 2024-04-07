using Source.Chapter17;

namespace UnitTests.Chapter17;

[TestClass]
public class SwapTests
{
    [TestMethod]
    public void SwapIntTest()
    {
        int firstIntValue = 5;
        int secondIntValue = 3;
        
        Swap<int>.SwapValue(ref firstIntValue, ref secondIntValue);
        
        Assert.AreEqual(3, firstIntValue);
        Assert.AreEqual(5, secondIntValue);
        
        Swap<int>.SwapValue(ref firstIntValue, ref secondIntValue);
        
        Assert.AreEqual(5, firstIntValue);
        Assert.AreEqual(3, secondIntValue);
        
        Swap<int> intSwap = new Swap<int>(firstIntValue, secondIntValue);
        
        intSwap.SwapValue();
        
        Assert.AreEqual(firstIntValue, intSwap.second);
        Assert.AreEqual(secondIntValue, intSwap.first);
        
        intSwap.SwapValue();
        
        Assert.AreEqual(firstIntValue, intSwap.first);
        Assert.AreEqual(secondIntValue, intSwap.second);
    }

    [TestMethod]
    public void SwapDoubleTest()
    {
        double firstDoubleValue = 2.1;
        double secondDoubleValue = 9.3;
        Swap<double>.SwapValue(ref firstDoubleValue, ref secondDoubleValue);
     
        Assert.AreEqual(9.3, firstDoubleValue);
        Assert.AreEqual(2.1, secondDoubleValue);
    }
    
    [TestMethod]
    public void SwapStringTest()
    {
        string firstStringValue = "school";
        string secondStringValue = "exchange";
        Swap<string>.SwapValue(ref firstStringValue, ref secondStringValue);
        
        Assert.AreEqual("exchange", firstStringValue);
        Assert.AreEqual("school", secondStringValue);
    }
}
