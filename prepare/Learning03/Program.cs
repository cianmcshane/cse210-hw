using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction cmFraction1 = new Fraction();
        Fraction cmFraction2 = new Fraction(5);
        Fraction cmFraction3 = new Fraction(3, 4);

        Console.WriteLine(cmFraction1.GetFractionString());
        Console.WriteLine(cmFraction1.GetDecimalValue());

        Console.WriteLine(cmFraction2.GetFractionString());
        Console.WriteLine(cmFraction2.GetDecimalValue());

        Console.WriteLine(cmFraction3.GetFractionString());
        Console.WriteLine(cmFraction3.GetDecimalValue());
    }
}