public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointsPerMark) : base(name, description, pointsPerMark)
    {

    }

    public override int Mark()
    {
        _isDone = true;

        return _pointsPerMark;
    }

    public override string Save()
    {
        return $"SimpleGoal~~{_isDone}~~{_name}~~{_description}~~{_pointsPerMark}";
    }
}