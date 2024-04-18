namespace Source.Chapter21;

public class Employee: IComparable<Employee>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
    public int ID { get; set; }
    
    int IComparable<Employee>.CompareTo(Employee? other)
    {
        if (other is null)
        {
            return 1;
        }

        if (ID > other.ID)
        {
            return 1;
        }

        if (ID < other.ID)
        {
            return -1;
        }

        return 0;
    }

    public override string ToString() => $"ID: {ID}, Name: {FirstName} {LastName}, Dept: {Department}";
}
