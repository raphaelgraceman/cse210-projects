public class Activity
{
    private string _activityName;
    private int _duration;
    private string _description;

    

    public Activity(int prompt)
    {
        SetActivity(prompt);
    }

    public Activity(int prompt, int duration)
    {
        SetActivity(prompt);
        SetDuration(duration);
    }

    public void SetActivity(int a)
    {
if (a == 1)
        {
            _activityName = "Breathing Activity";
            _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n\nHow long, in seconds, would you like for your session? ";
        }
        if (a == 2)
        {
            _activityName = "Reflecting Activity";
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n\nHow long, in seconds, would you like for your session? ";
        }
        if (a == 3)
        {
_activityName = "Listing Activity";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\nHow long, in seconds, would you like for your session? ";
        }
    }

    public void SetDuration(int a)
    {
        _duration = a;
    }
    public string GetDescription()
    {
        return _description;
    }
public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.Write($"Welcome to {GetActivityName()}\n\n{GetDescription()}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        StringSpinner();

        Console.WriteLine($"\nYou have completed another {GetDuration()} seconds of the {GetActivityName()}");
        StringSpinner();

    }
    public int GetDuration()
    {
        return _duration;
    }

    public string GetActivityName()
    {
        return _activityName;
    }
    public void RunActivity()
    {
        if (GetActivityName() == "Breathing Activity")
        {
            BreathingActivity breathingActivity = new(GetDuration());
            DisplayEndingMessage();
        }
        if (GetActivityName() == "Reflecting Activity")
        {
            ReflectingActivity reflectingActivity = new(GetDuration());
            DisplayEndingMessage();
        }
        if (GetActivityName() == "Listing Activity") 
        {
            ListingActivity listingActivity = new(GetDuration());
            DisplayEndingMessage();
        }
    }
//Animation
    public static void StringSpinner()
    {
        List<string> spinnerString = new()
        {
            "|",
            "/",
            "-",
            "\\",
             "|",
            "/",
            "-",
            "\\"


        };

        foreach (string a in spinnerString)
        {
            Console.Write(a);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }

    }
public static void NumberCountdown()
    {
        for (int i = 5; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public static void DotCountdown(int a)
    {
        for (int i = a; i >= 0; i--)
        {
            Console.Write('.');
            Thread.Sleep(1000);
        }
    }

    public DateTime StartTime()
    {
        DateTime a = DateTime.Now;
        return a;
    }
    
   
    
}