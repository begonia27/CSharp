using Source.Chapter17;

namespace UnitTests.Chapter17;

[TestClass]
public class QueueObjectTests
{
    [TestMethod]
    public void QueueObjectTest()
    {
        QueueObject queueObject = new QueueObject();
        
        queueObject.Enqueue(100);
        queueObject.Enqueue(-25);
        queueObject.Enqueue(33);
    
        Assert.AreEqual(100, queueObject.Dequeue());
        Assert.AreEqual(-25, queueObject.Dequeue());
        Assert.AreEqual(33, queueObject.Dequeue());
    }
}
