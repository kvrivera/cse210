/*
Your program must do the following:

Have a menu system to allow the user to choose an activity.

Each activity should start with a common starting message that 
provides the name of the activity, a description, and asks for and 
sets the duration of the activity in seconds. Then, it should tell 
the user to prepare to begin and pause for several seconds.

Each activity should end with a common ending message that tells the 
user they have done a good job, and pause and then tell them the 
activity they have completed and the length of time and pauses for 
several seconds before finishing.

Whenever the application pauses it should show some kind of animation 
to the user, such as a spinner, a countdown timer, or periods being 
displayed to the screen.

The interface for the program should remain generally true to the one 
shown in the video demo.

*/



// ABOVE AND BEYOND: In the Listing class:
// Display the list that the user generated, for them to reflect on further. The user could screenshot it or copy the text and save it to a journal entry if they wished outside of the app.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); // Clear the console

        Console.WriteLine("Welcome to MyMindfulnessApp.");
        Console.WriteLine();
        Console.WriteLine("Please choose from one of the following activities to practice mindfulness.");
        Console.WriteLine("1. Breathing Activity \n2. Reflecting Activity\n3.Listing Activity\n4.Quit program");
        Console.WriteLine("Type the number of the activity you would like to participate in. ");
        int userMenuChoice = int.Parse(Console.ReadLine()); // User input (menu choice) stored as variable

        while (userMenuChoice != 4) // While the user does not select 4 (ie: quit)
        {
            // syntax
            if (userMenuChoice == 1)
            {
                // syntax
                Breathing breathingActivity = new Breathing();
                breathingActivity.Run();
            }
            else if (userMenuChoice == 2)
            {
                // syntax
                Reflecting reflectingActivity = new Reflecting();
                reflectingActivity.Run();
            }
            else if (userMenuChoice == 3)
            {
                // syntax
                Listing listingActivity = new Listing();
                listingActivity.Run();
            }
            else
            {
                break;
            }

            Console.WriteLine("What would you like to do now?"); // Repeat the menu for the user to choose their next activity or quit
            Console.WriteLine("1. Breathing Activity \n2. Reflection Activity\n3.Listing Activity\n4.Quit program");
            Console.WriteLine("Type the number of the activity you would like to participate in. ");
            userMenuChoice = int.Parse(Console.ReadLine()); // Get user input again to reset value for the while loop
        }
    }
}