using System.Collections;
using Source.Chapter20;

namespace UnitTests.Chapter20;

[TestClass]
public class FindInstanceTests
{
    [TestMethod]
    public void FindFamilyInfo()
    {
        List<Person> personnel =
        [
            new Person() { ID = 1, Name = "John", Age = 53 },
            new Person() { ID = 2, Name = "Sid", Age = 28 },
            new Person() { ID = 3, Name = "Fred", Age = 34 },
            new Person() { ID = 4, Name = "Paul", Age = 22 }
        ];

        double averageAge = personnel.Average(p => p.Age);
        double expectedAge = 34.25;

        int maxID = personnel.Max(p => p.ID);
        int expectedId = 4;

        int thirties = personnel.Count(p => p.Age >= 30 && p.Age <= 39);
        int expectedThitries = 1;
        
        Assert.AreEqual(expectedAge, averageAge);
        Assert.AreEqual(expectedId, maxID);
        Assert.AreEqual(expectedThitries, thirties);
    }
}
