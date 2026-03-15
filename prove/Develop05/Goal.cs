using System.ComponentModel;
using System.Data;

public abstract class Goal
{
    protected int _points;
    protected string _goalName;
    protected string _description;
    protected DateTime _creationDate;
    protected DateTime _lastCompletionDate;
    protected int _timesCompleted;

public Goal(string goalName, string description, int points)
    {
        _goalName = goalName;
        _points = points;
        _description = description;
        _creationDate = DateTime.Now;
        _lastCompletionDate = DateTime.MinValue;
    }
public DateTime SetCreationDate(string CreationDate)
    {
        _creationDate = DateTime.Parse(CreationDate);
        
        return _creationDate;
    }
public DateTime SetCompletionDate(string CompletionDate)
    {
         _lastCompletionDate = DateTime.Parse(CompletionDate);
         return _lastCompletionDate;

    }

 public int SetTimeCompleted(string timecomplete){
        return _timesCompleted = int.Parse(timecomplete);
    }
    public abstract int recordEvent();

    public abstract bool Iscompleted();

    public virtual void Display()
    {
        Console.WriteLine($"{_goalName} : {_description}");
        Console.WriteLine();
        Console.WriteLine($"Created Date: {_creationDate}");
        Console.WriteLine();
        Console.WriteLine($"Last Completed Date: {_lastCompletionDate}");
        Console.WriteLine();
    }

    public virtual string DisplayInString()
    {
        return $"{_goalName}|{_description}|{_points}|{_creationDate}|{_lastCompletionDate}";
    }

}