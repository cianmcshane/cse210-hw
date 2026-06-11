using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("Roberto Rodriguez-Hernandez", "Factorials", "3.3", "1-9");
        Console.WriteLine(assignment1.Getsummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assingment2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assingment2.Getsummary());
        Console.WriteLine(assingment2.GetWritingInformation());
    }
}