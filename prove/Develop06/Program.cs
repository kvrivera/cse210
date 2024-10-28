// ABOVE AND BEYOND:
// I added animations ("spinner") and confirmation messages in the GoalManager class to demonstrate to the user
// that their Goal had been created, or that their saved file was loading.
// I also added a level system, where the user can scale up to 11 levels based off of how many points they have. Once
// the user reaches 1000 points, they have reached level 11! The ultimate level.
// The user's level displays each time the menu shows (in the Start() method of the GoalManager class)
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager goalManager = new GoalManager();
        goalManager.Start(); // clears console, shows score, then menu options
        Console.WriteLine(); // blank space

        Console.Write("Select a choice from the menu: ");
        int userMenuChoice = int.Parse(Console.ReadLine());
        Console.WriteLine(); // blank space

        while (userMenuChoice != 6) // While user doesn't choose Quit
        {
            if (userMenuChoice == 1) // Create New Goal
            {
                goalManager.CreateGoal(); // shows goal types, lets user choose a type, takes input to set variables for Goal object

                Console.Clear();
                goalManager.Start();
                Console.WriteLine(); // blank space

                Console.Write("Select a choice from the menu: ");
                userMenuChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(); // blank space

            }

            else if (userMenuChoice == 2) // List Goals user has already set
            {
                goalManager.ShowGoalList(); // prints a numbered list of goals with their descriptions

                Console.WriteLine();
                Console.WriteLine();
                goalManager.Start();
                Console.WriteLine(); // blank space
                Console.Write("Select a choice from the menu: ");
                userMenuChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(); // blank space
            }
            else if (userMenuChoice == 3) // Save Goals
            {
                goalManager.SaveGoals();

                Console.Clear();
                goalManager.Start();
                Console.WriteLine(); // blank space
                Console.Write("Select a choice from the menu: ");
                userMenuChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(); // blank space
            }
            else if (userMenuChoice == 4) // Load Goals
            {
                goalManager.LoadGoals();

                Console.WriteLine();
                Console.WriteLine();
                goalManager.Start();
                Console.WriteLine(); // blank space
                Console.Write("Select a choice from the menu: ");
                userMenuChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(); // blank space
            }
            else if (userMenuChoice == 5) // Record Event
            {
                goalManager.RecordEvent(); // user selects the goal they've worked on

                Console.Clear();
                goalManager.Start();
                Console.WriteLine(); // blank space
                Console.Write("Select a choice from the menu: ");
                userMenuChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(); // blank space
            }
        }
        if (userMenuChoice == 6) // Quit
        {
            Console.WriteLine("Ending program...");
            goalManager.ShowSpinner(2);
        }


    }
}