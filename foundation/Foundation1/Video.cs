/*
Purpose:
    member variables:
        title
        author
        length (seconds) of the video
    member methods (functions):
        store a list of Comments
*/

using System;

class Video
{
    // MEMBER VARIABLES
    private string _title; // title of the video
    private string _author; // author of the video
    private int _length; // seconds
    private List<Comment> _comments; // list of Comments for this video

    // CONSTRUCTOR(S)
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    // MEMBER METHOD(S)
    // getter for _title
    private string GetTitle()
    {
        return _title;
    }
    // getter for _author
    private string GetAuthor()
    {
        return _author;
    }
    // getting for _length
    private int GetLength()
    {
        return _length;
    }


    public string FullVideoData()
    {
        return $"\"{_title}\" by {_author} | {_length} seconds";
    }
}
