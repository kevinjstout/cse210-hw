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
            Console.WriteLine();

            menu.ExecuteSelection();
        }
    }
}