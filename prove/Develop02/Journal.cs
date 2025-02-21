public class Journal
{
    public string _fileName;

    public List<Entry> _entries = new List<Entry>();

    public void Open()
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(_fileName);

            _entries = new List<Entry>();

            foreach (string line in lines)
            {
                Console.WriteLine(line);


                List<string> splitByDashPrompt = line.Split(" - Prompt: ").ToList();

                string date = splitByDashPrompt[0];

                List<string> splitByCommaEntry = splitByDashPrompt[1].Split(", Entry: ").ToList();

                string prompt = splitByCommaEntry[0];

                string content = splitByCommaEntry[1];
                
                Entry entry = new Entry();
                entry._date = date;
                entry._prompt = prompt;
                entry._content = content;

                _entries.Add(entry);
            }
        }
        catch
        {
            Console.WriteLine("Something went wrong while trying to open your file.");
            Console.WriteLine("You may have inputed an incorrect name, a file you don't have access to, or something else.");
            Console.WriteLine("Please try again.");
        }
    }
    public void Save()
    {
        try
        {   
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.PrettyText());
                }
            }
        }
        catch
        {
            Console.WriteLine("Something went wrong. Make sure your input and settings are valid. Please try again.");
        }
    }

    public void Merge(string firstJournal, string secondJournal, string mergedJournalName)
    {
        
        try
        {
            string[] lines1 = System.IO.File.ReadAllLines(firstJournal);
                
            using (StreamWriter outputFile = new StreamWriter(mergedJournalName))
            {
                foreach (string line in lines1)
                {
                    outputFile.WriteLine(line);
                }
            };
                
            
            string[] lines2 = System.IO.File.ReadAllLines(secondJournal);

            using (StreamWriter outputFile = new StreamWriter(mergedJournalName, true))
            {
                foreach (string line in lines2)
                {
                    outputFile.WriteLine(line);
                }
            };

        }
        catch
        {
            Console.WriteLine("Sorry, something went wrong. Please check that your files exist, that you have permission to access them,");
            Console.WriteLine("and try again.");
        }        
    }
}