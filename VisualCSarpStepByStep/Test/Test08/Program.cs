using Test08;

Season colorful = Season.Fall;
Season colorDay = Season.Summer;
Season? useNullVar = null;

Console.WriteLine(colorful);
Console.WriteLine(colorDay);
Console.WriteLine(useNullVar);

string name = colorful.ToString();
Console.WriteLine(name);

Console.WriteLine((int)(Season.Spring));
Console.WriteLine((int)(Season.Summer));
Console.WriteLine((int)(Season.Fall));
Console.WriteLine((int)(Season.Winter));

SeasonOther ways = SeasonOther.Autumn;
Console.WriteLine(ways);
Console.WriteLine((int)ways);

static void Main(string[] args)
{
        
}

Time now = new Time(12, 30);
Console.WriteLine($"This time is {now.Hours()}:{now.Minutes()}:{(now.Seconds())}");

Time other = new Time(25, 66, 155);
Console.WriteLine($"This time is {other.Hours()}:{other.Minutes()}:{(other.Seconds())}");

enum SeasonOther {Spring, Summer, Fall, Autumn = Fall, Winter}
enum SeasonSave :short {Spring, Summer, Fall, Winter}

namespace Test08
{ 
    enum Season{Spring = 1, Summer, Fall, Winter}

    class Example
    {
        // use a type of enumeration's parameter
        public void Method(Season parameter)
        {
            Season localVariable;
        }
        
        // defined a type of enumeration's variable
        private Season currentSeason;
    }
}
