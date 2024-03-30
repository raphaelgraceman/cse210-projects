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
            
            if (stringPrompt == ""){
            stringPrompt = Console.ReadLine();
            }
            int prompt = int.Parse(stringPrompt);

            if (prompt == 4)
            {
                stopper = false;
            }

            else
            {
                Activity activity = new(prompt);
                activity.DisplayStartingMessage();

                string durationString = Console.ReadLine();
                int duration = int.Parse(durationString);
                
                Activity specificActivity = new(prompt, duration);
                specificActivity.RunActivity();
          
            }

        } while (stopper == true);
    }
  
}