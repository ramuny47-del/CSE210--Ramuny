using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
         

    int response = 0;
    int magic_number = 1000000;
    Console.Write("What is the magic number? ");
            magic_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number is " + magic_number);

    while (!(response == magic_number))
        {   
            Console.Write("Guess a number: ");
            response = int.Parse(Console.ReadLine());
        if (response > magic_number)
        {
            Console.WriteLine("Too High");
            }
        else if(response < magic_number)
        {
            Console.WriteLine("Too Low");
        }
        }
Random randomGenerator = new Random();
    int number = randomGenerator.Next(1,101);

    Console.WriteLine(number);
    int answer = 0;
    while (!(answer == number))
        {
            Console.Write("Take a Guess ");
            answer = int.Parse(Console.ReadLine());
        if (answer > number)
        {
            Console.WriteLine("Too High");
            }
        else if(answer < number)
        {
            Console.WriteLine("Too Low");

        }
            else
            {
                Console.WriteLine("You Guess it right!");
            }
    }
    
   
}}