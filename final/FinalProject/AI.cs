public class AI : Player
{
    private List<bool> _allActions = new List<bool>{false, false, false, false};

    private DateTime _startTime;

    private DateTime _endTime;

    private int _direction;

    
    public AI(Animation _animation, int[] coordinates) : base(_animation, coordinates)
    {

    }

    public override void Walk(string direction, int playerXCoord)
    {
        if (direction == "D")
        {
            if (_coordinates[0] < 60)
            {
                _coordinates[0]++;
            }

            _animation.Increment("D");
        }
        else if (direction == "A")
        {
            if (_coordinates[0] > playerXCoord+4)
            {
                _coordinates[0]--;
            }
            
            _animation.Increment("A");
        }
    }

    public override bool Punch(int playerXCoord)
    {
        if (_isPunching == false)
        {
            _isPunching = true;

            _isPunchingStartTime = DateTime.Now;
            _isPunchingEndTime = _isPunchingStartTime.AddSeconds(0.5);

            _animation.Increment("punch");

            if (_coordinates[0] == playerXCoord+4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public bool RandomAction(int playerXCoord)
    {   
        if (_allActions[0] == false & _allActions[1] == false & _allActions[2] == false & _allActions[3] == false)
        {
            Random random = new();
            int action = random.Next(0,5);

            if (action == 0)
            {
                _allActions[0] = true;

                _startTime = DateTime.Now;
                _endTime = _startTime.AddSeconds(1);

                _direction = random.Next(0,4);
            }
            else if (action == 1 || action == 4)
            {
                _allActions[1] = true;
                
                _startTime = DateTime.Now;
                _endTime = _startTime.AddSeconds(0.5);
                
                bool punch = Punch(playerXCoord);
                if (punch)
                {
                    return true;
                }
            }
            else if (action == 2)
            {
                _allActions[2] = true;

                _startTime = DateTime.Now;
                _endTime = _startTime.AddSeconds(2);

                Jump();
            }
            else if (action == 3)
            {
                _allActions[3] = true;

                _startTime = DateTime.Now;
                _endTime = _startTime.AddSeconds(1);
            }
        }
        else
        {
            if (_allActions[0] == true)
            {
                if (_direction == 0)
                {
                    Walk("D", playerXCoord);
                }
                else
                {
                    Walk("A", playerXCoord);
                }

                if (_endTime < DateTime.Now)
                {
                    _allActions[0] = false;
                    Stand();
                }
            }
            else if (_allActions[1] == true)
            {
                StopPunch();
                
                if (_endTime <= DateTime.Now)
                {
                    _allActions[1] = false;
                }
                
            }
            else if (_allActions[2] == true)
            {
                Fall();
                
                if (_endTime <= DateTime.Now)
                {
                    _allActions[2] = false;
                }
            }
            else if (_allActions[3] == true)
            {
                if (_endTime <= DateTime.Now)
                {
                    _allActions[3] = false;
                }
            }
        }

        return false;

    }
}