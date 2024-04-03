namespace Chapter17;

public class Queue
{
    private const int DEFAULTQUEUESIZE = 100;
    private int[] data;
    private int head = 0, tail = 0;
    private int numElements = 0;

    public Queue()
    {
        data = new int[DEFAULTQUEUESIZE];
    }

    public Queue(int size)
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
            throw new Exception("Queue full");
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
            throw new Exception("Queue empty");
        }

        int queueItem = data[this.tail];
        tail++;
        tail %= data.Length;
        numElements--;
        return queueItem;
    }
}
