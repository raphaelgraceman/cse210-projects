class ChecklistGoal : Goal
{
    public ChecklistGoal(List<string> eventDescriptions)  : base(eventDescriptions)
    {
        foreach (string eventDescription in eventDescriptions)
        {
            RecordEvent(eventDescription);
        }
    }

    public override void RecordEvent(string eventDescription)
    {
        Events.Add(eventDescription);
    }

    public override int CalculateScore()
    {
        // Logic to calculate score for an eternal goal
        return Score;
    }
}