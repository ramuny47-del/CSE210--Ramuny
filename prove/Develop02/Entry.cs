namespace Develop02;
public class Entry
{
    private string _date;
    private string _prompt;
    private string _text;

    public Entry(string date, string prompt, string text)
    {
        _date = date;
        _prompt = prompt;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_text);
    }

    public override string ToString()
    {
        // Use a simple delimiter so we can parse entries back.
        return $"{_date}|{_prompt}|{_text}";
    }

    public static Entry FromString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length < 3)
        {
            return null;
        }

        string date = parts[0];
        string prompt = parts[1];
        string text = string.Join("|", parts.Skip(2));
        return new Entry(date, prompt, text);
    }
}