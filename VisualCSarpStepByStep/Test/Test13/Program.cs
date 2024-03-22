using System.Reflection.Metadata;

namespace Test13;

class Program
{
    class Mammal
    {
        // constructor of base class
        public Mammal(string name)
        {
            
        }
        
        public void Breathe()
        {
            
        }

        public void SuckYoung()
        {
            
        }

        public void Talk()
        {
            
        }
    }

    class Horse: Mammal
    {
        // derived class constructor invoke by base class constructor
        public Horse(string name): base(name)
        {
            
        }
        
        public void Trot()
        {
            
        }

        public new void Talk()
        {
            
        }
    }

    class Whale : Mammal
    {
        // derived class constructor invoke by base class constructor
        public Whale(string name): base(name)
        {
            
        }

        public void Swim()
        {
            
        }
    }
    
    static void Assignment()
    {
        Horse myHorse = new Horse("honey");
        myHorse.Trot();
        myHorse.Breathe();
        myHorse.SuckYoung();

        Whale myWhale = new Whale("sprite");
        myWhale.Swim();
        myWhale.Breathe();
        myWhale.SuckYoung();

        // it is allowed assignment derived class to base class
        Mammal myMammal = myHorse;
        
        // only use a method from base class 
        myMammal.Breathe();
        myMammal.SuckYoung();
    }

    static void UseAs()
    {
        Horse myHorse = new Horse("colt");
        Mammal myMammal = myHorse;
        
        Horse? myHorseAgain = myMammal as Horse;
        myHorseAgain?.Trot();
        myHorseAgain?.Breathe();
        myHorseAgain?.SuckYoung();

        // myHorseAgain is null
        Whale myWhale = new Whale("cute");
        myMammal = myWhale;
        myHorseAgain = myMammal as Horse;
        myHorseAgain.Trot();
    }
    
    static void Main(string[] args)
    {
        // Assignment();
        // UseAs();

        List<Shape> list = new List<Shape>();
        
        list.Add(new Square(7));
        list.Add(new Circle(3));
        list.Add(new Square(333));

        foreach (Shape s in list)
        {
            Console.WriteLine(s.Area());
        }
        
        // Shape shape = new Circle(10);
        // Console.WriteLine($"The area of circle is {shape.Area()}");
        //
        // shape = new Square(12);
        // Console.WriteLine($"The area of square is {shape.Area()}");
    }
}
