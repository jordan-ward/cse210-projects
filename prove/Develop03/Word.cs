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
        var replacement = _text.Replace($"{_text.Length}", "_");
        replacement = _text;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (Word.Hide())
        {
            
        }
    }

    public string GetDisplayText()
    {

    }
}