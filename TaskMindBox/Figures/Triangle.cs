namespace TaskMindBox.Figures;

internal class Triangle: ISquarable
{
    private readonly double _aSide;
    
    private readonly double _bSide;
    
    private readonly double _cSide;

    public Triangle(double aSide, double bSide, double cSide)
    {
        _aSide = aSide;
        _bSide = bSide;
        _cSide = cSide;
    }

    public double GetSquare()
    {
        var p = (_aSide + _bSide + _cSide) / 2;

        var square = Math.Sqrt( p * (p - _aSide) * (p - _bSide) * (p - _cSide));

        return square;
    }

    public bool CheckTriangleIsRectangular()
    {
        List<double> figureSides = new List<double>{_aSide, _bSide, _cSide};
        var hypotenuse = figureSides.Max();
        figureSides.Remove(hypotenuse);

        var result = Math.Pow(hypotenuse, 2) - figureSides.Select(figureSide => Math.Pow(figureSide, 2)).Sum();

        return Math.Abs( result ) == 0;
    }
}