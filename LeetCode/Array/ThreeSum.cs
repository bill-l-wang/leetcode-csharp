using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array
{
    /// <summary>
    /// https://leetcode.com/problems/3sum/description/
    /// Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0?
    /// Find all unique triplets in the array which gives the sum of zero
    /// Note: The solution set must not contain duplicate triplets
    /// For example, given array S = [-1, 0, 1, 2, -1, -4],
    /// A solution set is:
    /// [
    ///  [-1, 0, 1],
    ///  [-1, -1, 2]
    /// ]
    /// </summary>
    public class ThreeSum
    {
        public List<List<int>> Sum(int[] nums)
        {
            nums = nums.OrderBy(n => n).ToArray();
            var results = new List<List<int>>();
            for (var i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                {
                    int low = i + 1, high = nums.Length - 1, sum = 0 - nums[i];

                    while (low < high)
                    {
                        if (nums[low] + nums[high] == sum)
                        {
                            results.Add(new List<int> {nums[i], nums[low], nums[high]});
                            while (low < high && nums[low] == nums[low + 1]) // skip equal elements to avoid duplicates
                            {
                                low++;
                            }
                            while (low < high && nums[high] == nums[high - 1])
                            {
                                high--;
                            }
                            low++;
                            high--;
                        }
                        else if (nums[low] + nums[high] < sum)
                        {
                            while (low < high && nums[low] == nums[low + 1])
                            {
                                low++;
                            }
                            low++;
                        }
                        else
                        {
                            while (low < high && nums[high] == nums[high - 1])
                            {
                                high--;
                            }
                            high--;
                        }
                    }
                }
            }

            return results;
        }

        public List<List<int>> Sums(int[] nums)
        {
            var numbers = nums.OrderBy(n => n).ToArray();
            var numberPairs = numbers.Select((value, index) => new {index, value}).ToArray();

            var results = new List<List<int>>();
            for (var i = 0; i < numbers.Length - 2; i++)
            {
                if (i > 0 && numbers[i] == numbers[i - 1]) i++;

                var j = i + 1;
                while (j < numbers.Length)
                {
                    var complement = 0 - numbers[i] - numbers[j];

                    if (numberPairs.Any(d => d.value == complement && d.index > j))
                    {
                        results.Add(new List<int> { numbers[i], numbers[j], complement });
                    }
                    j++;
                }
            }
            return results;
        }
    }
}
