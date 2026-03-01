using System.ComponentModel;
using System.Data;

public class Breathing : Activity 
{
 public Breathing(): base("Breathing", "This activity will help you breath, Follow the instruction")
    {
        
    }

public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {   
            Console.Clear();
            Console.Write("Breathe in for 4 second...");
            Console.Clear();
            Console.Write("Breathing in ...");
            Console.Write("1");
            animation(1);
            Console.Write("\b \b");
            Console.Write("2");
            animation(1);
            Console.Write("\b \b");
             Console.Write("3");
            animation(1);
            Console.Write("\b \b");
            Console.Write("4");
            animation(1);
           
            Console.Clear();
            Console.Write("Hold for 2 second");
            Console.Clear();
            Console.Write("Hold ...");
            Console.Write("1");
            animation(1);
            Console.Write("\b \b");
            Console.Write("2");
            animation(1);

            Console.Clear();
            Console.Write("Breathe out for 4 seconds");
            Console.Clear();
            Console.Write("Breathing out ...");
             Console.Write("1");
            animation(1);
            Console.Write("\b \b");
            Console.Write("2");
            animation(1);
            Console.Write("\b \b");
             Console.Write("3");
            animation(1);
            Console.Write("\b \b");
            Console.Write("4");
            animation(1);



        }
        DisplayEndingMessage();

    }
}