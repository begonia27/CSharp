namespace Test17;

struct ScreenPosition
{
    private int _a;
    private int _b;

    private static int RangeCheckedX(int x)
    {
        if (x is < 0 or > 1279)
        {
            throw new ArgumentOutOfRangeException(nameof(x));
        }

        return x;
    }

    private static int RangeCheckedY(int y)
    {
        if (y is < 0 or > 1023)
        {
            throw new ArgumentOutOfRangeException(nameof(y));
        }

        return y;
    }

    public ScreenPosition(int x, int y)
    {
        this._a = RangeCheckedX(x);
        this._b = RangeCheckedY(y);
        
        Console.WriteLine(F(10));
    }

    public int XX
    {
        get => this._a;
        set => this._a = RangeCheckedX(value);
    }

    public int Y
    {
        get => this._b;
        set => this._b = RangeCheckedY(value);
    }

    public int Z
    {
        get => this._a;
    }

    public int Q
    {
        set => this._b = RangeCheckedY(value);
    }

    public int W
    {
        get => this._a;
        private set => this._a = RangeCheckedX(value);
    }

    // The accessibility modifier of the accessor must be more restrictive than the property 'Test17.ScreenPosition.E'
    // private int E
    // {
    //     get => this._a;
    //     public set => this._a = RangeCheckedX(value);
    // }

    public int F(int n)
    {
        return n >= 1 ? n * F(n - 1) : 1;
    }

    public int CC
    {
        get => this._a;
        set { }
    }

    public int DD { get; set; }
}
