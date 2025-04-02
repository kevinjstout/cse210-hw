using System.Security.Cryptography.X509Certificates;

public class Screen
{
    public void DisplayStats(int health, int aiHealth)
    {
        Console.SetCursorPosition(3, 3);
        for(int i = 0; i < health; i++)
        {
            Console.Write("(O)");
        }
        for(int i = 0; i < 3-health; i++)
        {
            Console.Write("( )");
        }

        Console.SetCursorPosition(50, 3);
        for(int i = 0; i < aiHealth; i++)
        {
            Console.Write("(O)");
        }
        for(int i = 0; i < 3-aiHealth; i++)
        {
            Console.Write("( )");
        }
    }

    public void DisplayPlayer(Player player)
    {
        string[] lines = player.GetFrame().Split("\n");
        for (int i = 0; i < lines.Length; i++)
        {
            int[] coords = player.GetCoordinates();
            
            Console.SetCursorPosition(coords[0], coords[1]+i);

            Console.Write(lines[i]);
        }
    }
}