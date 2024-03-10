using System;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompt = new List<string>();
    public string _randomPrompt = "";

    //call special constructor
    public PromptGenerator()
    {
      _prompt = new List<string>
      {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
      };
    }

    //Get Random Prompts
    public string GetRandomPrompt()
    {
        Random random = new Random();
        //generate less than the list
        int index = random.Next(_prompt.Count);
        string _randomPrompt = _prompt[index];
        //Display the results
        return _randomPrompt;
    }
}
