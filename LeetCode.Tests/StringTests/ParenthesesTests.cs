using LeetCode.String;
using Xunit;

namespace LeetCode.Tests.StringTests
{
    public class ParenthesesTests
    {
        [Theory]
        [InlineData("(()",2)]
        [InlineData("(()()", 4)]
        [InlineData(")()())", 4)]
        [InlineData("())((())", 4)]
        public void Given_a_string_when_retrieve_then_return_the_length_of_the_longest_valid_parentheses(
            string s, int expected)
        {
            var soution = new Parentheses();
            var result = soution.LongestValidParentheses(s);
            Assert.Equal(expected, result);
        }
    }
}
