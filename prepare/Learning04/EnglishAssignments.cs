public class EnglishAssignments : Assignment
{
    private string _title;

    public EnglishAssignments(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetEnglishInfo()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}