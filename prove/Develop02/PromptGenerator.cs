public class PromptGenerator
{
    public static List<string> _prompts = new List<string>
    {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "What miracle did you see today?",
    "How did I see the hand of the Lord in my life today?",
    "What are you going to do tomorrow that you didnt do today?",
    "What was the strongest emotion I felt today?",
    "What was one thing you wished you had done today?",
    "How did you show your love for someone else today?",
    "If I had one thing I could do over today, what would it be?"
    };
    public static string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string _promptText = _prompts[index];
        return _promptText;
    }
}