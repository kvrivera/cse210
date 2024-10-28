using System;
using System.Collections.Generic;

class Listing : Activity
{
    // Variables
    private int _count;
    private List<string> _prompts;
    private Random _random = new Random(); // This allows this class to use Random later
    private List<string> _listFromUser; // list of user responses to prompt


    // Constructor(s)
    public Listing()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
        _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who have you helped this week?", "When have you felt at peace this month?", "Who are some of your personal heroes?" };
        _listFromUser = new List<string>();
    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt(); // Get and display random prompt question

        Console.WriteLine("Take a moment to ponder this prompt.");
        ShowCountDown(7); // give them 7 seconds to ponder

        List<string> userListingAnswers = GetListFromUser(_duration); // get the user's list (their response to the prompt question)
        _count = userListingAnswers.Count(); // Count how many answers they gave to the prompt
        Console.WriteLine($"You listed {_count} things.");
        string userListString = DisplayListFromUser(); // store string-ed list in variable
        Console.WriteLine(userListString);

        Console.WriteLine();
        Console.WriteLine();

        base.DisplayEndingMessage();
        Console.WriteLine();

    }
    private string GetRandomPrompt()
    {
        int randomIndex = _random.Next(_prompts.Count); // Picks an index at random from the _prompts List
        return _prompts[randomIndex];
    }
    private void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---{randomPrompt}---");
    }
    private List<string> GetListFromUser(int _duration)
    {

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("Type your answer here: ");
            string userAnswer = Console.ReadLine(); // The user answers the prompt with a string
            _listFromUser.Add(userAnswer); // Add the userAnswer to the list of their answers
            currentTime = DateTime.Now; // update currentTime for the sake of the loop
        }
        return _listFromUser; // return the list
    }

    // ABOVE AND BEYOND: Display the list that the user generated, for them to reflect on further. The user could screenshot it or copy the text and save it to a journal entry if they wished outside of the app.
    private string DisplayListFromUser()
    {
        string _listFromUserString = "";
        foreach (string listItem in _listFromUser)
        {
            int listNumber = _listFromUser.IndexOf(listItem) + 1;
            string listItemString = $"{listNumber}.) {listItem}"; // Example: "1.) My dog was so happy"
            _listFromUserString += $"{listItemString}\n"; // Adds this to the end of the string of all listed items
        }
        return _listFromUserString;
    }
}