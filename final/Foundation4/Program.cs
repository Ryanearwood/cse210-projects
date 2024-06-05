
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running { Date = new DateTime(2022, 11, 3), Minutes = 30, Distance = 3.0 },
            new Cycling { Date = new DateTime(2022, 11, 3), Minutes = 30, Speed = 20.0 },
            new Swimming { Date = new DateTime(2022, 11, 3), Minutes = 30, Laps = 20 }
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

