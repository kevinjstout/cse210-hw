public class DeathMenu : Menu
{
    public override void Display(string loser)
    {
        Console.SetCursorPosition(0,10);

        if (loser == "ai")
        {
            Console.WriteLine("""        
                                __________.__                               __      __.__              ._.
                                \______   \  | _____  ___.__. ___________  /  \    /  \__| ____   _____| |
                                 |     ___/  | \__  \<   |  |/ __ \_  __ \ \   \/\/   /  |/    \ /  ___/ |
                                 |    |   |  |__/ __ \\___  \  ___/|  | \/  \        /|  |   |  \\___ \ \|
                                 |____|   |____(____  / ____|\___  >__|      \__/\  / |__|___|  /____  >__
                                                    \/\/         \/               \/          \/     \/ \/

                              """);
        }
        else
        {
            Console.WriteLine("""
                                _____  .___   __      __.__              ._.
                               /  _  \ |   | /  \    /  \__| ____   _____| |
                              /  /_\  \|   | \   \/\/   /  |/    \ /  ___/ |
                             /    |    \   |  \        /|  |   |  \\___ \ \|
                             \____|__  /___|   \__/\  / |__|___|  /____  >__
                                     \/             \/          \/     \/ \/

                             """);
        }

        Console.WriteLine();
        Console.Write("Press Enter to Return to the Menu: ");
        Console.ReadLine();

        Console.Clear();
    }
}