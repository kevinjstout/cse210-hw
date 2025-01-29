public class Journal
{
    public string _fileName;

    public string _currentEntry;

    public void Open()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(_currentEntry);
        }
    }
}