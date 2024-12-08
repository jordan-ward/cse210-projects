public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void Run()
    {
        DateTime startTime = GetCurrentTime();
        DateTime futureTime = GetFutureTime(GetDuration());

        Console.WriteLine();
        Console.Write("Breathe in... ");
        ShowCountDown(2);
        Console.WriteLine();
        Console.Write("Breathe out... ");
        ShowCountDown(4);

        while (startTime <= futureTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountDown(8);

            startTime = DateTime.Now;
            
        }
    }
}