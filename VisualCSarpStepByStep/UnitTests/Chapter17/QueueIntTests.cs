using Source.Chapter17;

namespace UnitTests.Chapter17;

[TestClass]
public class QueueIntTests
{
    [TestMethod]
    public void QueueIntTest()
    {
        QueueInt queueInt = new QueueInt();
        
        queueInt.Enqueue(100);
        queueInt.Enqueue(-25);
        queueInt.Enqueue(33);
    
        Assert.AreEqual(100, queueInt.Dequeue());
        Assert.AreEqual(-25, queueInt.Dequeue());
        Assert.AreEqual(33, queueInt.Dequeue());
    }
}
