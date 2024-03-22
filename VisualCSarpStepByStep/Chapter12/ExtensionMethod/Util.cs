using System;

namespace Extensions
{
    static class Util
    {
        public static int ConvertToBase(this int number, int baseToConvertTo)
        {
            if (baseToConvertTo < 2 || baseToConvertTo > 10)
            {
                throw new ArgumentException("Value cannot be converted to base " +
                                            baseToConvertTo.ToString());
            }

            int result = 0;
            int iterations = 0;

            do
            {
                int nextDigit = number % baseToConvertTo;
                number /= baseToConvertTo;
                result += nextDigit * (int)Math.Pow(10, iterations);
                iterations++;
            } while (number != 0);

            return result;
        }
    }
}
