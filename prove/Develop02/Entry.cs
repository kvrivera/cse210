using System.Collections.Generic;

public class Entry
/*
What this class does:
    Represents a single journal entry
Methods: 
    Display() : void
Variables: 
    _date : string
    _promptText : string
    _entryText : string
*/
{
    public string _date;
    public string _promptText;
    public string _entryText;

    // create a method to display the entry back with 
    // the date and prompt text included
    public void Display()
    {
        Console.WriteLine($"Date: {_date} \n{_promptText} \n{_entryText}");
    }
}