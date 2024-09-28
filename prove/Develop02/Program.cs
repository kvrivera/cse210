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
Meeting the core requirements makes your program eligible to 
receive a 93%. To receive 100% on the assignment, 
you need to show creativity and exceed these requirements.

Here are some ideas you might consider:

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

class Program
/* 
A Journal program that allows a user to write and display journal
entries.
Inputs: journal entries through the Write command
Outputs: journal entries displayed through Display command

Program ends when user selects Quit command
*/
{
    static void Main(string[] args)
    {
        /* 
        Display the menu
        1. Write
        2. Display
        3. Save
        4. Load
        5. Quit
        */
        Console.WriteLine("MyJournal Menu \n1. Write \n2. Display \n3. Save \n4. Load \n5. Quit \nWhat would you like to do? ");

        //Get input from user
        string menuChoice = Console.ReadLine();


    }

    static void WriteEntry()
    {
        // list of prompts to give the user
        /*
        List<string> prompts = new List<string>();

        // randomized prompts to show each time 
        Console.WriteLine($"");
        // grab the text entry from the user
        Console.ReadLine();
        */
    }

    static void DisplayEntries()
    {

    }

    static void SaveEntries()
    {

    }

    static void LoadEntries()
    {

    }

    static void QuitProgram()
    {

    }
}