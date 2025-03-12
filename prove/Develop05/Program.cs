using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        
        while (quit == false)
        {
            List<Goal> goals = new List<Goal>();

            int points = 0;
            
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Input the number corresponding to your desired action:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write(">> ");
            string input = Console.ReadLine();
            Console.WriteLine();

            if (input == "1")
            {
                
            }
            else if (input == "2")
            {

            }
            else if (input == "3")
            {
                
            }
            else if (input == "4")
            {
                
            }
            else if (input == "5")
            {
                
            }
            else if (input == "6")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}