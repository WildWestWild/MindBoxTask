namespace TaskMindBox.Figures;

internal class Circle: ISquarable
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetSquare() => Math.PI * Math.Pow(_radius, 2);
}