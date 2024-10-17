///***
/// ABOVE AND BEYOND
/// I created an additional option in the program to take user input
/// in order to store a Reference and then a Scripture that the user
/// gives themselves. The user has a choice at the beginning of the
/// program to choose a predetermined scripture (basic requirements of
/// the assignment) or to input their own scripture.
///***

/*
Scripture Class
Purpose:
    Keeps track of both the reference and the text of the scripture verse(s)
    Can hide and get the rendered display of the text
    
*/

using System;
using System.Collections.Generic;
using System.Formats.Asn1;

class Scripture
{
    // VARIABLES
    private Reference _reference;
    private List<Word> _words;

    // CONSTRUCTORS
    /*
    NOTE:
    While the variable _word is a list of the words in the
    scripture's text, it would go against the principle of
    encapsulation (and would be a lot more work) to pass
    a list of words as a parameter for the constructor (see below).
    
    Instead: pass a string that is the text of the scripture
    verse(s) and then have the constructor convert that string
    to a list of Word objects.
    */
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>(); // initialize the list here

        // now turn the string scriptureText into separate Word objects
        // for each word and put them into a list
        string[] words = scriptureText.Split(" ");

        // add each word to the _words list
        foreach (string word in words)
        {
            Word individualWord = new Word(word); // create an instance of a new Word referenced by the variable 'text'
            _words.Add(individualWord); // add the new Word to the _words list
        }

    }
    // METHODS (ie: behaviours)
    public void HideRandomWords(int numberToHide) // randomly hide a number of words equal to numberToHide, that are not already hidden
    {
        // create an instance of Random
        Random random = new Random();
        // create an instance of a List<Word> to show only viible words
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            // if the word is visible, add it to the list of visible words
            if (!word.IsHidden() == true)
            {
                visibleWords.Add(word);
            }
        }

        if (visibleWords.Count < numberToHide) // if the number of words UNhidden is smaller than the number of words passed to hide (check parameters)...
        {
            numberToHide = visibleWords.Count; // then only hide as many words are left to hide
        }

        int numberHidden = 0;

        while (numberHidden < numberToHide)
        {
            // use Next method to get a random index
            // use Count to help Next run properly
            int index = random.Next(visibleWords.Count); // use Count method to get count of how many objects are in the visible words list
            Word wordToHide = visibleWords[index]; // this is an instance of Word that is currently in the visibleWords list
            wordToHide.HideWord(); // now hide this instance of Word in the original list (that's what this method/function does)

            visibleWords.RemoveAt(index); // this function will remove the word we just made not visible 
            // from the visibleWords list
            // so that the program doesn't select it again

            numberHidden++; // add 1 to the numberHidden count, so the loop stops at the set number of hidden words
        }
    }
    public string GetScriptureDisplayText()
    {
        string referenceDisplayText = _reference.GetReferenceDisplayText();
        // initialize a new string
        string scriptureDisplayText = $"{referenceDisplayText} \n"; // just the reference for now

        // print the list of Word objects from the _words list
        foreach (Word word in _words)
        {
            string wordDisplayText = word.GetWordDisplayText();
            scriptureDisplayText += wordDisplayText + " "; // add each Word's text to the end of the string
        }
        // but only the Word objects, nothing else
        return scriptureDisplayText;
    }
    public bool CheckIfCompletelyHidden() // check to see if all of the words are hidden, and if so, quit the program
    {
        bool completelyHidden = true; // use a boolean value here so that no matter
                                      // what happens with the while or foreach loop,
                                      // you will have a value and not an overstack error

        foreach (Word word in _words) // loop through each word
            if (!word.IsHidden()) // if this word is NOT hidden
            {
                completelyHidden = false;
                break; // exit the loop
            }
        return completelyHidden; // this returns the boolean value of true or false
                                 // as determined by the foreach loop and if statement
                                 // True unless proven otherwise by the loop
    }
}