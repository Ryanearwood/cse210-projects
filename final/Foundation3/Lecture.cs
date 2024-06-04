public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetStandardDetails()
    {
        return $"Title: {Title}, Description: {Description}, Date: {Date}, Time: {Time}, Address: {Address}";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}, Type: Lecture, Speaker: {speaker}, Capacity: {capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Lecture, Title: {Title}, Date: {Date}";
    }
}
