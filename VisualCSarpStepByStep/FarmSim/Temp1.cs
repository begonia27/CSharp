// namespace FarmSim;
//
// class Program
// {
//
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello, World!");
//         
//         // // Type name = Initialize;
//         //
//         // // primitive
//         // int i1 = 0;
//         // double d1 = 0;
//         //
//         // i1 = 4;
//         //
//         // if (true)
//         // {
//         //     int i2;
//         // }
//         //
//         // Console.WriteLine(i1);
//         //
//         // // reference
//         // // Type name = new Type();
//         // // Type name = new Type(params, ...);
//         // // name = new Type();
//         // // name = other;
//         //
//         // Temp1 t1 = new Temp1();
//         // Temp1 t2 = new Temp1();
//         //
//         // t1 = t2;
//         // t1 = new Temp1();
//         //
//         // // stack
//         // // 0xffff0000 i1; -> 00000000000000000000000000000100
//         // // 0xffff0004 d1; -> 
//         // // 0xffff000c i2;
//         // // 0xffff0010 t1; -> 0x00ff0000 -> 0x00ff1000 -> 0x00ff2000
//         // // 0xffff0018 t2; -> 0x00ff1000
//         // t1.y1 = 3;
//         //
//         // // heap
//         // // 0x00ff0000 -> 0x00ff0fff t1;
//         // // 0x00ff1000 -> 0x00ff1fff t2;
//         // // 0x00ff2000 -> 0x00ff2fff t1.1;
//
//         Point point1 = new Point();
//         Point point2 = new Point();
//
//         point1.x = 123;
//         point1.y = 333;
//
//         point1.Length();
//         point2.Length();
//         point1.Length();
//         point1.DistanceTo(point2);
//         point2.DistanceTo(point1);
//     }
// }
//
// class Point
// {
//     public int x;
//     public int y;
//         
//     public double Length()
//     {
//         return Math.Sqrt(x * this.x + this.y * this.y);
//     }
//     
//     // public double Length(int x, int y)
//     // {
//     //     return Math.Sqrt(x * x + y * y);
//     // }
//
//     public double DistanceTo(Point other)
//     {
//         int deltaX = this.x - other.x;
//         int deltaY = y - other.y;
//         
//         return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
//     }
// }
//
// struct Temp1
// {
//     public int y1;
//     // ...
// }
