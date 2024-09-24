using System;
using System.Globalization;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        // assign a variable for the user's name
        string userName = PromptUserName();

        // assign a variable for the user's favourite number
        int favNumber = PromptUserNumber();

        // assign a variable for the user's fav number squared
        int squaredNumber = SquareNumber(favNumber);

        // display the result and include the user's name
        DisplayTheResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        return userName
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        string favNumberText = Console.ReadLine();
        // parse the favNumber string to an integer
        int favNumber = int.Parse(favNumberText);

        return favNumber;
    }

    static int SquareNumber(int favNumber)
    {
        // in python you can use ** to calculate a number
        // to the power of another number, but you cannot
        // use ** in C# 
        int favNumberSquared = favNumber * favNumber;

        return favNumberSquared
    }

    static void DisplayTheResult(string name, int numberSquared)
    {
        Console.WriteLine($"{name}, the square of your number is {numberSquared}.");
    }
}