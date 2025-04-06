using System;

class Program
{
    static void Main(string[] args)
    {
        StartingMenu startingMenu = new StartingMenu();
        
        try
        {
            while (startingMenu.IsQuit() == false)
            {
                Screen screen = new Screen();

                List<string> walkingFrames = new List<string> {"1",
                                                        """
                                                         O 
                                                        /|\
                                                        / \
                                                        """,
                                                        """
                                                         O 
                                                        /|\
                                                        / >
                                                        """,
                                                        """
                                                         O 
                                                        /|\
                                                         >\
                                                        """,
                                                        """
                                                         O 
                                                        /|\
                                                        < \
                                                        """,
                                                        """
                                                         O 
                                                        /|\
                                                        /<
                                                        """
                                                    };
                List<string> jumpingFrames = new List<string> {"1",
                                                        """
                                                         O 
                                                        /|V
                                                        / >
                                                        """
                                                        };
                List<string> punchingFrames = new List<string> {"1",
                                                        """
                                                         O 
                                                        <|--
                                                        / \
                                                        """
                                                        };
                int[] coordinates = {3, 6};
                Animation playerAnimation = new Animation(walkingFrames, jumpingFrames, punchingFrames);
                Player player = new Player(playerAnimation, coordinates);

                
                List<string> aiWalkingFrames = new List<string> {"1",
                                                        """
                                                        [X] 
                                                        /|\
                                                        / \
                                                        """,
                                                        """
                                                        [X]  
                                                        /|\
                                                        / >
                                                        """,
                                                        """
                                                        [X]  
                                                        /|\
                                                         >\
                                                        """,
                                                        """
                                                        [X]  
                                                        /|\
                                                        < \
                                                        """,
                                                        """
                                                        [X]  
                                                        /|\
                                                        /<
                                                        """
                                                    };
                List<string> aiJumpingFrames = new List<string> {"1",
                                                        """
                                                        [X]  
                                                        V|\
                                                        / >
                                                        """
                                                        };
                List<string> aiPunchingFrames = new List<string> {"1",
                                                        """
                                                        [X]  
                                                       --|>
                                                        / \
                                                       """
                                                        };
                int[] aiCoordinates = {50, 6};
                Animation aiAnimation = new Animation(aiWalkingFrames, aiJumpingFrames, aiPunchingFrames);
                AI ai = new AI(aiAnimation, aiCoordinates);
                
                
                
                Game game = new Game(player, ai, screen, 3, 3);

                DeathMenu deathMenu = new DeathMenu();
    
                startingMenu.Display("nothing to write here");

                if (startingMenu.IsQuit() == false)
                {   
                    game.Countdown();

                    while (game.GetLoser() == "no one")
                    {
                        game.Run();
                    }

                    game.Run();

                    deathMenu.Display(game.GetLoser());
                }
            }
            Console.Clear();
            Console.WriteLine("""
                    
                   ___________.__                   __                 _____                __________.__                .__                
            [X]    \__    ___/|  |__ _____    ____ |  | __  ______   _/ ____\___________    \______   \  | _____  ___.__.|__| ____    ____  
           --|>      |    |   |  |  \\__  \  /    \|  |/ / /  ___/   \   __\/  _ \_  __ \    |     ___/  | \__  \<   |  ||  |/    \  / ___\ 
            < \      |    |   |   Y  \/ __ \|   |  \    <  \___ \     |  | (  <_> )  | \/    |    |   |  |__/ __ \\___  ||  |   |  \/ /_/  >
                     |____|   |___|  (____  /___|  /__|_ \/____  >    |__|  \____/|__|       |____|   |____(____  / ____||__|___|  /\___  / 
                                   \/     \/     \/     \/     \/                                               \/\/             \//_____/  

           """);
        }
        catch
        {
            startingMenu.Quit();
            
            startingMenu.Fail();
        }
    }    
}