public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 60)
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 10; i++)
        {
            Console.WriteLine("Breathe In");
            ShowBreathingAnimation();

            Console.WriteLine("Breathe Out");
            ShowBreathingAnimation();
        }

        DisplayEndingMessage();
    }

    private void ShowBreathingAnimation()
    {
        string breath = "";
        for (int i = 0; i < 10; i++)
        {
            breath += "*";
            Console.WriteLine(breath);
            Thread.Sleep(500);
        }

        for (int i = 0; i < 10; i++)
        {
            breath = breath.Remove(breath.Length - 1);
            Console.WriteLine(breath);
            Thread.Sleep(500);
        }
    }
}
