using System;
class Breathing : Activity
{
    // Variables
    // none

    // Constructor(s)
    public Breathing()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Method(s)
    public void Run()
    {
        DisplayStartingMessage(); // Shows user a starting msg, and gets value for _duration
        // syntax
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("Breathe in... ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000); // keep the number on the screen for 1 second
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.Write("Now breathe out... ");
            ShowCountDown(10);
            Console.WriteLine();
            currentTime = DateTime.Now; // update currentTime for the sake of the loop
        }

        Console.WriteLine();
        DisplayEndingMessage();
        Console.WriteLine();
    }
}