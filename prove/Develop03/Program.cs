/*
Program Name: Scripture Memorizer
Author: Kat Rivera
Date: October 2 2024

Purpose:
    1. Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
    2. Accommodate scriptures with multiple verses, such as 
    "Proverbs 3:5-6".
    3. Clear the console screen and display the complete scripture, 
    including the reference and the text.
    4. Prompt the user to press the enter key or type quit.
    5. If the user types quit, the program should end.
    6. If the user presses the enter key (without typing quit), 
    the program should hide a few random words in the scripture, 
    clear the console screen, and display the scripture again.
    7. The program should continue prompting the user and hiding 
    more words until all words in the scripture are hidden.
    8. When all words in the scripture are hidden, the program 
    should end.
    9. When selecting the random words to hide, for the core 
    requirements, you can select any word at random, even if the
     word was already hidden. (As a stretch challenge, try to 
     randomly select from only those words that are not already 
     hidden.)
*/

using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // clear the console
        Console.Clear();

        // get the reference
        Reference reference1 = new Reference("John", 3, 16);

        // get the scripture text and reference string
        Scripture scripture = new Scripture(reference1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Console.WriteLine(scripture.GetScriptureDisplayText());


        //////Scripture scriptureVariable = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        // show the user the reference and scripture text
        ////Console.WriteLine($'{variable}');

        // prompt user to press enter key or type quit
        Console.Write("To begin, press the 'ENTER' key. \nTo quit the program, type 'quit' at any time.");
        string userInput = Console.ReadLine(); // accept input from user


        while (userInput != "quit")
        {
            if (userInput == "") // pressed "Enter" key (ie: returned an empty string)
            {
                if scripture.
                // syntax for slowly hiding words
                scripture.HideRandomWords(3);
                // get new display text for Scripture object
                string newDisplayText = scripture.GetScriptureDisplayText();
                // print to console
                Console.WriteLine(newDisplayText);

                Console.Write("To continue, press the 'ENTER' key. \nTo quit the program, type 'quit' at any time.");
                userInput = Console.ReadLine(); // accept input from user
            }
            else if (userInput == "quit")
            {
                Console.WriteLine("Ending the program. Have a nice day!");
                // end the program here
                break;
            }
            else if (scripture.CheckIfCompletelyHidden()) // if all of the words are hidden
            {
                Console.WriteLine("Great work! Ending the program...");
                // end program here
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please press Enter to continue or type \"quit\" to exit the program. ");
                userInput = Console.ReadLine(); // accept new input from user
            }
        }
        // if the user presses quit, the program should end
        // if the user presses enter, the program should begin


        Console.WriteLine();
        // when all of the words in the scripture are hidden, the program should end
        Console.WriteLine();
    }
}