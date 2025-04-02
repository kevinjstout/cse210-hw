public class Game
{
    private Player _player;

    private AI _ai;

    private Screen _screen;

    private string _loser = "no one";

    public Game(Player player, AI ai, Screen screen, int playerHealth, int _aiHealth)
    {
        _player = player;

        _ai = ai;

        _screen = screen;
    }
    
    public void Countdown()
    {
        Console.Clear();
        Console.WriteLine("""
                        ________
                        \_____  \ 
                          _(__  < 
                         /       \
                        /______  /
                               \/ 
                        """);
        Thread.Sleep(1000);

        Console.Clear();
        Console.WriteLine("""       
                        ________  
                        \_____  \ 
                         /  ____/ 
                        /       \ 
                        \_______ \
                                \/ 
                        """);
        Thread.Sleep(1000);

        Console.Clear();
        Console.WriteLine("""
                         ____ 
                        /_   |
                         |   |
                         |   |
                         |___|
                        """);
        Thread.Sleep(1000);

        Console.Clear();
        Console.WriteLine("""
                        
                         ________ ________ ._.
                        /  _____/ \_____  \| |
                       /   \  ___  /   |   \ |
                       \    \_\  \/    |    \|
                        \______  /\_______  /_
                               \/         \/\/

                       """);
        Thread.Sleep(500);
    }
    
    public void Run()
    {
        Console.Clear();
        _screen.DisplayStats(_player.GetHealth(), _ai.GetHealth());
        _screen.DisplayPlayer(_player);
        _screen.DisplayPlayer(_ai);

        // PLAYER STUFF
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.D)
            {
                _player.Walk("D", _ai.GetCoordinates()[0]);
            }
            else if (keyInfo.Key == ConsoleKey.A)
            {
                _player.Walk("A", _ai.GetCoordinates()[0]);
            }
            else if (keyInfo.Key == ConsoleKey.W)
            {
                _player.Jump();
            }
            else if (keyInfo.Key == ConsoleKey.Q)
            {
                bool punch = _player.Punch(_ai.GetCoordinates()[0]);
                if (punch)
                {
                    if (_ai.GetHealth() > 1)
                    {
                        _ai.LoseLife();
                    }
                    else
                    {
                        _ai.LoseLife();
                        _loser = "ai";

                        _screen.DisplayStats(_player.GetHealth(), _ai.GetHealth());
                    }
                }
            }
        }
        else
        {
            DateTime now = DateTime.Now;
            int milliseconds = now.Millisecond;

            if (_player.IsJumping() == false)
            {
                if (milliseconds % 3 == 0)
                {
                    _player.Stand();
                }
            }
        }

        while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }

        _player.Fall();
        _player.StopPunch();

        // AI STUFF
        bool aiPunch = _ai.RandomAction(_player.GetCoordinates()[0]);
        if (aiPunch)
        {
            if (_player.GetHealth() > 1)
                    {
                        _player.LoseLife();
                    }
                    else
                    {
                        _player.LoseLife();
                        _loser = "player";

                        _screen.DisplayStats(_player.GetHealth(), _ai.GetHealth());
                    }
        }


        // Finishing stuff
        Console.SetCursorPosition(0,0);
        Thread.Sleep(50);
    }

    public string GetLoser()
    {
        return _loser;
    }

}