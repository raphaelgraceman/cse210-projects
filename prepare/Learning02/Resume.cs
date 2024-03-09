using System;
public class Resume 
{
    public string _name = "";
    //Initializing the lists of Jobs
    public List<Job> _jobLists = new List<Job>();

    //calling the spcial constructor "Resume"
    public Resume()
    {

    }
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //looping through each job
        foreach (Job job in _jobLists)
        {
            //display each job
            job.DisplayJobDetails();
        }
    }
}