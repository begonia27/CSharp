namespace Test19
{
    // record Grade
    // {
    //     public int StudentID { get; init; }
    //     public string Subject { get; init; }
    //     public char SubjectGrade { get; init; }
    // }

    public record Grade(int StudentID, string Subject, char SubjectGrade);
}
