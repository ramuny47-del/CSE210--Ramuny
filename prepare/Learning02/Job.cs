class Job
{
    public string company;
    public string jobtitle;
    public int startyear;
    public int endyear;

    public void Display()
    {
        Console.WriteLine($"{jobtitle} ({company}) {startyear}-{endyear}");
    }
}
