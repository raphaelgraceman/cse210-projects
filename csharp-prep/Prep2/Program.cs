using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        //Ask the user for their grade
        Console.WriteLine("What is your percentage grade score?");
        string gradeScore = Console.ReadLine();
        int userGradeScore = int.Parse(gradeScore);
        //ussing letter as a variable to represent grade percent
        string letter = "";

        if (userGradeScore >= 90)
        {
            letter = "A";
        }
        else if (userGradeScore >= 80)
        {
            letter = "B";
        }
        else if (userGradeScore >= 70)
        {
            letter = "C";
        }
        else if (userGradeScore >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }
        // Display user grade
        Console.WriteLine($"Your grade is {letter}.");


        //If pass mark is at least 70, declare a message to congratulate the user
        //or encourage the user to better performance next time

        if (userGradeScore == 70 || userGradeScore >= 70)
            {
                Console.WriteLine("Congratulations! You've passed the test.");
            }
        else
        {
            Console.WriteLine("Left an inch! You almost pass the test.");
            Console.WriteLine("You could do better next time");
        }
    }
}