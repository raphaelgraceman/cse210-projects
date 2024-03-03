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

        //looping the user guess
        while (guess != magicNumber)
        {
            Console.WriteLine("Guess a magic number.");
            guess = int.Parse(Console.ReadLine());

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
    }
}