using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<string> cmEntries = new List<string>();

    // Add a new journal entry
    public void _cmaddEntry()
    {
        string cmEntry = Entry._cmNewEntry(Prompter._cmPrompt());
        cmEntries.Add(cmEntry);

        Console.WriteLine("\nEntry saved!\n");
    }

    // Display all entries
    public void _cmdisplay()
    {
    foreach (string cmEntry in cmEntries)
    {
        string[] parts = cmEntry.Split(",");

        if (parts.Length < 3)
        {
            continue; // skip broken lines safely
        }

        string cmDate = parts[0];
        string cmPrompt = parts[1];
        string cmResponse = parts[2];

        Console.WriteLine($"\nDate: {cmDate}");
        Console.WriteLine($"Prompt: {cmPrompt}");
        Console.WriteLine($"Response: {cmResponse}");
        Console.WriteLine("----------------------");
        }
    }

    public void _cmsave()
    {
        Console.Write("Enter filename: ");
        string cmFilename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(cmFilename))
        {
            foreach (string cmEntry in cmEntries)
            {
                outputFile.WriteLine(cmEntry);
            }
        }

        Console.WriteLine("Journal saved!");
    }

     public void _cmload()
    {
        Console.Write("Enter filename: ");
        string cmFilename = Console.ReadLine();

        if (File.Exists(cmFilename))
        {
            cmEntries.Clear();

            string[] cmFileLines = File.ReadAllLines(cmFilename);

            foreach (string cmLine in cmFileLines)
            {
                cmEntries.Add(cmLine);
            }

            Console.WriteLine("Journal loaded!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}