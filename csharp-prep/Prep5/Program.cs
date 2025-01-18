using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static float PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            float number = float.Parse(Console.ReadLine());

            return number;
        }

        static float SquareNumber(float n)
        {
            return n*n;
        }

        static void DisplayResult(string name, float square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }


        DisplayWelcome();

        string name = PromptUserName();
        float number = PromptUserNumber();

        float square = SquareNumber(number);
        
        DisplayResult(name, square);

    
    }
}