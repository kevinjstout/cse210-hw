using System.Reflection;

public class Player
{
    protected int _health;

    protected Animation _animation;

    protected int[] _coordinates;

    public Player(Animation animation, int[] coordinates)
    {
        _coordinates = coordinates;

        _health = 3;

        _animation = animation;
    }
    
    public void Jump()
    {

    }

    public void Walk(string direction)
    {
        if (direction == "D")
        {
            _coordinates[0]++;
        }
        else if (direction == "A")
        {
            _coordinates[0]--;
        }
    }

    public void Punch()
    {

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
}