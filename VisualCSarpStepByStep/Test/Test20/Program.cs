using System.Collections;

namespace Test20;

class Program
{
    private uint binData = 0b01111;
    private uint moreBinData = 0b0_11110000_01010101_11001100_00001111;
    private uint hexData = 0x0_0F;
    
    static void Main(string[] args)
    {
        uint moreHexData = 0x0_F0_5A_CC_0F;
        uint testData = 0x0_FF_FF_FF_FF;
        
        Console.WriteLine($"{Convert.ToString(moreHexData, 2)}");
        Console.WriteLine($"{Convert.ToString(testData, 10)}");
        Console.WriteLine($"{Convert.ToString(testData, 2)}");
        
        int adapted = 0b0_01111110;
        IntBits bits = new IntBits(adapted);
        
        // 获取索引位置为 6 的 bool 值：true (1)
        bool peek = bits[6];
        bits[0] = true;
        bits[3] = false;
        Console.WriteLine($"{bits}");
    }
}
