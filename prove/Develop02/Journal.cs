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
        // syntax to add the entry to the _entries list
    }

    public void DisplayAll()
    {
        // syntax to display all entries
    }


    public void SaveToFile(string file) // should this be void or something else?
    {
        // syntax to save the user string to file
    }

    public void LoadFromFile(string file) // should this be void?
    {
        // syntax to load entry from file
    }
}