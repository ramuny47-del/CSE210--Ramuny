public class Store_entry
{
    List<string> entry = new List<string>();
    public void store(string entries)
    {
        // You can modify this logic as needed
        entry.Add(entries);
    }

    public List<string> all_entry()
    {
        return entry;
    }
}