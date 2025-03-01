class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    
    }

    public void Breathe()
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);

        while (currentTime < futureTime)
        {   
            Console.WriteLine("Breathe in...");
            Console.WriteLine();
            
            int count = 4;
            while (count >= 0)
            {
                Console.Write("\b" + count);
                count --;

                Thread.Sleep(1000);
            }
            Console.Write("\b \b");

            Console.WriteLine("Breathe out...");
            Console.WriteLine();
            
            count = 4;
            while (count >= 0)
            {
                Console.Write("\b" + count);
                count --;

                Thread.Sleep(1000);
            }
            Console.Write("\b \b");

            currentTime = DateTime.Now;
        }
    }
}