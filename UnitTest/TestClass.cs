using NUnit.Framework;
using TaskMindBox;

namespace UnitTest;

[TestFixture]
public class TestClass
{
    [TestCase(1, 5)]
    public void GetCircleSquareTest(int countRound, double radius)
    {
        var square = FigureAnalyzer.GetSquareSomeFigure(countRound, radius);
        
        Assert.AreEqual(78.5, square);
    }

    [TestCase(1, new double[]{ 3, 4, 5 })]
    public void GetTriangleSquareTest(int countRound, params double[] figureParams)
    {
        var square = FigureAnalyzer.GetSquareSomeFigure(countRound, figureParams);
        
        Assert.AreEqual(6, square);
    }
    
    [TestCase(3, 4 , 5)]
    public void TriangleIsRectangularTest(double aSide, double bSide, double cSide)
    {
        var result = FigureAnalyzer.CheckTriangleIsRectangular(aSide, bSide, cSide);
        
        Assert.IsTrue(result);
    }
    
    [TestCase(3, 4 , 6)]
    public void TriangleIsNotRectangularTest(double aSide, double bSide, double cSide)
    {
        var result = FigureAnalyzer.CheckTriangleIsRectangular(aSide, bSide, cSide);
        
        Assert.IsFalse(result);
    }
}