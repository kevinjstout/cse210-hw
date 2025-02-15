using System.ComponentModel;

public class Word
{
    private int _length;

    private string _word;

    private bool _isHidden = false;

    public Word(int length, string word)
    {
        _length = length;

        _word = word;
    }

    public string GetWord()
    {
        if (_isHidden == false)
        {
            return _word;
        }
        else
        {
            string empty = "";

            for (int i = 0; i < _length; i++)
            {
                empty = empty + "_";
            }

            return empty;
        }
    }

    public void SetHidden()
    {
        _isHidden = true;
    }
}
