using System;
using LeetCode.Array;
using Xunit;

namespace LeetCode.Tests.Array
{
    public class TwoSumTest
    {
        private const string InvalidArgumentMessage = "No two sum solution";

        [Theory]
        [InlineData(new[] {2, 7, 11, 15}, 9, new[] {0, 1})]
        public void Given_an_array_when_sum_succeed_then_return_indices_can_added_up_to_target(
            int[] nums, int target, int[] expected)
        {
            var solution = new TwoSum();
            var actual = solution.Sum(nums, target);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 8)]
        public void Given_an_array_when_can_not_find_indices_then_should_throw(int[] nums, int target)
        {
            var solution = new TwoSum();
            var exception = Assert.Throws<ArgumentException>(() => solution.Sum(nums, target));
            Assert.Equal(InvalidArgumentMessage, exception.Message);
        }
    }
}
