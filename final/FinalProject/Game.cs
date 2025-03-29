public class Game
{
    private Player _player;

    private Player _ai;

    private Screen _screen;

    public Game(Player player, Player ai, Screen screen, int playerHealth, int _aiHealth)
    {
        _player = player;

        _screen = screen;
    }
    
    public void Run()
    {
        Console.Clear();
        _screen.DisplayPlayer(_player);

        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.D)
            {
                _player.Walk("D");
            }
            else if (keyInfo.Key == ConsoleKey.A)
            {
                _player.Walk("A");
            }
            else if (keyInfo.Key == ConsoleKey.W)
            {
                _player.Jump();
            }
        }

        while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }

        Console.SetCursorPosition(0,0);

        Thread.Sleep(50);
    }

}