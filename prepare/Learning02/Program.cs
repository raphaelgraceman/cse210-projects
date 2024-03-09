using System;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        
        //creating a blank space
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        //creating a new job instance named job1
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle =  "Software Engineer";
        job1._startYear = 1947;
        job1._endYear = 1957;

        //An instance of Job2
        Job job2 = new Job();
        job2._company = "Royal Seed Orphanage";
        job2._jobTitle = "Administrator";
        job2._startYear = 200;
        job2._endYear = 2040;
        
        //Calling the special consturctor "JOB" to be displayed
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        //creating a blank space
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        //creating an instance for the resume class
        Resume myResume = new Resume();
        myResume._name = "Raphael Dotse";

        //Adding the two jobs
        myResume._jobLists.Add(job1);
        myResume._jobLists.Add(job2);

        //Accessing the job list using the display function
        myResume.DisplayResume();

        //creating a blank space
        Console.WriteLine(" ");
        Console.WriteLine(" ");



    }
    
   
   
}