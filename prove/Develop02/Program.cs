using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        //creating a blank space
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        Journal journal = new Journal();

        int userInput = 0;

        //Display Welcome Message to the Screen
        Console.WriteLine("Welcome to the Journal!");

        //Display Options
        List<string> menu = new List<string>
        {
            "Please select one of the following choices",
            "1. Write to the Journal: ",
            "2. Display the Journal: ",
            "3. Load from the Journal: ",
            "4. Save to the Journal: ",
            "5. Quit",
            "",
            "What would you like to do?"
        };
        //while user do no want to Quit the program,
        while (userInput != 5){
            foreach (String item in menu){
                Console.WriteLine(item);
            }
            //convert string items to int to accept user input
            userInput = int.Parse(Console.ReadLine());

            //looping through each of the options
            if (userInput == 1){
                journal.CreateJournalEntry();
            }

            else if (userInput == 2){
                journal.DisplayJournalEntry();
            }

            else if (userInput == 3){
                journal.LoadFromJournal();
            }

            else if (userInput == 4){
                journal.SaveToCSV();
            }

            else {
                Console.WriteLine("Thank you for visiting the Journal!");
            } 
        }
        
    }
}