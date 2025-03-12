public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointsPerMark, bool isDone) : base(name, description, pointsPerMark, isDone)
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