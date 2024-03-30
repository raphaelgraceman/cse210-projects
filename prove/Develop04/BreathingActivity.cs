using System;
using System.Threading;

public class BreathingActivity
{
    public BreathingActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity!");
        Console.Write("Please enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        for (int i = 0; i < duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);

            if (i + 1 < duration)
            {
                Console.WriteLine("Breathe out...");
                Thread.Sleep(2000);
                Console.WriteLine("3");
                Thread.Sleep(1000);
                Console.WriteLine("2");
                Thread.Sleep(1000);
                Console.WriteLine("1");
                Thread.Sleep(1000);
            }
        }

        Console.WriteLine("Congratulations! You have completed the Breathing Activity.");
    }
}



