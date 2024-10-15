/*
Purpose:
    member variables:
        commenter (name of person who made the comment)  
        comment text (what the comment says)  
*/

using System;
class Comment
{
    // MEMBER VARIABLES
    private string _commenter;
    private string _commentText;

    // CONSTRUCTOR(S)
    public Comment(string commenter, string commentText)
    {
        _commenter = commenter;
        _commentText = commentText;
    }

    // MEMBER METHOD(S)
    public string GetCommenterName() // return the value of the commenterName private member variable
    {
        return _commenter;
    }

    public string GetCommentText() // return the value of the commentText private member variable 
    {
        return _commentText;
    }

    public string GetCommentDisplayText() // return what the comment would look like with author and text
    {
        return $"{_commenter} -- {_commentText}";
    }
}