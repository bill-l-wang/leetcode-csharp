namespace LeetCode.String
{
    /// <summary>
    /// https://leetcode.com/problems/implement-strstr/description/
    /// Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
    /// Example 1: Input: haystack = "hello", needle = "ll" Output: 2
    /// Example 2: Input: haystack = "aaaaa", needle = "bba" Output: -1
    /// </summary>
    public class NeedleInHaystack
    {
        public int StrStr(string haystack, string needle)
        {
            for (var i = 0; ; i++)
            {
                for (var j = 0;; j++)
                {
                    if (j == needle.Length)
                        return i;

                    if (i + j == haystack.Length)
                        return -1;

                    if (needle.Substring(j, 1) != haystack.Substring(i + j, 1))
                        break;
                }
            }
        }
    }
}
