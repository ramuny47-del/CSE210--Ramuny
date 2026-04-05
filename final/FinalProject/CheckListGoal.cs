using System.Runtime;

public class CheckListGoal : Goal
{
    private int _target;
    private int _bonus;

    public CheckListGoal(string description, int points, int target, int bonus)
    : base("CheckListGoal", description, points)
    {
        _target = target;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override int recordEvent()
    {
        _lastCompletionDate = DateTime.Now;
        _timesCompleted++;
        if (_timesCompleted == _target)
        {
            _lastCompletionDate = DateTime.Now;
            return _points + _bonus;
        }
        return _points;

    }

    public override bool Iscompleted()
    {
        return _timesCompleted >= _target;
    }

    public override void Display()
    {
        base.Display();
         Console.WriteLine($"Amount Completed {_timesCompleted}/{_target}");
    }

    public override string DisplayInString()
    {
        return $"{_goalName}|{_description}|{_points}|{_creationDate}|{_lastCompletionDate}|{_timesCompleted}|{_bonus}|{_target}";
    }

  
}