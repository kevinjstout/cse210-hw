public abstract class Goal
{
    protected bool _isDone;

    protected string _name;

    protected string _description;

    protected int _pointsPerMark;

    public Goal(string name, string description, int pointsPerMark)
    {
        _name = name;

        _description = description;

        _pointsPerMark = pointsPerMark;

        _isDone = false;
    }

    public abstract int Mark();

    public virtual string PrettyText()
    {
        if (_isDone)
        {
            return $"[x] {_name} ({_description})";
        }
        else
        {
            return $"[ ] {_name} ({_description})";
        }
    }

    public abstract string Save();
}