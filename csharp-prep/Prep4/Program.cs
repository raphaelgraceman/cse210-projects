using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number or 0 to quit: ");

            //get user response
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            //add the number to the list if not zero
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

            //Computing the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            //Display the sum
            Console.WriteLine($"The sum is: {sum}");

            //finding the max
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The max is: {max}");
        }
    }
}