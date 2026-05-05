using System;

public class Resume
{
    public string _cmname = "";
    public List<Job> _cmjobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_cmname}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _cmjobs)
        {
            job.Display();
        }
    }
}