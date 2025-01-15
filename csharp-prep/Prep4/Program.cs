using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        float input = -1;

        List<float> list = new List<float>();

        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                list.Add(input);
            }
        }

        float sum = 0;
        foreach (float i in list)
        {
            sum += i;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = sum / (list.Count);
        Console.WriteLine($"The average is: {average}");

        float largest = list[0];
        foreach (float i in list)
        {
            if (i >= largest)
            {
                largest = i;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

    }
}