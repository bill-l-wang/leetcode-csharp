using System.Collections.Generic;
using LeetCode.Array;
using Xunit;

namespace LeetCode.Tests.Array
{
    public class ThreeSumTest
    {
        private readonly int[] _numbers = {-1, 0, 1, 2, -1, -4};
        private readonly List<List<int>> _expected = new List<List<int>>
        {
            new List<int> {-1, -1, 2},
            new List<int> {-1, 0, 1}
        };

        [Fact]
        public void Given_an_array_when_call_three_sum_then_return_all_unique_triplets_that_sum_is_zero()
        {
            var solution = new ThreeSum();
            var result = solution.Sum(_numbers);
            Assert.Equal(_expected, result);
        }
    }
}
