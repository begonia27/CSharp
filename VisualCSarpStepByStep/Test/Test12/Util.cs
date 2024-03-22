using Microsoft.VisualBasic;

namespace Test12;

class Util
{
    public static int Min(params int[] paramList)
    {
        if (paramList == null || paramList.Length == 0)
        {
            throw new ArgumentException("Util.Min: 实参数量不足");
        }

        int currentMin = paramList[0];

        foreach (int i in paramList)
        {
            if (i < currentMin)
            {
                currentMin = i;
            }
        }

        return currentMin;
    }

    static void OptionOne()
    {
        int[] array = new int[3];
        const int first = 7;
        const int second = 4;
        const int third = 2;

        array[0] = first;
        array[1] = second;
        array[2] = third;
        
        int min = Util.Min(array);
        Console.WriteLine($"Min value is {min}");
    }
    
    static void OptionTwo()
    {
        int min = Util.Min([17, 24, 32, 13, 3, 15]);
        Console.WriteLine($"Min value is {min}");
    }

    static void DiffParam()
    {
        object[] array = new object[3];
        array[0] = "forty two";
        array[1] = 42;
        array[2] = 'd';

        foreach (object i in array)
        {
            Console.WriteLine($"Param is {i}");
        }
    }
    
    static void Main(string[] args)
    {
        // OptionOne();
        // OptionTwo();
        // Black.Hole();
        // Black.Hole(null);
        DiffParam();
        Black.Hole("forty two", 42, 'a', 11.02);
    }
}
