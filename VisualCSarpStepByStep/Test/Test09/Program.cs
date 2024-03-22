using System;
using System.Collections;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using Test08;

namespace Test09;
    
class Program
{
    // int[] pins;

    // creat a type of struct array element
    // Date[] dates;

    // static int size = int.Parse(Console.ReadLine());
    // int[] pins = new int[size];

    // int[] pins = new int[4] {9, 3, 7, 2};

    static void StructArray()
    {
        Time[] schedule = [new Time(12, 56), new Time(5, 30)];
        Console.WriteLine($"One schedule is {schedule[0].Hours()}:{schedule[0].Minutes()}:{schedule[0].Seconds()}");
        Console.WriteLine($"Other schedule is {schedule[1].Hours()}:{schedule[1].Minutes()}:{schedule[1].Seconds()}");
    }

    static void ArrayRandom()
    {
        Random r = new Random();
        int[] arrayValues = new int[4]
        {
            r.Next() % 10, r.Next() % 10,
            r.Next() % 10, r.Next() % 10
        };

        Console.WriteLine(arrayValues[0]);
        Console.WriteLine(arrayValues[1]);
        Console.WriteLine(arrayValues[2]);
        Console.WriteLine(arrayValues[3]);
    }

    static void ArrayIgnore()
    {
        int[] numbers = [4, 5, 3, 9];
        Console.WriteLine(numbers[2]);
    }

    static void ImplicitType()
    {
        var name = new[]
        {
            new {Name = "John", Age = 57},
            new {Name = "Diana", Age = 57},
            new {Name = "James", Age = 30},
            new {Name = "Francesca", Age = 26}
        };

        Console.WriteLine(name[0]);
        Console.WriteLine(name[1]);
        Console.WriteLine(name[2]);
        Console.WriteLine(name[3]);

        var names = name[0..4];
        Console.WriteLine($"Consecutive array is {names[1]}");

        /*
         * namesOther 索引从 4 - 3 开始，到 4 - 1 结束，但是不包含索引 4 - 1 ，因此只能打印两个元素的值
         * 但是由于 name[1] 和 name[2] 赋值给 namesOther 时，索引从 0 开始计算，因此输出 namesOther 里的值时，
         * 只能输出 namesOther[0] 和 namesOther[1] 的值
         */
        var namesOther = name[^3..^1];
        Console.WriteLine($"NamesOther is {namesOther[0]}");
        Console.WriteLine($"NamesOther is {namesOther[1]}");

        foreach (var familyMember in name)
        {
            Console.WriteLine($"Name: {familyMember.Name}, Age: {familyMember.Age}");
        }
    }

    static void AccessElement()
    {
        int[] pins = [88, 99, 55];

        int myPin = pins[2];
        Console.WriteLine($"My pin is {myPin}");

        myPin = 1645;
        pins[2] = myPin;
        Console.WriteLine($"Pins is {pins[2]}");
    }

    static void CheckRangeOfArray()
    {
        try
        {
            int[] arrays = [11, 22, 33, 44];
            Console.WriteLine(arrays[4]);
        }
        catch (IndexOutOfRangeException ex)
        {
            // Console.WriteLine("your array's out of range");
            Console.WriteLine(ex.Message);
        }
    }

    static void TraversalArray()
    {
        int[] someNumber = [1, 3, 5, 7, 9];

        // for (int index = 0; index < someNumber.Length; index++)
        // {
        //     int number = someNumber[index];
        //     Console.WriteLine(number);
        // }

        foreach (int number in someNumber)
        {
            Console.WriteLine(number);
        }
    }

    public static void ArrayParameter(int[] data)
    {
        int multiplier = 2;

        // （如果原始的值不再使用）可以使用数组变量 data 存储计算后的新值
        data = Array.ConvertAll(data, x => x * multiplier);

        foreach (int i in data)
        {
            Console.WriteLine($"data number is {i}");
        }
    }

    public static int[] ReadData()
    {
        Console.WriteLine("How many elements?");
        string? reply = null;
        int numElements = int.Parse(reply ?? "0");

        int[] data = new int[numElements];
        for (int i = 0; i < numElements; i++)
        {
            Console.WriteLine($"Enter data for element {i}");
            reply = Console.ReadLine();
            int elementData = int.Parse(reply);
            data[i] = elementData;
        }

        return data;
    }

    static void WriteData()
    {
        int[] aNumber = ReadData();
    
        foreach (var values in aNumber)
        {
            Console.WriteLine($"Values is {values}");
        }
    }

    static void ArrayForCopy()
    {
        int[] pins = [9, 3, 1];
        int[] copy = new int[pins.Length];
        
        // plan one:
        for (int i = 0; i < copy.Length; i++)
        {
            copy[i] = pins[i];
            Console.WriteLine(copy[i]);
        }
        
        // plan two: use "CopyTo"
        pins.CopyTo(copy, 0);
        foreach (int a in copy)
        {
            Console.WriteLine(a);
        }
      
        // plan three: use "Copy"
        Array.Copy(pins, copy, copy.Length);
        foreach (int b in copy)
        {
            Console.WriteLine(b);
        }
        
        // plan four: use "Clone"
        int[] copyValue = (int[])pins.Clone();
        foreach (int c in copyValue) 
        {
            Console.WriteLine(c);
        }
    }

    static void CheckCopyFrom()
    {
        int i = 8;
        Console.WriteLine(i);

        Pass.Value(i);
        Console.WriteLine(i);

        Package a = new Package();
        Console.WriteLine(a.Number);
        
        Package.Method(a);
        Console.WriteLine(a.Number);
        
        a.Double();
        Console.WriteLine($"a.Number is {a.Number}");
    }

    static void TwoDimensionalArray()
    {
        int[, ] items = new int[4, 6];
        items[2, 3] = 99;
        items[2, 4] = items[2, 3];
        items[2, 4]++;
        Console.WriteLine(items[2, 3]);
        Console.WriteLine(items[2, 4]);
    }
    
    static void MultidimensionalArray()
    {
        int[, ,] cube = new int[5, 5, 5];
        cube[1, 2, 1] = 101;
        cube[1, 2, 1] = cube[1, 2, 1] * 3;
        Console.WriteLine(cube[1, 2, 1]);
    }

    static void Interlace()
    {
        // 3 + 10 + 4 + 2, 共 19 个值
        int[][] items = new int[4][];
        
        int[] columnForRow0 = new int[3];
        int[] columnForRow1 = new int[10];
        int[] columnForRow2 = new int[4];
        int[] columnForRow3 = new int[2];
        
        items[0] = columnForRow0; 
        items[1] = columnForRow1;
        items[2] = columnForRow2;
        items[3] = columnForRow3;

        items[0][0] = 1;
        items[0][1] = 1;
        items[0][2] = 1;
        
        items[1][0] = 22;
        items[1][1] = 22;
        items[1][2] = 22;
        items[1][3] = 22;
        items[1][4] = 22;
        items[1][5] = 22;
        items[1][6] = 22;
        items[1][7] = 22;
        items[1][8] = 22;
        items[1][9] = 22;

        items[2][0] = 333;
        items[2][1] = 333;
        items[2][2] = 333;
        items[2][3] = 333;

        items[3][0] = 4444;
        items[3][1] = 4444;
        
        // Console.WriteLine(items[0][0]);
        // Console.WriteLine(items[0][1]);
        // Console.WriteLine(items[0][2]);
        //
        // Console.WriteLine(items[1][0]);
        // Console.WriteLine(items[1][1]);
        // Console.WriteLine(items[1][2]);
        // Console.WriteLine(items[1][3]);
        // Console.WriteLine(items[1][4]);
        // Console.WriteLine(items[1][5]);
        // Console.WriteLine(items[1][6]);
        // Console.WriteLine(items[1][7]);
        // Console.WriteLine(items[1][8]);
        // Console.WriteLine(items[1][9]);
        //
        // Console.WriteLine(items[2][0]);
        // Console.WriteLine(items[2][1]);
        // Console.WriteLine(items[2][2]);
        // Console.WriteLine(items[2][3]);
        //
        // Console.WriteLine(items[3][0]);
        // Console.WriteLine(items[3][1]);

        // 使用 foreach 输出每一个值（有几个 foreach 就代表几维数组）
        // 每一维数组 （共 2 维）
        foreach (int[] item in items)
        {
            // 每一维数组里的每一个值
            foreach (int i in item)
            {
                Console.WriteLine(i);
            }
        }

        // 初始化为 5 行（没有值）
        int[][] addItems = new int[5][];
        
        // 初始化为 2 列（没有值）
        int[] columnWithRow = new int[2];
        
        // 把第 2 列里的值全部添加到第一行里
        addItems[0] = columnWithRow;
        
        // 以下代表第一行第一列和第一行第二列
        // addItems[0][0]
        // addItems[0][1]
    }
    
    static void Main(string[] args)
    {
        // StructArray();
        // ArrayRandom();
        // ArrayIgnore();
        // ImplicitType();
        // AccessElement();
        // CheckRangeOfArray();
        // TraversalArray();
        // ArrayParameter(new int[]{1, 2, 3, 4, 5}); // 传递数组类型的值
        // // ArrayParameter([1, 2, 3, 4, 5]); 这种传递数组类型的值的写法是 C#12 的新语法
        // WriteData();
        // ArrayForCopy();
        // CheckCopyFrom();
        // TwoDimensionalArray();
        // MultidimensionalArray();
        Interlace();
    }
}
