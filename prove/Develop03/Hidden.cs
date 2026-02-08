class Hidden
{
    private List<string> _words;
    private Random _random;

    public Hidden(string text)
    {
        _words = text
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        _random = new Random();
    }

    public void HideMoreWords(int count)
    {
        int hiddenThisRound = 0;
        int attempts = 0;

        while (hiddenThisRound < count && !AllHidden())
        {
            int index = _random.Next(_words.Count);

            if (!_words[index].StartsWith("_"))
            {
                _words[index] = new string('_', _words[index].Length);
                hiddenThisRound++;
            }

            attempts++;
            if (attempts > 1000) break;
        }
    }

    public bool AllHidden()
    {
        foreach (string word in _words)
        {
            if (!word.StartsWith("_"))
                return false;
        }
        return true;
    }

    public void Display()
    {
        foreach (string word in _words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}
