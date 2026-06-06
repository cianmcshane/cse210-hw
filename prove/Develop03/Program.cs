using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: Multiple scriptures are stored and one is chosen at random.

        List<Scripture> cmScriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("John", 11, 35),
                "Jesus wept"
            ),

            new Scripture(
                new Reference("Doctrine and Covenants", 6, 36),
                "Look unto me in every thought doubt not fear not"
            ),

            new Scripture(
                new Reference("Psalm", 46, 10),
                "Be still and know that I am God"
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"
            )
        };

        Random cmRandom = new Random();

        Scripture cmScripture =
            cmScriptures[cmRandom.Next(cmScriptures.Count)];

        while (!cmScripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(cmScripture.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press Enter to continue or type quit: ");

            string cmInput = Console.ReadLine();

            if (cmInput.ToLower() == "quit")
            {
                return;
            }

            cmScripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(cmScripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("All words are hidden!");
    }
}

