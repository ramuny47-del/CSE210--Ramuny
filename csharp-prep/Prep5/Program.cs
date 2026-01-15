using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string names = PromptUserName();
        int year = PromptUserBirthYear();
        int number = PromptUserNumber();
        DisplayResult(names, year, number);
        
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;

        }
        static int PromptUserNumber()
    { int number = 0;
        Console.Write("Please Enter Your Favorite number: ");
        number = int.Parse(Console.ReadLine());
        return number;
    }
    static int PromptUserBirthYear()
    {
        int year = 0;
        Console.Write("Please Enter Your Birth Year: ");
        year = int.Parse(Console.ReadLine());
        return year;
    }

    static int SquareNumber()
    {
        int number = 0;
        Console.Write("Please enter your number to be squared: ");
        number = int.Parse(Console.ReadLine());
        int Square = number * number;
        return Square;
    }
    static void DisplayResult(string name, int birthday, int number )
    {
        int age = 2026 - birthday;
        Console.WriteLine(name + "," + "The square of your number is " + number);
        Console.WriteLine(name + "," + "You will turn " + age + " his year.");

    }
}