
class Resume
{
    public string name;
    public List<Job> Jobs = new List<Job>();

    public void display()
    {
        Console.WriteLine($"name: {name}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}