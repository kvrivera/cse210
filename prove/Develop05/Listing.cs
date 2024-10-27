using System;
using System.Collections.Generic;

class Listing : Activity
{
    // Variables
    private int _count;
    private List<string> _prompts;
    private Random _random = new Random(); // This allows this class to use Random later


    // Constructor(s)
    public Listing()
    {
        _count = 0;
        List<string> _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who have you helped this week?", "When have you felt at peace this month?", "Who are some of your personal heroes?" };
    }

    // Methods
    public void Run()
    {
        base.DisplayStartingMessage();
        DisplayPrompt(); // Get and display random prompt question
        // Syntax for a countdown of several seconds
        GetListFromUser(); // get the user's list (their response to the prompt question)
        int numberOfAnswers = GetListFromUser().Count(); // Count how many answers they gave to the prompt
        Console.WriteLine($"You listed {numberOfAnswers} things.");
        base.DisplayEndingMessage();

    }
    private string GetRandomPrompt()
    {
        int randomIndex = _random.Next(_prompts.Count); // Picks an index at random from the _prompts List
        return _prompts[randomIndex];
    }
    private void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
    }
    private List<string> GetListFromUser()
    {
        List<string> listFromUser = new List<string>();
        Console.Write("Type your answer here: ");
        string userAnswer = Console.ReadLine(); // The user answers the prompt with a string
        listFromUser.Add(userAnswer); // Add the userAnswer to the list of their answers

        return listFromUser; // return the list
    }

    // ABOVE AND BEYOND: Display the list that the user generated, for them to reflect on further. The user could screenshot it or copy the text and save it to a journal entry if they wished outside of the app.
}