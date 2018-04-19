using LeetCode.String;
using Xunit;

namespace LeetCode.Tests.StringTests
{
    public class LongestPalindromeTests
    {
        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        public void Given_a_string_when_find_longest_palindromic_then_return_substirng_in_given_string(string s, string expected)
        {
            var solution = new PalindromicSubstring();
            var actual = solution.LongestPalindrome(s);
            Assert.Equal(expected, actual);
        }
    }
}
