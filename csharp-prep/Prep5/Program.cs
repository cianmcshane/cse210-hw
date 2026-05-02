using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string cmName = PromptUserName();
        int cmNumber = PromptUserNumber();
        PromtUserBirthYear(out int cmBirthYear);
        int cmSquare = SquareNumber(cmNumber);

        DisplayResult(cmName, cmSquare, cmBirthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string cmName = Console.ReadLine();

        return cmName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int cmNumber = int.Parse(Console.ReadLine());

        return cmNumber;
    } 

    static void PromtUserBirthYear(out int cmBirthYear)
    {
        Console.Write($"Please enter the year you were born: ");
        cmBirthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int cmNumber)
    {
        int cmSquare = cmNumber * cmNumber;

        return cmSquare;
    }

    static void DisplayResult(string cmName, int cmSquare, int cmBirthYear)
    {
        Console.WriteLine($"{cmName}, the square of your number is {cmSquare}.");
        Console.WriteLine($"{cmName}, you will turn {2026 - cmBirthYear} years old this year.");
    }
}