namespace Source.Chapter17;

public interface IAnimal<T>
{
    void SetData(T data);
    T GetData();
}

public class Horse<T> : IAnimal<T>
{
    private T storedData;

    void IAnimal<T>.SetData(T data)                                                                                                                                                                                                                                                                                                  
    {
        storedData = data;
    }

    T IAnimal<T>.GetData()
    {
        return storedData;
    }
}

public interface IStoreCat<T>
{
    void SetData(T data);
}

public interface IRetrieveCat<out T>
{
    T GetData();
}

public class Cat<T> : IStoreCat<T>, IRetrieveCat<T>
{
    private T someData;

    void IStoreCat<T>.SetData(T data)
    {
        someData = data;
    }

    T IRetrieveCat<T>.GetData()
    {
        return someData;
    }
}
