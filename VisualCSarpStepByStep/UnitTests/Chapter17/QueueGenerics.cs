using Source.Chapter17;

namespace UnitTests.Chapter17;

[TestClass]
public class QueueGenericsTests
{
    [TestMethod]
    public void QueueGenericsTest()
    {
        QueueGenerics<int> intQueue = new QueueGenerics<int>();
    
        intQueue.Enqueue(99);
        
        Assert.AreEqual(99, intQueue.Dequeue());
    }
}
