namespace Test10;

class Program
{
    // 使用 ref 关键字，对值类型进行引用
    static ref Person FindYoungest(Person[] family)
    {
        int youngest = 0;
        for (int i = 1; i < family.Length; i++)
        {
            if (family[i].Age < family[youngest].Age)
            {
                youngest = i;
            }
        }

        // 使用 ref 关键字，对值类型进行引用
        return ref family[youngest];
    } 
    static public Person[] ValueType()
    {
        Person[] family = new Person[]
        {
            new Person("John", 57),
            new Person("Diana", 57),
            new Person("James", 30),
            new Person("Francesca", 26)
        };
        
        Person mostYouthful = FindYoungest(family);
        Console.WriteLine($"Name: {mostYouthful.Name}, Age: {mostYouthful.Age}");

        return family;
    }

    static void IncreaseYoungestAge(Person[] family)
    {
        // 使用 ref 关键字，对值类型进行引用
        ref Person mostYouthful = ref FindYoungest(family);
        mostYouthful.IncreaseAge();
        
        Console.WriteLine($"Name: {mostYouthful.Name}, Age: {mostYouthful.Age}\n");
    }
    
    static void DisplayAllMember(Person[] family)
    {
        foreach (Person familyMember in family)
        {
            Console.WriteLine($"Name: {familyMember.Name}, Age: {familyMember.Age}");
        }
    }

    static void Main(string[] args)
    {
        Person[] family = ValueType();
        IncreaseYoungestAge(family);
        DisplayAllMember(family);
    }
}   
