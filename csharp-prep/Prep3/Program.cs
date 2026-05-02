using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int cmNumber = randomGenerator.Next(1, 11);

        int cmGuess = 0;

        Console.WriteLine("What is the magic number? ");

        while (cmGuess != cmNumber)
        {
            Console.WriteLine("What's your guess?");
            string cmStringGuess = Console.ReadLine();
            cmGuess = int.Parse(cmStringGuess);

            if (cmGuess > cmNumber)
            {
                Console.WriteLine("too high");
            }
            else if (cmGuess < cmNumber)
            {
                Console.WriteLine("too low");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
    
        }

    }
}