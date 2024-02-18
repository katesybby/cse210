public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int chapter, int verseStart, int verseEnd)   //constructor for multiple verse reference
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public Reference(string book, int chapter, int verse)   //constructor for single verse reference
   {
       _book = book;
       _chapter = chapter;
       _verseStart = verse;
       _verseEnd = verse;
   }

    public string GetReferenceString()
    {
        if (_verseStart == _verseEnd)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}