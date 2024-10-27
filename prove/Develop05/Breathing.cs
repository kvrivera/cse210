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
        _duration = 30; // 30 seconds?
    }

    // Method(s)
    public void Run()
    {
        base.DisplayStartingMessage(); // Shows user a starting msg, and gets value for _duration
        // syntax
        base.DisplayEndingMessage();
    }
}