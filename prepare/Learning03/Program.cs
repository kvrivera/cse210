using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        // verify that CONSTRUCTORS in Fraction class work
        // initialize an example of each of the constructors

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(2, 5);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());



        /*
        // If a user wants to interact with the program:
        Console.Write("Numerator: ");
        string numeratorString = Console.ReadLine();
        int numerator = int.Parse(numeratorString);
        Console.Write("Denominator: ");
        string denominatorString = Console.ReadLine();
        int denominator = int.Parse(denominatorString);
        */
    }
}