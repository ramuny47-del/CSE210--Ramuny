using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;



public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
// GET all of my classes ready
        Prompt myPrompt = new Prompt();
        string selected_prompt = myPrompt.prompt_select();

        Write writer = new Write();

        Store_entry storage = new Store_entry();

        Display display = new Display();

        Save_to_file save = new Save_to_file();

        Load load = new Load();

string user_input = "0";

while (!(user_input == "5")){
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Save");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Display");
        Console.WriteLine("5. Quit");

        user_input = Console.ReadLine();

        if (user_input == "1")
        {
            Console.WriteLine(selected_prompt);
            
            string entry = writer.write_entry();
            storage.store(entry);
        }
        if (user_input == "2")
            {
                Console.Write("Enter the filename to save entries: ");
                string filename = Console.ReadLine();
                save.save(storage.all_entry(), filename);
            }
        if (user_input == "3")
            {
                Console.Write("Enter the filename to load: ");
                string file_path = Console.ReadLine();

                List<string> load_entries = load.load_entries(file_path);

                foreach (string entry in load_entries)
                {
                    storage.store(entry);
                }
            }
        
        if (user_input == "4"){
            List<string> entries = storage.all_entry();
            foreach (string e in entries)
                {
                    Console.WriteLine(e);
                }

        }

    }}}
