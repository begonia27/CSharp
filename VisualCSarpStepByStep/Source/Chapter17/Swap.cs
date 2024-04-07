// 题目： 创建一个泛型方法 Swap，它能够交换两个相同类型的变量的值。这个方法应该能够适用于任何数据类型，包括整数、浮点数、字符串等。
//
// 要求：
// 方法应该是静态的。
// 方法应该接受两个引用参数 ref T First 和 ref T second。
// 方法执行后，First 和 second 变量的值应该互换。

namespace Source.Chapter17;

public class Swap<T>
{
    public T first { get; set; }
    public T second { get; set; }

    public Swap(T firstValue, T secondValue)
    {
        first = firstValue;
        second = secondValue;
    }

    // non-static method
    public void SwapValue()
    {
        T temp = first;
        first = second;
        second = temp;
    }
    
    // static method
    public static void SwapValue(ref T firstValue, ref T secondValue)
    {
        // T temp = firstValue;
        // firstValue = secondValue;
        // secondValue = temp;

        (firstValue, secondValue) = (secondValue, firstValue);
    }
}
