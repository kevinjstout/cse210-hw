using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("Please input an integer corresponding to your choice:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();

            if (choice == "1") // BREATHING ACTIVITY
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your 
                                                                  + "through breathing in and out slowly. Clear your mind"
                                                                  + "and focus on your breathing.");
            }

            else if (choice == "2") // REFLECTION ACTIVITY
            {

            }

            else if (choice == "3") // LISTING ACTIVITY
            {

            }

            else if (choice == "4") // QUIT
            {
                running = false;
            }

            else
            {
                Console.WriteLine("Not a valid choice try again.");
            }

        }
        
    }
}