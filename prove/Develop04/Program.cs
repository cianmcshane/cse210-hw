using System;

class Program
{
    
    static void Main(string[] args)
    {
        bool cmRunning = true;
        while (cmRunning == true) {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("     1-Start breathing activity");
            Console.WriteLine("     2-Start reflection activity");
            Console.WriteLine("     3-Start listing activity");
            Console.WriteLine("     4-Quit");
            Console.WriteLine("Select a number from the menu: ");

            string cmChoice = Console.ReadLine();

            if (cmChoice == "1")
            {
                BreathingActivity breath = new BreathingActivity("Breathing Activity", 
                "This activity will help you relax by walking you through breathing in and out slowly.");

                breath.Start();
                breath.Middle();
                breath.End();
            }

            else if (cmChoice == "2")
            {
                ReflectionActivity reflect = new ReflectionActivity("Reflection Activity", 
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize power you have and how you can use it in other aspects of your life.");

                reflect.Start();
                reflect.Middle();
                reflect.End();
            }
            else if (cmChoice == "3")
            {
                ListingActivity list = new ListingActivity("Listing Activity", 
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                list.Start();
                list.Middle();
                list.End();
            }
            else if (cmChoice == "4")
            {
                cmRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid Response, please try again.");
                Thread.Sleep(500);

            }
        }
    }
}