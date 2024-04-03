namespace Source.Chapter17;

public class QueueObject
{
    private const int DEFAULTQUEUESIZE = 100;
    private object[] data;
    private int head = 0, tail = 0;
    private int numElements = 0;

    public QueueObject()
    {
        data = new object[DEFAULTQUEUESIZE];
    }

    public QueueObject(int size)
    {
        if (size > 0)
        {
            data = new object[size];
        }
        else
        {
            throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
        }
    }

    public void Enqueue(object item)
    {
        if (numElements == data.Length)
        {
            throw new Exception("Queue object full");
        }

        data[head] = item;
        head++;
        head %= data.Length;
        numElements++;
    }

    public object Dequeue()
    {
        if (numElements == 0)
        {
            throw new Exception("Queue object empty");
        }

        Object queueItem = data[tail];
        tail++;
        tail %= data.Length;
        numElements--;
        return queueItem;
    }
}
