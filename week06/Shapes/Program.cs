using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(4,"red");
        // quare1.GetAre());Console.WriteLine(s
        // Console.WriteLine(square1.GetColor());
        // // square1.Display();

        Rectangle rectangle1 = new Rectangle(8, 5,"blue");

        Circles circles1 = new Circles(8,"black");

        List<Shape> shapes = new List <Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circles1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The color is {shape.GetColor()}, and his area is {shape.GetAre()}");
        }
    }
}