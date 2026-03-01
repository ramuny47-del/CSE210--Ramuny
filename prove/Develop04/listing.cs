using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Listing_ : Activity
{   private List<string> _question;
    private List<string> _item;
   public Listing_(): base("Listing", "This Activity will help you reflect by listing as many things as you can in a certain area.")
    {
    _question = new List<string>
    {
        "who are people that you appreciate?",
        "What are your personal strength?",
        "Who have you helped recently",
        "what are things that make you happy?",
        "What are things you are grateful for?",
    };
    _item = new List<string>
    {
        
    };
    
    }
    
    public void Run()
    {
        Random random = new Random();
        int index = random.Next(_question.Count);
        DisplayStartingMessage();
         DateTime endTime = DateTime.Now.AddSeconds(_time);

         Console.WriteLine();
            Console.WriteLine("List as many responses as you can to the following prompt: ");
            Console.WriteLine($"---- {_question[index]}----");
            Console.WriteLine();
            Console.Write("You may begin in: ");
            ShowCountDown(5);

           int counting = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            _item.Add(item);
            counting ++;
        }
    Console.WriteLine();
    Console.WriteLine($"You have listed {counting} items!");
    Console.WriteLine("Would you like to see your list? (yes or no)");
    string input = Console.ReadLine();
    if (input == "yes")
        {
            foreach (string item in _item){
            Console.Write(item);
            Console.Write("  ");
            }}
    else
    {
    DisplayEndingMessage();
    }
    }}
