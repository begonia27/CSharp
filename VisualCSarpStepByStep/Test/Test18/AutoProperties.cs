using System.Runtime.InteropServices.JavaScript;

namespace Test18;

class Circle
{
    public int Radius { get; set; }
}

class CircleDateTime
{
    public CircleDateTime()
    {
        CircleCreatedDate = DateTime.Now;
    }
    
    public DateTime CircleCreatedDate { get; }
}

class CircleDate
{
    public DateTime CircleCreatedDate { get; } = DateTime.Now;
}
