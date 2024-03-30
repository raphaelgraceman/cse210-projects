using System;
using System.Collections.Generic;

// Class ListingActivity
public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;

    public ListingActivity()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _items = new List<string>();
    }

    public override void Run()
    {
        Console.WriteLine("Starting Listing Activity...");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine();

        DisplayPrompt();

        int durationInSeconds = 60; // Default duration of 60 seconds
        ShowSpinner(durationInSeconds);
        
        Console.WriteLine();
        Console.WriteLine($"Number of items listed: {_items.Count}");
        Console.WriteLine();

        Console.WriteLine("Listing Activity concluded.");
    }

    public void DisplayPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
        Console.WriteLine("You have a few seconds to start thinking...");
        Thread.Sleep(5000); // Pause for 5 seconds
        Console.WriteLine("Start listing items:");

        CollectItems();
    }

    public void CollectItems()
    {
        Console.WriteLine("Enter an item (or type 'done' to finish):");

        string input = Console.ReadLine();
        while (input.ToLower() != "done")
        {
            _items.Add(input);
            input = Console.ReadLine();
        }
    }
}


