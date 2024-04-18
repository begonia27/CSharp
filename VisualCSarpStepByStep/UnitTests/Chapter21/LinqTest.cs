using Source.Chapter21;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Runtime.InteropServices.JavaScript;
using System.Linq;
using System.Security.Cryptography;

namespace UnitTests.Chapter21;

[TestClass]
public class LinqTests
{
    private List<People> _customersInfo = [];
    private List<People> _addressInfo = [];

    [TestInitialize]
    public void TestInitialize()
    {
        _customersInfo =
        [
            new People() { CustomerID = 1, FirstName = "Kim", LastName = "Abercrombie", CompanyName = "Alpine Ski House" },
            new People() { CustomerID = 2, FirstName = "Jeff", LastName = "Hay", CompanyName = "Coho Winery" },
            new People() { CustomerID = 3, FirstName = "Charlie", LastName = "Herb", CompanyName = "Alpine Ski House" },
            new People() { CustomerID = 4, FirstName = "Chris", LastName = "Preston", CompanyName = "Trey Research" },
            new People() { CustomerID = 5, FirstName = "Dave", LastName = "Barnett", CompanyName = "Wingtip Toys" },
            new People() { CustomerID = 6, FirstName = "Ann", LastName = "Beebe", CompanyName = "Coho Winery" },
            new People() { CustomerID = 7, FirstName = "John", LastName = "Kane", CompanyName = "Wingtip Toys" },
            new People() { CustomerID = 8, FirstName = "David", LastName = "Simpson", CompanyName = "Trey Research" },
            new People() { CustomerID = 9, FirstName = "Greg", LastName = "Chapman", CompanyName = "Wingtip Toys" },
            new People() { CustomerID = 10, FirstName = "Tim", LastName = "Litton", CompanyName = "Wide World Importers" }
        ];
        
        _addressInfo =
        [
            new People() { CompanyName = "Alpine Ski House", City = "Berne", Country = "Switzerland" },
            new People() { CompanyName = "Coho Winery", City = "San Francisco", Country = "United States" },
            new People() { CompanyName = "Trey Research", City = "New York", Country = "United States" },
            new People() { CompanyName = "Wingtip Toys", City = "London", Country = "United Kingdom" },
            new People() { CompanyName = "Wide World Importers", City = "Tetbury", Country = "United Kingdom" },
        ];
    }

    [TestMethod]
    public void FirstNameTest()
    {
        List<string> expected = ["Kim", "Jeff", "Charlie", "Chris", "Dave", "Ann", "John", "David", "Greg", "Tim"];
        List<string> actual = [];
        
        var customerFirstName = from cust in _customersInfo select cust.FirstName;

        actual.AddRange(customerFirstName);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void NamesTest()
    {
        List<People> expected =
        [
            new People() { FirstName = "Kim", LastName = "Abercrombie" },
            new People() { FirstName = "Jeff", LastName = "Hay" },
            new People() { FirstName = "Charlie", LastName = "Herb" },
            new People() { FirstName = "Chris", LastName = "Preston" },
            new People() { FirstName = "Dave", LastName = "Barnett" },
            new People() { FirstName = "Ann", LastName = "Beebe" },
            new People() { FirstName = "John", LastName = "Kane" },
            new People() { FirstName = "David", LastName = "Simpson" },
            new People() { FirstName = "Greg", LastName = "Chapman" },
            new People() { FirstName = "Tim", LastName = "Litton" }
        ];
        
        List<People> actual = [];
        
        var customerNames = from c in _customersInfo select new People(){ FirstName = c.FirstName, LastName = c.LastName };

        // // 73 行中 select 后面如果是匿名类型，可以用以下方法：
        // foreach (var name in customerNames)
        // {
        //     actual.Add(new People(){FirstName = name.FirstName, LastName = name.LastName});
        // }

        actual.AddRange(customerNames);
        Assert.AreEqual(expected.Count, actual.Count);

        for (int i = 0; i < expected.Count; ++i)
        {
            Assert.AreEqual(expected[i].FirstName, actual[i].FirstName);
        }
    }

    [TestMethod]
    public void CompaniesTest()
    {
        List<string> expected = ["Coho Winery", "Trey Research"];
        List<string> actual = [];
        
        var usCompanies = from a in _addressInfo
            where String.Equals(a.Country, "United States")
            select a.CompanyName;

        actual.AddRange(usCompanies);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CompaniesNamesTest()
    {
        List<string> expected = ["Alpine Ski House", "Coho Winery", "Trey Research", "Wide World Importers", "Wingtip Toys"];
        List<string> actual = [];

        var companyNames = from a in _addressInfo orderby a.CompanyName select a.CompanyName;

        actual.AddRange(companyNames);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GroupTest()
    {
        // expected result:
        // Country Switzerland have 1 companies: 
        //      Alpine Ski House
        // Country United States have 2 companies: 
        //      Coho Winery
        // Trey Research
        // Country United Kingdom have 2 companies: 
        //      Wingtip Toys
        //      Wide World Importers
        
        var companiesGroupedByCountry = from a in _addressInfo group a by a.Country;

        foreach (var companiesPerCountry in companiesGroupedByCountry)
        {
            Console.WriteLine($"Country {companiesPerCountry.Key} have {companiesPerCountry.Count()} companies");

            foreach (var companies in companiesPerCountry)
            {
                Console.WriteLine($"\t{companies.CompanyName}");
            }
        }
    }

    [TestMethod]
    public void CountTest()
    {
        int expected = 5;
        int numberOfCompanies = (from a in _addressInfo select a.CompanyName).Count();
        
        Assert.AreEqual(expected, numberOfCompanies);
    }

    [TestMethod]
    public void DistinctTest()
    {
        int expected = 3;
        int numberOfCompanies = (from a in _addressInfo select a.Country).Distinct().Count();
        
        Assert.AreEqual(expected, numberOfCompanies);
    }

    [TestMethod]
    public void NumberOfRowTest()
    {
        int expected = 10;
        int numberOfCompanies = _customersInfo.Count;
        
        Assert.AreEqual(expected, numberOfCompanies);
    }

    [TestMethod]
    public void JoinTest()
    {
        List<Person> expected =
        [
            new Person() { FirstName = "Kim", LastName = "Abercrombie", Country = "Switzerland" },
            new Person() { FirstName = "Jeff", LastName = "Hay", Country = "United States" },
            new Person() { FirstName = "Charlie", LastName = "Herb", Country = "Switzerland" },
            new Person() { FirstName = "Chris", LastName = "Preston", Country = "United States" },
            new Person() { FirstName = "Dave", LastName = "Barnett", Country = "United Kingdom" },
            new Person() { FirstName = "Ann", LastName = "Beebe", Country = "United States" },
            new Person() { FirstName = "John", LastName = "Kane", Country = "United Kingdom" },
            new Person() { FirstName = "David", LastName = "Simpson", Country = "United States" },
            new Person() { FirstName = "Greg", LastName = "Chapman", Country = "United Kingdom" },
            new Person() { FirstName = "Tim", LastName = "Litton", Country = "United Kingdom" },
        ];
        
        List<People> actual = [];
        
        // 千万不要写错了！！ 最后联结的数据里有 a 和 c 的值
        var citiesAndCustomers =
            from a in _addressInfo
            join c in _customersInfo
            on a.CompanyName equals c.CompanyName
            orderby c.CustomerID // 根据 _customersInfo 里的 CustomerID 进行升序排序
            select new People() { FirstName = c.FirstName, LastName = c.LastName, Country = a.Country };

        actual.AddRange(citiesAndCustomers);
        Assert.AreEqual(expected.Count, actual.Count);

        int length = expected.Count;

        for (int i = 0; i < length; ++i)
        {
            Assert.AreEqual(expected[i].FirstName, actual[i].FirstName);
            Assert.AreEqual(expected[i].LastName, actual[i].LastName);
            Assert.AreEqual(expected[i].Country, actual[i].Country);
        }
    }   
}
