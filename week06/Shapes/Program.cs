using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square square = new Square("Red",5);
        Rectangle rectangle = new Rectangle("Blue",4, 6);
        Circle circle = new Circle("Green",3);

        Console.WriteLine($"Square  color: {square.GetColor()}, area: {square.GetArea()}");
        Console.WriteLine($"Rectangle color: {rectangle.GetColor()}, area: {rectangle.GetArea()}");
        Console.WriteLine($"Circle  color: {circle.GetColor()}, area: {circle.GetArea()}");


        List<Shape> shapes = new List<Shape> { square, rectangle, circle };
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine("\nAll shapes in the list:");


        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");

        }
        

    }
}
