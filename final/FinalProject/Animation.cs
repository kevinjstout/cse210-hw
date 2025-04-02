using System.Runtime.Versioning;

public class Animation
{
    private List<string> _runningFrames;

    private List<string> _jumpingFrames;

    private List<string> _punchingFrames;

    string _currentFrameSet;

    private string dFrame = "2";
    private string aFrame = "4";

    public Animation(List<string> runningFrames, List<string> jumpingFrames, List<string> punchingFrames)
    {
        _runningFrames = runningFrames;

        _jumpingFrames = jumpingFrames;

        _punchingFrames = punchingFrames;
    }

    public void Increment(string key)
    {
        if (key == "D")
        {
            _currentFrameSet = "runningFrames";
            
            DateTime now = DateTime.Now;
            int milliseconds = now.Millisecond;

            if (milliseconds % 3 == 0)
            {
                if (dFrame == "2")
                {
                    dFrame = "3";
                } 
                else
                {
                    dFrame = "2";
                }
            }
            
            _runningFrames[0] = dFrame;
        }
        else if (key == "A")
        {
            _currentFrameSet = "runningFrames";
            
            DateTime now = DateTime.Now;
            int milliseconds = now.Millisecond;

            if (milliseconds % 3 == 0)
            {
                if (aFrame == "4")
                {
                    aFrame = "5";
                } 
                else
                {
                    aFrame = "4";
                }

                _runningFrames[0] = aFrame;
            }
        }
        else if (key == "jump")
        {
            _currentFrameSet = "jumpingFrames";
        }
        else if (key == "punch")
        {
            _currentFrameSet = "punchingFrames";
        }
        else if (key == "fall")
        {
            _currentFrameSet = "walkingFrames";
        }
    }

    public string GetFrame()
    {
        if (_currentFrameSet == "runningFrames")
        {
            int frame = int.Parse(_runningFrames[0]);
            return _runningFrames[frame];
        }
        else if (_currentFrameSet == "jumpingFrames")
        {
            int frame = int.Parse(_jumpingFrames[0]);
            return _jumpingFrames[frame];
        }
        else if (_currentFrameSet == "punchingFrames")
        {
            int frame = int.Parse(_punchingFrames[0]);
            return _punchingFrames[frame];
        }
        else
        {
            return _runningFrames[1];
        }
    }
}