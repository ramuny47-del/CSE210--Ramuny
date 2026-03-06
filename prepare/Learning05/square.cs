using System.Reflection.Metadata.Ecma335;

public class Square : Shape 
{
    private double _side;
    public Square(double side, string color) : base(color) {
        _side = side;
    }

    public override double getArea()
    {
        return _side * _side;
    }
}