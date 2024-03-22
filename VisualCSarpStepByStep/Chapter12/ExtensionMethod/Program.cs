using System.Xml.XPath;
using System;
using Extensions;

namespace ExtensionMethod
{
    class Program
    {
        static void DoWork()
        {
            int x = 591;
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"{x} in base {i} is {x.ConvertToBase(i)}");
            }
        }
    
        static void Main(string[] args)
        {
            try
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
