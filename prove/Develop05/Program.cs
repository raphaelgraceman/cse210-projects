using System;

class Program
{
    static void Main()
    {
        List<string> events = new List<string> {};

        SimpleGoal simpleGoal = new SimpleGoal(events);
        EternalGoal eternalGoal = new EternalGoal(events);
        ChecklistGoal checklistGoal = new ChecklistGoal(events);    

        GoalManager goalManager = new GoalManager();
        
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record events");
            Console.WriteLine("3. List goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    goalManager.CreateNewGoal();
                    break;

                case 2:
                    // Record an event
                    goalManager.RecordEvent();
                    break;
                case 3:
                    // Display goals
                    goalManager.ListGoals();
                    break;
               
                case 4:
                    // Load goals and scores
                    goalManager.LoadGoal();
                    break;
                case 5:
                    // Save goals and scores
                    goalManager.SaveData();
                    break;
                case 6:
                    // Exit
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Program exited. Thank you for using the Eternal Quest program.");
    }
}
