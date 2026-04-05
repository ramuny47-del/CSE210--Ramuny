public class Skill
{
private string _SkillName;
private int _Xp;
private int _TargetXp;

private int _SkillLevel;

public Skill(string name, int xp, int level)
    {
        _SkillName = name;
        _Xp = xp;
        _SkillLevel = level;
        _TargetXp = _SkillLevel * 1280 + (420 * _SkillLevel);
    }

public void AddXP(int amount)
    {
        _Xp = _Xp + amount;

        if (_Xp >= _TargetXp)
        {
            _SkillLevel = _SkillLevel + 1;
            
        }
    }

public void RemoveXP(int amount)
    {
        _Xp = _Xp - amount;

        if(_Xp < amount && _SkillLevel > 1)
        {
            _SkillLevel = _SkillLevel -1;
            _Xp = _TargetXp - (amount - _Xp);
        }
    }
public string GetName()
    {
        return _SkillName;
    }
public void Display()
    {
        Console.WriteLine($"{_SkillName}___LeveL: {_SkillLevel}  current XP: {_Xp}/{_TargetXp}");
         if (_Xp >= _TargetXp)
        {
            _SkillLevel = _SkillLevel + 1;
            _TargetXp = _SkillLevel * 1280 + (420 * _SkillLevel);
        
    }
    }
public string DisplayInString()
    {
        return $"Skill|{_SkillName}|{_SkillLevel}|{_Xp}";
    }

public static Skill Parse(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length != 4 || parts[0] != "Skill")
        {
            throw new FormatException("Invalid skill line format.");
        }
        string name = parts[1];
        int level = int.Parse(parts[2]);
        int xp = int.Parse(parts[3]);
        return new Skill(name, xp, level);
    }

public string SetSkillName(string skill)
    {
        _SkillName = skill;
        return _SkillName;
    }

public int SetXP(string xp)
    {
        _Xp = int.Parse(xp);
        return _Xp;

    }

public int SetSkillLevel(string skillLevel)
    {
        _SkillLevel = int.Parse(skillLevel);
        return _SkillLevel;
    }
}