using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string input = Console.ReadLine();
        float grade = float.Parse(input);
        string letter;

        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine(letter);
            
        }
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine(letter);
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine(letter);
        }
        else if (grade >= 60)
        {
            letter = "D";
            Console.WriteLine(letter);
        }
        else
        {
            letter = "F";
            Console.WriteLine(letter);
        }
        if ( letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("You have passed!");
        }
        else
            {
                Console.WriteLine("Unfortunately, You failed but You can always retake the class!");
            }
        
    }
}