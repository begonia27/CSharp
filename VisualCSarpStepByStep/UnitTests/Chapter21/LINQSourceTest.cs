using Source.Chapter21;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices.JavaScript;
using System.Linq;
namespace UnitTests.Chapter21;

[TestClass]
public class SearchTests
{
    private List<Person> _customersInfo = [];
    private List<string> _finallyFirstName = [];
    private List<string> _finallyLastName = [];
    private List<Person> _addressInfo = [];

    [TestInitialize]
    public void TestInitialize()
    {
        _customersInfo =
        [
            new Person()
                { CustomerID = 1, FirstName = "Kim", LastName = "Abercrombie", CompanyName = "Alpine Ski House" },
            new Person() { CustomerID = 2, FirstName = "Jeff", LastName = "Hay", CompanyName = "Coho Winery" },
            new Person() { CustomerID = 3, FirstName = "Charlie", LastName = "Herb", CompanyName = "Alpine Ski House" },
            new Person() { CustomerID = 4, FirstName = "Chris", LastName = "Preston", CompanyName = "Trey Research" },
            new Person() { CustomerID = 5, FirstName = "Dave", LastName = "Barnett", CompanyName = "Wingtip Toys" },
            new Person() { CustomerID = 6, FirstName = "Ann", LastName = "Beebe", CompanyName = "Coho Winery" },
            new Person() { CustomerID = 7, FirstName = "John", LastName = "Kane", CompanyName = "Wingtip Toys" },
            new Person() { CustomerID = 8, FirstName = "David", LastName = "Simpson", CompanyName = "Trey Research" },
            new Person() { CustomerID = 9, FirstName = "Greg", LastName = "Chapman", CompanyName = "Wingtip Toys" },
            new Person()
                { CustomerID = 10, FirstName = "Tim", LastName = "Litton", CompanyName = "Wide World Importers" }
        ];

        _addressInfo =
        [
            new Person() { CompanyName = "Alpine Ski House", City = "Berne", Country = "Switzerland" },
            new Person() { CompanyName = "Coho Winery", City = "San Francisco", Country = "United States" },
            new Person() { CompanyName = "Trey Research", City = "New York", Country = "United States" },
            new Person() { CompanyName = "Wingtip Toys", City = "London", Country = "United Kingdom" },
            new Person() { CompanyName = "Wide World Importers", City = "Tetbury", Country = "United Kingdom" },
        ];
    }

    [TestMethod]
    public void ChangeUseLinq()
    {
        Console.WriteLine(_customersInfo.Select(v => v.CustomerID));
        Console.WriteLine(from c in _customersInfo select c.CustomerID);

        Console.WriteLine(_customersInfo.Select(v => v.CustomerID).Where(v => v > 5));
        Console.WriteLine(from c in _customersInfo where c.CustomerID > 5 select c.CustomerID);

        Console.WriteLine(_customersInfo.Where(v => v.CustomerID < 5));
        Console.WriteLine(from c in _customersInfo where c.CustomerID < 5 select c);

        Console.WriteLine(_customersInfo.Select(v => new { CustomerId = v.CustomerID, v.FirstName }));
        Console.WriteLine(from c in _customersInfo select new { c.CustomerID, c.FirstName });

        Console.WriteLine(_customersInfo.Where(v => v.CustomerID > 5).Select(v => v.FirstName));
        Console.WriteLine(from c in _customersInfo where c.CustomerID > 5 select c.FirstName);
    }

    [TestMethod]
    public void CustomersInfo()
    {
        List<string> firstNameExpected =
            ["Kim", "Jeff", "Charlie", "Chris", "Dave", "Ann", "John", "David", "Greg", "Tim"];
        List<string> lastNameExpected =
            ["Abercrombie", "Hay", "Herb", "Preston", "Barnett", "Beebe", "Kane", "Simpson", "Chapman", "Litton"];

        IEnumerable<string> customerFirstNames = _customersInfo.Select(cust => cust.FirstName);
        IEnumerable<string> customerLastNames = _customersInfo.Select(cust => cust.LastName);

        foreach (string name in customerFirstNames)
        {
            _finallyFirstName.Add(name);
        }

        foreach (string name in customerLastNames)
        {
            _finallyLastName.Add(name);
        }

        CollectionAssert.AreEqual(firstNameExpected, _finallyFirstName);
        CollectionAssert.AreEqual(lastNameExpected, _finallyLastName);
    }

    [TestMethod]
    public void WhereTest()
    {
        List<string> companyExpected = ["Coho Winery", "Trey Research"];
        List<string> companyActual = [];
        IEnumerable<string?> usCompanies = _addressInfo.Where(addr => String.Equals(addr.Country, "United States"))
            .Select(usComp => usComp.CompanyName);

        foreach (string name in usCompanies)
        {
            companyActual.Add(name);
        }

        CollectionAssert.AreEqual(companyExpected, companyActual);
    }

    [TestMethod]
    public void OrderByTest()
    {
        List<string> orderByExpected =
            ["Alpine Ski House", "Coho Winery", "Trey Research", "Wide World Importers", "Wingtip Toys"];
        List<string> orderByDescendingExpected =
            ["Wingtip Toys", "Wide World Importers", "Trey Research", "Coho Winery", "Alpine Ski House"];
        List<string> companyNameAscendingActual = [];
        List<string> companyNameDescendingActual = [];

        // 升序
        IEnumerable<string?> ascendingOrder =
            _addressInfo.OrderBy(addr => addr.CompanyName).Select(comp => comp.CompanyName);

        // 降序
        IEnumerable<string?> descendingOrder =
            _addressInfo.OrderByDescending(addr => addr.CompanyName).Select(comp => comp.CompanyName);

        foreach (string value in ascendingOrder)
        {
            companyNameAscendingActual.Add(value);
        }

        foreach (string name in descendingOrder)
        {
            companyNameDescendingActual.Add(name);
        }

        CollectionAssert.AreEqual(orderByExpected, companyNameAscendingActual);
        CollectionAssert.AreEqual(orderByDescendingExpected, companyNameDescendingActual);
    }

    [TestMethod]
    public void ThenByTest()
    {
        List<string> thenByExpected = ["Berne", "London", "Tetbury", "New York", "San Francisco"];
        List<string> thenByActual = [];

        IEnumerable<String?> ascendingThenBy = _addressInfo.OrderBy(addr => addr.Country).ThenBy(addr => addr.City)
            .Select(city => city.City);

        foreach (string value in ascendingThenBy)
        {
            thenByActual.Add(value);
        }

        CollectionAssert.AreEqual(thenByExpected, thenByActual);
    }

    [TestMethod]
    public void ThenByCollectionTest()
    {
        List<Person> thenByCollectionExpected =
        [
            new Person() { CompanyName = "Alpine Ski House", City = "Berne", Country = "Switzerland" },
            new Person() { CompanyName = "Wingtip Toys", City = "London", Country = "United Kingdom" },
            new Person() { CompanyName = "Wide World Importers", City = "Tetbury", Country = "United Kingdom" },
            new Person() { CompanyName = "Trey Research", City = "New York", Country = "United States" },
            new Person() { CompanyName = "Coho Winery", City = "San Francisco", Country = "United States" },
        ];
        List<Person> thenByCollectionActual = [];

        IEnumerable<Person?> ascendingThenByCollection =
            _addressInfo.OrderBy(addr => addr.Country).ThenBy(addr => addr.City);
        
        var aaa =
            _addressInfo.OrderBy(addr => addr.Country).ThenBy(addr => addr.City).GroupBy(v => v.Country);

        foreach (var bbb in aaa)
        {
            Console.WriteLine("key: " + bbb.Key);
            foreach (var ccc in bbb)
            {
                Console.WriteLine("country: " + ccc.Country);
            }
        }

        foreach (Person info in ascendingThenByCollection)
        {
            thenByCollectionActual.Add(info);
        }

        // bool a = thenByCollectionExpected[0] == thenByCollectionActual[0];
        // Person x = new(), y = new();
        // x.Equals(y)
        // if (x == y)
        // {
        //     
        // }

        Assert.AreEqual(thenByCollectionExpected.Count, thenByCollectionActual.Count);
        
        var length = thenByCollectionActual.Count;
        for (var i = 0; i < length; ++i)
        {
            Assert.AreEqual(thenByCollectionExpected[i].City, thenByCollectionActual[i].City);
            Assert.AreEqual(thenByCollectionExpected[i].CompanyName, thenByCollectionActual[i].CompanyName);
            Assert.AreEqual(thenByCollectionExpected[i].Country, thenByCollectionActual[i].Country);
        }
        
        // CollectionAssert.AreEqual(thenByCollectionExpected, thenByCollectionActual);
    }

    [TestMethod]
    public void GroupBy()
    {
       // expected result:
       // Country Switzerland have 1 companies: 
       // Alpine Ski House
       //     Country United States have 2 companies: 
       // Coho Winery
       // Trey Research
       // Country United Kingdom have 2 companies: 
       // Wingtip Toys
       // Wide World Importers
        
        // var companiesCollection = _addressInfo.GroupBy(addrs => addrs.Country);
        IEnumerable<IGrouping<string?, Person>> companiesCollection = _addressInfo.GroupBy(addrs => addrs.Country);

        foreach (IGrouping<string?,Person> grouping in companiesCollection)
        {
            Console.WriteLine($"Country {grouping.Key} have {grouping.Count()} companies: ");

            foreach (Person name in grouping)
            {
                Console.WriteLine(name.CompanyName);
            }
        }
    }
}
