public class Word
{
    private string _cmText;
    private bool _cmIsHidden;

    public Word(string text)
    {
        _cmText = text;
        _cmIsHidden = false;
    }

    public void Hide()
    {
        _cmIsHidden = true;
    }

    public bool IsHidden()
    {
        return _cmIsHidden;
    }

    public string GetText()
    {
        return _cmText;
    }

    public string GetDisplayText()
    {
        if (_cmIsHidden)
        {
            return new string('_', _cmText.Length);
        }

        return _cmText;
    }
}