public class Level
{
    private int _points;
    private int _level;

    public Level(int level)

    {
        _level = level;
    }

    public int PointNeededtoLevelUp()
    {
         _points = 783 * _level;
        return _points;

    }
}