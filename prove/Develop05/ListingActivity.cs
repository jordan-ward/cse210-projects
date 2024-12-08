public class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are your personal heroes?"
    };

    public ListingActivity()
    {
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"-- {prompt} --");
        Console.WriteLine();
        Console.WriteLine("You will begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        
        DateTime startTime = GetCurrentTime();
        DateTime futureTime = GetFutureTime(GetDuration());

        List<string> responses = new List<string>();

        while (startTime <= futureTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);

            startTime = DateTime.Now;
        }

        Console.WriteLine($"Good Work! You made {responses.Count()} entries!");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _listingPrompts.Count);
        return _listingPrompts[index];
    }
}