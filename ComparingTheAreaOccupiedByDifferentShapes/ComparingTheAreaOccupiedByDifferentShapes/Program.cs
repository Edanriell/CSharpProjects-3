using RectangleClass;
using CircleClass;
using SolutionClass;

string compare1 = Solution.Solve(new Rectangle[0], new Circle[0]);
string compare2 = Solution.Solve(new[] { new Rectangle(1, 5) }, new Circle[0]);
string compare3 = Solution.Solve(new Rectangle[0], new[] { new Circle(1) });
string compare4 = Solution.Solve(
    new[] { new Rectangle(5.0, 2.1), new Rectangle(3, 3) },
    new[] { new Circle(1), new Circle(10) }
);

WriteLine(
    $"compare1 is {compare1}, "
        + $"compare2 is {compare2}, "
        + $"compare3 is {compare3}, "
        + $"compare4 is {compare4}."
);
