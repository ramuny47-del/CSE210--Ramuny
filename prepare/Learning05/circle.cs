public class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color): base(color)
    {
        _radius = radius;

    }

    public override double getArea()
    {
        return 3.14 * _radius * _radius;
    }
}