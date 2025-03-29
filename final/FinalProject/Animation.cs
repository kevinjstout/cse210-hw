using System.Runtime.Versioning;

public class Animation
{
    private List<string> _runningFrames;

    private List<string> _jumpingFrames;

    private List<string> _punchingFrames;

    string _currentFrameSet;

    public Animation(List<string> runningFrames, List<string> jumpingFrames, List<string> punchingFrames)
    {
        _runningFrames = runningFrames;
    }
    
    public void Increment(List<string> frameSet)
    {

    }

    public string GetFrame()
    {
        // if (_currentFrameSet == "runningFrames")
        // {
        //     int frame = int.Parse(_runningFrames[0]);
        //     return _runningFrames[frame];
        // }
        
        int frame = int.Parse(_runningFrames[0]);
        return _runningFrames[frame];
    }
}