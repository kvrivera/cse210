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

        // now turn the string scriptureText into separate Word objects
        // for each word and put them into a list

        // split the scriptureText string into individual words
        string[] words = scriptureText.Split(" ");

        // add each word to the _words list
        foreach (string word in words)
        {
            Word _text = new Word(word);
            _words.Add(_text);
        }
    }
    // METHODS (ie: behaviours)
    void HideRandomWords(int numberToHide) // randomly hide a number of words equal to numberToHide, that are not already hidden
    {
        // create an instance of Random
        Random random = new Random();

        int numberHidden = 0;

        while (numberHidden < numberToHide)
        {
            // use Next method to get a random index
            // use Count to help Next run properly
            int index = random.Next(_words.Count); // use Count method to get count of how many objects are in the list

            // check if the word is already hidden
            if (!_words[index].IsHidden())
            {
                _words[index].HideWord();
                numberHidden++; // add 1 to the numberHidden count, so the loop stops at 3 hidden words
            }
        }


    }
    string GetScriptureDisplayText() // display text refers to text with some words shown, some hidden
    {
        // syntax
        return "";
    }
    bool CheckIfCompletelyHidden() // check to see if all of the words are hidden, and if so, quit the program
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
                                 // True unless proven otherwise by the loop and if
    }
}