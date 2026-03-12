using System.Linq;

namespace Develop02;
public class Journal
{
    private List<Entry> _entry = new List<Entry>();
    private static readonly Random _random = new Random();

    public Journal()
    {
    }

    public void AddEntry(Entry entry)
    {
        _entry.Add(entry);
    }

    public List<string> GetEntriesAsLines()
    {
        return _entry.Select(e => e.ToString()).ToList();
    }

    public void Display()
    {
        foreach (Entry entry in _entry)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public Entry GetRandomEntry()
    {
        if (_entry.Count == 0)
        {
            return null;
        }

        int index = _random.Next(0, _entry.Count);
        return _entry[index];
    }

    public void DisplayRandomEntry()
    {
        Entry entry = GetRandomEntry();
        if (entry == null)
        {
            Console.WriteLine("No entries available yet. Try writing one first.");
            return;
        }

        Console.WriteLine("Here is a random past entry:");
        entry.Display();
        Console.WriteLine();
    }

    public void Load(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File is not found!");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            Entry entry = Entry.FromString(line);
            if (entry != null)
            {
                _entry.Add(entry);
            }
        }
    }

    public void Save(List<string> file, string filename)
    {
        File.WriteAllLines(filename, file);
        Console.WriteLine($"All entries saved to {filename}!");
    }
}
