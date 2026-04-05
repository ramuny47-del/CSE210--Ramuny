public class DailyHabit
{
    private string _name;
    private Skill _linkedSkill; 
    private int _XPReward;

    private DateTime _LastDid;

    public DailyHabit(string name, Skill skill, int XPReward)
    {
        _name = name;
        _linkedSkill = skill;
        _XPReward = XPReward;
        _LastDid = DateTime.MinValue;
    }

    public int Complete()
    {
        _linkedSkill.AddXP(_XPReward);
        Console.WriteLine(_name + " Completed! " + _XPReward + "XP to " + _linkedSkill.GetName()); 
        _LastDid = DateTime.Now;
        Console.WriteLine();
        Console.WriteLine();
        return _XPReward;
    }

    public void Penalty()
    {
        if (_LastDid == DateTime.MinValue)
        {
            return;
        }

        int daysMissed = (DateTime.Today - _LastDid.Date).Days - 1;
        if (daysMissed > 0)
        {
            int totalPenalty = daysMissed * _XPReward;
            _linkedSkill.RemoveXP(totalPenalty);
            Console.WriteLine(_name + " missed " + daysMissed + " day(s)! -" + totalPenalty + " XP to " + _linkedSkill.GetName());
            Console.WriteLine();
            Console.WriteLine();
        }

    }
    
    public void Display()
    {
        Console.WriteLine($"{_name}__________________{_XPReward}XP");
        Console.WriteLine($"Last Update: {_LastDid}");
    }

    public string DisplayInString()
    {
        return $"Habit|{_name}|{_linkedSkill.GetName()}|{_XPReward}|{_LastDid:O}";
    }

    public static DailyHabit Parse(string line, List<Skill> skills)
    {
        string[] parts = line.Split('|');
        if ((parts.Length != 5 && parts.Length != 6) || parts[0] != "Habit")
        {
            throw new FormatException("Invalid habit line format.");
        }

        string name = parts[1];
        string skillName = parts[2];
        int xpReward = int.Parse(parts[3]);
        string lastDidText = parts.Length == 5 ? parts[4] : parts[5];
        DateTime lastDid = DateTime.Parse(lastDidText);

        Skill linkedSkill = skills.Find(s => s.GetName() == skillName);
        if (linkedSkill == null)
        {
            linkedSkill = new Skill(skillName, 0, 1);
        }

        DailyHabit habit = new DailyHabit(name, linkedSkill, xpReward);
        habit.SetLastDid(lastDid);
        return habit;
    }

    public void SetLastDid(DateTime lastDid)
    {
        _LastDid = lastDid;
    }

    public string SetName(string name)
    {
        return _name = name;
    }

    public Skill setLinkedSkill(string linkedSkill)
    {
        return _linkedSkill = Skill.Parse(linkedSkill);
    }
}