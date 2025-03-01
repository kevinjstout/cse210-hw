class ListingActivity : Activity
{
    private List<string> _prompts;

    private int _listCounter;

    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;

        _listCounter = 0;
    }

    public void List()
    {
        Random random = new();
        int selection = random.Next(5);

        string prompt = _prompts[selection];

        Console.WriteLine(prompt);

        Console.WriteLine("Think about this prompt.");
        
        int count = 5;
        while (count >= 0)
        {
            Console.Write("\b" + count);
            count --;

            Thread.Sleep(1000);
        }
        Console.Write("\b \b");

        Console.WriteLine();
        Console.WriteLine("Now, list as many items as you can think of in the allotted time. Your time begins now.");

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);

        while (currentTime < futureTime)
        {   
            Console.WriteLine();
            Console.Write("> ");
            Console.ReadLine();

            _listCounter++;

            currentTime = DateTime.Now;
        }

        Console.WriteLine();
        Console.WriteLine($"Your time is up. You listed {_listCounter} items.");
    }
}