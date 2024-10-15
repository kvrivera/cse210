/*
Assignment description:
Assume you have been hired by a company that monitors product 
awareness by tracking the placement of their products in YouTube 
videos. They want you to write a program that can help them work 
with the tens of thousands of videos they have identified as well 
as the comments on them.

Write a program to keep track of YouTube videos and comments 
left on them. As mentioned this could be part of a larger 
project to analyze them, but for this assignment, you will 
only need to worry about storing the information about a video 
and the comments.

Purpose:
    Create 3-4 videos
    Set the appropriate values
    Add a list of 3-4 comments (with the commenter's name and text)
    Put each of these videos in a list

    Then...
    Program will iterate through the list of videos
    For each video in the list display the titel, author, length, 
        number of comments (from the method), and then list out 
        all of the comments for that video.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); // clear the console

        Console.WriteLine("Your videos:");

        ///// video1
        Video video1 = new Video("Coding 101", "Bob Seger", 543); // create a Video instance
        string fullVideoData1 = video1.FullVideoData(); // generate the video name and info (a string)
        Console.WriteLine(fullVideoData1); // "Title" by Author | 00 seconds
        // comment1
        Comment video1Comment1 = new Comment("Belly Blue", "This video is totally rad.");
        string v1C1Text = video1Comment1.GetCommentDisplayText();
        video1.
        // comment2
        Comment video1Comment2 = new Comment("Georgie Washingtonious", "I am subscribing to your channel IMMEDIATELY!");
        string v1C2Text = video1Comment2.GetCommentDisplayText();
        // comment3
        Comment video1Comment3 = new Comment("Bobbie Brown", "Dude your videos help me learn so much. Thanks bruh.");
        string v1C3Text = video1Comment3.GetCommentDisplayText();

        ///// video2
        Video video2 = new Video("Your Morning Java(script)", "Maria Codesalot", 27); // create a Video instance
        string fullVideoData2 = video2.FullVideoData(); // generate the video name and info (a string)
        Console.WriteLine(fullVideoData2); // "Title" by Author | 00 seconds

        // video3
        Video video3 = new Video("Coding on the High Seas", "SkalywagzPirateCoder100", 725); // create a Video instance
        string fullVideoData3 = video3.FullVideoData(); // generate the video name and info (a string)
        Console.WriteLine(fullVideoData3); // "Title" by Author | 00 seconds

        /////
        // add 3-4 Comments to a list belonging to each video



    }
}