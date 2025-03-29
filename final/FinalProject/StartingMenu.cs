public class StartingMenu : Menu
{
    public override void Display()
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

        Console.Write("Right now, all you can do is use A and D to move.");
        Console.Write("Press Enter to being: ");
        Console.ReadLine();

        base._isRunning = false;
    }
}