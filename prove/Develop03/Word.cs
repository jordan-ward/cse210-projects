using System.Runtime.CompilerServices;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            // return underscores for the word
            string underscore = new string('_', _text.Length);
            return $"{underscore}";
        }
        else (_isHidden == false)
        {
            // return name unchanged
            return $"{_text}";
        }
    }
}