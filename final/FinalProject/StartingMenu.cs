public class StartingMenu : Menu
{
    public override void Display(string loser)
    {
        string menuText = 
                        """
                                __________                   ___              ___
                                \__    ___/__________  _____ |__| ____ _____  |  |  
                                  |    |_/ __ \_  __ \/     \|  |/    \\__  \ |  |  
                                  |    |\  ___/|  | \/  Y Y  \  |   |  \/ __ \|  |__
                                  |____| \___  >__|  |__|_|  /__|___|  (____  /____/
                                             \/            \/        \/     \/       
                        ___________                  .__               __                
                        \__    ___/__________  _____ |__| ____ _____ _/  |_  ___________ 
                          |    |_/ __ \_  __ \/     \|  |/    \\__  \\   __\/  _ \_  __ \
                          |    |\  ___/|  | \/  Y Y  \  |   |  \/ __ \|  | (  <_> )  | \/
                          |____| \___  >__|  |__|_|  /__|___|  (____  /__|  \____/|__|   
                                     \/            \/        \/     \/                   

                        """;                                              


        string[] lines = menuText.Split("\n");
        for (int i = 0; i < lines.Length; i++)
        {
            int[] coords = {5,3};
            
            Console.SetCursorPosition(coords[0], coords[1]+i);

            Console.Write(lines[i]);
        }

        Console.WriteLine();
        
        Console.WriteLine("           INSTRUCTIONS");
        Console.WriteLine("           Press A, W, and D to move. Press Q to punch.");
        Console.WriteLine("           You have 3 lives. Defeat the AI by punching him 3 times, ");
        Console.WriteLine("           while evading his own punches.");

        Console.WriteLine();

        Console.Write("           Press Enter to begin, or type \"Q\" to quit: ");
        string input = Console.ReadLine();

        if (input == "Q")
        {
            _isQuit = true;
        }
    }
}