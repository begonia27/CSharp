namespace UnitTests.Chapter22;

[TestClass]
public class TestOnly
{
    class Hour
    {
        public int Value;
        
        public static Hour operator ++(Hour hour)
        {
            hour.Value++;
            
            return hour;

            // return new Hour() { Value = hour.Value + 1 };
        }
    }
    [TestMethod]
    public void T()
    {
        // Hour h = new Hour();
        //
        // h.Value++;
        //
        // Console.WriteLine(h.Value);
        //
        // h++;
        //
        // Console.WriteLine(h.Value);

        Hour prefix = new Hour();
        Hour postfix = prefix;

        postfix = prefix;
        prefix++;
        
        Console.WriteLine(prefix.Value);
        Console.WriteLine(postfix.Value);

        prefix = ++postfix;
        
        Console.WriteLine(prefix.Value);
        Console.WriteLine(postfix.Value);
    }
}
