public abstract class Event
{
    protected string Title { get; private set; }
    protected string Description { get; private set; }
    protected DateTime Date { get; private set; }
    protected string Time { get; private set; }
    protected Address Address { get; private set; }

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        this.Title = title;
        this.Description = description;
        this.Date = date;
        this.Time = time;
        this.Address = address;
    }

    public abstract string GetStandardDetails();
    public abstract string GetFullDetails();
    public abstract string GetShortDescription();
}
