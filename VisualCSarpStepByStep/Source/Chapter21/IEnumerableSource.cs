using System.Collections;

namespace Source.Chapter21;

public class Person : IEnumerable
{
    public int CustomerID { set; get; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? CompanyName { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }

    public Person()
    {
        CustomerID = 0;
        FirstName = null;
        LastName = null;
        CompanyName = null;
        City = null;
        Country = null;
    }

    // public override bool Equals(object? obj)
    // {
    //     if (obj == null)
    //     {
    //         return false;
    //     }
    //     
    //     if (obj is People p)
    //     {
    //         return CompanyName == p.CompanyName && City == p.City && Country == p.Country;
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }

    // public static bool operator ==(People? leftHandSide, People? rightHandSide)
    // {
    //     if (leftHandSide is null && rightHandSide is null)
    //     {
    //         return true;
    //     }
    //
    //     if (leftHandSide is null || rightHandSide is null)
    //     {
    //         return false;
    //     }
    //
    //     return leftHandSide.CompanyName == rightHandSide.CompanyName &&
    //            leftHandSide.City == rightHandSide.City &&
    //            leftHandSide.Country == rightHandSide.Country;
    // }
    //
    // public static bool operator !=(People leftHandSide, People rightHandSide)
    // {
    //     return !(leftHandSide == rightHandSide);
    // }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
