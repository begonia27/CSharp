namespace Source.Chapter17;

public interface IComparer<in T>
{
    int Compare(T x, T y);
}
public class ObjectComparer : IComparable<Object>, IComparable<ObjectComparer>, IComparable, IComparer<object>
{
    int IComparer<Object>.Compare(Object x, Object y)
    {
        int xHash = x.GetHashCode();
        int yHash = y.GetHashCode();
        if (xHash == yHash)
        {
            return 0;
        }
        else if (xHash < yHash)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }

    public int CompareTo(ObjectComparer? other)
    {
        throw new NotImplementedException();
    }

    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        if (ReferenceEquals(this, obj)) return 0;
        return obj is ObjectComparer other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(ObjectComparer)}");
    }
}
