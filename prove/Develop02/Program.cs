using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();

        Console.WriteLine
(@"
 ______    ___  ____   ___ ___  ____        ____   ___   __ __  ____   ____    ____  _     
|      |  /  _]|    \ |   |   ||    |      |    | /   \ |  |  ||    \ |    \  /    || |    
|      | /  [_ |  D  )| _   _ | |  | _____ |__  ||     ||  |  ||  D  )|  _  ||  o  || |    
|_|  |_||    _]|    / |  \_/  | |  ||     |__|  ||  O  ||  |  ||    / |  |  ||     || |___ 
  |  |  |   [_ |    \ |   |   | |  ||_____/  |  ||     ||  :  ||    \ |  |  ||  _  ||     |
  |  |  |     ||  .  \|   |   | |  |      \  `  ||     ||     ||  .  \|  |  ||  |  ||     |
  |__|  |_____||__|\_||___|___||____|      \____j \___/  \__,_||__|\_||__|__||__|__||_____|");

        while (menu._quit == false)
        {
            menu.DisplayAndPrompt();

            menu.ExecuteSelection();

            menu._input = 0;
        }

        /*
        Here is a list of functions that I added that go beyond the core requirements (though I hope just the first will suffice):

        - Added option to merge two journals.
            - This adds a method to the journal class, along with an option on the menu.
            - It takes one journal file, then another, and adds their contents together (in order given).
            - This new file is saved under a new prompted name.
        - Added cool visuals
            - Boxed in text 
            - Ascii title
        - General error handling to deal with invalid input so the program doesn't just crash.
        */
    }
}