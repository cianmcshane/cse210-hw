using System;

public class Entry
{
    public static string _cmNewEntry(string cmPrompt)
    {
        Console.WriteLine(cmPrompt);
        string cmResponse = Console.ReadLine();

        DateTime cmToday = DateTime.Today;

        string cmEntry = $"{cmToday},{cmPrompt},{cmResponse}";
        return cmEntry;
    }
}