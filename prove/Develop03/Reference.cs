/*
Reference Class
Purpose:
    Keeps track of the book, chapter and verse information
*/

using System.Net.Http.Headers;

class Reference
{
    // VARIABLES
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    // CONSTRUCTORS
    // 1 verse
    public Reference(string book, int chapter, int verse)
    {
        GetReferenceDisplayText(book, chapter, verse);
    }
    // 2 verses
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        GetReferenceDisplayText(book, chapter, verse, endVerse);
    }
    // METHODS (ie: behaviours)
    // use method overloading to show what happens with different amounts of parameters passed
    private string GetReferenceDisplayText(string book, int chapter, int verse) // returns a string of "book chapter:verse"
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        string referenceDisplayText = $"{_book} {_chapter}:{_verse}";
        return referenceDisplayText;
    }
    public string GetReferenceDisplayText(string book, int chapter, int verse, int endVerse) // returns a string of "book chapter:verse-endVerse"
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        string referenceDisplayText = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        return referenceDisplayText;
    }


}
