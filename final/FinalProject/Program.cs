using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello FinalProject World!");

            bool quit = true;
            RSHCare rSHCare = new RSHCare();

            do
            {
                rSHCare.DisplayLevel();
                rSHCare.DisplayMenu();
                string prompt = Console.ReadLine();
                int intPrompt = int.Parse(prompt);

                if (intPrompt == 1)
                {
                    rSHCare.RSHCareType();
                    string casePrompt = Console.ReadLine();
                    int intRSHCarePrompt = int.Parse(casePrompt);
                    rSHCare.CreateRSHCare(intRSHCarePrompt);
                }

                if (intPrompt == 2)
                {
                    rSHCare.DisplayGoals();
                }

                if (intPrompt == 3)
                {
                    rSHCare.SaveToFile();
                }

                if (intPrompt == 4)
                {
                    rSHCare.LoadFile();
                }

                if (intPrompt == 5)
                {
                    rSHCare.RecordEvents();
                }

                if (intPrompt == 6)
                {
                    quit = false;
                }

                if (intPrompt > 6 || intPrompt < 0)
                {
                    Console.WriteLine("\nIncorrect Prompt");
                }

            } while (quit == true);
        }
    }


}