public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic) // Calls the base class constructor
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to return Math homework details
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
