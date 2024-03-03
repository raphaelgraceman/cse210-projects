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
        string sign = "+";

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

        //If pass mark is at least 70, declare a message to congratulate the user
        //or encourage the user to better performance next time

        if (userGradeScore == 70 || userGradeScore >= 70)
            {
                Console.WriteLine("Congratulations! You've passed the test.");
                if (userGradeScore >= 97)
                {Console.WriteLine($"Your grade is {letter}-.");}
                else if (userGradeScore >= 87)
            {
                Console.WriteLine($"Your grade is {letter + sign}");
            }
            else{
                Console.WriteLine($"Your grade is {letter}-.");
            }
            }
          
        else
        {
            // Display user grade
            Console.WriteLine($"Your grade is {letter}.");

            Console.WriteLine("Left an inch! You almost pass the test.");
            Console.WriteLine("You could do better next time");
        }
    }
}