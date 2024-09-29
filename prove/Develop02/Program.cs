/*
The assignment is as follows:

Write a new entry - Show the user a random prompt (from a list that 
you create), and save their response, the prompt, and the date as 
an Entry.
Display the journal - Iterate through all entries in the journal 
and display them to the screen.
Save the journal to a file - Prompt the user for a filename and 
then save the current journal (the complete list of entries) to 
that file location.
Load the journal from a file - Prompt the user for a filename and 
then load the journal (a complete list of entries) from that file. 
This should replace any entries currently stored the journal.
Provide a menu that allows the user choose these options
Your list of prompts must contain at least five different prompts. 
Make sure to add your own prompts to the list, but the following 
are examples to help get you started:
Who was the most interesting person I interacted with today?
What was the best part of my day?
How did I see the hand of the Lord in my life today?
What was the strongest emotion I felt today?
If I had one thing I could do over today, what would it be?
*/

/*
Contain classes for the major components in the program.
Contain at least two classes in addition to the Program class.
Demonstrate the principle of abstraction by using member variables 
and methods appropriately.
*/

/*
Saving your file as a .csv file requires you to handle commas and 
quotes in the content appropriately. At this point, you can ignore 
that and just choose a symbol for a separator that you think is 
unlikely to show up in the content (such as | or ~ or ~|~).
You do not need to store the date as an actual C# DateTime object 
in your class or in the file. You can simply store it as a string.
*/

/*
Above and Beyond Ideas to consider:

Think of other problems that keep people from writing in their 
journal and address one of those.
Save other information in the journal entry.
Improve the process of saving and loading to save as a .csv file 
that could be opened in Excel (make sure to account for quotation 
marks and commas correctly in your content.
Save or load your document to a database or use a different library 
or format such as JSON for storage.
Report on what you have done to exceed requirements by adding a 
description of it in a comment in the Program.cs file.
*/

/* 
ABOVE AND BEYOND:
Create an additional menu option called "Create Prompt"
Allow user to input a prompt
Add the prompt to the prompt list in PromptGenerator
Reason this is so useful/problem this solves:
    Users often have things they want to eventually write about,
    and this allows them to create a 'to-do' list of things to
    write about, in order to not forget special moments they may
    not be able to write about in the moment. This is a particular
    'problem' I want to find a resolution for in my own life. 
    Voila.
*/
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;

class Program
/* 
A Journal program that allows a user to write and display journal
entries.
Inputs: journal entries through the Write command
Outputs: journal entries displayed through Display command

Program ends when user selects Quit command 5
*/
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        /* 
        Display the menu
        1. Write
        2. Display
        3. Save
        4. Load
        5. Add your own personalized prompt
        6. Quit
        */
        Console.WriteLine("MyJournal Menu \n\n1. Write \n2. Display \n3. Save \n4. Load \n5. Add a personalized prompt \n6. Quit \n\nWhat would you like to do? ");

        //Get input from user
        string menuChoiceString = Console.ReadLine();
        // convert string to integer
        int menuChoice = int.Parse(menuChoiceString);
        // use a do while loop to ensure the menu continues
        // to show up and run for the user as long as they
        // have not input 5 (ie: quit)

        while (menuChoice != 6)
        {
            // use if else statements to run through the program
            // based off of the user's menu choice input
            if (menuChoice == 1) // user selected WRITE
            {
                // initiate a new Entry
                Entry entry = new Entry();

                // get the current date and time
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();

                // get user their prompt
                PromptGenerator prompt = new PromptGenerator(); // create new instance of promptgenerator
                entry._promptText = prompt.GetRandomPrompt(); // generate random prompt, assign it to a new variable
                Console.WriteLine(entry._promptText); // display the prompt to the user

                // get entry text from user
                entry._entryText = Console.ReadLine();

                // add entry to journal's _entries list
                journal.AddEntry(entry);
            }

            else if (menuChoice == 2) // user selected DISPLAY
            {
                // use a foreach loop to display all entries
                foreach (Entry e in journal._entries)
                {
                    e.Display(); // display the whole entry
                }
            }

            else if (menuChoice == 3) // user selected SAVE
            {
                // get the file name that the user wants to give their file
                Console.Write("What name will you give your file? ");
                string file = Console.ReadLine();

                // save the entry to the file
                foreach (Entry entry in journal._entries)
                {
                    journal.SaveToFile(file); // the user's chosen file name is in the brackets, passed through the method
                }
            }

            else if (menuChoice == 4) // user selected LOAD
            {
                Console.Write("What is the name of the file you would like to load? ");
                // get the file name from the user
                string fileName = Console.ReadLine();
                // open the file with the name that the user gave
                journal.LoadFromFile(fileName);
            }

            else if (menuChoice == 5) // user selected PERSONALIZED PROMPT
            {
                PromptGenerator userInput = new PromptGenerator();

                // get user to input their own personalized prompt
                Console.Write("Enter your own personalized prompt to add to a list of randomized prompts you can receive. ");
                string personalizedPrompt = Console.ReadLine();

                userInput.AddToPrompts(personalizedPrompt);

                // check to see if they all display
                userInput.DisplayAllPrompts();
            }

            // Now ask the user what they want to do again,
            // and get a new input value for menuChoice
            Console.WriteLine("MyJournal Menu \n1. Write \n2. Display \n3. Save \n4. Load \n5. Add personalized prompt \n6. Quit \n\nWhat would you like to do? ");

            //Get input from user
            menuChoiceString = Console.ReadLine();
            // convert string to integer
            menuChoice = int.Parse(menuChoiceString);
        }

        // if statement for when the user inputs 5 (ie: quit)
        if (menuChoice == 6)
        {
            Console.WriteLine("See you next time."); // now the program closes
        }
    }
}