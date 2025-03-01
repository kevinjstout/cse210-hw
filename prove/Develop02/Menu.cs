public class Menu
{
    public int _input;

    public bool _quit = false;

    public Journal _journal = new();

    public void DisplayAndPrompt()
    {
        Console.WriteLine(" ____________________________________________________________________________");
        Console.WriteLine("| Please make a selection based on what you'd like to do. (Enter an integer.)|");
        Console.WriteLine("| 1. Get prompt and respond.                                                 |");
        Console.WriteLine("| 2. Display current journal prompts and entries.                            |");
        Console.WriteLine("| 3. Open journal.                                                           |");
        Console.WriteLine("| 4. Save journal (replaces or creates a file).                              |");
        Console.WriteLine("| 5. Merge two (pre-existing) journals.                                      |");
        Console.WriteLine("| 6. Quit                                                                    |");
        Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.Write("Selection >> ");
        try
        {
            _input = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Not a valid selection.");
            Console.WriteLine();
        }
    }

    public void ExecuteSelection()
    {
        if (_input == 1)
        {  
            Entry entry = new();

            string prompt = entry.GeneratePrompt();

            entry._prompt = prompt;

            Console.WriteLine(prompt);

            Console.Write("Response >> ");
            entry._content = Console.ReadLine();

            _journal._entries.Add(entry);

            Console.WriteLine();
        }

        if (_input == 2)
        {
            foreach (Entry entry in _journal._entries)
            {
                Console.WriteLine(entry.PrettyText());
            }
        }

        if (_input == 3)
        {
            Console.WriteLine("Please enter journal text file name (in this format: example.txt).");
            Console.Write("Journal Name >> ");
            _journal._fileName = Console.ReadLine();
            Console.WriteLine();

            _journal.Open();

            Console.WriteLine();
        }

        if (_input == 4)
        {
            Console.WriteLine("Please enter journal text file name (in this format: example.txt) to save the entry to.");
            Console.Write("Journal Name >> ");
            _journal._fileName = Console.ReadLine();
            
            _journal.Save();

            Console.WriteLine($"Entries successfully saved to {_journal._fileName}.");
            Console.WriteLine();

        }

        if (_input == 5)
        {
            Console.WriteLine("Please enter first journal text file name (in this format: example.txt) to merge.");
            Console.Write("First Journal Name >> ");
            string firstJournal = Console.ReadLine();

            Console.WriteLine("Please enter second journal text file name (in this format: example.txt) to merge.");
            Console.Write("Second Journal Name >> ");
            string secondJournal = Console.ReadLine();

            Console.WriteLine("Please supply a name for the new, merged file (in this format: example.txt).");
            Console.Write("New Journal Name >> ");
            string mergedJournalName = Console.ReadLine();

            _journal.Merge(firstJournal, secondJournal, mergedJournalName);
        }

        if (_input == 6)
        {
            Console.WriteLine("Thanks for stopping by!");
            _quit = true;
        }

        if ((_input != 0) & (_input != 1) & (_input != 2) & (_input != 3) & (_input != 4) & (_input != 5) & (_input != 6))
        {
            Console.WriteLine("Not a valid response, please try something else.");
            Console.WriteLine();
        }
    }
}