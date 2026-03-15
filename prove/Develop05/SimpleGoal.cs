using System.Runtime.Serialization;

public class SimpleGoal : Goal
{
    private bool _IsCompleted;

    public SimpleGoal(string description, int points) : base("SimpleGoal", description, points)
    {
        _IsCompleted = false;
    }

    public override int recordEvent()
    {
       if (!(_IsCompleted)){
            
            _IsCompleted = true;
            _lastCompletionDate = DateTime.Now;

            return _points;
        }
        return 0;
    }

    public override bool Iscompleted()
    {
        return _IsCompleted;
    }

    public override string DisplayInString()
    {
        return $"{_goalName}|{_description}|{_points}|{_creationDate}|{_lastCompletionDate}|{_IsCompleted}";
    }

    public override void Display()
    {
        base.Display();
        if (_IsCompleted){Console.WriteLine($"Status: Completed");}
        if (!_IsCompleted){Console.WriteLine($"Status: Not Completed");}
        
    }
    public bool SetIsCompleted(string status)
    {
        return _IsCompleted = bool.Parse(status);
    }
}