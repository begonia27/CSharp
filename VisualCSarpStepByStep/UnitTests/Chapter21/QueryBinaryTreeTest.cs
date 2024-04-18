using System.Data.Common;
using System.Linq;
using System.Text.RegularExpressions;
using Source.Chapter21;
using BinaryTree;
namespace UnitTests.Chapter21;

[TestClass]
public class TreeTests
{
    [TestMethod]
    public void QueryBinaryTree()
    {
        Tree<Employee> empTree = new Tree<Employee>(new Employee
                    {
                        ID = 1, 
                        FirstName = "Kim", 
                        LastName = "Abercrobie", 
                        Department = "IT"
                    });
                    empTree.Insert(new Employee()
                    {
                        ID = 2, 
                        FirstName = "Jeff", 
                        LastName = "Hay", 
                        Department = "Marketing"
                    });
                    empTree.Insert(new Employee()
                    {
                        ID = 4, 
                        FirstName = "Charlie", 
                        LastName = "Herb", 
                        Department = "IT"
                    });
                    empTree.Insert(new Employee()
                    {
                        ID = 6, 
                        FirstName = "Chris", 
                        LastName = "Preston", 
                        Department = "Sales"
                    });
                    empTree.Insert(new Employee()
                    {
                        ID = 3, 
                        FirstName = "Dave", 
                        LastName = "Barnett", 
                        Department = "Sales"
                    });
                    empTree.Insert(new Employee()
                    {
                        ID = 5, 
                        FirstName = "Tim", 
                        LastName = "Litton", 
                        Department = "Marketing"
                    });
       
        // Console.WriteLine("List of departments");
        // // var depts = empTree.Select(d => d.Department).Distinct();
        // var depts = (from d in empTree select d.Department).Distinct();
        //
        //
        // foreach (var dept in depts)
        // {
        //     Console.WriteLine($"Department: {dept}");
        // }
        //
        // Console.WriteLine();
        // Console.WriteLine("Employees in the IT department");
        // // var ITEmployees =
        // //         empTree.Where(e => String.Equals(e.Department, "IT"))
        // //     .Select(emp => emp);
        //
        // var ITEmployees = from e in empTree 
        //     where String.Equals(e.Department, "IT") 
        //     select e;
        //
        // foreach (var emp in ITEmployees)
        // {
        //     Console.WriteLine(emp);
        // }
        //
        // Console.WriteLine();
        // Console.WriteLine($"All employees grouped by department");
        // // var employeesByDept = empTree.GroupBy(e => e.Department);
        // var employeesByDept = from a in empTree group a by a.Department;
        //
        // foreach (var dept in employeesByDept)
        // {
        //     Console.WriteLine($"Department {dept.Key}");
        //
        //     foreach (var emp in dept)
        //     {
        //         Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
        //     }
        // }
        
        // 使用集合的缓存拷贝，不会推迟求值
        Console.WriteLine("All employees");
        var allEmployees = from e in empTree.ToList<Employee>()select e;

        foreach (var emp in allEmployees)
        {
            Console.WriteLine(emp);
        }
        
        empTree.Insert(new Employee()
            {
                ID = 7,
                FirstName = "David",
                LastName = "Simpson",
                Department = "IT"
            }
        );
        
        Console.WriteLine();
        Console.WriteLine("Employee added");
        
        Console.WriteLine("All employees");
        foreach (var emp in allEmployees)
        {
            Console.WriteLine(emp);
        }
    }
}
