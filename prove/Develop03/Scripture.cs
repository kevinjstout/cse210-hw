using System.ComponentModel;

public class Scripture
{
    private Reference _reference;

    private List<Word> _verseText = new List<Word>();

    private List<int> _remainingWordsIndices = new List<int>();

    // Constructer with an ending verse.
    public Scripture(string book, int chapter, int startingVerse, int endingVerse, string text)
    {
        _reference = new Reference(book, chapter, startingVerse, endingVerse);

        List<string> textSplitBySpaces = new List<string>(text.Split(" "));

        int remainingWordsIndex = 0;
        
        foreach (string word in textSplitBySpaces)
        {
            Word objectVersionOfWord = new Word(word.Length, word);

            _verseText.Add(objectVersionOfWord);

            _remainingWordsIndices.Add(remainingWordsIndex);

            remainingWordsIndex++;
        }
    }

    // Constructer without an ending verse.
    public Scripture(string book, int chapter, int startingVerse, string text)
    {
        _reference = new Reference(book, chapter, startingVerse);

        List<string> textSplitBySpaces = new List<string>(text.Split(" "));

        int remainingWordsIndex = 0;
        
        foreach (string word in textSplitBySpaces)
        {
            Word objectVersionOfWord = new Word(word.Length, word);

            _verseText.Add(objectVersionOfWord);


            _remainingWordsIndices.Add(remainingWordsIndex);

            remainingWordsIndex++;
        }
    }

    public void Display()
    {
        Console.Clear();

        string text = "";

        int wrapLineCounter = 0;

        Console.Write(_reference.GetFull());

        foreach (Word word in _verseText)
        {
            text = text + $" {word.GetWord()}";

            wrapLineCounter++;
            if (wrapLineCounter == 24)
            {
                Console.WriteLine(text);

                wrapLineCounter = 0;

                text = "";
            }
        }
    }

    public void RemoveWord()
    {
        Random rand = new Random();

        int indexIndex = rand.Next(0, _remainingWordsIndices.Count);

        int wordIndex = _remainingWordsIndices[indexIndex];

        _verseText[wordIndex].SetHidden();

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