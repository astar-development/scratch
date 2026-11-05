namespace Advent.Y2015.Day3;

public class Day3Should
{
    [Theory]
    [InlineData(">", 2)]
    [InlineData("^>v<", 4)]
    [InlineData("^v^v^v^v^v", 2)]
    public void return_correct_result_for_part1(string input, int expected)
    {
        PerfectlySphericalHousesInAVacuum.Part1(input).ShouldBe(expected);
    }

    [Fact]
    public void return_correct_result_for_part1_with_real_data()
    {
        PerfectlySphericalHousesInAVacuum.Part1(Input.Day3Data).ShouldBe(2565);
    }

    [Fact]
    public void return_correct_result_for_part2_with_real_data()
    {
        PerfectlySphericalHousesInAVacuum.Part2(Input.Day3Data).ShouldBe(2639);
    }
}