class ReflectionActivity : Activity
{
    private List<string> _experiences;

    private List<string> _promptsAboutExp;

    public ReflectionActivity(string name, string description, List<string> experiences, List<string> promptsAboutExperiences) : base(name, description)
    {
        _experiences = experiences;

        _promptsAboutExp = promptsAboutExperiences;
    }

    public void Reflect()
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);

        Random random = new();
        int selection = random.Next(4);

        string experience = _experiences[selection];

        Console.WriteLine();
        Console.WriteLine(experience);
        Pause(4);

        Console.WriteLine();
        Console.WriteLine("Reflect on the following questions that relate to this experience. Your time begins now.");
        
        while (currentTime < futureTime)
        {
            selection = random.Next(9);
            string question = _promptsAboutExp[selection];

            Console.WriteLine("> " + question);
            Pause(3);

            currentTime = DateTime.Now;
        }
    }
}