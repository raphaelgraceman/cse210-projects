using System.Globalization;

public class Scriptures
{
    private Reference _scripture;
    private List<Word> _texts;
    

    public Scriptures(string book, int chapter, int startVerse, int endVerse, string text) //mult
    {
        _scripture = new Reference(book, chapter, startVerse, endVerse);
        _texts = new List<Word>();

        string[] textSplit = text.Split(' ');
        foreach (string words in textSplit)
        {
            _texts.Add(new Word(words));
        }
}
    public Scriptures(string book, int chapter, int startVerse, string text)// single verses
    {
        _scripture = new Reference(book, chapter, startVerse);
        _texts = new List<Word>();

        string[] textSplit = text.Split(' ');
        foreach (string words in textSplit)
        {
            _texts.Add(new Word(words));
        }
    }



    private List<Word> AvailableWords()
    {
        List<Word> availableWords = new();
        foreach (Word available in _texts)
        {
            if (!available.IsHidden())
            {
                availableWords.Add(available);
            }

        }

        return availableWords;
    }
public bool HideWords()
    {
        List<Word> availableWords = AvailableWords();

        if (availableWords.Count == 0)
        {
            return false;
        }

        Random randomIndex = new();
        int hideWordIndex1 = (randomIndex.Next(availableWords.Count));
        int hideWordIndex2;
        int hideWordIndex3;

        do
        {
            hideWordIndex2 = (randomIndex.Next(availableWords.Count));
            hideWordIndex3 = (randomIndex.Next(availableWords.Count));
        }

        while (hideWordIndex1 == hideWordIndex2 && hideWordIndex1 == hideWordIndex3 && hideWordIndex2 == hideWordIndex3);


        availableWords[hideWordIndex1].Hide();
        availableWords[hideWordIndex2].Hide();
        availableWords[hideWordIndex3].Hide();

        return true;

    }
public void Display()
    {
        _scripture.DisplayScriptureReference();
        foreach (Word words in _texts)
        {
            if (words.IsHidden())
            {
                Console.Write(new string('_', words.GetText().Length) + " ");


            }
            else
            {
                Console.Write(words.DisplayWord() + " ");;
            }
        }
    }
}