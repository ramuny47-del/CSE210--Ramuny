public class EternalGoal : Goal
{
    public EternalGoal( string description, int points) 
    :base("EternalGoal", description, points)
    {
        _timesCompleted = 0;
    }

    public override int recordEvent()
    {
       _lastCompletionDate = DateTime.Now;
       _timesCompleted++;

       return _points;
    }

    public override bool Iscompleted()
    {
        return false;
    }

    public override void Display()
    {
        base.Display();
         Console.WriteLine($"Completed {_timesCompleted} times");
    }

   
     public override string DisplayInString()
    {
        return $"{_goalName}|{_description}|{_points}|{_creationDate}|{_lastCompletionDate}|{_timesCompleted}";
    }

}