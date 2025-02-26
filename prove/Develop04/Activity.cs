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
        Console.WriteLine($"Welcome to the {_name}. {_description} How long would you like to do this activity?");

        _duration = int.Parse(Console.ReadLine());

        Pause(3)
    }

    public void Conclude()
    {
        Console.WriteLine($"You are done. Thank you for doing the {_name}.");
    }

    public void Pause(int duration)
    {
        // Whenever the application pauses it should show some kind 
        // of animation to the user, such as a spinner, a countdown timer, 
        // or periods being displayed to the screen.
    }
}