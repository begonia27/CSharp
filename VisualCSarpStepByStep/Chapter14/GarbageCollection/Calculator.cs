 using GarbageCollection;

public class Calculator: IDisposable
{
    private bool _disposed = false;

    public Calculator()
    {
        Console.WriteLine("Calculator being created");
    }
    
    public int Divide(int first, int second)
    {
        return first / second;
    }

    ~Calculator()
    {
        // 根据不同的情况采取不同的方法来释放资源
        Console.WriteLine("Calculator being finalized");
        this.Dispose();
    }
    
    public void Dispose()
    {
        // 一开始是 false ，取反后执行 if 判断里的语句
        if (!_disposed)
        {
            Console.WriteLine("Calculator being disposed");
        }

        // 执行结束后，状态改为 true ，就不会再执行 if 语句了
        this._disposed = true;
        GC.SuppressFinalize(this); // 不要对指定对象执行终止操作，即阻止终结器运行
        
        // 在 C# 中，this 关键字指的是类的当前实例
    }
}
