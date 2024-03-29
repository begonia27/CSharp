using System.Collections;
using System.Data.SqlTypes;
using Test20;

namespace Test20
{
    struct IntBits
    {
        public int bits;

        public IntBits(int initialBitValue) => bits = initialBitValue;

        public override string ToString()
        {
            return (Convert.ToString(bits, 2));
        }
        
        public bool this[int index]
        {
            get => (bits & (1 << index)) != 0;
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
}

/*
 * 当我们想要将一个数的特定位置设置为 1 时，我们会使用按位或运算
 * 这个运算会比较两个数的每一位，如果任一数的该位为 1 ，则结果的该位也为 1
 * 在这里，1 << index 创建了一个只在 index 位置上有 1 的数，其他位都是 0
 * 这样，当我们对 bits 使用 | 运算时，只有 index 位可能改变，如果它原来是 0, 它会变成 1 ，其他位保持不变
 *
 * 当我们想要将一个数的特定位置设置为 0 时，我们会使用 & ~ 这两个运算符
 * 首先，1 << index 操作和之前一样，创建一个只在 index 位置上有一个 1 的数
 * 然后 ~ 运算符会取反这个数，即 index 位变为 0 ，其他位变为 1
 * 最后使用 & 运算符，bits 中的 index 位与 0 进行 AND 运算
 * 导致该位变为 0，而其他位由于与 1 进行 AND 运算，所以保持原值
 * 这些操作允许我们在不影响整数中的其他位的情况下，单独修改一个值
 */
