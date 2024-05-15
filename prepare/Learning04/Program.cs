class Program
{
    static void Main(string[] args)
    {
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "Causes of World War II", "Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}