using System;
class Activity
{
    // Variables
    protected string _name;
    protected string _description;
    protected int _duration;
    protected List<string> _animationStrings;

    // Constructor
    public Activity()
    {
        _name = "Activity Name";
        _description = "Description of the Activity";
        _duration = 0;
        _animationStrings = new List<string> { "|", "/", "-", "\\" };
    }

    // Methods
    protected void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to your personal {_name}. {_description}");
        Console.WriteLine("How long would you like for this activity to last?");
        Console.Write("Write only the number of seconds: ");
        _duration = int.Parse(Console.ReadLine()); // Get user input for _duration of Activity
        Console.WriteLine();
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Great job. :)");
        // syntax for a pause
        Console.WriteLine($"You have completed your personal {_name} for a duration of {_duration} seconds.");
        // syntax for a pause (several seconds)
        Console.WriteLine();
    }
    protected void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            foreach (string s in _animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(250); // pause
                Console.Write("\b \b"); // erase previous char, space to clear, erase space
                currentTime = DateTime.Now; // update currentTime for loop break
            }
        }
    }
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // keep the number on the screen for 1 second
            Console.Write("\b \b");
        }
    }
}