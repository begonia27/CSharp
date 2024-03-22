namespace Test12;

class Black
{
    public static void Hole(params object[]? paramList)
    {
        if (paramList == null)
        {
            return;
        }

        foreach (object i in paramList)
        {
            Console.WriteLine($"Param is {i}");
        }
    }
}
