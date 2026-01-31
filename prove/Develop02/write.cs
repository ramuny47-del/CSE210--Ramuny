public class Write
{
    public string write_entry()
    {
        Console.WriteLine("Please write your response to the prompt:");
        string entry = Console.ReadLine();

        string timestamp = DateTime.Now.ToString("yyyy-MM-dd");
        entry = $"Date: {timestamp} - {entry}";
        return entry;
    }
}