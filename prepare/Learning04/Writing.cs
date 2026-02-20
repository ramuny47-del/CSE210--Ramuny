public class Writing : Student
{
    private string _title;

    public Writing(string title, string studentName, string topic)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"Title: {_title}";
    }
}
