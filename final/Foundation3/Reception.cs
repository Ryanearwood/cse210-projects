public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetStandardDetails()
    {
        return $"Title: {Title}, Description: {Description}, Date: {Date}, Time: {Time}, Address: {Address}";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}, Type: Reception, RSVP Email: {rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Reception, Title: {Title}, Date: {Date}";
    }
}
