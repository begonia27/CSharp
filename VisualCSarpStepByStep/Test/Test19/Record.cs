namespace Test19
{
    // record Grade
    // {
    //     public int StudentID { get; init; }
    //     public string Subject { get; init; }
    //     public char SubjectGrade { get; init; }
    // }
    
    record Grade(int StudentID, string Subject, char SubjectGrade);
}
