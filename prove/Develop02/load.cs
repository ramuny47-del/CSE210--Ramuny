public class Load
{
    public List<string> load_entries(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File is not found!");
            return new List<string>();
        }
        List<string> entries = new List<string>(File.ReadAllLines(filePath));
        return entries;
    }
}