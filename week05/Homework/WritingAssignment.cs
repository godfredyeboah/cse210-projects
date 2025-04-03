public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Calls the base class constructor
    {
        _title = title;
    }

    // Method to return writing assignment details
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
