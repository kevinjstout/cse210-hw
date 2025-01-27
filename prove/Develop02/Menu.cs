public class Menu
{
    //public List<string> _selection; - do i even need this?
    public int _input;


    public int DisplayAndPrompt()
    {
        Console.WriteLine("Hello. Please make a selection based on what you'd like to do. (Enter an integer.)");
        Console.WriteLine("1. Get prompt.");
        Console.WriteLine("2. Open journal.");
        Console.WriteLine("3. Save prompt.");

        int selection = int.Parse(Console.ReadLine());
        return selection;
    }

    public void ExecuteSelection()
    {
        if (_input == 1)
        {
            //call entry to generate and return string
        }

        if (_input == 2)
        {
            //call file, get text, print
        }

        if (_input == 3)
        {
            //call journal class to save current prompt
        }
    }
}