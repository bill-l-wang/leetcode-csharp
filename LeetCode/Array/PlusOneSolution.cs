using System.Linq;

namespace LeetCode.Array
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one/description/
    /// Given a non-negative integer represented as a non-empty array of digits, plus one to the integer.
    /// You may assume the integer do not contain any leading zero, except the number 0 itself.
    /// The digits are stored such that the most significant digit is at the head of the list.
    /// [1, 2, 3, 4] represents integer 1234, add one to 1234(the length of array not changed), you get 1235. 
    /// but [9, 9, 9, 9] represents 9999, add one to 9999, you get 10000(the length of array changed)
    /// </summary>
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            var carryValue = 1;
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                var sum = carryValue + digits[i];
                carryValue = sum / 10;
                digits[i] = sum % 10;
            }

            return carryValue > 0
                ? new[] {1}.Concat(digits).ToArray()
                : digits;
        }
    }
}
