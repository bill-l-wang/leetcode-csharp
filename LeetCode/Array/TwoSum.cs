using System;
using System.Linq;

namespace LeetCode.Array
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/description/
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice
    /// Given nums = [2, 7, 11, 15], target = 9,
    /// Because nums[0] + nums[1] = 2 + 7 = 9,
    /// return [0, 1].
    /// </summary>
    public class TwoSum
    {
        public int[] Sum(int[] nums, int target)
        {
            var dic = nums.Select((value, index) => new {value, index})
                .ToDictionary(num => num.value, num => num.index);

            for(var i= 0; i< nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dic.ContainsKey(complement) && dic[complement] != i)
                {
                    return new[] {i, dic[complement]};
                }
            }

            throw new ArgumentException("No two sum solution");
        }
    }
}
