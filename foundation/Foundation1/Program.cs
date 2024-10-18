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
        // Console.Clear(); // clear the console

        Console.WriteLine("Your videos:");

        ///// video1
        Video video1 = new Video("Coding 101", "Bob Seger", 543); // create a Video instance
        // comment1
        Comment video1Comment1 = new Comment("Cynthia Marshall", "This changed my life. Thanks a lot.");
        video1.AddCommentToList(video1Comment1); // add comment to the list of comments for this video
        string v1C1Text = video1Comment1.GetCommentDisplayText();

        // comment2
        Comment video1Comment2 = new Comment("Ashleigh Vanderdoes", "You're a genius. Can't wait for the next video!!");
        video1.AddCommentToList(video1Comment2); // add comment to list of video1 comments
        string v1C2Text = video1Comment2.GetCommentDisplayText();

        // comment3
        Comment video1Comment3 = new Comment("Hilly Gregson", "I'm exciting to learn more.");
        video1.AddCommentToList(video1Comment3); // add comment to list of comments for video1
        string v1C3Text = video1Comment3.GetCommentDisplayText();

        string fullVideoData1 = video1.FullVideoData();
        Console.WriteLine(fullVideoData1); // "Title" by Author | 00 seconds | Comments (#number)
        Console.WriteLine($"{v1C1Text} \n{v1C2Text} \n{v1C3Text}"); // print comments under video data

        // white space
        Console.WriteLine();
        Console.WriteLine();

        ///// video2
        Video video2 = new Video("Coding In a Nutshell", "Billy Joel", 234); // create a Video instance
        // comment1
        Comment video2Comment1 = new Comment("Belly Blue", "This video is totally rad.");
        video2.AddCommentToList(video2Comment1); // add comment to the list of comments for this video
        string v2C1Text = video2Comment1.GetCommentDisplayText();

        // comment2
        Comment video2Comment2 = new Comment("Georgie Washingtonious", "I am subscribing to your channel IMMEDIATELY!");
        video2.AddCommentToList(video2Comment2); // add comment to list of video1 comments
        string v2C2Text = video2Comment2.GetCommentDisplayText();

        // comment3
        Comment video2Comment3 = new Comment("Bobbie Brown", "Dude your videos help me learn so much. Thanks bruh.");
        video2.AddCommentToList(video2Comment3); // add comment to list of comments for video1
        string v2C3Text = video2Comment3.GetCommentDisplayText();

        string fullVideoData2 = video2.FullVideoData();
        Console.WriteLine(fullVideoData2); // "Title" by Author | 00 seconds | Comments (#number)
        Console.WriteLine($"{v2C1Text} \n{v2C2Text} \n{v2C3Text}"); // print comments under video data

        // white space
        Console.WriteLine();
        Console.WriteLine();


        // video3
        Video video3 = new Video("Code My Life", "Matrix Guy", 0989); // create a Video instance
        // comment1
        Comment video3Comment1 = new Comment("Fred Tappington", "Love it.");
        video3.AddCommentToList(video3Comment1); // add comment to the list of comments for this video
        string v3C1Text = video3Comment1.GetCommentDisplayText();

        // comment2
        Comment video3Comment2 = new Comment("Victor Krum", "Better than Quidditch!");
        video3.AddCommentToList(video3Comment2); // add comment to list of video1 comments
        string v3C2Text = video3Comment2.GetCommentDisplayText();

        // comment3
        Comment video3Comment3 = new Comment("CodingNewb123", "WOWWWW <3 <3.");
        video3.AddCommentToList(video3Comment3); // add comment to list of comments for video1
        string v3C3Text = video3Comment3.GetCommentDisplayText();

        string fullVideoData3 = video3.FullVideoData();
        Console.WriteLine(fullVideoData3); // "Title" by Author | 00 seconds | Comments (#number)
        Console.WriteLine($"{v3C1Text} \n{v3C2Text} \n{v3C3Text}"); // print comments under video data

        // white space
        Console.WriteLine();
        Console.WriteLine();
    }
}