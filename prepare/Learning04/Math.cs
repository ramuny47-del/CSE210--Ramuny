public class Math : Student
{
    private string _textbookSection;
    private string _problem;


    public Math(string studentName, string topic, string textbookSection, string problem)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problem= problem;

    }

    public string GetHomeworkList()
    {
        return $"Secetion {_textbookSection} Problems {_problem}";
    }


}
