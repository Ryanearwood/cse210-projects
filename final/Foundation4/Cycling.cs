public class Cycling : Activity
{
    public double Speed { get; set; }

    public override double GetDistance() => (Speed / 60) * Minutes;
    public override double GetSpeed() => Speed;
    public override double GetPace() => Minutes / GetDistance();
}
