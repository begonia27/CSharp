using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Point
    {
        public int _x;
        public int _y;
        public static int _objectCount;
        public static int ObjectCount() => _objectCount;
        // public Point()
        // {
        //     _x = -1;
        //     _y = -1;
        //     _objectCount++;
        // }
        //
        // public Point(int x, int y)
        // {
        //     _x = x;
        //     _y = y;
        //     _objectCount++;
        // }

        public double DistanceTo(Point other)
        {
            int xDiff = _x - other._x;
            int yDiff = _y - other._y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));

            return distance;
        }
    }
}
