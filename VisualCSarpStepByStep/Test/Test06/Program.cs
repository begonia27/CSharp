namespace Test06;

class Program
{
    static void UseIsConversionType()
    {
        WrappedInt wi = new WrappedInt();

        object o = wi;

        if (o is WrappedInt)
        {
            WrappedInt temp = (WrappedInt) o;
            Console.WriteLine("O is a WrappedInt type");
        }

        // if (o is WrappedInt temp)
        // {
        //     // use temp
        // }
    }

    static void UseAsConversionType()
    {
        WrappedInt wi = new WrappedInt();
        object o = wi;
        WrappedInt temp = o as WrappedInt;
        if (temp != null)
        {
            Console.WriteLine("Conversion type is successful");
        }
    }
    
    static void Main(string[] args)
    {
        UseIsConversionType();
        UseAsConversionType();
    }
}
