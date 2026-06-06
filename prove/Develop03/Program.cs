using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> cmScriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"
            ),

            new Scripture(
                new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God"
            ),
            new Scripture(
                new Reference("John", 11, 35),
                "Jesus wept."
            ),
            new Scripture(
                new Reference("Psalm", 46, 10),
                "Be still and know that I am God.")
        };

        Random cmRandom = new Random();
        Scripture cmScripture = cmScriptures[cmRandom.Next(cmScriptures.Count)];

        while (!cmScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(cmScripture.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press Enter to continue or type quit: ");
            string cmInput = Console.ReadLine();

            if (cmInput.ToLower() == "quit")
            {
                break;
            }

            cmScripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(cmScripture.GetDisplayText());
    }
}

