using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq; // this allows us to use the .Max() method to find the highest number in a list

/* 
        Here are some notes for this assignment:

        List<string> words = new List<string>();
        // adding words to C# is the same as 
        // words.append("phone") in python
        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        // get the size of the list with Count property like so:
        Console.WriteLine(words.Count);
        // in python this looks like print(len(words))

        // to iterate through a list we can use a foreach loop
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        // in python this looks like:
        // for word in words:
        //      print(word)

        // to access items by their index
        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
        // in python this looks like:
        // for i in range (len(words)):
        //      print(words[i])

        End of notes
        */
// Ask the user for a series of numbers, and append each one
// to a list. Stop when they enter the number 0.        
class Program
{
    static void Main(string[] args)
    {
        //set up list for user's numbers
        // put the brackets after the new list you create
        // because it is an object
        List<int> numbers = new List<int>();


        // set a initial value for userNumber so we can use it later
        int userNumber = 99999;

        // Introduce program to user, giving instructions for user
        Console.Write("Enter a series of numbers, one at a time. ");
        Console.WriteLine("Type 0 when finished.");

        // use a do while loop to allow the user to enter in a
        // series of numbers, stopping when they enter 0
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                // add the user's given number to the list
                numbers.Add(userNumber);
            }
            else if (userNumber == 0)
            {
                Console.WriteLine("All numbers received. Calculating ...");
            }

        }


        // when the user enters 0 the following code will be executed

        // calculate the sum of all of the given numbers
        int listSum = 0;
        foreach (int number in numbers)
        {
            listSum += number;
        }

        /*
        // Using System.Linq and .Sum()
        int listSum = numbers.Sum();
        */
        Console.WriteLine($"The sum of the given numbers is: {listSum}");

        // calculate the average of all of the given numbers
        // use the sum you just calculated above so you don't have to do all that work again

        //determine the number of items in the list
        int numberCount = numbers.Count;
        // now find the average by dividing the sum by the number of items in the list
        // we need to first make this data input type a float
        // otherwise the computer will do int division which will not return the decimal
        // that it should return to accurately given the average of the list's numbers

        // you make one of the numbers in the division equation a float as well
        // to tell the computer that we need the decimal that it should return
        float average = ((float)listSum) / numberCount;
        // now tell the user
        Console.WriteLine($"The average of the given numbers if {average}");

        // determine the largest number in the list
        // using System.Linq namespace (top of code)
        // using .Max() method
        int largestNumber = numbers.Max();
        Console.WriteLine($"The largest number is {largestNumber}");
        /*
        Could also use a for loop as follows
        // First pick the index of the first number of the list
        int largestNumber = numbers[0]
        
        // now loop through the list to compare the other numbers to the first number
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        */
    }
}