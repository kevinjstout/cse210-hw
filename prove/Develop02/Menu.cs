public class Menu
{
    public int _input;

    public bool _quit = true;

    public Entry _entry;

    public void DisplayAndPrompt()
    {
        Console.WriteLine("Hello. Please make a selection based on what you'd like to do. (Enter an integer.)");
        Console.WriteLine("1. Get prompt and respond.");
        Console.WriteLine("2. Open journal.");
        Console.WriteLine("3. Save (append) most recent prompt to journal.");
        Console.WriteLine("4. Quit");

        _input = int.Parse(Console.ReadLine());
    }

    public void ExecuteSelection()
    {
        if (_input == 1)
        {  
            string prompt = _entry.GeneratePrompt();

            _entry._prompt = prompt;
            Console.WriteLine(prompt);

            _entry._content = Console.ReadLine();
        }

        if (_input == 2)
        {
            Journal journal = new();
            
            Console.WriteLine("Please enter journal text file name (in this format: example.txt).");
            journal._fileName = Console.ReadLine();

            journal.Open();
        }

        if (_input == 3)
        {
            Journal journal = new();
            
            Console.WriteLine("Please enter journal text file name (in this format: example.txt) to save the entry to.");
            journal._fileName = Console.ReadLine();
            
            journal._currentEntry = _entry.PrettyText();
            journal.Save();

            Console.WriteLine($"Most recent entry successfully saved to {journal._fileName}.");
        }

        if (_input == 4)
        {
            Console.WriteLine("Thanks for stopping by!");
            _quit = true;
        }
    }
}