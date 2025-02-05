using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        
        Fraction f2 = new Fraction(2);

        Fraction f3 = new Fraction(2, 3);

        f3.SetNumerator(5);
        f3.SetDenominator(9);

        f1.SetNumerator(6);
        f1.SetDenominator(7);

        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());

        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());

        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f1.GetFractionString());
    }
}