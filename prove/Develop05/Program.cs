using System;
using System.IO;


class Program
{
    // ADDED FEATURES FOR FULL CREDIT
    /// - Added a counter to count how many goals you marked in the current session.
    /// - 
    
    static void Main(string[] args)
    {
        bool quit = false;

        List<Goal> goals = new List<Goal>();

        int points = 0;

        int goalsMarkedThisSession = 0;
        
        while (quit == false)
        {           
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine($"You have marked {goalsMarkedThisSession} goals this session.");
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
                Console.WriteLine("What type of goal would you like to create: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write(">> ");
                string goalTypeInt = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Great! Please input your goal's name. >> ");
                string goalName = Console.ReadLine();

                Console.Write("Goal description >> ");
                string goalDescription = Console.ReadLine();

                Console.Write("How many points would you like per marking of the goal? >> ");
                int pointsPerMark = int.Parse(Console.ReadLine());
                
                if (goalTypeInt == "1")
                {
                    SimpleGoal goal = new SimpleGoal(goalName, goalDescription, pointsPerMark, false);

                    goals.Add(goal);
                }
                else if (goalTypeInt == "2")
                {
                    EternalGoal goal = new EternalGoal(goalName, goalDescription, pointsPerMark, false);

                    goals.Add(goal);
                }
                else if (goalTypeInt == "3")
                {
                    Console.Write("How many points would you like when you complete the goal? >> ");
                    int pointsOnCompletion = int.Parse(Console.ReadLine());
                    
                    Console.Write("How many times would you like to complete this checklist goal? >> ");
                    int neededNumOfMarks = int.Parse(Console.ReadLine());

                    ChecklistGoal goal = new ChecklistGoal(goalName, goalDescription, pointsPerMark, false,
                                                           pointsOnCompletion, 0, neededNumOfMarks);

                    goals.Add(goal);
                }
                Console.WriteLine();
                Console.WriteLine("Your goal has been added.");
            }
            else if (input == "2")
            {
                int num = 0;
                
                foreach (Goal goal in goals)
                {
                    num++;
                    
                    Console.WriteLine($"{num}. {goal.PrettyText()}");
                }
            }
            else if (input == "3")
            {
                Console.Write("Please input file name to save to. >> ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(points);

                    foreach (Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.Save());
                    }
                }
            }
            else if (input == "4")
            {
                Console.Write("Please input file name to load from. >> ");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);

                points = int.Parse(lines[0]);
                goals = new List<Goal>();

                for (int i = 1; i<lines.Length; i++)
                {
                    string line = lines[i];
                    
                    string[] parts = line.Split("~~");

                    if (parts[0] == "SimpleGoal")
                    {         
                        SimpleGoal goal = new SimpleGoal(parts[2], parts[3], int.Parse(parts[4]), bool.Parse(parts[1]));

                        goals.Add(goal);
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        EternalGoal goal = new EternalGoal(parts[2], parts[3], int.Parse(parts[4]), bool.Parse(parts[1]));

                        goals.Add(goal);
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        ChecklistGoal goal = new ChecklistGoal(parts[2], parts[3], int.Parse(parts[4]), bool.Parse(parts[1]),
                                                               int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));

                        goals.Add(goal);
                    }
                }
            }
            else if (input == "5")
            {
                Console.WriteLine("Here are your goals, which one would you like to mark?");

                int num = 0;
                
                foreach (Goal goal in goals)
                {
                    num++;
                    
                    Console.WriteLine($"{num}. {goal.PrettyText()}");
                }
                
                Console.Write(">> ");
                int goalIndex = int.Parse(Console.ReadLine());

                if (goals[goalIndex-1].GetGoalStatus() == false)
                {
                    points += goals[goalIndex-1].Mark();

                    goalsMarkedThisSession++;
                }
                else
                {
                    Console.WriteLine("That goal is already marked complete, you can't do that.");
                }
            }
            else if (input == "6")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
            
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
        }
    }
}