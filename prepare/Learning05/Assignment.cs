class Assignment
{
    // Variables
    private string _studentName;
    private string _topic;

    // Constructor(s)
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    // Methods (functions)
    public string GetSummary()
    {
        string summary = $"Student Name: {_studentName}\nTopic: {_topic}";
        return summary;
    }
}