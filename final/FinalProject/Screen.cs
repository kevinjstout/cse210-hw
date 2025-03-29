using System.Security.Cryptography.X509Certificates;

public class Screen
{
    public void DisplayStats(int health, int aiHealth)
    {

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