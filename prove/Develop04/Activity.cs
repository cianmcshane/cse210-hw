using System;

class Activity
{
    private string _cmName;
    private string _cmDescription;
    private int _cmDuration;

    public Activity(string name, string description)
    {
        _cmName = name;
        _cmDescription = description;
    }

    public int GetDuration()
    {
        return _cmDuration;
    }

    
    public void Spinner()
    {
            for (int i = 0; i < 3; i++)
            {Console.Write("E");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("M");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("W");}
            Console.Write("\b \b");
            Console.Write("      ");

    }

    public void Start()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_cmName} activity.\n");
        Console.WriteLine($"{_cmDescription}");

        Console.Write("How long, in seconds, would you like your session? ");
        _cmDuration = int.Parse(Console.ReadLine());


    //Get ready + spinner

        Console.Clear();
        Console.WriteLine("Get ready... ");

        Spinner();

        Console.Write("\b \b");
        Console.Write("          ");    
    }

    public void End()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed another {_cmDuration} seconds of the {_cmName} activity.\n");
    }
}