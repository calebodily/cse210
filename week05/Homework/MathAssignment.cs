public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string student, string topic, string book, string problems): base(student, topic)
    {
        _textbookSection = book;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}