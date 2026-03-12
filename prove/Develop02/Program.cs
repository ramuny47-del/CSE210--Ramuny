namespace Develop02;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Prompt promptGenerator = new Prompt();
        Journal journal = new Journal();

        string userInput = "0";

        while (userInput != "6")
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Save");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. Random entry");
            Console.WriteLine("6. Quit");

            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                string promptText = promptGenerator.PromptSelect();
                Console.WriteLine(promptText);

                string text = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry(date, promptText, text);

                journal.AddEntry(entry);
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Enter filename:");
                string filename = Console.ReadLine();

                List<string> lines = journal.GetEntriesAsLines();
                journal.Save(lines, filename);
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Enter filename:");
                string filename = Console.ReadLine();

                journal.Load(filename);
            }
            else if (userInput == "4")
            {
                journal.Display();
            }
            else if (userInput == "5")
            {
                journal.DisplayRandomEntry();
            }
        }
    }
}