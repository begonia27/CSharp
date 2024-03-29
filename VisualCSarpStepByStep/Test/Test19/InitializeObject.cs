namespace Test19
{
// public class Triangle
// {
//     private int side1Length;
//     private int side2Length;
//     private int side3Length;
//
//     public Triangle()
//     {
//         this.side1Length = this.side2Length = this.side3Length = 10;
//     }
//
//     public Triangle(int length1)
//     {
//         this.side1Length = length1;
//         this.side2Length = side3Length = 10;
//     }
//
//     public Triangle(int length1, int length2)
//     {
//         this.side1Length = length1;
//         this.side2Length = length2;
//         this.side3Length = 10;
//     }
//
//     public Triangle(int length1, int length2, int length3)
//     {
//         this.side1Length = length1;
//         this.side2Length = length2;
//         this.side3Length = length3;
//     }
// }

    public class Triangle
    {
        private int side1Length = 10;
        private int side2Length = 10;
        private int side3Length = 10;
        public string shapeName = "123";

        public int Side1Length
        {
            get => side1Length;
            set => side1Length = value;
        }

        public int Side2Length
        {
            get => side2Length;
            set => side2Length = value;
        }

        public int Side3Length
        {
            get => side3Length;
            set => side3Length = value;
        }

        public Triangle(string name)
        {
            shapeName = name;
        }
    }
}
