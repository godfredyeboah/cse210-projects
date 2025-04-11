using System;

class Program
{
    static void Main(string[] args)
    {
       // List of shapes
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 4);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 6);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 5);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // All shapes have a GetColor method from the base class
            string color = s.GetColor();

            // All shapes have a GetArea method, but with different behaviors.
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}