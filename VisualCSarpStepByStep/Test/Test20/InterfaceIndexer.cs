namespace Test20;

interface IRawInt
{
    bool this [int index] { get; set; }
}

struct RawInt : IRawInt
{
    private int bits;
    
    public bool this[int index]
    {
        get => (bits & 1 << index) != 0;
        set
        {
            if (value)
            {
                bits |= (1 << index);
            }
            else
            {
                bits &= ~(1 << index);
            }
        }
    }

    // explicitly implement interface is not public and not virtual
    // so, it is do not allow be override
    bool IRawInt.this[int index]
    {
        get => (bits & 1 << index) != 0;
        set
        {
            if (value)
            {
                bits |= (1 << index);
            }
            else
            {
                bits &= ~(1 << index);
            }
        }
    }
}

interface Number
{
    bool this [int index] { get; set; }
}

class IntegerNumber : Number
{
    private int bits;

    public virtual bool this[int index]
    {
        get => (bits & 1 << index) != 0;
        set
        {
            if (value)
            {
                bits |= (1 << index);
            }
            else
            {
                bits &= ~(1 << index);
            }
        }
    }
}
