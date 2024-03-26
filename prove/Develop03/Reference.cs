public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
   

    public Reference(string book, int chapter, int verseStart)
    {
        SetBook(book);
        SetChapter(chapter);
        SetVerse(verseStart);
        SetVerses(verseStart);
        
    }
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        SetBook(book);
        SetChapter(chapter);
        SetVerse(verseStart);
        SetVerses(verseEnd);
        
    }
public void SetBook(string book)
    {
        _book = book;
    }
    public string GetBook()
    {
        return _book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public void SetVerse(int verse)
    {
        _verseStart = verse;
    }
    public int GetVerse()
    {
        return _verseStart;
    }
    public void SetVerses(int verseEnd)
    {

        _verseEnd = verseEnd;
    }
    public int GetVerses()
    {

        return _verseEnd;
    }
public void DisplayScriptureReference()
    {
        if (GetVerse() == GetVerses())
        {
            Console.WriteLine($"{GetBook()} {GetChapter()}: {GetVerse()}\n"); 
           
        }
        else
        {
            Console.WriteLine($"{GetBook()} {GetChapter()}: {GetVerse()} - {GetVerses()}\n");
           

        }
    }
    
}