namespace Test04
{
    class Program
    {
        static void doIncrement(ref int param)
        {
            param++;
        }
        
        static void doInitialize(out int param)
        {
            param = 33;
        }
        
        // static void doInitialize(out int arg)
        // {
        //     arg = 2;
        // }
        
        static void Main()
        {
            // int arg = 42;
            int arg;
            
            // ref 参数有出有进
            // out 参数只出不进
            // doIncrement(ref arg);
            doInitialize(out arg);
            
            Console.WriteLine(arg);
        }
    }
}
