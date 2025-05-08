namespace SlothWeeklyNoYelling;

public class SolutionTest
{
    [Theory]
    [InlineData("What went wrong?????????", "What went wrong?")]
    [InlineData("Oh my goodness!!!", "Oh my goodness!")]
    [InlineData("I just!!! can!!! not!!! believe!!! it!!!", "I just!!! can!!! not!!! believe!!! it!")]
    [InlineData("Oh my goodness!", "Oh my goodness!")]
    [InlineData("Oh my.", "Oh my.")]
    public void Solution_NoYelling_ReturnsExpectedResult(string input, string expectedResult)
    {
        Assert.Equal(expectedResult, Solution.NoYelling(input));
    }
}
