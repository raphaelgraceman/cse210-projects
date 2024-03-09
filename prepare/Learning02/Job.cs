using System;

public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;
    //call the special constructor
    public Job()
    {

    }

    //behaviors: Display the job information in the format
    //"Job Title (Company) StartYear-EndYear"
    //for example: "Software Engineer (Microsoft) 2019-2022".
    public void DisplayJobDetails() //display method or function
    {
        Console.WriteLine($"{_jobTitle} ({_company} {_startYear} - {_endYear})");
    }
}