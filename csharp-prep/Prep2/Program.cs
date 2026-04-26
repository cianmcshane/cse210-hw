using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage?");
        string stringNumber = Console.ReadLine();
        int cmgradeNumber = int.Parse(stringNumber);
        string cmGrade = "";

        if (cmgradeNumber >= 90)
        {
            cmGrade = "A";
        }
        else if (cmgradeNumber >= 80)
        {
            cmGrade = "B";
        }
        else if (cmgradeNumber >= 70)
        {
            cmGrade = "C";
        }
        else if (cmgradeNumber >= 60)
        {
            cmGrade = "D";
        }
        else
        {
            cmGrade = "F";
        }

        Console.WriteLine($"Your grade is a {cmGrade}");
    }
}