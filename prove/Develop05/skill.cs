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
        return $"{_SkillName}|{_SkillLevel}|{_Xp}";
    }
}