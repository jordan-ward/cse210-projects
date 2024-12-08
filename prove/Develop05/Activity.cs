public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 5;
    }

    public void StartActivity()
    {
        Console.Clear();
        DisplayStartingMessage();
        AskDuration();
        Delay();
    }

    public void AskDuration()
    {
        Console.Write("How long would you like your session to be? (In seconds): ");
        string durationSet = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationSet));
    }

    public void Delay()
    {
        Console.WriteLine("Get ready...");
        ShowCountDown(5);
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine($"Description: {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Thank you for participating in the {_name} activity!");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> animationStrings = new List<string>();    
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i=0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }


    }

    public DateTime GetCurrentTime()
    {
        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;
        return currentTime;
    }

    public DateTime GetFutureTime(int duration)
    {
        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(duration);
        return futureTime;
    }
}