using System.ComponentModel.Design;
using System.Net.Mime;

public class Entry
{
    public string _content;

    public string _prompt;

    public string _date;

    public string PrettyText()
    {
        DateTime currentTime = DateTime.Now;
        _date = currentTime.ToShortDateString();

        return $"{_date} - Prompt: {_prompt}, Entry: {_content}";
    }

    public string GeneratePrompt()
    {
        List<string> prompts = new List<string> {
            "What went well today?",
            "What went poorly today?",
            "What is your opinion on the history of the Judeo-Christian moral framework's effects on our governing bodies?",
            "What about today do you want to make sure you don't forget?",
            "What's your favorit animal?",
            "Start your entry with these words \"Although I wouldn't do that today, if...\"",
            "What would you do with a million dollars?",
            "What would you change about yourself if you could become anything or anyone in the world?",
            "Who or what made you smile today?"
        };

        Random rnd = new Random();
        int selection = rnd.Next(1, 10);

        return prompts[selection];
    }
}