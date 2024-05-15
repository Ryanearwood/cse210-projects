public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    public MathAssignment(string name, string description, string section, string problems) : base(name, description)
    {
        _section = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_section} Problems {_problems}";
    }
}