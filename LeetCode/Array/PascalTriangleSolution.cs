using System.Collections.Generic;

namespace LeetCode.Array
{
    /// <summary>
    /// https://leetcode.com/problems/pascals-triangle/description/
    /// Given numRows, generate the first numRows of Pascal's triangle.
    /// For example, given numRows = 5,Return
    /// [
    ///    [1],
    ///    [1,1],
    ///   [1,2,1],
    ///  [1,3,3,1],
    /// [1,4,6,4,1]
    /// ]
    /// </summary>
    public class PascalTriangleSolution
    {
        public IList<List<int>> Generate(int numRows)
        {
            var triangleRows = new List<List<int>> {new List<int> {1}};

            for (var i = 1; i < numRows; i++)
            {
                var currentRowItems = new List<int> {1};
                var previousRowItems = triangleRows[i - 1];

                for (var j = 1; j < previousRowItems.Count; j++)
                {
                    currentRowItems.Add(previousRowItems[j - 1] + previousRowItems[j]);
                }

                currentRowItems.Add(1);
                triangleRows.Add(currentRowItems);
            }

            return triangleRows;
        }
    }
}
