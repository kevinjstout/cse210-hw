using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        bool unguessed = true;
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        while (unguessed)
        {
            Console.Write("What is your guess? ");
            float guess = float.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
                unguessed = false;
            }
        }

    }
}