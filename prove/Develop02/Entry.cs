using System;

public class Entry
{
    public string _date = "";
    public string _promptText;
    public string _response;

    //call the special constructor
    public Entry(string _date, string _promptText, string _response)
    {

    }

    //Accessing the Display method
    public void DisplayJournalEntry()
    {
        Console.WriteLine($"Today, {_date} - {_promptText} ");
        Console.WriteLine($"{_response}");
    }

    //Get user response
    public string GetEntry()
    {
       return string.Format("{0} - {1} - {2}", _date, _promptText, _response); 
    }
}
