using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");


        List<Shape> shape = new List<Shape>();
        
        shape.Add(new Square(2, "red"));
        shape.Add(new Circle(14, "blue"));
        shape.Add(new Rectangle(12, 13, "green"));
    foreach (Shape item in shape)
        {
            Console.WriteLine(item.getArea());
        }

    }
}