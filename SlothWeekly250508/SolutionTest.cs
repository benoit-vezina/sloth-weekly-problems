namespace SlothWeekly250508;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[]{1, 2, 3, 5, 8, 6, 9, 10, 7, 4}, false)]
    [InlineData(new int[]{3, 5, 1, 9, 8, 7, 6, 4, 2, 10}, false)]
    [InlineData(new int[]{1, 5, 3, 8, 10, 2, 7, 6, 4, 9}, true)]
    [InlineData(new int[]{1, 3, 5, 7, 9, 2, 4, 6, 8, 10}, true)]
    [InlineData(new int[]{10, 8, 9, 7, 5, 4, 6, 3, 2, 1}, false)]
    public void Solution_IsShuffledWell_ReturnsExpectedOutput(int[] numbers, bool expectedOutput)
    {
        Assert.Equal(Solution.IsShuffledWell(numbers), expectedOutput);
    }
}
