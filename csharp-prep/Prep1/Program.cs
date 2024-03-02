using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        //prep 1 assignement 
       //request user fname
       Console.WriteLine("What is your fname?");
       string fname = Console.ReadLine();

       //get the second name
       Console.WriteLine("What is your last name?");
       string lname = Console.ReadLine();

       //Print user full name
       Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}