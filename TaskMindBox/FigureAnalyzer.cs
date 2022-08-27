using TaskMindBox.Figures;

namespace TaskMindBox;

public static class FigureAnalyzer
{
    /// <summary>
    /// Нахождение площади фигуры
    /// </summary>
    /// <param name="countRound">Количество знаков для округления результата</param>
    /// <param name="figureParams">Массив параметров фигуры</param>
    /// <returns>Площадь фигуры</returns>
    /// <exception cref="Exception">Фигуры с заданным кол-вом пораметров не найдено</exception>
    public static double GetSquareSomeFigure(int countRound, params double[] figureParams)
    {
        ISquarable figure;

        var length = figureParams.Length;
        
        switch (length)
        {
            case 1: figure = new Circle(figureParams[0]);
                break;
            case 3: figure = new Triangle(figureParams[0], figureParams[1], figureParams[2]);
                break;
            default:
                throw new Exception($"Not found figure with {length} params!");
        }
        
        var square =  figure.GetSquare();

        return Math.Round(square, countRound);
    }

    /// <summary>
    /// Определяет, является ли треугольник равнобедренным
    /// </summary>
    /// <param name="aSide"></param>
    /// <param name="bSide"></param>
    /// <param name="cSide"></param>
    /// <returns></returns>
    public static bool CheckTriangleIsRectangular(double aSide, double bSide, double cSide)
    {
        Triangle triangle = new Triangle(aSide, bSide, cSide);

        return triangle.CheckTriangleIsRectangular();
    }
}