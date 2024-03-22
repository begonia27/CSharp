namespace Test09
{
    public class Pass
    {
        public int X;

        public void Double()
        {
            X *= 2;
        }

        public static void Value(int param)
        {
            param = 66;
        }
    }

    public class Package
    {
        public int Number;
        
        public void Double()
        {
            Number *= 2;
        }
        
        public static void Method(Package param)
        {
            param.Number = 90;
            param = new Package();
        }
    }
}
