// Create a function that transforms sentences ending with multiple question marks ? or
// exclamation marks ! into a sentence only ending with one without changing punctuation
// in the middle of the sentences.

namespace SlothWeeklyNoYelling;

static class Solution
{
    public static string NoYelling(string input)
    {
        char[] marks = ['!', '?'];
        if (!marks.Contains(input[^1])) return input;
        for (int i = 1; i <= input.Length; i++)
            if (!marks.Contains(input[^i])) return input[..^(i-2)];
        return input;
    }
}