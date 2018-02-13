using System.Linq;
using LeetCode.Array;
using Xunit;

namespace LeetCode.Tests.Array
{
    public class PlusOneTest
    {
        [Theory]
        [InlineData(new [] { 9, 9, 9, 9 }, new[]{ 1, 0, 0, 0, 0 })]
        [InlineData(new [] { 1, 2, 3, 4 }, new[]{ 1, 2, 3, 5 })]
        public void Given_an_array_when_plus_one_then_the_value_should_be_added(
            int[] inputArray, int[] expected)
        {
            var solution = new PlusOne();
            var actual = solution.Plus(inputArray).ToArray();
            Assert.Equal(expected, actual);
        }
    }
}
