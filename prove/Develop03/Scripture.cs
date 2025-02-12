public class Scripture
{
    private Reference _reference;

    private List<Word> _scripture = new List<Word>();

    private List<int> _remainingWords = new List<int>();

    public Scripture(Reference reference, string text)
    {


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
