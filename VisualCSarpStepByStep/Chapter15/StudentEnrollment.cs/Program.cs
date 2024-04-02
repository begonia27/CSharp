namespace StudentEnrollment.cs;

class Program
{
    static void DoWork()
    {
        var enrollments = new Enrollment[5];
        
        enrollments[0] = new Enrollment(StudentID: 1, CourseName: "Physics", DateEnrolled: new DateOnly(2021, 07, 20));
        enrollments[1] = new Enrollment(StudentID: 1, CourseName: "Chemistry", DateEnrolled: new DateOnly(2021, 07, 20));
        enrollments[2] = enrollments[0];
        enrollments[3] = enrollments[0] with { StudentID = 2 };
        enrollments[4] = enrollments[0] with { CourseName = "Math", DateEnrolled = new DateOnly(2021, 08, 15)};

        foreach (var Enrollment in enrollments)
        {
            Console.WriteLine($"{Enrollment}");
        }

        var firstEnrollment = enrollments[0];
        
        // compare each item separately
        foreach (var enrollment in enrollments[1..5])
        {
            Console.WriteLine($"{firstEnrollment == enrollment}");
        }
    }
    
    static void Main(string[] args)
    {
        try
        {
            DoWork();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
