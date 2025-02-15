using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("3 Nephi", 3, 7,
                                            "Or in other words, yield yourselves up unto us, and unite with us"
                                            + " and become acquainted with our secret works, and become our brethren that ye"
                                            + " may be like unto us —not our slaves, but our brethren and partners of all our" 
                                            + " substance.");
        
        bool startingSequence = true;
        int inputNumber = 1;
        while (startingSequence)
        {
            try 
            {
                Console.WriteLine("How many words would you like hidden at a time? ");
                
                inputNumber = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine($"Got it. {inputNumber} words will be deleted each iteration. Press enter to begin.");
                string input = Console.ReadLine();

                startingSequence = false;
            }
            catch
            {
                Console.WriteLine("Not a valid response.");
            }
        }
        
        bool quit = false;

        while (quit == false)
        {
            scripture.Display();

            Console.WriteLine();
            Console.WriteLine("Press enter to proceed (delete words). Type \"quit\" to exit. ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                quit = true;
            }

            if (scripture.GetRemainingWordCount() != 0)
            {
                scripture.Iterate(inputNumber);
            }
            else
            {
                quit = true;

                Console.WriteLine();
                Console.WriteLine("That's all, good job!");
            }

        }
    }
}