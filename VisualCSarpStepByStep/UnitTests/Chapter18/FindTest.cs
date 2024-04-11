using System.Text.RegularExpressions;
using Source.Chapter18;
namespace UnitTests.Chapter18;

[TestClass]
public class FindTests
{
    [TestMethod]
    public void FindTest()
    {
        List<Person> personnel =
        [
            new Person() { ID = 1, Name = "John", Age = 53 },
            new Person() { ID = 2, Name = "Sid", Age = 28 },
            new Person() { ID = 3, Name = "Fred", Age = 34 },
            new Person() { ID = 4, Name = "Paul", Age = 22 },
        ];
        
        // Person match = personnel.Find((Person p) => { return p.ID == 3;});
        Person match = personnel.Find((p) => p.ID == 3);

        // string expected = $"ID: {match.ID}\n, Name: {match.Name}\n, Age: {match.Age}";

        Person expected = new Person {ID = 3, Name = "Fred", Age = 34};
        
        Console.WriteLine($"{expected.Equals(match)}");
        Console.WriteLine($"{expected == match}");
        Assert.AreEqual(expected, match);
    }
}
