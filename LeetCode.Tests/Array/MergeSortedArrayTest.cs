using LeetCode.Array;
using Xunit;

namespace LeetCode.Tests.Array
{
    public class MergeSortedArrayTest
    {
        private readonly int[] _numbersFirst = new int[9];
        private readonly int[] _numbersSecond = {2, 3, 4, 5};
        private readonly int[] _expected = {2, 3, 3, 4, 5, 5, 6, 7, 8};

        public MergeSortedArrayTest()
        {
            _numbersFirst[0] = 3;
            _numbersFirst[1] = 5;
            _numbersFirst[2] = 6;
            _numbersFirst[3] = 7;
            _numbersFirst[4] = 8;
        }

        [Fact]
        public void Given_two_sorted_array_when_merge_then_should_be_merged_as_one_sorted_array()
        {
            var solution = new MergeSortedArray();
            solution.Merge(_numbersFirst, 5, _numbersSecond, 4);
            Assert.Equal(_numbersFirst, _expected);
        }
    }
}
