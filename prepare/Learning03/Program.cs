using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction = new Fraction(3,4);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        Random rand = new Random();
        for (int i = 0; i <21; i++)
        {
            int top = rand.Next(0,100);
            int bottom = rand.Next(0,100);
            Fraction fraction_number = new Fraction(top,bottom);

            Console.WriteLine($"Fraction 1: string: {fraction_number.GetFractionString()} Number:{fraction_number.GetDecimalValue()}"); 
        }
    }
}