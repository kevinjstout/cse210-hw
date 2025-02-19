public class Journal
{
    public string _fileName;

    public List<Entry> _entries = new List<Entry>();

    public void Open()
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(_fileName);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
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

                foreach (string line in lines1)
                {
                    using (StreamWriter outputFile = new StreamWriter(mergedJournalName))
                    {
                        outputFile.WriteLine(line);
                    };
                }
            
            string[] lines2 = System.IO.File.ReadAllLines(secondJournal);

                foreach (string line in lines2)
                {
                    using (StreamWriter outputFile = new StreamWriter(mergedJournalName, true))
                    {
                        outputFile.WriteLine(line);
                    };
                }
        }
        catch
        {
            Console.WriteLine("Sorry, something went wrong. Please check that your files exist, that you have permission to access them,");
            Console.WriteLine("and try again.");
        }        
    }
}