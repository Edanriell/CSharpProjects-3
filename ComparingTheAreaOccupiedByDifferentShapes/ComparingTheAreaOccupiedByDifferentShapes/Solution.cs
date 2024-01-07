using CircleClass;
using RectangleClass;

namespace SolutionClass;

public static class Solution
{
    public const string Equal = "equal";
    public const string Rectangular = "rectangular";
    public const string Circular = "circular";

    public static string Solve(Rectangle[] rectangularSection, Circle[] circularSection)
    {
        var totalAreaOfRectangles = CalculateTotalAreaOfRectangles(rectangularSection);
        var totalAreaOfCircles = CalculateTotalAreaOfCircles(circularSection);

        return GetBigger(totalAreaOfRectangles, totalAreaOfCircles);
    }

    private static double CalculateTotalAreaOfRectangles(Rectangle[] rectangularSection)
    {
        double totalAreaOfRectangles = 0;

        foreach (var rectangle in rectangularSection)
        {
            totalAreaOfRectangles += rectangle.Area;
        }

        return totalAreaOfRectangles;
    }

    private static double CalculateTotalAreaOfCircles(Circle[] circularSection)
    {
        double totalAreaOfCircles = 0;

        foreach (var circle in circularSection)
        {
            totalAreaOfCircles += circle.Area;
        }

        return totalAreaOfCircles;
    }

    private static string GetBigger(double totalAreaOfRectangles, double totalAreaOfCircles)
    {
        const double margin = 0.01;

        bool areAlmostEqual = Math.Abs(totalAreaOfRectangles - totalAreaOfCircles) <= margin;

        if (areAlmostEqual)
        {
            return Equal;
        }
        else if (totalAreaOfRectangles > totalAreaOfCircles)
        {
            return Rectangular;
        }
        else
        {
            return Circular;
        }
    }
}
