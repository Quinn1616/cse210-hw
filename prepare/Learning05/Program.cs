using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Square square = new Square("blue", 4.0);
        Console.Write($"{square.GetArea()} - ");
        Console.WriteLine(square.GetColor());

        Rectangle rectangle = new Rectangle("red", 3.0, 4.0);
        Console.Write($"{rectangle.GetArea()} - ");
        Console.WriteLine(rectangle.GetColor());

        Circle circle = new Circle("green", 2.0);
        Console.Write($"{circle.GetArea()} - " );
        Console.WriteLine(circle.GetColor());
        */

        List<Shape> shapes = new List<Shape>();
        
        shapes.Add(new Square("blue", 4.0));
        shapes.Add(new Rectangle("red", 3.0, 4.0));
        shapes.Add(new Circle("green", 2.0));

        foreach(Shape shape in shapes)
        {
            double shapeArea = shape.GetArea();
            string shapeColor = shape.GetColor();
            Console.WriteLine($"{shapeArea} - {shapeColor}");
        }
        
    }
}