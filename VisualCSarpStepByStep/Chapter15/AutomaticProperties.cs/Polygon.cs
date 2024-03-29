using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticProperties.cs;

public class Polygon
{
    public int NumSides { get; set; }
    public double SideLength { get; set; }

    public Polygon()
    {
        NumSides = 4;
        SideLength = 10.0;
    }
}
