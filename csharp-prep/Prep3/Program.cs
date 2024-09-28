using System;

class Program
{
    static void Main(string[] args)
    {
        // to start we will have the user pick the magic number.
        // We will change this in future steps to have the 
        // computer generate a random number.
        // Console.Write("What is the magic number? ");
        // string userMagicNumberString = Console.ReadLine();
        // convert the user's magic number into an integer
        // int userMagicNumber = int.Parse(userMagicNumberString);

        // generate a random number to become the magic number
        // create an instance of teh Random class
        Random random = new Random();

        // Next() method generates a random integer
        // set the new variable to the magicNumber
        // parameters are (lowest, highest) (1-199) as shown below
        int magicNumber = random.Next(1, 200);

        // set initial value for userGuess to a number that's not possible in the loop
        int userGuess = -1;

        // use a do while loop to ask the user what their guess is
        // and continue asking them until they guess it correctly
        while (userGuess != magicNumber)
        {
            // have the user try to guess the magic number
            Console.Write("What is your guess? ");
            string userGuessString = Console.ReadLine();
            // convert user's guess to an int
            // don't specify the data type beforehand because it is not a new variable
            // and that will mess it up
            userGuess = int.Parse(userGuessString);

            // use an if statement to determine if the user needs to 
            // guess higher or lower, or to tell them if they guessed 
            // correctly

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number.");
            }
        }
    }
}