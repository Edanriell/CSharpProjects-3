var isEnough1 = Solution.IsEnough(0, new IShape[0]);
var isEnough2 = Solution.IsEnough(1, new[] { new Rectangle(1, 1) });
var isEnough3 = Solution.IsEnough(100, new IShape[] { new Circle(5) });
var isEnough4 = Solution.IsEnough(
    5,
    new IShape[] { new Rectangle(1, 1), new Circle(1), new Rectangle(1.4, 1) }
);

WriteLine(
    $"IsEnough1 = {isEnough1}, "
        + $"IsEnough2 = {isEnough2}, "
        + $"IsEnough3 = {isEnough3}, "
        + $"IsEnough4 = {isEnough4}."
);
