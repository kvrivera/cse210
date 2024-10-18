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
    private int _length; // length in seconds
    private int _totalNumberOfComments; // number of comments on video
    private List<Comment> _comments; // list of Comments for this video

    // CONSTRUCTOR(S)
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
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
    public void AddCommentToList(Comment comment)
    {
        _comments.Add(comment);
    }
    private int NumberOfComments() // return the number of comments a video has
    {
        _totalNumberOfComments = _comments.Count;
        return _totalNumberOfComments;
    }

    public string FullVideoData()
    {
        return $"\"{_title}\" by {_author} | {_length} seconds | Comments ({NumberOfComments()})";
    }
}
