using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your first name?");
        string cmfirstName = Console.ReadLine();
        Console.WriteLine("What's your last name?");
        string cmlastName = Console.ReadLine();
        Console.WriteLine($"Your name is {cmlastName}, {cmfirstName} {cmlastName}");
    }
}