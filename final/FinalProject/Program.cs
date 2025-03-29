using System;

class Program
{
    static void Main(string[] args)
    {
        Screen screen = new Screen();

        List<string> frames = new List<string> {"1",
                                                """
                                                 O 
                                                /|\
                                                / \
                                                """,
                                                """
                                                 O 
                                                /|\
                                                / >
                                                """
                                               };
        int[] coordinates = {2, 8};

        Animation animation = new Animation(frames, frames, frames);
        
        Player player = new Player(animation, coordinates);

        Player ai = new AI(animation, coordinates);
        
        Game game = new Game(player, ai, screen, 3, 3);

        StartingMenu startingMenu = new StartingMenu();

        while (startingMenu.IsRunning() == true)
        {
            startingMenu.Display();
        }
        
        while (true)
        {
            game.Run();
        }
    }    
}