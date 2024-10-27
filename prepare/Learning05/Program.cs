using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("George Washington", "Social Studies"); // create assignment
        Console.WriteLine(assignment1.GetSummary());
    }
}