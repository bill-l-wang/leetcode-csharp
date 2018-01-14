namespace LeetCode.Array
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array/description/
    /// Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array
    /// You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.
    /// The number of elements initialized in nums1 and nums2 are m and n respectively
    /// </summary>
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            while (n > 0)
            {
                if (m == 0 || nums2[n - 1] > nums1[m - 1])
                {
                    nums1[m + n - 1] = nums2[--n];
                }
                else
                {
                    nums2[m + n - 1] = nums1[--m];
                }
            }
        }
    }
}
