using System;

class Program
{
    static void Main(string[] args)
    {
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
                goalManager.Start();
                Console.WriteLine(); // blank space

                Console.Write("Select a choice from the menu: ");
                userMenuChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(); // blank space

            }

            else if (userMenuChoice == 2) // List Goals user has already set
            {
                goalManager.ShowGoalList(); // prints a numbered list of goals with their descriptions

                goalManager.Start();
                Console.WriteLine(); // blank space
                Console.Write("Select a choice from the menu: ");
                userMenuChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(); // blank space
            }
            else if (userMenuChoice == 3) // Save Goals
            {
                goalManager.SaveGoals();

                goalManager.Start();
                Console.WriteLine(); // blank space
                Console.Write("Select a choice from the menu: ");
                userMenuChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(); // blank space
            }
            else if (userMenuChoice == 4) // Load Goals
            {
                goalManager.LoadGoals();

                goalManager.Start();
                Console.WriteLine(); // blank space
                Console.Write("Select a choice from the menu: ");
                userMenuChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(); // blank space
            }
            else if (userMenuChoice == 5) // Record Event
            {
                goalManager.RecordEvent(); // user selects the goal they've worked on

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
        }


    }
}