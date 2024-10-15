/*
Word Class
Purpose:
    Keeps track of a single word and whether it is shown or hidden
*/

using System;
using System.Collections.Generic;

class Word
{
    // VARIABLES
    private string _text;
    private bool _isHidden;

    // CONSTRUCTOR
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // you set this to visible by default, it does not need to be passed as a parameter
    }
    // METHODS (ie: behaviours)
    public void HideWord() // hide a word that is not yet hidden
    {
        if (_isHidden == false)
        {
            _text = "___"; // change the text to ___
            _isHidden = true;
        }
    }
    void ShowWord()
    {
        //syntax
    }
    public bool IsHidden() // check to see if a word is hidden or not
    {
        if (_text == "___")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetWordDisplayText() // return the display text of a word, whether it is the word with letters or the hidden ____ version
    {
        if (IsHidden() == true)
        {
            return "___";
        }
        else
        {
            return _text;
        }
    }
}
