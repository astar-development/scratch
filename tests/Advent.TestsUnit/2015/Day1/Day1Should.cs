namespace Advent.TestsUnit.Day1;

public class Day1Should
{
    [Theory]
    [InlineData("(())", 0)]
    [InlineData("()()", 0)]
    [InlineData("(((", 3)]
    [InlineData("(()(()(", 3)]
    [InlineData("))(((((", 3)]
    [InlineData("())", -1)]
    [InlineData("))(", -1)]
    [InlineData(")))", -3)]
    [InlineData(")())())", -3)]
    public void return_correct_result_for_part1_test_data(string input, int expected)
    {
        Y2015.Day1.NotQuiteLisp.Part1(input).ShouldBe(expected);
    }

    [Fact]
    public void return_correct_result_for_part1()
    {
        Y2015.Day1.NotQuiteLisp.Part1(Y2015.Day1.Input.Day1Data).ShouldBe(280);
    }

    [Fact]
    public void return_correct_result_for_part2()
    {
        Y2015.Day1.NotQuiteLisp.Part2(Y2015.Day1.Input.Day1Data).ShouldBe(1797);
    }
}
