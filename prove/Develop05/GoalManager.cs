using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class GoalManager
{
    private List<Goal> goals = new List<Goal>();

        public void CreateNewGoal()
    {
        Console.Write(" ");
        Console.WriteLine("Options:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter the type of goal: ");
        int goalType = Convert.ToInt32(Console.ReadLine());

        Goal goal = null;

        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal();
                Console.Write("Enter the title of the Simple Goal: ");
                goal.Title = Console.ReadLine();

                Console.WriteLine(" ");
                Console.WriteLine("Enter the description of the Goal: ");
                goal.Title = Console.ReadLine();

                Console.WriteLine(" ");
                Console.Write("Enter the score for the Simple Goal: ");
                goal.Score = Convert.ToInt32(Console.ReadLine());
                break;

            case 2:
                goal = new EternalGoal();
                Console.Write("Enter the title of the Eternal Goal: ");
                goal.Title = Console.ReadLine();

                Console.WriteLine(" ");
                Console.WriteLine("Enter the description of the Goal: ");
                goal.Title = Console.ReadLine();

                Console.WriteLine(" ");
                Console.Write("Enter the score for the Eternal Goal: ");
                goal.Score = Convert.ToInt32(Console.ReadLine());
                break;

            case 3:
                goal = new ChecklistGoal();
                Console.Write("Enter the title of the Checklist Goal: ");
                goal.Title = Console.ReadLine();

                Console.WriteLine(" ");
                Console.WriteLine("Enter the description of the Goal: ");
                goal.Title = Console.ReadLine();

                Console.WriteLine(" ");
                Console.Write("Enter the score for the Checklist Goal: ");
                goal.Score = Convert.ToInt32(Console.ReadLine());
                break;

            default:
                Console.WriteLine("Invalid goal type choice.");
                return;
        }
        //Add to the list of goals
        goals.Add(goal);
        Console.WriteLine("New goal created successfully.");
    }

    //Method to add and record events
    public void AddGoalAndRecordEvents()
    {
        CreateNewGoal(); // Method to create a new goal

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals have been added. Please add a goal first.");
            return;
        }

        ListGoals(); // Method to display the list of goals

        Console.Write("Select the goal to record an event for (enter the index): ");
        int selectedGoalIndex = Convert.ToInt32(Console.ReadLine());

        if (selectedGoalIndex < 0 || selectedGoalIndex >= goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        Goal selectedGoal = goals[selectedGoalIndex];

        RecordEvent(selectedGoal); // Method to record an event for the selected goal
    }


    public void RecordEvent(Goal goal)
    {
        Console.WriteLine($"Recording an event for goal: {goal.Title}");

        Console.Write("Enter event description: ");
        string eventDescription = Console.ReadLine();

        goal.RecordEvent(eventDescription);

        Console.WriteLine("Event recorded successfully.");
    }

    public void ListGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.ToString());
        }
    }

    public void ShowScore()
    {
        int totalScore = 0;

        foreach (Goal goal in goals)
        {
            totalScore += goal.CalculateScore();
        }

        Console.WriteLine($"Total score: {totalScore}");
    }

    public void SaveData()
    {
        string json = JsonSerializer.Serialize(goals);
        File.WriteAllText("goals.json", json);
        Console.WriteLine("Goals and scores saved successfully.");
    }

    public void LoadGoal()
    {
        if (File.Exists("goals.json"))
        {
            string json = File.ReadAllText("goals.json");
            goals = JsonSerializer.Deserialize<List<Goal>>(json);
            Console.WriteLine("Goals and scores loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved data found.");
        }
    }

    public void RecordEventForEternalGoal(EternalGoal eternalGoal)
    {
        Console.WriteLine($"Recording an event for eternal goal: {eternalGoal.Title}");

        Console.Write("Enter event description: ");
        string eventDescription = Console.ReadLine();

        eternalGoal.RecordEvent(eventDescription);

        Console.WriteLine("Event recorded successfully.");
    }


}
