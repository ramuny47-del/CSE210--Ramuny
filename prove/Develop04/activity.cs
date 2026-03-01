using System.ComponentModel;

public class Activity
{
    private string _name;
    private string _description;
    protected int _time; 


    public Activity (string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.WriteLine("How long in seconds, would you like for your session? (minimum 60s)");
        _time = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready ...");
        animation(3);

    }

    public void DisplayEndingMessage()
    {   Console.WriteLine();
        Console.WriteLine("Well done!");
        animation(3);
        Console.WriteLine($"time completed {_time} s");
        animation(5);
    }

    public void animation(int seconds)
    {
        List<string> spinner = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\"
        };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            foreach (string symbol in spinner)
            {
                Console.Write(symbol);
                Thread.Sleep(100);
                Console.Write("\b \b");
            }
        }
    }
    public void ShowCountDown(int second)
    {
         DateTime endTime = DateTime.Now.AddSeconds(second);
         int time = second;
        while (DateTime.Now < endTime && time > 0)
            {
            Console.WriteLine(time);
            time = time - 1;
            animation(1);   
            }
        }
    }
