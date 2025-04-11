public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // The override method in use
    public override double GetArea()
    {
        return _side * _side;
    }
}
