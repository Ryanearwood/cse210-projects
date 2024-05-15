public class WritingAssignment : Assignment
{
    private string _topic;
    private string _studentName;

    public WritingAssignment(string name, string description, string topic, string studentName) : base(name, description)
    {
        _topic = topic;
        _studentName = studentName;
    }

    public string GetWritingInformation()
    {
        return $"The {_topic} by {_studentName}";
    }
}