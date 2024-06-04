public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetStandardDetails()
    {
        return $"Title: {Title}, Description: {Description}, Date: {Date}, Time: {Time}, Address: {Address}";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}, Type: Outdoor Gathering, Weather Forecast: {weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering, Title: {Title}, Date: {Date}";
    }
}
