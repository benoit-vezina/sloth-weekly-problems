// Given an array of 10 numbers, return whether or not the array is shuffled enough.

// In this case, if 3 or more numbers appear consecutively (ascending or descending), return false.

namespace SlothWeekly250508;

static class Solution
{
    // Simply increment a counter every time the difference with the last element is 
    // 1 or -1. If we wanted to find the the longuest not-shuffled sequence, we would
    // implement the Sliding Window technique.
    // We assume that the numbers parameter is always an array of numbers from 1 to 10
    // arranged in a random order
    public static bool IsShuffledWell(int[] numbers)
    {
        int lastNumber = numbers[0];
        int consecutiveNumberCount = 1;

        foreach (int number in numbers)
        {
            if (Math.Abs(number - lastNumber) == 1)
            {
                if (++consecutiveNumberCount == 3) return false;
            }
            else consecutiveNumberCount = 1;
            lastNumber = number;
        }

        return true;
    }
}