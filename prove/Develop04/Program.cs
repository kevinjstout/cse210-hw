namespace Develop04;
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
                BreathingActivity activity = new BreathingActivity("Breathing Activity", 
                                                                    "This activity will help you relax by walking your" 
                                                                    + "through breathing in and out slowly. Clear your mind"
                                                                    + "and focus on your breathing.");

                activity.Welcome();

                activity.Breathe();

                activity.Conclude();


            }

            else if (choice == "2") // REFLECTION ACTIVITY
            {
                List<string> experiences = new List<string> {};
                List<string> promptsAboutExperiences = new List<string> {};
                
                ReflectionActivity activity = new ReflectionActivity("Reflection Activity",
                                                                      "This activity will help you reflect on times in your"
                                                                      + "life when you have shown strength and resilience."
                                                                      + "This will help you recognize the power you have and"
                                                                      + "how you can use it in other aspects of your life.",
                                                                      experiences, prompts)
                
                activity.Welcome();

                activity.Reflect();

                activity.Conclude();
            }

            else if (choice == "3") // LISTING ACTIVITY
            {
                activity.Welcome();

                activity.Breathe();

                activity.Conclude();
            }

            else if (choice == "4") // QUIT
            {
                running = false;
            }

            else
            {
                Console.WriteLine("Not a valid choice, please try again.");
            }

        }
        
    }
}