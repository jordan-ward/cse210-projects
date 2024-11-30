public class Video
{
    public string _title;
    public string _author;
    public int _lengthOfVideo;


    public List<Comments> _comment = new List<Comments>();
    public void NumberOfComments()
    {
        Console.WriteLine("{0}", _comment.Count);
    }
    public void DisplayInformation()
    {
        Console.WriteLine("");
        Console.WriteLine($"Video title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length of the video: {_lengthOfVideo}");
        Console.WriteLine($"Number of comments: {NumberOfComments}");
        Console.WriteLine("Comments: ");


        foreach (Comments comments in _comment)
        {
            comments.DisplayComment();
        }


    }
}