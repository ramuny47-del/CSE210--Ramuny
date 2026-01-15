using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Numerics;
using System.Security.Claims;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
int clue = 99999;
int sum = 0;
Console.WriteLine("Enter a list of numbers, type 0 when finished!");
while (!(clue == 0)){
    Console.Write("Enter number: ");
    clue = int.Parse(Console.ReadLine());
    if (!(clue == 0)){
    numbers.Add(clue);
}}
int max = numbers[0];
foreach (int number in numbers)
            {
                sum+= number;
                if (number > max){
                max = number;
                }
            }
int min = numbers[0];
foreach (int small in numbers)
        {
            if (small < min)
            { if (!(small == 0)){
                min = small;
            }}
        }
    int len = numbers.Count;
    double average = (double)sum /  len;
 Console.WriteLine("The Sum is: " + sum);
 Console.WriteLine("The Average is: " + average);
 Console.WriteLine("The Largest number is: " + max);
 Console.WriteLine("The Smallest number is: " + min);
    }


}