public class Save_to_file
{
    public void save(List<string> file, string filename)
    {
        File.WriteAllLines(filename, file);
        Console.WriteLine($"All entries saced to {filename}!");
    }


}