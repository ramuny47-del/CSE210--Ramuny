using System.Security;

public class Load
{
    private string _fileName;

    public Load(string filename)
    {
        _fileName = filename;
    }
    public(List<Goal> goals, int level, int totalPoints) LoadGoal()
    {   
        List<Goal> goals = new List<Goal>();
        int level = 1;
        int totalPoints = 0;
        if (!File.Exists(_fileName))
        {
            Console.WriteLine("No Saved goals found.");
            return (goals, level, totalPoints);
        }

        string[] lines = File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(parts[1], int.Parse(parts[2]));
                g.SetCreationDate(parts[3]);
                g.SetCompletionDate(parts[4]);
                g.SetIsCompleted(parts[5]);
                goals.Add(g);


            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal g = new EternalGoal(parts[1],int.Parse(parts[2]));
                g.SetCreationDate(parts[3]);
                g.SetCompletionDate(parts[4]);
                g.SetTimeCompleted(parts[5]);
                goals.Add(g);
            }

            else if (parts[0] == "CheckListGoal")
            {
                int Bonus = int.Parse(parts[6]);
                int Target = int.Parse(parts[7]);
                CheckListGoal g = new CheckListGoal(parts[1], int.Parse(parts[2]), Target, Bonus);
                g.SetCreationDate(parts[3]);
                g.SetCompletionDate(parts[4]);
                g.SetTimeCompleted(parts[5]);
                goals.Add(g);
            }
            else if (parts[0] == "Level")
            {
                level = int.Parse(parts[1]);
                totalPoints = int.Parse(parts[2]);
                
            }
        }
        Console.WriteLine("Goal Loaded Sucessfully!");
        return (goals, level, totalPoints);
    }
    
}