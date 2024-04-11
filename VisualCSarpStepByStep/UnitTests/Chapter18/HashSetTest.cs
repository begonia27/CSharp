using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices.JavaScript;

namespace UnitTests.Chapter18;

[TestClass]
public class HashSetTests
{
    private HashSet<string> employees = [];
    private HashSet<string> customers = [];
    
    [TestInitialize]
    public void TestInitialize()
    {
        employees = ["Fred", "Bert", "Harry", "John"];
        customers = ["John", "Sid", "Harry", "Diana"];
        
        employees.Add("James");
        customers.Add("Francesca");
    }
    
    [TestMethod]
    public void HashSetBothTestOne()
    {
        List<string> bothExpected = ["Harry", "John"];
        List<string> both = [];

        foreach (string name in employees)
        {
            if (customers.Contains(name))
            {
                both.Add(name);
            }
        }

        CollectionAssert.AreEqual(bothExpected, both);
    }

    [TestMethod]
    public void HashSetBothTestTwo()
    {
        List<string> bothExpected = ["John", "Harry"];
        List<string> both = [];
        
        customers.IntersectWith(employees);

        foreach (string name in customers)
        {
            both.Add(name);
        }

        CollectionAssert.AreEqual(bothExpected, both);
    }

    [TestMethod]
    public void HashSetNotRepeatTestOne()
    {
        List<string> notRepeatExpected = ["Bert", "Diana", "Francesca", "Fred", "Harry", "James", "John", "Sid"];
        List<string> notRepeat = [];

        foreach (string name in employees)
        {
            if (customers.Contains(name))
            {
                customers.Remove(name);
            }
        }

        foreach (string name in employees)
        {
            customers.Add(name);
        }

        foreach (string value in customers)
        {
            notRepeat.Add(value);
        }

        SortedSet<string> sort = new SortedSet<string>(notRepeat);
        
        CollectionAssert.AreEqual(notRepeatExpected, sort);
    }

    [TestMethod]
    public void HashSetNotRepeatTestTwo()
    {
        List<string> notRepeatExpected = ["Bert", "Diana", "Francesca", "Fred", "Harry", "James", "John", "Sid"];
        List<string> notRepeat = [];

        customers.UnionWith(employees);

        foreach (string name in customers)
        {
            notRepeat.Add(name);
        }

        SortedSet<string> sorted = new SortedSet<string>(notRepeat);
        
        CollectionAssert.AreEqual(notRepeatExpected, sorted);
    }

    [TestMethod]
    public void HashSetOnlyTestOne()
    {
        List<string> onlyExpected = ["Diana", "Francesca", "Sid"];
        List<string> only = [];

        foreach (string name in employees)
        {
            if (customers.Contains(name))
            {
                customers.Remove(name);
            }
        }

        foreach (string value in customers)
        {
            only.Add(value);
        }

        SortedSet<string> sort = new SortedSet<string>(only);
        
        CollectionAssert.AreEqual(onlyExpected, sort);
    }

    [TestMethod]
    public void HashSetOnlyTestTwo()
    {
        List<string> onlyExpected = ["Diana", "Francesca", "Sid"];
        List<string> only = [];
        
        customers.ExceptWith(employees);

        foreach (string name in customers)
        {
            only.Add(name);
        }
        
        SortedSet<string> sorted = new SortedSet<string>(only);
        
        CollectionAssert.AreEqual(onlyExpected, sorted);
    }
    
    // use "class" substitute "collection":
    // class T
    // {
    //     private string First;
    //     private int Second;
    // }
    
    // KeyValuePair<string, int> v = new KeyValuePair<string, int>("abdf", 2);
    // Tuple<int, double, int, string, List<int>> v1 =
    //     new Tuple<int, double, int, string, List<int>>(1, 1.3, 4, "", new List<int>());
}
