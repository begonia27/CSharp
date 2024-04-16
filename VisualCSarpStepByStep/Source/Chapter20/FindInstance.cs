namespace Source.Chapter20;

public struct Person
{
    public int ID { set; get; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {
        ID = 0;
        Name = null;
        Age = 0;
    }
}
