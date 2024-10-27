using System;
using System.Collections.Generic;

class Reflecting : Activity

{
    // Member Variables
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random(); // This allows this class to use Random later

    // Constructor(s)
    public Reflecting()
    {
        List<string> _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        List<string> _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when you had finished this task?", "What made this time different than other times when you were successful?", "What is your favourite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?", "How do you feel this experience made the world a better place?" };
    }

    // Methods (functions)
    public void Run()
    {
        base.DisplayStartingMessage();
        DisplayPrompt(); // Get and display random prompt

        while (timeRemaining > 0) // timeRemaining is whats left of _duration... // syntax required here
        {
            DisplayQuestions(); // Get and display random question
            // syntax to pause
            // timeRemaining // update this at the end of each display
        }

        base.DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        int randomIndex = _random.Next(_prompts.Count); // Picks an index from the _prompts list
        return _prompts[randomIndex]; // Return the prompt at the randomIndex of _prompts List
    }
    private string GetRandomQuestion()
    {
        int randomIndex = _random.Next(_questions.Count); // Picks an index at random from _question List
        return _questions[randomIndex]; // Return the question at the randomIndex of _questions List
    }
    private void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
    }
    private void DisplayQuestions()
    {
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine(randomQuestion);
    }
}