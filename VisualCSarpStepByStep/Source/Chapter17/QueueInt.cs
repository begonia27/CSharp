namespace Source.Chapter17;

public class QueueInt
{
    private const int DEFAULTQUEUESIZE = 100;
    private int[] data;
    private int head = 0, tail = 0;
    private int numElements = 0;

    public QueueInt()
    {
        data = new int[DEFAULTQUEUESIZE];
    }

    public QueueInt(int size)
    {
        if (size > 0)
        {
            data = new int[size];
        }
        else
        {
            throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
        }
    }

    public void Enqueue(int item)
    {
        if (numElements == data.Length)
        {
            throw new Exception("Queue int full");
        }

        data[head] = item;
        head++;
        head %= data.Length;
        numElements++;
    }

    public int Dequeue()
    {
        if (numElements == 0)
        {
            throw new Exception("Queue int empty");
        }

        int queueItem = data[tail];
        tail++;
        tail %= data.Length;
        numElements--;
        return queueItem;
    }
}
