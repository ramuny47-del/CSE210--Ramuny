using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        
       
Console.WriteLine("Choose from the following (type 1 or 2): ");
Console.WriteLine("1.Put your own scripture");
Console.WriteLine("2.Go with the selected scripture");
string user_input = Console.ReadLine();

if (user_input == "1")
        {
            Console.WriteLine("What is the book of scripture?");
            string scripture_book = Console.ReadLine();
            Console.WriteLine("What is the chapter?");
            string scripture_chapter = Console.ReadLine();
            int scripture_chapter_int = int.Parse(scripture_chapter);

            Console.WriteLine("What is the starting verse?");
            string scripture_start_verse = Console.ReadLine();
            int scripture_start_verse_int = int.Parse(scripture_start_verse);
            Console.WriteLine("What is the ending verse (if one 1 verse, type 0)");
            string scripture_end_verse = Console.ReadLine();
            int scripture_end_verse_int = int.Parse(scripture_end_verse);
            Console.WriteLine("Please paste your scripture here: ");
            string scripture_input = Console.ReadLine();
    Reference reference__ = new Reference(scripture_book,scripture_chapter_int, scripture_start_verse_int, scripture_end_verse_int);
Hidden hidden = new Hidden(scripture_input);

Scripture scripture = new Scripture(reference__, hidden);

while (true)
{
    Console.Clear();
    scripture.Display();

    if (scripture.AllHidden())
        break;

    Console.WriteLine("\nPress Enter to hide 3 words or type 'quit': ");
    string input = Console.ReadLine();

    if (input == "quit")
        break;

    scripture.HideMoreWords(3);
}
        }

else{
        Reference reference = new Reference("John", 3, 16,2
        );
Hidden hidden = new Hidden(
    "Trust in the Lord with all thine heart and lean not unto thine own understanding."
);

Scripture scripture = new Scripture(reference, hidden);

while (true)
{
    Console.Clear();
    scripture.Display();

    if (scripture.AllHidden())
        break;

    Console.WriteLine("\nPress Enter to hide 3 words or type 'quit': ");
    string input = Console.ReadLine();

    if (input == "quit")
        break;

    scripture.HideMoreWords(3);
}
    }}}
