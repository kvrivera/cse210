using System;
class Activity
{
    // Variables
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    public Activity()
    {
        _name = "Activity Name";
        _description = "Description of the Activity";
        _duration = 0;
    }

    // Methods
    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to your personal {_name}. {_description}");
        Console.WriteLine("How long would you like for this activity to last?");
        Console.Write("Write only the number of seconds: ");
        _duration = int.Parse(Console.ReadLine()); // Get user input for _duration of Activity
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Great job. :)");
        // syntax for a pause
        Console.WriteLine($"You have completed your personal {_name} for a duration of {_duration}.");
        // syntax for a pause (several seconds)
    }
    private void ShowSpinner(int seconds)
    {
        _duration = seconds;
        // syntax
    }
    private void ShowCountDown(int seconds)
    {
        _duration = seconds; // is duration in seconds?
        // syntax
    }
}