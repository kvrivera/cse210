using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

public class Journal
/*
What this class does:
    Adds an entry
    Displays all entries when called upon to do so
    Saves user input (string) to a file
    Loads entries from a file
Methods:
    AddEntry(newEntry : Entry) : void
    DisplayAll() : void
    SaveToFile(file : string)
    LoadFromFile(file : string)
Variables:
    _entries : List<Entry>
*/
{
    // create a list of entries to be added to every
    // time the user writes a new entry
    public List<Entry> _entries = new List<Entry>();

    // create a method to add an entry to the list of 
    // entries in the above code
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        // use a foreach loop to display all journal entries
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string file)
    {
        // explain to user what's going on
        Console.WriteLine("Saving your journal file...");

        // convert the file name that the user gave us to a string variable
        string fileName = file;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // ask the computer to read all of the lines of the file
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                // select a separator character
                // . makes sense here because it could be split by sentences,
                // which makes the most sense to me right now
                string[] parts = line.Split(".");
            }
        }





    }

    public void LoadFromFile(string file)
    {
        // syntax to load entry from file
    }
}