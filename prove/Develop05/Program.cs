using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager cmManager = new GoalManager();
        
        bool done = false;

        while (done == false)
        {
            Console.WriteLine("");
            Console.WriteLine($"You have {cmManager.GetScore()} points!");
            Console.WriteLine("");
            Console.WriteLine("   1-Create new Goal");
            Console.WriteLine("   2-List Goals");
            Console.WriteLine("   3-Save Goals");
            Console.WriteLine("   4-Load Goals");
            Console.WriteLine("   5-Record Event");
            Console.WriteLine("   6-Quit");
            Console.WriteLine("");
            Console.WriteLine("Select a choice from the menu: ");
            Console.WriteLine("");


            string _cmChoice = Console.ReadLine();

            if (_cmChoice == "1")
            {
                cmManager.CreateGoal();
            }
            else if (_cmChoice == "2")
            {
                cmManager.ListGoals();
            }
            else if (_cmChoice == "3")
            {
                cmManager.SaveGoals();
            }
            else if (_cmChoice == "4")
            {
                cmManager.LoadGoals();
            }
            else if (_cmChoice == "5")
            {
                cmManager.RecordGoalCompletion();
            }
            else if (_cmChoice == "6")
            {
                done = true;
            }
            else
            {
                Console.WriteLine("Invalid Response, please try again.");
                Console.ReadLine();
            }
        }
    }
}