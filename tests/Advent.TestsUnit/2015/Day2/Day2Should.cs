using Shouldly;

namespace Advent.TestsUnit.Day2;

public class Day2Should
{
    [Theory]
    [InlineData("2x3x4", 58)]
    [InlineData("1x1x10", 43)]
    public void return_correct_result_for_part1(string input, int expected)
    {
        Y2015.Day2.Day2.Part1(input).ShouldBe(expected);
    }

    [Fact]
    public void return_correct_result_for_part1_with_real_data()
    {
        Y2015.Day2.Day2.Part1(Y2015.Day2.Input.Day2Data).ShouldBe(1598415);
    }

    [Theory]
    [InlineData("2x3x4", 34)]
    [InlineData("1x1x10", 14)]
    public void return_correct_result_for_part2(string input, int expected)
    {
        Y2015.Day2.Day2.Part2(input).ShouldBe(expected);
    }

    [Fact]
    public void return_correct_result_for_part2_with_real_data()
    {
        Y2015.Day2.Day2.Part2(Y2015.Day2.Input.Day2Data).ShouldBe(3812909);
    }
}
