using System;

class Program
{
    static void Main(string[] args)
    {
        bool stopper = true;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            string stringPrompt = Console.ReadLine();

            // Remove redundant ReadLine()
            if (stringPrompt == "")
            {
                continue; // Continue the loop if user input is empty
            }

            // Parse user input
            int selectedOption;
            if (!int.TryParse(stringPrompt, out selectedOption))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue; // Continue the loop if parsing fails
            }

            if (selectedOption == 4)
            {
                stopper = false;
            }
            else
            {
                Activity activity = new Activity(selectedOption);
                activity.DisplayStartingMessage();

                // Get duration input
                Console.Write("Enter duration (in seconds): ");
                string durationString = Console.ReadLine();
                int duration;
                if (!int.TryParse(durationString, out duration))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for duration.");
                    continue; // Continue the loop if parsing fails
                }

                Activity specificActivity = new Activity(selectedOption, duration);
                specificActivity.RunActivity();
            }
        } while (stopper);
    }
}
