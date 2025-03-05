using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("blue", 2);
        Circle c = new Circle("red", 2);
        Rectangle r = new Rectangle("yellow", 4, 8);

        List<Shape> list = new List<Shape> {s, c, r};

        foreach (Shape shape in list)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}