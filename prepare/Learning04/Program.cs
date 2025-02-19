using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment test = new("John Homeworkdoer", "Fractions", "Section 42", "18-19");

        Console.WriteLine(test.GetSummary());

        Console.WriteLine(test.GetHomeworkList());


    
        WritingAssignment test2 = new("John Homeworkdoer", "Fractions", "the revolution of spaghetti");

        Console.WriteLine(test2.GetSummary());

        Console.WriteLine(test2.GetWritingInformation());
    }
}