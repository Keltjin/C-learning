using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 4);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("red", 5, 4);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("yellow", 8);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
    }
}