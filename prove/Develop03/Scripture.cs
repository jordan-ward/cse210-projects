public class Scripture
{
    public Reference _reference{get;}
    private List<Word> _words;
    private int currentWordIndex = 0;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(" ");
        foreach (var word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // use randon number generator to set words in 
        // the list to hidden.
        Random random = new Random();
        int randomIndex = random.Next(0, _words.Count);
        _words[randomIndex].Hide;
        currentWordIndex++;
    }

    public string GetDisplayText()
    {
        // Show text of the reference and each word in 
        // the _words list.
        return $"{_reference} {_words}";
    }

    public bool IsCompletelyHidden()
    {
        // Needs to check all Words in _words to see if 
        // they are hidden or not. Use IsHidden method.
        if (currentWordIndex == _words.Count)
        {
            return true;
        }
        else currentWordIndex != _words.Count
        {
            return false;
        }
    }
}