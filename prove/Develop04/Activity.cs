using System.Diagnostics.Metrics;

class Activity
{
    protected string _name;

    protected string _description;

    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;

        _description = description;
    }

    public void Welcome()
    {
        Console.Clear();
        
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();

        Console.WriteLine(_description);
        Console.WriteLine();

        Console.WriteLine("How long (in seconds) would you like to do this activity?");
        
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Prepare to begin the activity.");

        Pause(3);

        Console.WriteLine();
    }

    public void Conclude()
    {
        Console.WriteLine();
        Console.WriteLine("You are done, good job.");

        Pause(2);
        
        Console.WriteLine();
        Console.WriteLine($"Thank you for completing the {_name}. You did this activity for {_duration} seconds.");

        Pause(3);

        Console.Clear();
    }

    public void Pause(int duration)
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(duration);

        List<string> frames = new List<string> {"|", "/", "—", "\\"};
        int counter = 0;

        while (currentTime < futureTime)
        {
            counter ++;

            Console.Write("\b" + frames[counter % 4]);
            
            Thread.Sleep(300);

            currentTime = DateTime.Now;
        }

        Console.Write("\b \b");
    }
}