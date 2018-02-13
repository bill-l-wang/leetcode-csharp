using System;
using System.Collections.Generic;

namespace LeetCode.String
{
    /// <summary>
    /// https://leetcode.com/problems/longest-valid-parentheses/description/
    /// Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring
    /// For "(()", the longest valid parentheses substring is "()", which has length = 2
    /// Another example is ")()())", where the longest valid parentheses substring is "()()", which has length = 4
    /// for example:     ( ) ) ( ( ( ) )
    /// the index is: -1 0 1 2 3 4 5 6 7
    /// after calculation, there is no matched parentheses for the index 2,3 )(
    /// matched: Math.Max(maxans, i - stack.Peek()) 7-3 = 4
    /// </summary>
    public class Parentheses
    {
        public int LongestValidParentheses(string s)
        {
            var maxans = 0;
            var stack = new Stack<int>();
            stack.Push(-1);

            for (var i = 0; i < s.Length; i++)
            {
                if (s.Substring(i, 1) == "(")
                {
                    stack.Push(i);
                }
                else
                {
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        stack.Push(i);
                    }
                    else
                    {
                        maxans = Math.Max(maxans, i - stack.Peek());
                    }
                }
            }

            return maxans;
        }
    }
}
