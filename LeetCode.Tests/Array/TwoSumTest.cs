using System;
using LeetCode.Array;
using Xunit;

namespace LeetCode.Tests.Array
{
    public class TwoSumTest
    {
        private const int Target = 9;
        private const int UnExpectedTarget = 8;
        private const string InvalidArgumentMessage = "No two sum solution";
        private readonly int[] _nums = {2, 7, 11, 15};
        private readonly int[] _expected = {0, 1};

        [Fact]
        public void Given_an_array_when_sum_succeed_then_return_indices_can_added_up_to_target()
        {
            var solution = new TwoSum();
            var result = solution.Sum(_nums, Target);
            Assert.Equal(_expected, result);
        }

        [Fact]
        public void Given_an_array_when_can_not_find_indices_then_should_throw()
        {
            var solution = new TwoSum();
            var exception = Assert.Throws<ArgumentException>(() => solution.Sum(_nums, UnExpectedTarget));
            Assert.Equal(InvalidArgumentMessage, exception.Message);
        }
    }
}
