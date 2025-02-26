class Activity
{
    protected string _name;

    protected string _description;

    protected int _duration;

    private DateTime _startTime;

    public Activity(string name, string description)
    {
        _name = name;

        _description = description;
    }

    public void Welcome()
    {

    }

    public void Conclude()
    {

    }

    public void Pause(int duration)
    {

    }
}