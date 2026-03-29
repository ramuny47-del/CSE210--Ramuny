public class DailyHabit
{
    private string _name;
    private Skill _linkedSkill; 
    private int _XPReward;

    private DateTime _Today;
    private DateTime _LastDid;

    public DailyHabit(string name, Skill skill, int XPReward)
    {
        _name = name;
        _linkedSkill = skill;
        _XPReward = XPReward;
        _Today = DateTime.Now;
        _LastDid = DateTime.MinValue;
    }

    public void Complete()
    {
        _linkedSkill.AddXP(_XPReward);
        Console.WriteLine(_name + " Completed! " + _XPReward + "XP to " + _linkedSkill.GetName()); 
        _LastDid = DateTime.Now;
        Console.WriteLine();
        Console.WriteLine();
    }

    public void Penalty()
    {   
        int daysMissed = (_Today - _LastDid).Days -1;
        if (daysMissed > 0)
        {
            int totalPenalty = daysMissed * _XPReward;
            _linkedSkill.RemoveXP(totalPenalty);
            Console.WriteLine(_name + " missed " + daysMissed + "day(s)! -" + totalPenalty + "XP to" + _linkedSkill.GetName());
            Console.WriteLine();
            Console.WriteLine();
        }

    }
    
    public void Display()
    {
        Console.WriteLine($"{_name}__________________{_XPReward}XP");
        Console.WriteLine($"Last Update: {_LastDid}");
    }

}