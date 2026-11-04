namespace Advent.Day1;

public static class Solve
{
    private static IEnumerable<int> Steps(string input) => input.Select(c => c == '(' ? 1 : -1);

    public static int Part1(string input) => Steps(input).Sum();

    public static int Part2(string input) => Enumerable.Repeat(0, 1)
        .SelectMany(floor => Steps(input).Select((step, index) => (floor: floor += step, position: index + 1)))
        .FirstOrDefault(x => x.floor == -1, (floor: 0, position: -1))
        .position;
}
