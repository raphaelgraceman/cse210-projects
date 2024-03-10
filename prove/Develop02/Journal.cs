using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    //Call the special constructor
    public Journal()
    {
        _entries = new List<Entry>();
    }

    //Creating Journal Entires
    public void CreateJournalEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string userInput = promptGenerator.GetRandomPrompt();

        //Current Date and Time Documentation
        DateTime _dateTime = DateTime.Now;
        string _date = _dateTime.ToShortDateString();

        //Display the Date item
        Console.WriteLine(userInput);

        //Prompt userInput and store it as response
        Console.Write("Response: ");
        string response = Console.ReadLine();

        //Get and store entries into theEntery
        Entry _theEntry = new Entry(_date, userInput, response);
        //Recodring Enteries
        _entries.Add(_theEntry);
    }

    public void DisplayJournalEntry()
    {
        foreach (Entry _theEntry in _entries){
            _theEntry.DisplayJournalEntry();
        }
    }

    //Load Form CSV()
    public void LoadFromJournal()
    {
        string fileName = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
           Console.WriteLine(line);
        }
    }

      //Saving CSV()
    public void SaveToCSV()
    {
        string fileName  ="myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //Add text to the file using writeline method
            outputFile.WriteLine(_entries);
        }
    }
}