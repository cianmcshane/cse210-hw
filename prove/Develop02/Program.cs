using System;

class Program
{
    static void Main(string[] args)
    {
        Journal cmJournal = new Journal();

        string cmChoice = "";
        do
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to journal program!");
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Which one would you like to select?");
            cmChoice = Console.ReadLine();
        
            if (cmChoice == "1")
            {
                cmJournal._cmaddEntry();
            }
            else if (cmChoice == "2")
            {
                cmJournal._cmdisplay();
            }
            else if (cmChoice == "3")
            {
                cmJournal._cmload();
            }
            else if (cmChoice == "4")
            {
                cmJournal._cmsave();
            }
            else if (cmChoice == "5")
            {
                Console.WriteLine("Bye!");
            }
            else
            {
                Console.WriteLine("Invalid response please try again.");
            }
        } while (cmChoice != "5");

    }
}