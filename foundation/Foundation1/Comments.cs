public class Comments
{
    public string _name;
    public string _commentText;

    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: {_commentText}");
    }
}