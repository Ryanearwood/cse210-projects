public class Swimming : Activity
{
    public int Laps { get; set; }

    public override double GetDistance() => (Laps * 50 / 1000) * 0.62;
    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance();
}
