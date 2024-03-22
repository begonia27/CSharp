namespace Test10;

// class Person
// {
//     public string Name;
//     public int Age;
//
//     public Person(string name, int age)
//     {
//         this.Name = name;
//         this.Age = age;
//     }
// }

struct Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    
    public void IncreaseAge()
    {
        ++Age;
    }
}
