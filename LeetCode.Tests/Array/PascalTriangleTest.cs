using System.Collections.Generic;
using LeetCode.Array;
using Xunit;

namespace LeetCode.Tests.Array
{
    public class PascalTriangleTest
    {
        private const int Number = 5;
        private readonly List<List<int>> _triangle = new List<List<int>>
        {
            new List<int> {1},
            new List<int> {1, 1},
            new List<int> {1, 2, 1},
            new List<int> {1, 3, 3, 1},
            new List<int> {1, 4, 6, 4, 1}
        };

        [Fact]
        public void Given_a_number_of_rows_when_generate_then_should_constructed_as_pascal_triangle()
        {
            var solution = new PascalTriangleSolution();
            var result = solution.Generate(Number);
            Assert.Equal(_triangle, result);
        }
    }
}
