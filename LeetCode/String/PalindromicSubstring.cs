using System;

namespace LeetCode.String
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindromic-substring/description/
    /// Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
    /// Input: "babad" Output: "bab"; Input: "cbbd", Output: "bb"
    /// </summary>
    public class PalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            var start = 0;
            var end = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var len1 = ExpandAroundCenter(s, i, i);
                var len2 = ExpandAroundCenter(s, i, i + 1);
                var len = Math.Max(len1, len2);
                if (len > end - start + 1)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end - start + 1);
        }

        private static int ExpandAroundCenter(string s, int left, int right)
        {
            var l = left;
            var r = right;

            while (l >= 0 && r < s.Length && s.Substring(l, 1) == s.Substring(r, 1))
            {
                l--;
                r++;
            }

            return r - l - 1;
        }
    }
}
