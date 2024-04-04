using System;

abstract class Goal
{
    public string Title { get; set; }
    public int Score { get; set; }

    public List<string> Events { get; }

    public Goal(List<string> eventDescriptions)
    {
        Events = new List<string>(eventDescriptions);
    }

    public virtual void RecordEvent(string eventDescription)
    {
        Events.Add(eventDescription);
    }

      public void DisplayEvents()
    {
        Console.WriteLine($"Events for goal '{Title}':");
        foreach (string ev in Events)
        {
            Console.WriteLine(ev);
        }
    }
    public abstract int CalculateScore();

    public override string ToString()
    {
        return $"Title: {Title}, Score: {Score}";
    }
    
    public virtual void DisplayGoalStatus()
    {
        string completionStatus = IsComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{completionStatus} {Name}");
    }
}



