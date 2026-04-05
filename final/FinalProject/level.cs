public class Level
{
    private int _points;
    private int _level;
    private int _title;

    public Level(int level)

    {
        _level = level;
    }

    public int PointNeededtoLevelUp()
    {
         _points = 783 * _level;
        return _points;

    }

    List<string> levelTitles = new List<string>
    {
        "Rookie", "Try-Hard", "Getting There", "Skill Seeker", "Specialist",
         "Expert", "Pro Performer", "Champion", "Master",
         "Grandmaster", "Elite", "Legend in Training", "Legend", "Mythic"
    };

    public string GetTitle()
    {
     int index;
        if(_level <= 12 * 25)
        {
            index = (_level-1) / 25;

        }
        else
        {
            index = 12 + (_level - 12 * 25 -1 / 50);

        }
        if (index >= levelTitles.Count)
        {
            index = levelTitles.Count -1;

        }
    
    return levelTitles[index];
    }

    public string DisplayInString()
    {
        return $"{_level}|{_points}|{_title}";
    }
    
}