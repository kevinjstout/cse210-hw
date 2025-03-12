public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointsPerMark) : base(name, description, pointsPerMark)
    {

    }

    public override int Mark()
    {
        return _pointsPerMark;
    }

    public override string Save()
    {
        return $"EternalGoal~~{_isDone}~~{_name}~~{_description}~~{_pointsPerMark}";
    }
}