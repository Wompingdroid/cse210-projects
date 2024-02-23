namespace Learning04;

class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

        public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return base._studentName + " - " + base._topic + "\nSection " + _textbookSection + " Problems " + _problems;
    }
}


class EnglishAssignment : Assignment
{
    private string _title;

public EnglishAssignment(string studentName, string topic, string title) : base(studentName, topic)
{
    _title = title;
}

    public string GetWritingInformation()
    {
        return  base._studentName + " " + base._topic + "\n" + _title;
    }
}