using System.Reflection;

public class Player
{
    protected int _health;

    protected Animation _animation;

    protected int[] _coordinates;

    protected bool _isJumping;
    protected DateTime _isJumpingStartTime;
    protected DateTime _isJumpingEndTime;

    protected bool _isPunching;
    protected DateTime _isPunchingStartTime;
    protected DateTime _isPunchingEndTime;


    public Player(Animation animation, int[] coordinates)
    {
        _coordinates = coordinates;

        _health = 3;

        _animation = animation;

        _isJumping = false;
    }
    
    public void Jump()
    {
        if (_isJumping == false)
        {
            _isJumping = true;

            _coordinates[1]--;

            _isJumpingStartTime = DateTime.Now;
            _isJumpingEndTime = _isJumpingStartTime.AddSeconds(0.5);

            _animation.Increment("jump");
        }
    }

    public void Fall()
    {
        if (_isJumping == true & DateTime.Now > _isJumpingEndTime)
        {
            _isJumping = false;

            _coordinates[1]++;

            _animation.Increment("fall");
        }
    }

    public virtual void Walk(string direction, int aiXCoord)
    {
        if (direction == "D")
        {
            if (_coordinates[0] < aiXCoord-4)
            {
                _coordinates[0]++;
            }

            _animation.Increment("D");
        }
        else if (direction == "A")
        {
            if (_coordinates[0] > 1)
            {
                _coordinates[0]--;
            }
            
            _animation.Increment("A");
        }
    }

    public void Stand()
    {
        _animation.Increment("fall");
    }
    
    public virtual bool Punch(int aiXCoord)
    {
        if (_isPunching == false)
        {
            _isPunching = true;

            _isPunchingStartTime = DateTime.Now;
            _isPunchingEndTime = _isPunchingStartTime.AddSeconds(0.5);

            _animation.Increment("punch");

            if (_coordinates[0] == aiXCoord-4)
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

    public void StopPunch()
    {
        if (_isPunching == true & DateTime.Now > _isPunchingEndTime)
        {
            _isPunching = false;

            _animation.Increment("fall");
        }
    }

    public string GetFrame()
    {
        return _animation.GetFrame();
    }

    public int GetHealth()
    {
        return _health;
    }

    public int[] GetCoordinates()
    {
        return _coordinates;
    }

    public bool IsJumping()
    {
        return _isJumping;
    }

    public void LoseLife()
    {
        _health--;
    }
}