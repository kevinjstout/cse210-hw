using System;

class Program1
{
    static void Main1(string[] args)
    {
        List<string> frames = new List<string> {
                                                """
                                                 O 
                                                /|\
                                                 >\
                                                """,
                                                """
                                                 O 
                                                /|\
                                                / >
                                                """
                                               };

        static void PrintAt(int x, int y, string text)
        {
            string[] lines = text.Split(new[] { '\n' });
            for (int i = 0; i < lines.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(lines[i]);
            }
        }

        int x = 2;
        int y = 2;
        int f = 0;

        while (true)
        {
            DateTime now = DateTime.Now;
            int seconds = now.Second;

            if (seconds % 2 == 0)
            {
                f = 0;
            }
            else
            {
                f = 1;
            }
            
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.D)
                {
                    x++;
                }
                else if (keyInfo.Key == ConsoleKey.A)
                {
                    x--;
                }
            }

            Console.Clear();
            PrintAt(x, y, frames[f]);
            Thread.Sleep(200);
        }
        
        
    }
}