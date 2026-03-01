using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("Welcome to the mindfulness app!");
        Console.WriteLine("Menu Option: ");
        Console.WriteLine("1.Start Breathing activity");
        Console.WriteLine("2.Start Reflecting Activity");
        Console.WriteLine("3.Start Listening Activity");
        Console.WriteLine("4.Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            Breathing breathe = new Breathing();
            breathe.Run();
        }
        if (choice == "2")
        {
            Reflecting reflect = new Reflecting();
            reflect.Run();
        }
        if (choice == "3")
        {
            Listing_ list = new Listing_();
            list.Run();
        if (choice == "4")
            {
                return;
            }
        }
        else
        {Breathing breathe = new Breathing();
            breathe.ShowCountDown(100);

        }
    }}