using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string percentString = Console.ReadLine();
        int percent = int.Parse(percentString);

        string letter;

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You've passed, you should feel proud!");
        }
        else
        {
            Console.WriteLine("You failed. You can get it next time, we believe in you!");
        }

    }
}