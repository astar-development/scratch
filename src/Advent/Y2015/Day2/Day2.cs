namespace Advent.Y2015.Day2;

public static class Day2
{
    private static IEnumerable<(int,int,int)> Steps(string input)
    {
        var data = input.Split("\n");
        var dimensions = data.Select(l => l.Split("x").Select(int.Parse).ToArray());

        foreach (var d in dimensions)
        {
            yield return (d[0], d[1], d[2]);
        }
    }

    public static int Part1(string input)
    {
        var total = 0;
        foreach (var (l, w, h) in Steps(input))
        {
            var sides = new[] { 2*l*w , 2*w*h, 2*h*l };
            var slack = sides.Min()/2;
            total += sides.Sum() + slack;
        }

        return total;
    }

    public static int Part2(string input) => input.Split("\n").Select(l => l.Split("x").Select(int.Parse).ToArray()).Select(d => 2 * (d.Sum() - d.Max()) + d.Aggregate(1, (a, b) => a * b)).Sum();
}