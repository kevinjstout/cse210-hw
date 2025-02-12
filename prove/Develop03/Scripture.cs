public class Scripture
{
    private Reference _reference;

    private List<Word> _scripture = new List<Word>();

    private List<int> _remainingWords = new List<int>();

    public Scripture(Reference reference, string text)
    {
        Reference _reference = reference;

        List<string> textSplitBySpaces = new List<string>(text.Split(" "));

    }

    public void Display()
    {
        Console.Clear();
    }

    public void RemoveWord()
    {

    }

}
