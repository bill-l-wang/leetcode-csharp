using Xunit;
using LeetCode.String;

namespace LeetCode.Tests.StringTests
{
    public class FindTheDifferenceTests
    {
        [Theory]
        [InlineData("abcd", "abcde", 'e')]
        public void Given_two_consist_string_when_click_find_then_return_the_letter_was_added(string s, string t, char expected)
        {
            var solution = new FindTheDifference();
            var actual = solution.FindDifference(s, t);
            Assert.Equal(expected, actual);
        }
    }
}
