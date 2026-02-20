using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Student simpletest = new Student("Samuel Bennett", "Mutiplication");
        Console.WriteLine(simpletest.GetSummary());

        Math simplemath = new Math("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(simplemath.GetSummary());
        Console.WriteLine(simplemath.GetHomeworkList());
        Console.WriteLine();

        Writing simplewrite = new Writing("Mary Waters", "European History", "The causes of World War 2");
        Console.WriteLine(simplewrite.GetSummary());
        Console.WriteLine(simplewrite.GetWritingInfo());
    }
}