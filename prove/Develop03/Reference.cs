public class Reference
{
    public string _book;
    public int _chapter;
    public int _startVerse;
    public int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }
    
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}