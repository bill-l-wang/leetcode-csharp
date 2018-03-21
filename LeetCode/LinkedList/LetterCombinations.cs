using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
    /// Given a digit string, return all possible letter combinations that the number could represent.
    /// A mapping of digit to letters (just like on the telephone buttons) is given below.
    /// Input:Digit string "23"
    /// Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
    /// </summary>
    public class LetterCombinations
    {
        public IEnumerable<string> Combine(string digites)
        {
            if(string.IsNullOrEmpty(digites))
                return Enumerable.Empty<string>();

            var letters = new[] {"0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
            var numbers = digites.ToCharArray();
            var results = new Queue<string>();
            results.Enqueue("");

            for (var i = 0; i < numbers.Length; i++)
            {
                var buttonLetters = letters[(int) char.GetNumericValue(numbers[i])].ToCharArray();
                while (results.Peek().Length == i)
                {
                    var row = results.Dequeue();
                    foreach (var letter in buttonLetters)
                    {
                        results.Enqueue(row + letter);
                    }
                }
            }

            return results;
        }
    }
}
