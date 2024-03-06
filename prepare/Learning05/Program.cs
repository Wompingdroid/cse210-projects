using System;
using System.Runtime.InteropServices;
namespace Learning05;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square();
        Rectangle rectangle = new Rectangle();
        Circle circle = new Circle();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes){
            System.Console.WriteLine(shape.GetColor());
            System.Console.WriteLine(shape.GetArea());
        }
    }
}