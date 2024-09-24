using System;
using System.Diagnostics;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        // this is the main function, where your program
        // will actually perform

        // 1. get the user's grade as an input (read)
        // and assign it a variable
        int grade = GetGrade();

        string letterGrade = DetermineLetterGrade(grade);

        Console.WriteLine($"Your letter grade is {letterGrade}.");

    }

    static int GetGrade()
    {
        Console.Write("What is your grade (number only)? ");
        string gradeText = Console.ReadLine();
        int grade = int.Parse(gradeText);

        return grade;
    }

    static string DetermineLetterGrade(int grade)
    {
        if (grade >= 90)
        {
            string letterGrade = "A";
            Console.WriteLine($"You have passed!");
            return letterGrade;
        }
        else if (grade >= 80)
        {
            string letterGrade = "B";
            Console.WriteLine($"You have passed!");
            return letterGrade;
        }
        else if (grade >= 70)
        {
            string letterGrade = "C";
            Console.WriteLine($"You have passed!");
            return letterGrade;
        }
        else if (grade >= 60)
        {
            string letterGrade = "D";
            Console.WriteLine($"You have failed!");
            return letterGrade;
        }
        else if (grade < 60)
        {
            string letterGrade = "F";
            Console.WriteLine($"You have failed!");
            return letterGrade;
        }
        else
        {
            string letterGrade = "error";
            Console.WriteLine("You have entered in a value that's not on our grade scale!");
            return letterGrade;
        }
    }
}