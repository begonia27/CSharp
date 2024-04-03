namespace Source.Chapter17;

public class QueueGenerics<T>
{
    private T[] data;
    private const int DEFAULTQUEUESIZE = 100;
    private int head = 0, tail = 0;
    private int numElements = 0;

    public QueueGenerics()
    {
        data = new T[DEFAULTQUEUESIZE];
    }

    public QueueGenerics(int size)
    {
        if (size > 0)
        {
            data = new T[DEFAULTQUEUESIZE];
        }
        else
        {
            throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
        }
    }

    public void Enqueue(T item)
    {
        if (numElements == data.Length)
        {
            throw new ArgumentException("Queue full");
        }

        data[head] = item;
        head++;
        head %= data.Length;
        numElements++;
    }

    public T Dequeue()
    {
        if (numElements == 0)
        {
            throw new Exception("Queue empty");
        }
        
        T queueItem = data[tail];
        tail++;
        tail %= data.Length;
        numElements--;
        return queueItem;
    }
}
