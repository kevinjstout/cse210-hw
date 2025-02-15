using System;

class Program
{
    static void Main(string[] args)
    {
        //// Thing I've done to exceed requirements:
        // 
        // - As suggested in the assignment, I wrote code to make sure that one word isn't deleted twice.
        //        - This was done by creating a remaining word index list, and selecting from the indices instead of the words themselves, removing the index and
        //          associated word when hiding a word.
        // - I also created an initial set-up environment for the user to choose how many words they want to have removed each iteration.
        //        - This works for any integer they input, even if it is greater than the number of words in the full verse.
        // - Error handling.
        
        
        // Initializes scripture.
        Scripture scripture = new Scripture("1 Nephi", 1, 1, 3, // 1 Nephi 1:1-3
                                                "I, Nephi, having been born of goodly parents, therefore I was taught somewhat "
                                                + "in all the learning of my father; and having seen many afflictions in the course "
                                                + "of my days, nevertheless, having been highly favored of the Lord in all my days; "
                                                + "yea, having had a great knowledge of the goodness and the mysteries of God, therefore "
                                                + "I make a record of my proceedings in my days. "
                                                
                                                + "Yea, I make a record in the language of my father, which consists of the learning "
                                                + "of the Jews and the language of the Egyptian. "
                                                
                                                + "And I know that the record which I make is true; and I make it with mine own hand; "
                                                + "and I make it according to my knowledge. ");

        // Initially prompts user for how many words should be deleted.
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
        
        // MAIN LOOP
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

            // Iterates through and removes words (and checks to make sure there are enough words to remove)
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