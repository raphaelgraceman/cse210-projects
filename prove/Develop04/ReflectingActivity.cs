using System;
using System.Collections.Generic;
using System.Threading;

// Class ReflectionsActivity
public class ReflectingActivity : Activity
{
    private List<string> _questions;

    public ReflectingActivity()
    {
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public override void Run()
    {
        Console.WriteLine("Starting Reflection Activity...");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();

        DisplayPrompt();

        int durationInSeconds = 60; // Default duration of 60 seconds
        ShowSpinner(durationInSeconds);

        Console.WriteLine();
        Console.WriteLine("Reflection Activity concluded.");
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Think of a time when you stood up for someone else.");
        Console.WriteLine("Think of a time when you did something really difficult.");
        Console.WriteLine("Think of a time when you helped someone in need.");
        Console.WriteLine("Think of a time when you did something truly selfless.");
        Console.WriteLine();
    }

    public void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine($"- {question}");
            Thread.Sleep(5000); // Pause for 5 seconds
        }
    }
}


