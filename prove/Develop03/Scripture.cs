public class Scripture
{
    private Reference _reference;

    private List<Word> _scriptureText = new List<Word>();

    private List<int> _remainingWordsIndices = new List<int>();

    public Scripture(string book, int chapter, int startingVerse, int endingVerse, string text)
    {
        _reference = new Reference(book, chapter, startingVerse, endingVerse);

        List<string> textSplitBySpaces = new List<string>(text.Split(" "));

        int remainingWordsIndex = 0;
        
        foreach (string word in textSplitBySpaces)
        {
            Word objectVersionOfWord = new Word(word.Length, word);

            _scriptureText.Add(objectVersionOfWord);


            _remainingWordsIndices.Add(remainingWordsIndex);

            remainingWordsIndex++;
        }
    }

    public Scripture(string book, int chapter, int startingVerse, string text)
    {
        _reference = new Reference(book, chapter, startingVerse);

        List<string> textSplitBySpaces = new List<string>(text.Split(" "));

        int remainingWordsIndex = 0;
        
        foreach (string word in textSplitBySpaces)
        {
            Word objectVersionOfWord = new Word(word.Length, word);

            _scriptureText.Add(objectVersionOfWord);


            _remainingWordsIndices.Add(remainingWordsIndex);

            remainingWordsIndex++;
        }
    }

    public void Display()
    {
        Console.Clear();

        string text = "";
        foreach (Word word in _scriptureText)
        {
            text = text + $" {word.GetWord()}";
        }

        string scriptureString = $"{_reference.GetFull()} {text}";

        Console.WriteLine(scriptureString);
    }

    public void RemoveWord()
    {
        Random rand = new Random();

        int indexIndex = rand.Next(0, _remainingWordsIndices.Count);

        int wordIndex = _remainingWordsIndices[indexIndex];

        _scriptureText[wordIndex].SetHidden();

        _remainingWordsIndices.RemoveAt(indexIndex);
    }

    public int GetRemainingWordCount()
    {
        return _remainingWordsIndices.Count;
    }

    public void Iterate(int inputNumber)
    {
        if (GetRemainingWordCount() > inputNumber)
            {
                for (int i = 0; i < inputNumber; i++)
                {
                    RemoveWord();
                }
            }
        else
        {
            int count = GetRemainingWordCount();
            for (int i = 0; i < count; i++)
            {
                RemoveWord();
            }
        }
    }

}