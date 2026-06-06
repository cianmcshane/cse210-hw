public class Reference
{
    private string _cmBook;
    private int _cmChapter;
    private int _cmStartVerse;
    private int _cmEndVerse;

    public Reference(string book, int chapter, int verse)
    {
        _cmBook = book;
        _cmChapter = chapter;
        _cmStartVerse = verse;
        _cmEndVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _cmBook = book;
        _cmChapter = chapter;
        _cmStartVerse = startVerse;
        _cmEndVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_cmStartVerse == _cmEndVerse)
        {
            return $"{_cmBook} {_cmChapter}:{_cmStartVerse}";
        }

        return $"{_cmBook} {_cmChapter}:{_cmStartVerse}-{_cmEndVerse}";
    }
}
