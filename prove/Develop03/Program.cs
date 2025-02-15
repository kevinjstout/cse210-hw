using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("3 Nephi", 3, 7,
                                            "Or in other words, yield yourselves up unto us, and unite with us"
                                            + " and become acquainted with our secret works, and become our brethren that ye"
                                            + " may be like unto us—not our slaves, but our brethren and partners of all our" 
                                            + " substance.");
        
        bool quit = false;

        while (quit == false)
        {
            scripture.Display();

            Console.WriteLine("Press enter to proceed (delete words). Type \"quit\" to exit. ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                quit = true;
            }

            scripture.RemoveWord();
        }
    }
}