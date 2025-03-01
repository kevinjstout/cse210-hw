namespace Develop04;
using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        int activitiesCompleted = 0;
        DateTime startTime = DateTime.Now;

        Console.WriteLine("Before we begin, please enter a goal in minutes for how long you would like to use this program.");
        Console.WriteLine("This goal will be displayed in your session info section, for your own personal use.");
        Console.WriteLine();
        Console.Write("> ");

        float goalInMinutes = float.Parse(Console.ReadLine());

        Console.Clear();
        
        while (running)
        {
            Console.WriteLine("Please input an integer corresponding to your choice:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Get session info.");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("> ");

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

                activitiesCompleted++;
            }

            else if (choice == "2") // REFLECTION ACTIVITY
            {
                List<string> experiences = new List<string> {"Think of a time when you stood up for someone else.",
                                                             "Think of a time when you did something really difficult.",
                                                             "Think of a time when you helped someone in need.",
                                                             "Think of a time when you did something truly selfless."};

                List<string> promptsAboutExperiences = new List<string> {"Why was this experience meaningful to you?",
                                                                         "Have you ever done anything like this before?",
                                                                         "How did you get started?",
                                                                         "How did you feel when it was complete?",
                                                                         "What made this time different than other times when you were not as successful?",
                                                                         "What is your favorite thing about this experience?",
                                                                         "What could you learn from this experience that applies to other situations?",
                                                                         "What did you learn about yourself through this experience?",
                                                                         "How can you keep this experience in mind in the future?"};
                
                ReflectionActivity activity = new ReflectionActivity("Reflection Activity",
                                                                      "This activity will help you reflect on times in your "
                                                                      + "life when you have shown strength and resilience. "
                                                                      + "This will help you recognize the power you have and "
                                                                      + "how you can use it in other aspects of your life.",
                                                                      experiences, promptsAboutExperiences);
                
                activity.Welcome();

                activity.Reflect();

                activity.Conclude();

                activitiesCompleted++;
            }

            else if (choice == "3") // LISTING ACTIVITY
            {
                List<string> questions = new List<string> {"Who are people that you appreciate?",
                                                           "What are personal strengths of yours?",
                                                           "Who are people that you have helped this week?",
                                                           "When have you felt the Holy Ghost this month?",
                                                           "Who are some of your personal heroes?"};
                
                ListingActivity activity = new ListingActivity("Listing Activity",
                                                                "This activity will help you reflect on the good " +
                                                                "things in your life by having you list as many things as you can in a certain area.",
                                                                questions);
                
                activity.Welcome();

                activity.List();

                activity.Conclude();

                activitiesCompleted++;
            }

            else if (choice == "4") // GET SESSION INFO
            {
                Console.Clear();
                
                DateTime goalTime = startTime.AddMinutes(goalInMinutes);
                
                Console.WriteLine($"In this session, you have completed {activitiesCompleted} activities.");
                Console.WriteLine($"Date and time session started: {startTime}");
                Console.WriteLine($"Date and time of session length goal: {goalTime}");                
                Console.WriteLine();
                Console.WriteLine("Please press enter to exit session info mode.");
                Console.ReadLine();
                Console.Clear();
            }

            else if (choice == "5") // QUIT
            {
                running = false;
            }

            else
            {
                Console.WriteLine("Not a valid choice, please try again. (Press enter to continue.)");
                Console.ReadLine();
                Console.Clear();
            }

        }
        
    }
}