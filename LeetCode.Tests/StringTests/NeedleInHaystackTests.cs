using LeetCode.String;
using Xunit;

namespace LeetCode.Tests.StringTests
{
    public class NeedleInHaystackTests
    {
        [Theory]
        [InlineData("hello", "ll", 2)]
        [InlineData("aaaaa", "bba", -1)]
        public void Given_a_needle_when_strstr_then_get_index_of_the_first_occurrence(
            string hayStack,
            string needle,
            int expected)
        {
            var solution = new NeedleInHaystack();
            var result = solution.StrStr(hayStack, needle);
            Assert.Equal(expected, result);
        }
    }
}
