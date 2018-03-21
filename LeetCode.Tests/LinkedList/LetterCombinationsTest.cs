using LeetCode.LinkedList;
using Xunit;

namespace LeetCode.Tests.LinkedList
{
    public class LetterCombinationsTest
    {
        [Theory]
        [InlineData("23", new[]{ "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [InlineData("12", new[]{ "1a", "1b", "1c" })]
        public void Given_a_digit_string_when_combine_then_represent_a_mapping_of_letters(string digits, string[] expected)
        {
            var solution = new LetterCombinations();
            var results = solution.Combine(digits);
            Assert.Equal(expected, results);
        }
    }
}
