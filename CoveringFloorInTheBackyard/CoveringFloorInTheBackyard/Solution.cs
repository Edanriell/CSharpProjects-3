public static class Solution
{
    public static bool IsEnough(double mosaicArea, IShape[] tiles)
    {
        double totalArea = 0;
        foreach (var tile in tiles)
        {
            totalArea += tile.Area;
        }

        const double tolerance = 0.0001;
        return totalArea - mosaicArea >= -tolerance;
    }
}
