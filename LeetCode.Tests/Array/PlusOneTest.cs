using System.Linq;
using LeetCode.Array;
using Xunit;

namespace LeetCode.Tests.Array
{
    public class PlusOneTest
    {
        private readonly int[] _carriedArray = { 9, 9, 9, 9 };
        private readonly int[] _unCarriedArray = { 1, 2, 3, 4 };

        private readonly int[] _carriedAfterPlus = { 1, 0, 0, 0, 0 };
        private readonly int[] _unCarriedAfterPlus = { 1, 2, 3, 5 };

        [Fact]
        public void Given_an_array_when_plueone_then_the_value_shouldbe_added()
        {
            var solution = new PlusOneSolution();
            var lengthChanged = solution.PlusOne(_carriedArray).ToArray();
            Assert.Equal(_carriedAfterPlus, lengthChanged);

            var lengthUnchanged = solution.PlusOne(_unCarriedArray).ToArray();
            Assert.Equal(_unCarriedAfterPlus, lengthUnchanged);
        }
    }
}
