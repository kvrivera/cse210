///***
/// ABOVE AND BEYOND
/// I created an additional option in the program to take user input
/// in order to store a Reference and then a Scripture that the user
/// gives themselves. The user has a choice at the beginning of the
/// program to choose a predetermined scripture (basic requirements of
/// the assignment) or to input their own scripture.
///***
///
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
        // declare variables so that they work outside of if statements
        Scripture scripture = null;

        // clear the console
        Console.Clear();

        // give the user the following 2 options:
        // either they use a pre-loaded Scripture or they input their own scripture and reference

        Console.WriteLine("Welcome to The Scripture Memorizer. Would you like to memorize \n a preloaded scripture, or create your own?");
        Console.Write("Type 1 for preloaded, or 2 for creating your own. ");
        string userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            // get the reference
            Reference reference1 = new Reference("John", 3, 16);

            // get the scripture text and reference string
            scripture = new Scripture(reference1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
            Console.WriteLine(scripture.GetScriptureDisplayText());
        }

        else if (userChoice == "2")
        {
            // get reference for scripture passage from user
            // create variables to pass through the Reference object instance later
            Console.WriteLine("First we will get the reference for your scripture passage.");
            Console.Write("Enter the BOOK: ");
            string userBook = Console.ReadLine();

            Console.Write("Enter the CHAPTER: ");
            string userChapterString = Console.ReadLine();
            int userChapter = int.Parse(userChapterString); // parse to int

            Console.Write("Enter the FIRST VERSE in the passage.");
            string userFirstVerseString = Console.ReadLine();
            int userFirstVerse = int.Parse(userFirstVerseString); // parse to int

            Console.Write("Enter the LAST VERSE in the passage. If there is only 1 verse, type 0: ");
            string userLastVerseString = Console.ReadLine();
            int userLastVerse = int.Parse(userLastVerseString); // parse to int

            // get the Scripture object text from user
            Console.WriteLine("Now we will get the passage. Please type only words,");
            Console.WriteLine("and do not include verse numbers. Press your ENTER button to submit.");
            Console.Write("The PASSAGE: ");
            string userScripturePassage = Console.ReadLine();

            // create the Reference object
            if (userLastVerse != 0) // > 1 verses
            {
                Reference reference1 = new Reference(userBook, userChapter, userFirstVerse, userLastVerse);

                // create the Scripture object using the Reference object and the user's
                // scripture passage input (userScripturePassage)
                scripture = new Scripture(reference1, userScripturePassage);
                Console.WriteLine(scripture.GetScriptureDisplayText());
            }
            else if (userLastVerse == 0) // == 1 verse
            {
                Reference reference1 = new Reference(userBook, userChapter, userFirstVerse);
                scripture = new Scripture(reference1, userScripturePassage);
                Console.WriteLine(scripture.GetScriptureDisplayText());
            }
        }

        // prompt user to press enter key or type quit
        Console.Write("To begin, press the 'ENTER' key. \nTo quit the program, type 'quit' at any time.");
        string userInput = Console.ReadLine(); // accept input from user


        while (userInput != "quit")
        {
            if (userInput == "") // pressed "Enter" key (ie: returned an empty string)
            {
                bool scriptureIsHidden = scripture.CheckIfCompletelyHidden();
                if (scriptureIsHidden == true) // if all words are hidden 
                {
                    Console.WriteLine("Great job! All done. Ending program...");
                    break; // end the program now
                }

                else if (scriptureIsHidden == false)  // if not all words are hidden
                {
                    scripture.HideRandomWords(3); // syntax for slowly hiding words
                    // get new display text for Scripture object
                    string newDisplayText = scripture.GetScriptureDisplayText();
                    // print to console
                    Console.WriteLine(newDisplayText);

                    Console.Write("To continue, press the 'ENTER' key. \nTo quit the program, type 'quit' at any time.");
                    userInput = Console.ReadLine(); // accept input from user
                }

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