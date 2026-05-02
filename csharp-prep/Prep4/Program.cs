using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> cmNumbers = new List<int>();

        int cmNumber = 101;
        Console.Write("Enter a list of numbers, type 0 when finished.");

        while (cmNumber != 0)
        {
            Console.WriteLine("Enter number: ");
            string cmStringNumber = Console.ReadLine();
            cmNumber = int.Parse(cmStringNumber);
            cmNumbers.Add(cmNumber);
        }

        int cmSum = 0;
        int cmLargestNumber = 0;

        for (int i = 0; i < cmNumbers.Count; i++)
            {
                Console.WriteLine(cmNumbers[i]);
                cmSum += cmNumbers[i];

                if (cmNumbers[i] > cmLargestNumber)
                {
                    cmLargestNumber = cmNumbers[i];
                }
            }
        
        decimal cmAverage = (decimal)cmSum / cmNumbers.Count;

        Console.WriteLine($"The sum is: {cmSum}");
        Console.WriteLine($"The average is {cmAverage}");
        Console.WriteLine($"The largest number is: {cmLargestNumber}");

    }
}