class Scripture
{
    private Reference _reference;
    private Hidden _hidden;

    public Scripture(Reference reference, Hidden hidden)
    {
        _reference = reference;
        _hidden = hidden;
    }

    public void Display()
    {
        Console.WriteLine(_reference.display());
        _hidden.Display();
    }

    public void HideMoreWords(int count)
    {
        _hidden.HideMoreWords(count);
    }

    public bool AllHidden()
    {
        return _hidden.AllHidden();
    }
}
