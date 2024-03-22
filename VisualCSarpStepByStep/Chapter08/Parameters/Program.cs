using System;
using System.Linq.Expressions;

namespace Parameters
{
    class Program
    {
        static void Dowork()
        {
            int i = 0;
            Console.WriteLine(i);
            Pass.Value(ref i);
            Console.WriteLine(i);

            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
        }

        static void Main(string[] args)
        {
            try
            {
                Dowork();
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
