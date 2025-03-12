public class ChecklistGoal : Goal
{
    private int _pointsOnCompletion;

    private int _numOfMarks;

    private int _neededNumOfMarks;
    
    public ChecklistGoal(string name, string description, int pointsPerMark, 
                        int pointsOnCompletion, int numOfMarks, int neededNumOfMarks) : base(name, description, pointsPerMark)
    {
        _pointsOnCompletion = pointsOnCompletion;

        _numOfMarks = numOfMarks;

        _neededNumOfMarks = neededNumOfMarks;
    }

    public override int Mark()
    {
        _numOfMarks ++;
        
        if (_numOfMarks == _neededNumOfMarks)
        {
            return _pointsOnCompletion + _pointsPerMark;
        }
        else
        {
            return _pointsPerMark;
        }
    }

    public override string PrettyText()
    {
        if (_isDone)
        {
            return $"[x] {_name} ({_description}) -- Currently completed: {_numOfMarks}/{_neededNumOfMarks}";
        }
        else
        {
            return $"[ ] {_name} ({_description}) -- Currently completed: {_numOfMarks}/{_neededNumOfMarks}";
        }
    }

    public override string Save()
    {
        return $"ChecklistGoal~~{_isDone}~~{_name}~~{_description}~~{_pointsPerMark}~~{_pointsOnCompletion}~~{_numOfMarks}~~{_neededNumOfMarks}";
    }
}