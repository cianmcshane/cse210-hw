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
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime end = DateTime.Now.AddSeconds(3);

        while (DateTime.Now < end)
        {
            foreach (string s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(200);
                Console.Write("\b");
            }
        }
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