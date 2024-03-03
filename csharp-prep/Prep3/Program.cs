using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        //Generate a random nuber from the computer
        Random randomNumber = new Random();
        int magicNumber =  randomNumber.Next(1, 100);

        int guess = -1;
        int guessCount = 0;

        //looping the user guess
        while (guess != magicNumber)
        {
           if (guessCount != 5)
           {
             Console.WriteLine("Guess a magic number.");
            guess = int.Parse(Console.ReadLine());
            guessCount++ ;

            if (magicNumber > guess)
            {
                Console.WriteLine("Guess higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Guess lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
           }

           else
           {
            Console.WriteLine("Game Over");
            string  response = "yes";
            if (response == "yes")
            {
                Console.WriteLine("Would you like to continue?");
                response = Console.ReadLine();
            }

            //continueing
             Console.WriteLine("Guess a magic number.");
            guess = int.Parse(Console.ReadLine());
            guessCount++ ;

            if (magicNumber > guess)
            {
                Console.WriteLine("Guess higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Guess lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            Console.WriteLine("Game over");
           }
        }
    }
}