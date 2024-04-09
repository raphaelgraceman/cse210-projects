using System;
using System.IO;
namespace  Eternal_Quest
{     
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = true;
            
            GoalManager goalManager = new();

            do
            {
                
                goalManager.DisplayLevel();

                goalManager.DisplayMenu();
                string prompt = Console.ReadLine();
                int intPrompt = int.Parse(prompt);



                if (intPrompt == 1)
                {
                    goalManager.GoalType();
                    string goalPrompt = Console.ReadLine();
                    int intGoalPrompt = int.Parse(goalPrompt);

                    goalManager.CreateGoal(intGoalPrompt);


                }

                if (intPrompt == 2)
                {   
                    goalManager.DisplayGoals();
                }

                if (intPrompt == 3)
                {
                    goalManager.SaveToFile();
                }

                if (intPrompt == 4)
                {
                    goalManager.LoadFile();
                }

                if (intPrompt == 5)
                {
                    goalManager.RecordEvents();

                }

                if (intPrompt == 6)
                {
                    quit = false;
                }

                if (intPrompt>6||intPrompt<0)
                {
                    Console.WriteLine("\nIncorrect Prompt");
                }

            } while (quit == true);

        }
    
    
    }
}