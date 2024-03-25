using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordArray = text.Split();
        foreach(string value in wordArray)
        {
            Word wordObj = new Word(value);
            _words.Add(wordObj);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for(int i = 0 ; i < numberToHide ; i ++) //Standard for loop
        {
            int index;
            do{
                index = _random.Next(_words.Count);
            } while(_words[index].GetIsHidden() == true);
            _words[index].Hide();
            if (AllWordsHidden())
                break;
        }
    }

    public void GetDisplayText()
    {
        Console.Write(_reference.GetDisplayText() + " - ");
        foreach(Word word in _words)
        { 
            Console.Write(word.GetText() + " ");
        }
        Console.WriteLine("\n");
    }

   
    public bool AllWordsHidden()
    {
        foreach( Word word in _words)
        {
            if(word.GetIsHidden() == false)
                return false;
        }
        return true;
    }

}